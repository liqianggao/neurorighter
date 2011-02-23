// NeuroRighter
// Copyright (c) 2008-2009 John Rolston
//
// This file is part of NeuroRighter.
//
// NeuroRighter is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// NeuroRighter is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with NeuroRighter.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace NeuroRighter
{
    using rawType = System.Double;


    /// <author>John Rolston (rolston2@gmail.com) and Jon Newman</author>
    class RMSThresholdFixed : SpikeDetector
    {

        private const int TOTAL_NUM_UPDATES = 1000;
        private int[] numUpdates; //We want to converge on a good estimate of RMS based on the first few calls, then stop updating
        private double[,] RMSList;
        private double[] ChanThresh;
        private double[] ThreshSorted;

        public RMSThresholdFixed(int spikeBufferLengthIn, int numChannelsIn, int downsampleIn, int spike_buffer_sizeIn, int numPostIn, int numPreIn, rawType threshMult) :
            base(spikeBufferLengthIn, numChannelsIn, downsampleIn, spike_buffer_sizeIn, numPostIn, numPreIn, threshMult) 
        {
            threshold = new rawType[1, numChannels];
            numUpdates = new int[numChannels];
            RMSList = new double[numChannels,TOTAL_NUM_UPDATES];
            ChanThresh = new double[TOTAL_NUM_UPDATES];
            ThreshSorted = new double[(int)Math.Floor((double)(TOTAL_NUM_UPDATES - 9 * TOTAL_NUM_UPDATES / 10))];
        }

        protected override void updateThreshold(rawType[] data, int channel, int idx)
        {
            rawType tempData = 0;
            for (int j = 0; j < spikeBufferLength / downsample; ++j)
                tempData += data[j * downsample] * data[j * downsample]; //Square data
            tempData /= (spikeBufferLength / downsample);
            rawType thresholdTemp = (rawType)(Math.Sqrt(tempData) * _thresholdMultiplier);
            RMSList[channel,idx] = thresholdTemp;
            threshold[0, channel] = (threshold[0, channel]*(numUpdates[channel])) / (numUpdates[channel]+1)  + (thresholdTemp / (numUpdates[channel]+1));// Recursive RMS estimate

        }

        public override void detectSpikes(rawType[] data, List<SpikeWaveform> waveforms, int channel)
        {
            if (numUpdates[channel] > TOTAL_NUM_UPDATES) { /* do nothing */ }
            else if (numUpdates[channel] == TOTAL_NUM_UPDATES)
            {
                // Estimate the threshold based on the lower 25% percentile of threshold estimates gathered duringthe updating process
                for (int j = 0; j < TOTAL_NUM_UPDATES; ++j)
                    ChanThresh[j] = RMSList[channel, j];

                Array.Sort(ChanThresh);

                for (int j = 0; j < ThreshSorted.Length; ++j)
                    ThreshSorted[j] = RMSList[channel, j];

                threshold[0, channel] = ThreshSorted.Average();
                ++numUpdates[channel]; // prevent further updates
            }
            else
            {
                updateThreshold(data, channel, numUpdates[channel]);
                ++numUpdates[channel];
            }
            int i;

            //Check carried-over samples for spikes
            for (i = spikeBufferSize - numPost; i < spikeBufferSize; ++i)
            {
                if (spikeDetectionBuffer[channel][i] < threshold[0, channel] &&
                    spikeDetectionBuffer[channel][i] > -threshold[0, channel]) { /*do nothing, pt. is within thresh*/ }
                else
                {
                    rawType[] waveform = new rawType[numPost + numPre + 1];
                    for (int j = i - numPre; j < spikeBufferSize; ++j)
                        waveform[j - i + numPre] = spikeDetectionBuffer[channel][j];
                    for (int j = 0; j < numPost - (spikeBufferSize - i) + 1; ++j)
                        waveform[j + numPre + (spikeBufferSize - i)] = data[j];
                    waveforms.Add(new SpikeWaveform(channel, i - spikeBufferSize, threshold[0, channel], waveform));
                    i += numPost - 10;
                }
            }
            for (i = 0; i < numPre; ++i)
            {
                if (data[i] < threshold[0, channel] && data[i] > -threshold[0, channel]) { }
                else
                {
                    rawType[] waveform = new rawType[numPost + numPre + 1];
                    for (int j = spikeBufferSize - (numPre - i); j < spikeBufferSize; ++j)
                        waveform[j - spikeBufferSize + (numPre - i)] = spikeDetectionBuffer[channel][j];
                    for (int j = 0; j < numPost + 1; ++j)
                        waveform[j + (numPre - i)] = data[j];
                    waveforms.Add(new SpikeWaveform(channel, i, threshold[0, channel], waveform));
                    i += numPost - 10;
                }
            }
            for (; i < spikeBufferLength - numPost; ++i)
            {
                if (data[i] < threshold[0, channel] && data[i] > -threshold[0, channel]) { }
                else
                {
                    rawType[] waveform = new rawType[numPost + numPre + 1];
                    for (int j = i - numPre; j < i + numPost + 1; ++j)
                        waveform[j - i + numPre] = data[j];
                    waveforms.Add(new SpikeWaveform(channel, i, threshold[0, channel], waveform));
                    i += numPost - 10;
                }
            }


            for (int j = 0; j < spikeBufferSize; ++j)
                spikeDetectionBuffer[channel][j] = data[j + spikeBufferLength - spikeBufferSize];
        }
    }
}