﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Content.Pipeline;

namespace NeuroRighter
{
    ///<author>John Rolston</author>
    sealed internal class GridGraph : GraphicsDeviceControl
    {
        private float minX = 0F;
        private float maxX = 1F;
        private float minY = 0F;
        private float maxY = 1F;
        private float dX = 1F;
        private float dY = 1F;
        private float xScale;
        private float yScale;

        private int numRows;
        private int numCols;
        private int numSamplesPerPlot;
        private bool _isSpikeWaveformPlot;
        internal bool isSpikeWaveformPlot
        {
            get { return _isSpikeWaveformPlot; }
        }


        private Color gridColor = Color.White;

        BasicEffect effect;
        //VertexDeclaration vDec;
        List<VertexPositionColor[]> lines; //Lines to be plotted
        List<VertexPositionColor[]> threshlines1; // threshold lines to be plotted
        List<VertexPositionColor[]> threshlines2; // -threshold lines to be plotted
        List<VertexPositionColor[]> gridLines; //Grid lines
        short[] idx; //Index to points in 'lines'
        private static readonly short[] gridIdx = { 0, 1 }; //Index to points in gridLines

        //Constants for text rendering
        private ContentManager content;
        private SpriteBatch spriteBatch;
        private SpriteFont font;
        private Dictionary<int, Vector2> channelNumberLocations;
        private Dictionary<int, String> channelNumberText;
        private String voltageTimeLabel;
        private double displayGain = 1;
        private double voltageRange; //in volts
        private double timeRange; //in seconds
        private Vector2 voltageTimeLabelCoords;

        private const int NUM_WAVEFORMS_PER_PLOT = 20;

        internal void setup(int numRows, int numColumns, int numSamplesPerPlot, bool isSpikeWaveformPlot, double timeRange, double voltageRange)
        {
            this.numRows = numRows; this.numCols = numColumns; this._isSpikeWaveformPlot = isSpikeWaveformPlot;
            this.numSamplesPerPlot = numSamplesPerPlot;
            if (!isSpikeWaveformPlot)
            {
                lines = new List<VertexPositionColor[]>(numRows); // Room for data 
                threshlines1 = new List<VertexPositionColor[]>(numRows); // Room for upper threshold
                threshlines2 = new List<VertexPositionColor[]>(numRows); // Room for lower threshold
                for (int i = 0; i < numRows; ++i)
                {
                    lines.Add(new VertexPositionColor[numSamplesPerPlot * numColumns]);
                    threshlines1.Add(new VertexPositionColor[numSamplesPerPlot * numColumns]);
                    threshlines2.Add(new VertexPositionColor[numSamplesPerPlot * numColumns]);
                }
                idx = new short[numSamplesPerPlot * numCols];
            }
            else
            {
                lines = new List<VertexPositionColor[]>(numCols * numRows * NUM_WAVEFORMS_PER_PLOT);
                for (int i = 0; i < numCols * numRows * NUM_WAVEFORMS_PER_PLOT; ++i)
                    lines.Add(new VertexPositionColor[numSamplesPerPlot]);
                idx = new short[numSamplesPerPlot];
            }

            gridLines = new List<VertexPositionColor[]>(numRows + numCols - 2);

            for (int i = 0; i < numRows + numCols - 2; ++i) 
                gridLines.Add(new VertexPositionColor[2]);
            for (short i = 0; i < idx.Length; ++i) 
                idx[i] = i;

            this.timeRange = timeRange;
            this.voltageRange = voltageRange;
        }

        internal void clear()
        {
            if (!_isSpikeWaveformPlot)
            {
                lines.Clear();
                threshlines1.Clear();
                threshlines2.Clear();
                for (int i = 0; i < numRows; ++i)
                {
                    lines.Add(new VertexPositionColor[numSamplesPerPlot * numCols]);
                    threshlines1.Add(new VertexPositionColor[numSamplesPerPlot * numCols]);
                    threshlines2.Add(new VertexPositionColor[numSamplesPerPlot * numCols]);
                }
            }
            else
            {
                lines.Clear();
                for (int i = 0; i < numCols * numRows * NUM_WAVEFORMS_PER_PLOT; ++i)
                    lines.Add(new VertexPositionColor[numSamplesPerPlot]);
            }
        }

        protected override void Initialize()
        {
            effect = new BasicEffect(GraphicsDevice);
            effect.VertexColorEnabled = true;
            effect.View = Matrix.CreateLookAt(new Vector3(0, 0, 1), Vector3.Zero, Vector3.Up);
            effect.Projection = Matrix.CreateOrthographicOffCenter(0, this.Width, this.Height, 0, 1, 1000);

            // Graphics device options
            GraphicsDevice.BlendState = BlendState.NonPremultiplied;

            content = new ContentManager(Services, "Content");
            spriteBatch = new SpriteBatch(GraphicsDevice);
            font = content.Load<SpriteFont>("NRArial");

            this.Resize += new EventHandler(resize);
            this.SizeChanged += new EventHandler(resize);
            this.VisibleChanged += new EventHandler(resize);
        }

        internal void resize(object sender, System.EventArgs e)
        {
            if (!(this.Disposing) && effect != null)
            {
                effect.Projection = Matrix.CreateOrthographicOffCenter(0F, this.Width, this.Height, 0F, 1F, 1000F);
                xScale = (float)this.Width / dX;
                yScale = -(float)this.Height / dY;

                plotGridLines();
                updateChannelNumbers();
                updateVoltageTime();
            }
        }

        internal void setMinMax(float minX, float maxX, float minY, float maxY)
        {
            lock (this)
            {
                this.minX = minX;
                this.minY = minY;
                this.maxX = maxX;
                this.maxY = maxY;
                dX = maxX - minX;
                dY = maxY - minY;
                xScale = (float)this.Width / dX;
                yScale = -(float)this.Height / dY;
            }
        }

        internal void plotYWithThresh(float[] data, float[] threshold1, float[] threshold2, float firstX, float incrementX,
            List<Color> colorWave, int numSampPerPlot, Color colorThresh, int plotNumber)
        {
            for (int i = 0; i < data.GetLength(0); ++i)
                lines[plotNumber][i] = new VertexPositionColor(new Vector3(xScale * (firstX + incrementX * i - minX),
                    yScale * ((float)data[i] - maxY), 0), colorWave[numCols * plotNumber + i / numSampPerPlot]);
            for (int i = 0; i < data.GetLength(0); ++i)
                threshlines1[plotNumber][i] = new VertexPositionColor(new Vector3(xScale * (firstX + incrementX * i - minX),
                    yScale * (threshold1[i] - maxY), 0), colorThresh);
            for (int i = 0; i < data.GetLength(0); ++i)
                threshlines2[plotNumber][i] = new VertexPositionColor(new Vector3(xScale * (firstX + incrementX * i - minX),
                    yScale * (threshold2[i] - maxY), 0), colorThresh);
        }

        protected override void Draw()
        {
            GraphicsDevice.Clear(Color.Black);

            //Draw channel numbers
            plotChannelNumbers();
            plotVoltageTime();

            //effect.Begin();
            effect.CurrentTechnique.Passes[0].Apply();

            for (int i = 0; i < lines.Count; ++i)
                GraphicsDevice.DrawUserIndexedPrimitives<VertexPositionColor>(PrimitiveType.LineStrip,
                    lines[i], 0, idx.Length, idx, 0, idx.Length - 1);
            for (int i = 0; i < threshlines1.Count; ++i)
            {
                GraphicsDevice.DrawUserIndexedPrimitives<VertexPositionColor>(PrimitiveType.LineStrip,
                    threshlines1[i], 0, idx.Length, idx, 0, idx.Length - 1);
                GraphicsDevice.DrawUserIndexedPrimitives<VertexPositionColor>(PrimitiveType.LineStrip,
                    threshlines2[i], 0, idx.Length, idx, 0, idx.Length - 1);
            }
            for (int i = 0; i < gridLines.Count; ++i)
                GraphicsDevice.DrawUserIndexedPrimitives<VertexPositionColor>(PrimitiveType.LineStrip,
                    gridLines[i], 0, 2, gridIdx, 0, 1);

            //effect.CurrentTechnique.Passes[0].End();
            //effect.End();
        }

        private void plotGridLines()
        {
            float boxHeight = (float)this.Height / numRows;
            float boxWidth = (float)this.Width / numCols;

            //Draw horz. lines
            for (int i = 0; i < numRows - 1; ++i)
            {
                gridLines[i][0] = new VertexPositionColor(new Vector3(0F, boxHeight * (i + 1), 0F),
                    gridColor);
                gridLines[i][1] = new VertexPositionColor(new Vector3(this.Width, boxHeight * (i + 1), 0F),
                    gridColor);
            }
            //Draw vert. lines
            for (int i = 0; i < numCols - 1; ++i)
            {
                gridLines[i + numRows - 1][0] = new VertexPositionColor(new Vector3(boxWidth * (i + 1),
                    0F, 0F), gridColor);
                gridLines[i + numCols - 1][1] = new VertexPositionColor(new Vector3(boxWidth * (i + 1),
                    this.Height, 0F), gridColor);
            }
        }

        private void plotChannelNumbers()
        {
            spriteBatch.Begin();
            for (int i = 1; i <= channelNumberText.Count; ++i)
                spriteBatch.DrawString(font, channelNumberText[i], channelNumberLocations[i], Color.White);
            spriteBatch.End();
        }

        private void updateChannelNumbers()
        {
            float boxHeight = (float)this.Height / numRows;
            float boxWidth = (float)this.Width / numCols;

            const int MARGIN = 5; //Pixels from vert/horz grid for each label
            //labels will be in upper left of each box

            if (channelNumberLocations == null)
                channelNumberLocations = new Dictionary<int, Vector2>(numCols * numRows);
            else channelNumberLocations.Clear();

            if (channelNumberText == null)
                channelNumberText = new Dictionary<int, string>(numCols * numRows);
            else channelNumberText.Clear();

            int i = 1;
            for (int r = 0; r < numRows; ++r)
            {
                for (int c = 0; c < numCols; ++c)
                {
                    channelNumberLocations.Add(i, new Vector2(boxWidth * c + MARGIN, boxHeight * r + MARGIN));
                    channelNumberText.Add(i, i.ToString());
                    ++i;
                }
            }
        }

        private void plotVoltageTime()
        {
            spriteBatch.Begin();
            lock (voltageTimeLabelLock)
            {
                spriteBatch.DrawString(font, voltageTimeLabel, voltageTimeLabelCoords, Color.White);
            }
            spriteBatch.End();
        }

        private object voltageTimeLabelLock = new object();
        private void updateVoltageTime()
        {
            if (font != null) //Prevents this from being called if object isn't initalized
            {
                const int VERTICAL_MARGIN = 5;
                const int HORIZONTAL_MARGIN = 5;

                double displayVoltage = voltageRange / displayGain;

                lock (voltageTimeLabelLock)
                {
                    voltageTimeLabel = "";
                    if (displayVoltage >= 1)
                        voltageTimeLabel = @"+-" + Math.Ceiling(displayVoltage) + " V, ";
                    else if (displayVoltage * 1000 >= 1)
                        voltageTimeLabel = @"+-" + Math.Ceiling(displayVoltage * 1000) + " mV, ";
                    else if (displayVoltage * 1E6 >= 1)
                        voltageTimeLabel = @"+-" + Math.Ceiling(displayVoltage * 1E6) + " uV, ";
                    else
                        voltageTimeLabel = @"+-" + Math.Ceiling(displayVoltage * 1E9) + " nV, ";

                    voltageTimeLabel += timeRange * 1000 + " ms";

                    Vector2 stringExtent = font.MeasureString(voltageTimeLabel);
                    voltageTimeLabelCoords = new Vector2(this.Width - stringExtent.X - HORIZONTAL_MARGIN, this.Height - stringExtent.Y - VERTICAL_MARGIN);
                }
            }
        }

        internal void setDisplayGain(double gain)
        {
            displayGain = gain;
            updateVoltageTime();
        }

        protected override void Dispose(bool disposing)
        {
            if (content != null)
                content.Unload();
            base.Dispose(disposing);
        }
    }

}
