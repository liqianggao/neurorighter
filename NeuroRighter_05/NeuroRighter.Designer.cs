namespace NeuroRighter
{
    partial class NeuroRighter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NeuroRighter));
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.led_recording = new NationalInstruments.UI.WindowsForms.Led();
            this.checkBox_video = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.switch_record = new NationalInstruments.UI.WindowsForms.Switch();
            this.checkBox_SaveRawSpikes = new System.Windows.Forms.CheckBox();
            this.button_BrowseOutputFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_OutputFile = new System.Windows.Forms.TextBox();
            this.groupBox32 = new System.Windows.Forms.GroupBox();
            this.numericUpDown_timedRecordingDurationSeconds = new System.Windows.Forms.NumericUpDown();
            this.label90 = new System.Windows.Forms.Label();
            this.checkBox_enableTimedRecording = new System.Windows.Forms.CheckBox();
            this.numericUpDown_timedRecordingDuration = new System.Windows.Forms.NumericUpDown();
            this.label72 = new System.Windows.Forms.Label();
            this.label89 = new System.Windows.Forms.Label();
            this.label_timeElapsed = new System.Windows.Forms.Label();
            this.toolTip_outputFilename = new System.Windows.Forms.ToolTip(this.components);
            this.checkBox_SALPA = new System.Windows.Forms.CheckBox();
            this.checkBox_freeze = new System.Windows.Forms.CheckBox();
            this.button_scaleReset = new System.Windows.Forms.Button();
            this.button_scaleDown = new System.Windows.Forms.Button();
            this.button_scaleUp = new System.Windows.Forms.Button();
            this.comboBox_SpikeGain = new System.Windows.Forms.ComboBox();
            this.radioButton_OnDemandBiphasic = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.checkBox_artiFilt = new System.Windows.Forms.CheckBox();
            this.checkBox_LFPsFilter = new System.Windows.Forms.CheckBox();
            this.label25 = new System.Windows.Forms.Label();
            this.LFPFiltOrder = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.LFPHighCut = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.LFPLowCut = new System.Windows.Forms.NumericUpDown();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this.SpikeFiltOrder = new System.Windows.Forms.NumericUpDown();
            this.checkBox_spikesFilter = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SpikeHighCut = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.SpikeLowCut = new System.Windows.Forms.NumericUpDown();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label93 = new System.Windows.Forms.Label();
            this.label92 = new System.Windows.Forms.Label();
            this.label91 = new System.Windows.Forms.Label();
            this.textBox_AbsArtThresh = new System.Windows.Forms.TextBox();
            this.checkBox_spikeValidation = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox_spikeDetAlg = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numPostSamples = new System.Windows.Forms.NumericUpDown();
            this.numPreSamples = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.thresholdMultiplier = new System.Windows.Forms.NumericUpDown();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timer_expt = new System.Windows.Forms.Timer(this.components);
            this.bw_genExpt = new System.ComponentModel.BackgroundWorker();
            this.bw_stim = new System.ComponentModel.BackgroundWorker();
            this.bw_openLoop = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_DisplaySettings = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processingSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl_sidebar = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox31 = new System.Windows.Forms.GroupBox();
            this.label86 = new System.Windows.Forms.Label();
            this.label87 = new System.Windows.Forms.Label();
            this.label84 = new System.Windows.Forms.Label();
            this.label88 = new System.Windows.Forms.Label();
            this.numericUpDown_salpa_delta = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_salpa_postpegzeros = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_salpa_postpeg = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_salpa_halfwidth = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.channelOut = new System.Windows.Forms.NumericUpDown();
            this.label63 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.progressBar_train = new System.Windows.Forms.ProgressBar();
            this.button_Train = new System.Windows.Forms.Button();
            this.label_noise = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_numChannels = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button_lfpSamplingRate = new System.Windows.Forms.Button();
            this.button_spikeSamplingRate = new System.Windows.Forms.Button();
            this.label73 = new System.Windows.Forms.Label();
            this.textBox_MUASamplingRate = new System.Windows.Forms.TextBox();
            this.comboBox_LFPGain = new System.Windows.Forms.ComboBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label_SpikeGain = new System.Windows.Forms.Label();
            this.label_LFPSamplingRate = new System.Windows.Forms.Label();
            this.label_SpikeSamplingRate = new System.Windows.Forms.Label();
            this.textBox_spikeSamplingRate = new System.Windows.Forms.TextBox();
            this.textBox_lfpSamplingRate = new System.Windows.Forms.TextBox();
            this.spkWfmPlot1 = new NationalInstruments.UI.WaveformPlot();
            this.xAxis3 = new NationalInstruments.UI.XAxis();
            this.yAxis3 = new NationalInstruments.UI.YAxis();
            this.timer_timeElapsed = new System.Windows.Forms.Timer(this.components);
            this.imageList_zoomButtons = new System.Windows.Forms.ImageList(this.components);
            this.tabPage_diagnostics = new System.Windows.Forms.TabPage();
            this.checkBox_diagnosticsDigitalFilter = new System.Windows.Forms.CheckBox();
            this.textBox_diagnosticsMult = new System.Windows.Forms.TextBox();
            this.textBox_voltageDivider = new System.Windows.Forms.TextBox();
            this.textBox_diagnosticsResults = new System.Windows.Forms.TextBox();
            this.scatterGraph_diagnostics = new NationalInstruments.UI.WindowsForms.ScatterGraph();
            this.scatterPlot1 = new NationalInstruments.UI.ScatterPlot();
            this.xAxis4 = new NationalInstruments.UI.XAxis();
            this.yAxis4 = new NationalInstruments.UI.YAxis();
            this.label56 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.checkBox_diagnosticsVotlageDivider = new System.Windows.Forms.CheckBox();
            this.checkBox_diagnosticsBulk = new System.Windows.Forms.CheckBox();
            this.label42 = new System.Windows.Forms.Label();
            this.numericUpDown_numPeriods = new System.Windows.Forms.NumericUpDown();
            this.label41 = new System.Windows.Forms.Label();
            this.numericUpDown_diagnosticsVoltage = new System.Windows.Forms.NumericUpDown();
            this.label40 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.numericUpDown_startFreq = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_stopFreq = new System.Windows.Forms.NumericUpDown();
            this.button_computeGain = new System.Windows.Forms.Button();
            this.tabPage_impedance = new System.Windows.Forms.TabPage();
            this.button_impedanceSaveAsMAT = new System.Windows.Forms.Button();
            this.groupBox21 = new System.Windows.Forms.GroupBox();
            this.checkBox_impedanceAllChannels = new System.Windows.Forms.CheckBox();
            this.numericUpDown_impChannel = new System.Windows.Forms.NumericUpDown();
            this.button_impedanceCopyDataToClipboard = new System.Windows.Forms.Button();
            this.scatterGraph_impedance = new NationalInstruments.UI.WindowsForms.ScatterGraph();
            this.scatterPlot2 = new NationalInstruments.UI.ScatterPlot();
            this.xAxis2 = new NationalInstruments.UI.XAxis();
            this.yAxis2 = new NationalInstruments.UI.YAxis();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.textBox_impedanceResults = new System.Windows.Forms.TextBox();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.label_impedanceProgress = new System.Windows.Forms.Label();
            this.progressBar_impedance = new System.Windows.Forms.ProgressBar();
            this.checkBox_impUseMatchedFilter = new System.Windows.Forms.CheckBox();
            this.checkBox_impBandpassFilter = new System.Windows.Forms.CheckBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.numericUpDown_impNumPeriods = new System.Windows.Forms.NumericUpDown();
            this.label46 = new System.Windows.Forms.Label();
            this.numericUpDown_impStartFreq = new System.Windows.Forms.NumericUpDown();
            this.label43 = new System.Windows.Forms.Label();
            this.numericUpDown_impStopFreq = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_impCommandVoltage = new System.Windows.Forms.NumericUpDown();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.numericUpDown_RMeas = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_RGain = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_RCurr = new System.Windows.Forms.NumericUpDown();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.radioButton_impVoltage = new System.Windows.Forms.RadioButton();
            this.radioButton_impCurrent = new System.Windows.Forms.RadioButton();
            this.button_impedanceTest = new System.Windows.Forms.Button();
            this.button_impedanceCancel = new System.Windows.Forms.Button();
            this.tabPage_stim = new System.Windows.Forms.TabPage();
            this.DebugButton = new System.Windows.Forms.Button();
            this.groupBox33 = new System.Windows.Forms.GroupBox();
            this.refreshClosedLoopButton = new System.Windows.Forms.Button();
            this.pnpcl_available_dropdown = new System.Windows.Forms.ComboBox();
            this.progressBar_pnpcl = new System.Windows.Forms.ProgressBar();
            this.stopPNPCL = new System.Windows.Forms.Button();
            this.startPNPCL = new System.Windows.Forms.Button();
            this.groupBox30 = new System.Windows.Forms.GroupBox();
            this.button_BrowseOLStimFile = new System.Windows.Forms.Button();
            this.progressBar_protocolFromFile = new System.Windows.Forms.ProgressBar();
            this.button_stopStimFromFile = new System.Windows.Forms.Button();
            this.textBox_protocolFileLocations = new System.Windows.Forms.TextBox();
            this.label85 = new System.Windows.Forms.Label();
            this.button_startStimFromFile = new System.Windows.Forms.Button();
            this.button_showcase = new System.Windows.Forms.Button();
            this.groupBox24 = new System.Windows.Forms.GroupBox();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.radioButton_stimVoltageControlled = new System.Windows.Forms.RadioButton();
            this.radioButton_stimCurrentControlled = new System.Windows.Forms.RadioButton();
            this.offsetVoltage = new System.Windows.Forms.NumericUpDown();
            this.label26 = new System.Windows.Forms.Label();
            this.groupBox23 = new System.Windows.Forms.GroupBox();
            this.button_IISZapper_stop = new System.Windows.Forms.Button();
            this.button_IISZapper_start = new System.Windows.Forms.Button();
            this.label66 = new System.Windows.Forms.Label();
            this.numericUpDown_IISZapper_channel = new System.Windows.Forms.NumericUpDown();
            this.label67 = new System.Windows.Forms.Label();
            this.numericUpDown_IISZapper_phaseWidth = new System.Windows.Forms.NumericUpDown();
            this.label68 = new System.Windows.Forms.Label();
            this.numericUpDown_IISZapper_rate = new System.Windows.Forms.NumericUpDown();
            this.label69 = new System.Windows.Forms.Label();
            this.numericUpDown_IISZapper_voltage = new System.Windows.Forms.NumericUpDown();
            this.label70 = new System.Windows.Forms.Label();
            this.numericUpDown_IISZapper_pulsePerTrain = new System.Windows.Forms.NumericUpDown();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.button_ElectrodeScreeningSelectNone = new System.Windows.Forms.Button();
            this.label60 = new System.Windows.Forms.Label();
            this.button_ElectrodeScreeningSelectAll = new System.Windows.Forms.Button();
            this.numericUpDown_exptNumRepeats = new System.Windows.Forms.NumericUpDown();
            this.label59 = new System.Windows.Forms.Label();
            this.textBox_exptPulseWidths = new System.Windows.Forms.TextBox();
            this.label58 = new System.Windows.Forms.Label();
            this.textBox_exptPPT = new System.Windows.Forms.TextBox();
            this.label57 = new System.Windows.Forms.Label();
            this.textBox_exptVoltages = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.button_stopExpt = new System.Windows.Forms.Button();
            this.listBox_exptStimChannels = new System.Windows.Forms.ListBox();
            this.progressBar_stimExpt = new System.Windows.Forms.ProgressBar();
            this.button_stimExpt = new System.Windows.Forms.Button();
            this.groupBox22 = new System.Windows.Forms.GroupBox();
            this.label65 = new System.Windows.Forms.Label();
            this.button_electrolesioningSelectNone = new System.Windows.Forms.Button();
            this.button_electrolesioningSelectAll = new System.Windows.Forms.Button();
            this.listBox_electrolesioningChannels = new System.Windows.Forms.ListBox();
            this.label64 = new System.Windows.Forms.Label();
            this.numericUpDown_electrolesioningDuration = new System.Windows.Forms.NumericUpDown();
            this.label31 = new System.Windows.Forms.Label();
            this.numericUpDown_electrolesioningVoltage = new System.Windows.Forms.NumericUpDown();
            this.button_electrolesioningStart = new System.Windows.Forms.Button();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.waveformGraph_openLoopStimPulse = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.waveformPlot1 = new NationalInstruments.UI.WaveformPlot();
            this.xAxis1 = new NationalInstruments.UI.XAxis();
            this.yAxis1 = new NationalInstruments.UI.YAxis();
            this.button_openLoopSelectNone = new System.Windows.Forms.Button();
            this.button_openLoopSelectAll = new System.Windows.Forms.Button();
            this.label36 = new System.Windows.Forms.Label();
            this.openLoopPostphaseLength = new System.Windows.Forms.NumericUpDown();
            this.label35 = new System.Windows.Forms.Label();
            this.openLoopPrephaseLength = new System.Windows.Forms.NumericUpDown();
            this.label23 = new System.Windows.Forms.Label();
            this.openLoopWidth2 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.openLoopVoltage2 = new System.Windows.Forms.NumericUpDown();
            this.label34 = new System.Windows.Forms.Label();
            this.openLoopInterphaseLength = new System.Windows.Forms.NumericUpDown();
            this.label22 = new System.Windows.Forms.Label();
            this.listBox_stimChannels = new System.Windows.Forms.ListBox();
            this.openLoopStop = new System.Windows.Forms.Button();
            this.openLoopStart = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.openLoopWidth1 = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.openLoopVoltage1 = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.openLoopRate = new System.Windows.Forms.NumericUpDown();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.groupBox29 = new System.Windows.Forms.GroupBox();
            this.radioButton_OnDemandUniphasic = new System.Windows.Forms.RadioButton();
            this.label33 = new System.Windows.Forms.Label();
            this.stimInterphaseLength = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.stimChannel = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.stimWidth = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.stimRate = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.stimVoltage = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.stimPulses = new System.Windows.Forms.NumericUpDown();
            this.button_stim = new System.Windows.Forms.Button();
            this.tabPage_ProgRef = new System.Windows.Forms.TabPage();
            this.groupBox_plexonProgRef = new System.Windows.Forms.GroupBox();
            this.button_analogResetRefs = new System.Windows.Forms.Button();
            this.checkBox_analogRefLFPs = new System.Windows.Forms.CheckBox();
            this.label47 = new System.Windows.Forms.Label();
            this.numericUpDown_analogRefLFPs = new System.Windows.Forms.NumericUpDown();
            this.checkBox_analogRefSpikes = new System.Windows.Forms.CheckBox();
            this.label48 = new System.Windows.Forms.Label();
            this.numericUpDown_analogRefSpikes = new System.Windows.Forms.NumericUpDown();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.groupBox25 = new System.Windows.Forms.GroupBox();
            this.numericUpDown_CommonMedianLocalReferencingChannelsPerGroup = new System.Windows.Forms.NumericUpDown();
            this.label83 = new System.Windows.Forms.Label();
            this.radioButton_spikesReferencingCommonAverage = new System.Windows.Forms.RadioButton();
            this.radioButton_spikesReferencingCommonMedian = new System.Windows.Forms.RadioButton();
            this.radioButton_spikesReferencingCommonMedianLocal = new System.Windows.Forms.RadioButton();
            this.radioButton_spikeReferencingNone = new System.Windows.Forms.RadioButton();
            this.checkBox_digRefLFPs = new System.Windows.Forms.CheckBox();
            this.label44 = new System.Windows.Forms.Label();
            this.numericUpDown_digRefLFPs = new System.Windows.Forms.NumericUpDown();
            this.checkBox_digRefSpikes = new System.Windows.Forms.CheckBox();
            this.label27 = new System.Windows.Forms.Label();
            this.numericUpDown_digRefSpikes = new System.Windows.Forms.NumericUpDown();
            this.tabPage_EEG = new System.Windows.Forms.TabPage();
            this.eegGraph = new AxCWUIControlsLib.AxCWGraph();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.checkBox_eegFilter = new System.Windows.Forms.CheckBox();
            this.label52 = new System.Windows.Forms.Label();
            this.EEGFiltOrder = new System.Windows.Forms.NumericUpDown();
            this.label53 = new System.Windows.Forms.Label();
            this.EEGHighCut = new System.Windows.Forms.NumericUpDown();
            this.label54 = new System.Windows.Forms.Label();
            this.EEGLowCut = new System.Windows.Forms.NumericUpDown();
            this.label51 = new System.Windows.Forms.Label();
            this.textBox_eegSamplingRate = new System.Windows.Forms.TextBox();
            this.comboBox_eegGain = new System.Windows.Forms.ComboBox();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.comboBox_eegNumChannels = new System.Windows.Forms.ComboBox();
            this.tabPage_LFPs = new System.Windows.Forms.TabPage();
            this.tabPage_waveforms = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_clearSpkWfms = new System.Windows.Forms.Button();
            this.tabPage_spikes = new System.Windows.Forms.TabPage();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage_MUA = new System.Windows.Forms.TabPage();
            this.button_BrowseOLDFile = new System.Windows.Forms.Button();
            this.textBox_digitalProtocolFileLocation = new System.Windows.Forms.TextBox();
            this.label61 = new System.Windows.Forms.Label();
            this.checkBox_useManStimWaveform = new System.Windows.Forms.CheckBox();
            this.checkBox_repeatOLStim = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.led_recording)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.switch_record)).BeginInit();
            this.groupBox32.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_timedRecordingDurationSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_timedRecordingDuration)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LFPFiltOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LFPHighCut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LFPLowCut)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpikeFiltOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpikeHighCut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpikeLowCut)).BeginInit();
            this.groupBox10.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPostSamples)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPreSamples)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdMultiplier)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl_sidebar.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox31.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_salpa_delta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_salpa_postpegzeros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_salpa_postpeg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_salpa_halfwidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.channelOut)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage_diagnostics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scatterGraph_diagnostics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_numPeriods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_diagnosticsVoltage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_startFreq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_stopFreq)).BeginInit();
            this.tabPage_impedance.SuspendLayout();
            this.groupBox21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_impChannel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scatterGraph_impedance)).BeginInit();
            this.groupBox17.SuspendLayout();
            this.groupBox16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_impNumPeriods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_impStartFreq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_impStopFreq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_impCommandVoltage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_RMeas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_RGain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_RCurr)).BeginInit();
            this.groupBox15.SuspendLayout();
            this.tabPage_stim.SuspendLayout();
            this.groupBox33.SuspendLayout();
            this.groupBox30.SuspendLayout();
            this.groupBox24.SuspendLayout();
            this.groupBox18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.offsetVoltage)).BeginInit();
            this.groupBox23.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_IISZapper_channel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_IISZapper_phaseWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_IISZapper_rate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_IISZapper_voltage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_IISZapper_pulsePerTrain)).BeginInit();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_exptNumRepeats)).BeginInit();
            this.groupBox22.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_electrolesioningDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_electrolesioningVoltage)).BeginInit();
            this.groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.waveformGraph_openLoopStimPulse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openLoopPostphaseLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openLoopPrephaseLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openLoopWidth2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openLoopVoltage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openLoopInterphaseLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openLoopWidth1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openLoopVoltage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openLoopRate)).BeginInit();
            this.groupBox9.SuspendLayout();
            this.groupBox29.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stimInterphaseLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stimChannel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stimWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stimRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stimVoltage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stimPulses)).BeginInit();
            this.tabPage_ProgRef.SuspendLayout();
            this.groupBox_plexonProgRef.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_analogRefLFPs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_analogRefSpikes)).BeginInit();
            this.groupBox13.SuspendLayout();
            this.groupBox25.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CommonMedianLocalReferencingChannelsPerGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_digRefLFPs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_digRefSpikes)).BeginInit();
            this.tabPage_EEG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eegGraph)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EEGFiltOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EEGHighCut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EEGLowCut)).BeginInit();
            this.tabPage_waveforms.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(92, 799);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Enabled = false;
            this.buttonStop.Location = new System.Drawing.Point(173, 799);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.led_recording);
            this.groupBox1.Controls.Add(this.checkBox_video);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.switch_record);
            this.groupBox1.Controls.Add(this.checkBox_SaveRawSpikes);
            this.groupBox1.Controls.Add(this.button_BrowseOutputFile);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_OutputFile);
            this.groupBox1.Controls.Add(this.groupBox32);
            this.groupBox1.Location = new System.Drawing.Point(5, 635);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 158);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recording";
            // 
            // led_recording
            // 
            this.led_recording.LedStyle = NationalInstruments.UI.LedStyle.Round3D;
            this.led_recording.Location = new System.Drawing.Point(203, 40);
            this.led_recording.Name = "led_recording";
            this.led_recording.Size = new System.Drawing.Size(35, 35);
            this.led_recording.TabIndex = 7;
            // 
            // checkBox_video
            // 
            this.checkBox_video.AutoSize = true;
            this.checkBox_video.Location = new System.Drawing.Point(15, 79);
            this.checkBox_video.Name = "checkBox_video";
            this.checkBox_video.Size = new System.Drawing.Size(91, 17);
            this.checkBox_video.TabIndex = 31;
            this.checkBox_video.Text = "Record Video";
            this.checkBox_video.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(181, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Record";
            // 
            // switch_record
            // 
            this.switch_record.Location = new System.Drawing.Point(164, 9);
            this.switch_record.Name = "switch_record";
            this.switch_record.Size = new System.Drawing.Size(47, 88);
            this.switch_record.SwitchStyle = NationalInstruments.UI.SwitchStyle.VerticalToggle3D;
            this.switch_record.TabIndex = 29;
            this.switch_record.StateChanged += new NationalInstruments.UI.ActionEventHandler(this.switch_record_StateChanged);
            // 
            // checkBox_SaveRawSpikes
            // 
            this.checkBox_SaveRawSpikes.AutoSize = true;
            this.checkBox_SaveRawSpikes.Location = new System.Drawing.Point(15, 59);
            this.checkBox_SaveRawSpikes.Name = "checkBox_SaveRawSpikes";
            this.checkBox_SaveRawSpikes.Size = new System.Drawing.Size(131, 17);
            this.checkBox_SaveRawSpikes.TabIndex = 30;
            this.checkBox_SaveRawSpikes.Text = "Save raw spike traces";
            this.checkBox_SaveRawSpikes.UseVisualStyleBackColor = true;
            // 
            // button_BrowseOutputFile
            // 
            this.button_BrowseOutputFile.Location = new System.Drawing.Point(137, 30);
            this.button_BrowseOutputFile.Name = "button_BrowseOutputFile";
            this.button_BrowseOutputFile.Size = new System.Drawing.Size(25, 23);
            this.button_BrowseOutputFile.TabIndex = 28;
            this.button_BrowseOutputFile.Text = "...";
            this.button_BrowseOutputFile.UseVisualStyleBackColor = true;
            this.button_BrowseOutputFile.Click += new System.EventHandler(this.button_BrowseOutputFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Output File";
            // 
            // textBox_OutputFile
            // 
            this.textBox_OutputFile.Location = new System.Drawing.Point(6, 32);
            this.textBox_OutputFile.Name = "textBox_OutputFile";
            this.textBox_OutputFile.ReadOnly = true;
            this.textBox_OutputFile.Size = new System.Drawing.Size(125, 20);
            this.textBox_OutputFile.TabIndex = 27;
            // 
            // groupBox32
            // 
            this.groupBox32.Controls.Add(this.numericUpDown_timedRecordingDurationSeconds);
            this.groupBox32.Controls.Add(this.label90);
            this.groupBox32.Controls.Add(this.checkBox_enableTimedRecording);
            this.groupBox32.Controls.Add(this.numericUpDown_timedRecordingDuration);
            this.groupBox32.Controls.Add(this.label72);
            this.groupBox32.Controls.Add(this.label89);
            this.groupBox32.Location = new System.Drawing.Point(6, 100);
            this.groupBox32.Name = "groupBox32";
            this.groupBox32.Size = new System.Drawing.Size(231, 54);
            this.groupBox32.TabIndex = 39;
            this.groupBox32.TabStop = false;
            // 
            // numericUpDown_timedRecordingDurationSeconds
            // 
            this.numericUpDown_timedRecordingDurationSeconds.Enabled = false;
            this.numericUpDown_timedRecordingDurationSeconds.Location = new System.Drawing.Point(149, 24);
            this.numericUpDown_timedRecordingDurationSeconds.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDown_timedRecordingDurationSeconds.Name = "numericUpDown_timedRecordingDurationSeconds";
            this.numericUpDown_timedRecordingDurationSeconds.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown_timedRecordingDurationSeconds.TabIndex = 36;
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Location = new System.Drawing.Point(201, 29);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(26, 13);
            this.label90.TabIndex = 38;
            this.label90.Text = "Sec";
            // 
            // checkBox_enableTimedRecording
            // 
            this.checkBox_enableTimedRecording.AutoSize = true;
            this.checkBox_enableTimedRecording.Location = new System.Drawing.Point(9, -1);
            this.checkBox_enableTimedRecording.Name = "checkBox_enableTimedRecording";
            this.checkBox_enableTimedRecording.Size = new System.Drawing.Size(143, 17);
            this.checkBox_enableTimedRecording.TabIndex = 34;
            this.checkBox_enableTimedRecording.Text = "Enable Timed Recording";
            this.checkBox_enableTimedRecording.UseVisualStyleBackColor = true;
            this.checkBox_enableTimedRecording.CheckedChanged += new System.EventHandler(this.checkBox_enableTimedRecording_CheckedChanged);
            // 
            // numericUpDown_timedRecordingDuration
            // 
            this.numericUpDown_timedRecordingDuration.Enabled = false;
            this.numericUpDown_timedRecordingDuration.Location = new System.Drawing.Point(65, 24);
            this.numericUpDown_timedRecordingDuration.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_timedRecordingDuration.Name = "numericUpDown_timedRecordingDuration";
            this.numericUpDown_timedRecordingDuration.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown_timedRecordingDuration.TabIndex = 33;
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(3, 28);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(59, 13);
            this.label72.TabIndex = 35;
            this.label72.Text = "Rec. Time:";
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.Location = new System.Drawing.Point(116, 29);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(24, 13);
            this.label89.TabIndex = 37;
            this.label89.Text = "Min";
            // 
            // label_timeElapsed
            // 
            this.label_timeElapsed.AutoSize = true;
            this.label_timeElapsed.ForeColor = System.Drawing.Color.DimGray;
            this.label_timeElapsed.Location = new System.Drawing.Point(9, 799);
            this.label_timeElapsed.Name = "label_timeElapsed";
            this.label_timeElapsed.Size = new System.Drawing.Size(13, 13);
            this.label_timeElapsed.TabIndex = 32;
            this.label_timeElapsed.Text = "  ";
            this.label_timeElapsed.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // checkBox_SALPA
            // 
            this.checkBox_SALPA.AutoSize = true;
            this.checkBox_SALPA.BackColor = System.Drawing.Color.White;
            this.checkBox_SALPA.Enabled = false;
            this.checkBox_SALPA.Location = new System.Drawing.Point(12, 0);
            this.checkBox_SALPA.Name = "checkBox_SALPA";
            this.checkBox_SALPA.Size = new System.Drawing.Size(60, 17);
            this.checkBox_SALPA.TabIndex = 13;
            this.checkBox_SALPA.Text = "SALPA";
            this.toolTip_outputFilename.SetToolTip(this.checkBox_SALPA, "Artifact subtraction algorithm: train noise levels to use");
            this.checkBox_SALPA.UseVisualStyleBackColor = false;
            this.checkBox_SALPA.CheckedChanged += new System.EventHandler(this.checkBox_SALPA_CheckedChanged);
            // 
            // checkBox_freeze
            // 
            this.checkBox_freeze.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox_freeze.AutoSize = true;
            this.checkBox_freeze.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox_freeze.Location = new System.Drawing.Point(178, 19);
            this.checkBox_freeze.Name = "checkBox_freeze";
            this.checkBox_freeze.Size = new System.Drawing.Size(49, 23);
            this.checkBox_freeze.TabIndex = 12;
            this.checkBox_freeze.Text = "Freeze";
            this.toolTip_outputFilename.SetToolTip(this.checkBox_freeze, "Freeze display");
            this.checkBox_freeze.UseVisualStyleBackColor = true;
            // 
            // button_scaleReset
            // 
            this.button_scaleReset.FlatAppearance.BorderSize = 0;
            this.button_scaleReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_scaleReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_scaleReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_scaleReset.ForeColor = System.Drawing.Color.Transparent;
            this.button_scaleReset.Image = ((System.Drawing.Image)(resources.GetObject("button_scaleReset.Image")));
            this.button_scaleReset.Location = new System.Drawing.Point(73, 14);
            this.button_scaleReset.Name = "button_scaleReset";
            this.button_scaleReset.Size = new System.Drawing.Size(40, 40);
            this.button_scaleReset.TabIndex = 11;
            this.toolTip_outputFilename.SetToolTip(this.button_scaleReset, "Reset display gain");
            this.button_scaleReset.UseVisualStyleBackColor = true;
            this.button_scaleReset.MouseLeave += new System.EventHandler(this.button_scaleReset_MouseLeave);
            this.button_scaleReset.Click += new System.EventHandler(this.button_scaleReset_Click);
            this.button_scaleReset.MouseEnter += new System.EventHandler(this.button_scaleReset_MouseEnter);
            // 
            // button_scaleDown
            // 
            this.button_scaleDown.FlatAppearance.BorderSize = 0;
            this.button_scaleDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_scaleDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_scaleDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_scaleDown.ForeColor = System.Drawing.Color.Transparent;
            this.button_scaleDown.Image = ((System.Drawing.Image)(resources.GetObject("button_scaleDown.Image")));
            this.button_scaleDown.Location = new System.Drawing.Point(38, 14);
            this.button_scaleDown.Name = "button_scaleDown";
            this.button_scaleDown.Size = new System.Drawing.Size(40, 40);
            this.button_scaleDown.TabIndex = 9;
            this.toolTip_outputFilename.SetToolTip(this.button_scaleDown, "Decrease display gain");
            this.button_scaleDown.UseVisualStyleBackColor = true;
            this.button_scaleDown.MouseLeave += new System.EventHandler(this.button_scaleDown_MouseLeave);
            this.button_scaleDown.Click += new System.EventHandler(this.button_scaleDown_Click);
            this.button_scaleDown.MouseEnter += new System.EventHandler(this.button_scaleDown_MouseEnter);
            // 
            // button_scaleUp
            // 
            this.button_scaleUp.FlatAppearance.BorderSize = 0;
            this.button_scaleUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_scaleUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_scaleUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_scaleUp.ForeColor = System.Drawing.Color.Transparent;
            this.button_scaleUp.Image = ((System.Drawing.Image)(resources.GetObject("button_scaleUp.Image")));
            this.button_scaleUp.Location = new System.Drawing.Point(5, 14);
            this.button_scaleUp.Name = "button_scaleUp";
            this.button_scaleUp.Size = new System.Drawing.Size(40, 40);
            this.button_scaleUp.TabIndex = 10;
            this.toolTip_outputFilename.SetToolTip(this.button_scaleUp, "Increase display gain");
            this.button_scaleUp.UseVisualStyleBackColor = true;
            this.button_scaleUp.MouseLeave += new System.EventHandler(this.button_scaleUp_MouseLeave);
            this.button_scaleUp.Click += new System.EventHandler(this.button_scaleUp_Click);
            this.button_scaleUp.MouseEnter += new System.EventHandler(this.button_scaleUp_MouseEnter);
            // 
            // comboBox_SpikeGain
            // 
            this.comboBox_SpikeGain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_SpikeGain.FormattingEnabled = true;
            this.comboBox_SpikeGain.Items.AddRange(new object[] {
            "1",
            "2",
            "5",
            "10",
            "20",
            "50",
            "100"});
            this.comboBox_SpikeGain.Location = new System.Drawing.Point(66, 97);
            this.comboBox_SpikeGain.Name = "comboBox_SpikeGain";
            this.comboBox_SpikeGain.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox_SpikeGain.Size = new System.Drawing.Size(46, 21);
            this.comboBox_SpikeGain.TabIndex = 7;
            this.toolTip_outputFilename.SetToolTip(this.comboBox_SpikeGain, "Sets A/D range");
            this.comboBox_SpikeGain.SelectedIndexChanged += new System.EventHandler(this.comboBox_SpikeGain_SelectedIndexChanged);
            // 
            // radioButton_OnDemandBiphasic
            // 
            this.radioButton_OnDemandBiphasic.AutoSize = true;
            this.radioButton_OnDemandBiphasic.Checked = true;
            this.radioButton_OnDemandBiphasic.Location = new System.Drawing.Point(91, 16);
            this.radioButton_OnDemandBiphasic.Name = "radioButton_OnDemandBiphasic";
            this.radioButton_OnDemandBiphasic.Size = new System.Drawing.Size(65, 17);
            this.radioButton_OnDemandBiphasic.TabIndex = 1;
            this.radioButton_OnDemandBiphasic.TabStop = true;
            this.radioButton_OnDemandBiphasic.Text = "Biphasic";
            this.toolTip_outputFilename.SetToolTip(this.radioButton_OnDemandBiphasic, "2nd phase negative of first");
            this.radioButton_OnDemandBiphasic.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Location = new System.Drawing.Point(5, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(241, 148);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Filters";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.checkBox_artiFilt);
            this.groupBox6.Controls.Add(this.checkBox_LFPsFilter);
            this.groupBox6.Controls.Add(this.label25);
            this.groupBox6.Controls.Add(this.LFPFiltOrder);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.LFPHighCut);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.LFPLowCut);
            this.groupBox6.Location = new System.Drawing.Point(127, 19);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(112, 122);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            // 
            // checkBox_artiFilt
            // 
            this.checkBox_artiFilt.AutoSize = true;
            this.checkBox_artiFilt.Location = new System.Drawing.Point(24, 99);
            this.checkBox_artiFilt.Name = "checkBox_artiFilt";
            this.checkBox_artiFilt.Size = new System.Drawing.Size(54, 17);
            this.checkBox_artiFilt.TabIndex = 14;
            this.checkBox_artiFilt.Text = "ArtiFilt";
            this.checkBox_artiFilt.UseVisualStyleBackColor = true;
            this.checkBox_artiFilt.CheckedChanged += new System.EventHandler(this.checkBox_artiFilt_CheckedChanged);
            // 
            // checkBox_LFPsFilter
            // 
            this.checkBox_LFPsFilter.AutoSize = true;
            this.checkBox_LFPsFilter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox_LFPsFilter.Checked = true;
            this.checkBox_LFPsFilter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_LFPsFilter.Location = new System.Drawing.Point(1, -1);
            this.checkBox_LFPsFilter.Name = "checkBox_LFPsFilter";
            this.checkBox_LFPsFilter.Size = new System.Drawing.Size(50, 17);
            this.checkBox_LFPsFilter.TabIndex = 18;
            this.checkBox_LFPsFilter.Text = "LFPs";
            this.checkBox_LFPsFilter.UseVisualStyleBackColor = false;
            this.checkBox_LFPsFilter.CheckedChanged += new System.EventHandler(this.checkBox_LFPsFilter_CheckedChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(7, 73);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(36, 13);
            this.label25.TabIndex = 8;
            this.label25.Text = "Order:";
            // 
            // LFPFiltOrder
            // 
            this.LFPFiltOrder.Location = new System.Drawing.Point(56, 71);
            this.LFPFiltOrder.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.LFPFiltOrder.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LFPFiltOrder.Name = "LFPFiltOrder";
            this.LFPFiltOrder.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LFPFiltOrder.Size = new System.Drawing.Size(51, 20);
            this.LFPFiltOrder.TabIndex = 21;
            this.LFPFiltOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.LFPFiltOrder.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LFPFiltOrder.ValueChanged += new System.EventHandler(this.LFPFiltOrder_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "High-cut:";
            // 
            // LFPHighCut
            // 
            this.LFPHighCut.Location = new System.Drawing.Point(56, 45);
            this.LFPHighCut.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.LFPHighCut.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LFPHighCut.Name = "LFPHighCut";
            this.LFPHighCut.Size = new System.Drawing.Size(51, 20);
            this.LFPHighCut.TabIndex = 20;
            this.LFPHighCut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.LFPHighCut.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.LFPHighCut.ValueChanged += new System.EventHandler(this.LFPHighCut_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Low-cut:";
            // 
            // LFPLowCut
            // 
            this.LFPLowCut.DecimalPlaces = 2;
            this.LFPLowCut.Location = new System.Drawing.Point(56, 19);
            this.LFPLowCut.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.LFPLowCut.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.LFPLowCut.Name = "LFPLowCut";
            this.LFPLowCut.Size = new System.Drawing.Size(51, 20);
            this.LFPLowCut.TabIndex = 19;
            this.LFPLowCut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.LFPLowCut.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LFPLowCut.ValueChanged += new System.EventHandler(this.LFPLowCut_ValueChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label24);
            this.groupBox5.Controls.Add(this.SpikeFiltOrder);
            this.groupBox5.Controls.Add(this.checkBox_spikesFilter);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.SpikeHighCut);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.SpikeLowCut);
            this.groupBox5.Location = new System.Drawing.Point(9, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(114, 121);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 73);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(36, 13);
            this.label24.TabIndex = 7;
            this.label24.Text = "Order:";
            // 
            // SpikeFiltOrder
            // 
            this.SpikeFiltOrder.Location = new System.Drawing.Point(57, 71);
            this.SpikeFiltOrder.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.SpikeFiltOrder.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SpikeFiltOrder.Name = "SpikeFiltOrder";
            this.SpikeFiltOrder.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SpikeFiltOrder.Size = new System.Drawing.Size(51, 20);
            this.SpikeFiltOrder.TabIndex = 17;
            this.SpikeFiltOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SpikeFiltOrder.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SpikeFiltOrder.ValueChanged += new System.EventHandler(this.SpikeFiltOrder_ValueChanged);
            // 
            // checkBox_spikesFilter
            // 
            this.checkBox_spikesFilter.AutoSize = true;
            this.checkBox_spikesFilter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox_spikesFilter.Location = new System.Drawing.Point(3, 0);
            this.checkBox_spikesFilter.Name = "checkBox_spikesFilter";
            this.checkBox_spikesFilter.Size = new System.Drawing.Size(58, 17);
            this.checkBox_spikesFilter.TabIndex = 14;
            this.checkBox_spikesFilter.Text = "Spikes";
            this.checkBox_spikesFilter.UseVisualStyleBackColor = false;
            this.checkBox_spikesFilter.CheckedChanged += new System.EventHandler(this.checkBox_spikesFilter_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "High-cut:";
            // 
            // SpikeHighCut
            // 
            this.SpikeHighCut.Location = new System.Drawing.Point(57, 45);
            this.SpikeHighCut.Maximum = new decimal(new int[] {
            21000,
            0,
            0,
            0});
            this.SpikeHighCut.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.SpikeHighCut.Name = "SpikeHighCut";
            this.SpikeHighCut.Size = new System.Drawing.Size(51, 20);
            this.SpikeHighCut.TabIndex = 16;
            this.SpikeHighCut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SpikeHighCut.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.SpikeHighCut.ValueChanged += new System.EventHandler(this.SpikeHighCut_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Low-cut:";
            // 
            // SpikeLowCut
            // 
            this.SpikeLowCut.Location = new System.Drawing.Point(57, 19);
            this.SpikeLowCut.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.SpikeLowCut.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SpikeLowCut.Name = "SpikeLowCut";
            this.SpikeLowCut.Size = new System.Drawing.Size(51, 20);
            this.SpikeLowCut.TabIndex = 15;
            this.SpikeLowCut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SpikeLowCut.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.SpikeLowCut.ValueChanged += new System.EventHandler(this.SpikeLowCut_ValueChanged);
            // 
            // groupBox10
            // 
            this.groupBox10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox10.Controls.Add(this.checkBox_freeze);
            this.groupBox10.Controls.Add(this.button_scaleReset);
            this.groupBox10.Controls.Add(this.button_scaleDown);
            this.groupBox10.Controls.Add(this.button_scaleUp);
            this.groupBox10.Location = new System.Drawing.Point(5, 498);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(241, 56);
            this.groupBox10.TabIndex = 5;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Display";
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox8.Controls.Add(this.label93);
            this.groupBox8.Controls.Add(this.label92);
            this.groupBox8.Controls.Add(this.label91);
            this.groupBox8.Controls.Add(this.textBox_AbsArtThresh);
            this.groupBox8.Controls.Add(this.checkBox_spikeValidation);
            this.groupBox8.Controls.Add(this.label12);
            this.groupBox8.Controls.Add(this.comboBox_spikeDetAlg);
            this.groupBox8.Controls.Add(this.label11);
            this.groupBox8.Controls.Add(this.label10);
            this.groupBox8.Controls.Add(this.numPostSamples);
            this.groupBox8.Controls.Add(this.numPreSamples);
            this.groupBox8.Controls.Add(this.label9);
            this.groupBox8.Controls.Add(this.thresholdMultiplier);
            this.groupBox8.Location = new System.Drawing.Point(5, 160);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(241, 165);
            this.groupBox8.TabIndex = 7;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Spike Detection";
            // 
            // label93
            // 
            this.label93.AutoSize = true;
            this.label93.Location = new System.Drawing.Point(145, 80);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(76, 13);
            this.label93.TabIndex = 30;
            this.label93.Text = "Threshold (uV)";
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.Location = new System.Drawing.Point(151, 67);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(64, 13);
            this.label92.TabIndex = 29;
            this.label92.Text = "Abs. Artifact";
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.Location = new System.Drawing.Point(75, 97);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(51, 13);
            this.label91.TabIndex = 28;
            this.label91.Text = "Absolute ";
            // 
            // textBox_AbsArtThresh
            // 
            this.textBox_AbsArtThresh.Location = new System.Drawing.Point(147, 43);
            this.textBox_AbsArtThresh.Name = "textBox_AbsArtThresh";
            this.textBox_AbsArtThresh.Size = new System.Drawing.Size(72, 20);
            this.textBox_AbsArtThresh.TabIndex = 27;
            this.textBox_AbsArtThresh.Text = "1000";
            // 
            // checkBox_spikeValidation
            // 
            this.checkBox_spikeValidation.AutoSize = true;
            this.checkBox_spikeValidation.Checked = true;
            this.checkBox_spikeValidation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_spikeValidation.Location = new System.Drawing.Point(147, 20);
            this.checkBox_spikeValidation.Name = "checkBox_spikeValidation";
            this.checkBox_spikeValidation.Size = new System.Drawing.Size(72, 17);
            this.checkBox_spikeValidation.TabIndex = 26;
            this.checkBox_spikeValidation.Text = "Validation";
            this.checkBox_spikeValidation.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(2, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Detection algorithm";
            // 
            // comboBox_spikeDetAlg
            // 
            this.comboBox_spikeDetAlg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_spikeDetAlg.FormattingEnabled = true;
            this.comboBox_spikeDetAlg.Items.AddRange(new object[] {
            "Adaptive RMS",
            "Improved Adaptive RMS",
            "Fixed RMS",
            "Median (Quiroga et al.)",
            "Improved Median",
            "LimAda (Wagenaar)"});
            this.comboBox_spikeDetAlg.Location = new System.Drawing.Point(6, 113);
            this.comboBox_spikeDetAlg.Name = "comboBox_spikeDetAlg";
            this.comboBox_spikeDetAlg.Size = new System.Drawing.Size(136, 21);
            this.comboBox_spikeDetAlg.TabIndex = 25;
            this.comboBox_spikeDetAlg.SelectedIndexChanged += new System.EventHandler(this.comboBox_spikeDetAlg_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(2, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Post samples:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(2, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Pre samples:";
            // 
            // numPostSamples
            // 
            this.numPostSamples.Location = new System.Drawing.Point(76, 71);
            this.numPostSamples.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPostSamples.Name = "numPostSamples";
            this.numPostSamples.Size = new System.Drawing.Size(57, 20);
            this.numPostSamples.TabIndex = 24;
            this.numPostSamples.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numPostSamples.Value = new decimal(new int[] {
            52,
            0,
            0,
            0});
            this.numPostSamples.ValueChanged += new System.EventHandler(this.numPostSamples_ValueChanged);
            // 
            // numPreSamples
            // 
            this.numPreSamples.Location = new System.Drawing.Point(76, 45);
            this.numPreSamples.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPreSamples.Name = "numPreSamples";
            this.numPreSamples.Size = new System.Drawing.Size(57, 20);
            this.numPreSamples.TabIndex = 23;
            this.numPreSamples.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numPreSamples.Value = new decimal(new int[] {
            22,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Threshold:";
            // 
            // thresholdMultiplier
            // 
            this.thresholdMultiplier.DecimalPlaces = 1;
            this.thresholdMultiplier.Location = new System.Drawing.Point(76, 19);
            this.thresholdMultiplier.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.thresholdMultiplier.Name = "thresholdMultiplier";
            this.thresholdMultiplier.Size = new System.Drawing.Size(57, 20);
            this.thresholdMultiplier.TabIndex = 22;
            this.thresholdMultiplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.thresholdMultiplier.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.thresholdMultiplier.ValueChanged += new System.EventHandler(this.thresholdMultiplier_ValueChanged);
            // 
            // timer
            // 
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timer_expt
            // 
            this.timer_expt.Interval = 1000;
            this.timer_expt.Tick += new System.EventHandler(this.timer_expt_Tick);
            // 
            // bw_genExpt
            // 
            this.bw_genExpt.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_genExpt_DoWork);
            this.bw_genExpt.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bw_genExpt_RunWorkerCompleted);
            // 
            // bw_stim
            // 
            this.bw_stim.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_stim_DoWork);
            this.bw_stim.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bw_stim_RunWorkerCompleted);
            // 
            // bw_openLoop
            // 
            this.bw_openLoop.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_openLoop_DoWork);
            this.bw_openLoop.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bw_openLoop_RunWorkerCompleted);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(949, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_DisplaySettings,
            this.settingsToolStripMenuItem,
            this.processingSettingsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolStripMenuItem_DisplaySettings
            // 
            this.toolStripMenuItem_DisplaySettings.Name = "toolStripMenuItem_DisplaySettings";
            this.toolStripMenuItem_DisplaySettings.Size = new System.Drawing.Size(176, 22);
            this.toolStripMenuItem_DisplaySettings.Text = "Display Settings";
            this.toolStripMenuItem_DisplaySettings.Click += new System.EventHandler(this.toolStripMenuItem_DisplaySettings_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.settingsToolStripMenuItem.Text = "Hardware Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // processingSettingsToolStripMenuItem
            // 
            this.processingSettingsToolStripMenuItem.Name = "processingSettingsToolStripMenuItem";
            this.processingSettingsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.processingSettingsToolStripMenuItem.Text = "Processing Settings";
            this.processingSettingsToolStripMenuItem.Click += new System.EventHandler(this.processingSettingsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(173, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_timeElapsed);
            this.panel1.Controls.Add(this.tabControl_sidebar);
            this.panel1.Controls.Add(this.buttonStart);
            this.panel1.Controls.Add(this.buttonStop);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(949, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 830);
            this.panel1.TabIndex = 18;
            // 
            // tabControl_sidebar
            // 
            this.tabControl_sidebar.Controls.Add(this.tabPage1);
            this.tabControl_sidebar.Controls.Add(this.tabPage2);
            this.tabControl_sidebar.Location = new System.Drawing.Point(2, 3);
            this.tabControl_sidebar.Name = "tabControl_sidebar";
            this.tabControl_sidebar.SelectedIndex = 0;
            this.tabControl_sidebar.Size = new System.Drawing.Size(260, 626);
            this.tabControl_sidebar.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox31);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.channelOut);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox8);
            this.tabPage1.Controls.Add(this.groupBox10);
            this.tabPage1.Controls.Add(this.label63);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(252, 600);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Online Settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox31
            // 
            this.groupBox31.Controls.Add(this.label86);
            this.groupBox31.Controls.Add(this.label87);
            this.groupBox31.Controls.Add(this.label84);
            this.groupBox31.Controls.Add(this.label88);
            this.groupBox31.Controls.Add(this.numericUpDown_salpa_delta);
            this.groupBox31.Controls.Add(this.numericUpDown_salpa_postpegzeros);
            this.groupBox31.Controls.Add(this.numericUpDown_salpa_postpeg);
            this.groupBox31.Controls.Add(this.numericUpDown_salpa_halfwidth);
            this.groupBox31.Controls.Add(this.checkBox_SALPA);
            this.groupBox31.Location = new System.Drawing.Point(6, 337);
            this.groupBox31.Name = "groupBox31";
            this.groupBox31.Size = new System.Drawing.Size(240, 155);
            this.groupBox31.TabIndex = 37;
            this.groupBox31.TabStop = false;
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.Location = new System.Drawing.Point(2, 128);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(79, 13);
            this.label86.TabIndex = 1;
            this.label86.Text = "Delta (samples)";
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.Location = new System.Drawing.Point(2, 58);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(105, 13);
            this.label87.TabIndex = 2;
            this.label87.Text = "Post-peg Blank (sec)";
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Location = new System.Drawing.Point(2, 93);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(95, 13);
            this.label84.TabIndex = 0;
            this.label84.Text = "Post-fit Blank (sec)";
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.Location = new System.Drawing.Point(2, 23);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(104, 13);
            this.label88.TabIndex = 3;
            this.label88.Text = "Half Width (samples)";
            // 
            // numericUpDown_salpa_delta
            // 
            this.numericUpDown_salpa_delta.Location = new System.Drawing.Point(114, 124);
            this.numericUpDown_salpa_delta.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_salpa_delta.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown_salpa_delta.Name = "numericUpDown_salpa_delta";
            this.numericUpDown_salpa_delta.ReadOnly = true;
            this.numericUpDown_salpa_delta.Size = new System.Drawing.Size(112, 20);
            this.numericUpDown_salpa_delta.TabIndex = 0;
            this.numericUpDown_salpa_delta.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_salpa_delta.ValueChanged += new System.EventHandler(this.numericUpDown_salpa_delta_ValueChanged);
            // 
            // numericUpDown_salpa_postpegzeros
            // 
            this.numericUpDown_salpa_postpegzeros.DecimalPlaces = 4;
            this.numericUpDown_salpa_postpegzeros.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.numericUpDown_salpa_postpegzeros.Location = new System.Drawing.Point(114, 89);
            this.numericUpDown_salpa_postpegzeros.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            262144});
            this.numericUpDown_salpa_postpegzeros.Name = "numericUpDown_salpa_postpegzeros";
            this.numericUpDown_salpa_postpegzeros.ReadOnly = true;
            this.numericUpDown_salpa_postpegzeros.Size = new System.Drawing.Size(112, 20);
            this.numericUpDown_salpa_postpegzeros.TabIndex = 1;
            this.numericUpDown_salpa_postpegzeros.Value = new decimal(new int[] {
            2,
            0,
            0,
            262144});
            this.numericUpDown_salpa_postpegzeros.ValueChanged += new System.EventHandler(this.numericUpDown_salpa_postpegzeros_ValueChanged);
            // 
            // numericUpDown_salpa_postpeg
            // 
            this.numericUpDown_salpa_postpeg.DecimalPlaces = 4;
            this.numericUpDown_salpa_postpeg.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.numericUpDown_salpa_postpeg.Location = new System.Drawing.Point(114, 54);
            this.numericUpDown_salpa_postpeg.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            196608});
            this.numericUpDown_salpa_postpeg.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDown_salpa_postpeg.Name = "numericUpDown_salpa_postpeg";
            this.numericUpDown_salpa_postpeg.ReadOnly = true;
            this.numericUpDown_salpa_postpeg.Size = new System.Drawing.Size(112, 20);
            this.numericUpDown_salpa_postpeg.TabIndex = 2;
            this.numericUpDown_salpa_postpeg.Value = new decimal(new int[] {
            2,
            0,
            0,
            196608});
            this.numericUpDown_salpa_postpeg.ValueChanged += new System.EventHandler(this.numericUpDown_salpa_postpeg_ValueChanged);
            // 
            // numericUpDown_salpa_halfwidth
            // 
            this.numericUpDown_salpa_halfwidth.Location = new System.Drawing.Point(114, 19);
            this.numericUpDown_salpa_halfwidth.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_salpa_halfwidth.Name = "numericUpDown_salpa_halfwidth";
            this.numericUpDown_salpa_halfwidth.ReadOnly = true;
            this.numericUpDown_salpa_halfwidth.Size = new System.Drawing.Size(112, 20);
            this.numericUpDown_salpa_halfwidth.TabIndex = 14;
            this.numericUpDown_salpa_halfwidth.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numericUpDown_salpa_halfwidth.ValueChanged += new System.EventHandler(this.numericUpDown_salpa_halfwidth_ValueChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(13, 563);
            this.label18.Name = "label18";
            this.label18.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label18.Size = new System.Drawing.Size(162, 13);
            this.label18.TabIndex = 20;
            this.label18.Text = "BNC Output Ch # (Experimental):";
            // 
            // channelOut
            // 
            this.channelOut.Enabled = false;
            this.channelOut.Location = new System.Drawing.Point(190, 560);
            this.channelOut.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.channelOut.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.channelOut.Name = "channelOut";
            this.channelOut.Size = new System.Drawing.Size(53, 20);
            this.channelOut.TabIndex = 19;
            this.channelOut.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.BackColor = System.Drawing.Color.Transparent;
            this.label63.Font = new System.Drawing.Font("Calibri", 75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label63.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label63.Location = new System.Drawing.Point(-3, 436);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(260, 122);
            this.label63.TabIndex = 36;
            this.label63.Text = "BETA";
            this.label63.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(252, 600);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Recording Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox7);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.comboBox_numChannels);
            this.groupBox3.Location = new System.Drawing.Point(3, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(243, 144);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Global Properties";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.progressBar_train);
            this.groupBox7.Controls.Add(this.button_Train);
            this.groupBox7.Controls.Add(this.label_noise);
            this.groupBox7.Location = new System.Drawing.Point(6, 72);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(223, 64);
            this.groupBox7.TabIndex = 11;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Noise Training";
            // 
            // progressBar_train
            // 
            this.progressBar_train.Location = new System.Drawing.Point(9, 35);
            this.progressBar_train.Name = "progressBar_train";
            this.progressBar_train.Size = new System.Drawing.Size(127, 23);
            this.progressBar_train.TabIndex = 12;
            // 
            // button_Train
            // 
            this.button_Train.Location = new System.Drawing.Point(142, 35);
            this.button_Train.Name = "button_Train";
            this.button_Train.Size = new System.Drawing.Size(75, 23);
            this.button_Train.TabIndex = 4;
            this.button_Train.Text = "Train";
            this.button_Train.UseVisualStyleBackColor = true;
            this.button_Train.Click += new System.EventHandler(this.button_Train_Click);
            // 
            // label_noise
            // 
            this.label_noise.AutoSize = true;
            this.label_noise.ForeColor = System.Drawing.Color.Red;
            this.label_noise.Location = new System.Drawing.Point(6, 16);
            this.label_noise.Name = "label_noise";
            this.label_noise.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_noise.Size = new System.Drawing.Size(171, 13);
            this.label_noise.TabIndex = 10;
            this.label_noise.Text = "Noise levels have not been trained";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 22);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Num. Channels:";
            // 
            // comboBox_numChannels
            // 
            this.comboBox_numChannels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_numChannels.FormattingEnabled = true;
            this.comboBox_numChannels.Items.AddRange(new object[] {
            "16",
            "32",
            "64"});
            this.comboBox_numChannels.Location = new System.Drawing.Point(130, 19);
            this.comboBox_numChannels.Name = "comboBox_numChannels";
            this.comboBox_numChannels.Size = new System.Drawing.Size(107, 21);
            this.comboBox_numChannels.TabIndex = 2;
            this.comboBox_numChannels.SelectedIndexChanged += new System.EventHandler(this.comboBox_numChannels_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button_lfpSamplingRate);
            this.groupBox2.Controls.Add(this.button_spikeSamplingRate);
            this.groupBox2.Controls.Add(this.label73);
            this.groupBox2.Controls.Add(this.textBox_MUASamplingRate);
            this.groupBox2.Controls.Add(this.comboBox_LFPGain);
            this.groupBox2.Controls.Add(this.label38);
            this.groupBox2.Controls.Add(this.comboBox_SpikeGain);
            this.groupBox2.Controls.Add(this.label_SpikeGain);
            this.groupBox2.Controls.Add(this.label_LFPSamplingRate);
            this.groupBox2.Controls.Add(this.label_SpikeSamplingRate);
            this.groupBox2.Controls.Add(this.textBox_spikeSamplingRate);
            this.groupBox2.Controls.Add(this.textBox_lfpSamplingRate);
            this.groupBox2.Location = new System.Drawing.Point(3, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 124);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recording Properties";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(204, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button_lfpSamplingRate
            // 
            this.button_lfpSamplingRate.Location = new System.Drawing.Point(204, 43);
            this.button_lfpSamplingRate.Name = "button_lfpSamplingRate";
            this.button_lfpSamplingRate.Size = new System.Drawing.Size(33, 23);
            this.button_lfpSamplingRate.TabIndex = 14;
            this.button_lfpSamplingRate.Text = "OK";
            this.button_lfpSamplingRate.UseVisualStyleBackColor = true;
            this.button_lfpSamplingRate.Click += new System.EventHandler(this.button_lfpSamplingRate_Click);
            // 
            // button_spikeSamplingRate
            // 
            this.button_spikeSamplingRate.Location = new System.Drawing.Point(204, 17);
            this.button_spikeSamplingRate.Name = "button_spikeSamplingRate";
            this.button_spikeSamplingRate.Size = new System.Drawing.Size(33, 23);
            this.button_spikeSamplingRate.TabIndex = 13;
            this.button_spikeSamplingRate.Text = "OK";
            this.button_spikeSamplingRate.UseVisualStyleBackColor = true;
            this.button_spikeSamplingRate.Click += new System.EventHandler(this.button_spikeSamplingRate_Click);
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Location = new System.Drawing.Point(6, 74);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(131, 13);
            this.label73.TabIndex = 11;
            this.label73.Text = "MUA Sampling Rate (Hz): ";
            // 
            // textBox_MUASamplingRate
            // 
            this.textBox_MUASamplingRate.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_MUASamplingRate.Location = new System.Drawing.Point(142, 71);
            this.textBox_MUASamplingRate.Name = "textBox_MUASamplingRate";
            this.textBox_MUASamplingRate.Size = new System.Drawing.Size(56, 20);
            this.textBox_MUASamplingRate.TabIndex = 12;
            this.textBox_MUASamplingRate.Text = "2000";
            this.textBox_MUASamplingRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // comboBox_LFPGain
            // 
            this.comboBox_LFPGain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_LFPGain.FormattingEnabled = true;
            this.comboBox_LFPGain.Items.AddRange(new object[] {
            "1",
            "2",
            "5",
            "10",
            "20",
            "50",
            "100"});
            this.comboBox_LFPGain.Location = new System.Drawing.Point(190, 97);
            this.comboBox_LFPGain.Name = "comboBox_LFPGain";
            this.comboBox_LFPGain.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox_LFPGain.Size = new System.Drawing.Size(47, 21);
            this.comboBox_LFPGain.TabIndex = 8;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(130, 100);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(54, 13);
            this.label38.TabIndex = 10;
            this.label38.Text = "LFP Gain:";
            // 
            // label_SpikeGain
            // 
            this.label_SpikeGain.AutoSize = true;
            this.label_SpikeGain.Location = new System.Drawing.Point(5, 100);
            this.label_SpikeGain.Name = "label_SpikeGain";
            this.label_SpikeGain.Size = new System.Drawing.Size(55, 13);
            this.label_SpikeGain.TabIndex = 8;
            this.label_SpikeGain.Text = "A/D Gain:";
            // 
            // label_LFPSamplingRate
            // 
            this.label_LFPSamplingRate.AutoSize = true;
            this.label_LFPSamplingRate.Location = new System.Drawing.Point(6, 48);
            this.label_LFPSamplingRate.Name = "label_LFPSamplingRate";
            this.label_LFPSamplingRate.Size = new System.Drawing.Size(126, 13);
            this.label_LFPSamplingRate.TabIndex = 2;
            this.label_LFPSamplingRate.Text = "LFP Sampling Rate (Hz): ";
            // 
            // label_SpikeSamplingRate
            // 
            this.label_SpikeSamplingRate.AutoSize = true;
            this.label_SpikeSamplingRate.Location = new System.Drawing.Point(6, 22);
            this.label_SpikeSamplingRate.Name = "label_SpikeSamplingRate";
            this.label_SpikeSamplingRate.Size = new System.Drawing.Size(126, 13);
            this.label_SpikeSamplingRate.TabIndex = 1;
            this.label_SpikeSamplingRate.Text = "Raw Sampling Rate (Hz):";
            // 
            // textBox_spikeSamplingRate
            // 
            this.textBox_spikeSamplingRate.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_spikeSamplingRate.Location = new System.Drawing.Point(142, 18);
            this.textBox_spikeSamplingRate.Name = "textBox_spikeSamplingRate";
            this.textBox_spikeSamplingRate.Size = new System.Drawing.Size(56, 20);
            this.textBox_spikeSamplingRate.TabIndex = 5;
            this.textBox_spikeSamplingRate.Text = "25000";
            this.textBox_spikeSamplingRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_lfpSamplingRate
            // 
            this.textBox_lfpSamplingRate.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_lfpSamplingRate.Location = new System.Drawing.Point(142, 45);
            this.textBox_lfpSamplingRate.Name = "textBox_lfpSamplingRate";
            this.textBox_lfpSamplingRate.Size = new System.Drawing.Size(56, 20);
            this.textBox_lfpSamplingRate.TabIndex = 6;
            this.textBox_lfpSamplingRate.Text = "2000";
            this.textBox_lfpSamplingRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // spkWfmPlot1
            // 
            this.spkWfmPlot1.XAxis = this.xAxis3;
            this.spkWfmPlot1.YAxis = this.yAxis3;
            // 
            // xAxis3
            // 
            this.xAxis3.AutoSpacing = false;
            this.xAxis3.Mode = NationalInstruments.UI.AxisMode.Fixed;
            this.xAxis3.Visible = false;
            // 
            // yAxis3
            // 
            this.yAxis3.AutoSpacing = false;
            this.yAxis3.Mode = NationalInstruments.UI.AxisMode.Fixed;
            this.yAxis3.Visible = false;
            // 
            // timer_timeElapsed
            // 
            this.timer_timeElapsed.Interval = 1000;
            this.timer_timeElapsed.Tick += new System.EventHandler(this.timer_timeElapsed_Tick);
            // 
            // imageList_zoomButtons
            // 
            this.imageList_zoomButtons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_zoomButtons.ImageStream")));
            this.imageList_zoomButtons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_zoomButtons.Images.SetKeyName(0, "ZoomInBlue.png");
            this.imageList_zoomButtons.Images.SetKeyName(1, "ZoomInBlueBright.png");
            this.imageList_zoomButtons.Images.SetKeyName(2, "ZoomOutBlue.png");
            this.imageList_zoomButtons.Images.SetKeyName(3, "ZoomOutBlueBright.png");
            this.imageList_zoomButtons.Images.SetKeyName(4, "ZoomResetBlue.png");
            this.imageList_zoomButtons.Images.SetKeyName(5, "ZoomResetBlueBright.png");
            // 
            // tabPage_diagnostics
            // 
            this.tabPage_diagnostics.Controls.Add(this.checkBox_diagnosticsDigitalFilter);
            this.tabPage_diagnostics.Controls.Add(this.textBox_diagnosticsMult);
            this.tabPage_diagnostics.Controls.Add(this.textBox_voltageDivider);
            this.tabPage_diagnostics.Controls.Add(this.textBox_diagnosticsResults);
            this.tabPage_diagnostics.Controls.Add(this.scatterGraph_diagnostics);
            this.tabPage_diagnostics.Controls.Add(this.label56);
            this.tabPage_diagnostics.Controls.Add(this.label55);
            this.tabPage_diagnostics.Controls.Add(this.checkBox_diagnosticsVotlageDivider);
            this.tabPage_diagnostics.Controls.Add(this.checkBox_diagnosticsBulk);
            this.tabPage_diagnostics.Controls.Add(this.label42);
            this.tabPage_diagnostics.Controls.Add(this.numericUpDown_numPeriods);
            this.tabPage_diagnostics.Controls.Add(this.label41);
            this.tabPage_diagnostics.Controls.Add(this.numericUpDown_diagnosticsVoltage);
            this.tabPage_diagnostics.Controls.Add(this.label40);
            this.tabPage_diagnostics.Controls.Add(this.label39);
            this.tabPage_diagnostics.Controls.Add(this.numericUpDown_startFreq);
            this.tabPage_diagnostics.Controls.Add(this.numericUpDown_stopFreq);
            this.tabPage_diagnostics.Controls.Add(this.button_computeGain);
            this.tabPage_diagnostics.Location = new System.Drawing.Point(4, 22);
            this.tabPage_diagnostics.Name = "tabPage_diagnostics";
            this.tabPage_diagnostics.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_diagnostics.Size = new System.Drawing.Size(941, 780);
            this.tabPage_diagnostics.TabIndex = 6;
            this.tabPage_diagnostics.Text = "Diagnostics";
            this.tabPage_diagnostics.UseVisualStyleBackColor = true;
            // 
            // checkBox_diagnosticsDigitalFilter
            // 
            this.checkBox_diagnosticsDigitalFilter.AutoSize = true;
            this.checkBox_diagnosticsDigitalFilter.Location = new System.Drawing.Point(643, 253);
            this.checkBox_diagnosticsDigitalFilter.Name = "checkBox_diagnosticsDigitalFilter";
            this.checkBox_diagnosticsDigitalFilter.Size = new System.Drawing.Size(80, 17);
            this.checkBox_diagnosticsDigitalFilter.TabIndex = 9;
            this.checkBox_diagnosticsDigitalFilter.Text = "Digital Filter";
            this.checkBox_diagnosticsDigitalFilter.UseVisualStyleBackColor = true;
            // 
            // textBox_diagnosticsMult
            // 
            this.textBox_diagnosticsMult.Location = new System.Drawing.Point(827, 89);
            this.textBox_diagnosticsMult.Name = "textBox_diagnosticsMult";
            this.textBox_diagnosticsMult.Size = new System.Drawing.Size(46, 20);
            this.textBox_diagnosticsMult.TabIndex = 3;
            this.textBox_diagnosticsMult.Text = "1.5";
            // 
            // textBox_voltageDivider
            // 
            this.textBox_voltageDivider.Location = new System.Drawing.Point(773, 223);
            this.textBox_voltageDivider.Name = "textBox_voltageDivider";
            this.textBox_voltageDivider.Size = new System.Drawing.Size(100, 20);
            this.textBox_voltageDivider.TabIndex = 8;
            // 
            // textBox_diagnosticsResults
            // 
            this.textBox_diagnosticsResults.Location = new System.Drawing.Point(6, 423);
            this.textBox_diagnosticsResults.MaxLength = 327670;
            this.textBox_diagnosticsResults.Multiline = true;
            this.textBox_diagnosticsResults.Name = "textBox_diagnosticsResults";
            this.textBox_diagnosticsResults.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_diagnosticsResults.Size = new System.Drawing.Size(628, 348);
            this.textBox_diagnosticsResults.TabIndex = 10;
            // 
            // scatterGraph_diagnostics
            // 
            this.scatterGraph_diagnostics.Location = new System.Drawing.Point(3, 3);
            this.scatterGraph_diagnostics.Name = "scatterGraph_diagnostics";
            this.scatterGraph_diagnostics.Plots.AddRange(new NationalInstruments.UI.ScatterPlot[] {
            this.scatterPlot1});
            this.scatterGraph_diagnostics.Size = new System.Drawing.Size(631, 414);
            this.scatterGraph_diagnostics.TabIndex = 13;
            this.scatterGraph_diagnostics.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis4});
            this.scatterGraph_diagnostics.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis4});
            // 
            // scatterPlot1
            // 
            this.scatterPlot1.XAxis = this.xAxis4;
            this.scatterPlot1.YAxis = this.yAxis4;
            // 
            // xAxis4
            // 
            this.xAxis4.Caption = "Frequency (Hz)";
            this.xAxis4.ScaleType = NationalInstruments.UI.ScaleType.Logarithmic;
            // 
            // yAxis4
            // 
            this.yAxis4.Caption = "Gain (dB)";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(640, 92);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(181, 13);
            this.label56.TabIndex = 20;
            this.label56.Text = "Step between Frequencies (multiple):";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(713, 226);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(54, 13);
            this.label55.TabIndex = 18;
            this.label55.Text = "Divide by:";
            // 
            // checkBox_diagnosticsVotlageDivider
            // 
            this.checkBox_diagnosticsVotlageDivider.AutoSize = true;
            this.checkBox_diagnosticsVotlageDivider.Location = new System.Drawing.Point(643, 200);
            this.checkBox_diagnosticsVotlageDivider.Name = "checkBox_diagnosticsVotlageDivider";
            this.checkBox_diagnosticsVotlageDivider.Size = new System.Drawing.Size(145, 17);
            this.checkBox_diagnosticsVotlageDivider.TabIndex = 7;
            this.checkBox_diagnosticsVotlageDivider.Text = "External Voltage Divider?";
            this.checkBox_diagnosticsVotlageDivider.UseVisualStyleBackColor = true;
            // 
            // checkBox_diagnosticsBulk
            // 
            this.checkBox_diagnosticsBulk.AutoSize = true;
            this.checkBox_diagnosticsBulk.Location = new System.Drawing.Point(643, 177);
            this.checkBox_diagnosticsBulk.Name = "checkBox_diagnosticsBulk";
            this.checkBox_diagnosticsBulk.Size = new System.Drawing.Size(257, 17);
            this.checkBox_diagnosticsBulk.TabIndex = 6;
            this.checkBox_diagnosticsBulk.Text = "All channels at once (requires special hardware)?";
            this.checkBox_diagnosticsBulk.UseVisualStyleBackColor = true;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(640, 144);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(87, 13);
            this.label42.TabIndex = 12;
            this.label42.Text = "Periods per freq.:";
            // 
            // numericUpDown_numPeriods
            // 
            this.numericUpDown_numPeriods.DecimalPlaces = 1;
            this.numericUpDown_numPeriods.Location = new System.Drawing.Point(753, 142);
            this.numericUpDown_numPeriods.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_numPeriods.Name = "numericUpDown_numPeriods";
            this.numericUpDown_numPeriods.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_numPeriods.TabIndex = 5;
            this.numericUpDown_numPeriods.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(640, 118);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(89, 13);
            this.label41.TabIndex = 10;
            this.label41.Text = "Input Voltage (V):";
            // 
            // numericUpDown_diagnosticsVoltage
            // 
            this.numericUpDown_diagnosticsVoltage.DecimalPlaces = 3;
            this.numericUpDown_diagnosticsVoltage.Location = new System.Drawing.Point(753, 116);
            this.numericUpDown_diagnosticsVoltage.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_diagnosticsVoltage.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericUpDown_diagnosticsVoltage.Name = "numericUpDown_diagnosticsVoltage";
            this.numericUpDown_diagnosticsVoltage.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_diagnosticsVoltage.TabIndex = 4;
            this.numericUpDown_diagnosticsVoltage.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(640, 66);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(107, 13);
            this.label40.TabIndex = 8;
            this.label40.Text = "Stop Frequency (Hz):";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(640, 40);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(107, 13);
            this.label39.TabIndex = 7;
            this.label39.Text = "Start Frequency (Hz):";
            // 
            // numericUpDown_startFreq
            // 
            this.numericUpDown_startFreq.DecimalPlaces = 1;
            this.numericUpDown_startFreq.Location = new System.Drawing.Point(753, 38);
            this.numericUpDown_startFreq.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_startFreq.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_startFreq.Name = "numericUpDown_startFreq";
            this.numericUpDown_startFreq.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_startFreq.TabIndex = 1;
            this.numericUpDown_startFreq.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_stopFreq
            // 
            this.numericUpDown_stopFreq.DecimalPlaces = 1;
            this.numericUpDown_stopFreq.Location = new System.Drawing.Point(753, 64);
            this.numericUpDown_stopFreq.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown_stopFreq.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_stopFreq.Name = "numericUpDown_stopFreq";
            this.numericUpDown_stopFreq.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_stopFreq.TabIndex = 2;
            this.numericUpDown_stopFreq.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // button_computeGain
            // 
            this.button_computeGain.Location = new System.Drawing.Point(798, 283);
            this.button_computeGain.Name = "button_computeGain";
            this.button_computeGain.Size = new System.Drawing.Size(75, 23);
            this.button_computeGain.TabIndex = 0;
            this.button_computeGain.Text = "Start";
            this.button_computeGain.UseVisualStyleBackColor = true;
            this.button_computeGain.Click += new System.EventHandler(this.button_computeGain_Click);
            // 
            // tabPage_impedance
            // 
            this.tabPage_impedance.Controls.Add(this.button_impedanceSaveAsMAT);
            this.tabPage_impedance.Controls.Add(this.groupBox21);
            this.tabPage_impedance.Controls.Add(this.button_impedanceCopyDataToClipboard);
            this.tabPage_impedance.Controls.Add(this.scatterGraph_impedance);
            this.tabPage_impedance.Controls.Add(this.groupBox17);
            this.tabPage_impedance.Controls.Add(this.groupBox16);
            this.tabPage_impedance.Controls.Add(this.button_impedanceTest);
            this.tabPage_impedance.Controls.Add(this.button_impedanceCancel);
            this.tabPage_impedance.Location = new System.Drawing.Point(4, 22);
            this.tabPage_impedance.Name = "tabPage_impedance";
            this.tabPage_impedance.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_impedance.Size = new System.Drawing.Size(941, 780);
            this.tabPage_impedance.TabIndex = 5;
            this.tabPage_impedance.Text = "Impedance";
            this.tabPage_impedance.UseVisualStyleBackColor = true;
            // 
            // button_impedanceSaveAsMAT
            // 
            this.button_impedanceSaveAsMAT.Location = new System.Drawing.Point(810, 170);
            this.button_impedanceSaveAsMAT.Name = "button_impedanceSaveAsMAT";
            this.button_impedanceSaveAsMAT.Size = new System.Drawing.Size(111, 41);
            this.button_impedanceSaveAsMAT.TabIndex = 7;
            this.button_impedanceSaveAsMAT.Text = "Save Data as Matlab MAT File";
            this.button_impedanceSaveAsMAT.UseVisualStyleBackColor = true;
            this.button_impedanceSaveAsMAT.Click += new System.EventHandler(this.button_impedanceSaveAsMAT_Click);
            // 
            // groupBox21
            // 
            this.groupBox21.Controls.Add(this.checkBox_impedanceAllChannels);
            this.groupBox21.Controls.Add(this.numericUpDown_impChannel);
            this.groupBox21.Location = new System.Drawing.Point(10, 6);
            this.groupBox21.Name = "groupBox21";
            this.groupBox21.Size = new System.Drawing.Size(209, 51);
            this.groupBox21.TabIndex = 2;
            this.groupBox21.TabStop = false;
            this.groupBox21.Text = "Channel";
            // 
            // checkBox_impedanceAllChannels
            // 
            this.checkBox_impedanceAllChannels.AutoSize = true;
            this.checkBox_impedanceAllChannels.Location = new System.Drawing.Point(117, 20);
            this.checkBox_impedanceAllChannels.Name = "checkBox_impedanceAllChannels";
            this.checkBox_impedanceAllChannels.Size = new System.Drawing.Size(84, 17);
            this.checkBox_impedanceAllChannels.TabIndex = 1;
            this.checkBox_impedanceAllChannels.Text = "All Channels";
            this.checkBox_impedanceAllChannels.UseVisualStyleBackColor = true;
            this.checkBox_impedanceAllChannels.CheckedChanged += new System.EventHandler(this.checkBox_impedanceAllChannels_CheckedChanged);
            // 
            // numericUpDown_impChannel
            // 
            this.numericUpDown_impChannel.Location = new System.Drawing.Point(6, 19);
            this.numericUpDown_impChannel.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numericUpDown_impChannel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_impChannel.Name = "numericUpDown_impChannel";
            this.numericUpDown_impChannel.Size = new System.Drawing.Size(105, 20);
            this.numericUpDown_impChannel.TabIndex = 0;
            this.numericUpDown_impChannel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_impChannel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button_impedanceCopyDataToClipboard
            // 
            this.button_impedanceCopyDataToClipboard.Location = new System.Drawing.Point(810, 124);
            this.button_impedanceCopyDataToClipboard.Name = "button_impedanceCopyDataToClipboard";
            this.button_impedanceCopyDataToClipboard.Size = new System.Drawing.Size(111, 40);
            this.button_impedanceCopyDataToClipboard.TabIndex = 6;
            this.button_impedanceCopyDataToClipboard.Text = "Copy Data to Clipboard";
            this.button_impedanceCopyDataToClipboard.UseVisualStyleBackColor = true;
            this.button_impedanceCopyDataToClipboard.Click += new System.EventHandler(this.button_impedanceCopyDataToClipboard_Click);
            // 
            // scatterGraph_impedance
            // 
            this.scatterGraph_impedance.Location = new System.Drawing.Point(10, 220);
            this.scatterGraph_impedance.Name = "scatterGraph_impedance";
            this.scatterGraph_impedance.Plots.AddRange(new NationalInstruments.UI.ScatterPlot[] {
            this.scatterPlot2});
            this.scatterGraph_impedance.Size = new System.Drawing.Size(925, 553);
            this.scatterGraph_impedance.TabIndex = 25;
            this.scatterGraph_impedance.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis2});
            this.scatterGraph_impedance.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis2});
            // 
            // scatterPlot2
            // 
            this.scatterPlot2.ProcessSpecialValues = true;
            this.scatterPlot2.XAxis = this.xAxis2;
            this.scatterPlot2.YAxis = this.yAxis2;
            // 
            // xAxis2
            // 
            this.xAxis2.Caption = "Frequency (Hz)";
            this.xAxis2.ScaleType = NationalInstruments.UI.ScaleType.Logarithmic;
            // 
            // yAxis2
            // 
            this.yAxis2.Caption = "Impedance (Ohms)";
            this.yAxis2.ScaleType = NationalInstruments.UI.ScaleType.Logarithmic;
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.textBox_impedanceResults);
            this.groupBox17.Location = new System.Drawing.Point(10, 93);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(209, 115);
            this.groupBox17.TabIndex = 3;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "Results (Ohms)";
            // 
            // textBox_impedanceResults
            // 
            this.textBox_impedanceResults.Location = new System.Drawing.Point(6, 19);
            this.textBox_impedanceResults.Multiline = true;
            this.textBox_impedanceResults.Name = "textBox_impedanceResults";
            this.textBox_impedanceResults.Size = new System.Drawing.Size(195, 87);
            this.textBox_impedanceResults.TabIndex = 0;
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.label_impedanceProgress);
            this.groupBox16.Controls.Add(this.progressBar_impedance);
            this.groupBox16.Controls.Add(this.checkBox_impUseMatchedFilter);
            this.groupBox16.Controls.Add(this.checkBox_impBandpassFilter);
            this.groupBox16.Controls.Add(this.label32);
            this.groupBox16.Controls.Add(this.label45);
            this.groupBox16.Controls.Add(this.numericUpDown_impNumPeriods);
            this.groupBox16.Controls.Add(this.label46);
            this.groupBox16.Controls.Add(this.numericUpDown_impStartFreq);
            this.groupBox16.Controls.Add(this.label43);
            this.groupBox16.Controls.Add(this.numericUpDown_impStopFreq);
            this.groupBox16.Controls.Add(this.numericUpDown_impCommandVoltage);
            this.groupBox16.Controls.Add(this.label30);
            this.groupBox16.Controls.Add(this.label29);
            this.groupBox16.Controls.Add(this.label28);
            this.groupBox16.Controls.Add(this.numericUpDown_RMeas);
            this.groupBox16.Controls.Add(this.numericUpDown_RGain);
            this.groupBox16.Controls.Add(this.numericUpDown_RCurr);
            this.groupBox16.Controls.Add(this.groupBox15);
            this.groupBox16.Location = new System.Drawing.Point(233, 15);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(383, 197);
            this.groupBox16.TabIndex = 4;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Parameters";
            // 
            // label_impedanceProgress
            // 
            this.label_impedanceProgress.AutoSize = true;
            this.label_impedanceProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_impedanceProgress.ForeColor = System.Drawing.Color.DimGray;
            this.label_impedanceProgress.Location = new System.Drawing.Point(273, 59);
            this.label_impedanceProgress.Name = "label_impedanceProgress";
            this.label_impedanceProgress.Size = new System.Drawing.Size(104, 13);
            this.label_impedanceProgress.TabIndex = 26;
            this.label_impedanceProgress.Text = "Impedance Progress";
            // 
            // progressBar_impedance
            // 
            this.progressBar_impedance.Location = new System.Drawing.Point(180, 27);
            this.progressBar_impedance.Name = "progressBar_impedance";
            this.progressBar_impedance.Size = new System.Drawing.Size(197, 25);
            this.progressBar_impedance.TabIndex = 25;
            // 
            // checkBox_impUseMatchedFilter
            // 
            this.checkBox_impUseMatchedFilter.AutoSize = true;
            this.checkBox_impUseMatchedFilter.Checked = true;
            this.checkBox_impUseMatchedFilter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_impUseMatchedFilter.Location = new System.Drawing.Point(183, 177);
            this.checkBox_impUseMatchedFilter.Name = "checkBox_impUseMatchedFilter";
            this.checkBox_impUseMatchedFilter.Size = new System.Drawing.Size(115, 17);
            this.checkBox_impUseMatchedFilter.TabIndex = 9;
            this.checkBox_impUseMatchedFilter.Text = "Use Matched Filter";
            this.checkBox_impUseMatchedFilter.UseVisualStyleBackColor = true;
            // 
            // checkBox_impBandpassFilter
            // 
            this.checkBox_impBandpassFilter.AutoSize = true;
            this.checkBox_impBandpassFilter.Location = new System.Drawing.Point(183, 150);
            this.checkBox_impBandpassFilter.Name = "checkBox_impBandpassFilter";
            this.checkBox_impBandpassFilter.Size = new System.Drawing.Size(120, 17);
            this.checkBox_impBandpassFilter.TabIndex = 8;
            this.checkBox_impBandpassFilter.Text = "Use Bandpass Filter";
            this.checkBox_impBandpassFilter.UseVisualStyleBackColor = true;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(43, 175);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(62, 13);
            this.label32.TabIndex = 14;
            this.label32.Text = "Voltage (V):";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(180, 126);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(107, 13);
            this.label45.TabIndex = 20;
            this.label45.Text = "Stop Frequency (Hz):";
            // 
            // numericUpDown_impNumPeriods
            // 
            this.numericUpDown_impNumPeriods.DecimalPlaces = 1;
            this.numericUpDown_impNumPeriods.Location = new System.Drawing.Point(111, 69);
            this.numericUpDown_impNumPeriods.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_impNumPeriods.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_impNumPeriods.Name = "numericUpDown_impNumPeriods";
            this.numericUpDown_impNumPeriods.Size = new System.Drawing.Size(63, 20);
            this.numericUpDown_impNumPeriods.TabIndex = 1;
            this.numericUpDown_impNumPeriods.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_impNumPeriods.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(180, 100);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(107, 13);
            this.label46.TabIndex = 19;
            this.label46.Text = "Start Frequency (Hz):";
            // 
            // numericUpDown_impStartFreq
            // 
            this.numericUpDown_impStartFreq.DecimalPlaces = 1;
            this.numericUpDown_impStartFreq.Location = new System.Drawing.Point(293, 98);
            this.numericUpDown_impStartFreq.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_impStartFreq.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_impStartFreq.Name = "numericUpDown_impStartFreq";
            this.numericUpDown_impStartFreq.Size = new System.Drawing.Size(77, 20);
            this.numericUpDown_impStartFreq.TabIndex = 6;
            this.numericUpDown_impStartFreq.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(18, 71);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(87, 13);
            this.label43.TabIndex = 24;
            this.label43.Text = "Periods per freq.:";
            // 
            // numericUpDown_impStopFreq
            // 
            this.numericUpDown_impStopFreq.DecimalPlaces = 1;
            this.numericUpDown_impStopFreq.Location = new System.Drawing.Point(293, 124);
            this.numericUpDown_impStopFreq.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_impStopFreq.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_impStopFreq.Name = "numericUpDown_impStopFreq";
            this.numericUpDown_impStopFreq.Size = new System.Drawing.Size(77, 20);
            this.numericUpDown_impStopFreq.TabIndex = 7;
            this.numericUpDown_impStopFreq.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // numericUpDown_impCommandVoltage
            // 
            this.numericUpDown_impCommandVoltage.DecimalPlaces = 2;
            this.numericUpDown_impCommandVoltage.Location = new System.Drawing.Point(111, 173);
            this.numericUpDown_impCommandVoltage.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_impCommandVoltage.Name = "numericUpDown_impCommandVoltage";
            this.numericUpDown_impCommandVoltage.Size = new System.Drawing.Size(63, 20);
            this.numericUpDown_impCommandVoltage.TabIndex = 5;
            this.numericUpDown_impCommandVoltage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_impCommandVoltage.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(19, 149);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(86, 13);
            this.label30.TabIndex = 12;
            this.label30.Text = "R_Meas (Ohms):";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(23, 123);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(82, 13);
            this.label29.TabIndex = 11;
            this.label29.Text = "R_Gain (Ohms):";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(12, 97);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(93, 13);
            this.label28.TabIndex = 10;
            this.label28.Text = "R_current (Ohms):";
            // 
            // numericUpDown_RMeas
            // 
            this.numericUpDown_RMeas.Location = new System.Drawing.Point(111, 147);
            this.numericUpDown_RMeas.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_RMeas.Name = "numericUpDown_RMeas";
            this.numericUpDown_RMeas.Size = new System.Drawing.Size(63, 20);
            this.numericUpDown_RMeas.TabIndex = 4;
            this.numericUpDown_RMeas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_RMeas.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDown_RGain
            // 
            this.numericUpDown_RGain.Location = new System.Drawing.Point(111, 121);
            this.numericUpDown_RGain.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDown_RGain.Name = "numericUpDown_RGain";
            this.numericUpDown_RGain.Size = new System.Drawing.Size(63, 20);
            this.numericUpDown_RGain.TabIndex = 3;
            this.numericUpDown_RGain.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_RGain.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDown_RCurr
            // 
            this.numericUpDown_RCurr.Location = new System.Drawing.Point(111, 95);
            this.numericUpDown_RCurr.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_RCurr.Name = "numericUpDown_RCurr";
            this.numericUpDown_RCurr.Size = new System.Drawing.Size(63, 20);
            this.numericUpDown_RCurr.TabIndex = 2;
            this.numericUpDown_RCurr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_RCurr.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.radioButton_impVoltage);
            this.groupBox15.Controls.Add(this.radioButton_impCurrent);
            this.groupBox15.Location = new System.Drawing.Point(6, 19);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(168, 39);
            this.groupBox15.TabIndex = 0;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Current vs. Voltage Control";
            // 
            // radioButton_impVoltage
            // 
            this.radioButton_impVoltage.AutoSize = true;
            this.radioButton_impVoltage.Location = new System.Drawing.Point(81, 16);
            this.radioButton_impVoltage.Name = "radioButton_impVoltage";
            this.radioButton_impVoltage.Size = new System.Drawing.Size(61, 17);
            this.radioButton_impVoltage.TabIndex = 1;
            this.radioButton_impVoltage.Text = "Voltage";
            this.radioButton_impVoltage.UseVisualStyleBackColor = true;
            this.radioButton_impVoltage.Click += new System.EventHandler(this.radioButton_impVoltage_Click);
            // 
            // radioButton_impCurrent
            // 
            this.radioButton_impCurrent.AutoSize = true;
            this.radioButton_impCurrent.Checked = true;
            this.radioButton_impCurrent.Location = new System.Drawing.Point(6, 16);
            this.radioButton_impCurrent.Name = "radioButton_impCurrent";
            this.radioButton_impCurrent.Size = new System.Drawing.Size(59, 17);
            this.radioButton_impCurrent.TabIndex = 0;
            this.radioButton_impCurrent.TabStop = true;
            this.radioButton_impCurrent.Text = "Current";
            this.radioButton_impCurrent.UseVisualStyleBackColor = true;
            this.radioButton_impCurrent.Click += new System.EventHandler(this.radioButton_impCurrent_Click);
            // 
            // button_impedanceTest
            // 
            this.button_impedanceTest.Location = new System.Drawing.Point(16, 63);
            this.button_impedanceTest.Name = "button_impedanceTest";
            this.button_impedanceTest.Size = new System.Drawing.Size(95, 23);
            this.button_impedanceTest.TabIndex = 0;
            this.button_impedanceTest.Text = "Test impedance";
            this.button_impedanceTest.UseVisualStyleBackColor = true;
            this.button_impedanceTest.Click += new System.EventHandler(this.button_impedanceTest_Click);
            // 
            // button_impedanceCancel
            // 
            this.button_impedanceCancel.Enabled = false;
            this.button_impedanceCancel.Location = new System.Drawing.Point(117, 64);
            this.button_impedanceCancel.Name = "button_impedanceCancel";
            this.button_impedanceCancel.Size = new System.Drawing.Size(81, 23);
            this.button_impedanceCancel.TabIndex = 1;
            this.button_impedanceCancel.Text = "Cancel";
            this.button_impedanceCancel.UseVisualStyleBackColor = true;
            this.button_impedanceCancel.Click += new System.EventHandler(this.button_impedanceCancel_Click);
            // 
            // tabPage_stim
            // 
            this.tabPage_stim.Controls.Add(this.DebugButton);
            this.tabPage_stim.Controls.Add(this.groupBox33);
            this.tabPage_stim.Controls.Add(this.groupBox30);
            this.tabPage_stim.Controls.Add(this.button_showcase);
            this.tabPage_stim.Controls.Add(this.groupBox24);
            this.tabPage_stim.Controls.Add(this.groupBox23);
            this.tabPage_stim.Controls.Add(this.groupBox11);
            this.tabPage_stim.Controls.Add(this.groupBox22);
            this.tabPage_stim.Controls.Add(this.groupBox12);
            this.tabPage_stim.Controls.Add(this.groupBox9);
            this.tabPage_stim.Location = new System.Drawing.Point(4, 22);
            this.tabPage_stim.Name = "tabPage_stim";
            this.tabPage_stim.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_stim.Size = new System.Drawing.Size(941, 780);
            this.tabPage_stim.TabIndex = 4;
            this.tabPage_stim.Text = "Stim";
            this.tabPage_stim.UseVisualStyleBackColor = true;
            // 
            // DebugButton
            // 
            this.DebugButton.Location = new System.Drawing.Point(723, 225);
            this.DebugButton.Name = "DebugButton";
            this.DebugButton.Size = new System.Drawing.Size(126, 34);
            this.DebugButton.TabIndex = 13;
            this.DebugButton.Text = "Debug";
            this.DebugButton.UseVisualStyleBackColor = true;
            this.DebugButton.Click += new System.EventHandler(this.DebugButton_Click);
            // 
            // groupBox33
            // 
            this.groupBox33.Controls.Add(this.refreshClosedLoopButton);
            this.groupBox33.Controls.Add(this.pnpcl_available_dropdown);
            this.groupBox33.Controls.Add(this.progressBar_pnpcl);
            this.groupBox33.Controls.Add(this.stopPNPCL);
            this.groupBox33.Controls.Add(this.startPNPCL);
            this.groupBox33.Location = new System.Drawing.Point(644, 10);
            this.groupBox33.Name = "groupBox33";
            this.groupBox33.Size = new System.Drawing.Size(291, 191);
            this.groupBox33.TabIndex = 12;
            this.groupBox33.TabStop = false;
            this.groupBox33.Text = "Closed Loop Experiment (Experimental)";
            // 
            // refreshClosedLoopButton
            // 
            this.refreshClosedLoopButton.Location = new System.Drawing.Point(11, 19);
            this.refreshClosedLoopButton.Name = "refreshClosedLoopButton";
            this.refreshClosedLoopButton.Size = new System.Drawing.Size(60, 21);
            this.refreshClosedLoopButton.TabIndex = 39;
            this.refreshClosedLoopButton.Text = "Refresh";
            this.refreshClosedLoopButton.UseVisualStyleBackColor = true;
            this.refreshClosedLoopButton.Click += new System.EventHandler(this.refresh_closedloop_button_Click);
            // 
            // pnpcl_available_dropdown
            // 
            this.pnpcl_available_dropdown.FormattingEnabled = true;
            this.pnpcl_available_dropdown.Location = new System.Drawing.Point(81, 19);
            this.pnpcl_available_dropdown.Name = "pnpcl_available_dropdown";
            this.pnpcl_available_dropdown.Size = new System.Drawing.Size(180, 21);
            this.pnpcl_available_dropdown.TabIndex = 38;
            // 
            // progressBar_pnpcl
            // 
            this.progressBar_pnpcl.Location = new System.Drawing.Point(8, 140);
            this.progressBar_pnpcl.Name = "progressBar_pnpcl";
            this.progressBar_pnpcl.Size = new System.Drawing.Size(267, 23);
            this.progressBar_pnpcl.TabIndex = 37;
            // 
            // stopPNPCL
            // 
            this.stopPNPCL.Location = new System.Drawing.Point(154, 100);
            this.stopPNPCL.Name = "stopPNPCL";
            this.stopPNPCL.Size = new System.Drawing.Size(121, 34);
            this.stopPNPCL.TabIndex = 6;
            this.stopPNPCL.Text = "Stop Protocol";
            this.stopPNPCL.UseVisualStyleBackColor = true;
            this.stopPNPCL.Click += new System.EventHandler(this.stopPNPCL_Click);
            // 
            // startPNPCL
            // 
            this.startPNPCL.Location = new System.Drawing.Point(11, 100);
            this.startPNPCL.Name = "startPNPCL";
            this.startPNPCL.Size = new System.Drawing.Size(126, 34);
            this.startPNPCL.TabIndex = 0;
            this.startPNPCL.Text = "Start Protocol";
            this.startPNPCL.UseVisualStyleBackColor = true;
            this.startPNPCL.Click += new System.EventHandler(this.startPNPCL_Click);
            // 
            // groupBox30
            // 
            this.groupBox30.Controls.Add(this.checkBox_repeatOLStim);
            this.groupBox30.Controls.Add(this.checkBox_useManStimWaveform);
            this.groupBox30.Controls.Add(this.button_BrowseOLDFile);
            this.groupBox30.Controls.Add(this.textBox_digitalProtocolFileLocation);
            this.groupBox30.Controls.Add(this.label61);
            this.groupBox30.Controls.Add(this.button_BrowseOLStimFile);
            this.groupBox30.Controls.Add(this.progressBar_protocolFromFile);
            this.groupBox30.Controls.Add(this.button_stopStimFromFile);
            this.groupBox30.Controls.Add(this.textBox_protocolFileLocations);
            this.groupBox30.Controls.Add(this.label85);
            this.groupBox30.Controls.Add(this.button_startStimFromFile);
            this.groupBox30.Location = new System.Drawing.Point(341, 8);
            this.groupBox30.Name = "groupBox30";
            this.groupBox30.Size = new System.Drawing.Size(291, 271);
            this.groupBox30.TabIndex = 11;
            this.groupBox30.TabStop = false;
            this.groupBox30.Text = "Open Loop Experiment (Experimental)";
            // 
            // button_BrowseOLStimFile
            // 
            this.button_BrowseOLStimFile.Location = new System.Drawing.Point(260, 19);
            this.button_BrowseOLStimFile.Name = "button_BrowseOLStimFile";
            this.button_BrowseOLStimFile.Size = new System.Drawing.Size(25, 23);
            this.button_BrowseOLStimFile.TabIndex = 36;
            this.button_BrowseOLStimFile.Text = "...";
            this.button_BrowseOLStimFile.UseVisualStyleBackColor = true;
            this.button_BrowseOLStimFile.Click += new System.EventHandler(this.button_BrowseOLStimFile_Click);
            // 
            // progressBar_protocolFromFile
            // 
            this.progressBar_protocolFromFile.Location = new System.Drawing.Point(9, 232);
            this.progressBar_protocolFromFile.Name = "progressBar_protocolFromFile";
            this.progressBar_protocolFromFile.Size = new System.Drawing.Size(276, 23);
            this.progressBar_protocolFromFile.TabIndex = 37;
            // 
            // button_stopStimFromFile
            // 
            this.button_stopStimFromFile.Location = new System.Drawing.Point(164, 190);
            this.button_stopStimFromFile.Name = "button_stopStimFromFile";
            this.button_stopStimFromFile.Size = new System.Drawing.Size(121, 34);
            this.button_stopStimFromFile.TabIndex = 6;
            this.button_stopStimFromFile.Text = "Stop Protocol";
            this.button_stopStimFromFile.UseVisualStyleBackColor = true;
            this.button_stopStimFromFile.Click += new System.EventHandler(this.button_stopStimFromFile_Click);
            // 
            // textBox_protocolFileLocations
            // 
            this.textBox_protocolFileLocations.Location = new System.Drawing.Point(106, 21);
            this.textBox_protocolFileLocations.Name = "textBox_protocolFileLocations";
            this.textBox_protocolFileLocations.Size = new System.Drawing.Size(148, 20);
            this.textBox_protocolFileLocations.TabIndex = 5;
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.Location = new System.Drawing.Point(5, 25);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(103, 13);
            this.label85.TabIndex = 2;
            this.label85.Text = "Open Loop Stm. File";
            // 
            // button_startStimFromFile
            // 
            this.button_startStimFromFile.Location = new System.Drawing.Point(8, 190);
            this.button_startStimFromFile.Name = "button_startStimFromFile";
            this.button_startStimFromFile.Size = new System.Drawing.Size(126, 34);
            this.button_startStimFromFile.TabIndex = 0;
            this.button_startStimFromFile.Text = "Start Protocol";
            this.button_startStimFromFile.UseVisualStyleBackColor = true;
            this.button_startStimFromFile.Click += new System.EventHandler(this.button_startStimFromFile_Click);
            // 
            // button_showcase
            // 
            this.button_showcase.Location = new System.Drawing.Point(25, 496);
            this.button_showcase.Name = "button_showcase";
            this.button_showcase.Size = new System.Drawing.Size(86, 51);
            this.button_showcase.TabIndex = 7;
            this.button_showcase.Text = "Showcase Stim (Experimental)";
            this.button_showcase.UseVisualStyleBackColor = true;
            this.button_showcase.Visible = false;
            this.button_showcase.Click += new System.EventHandler(this.button_showcase_Click);
            // 
            // groupBox24
            // 
            this.groupBox24.Controls.Add(this.groupBox18);
            this.groupBox24.Controls.Add(this.offsetVoltage);
            this.groupBox24.Controls.Add(this.label26);
            this.groupBox24.Location = new System.Drawing.Point(8, 8);
            this.groupBox24.Name = "groupBox24";
            this.groupBox24.Size = new System.Drawing.Size(321, 68);
            this.groupBox24.TabIndex = 0;
            this.groupBox24.TabStop = false;
            this.groupBox24.Text = "Global Parameters";
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.radioButton_stimVoltageControlled);
            this.groupBox18.Controls.Add(this.radioButton_stimCurrentControlled);
            this.groupBox18.Location = new System.Drawing.Point(9, 19);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(158, 39);
            this.groupBox18.TabIndex = 0;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "Current vs. Voltage Control";
            // 
            // radioButton_stimVoltageControlled
            // 
            this.radioButton_stimVoltageControlled.AutoSize = true;
            this.radioButton_stimVoltageControlled.Location = new System.Drawing.Point(91, 16);
            this.radioButton_stimVoltageControlled.Name = "radioButton_stimVoltageControlled";
            this.radioButton_stimVoltageControlled.Size = new System.Drawing.Size(61, 17);
            this.radioButton_stimVoltageControlled.TabIndex = 1;
            this.radioButton_stimVoltageControlled.Text = "Voltage";
            this.radioButton_stimVoltageControlled.UseVisualStyleBackColor = true;
            this.radioButton_stimVoltageControlled.Click += new System.EventHandler(this.radioButton_stimVoltageControlled_Click);
            // 
            // radioButton_stimCurrentControlled
            // 
            this.radioButton_stimCurrentControlled.AutoSize = true;
            this.radioButton_stimCurrentControlled.Checked = true;
            this.radioButton_stimCurrentControlled.Location = new System.Drawing.Point(6, 16);
            this.radioButton_stimCurrentControlled.Name = "radioButton_stimCurrentControlled";
            this.radioButton_stimCurrentControlled.Size = new System.Drawing.Size(59, 17);
            this.radioButton_stimCurrentControlled.TabIndex = 0;
            this.radioButton_stimCurrentControlled.TabStop = true;
            this.radioButton_stimCurrentControlled.Text = "Current";
            this.radioButton_stimCurrentControlled.UseVisualStyleBackColor = true;
            this.radioButton_stimCurrentControlled.Click += new System.EventHandler(this.radioButton_stimCurrentControlled_Click);
            // 
            // offsetVoltage
            // 
            this.offsetVoltage.DecimalPlaces = 3;
            this.offsetVoltage.Location = new System.Drawing.Point(192, 32);
            this.offsetVoltage.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.offsetVoltage.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.offsetVoltage.Name = "offsetVoltage";
            this.offsetVoltage.Size = new System.Drawing.Size(110, 20);
            this.offsetVoltage.TabIndex = 1;
            this.offsetVoltage.ValueChanged += new System.EventHandler(this.offsetVoltage_ValueChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(189, 16);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(90, 13);
            this.label26.TabIndex = 19;
            this.label26.Text = "Offset Voltage (V)";
            // 
            // groupBox23
            // 
            this.groupBox23.Controls.Add(this.button_IISZapper_stop);
            this.groupBox23.Controls.Add(this.button_IISZapper_start);
            this.groupBox23.Controls.Add(this.label66);
            this.groupBox23.Controls.Add(this.numericUpDown_IISZapper_channel);
            this.groupBox23.Controls.Add(this.label67);
            this.groupBox23.Controls.Add(this.numericUpDown_IISZapper_phaseWidth);
            this.groupBox23.Controls.Add(this.label68);
            this.groupBox23.Controls.Add(this.numericUpDown_IISZapper_rate);
            this.groupBox23.Controls.Add(this.label69);
            this.groupBox23.Controls.Add(this.numericUpDown_IISZapper_voltage);
            this.groupBox23.Controls.Add(this.label70);
            this.groupBox23.Controls.Add(this.numericUpDown_IISZapper_pulsePerTrain);
            this.groupBox23.Location = new System.Drawing.Point(628, 594);
            this.groupBox23.Name = "groupBox23";
            this.groupBox23.Size = new System.Drawing.Size(282, 172);
            this.groupBox23.TabIndex = 5;
            this.groupBox23.TabStop = false;
            this.groupBox23.Text = "IIS Zapper (Experimental)";
            // 
            // button_IISZapper_stop
            // 
            this.button_IISZapper_stop.Enabled = false;
            this.button_IISZapper_stop.Location = new System.Drawing.Point(209, 130);
            this.button_IISZapper_stop.Name = "button_IISZapper_stop";
            this.button_IISZapper_stop.Size = new System.Drawing.Size(56, 36);
            this.button_IISZapper_stop.TabIndex = 1;
            this.button_IISZapper_stop.Text = "Stop";
            this.button_IISZapper_stop.UseVisualStyleBackColor = true;
            this.button_IISZapper_stop.Click += new System.EventHandler(this.button_IISZapper_stop_Click);
            // 
            // button_IISZapper_start
            // 
            this.button_IISZapper_start.Location = new System.Drawing.Point(144, 133);
            this.button_IISZapper_start.Name = "button_IISZapper_start";
            this.button_IISZapper_start.Size = new System.Drawing.Size(54, 36);
            this.button_IISZapper_start.TabIndex = 0;
            this.button_IISZapper_start.Text = "Start";
            this.button_IISZapper_start.UseVisualStyleBackColor = true;
            this.button_IISZapper_start.Click += new System.EventHandler(this.button_IISZapper_start_Click);
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(172, 24);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(49, 13);
            this.label66.TabIndex = 20;
            this.label66.Text = "Channel:";
            // 
            // numericUpDown_IISZapper_channel
            // 
            this.numericUpDown_IISZapper_channel.Location = new System.Drawing.Point(229, 22);
            this.numericUpDown_IISZapper_channel.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numericUpDown_IISZapper_channel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_IISZapper_channel.Name = "numericUpDown_IISZapper_channel";
            this.numericUpDown_IISZapper_channel.Size = new System.Drawing.Size(48, 20);
            this.numericUpDown_IISZapper_channel.TabIndex = 6;
            this.numericUpDown_IISZapper_channel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(6, 102);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(88, 13);
            this.label67.TabIndex = 19;
            this.label67.Text = "Phase width (μs):";
            // 
            // numericUpDown_IISZapper_phaseWidth
            // 
            this.numericUpDown_IISZapper_phaseWidth.Location = new System.Drawing.Point(106, 100);
            this.numericUpDown_IISZapper_phaseWidth.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown_IISZapper_phaseWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_IISZapper_phaseWidth.Name = "numericUpDown_IISZapper_phaseWidth";
            this.numericUpDown_IISZapper_phaseWidth.Size = new System.Drawing.Size(52, 20);
            this.numericUpDown_IISZapper_phaseWidth.TabIndex = 5;
            this.numericUpDown_IISZapper_phaseWidth.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(6, 76);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(55, 13);
            this.label68.TabIndex = 18;
            this.label68.Text = "Rate (Hz):";
            // 
            // numericUpDown_IISZapper_rate
            // 
            this.numericUpDown_IISZapper_rate.DecimalPlaces = 2;
            this.numericUpDown_IISZapper_rate.Location = new System.Drawing.Point(106, 74);
            this.numericUpDown_IISZapper_rate.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDown_IISZapper_rate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_IISZapper_rate.Name = "numericUpDown_IISZapper_rate";
            this.numericUpDown_IISZapper_rate.Size = new System.Drawing.Size(52, 20);
            this.numericUpDown_IISZapper_rate.TabIndex = 4;
            this.numericUpDown_IISZapper_rate.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(6, 50);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(62, 13);
            this.label69.TabIndex = 16;
            this.label69.Text = "Voltage (V):";
            // 
            // numericUpDown_IISZapper_voltage
            // 
            this.numericUpDown_IISZapper_voltage.DecimalPlaces = 1;
            this.numericUpDown_IISZapper_voltage.Location = new System.Drawing.Point(106, 48);
            this.numericUpDown_IISZapper_voltage.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_IISZapper_voltage.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericUpDown_IISZapper_voltage.Name = "numericUpDown_IISZapper_voltage";
            this.numericUpDown_IISZapper_voltage.Size = new System.Drawing.Size(52, 20);
            this.numericUpDown_IISZapper_voltage.TabIndex = 3;
            this.numericUpDown_IISZapper_voltage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(6, 24);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(66, 13);
            this.label70.TabIndex = 13;
            this.label70.Text = "Pulses/train:";
            // 
            // numericUpDown_IISZapper_pulsePerTrain
            // 
            this.numericUpDown_IISZapper_pulsePerTrain.Location = new System.Drawing.Point(106, 22);
            this.numericUpDown_IISZapper_pulsePerTrain.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.numericUpDown_IISZapper_pulsePerTrain.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_IISZapper_pulsePerTrain.Name = "numericUpDown_IISZapper_pulsePerTrain";
            this.numericUpDown_IISZapper_pulsePerTrain.Size = new System.Drawing.Size(52, 20);
            this.numericUpDown_IISZapper_pulsePerTrain.TabIndex = 2;
            this.numericUpDown_IISZapper_pulsePerTrain.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.button_ElectrodeScreeningSelectNone);
            this.groupBox11.Controls.Add(this.label60);
            this.groupBox11.Controls.Add(this.button_ElectrodeScreeningSelectAll);
            this.groupBox11.Controls.Add(this.numericUpDown_exptNumRepeats);
            this.groupBox11.Controls.Add(this.label59);
            this.groupBox11.Controls.Add(this.textBox_exptPulseWidths);
            this.groupBox11.Controls.Add(this.label58);
            this.groupBox11.Controls.Add(this.textBox_exptPPT);
            this.groupBox11.Controls.Add(this.label57);
            this.groupBox11.Controls.Add(this.textBox_exptVoltages);
            this.groupBox11.Controls.Add(this.label37);
            this.groupBox11.Controls.Add(this.button_stopExpt);
            this.groupBox11.Controls.Add(this.listBox_exptStimChannels);
            this.groupBox11.Controls.Add(this.progressBar_stimExpt);
            this.groupBox11.Controls.Add(this.button_stimExpt);
            this.groupBox11.Location = new System.Drawing.Point(341, 292);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(452, 162);
            this.groupBox11.TabIndex = 3;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Electrode Screening";
            // 
            // button_ElectrodeScreeningSelectNone
            // 
            this.button_ElectrodeScreeningSelectNone.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ElectrodeScreeningSelectNone.Location = new System.Drawing.Point(33, 120);
            this.button_ElectrodeScreeningSelectNone.Name = "button_ElectrodeScreeningSelectNone";
            this.button_ElectrodeScreeningSelectNone.Size = new System.Drawing.Size(35, 31);
            this.button_ElectrodeScreeningSelectNone.TabIndex = 23;
            this.button_ElectrodeScreeningSelectNone.Text = "Select None";
            this.button_ElectrodeScreeningSelectNone.UseVisualStyleBackColor = true;
            this.button_ElectrodeScreeningSelectNone.Click += new System.EventHandler(this.button_ElectrodeScreeningSelectNone_Click);
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(227, 84);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(72, 13);
            this.label60.TabIndex = 36;
            this.label60.Text = "Num Repeats";
            // 
            // button_ElectrodeScreeningSelectAll
            // 
            this.button_ElectrodeScreeningSelectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ElectrodeScreeningSelectAll.Location = new System.Drawing.Point(74, 120);
            this.button_ElectrodeScreeningSelectAll.Name = "button_ElectrodeScreeningSelectAll";
            this.button_ElectrodeScreeningSelectAll.Size = new System.Drawing.Size(35, 31);
            this.button_ElectrodeScreeningSelectAll.TabIndex = 22;
            this.button_ElectrodeScreeningSelectAll.Text = "Select All";
            this.button_ElectrodeScreeningSelectAll.UseVisualStyleBackColor = true;
            this.button_ElectrodeScreeningSelectAll.Click += new System.EventHandler(this.button_ElectrodeScreeningSelectAll_Click);
            // 
            // numericUpDown_exptNumRepeats
            // 
            this.numericUpDown_exptNumRepeats.Location = new System.Drawing.Point(230, 102);
            this.numericUpDown_exptNumRepeats.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_exptNumRepeats.Name = "numericUpDown_exptNumRepeats";
            this.numericUpDown_exptNumRepeats.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown_exptNumRepeats.TabIndex = 6;
            this.numericUpDown_exptNumRepeats.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_exptNumRepeats.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(227, 16);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(89, 13);
            this.label59.TabIndex = 34;
            this.label59.Text = "Pulse Widths (μs)";
            // 
            // textBox_exptPulseWidths
            // 
            this.textBox_exptPulseWidths.Location = new System.Drawing.Point(230, 33);
            this.textBox_exptPulseWidths.Multiline = true;
            this.textBox_exptPulseWidths.Name = "textBox_exptPulseWidths";
            this.textBox_exptPulseWidths.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_exptPulseWidths.Size = new System.Drawing.Size(100, 45);
            this.textBox_exptPulseWidths.TabIndex = 4;
            this.textBox_exptPulseWidths.Text = "400.0";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(118, 83);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(84, 13);
            this.label58.TabIndex = 32;
            this.label58.Text = "Pulses Per Train";
            // 
            // textBox_exptPPT
            // 
            this.textBox_exptPPT.Location = new System.Drawing.Point(121, 100);
            this.textBox_exptPPT.Multiline = true;
            this.textBox_exptPPT.Name = "textBox_exptPPT";
            this.textBox_exptPPT.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_exptPPT.Size = new System.Drawing.Size(100, 56);
            this.textBox_exptPPT.TabIndex = 5;
            this.textBox_exptPPT.Text = "1";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(118, 16);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(64, 13);
            this.label57.TabIndex = 30;
            this.label57.Text = "Voltages (V)";
            // 
            // textBox_exptVoltages
            // 
            this.textBox_exptVoltages.Location = new System.Drawing.Point(121, 33);
            this.textBox_exptVoltages.Multiline = true;
            this.textBox_exptVoltages.Name = "textBox_exptVoltages";
            this.textBox_exptVoltages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_exptVoltages.Size = new System.Drawing.Size(100, 45);
            this.textBox_exptVoltages.TabIndex = 3;
            this.textBox_exptVoltages.Text = "-0.2, -0.4, -0.6, -0.8, -1.0, -1.5, -2.0, -5.0";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(6, 16);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(109, 13);
            this.label37.TabIndex = 28;
            this.label37.Text = "Channels to Stimulate";
            // 
            // button_stopExpt
            // 
            this.button_stopExpt.Enabled = false;
            this.button_stopExpt.Location = new System.Drawing.Point(368, 75);
            this.button_stopExpt.Name = "button_stopExpt";
            this.button_stopExpt.Size = new System.Drawing.Size(74, 38);
            this.button_stopExpt.TabIndex = 1;
            this.button_stopExpt.Text = "Stop Experiment";
            this.button_stopExpt.UseVisualStyleBackColor = true;
            this.button_stopExpt.Click += new System.EventHandler(this.button_stopExpt_Click);
            // 
            // listBox_exptStimChannels
            // 
            this.listBox_exptStimChannels.FormattingEnabled = true;
            this.listBox_exptStimChannels.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.listBox_exptStimChannels.Location = new System.Drawing.Point(9, 32);
            this.listBox_exptStimChannels.Name = "listBox_exptStimChannels";
            this.listBox_exptStimChannels.ScrollAlwaysVisible = true;
            this.listBox_exptStimChannels.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox_exptStimChannels.Size = new System.Drawing.Size(106, 82);
            this.listBox_exptStimChannels.TabIndex = 2;
            // 
            // progressBar_stimExpt
            // 
            this.progressBar_stimExpt.Location = new System.Drawing.Point(227, 130);
            this.progressBar_stimExpt.Name = "progressBar_stimExpt";
            this.progressBar_stimExpt.Size = new System.Drawing.Size(215, 23);
            this.progressBar_stimExpt.TabIndex = 4;
            // 
            // button_stimExpt
            // 
            this.button_stimExpt.Location = new System.Drawing.Point(368, 31);
            this.button_stimExpt.Name = "button_stimExpt";
            this.button_stimExpt.Size = new System.Drawing.Size(74, 38);
            this.button_stimExpt.TabIndex = 0;
            this.button_stimExpt.Text = "Start Experiment";
            this.button_stimExpt.UseVisualStyleBackColor = true;
            this.button_stimExpt.Click += new System.EventHandler(this.button_stimExpt_Click);
            // 
            // groupBox22
            // 
            this.groupBox22.Controls.Add(this.label65);
            this.groupBox22.Controls.Add(this.button_electrolesioningSelectNone);
            this.groupBox22.Controls.Add(this.button_electrolesioningSelectAll);
            this.groupBox22.Controls.Add(this.listBox_electrolesioningChannels);
            this.groupBox22.Controls.Add(this.label64);
            this.groupBox22.Controls.Add(this.numericUpDown_electrolesioningDuration);
            this.groupBox22.Controls.Add(this.label31);
            this.groupBox22.Controls.Add(this.numericUpDown_electrolesioningVoltage);
            this.groupBox22.Controls.Add(this.button_electrolesioningStart);
            this.groupBox22.Location = new System.Drawing.Point(349, 594);
            this.groupBox22.Name = "groupBox22";
            this.groupBox22.Size = new System.Drawing.Size(262, 173);
            this.groupBox22.TabIndex = 4;
            this.groupBox22.TabStop = false;
            this.groupBox22.Text = "Electrolesioning";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(147, 16);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(109, 13);
            this.label65.TabIndex = 21;
            this.label65.Text = "Channels to Stimulate";
            // 
            // button_electrolesioningSelectNone
            // 
            this.button_electrolesioningSelectNone.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_electrolesioningSelectNone.Location = new System.Drawing.Point(180, 133);
            this.button_electrolesioningSelectNone.Name = "button_electrolesioningSelectNone";
            this.button_electrolesioningSelectNone.Size = new System.Drawing.Size(35, 31);
            this.button_electrolesioningSelectNone.TabIndex = 5;
            this.button_electrolesioningSelectNone.Text = "Select None";
            this.button_electrolesioningSelectNone.UseVisualStyleBackColor = true;
            this.button_electrolesioningSelectNone.Click += new System.EventHandler(this.button_electrolesioningSelectNone_Click);
            // 
            // button_electrolesioningSelectAll
            // 
            this.button_electrolesioningSelectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_electrolesioningSelectAll.Location = new System.Drawing.Point(221, 133);
            this.button_electrolesioningSelectAll.Name = "button_electrolesioningSelectAll";
            this.button_electrolesioningSelectAll.Size = new System.Drawing.Size(35, 31);
            this.button_electrolesioningSelectAll.TabIndex = 4;
            this.button_electrolesioningSelectAll.Text = "Select All";
            this.button_electrolesioningSelectAll.UseVisualStyleBackColor = true;
            this.button_electrolesioningSelectAll.Click += new System.EventHandler(this.button_electrolesioningSelectAll_Click);
            // 
            // listBox_electrolesioningChannels
            // 
            this.listBox_electrolesioningChannels.FormattingEnabled = true;
            this.listBox_electrolesioningChannels.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.listBox_electrolesioningChannels.Location = new System.Drawing.Point(150, 32);
            this.listBox_electrolesioningChannels.Name = "listBox_electrolesioningChannels";
            this.listBox_electrolesioningChannels.ScrollAlwaysVisible = true;
            this.listBox_electrolesioningChannels.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox_electrolesioningChannels.Size = new System.Drawing.Size(106, 95);
            this.listBox_electrolesioningChannels.TabIndex = 3;
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(6, 47);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(64, 13);
            this.label64.TabIndex = 4;
            this.label64.Text = "Duration (s):";
            // 
            // numericUpDown_electrolesioningDuration
            // 
            this.numericUpDown_electrolesioningDuration.Location = new System.Drawing.Point(74, 45);
            this.numericUpDown_electrolesioningDuration.Name = "numericUpDown_electrolesioningDuration";
            this.numericUpDown_electrolesioningDuration.Size = new System.Drawing.Size(52, 20);
            this.numericUpDown_electrolesioningDuration.TabIndex = 2;
            this.numericUpDown_electrolesioningDuration.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(6, 21);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(62, 13);
            this.label31.TabIndex = 2;
            this.label31.Text = "Voltage (V):";
            // 
            // numericUpDown_electrolesioningVoltage
            // 
            this.numericUpDown_electrolesioningVoltage.DecimalPlaces = 2;
            this.numericUpDown_electrolesioningVoltage.Location = new System.Drawing.Point(74, 19);
            this.numericUpDown_electrolesioningVoltage.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_electrolesioningVoltage.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericUpDown_electrolesioningVoltage.Name = "numericUpDown_electrolesioningVoltage";
            this.numericUpDown_electrolesioningVoltage.Size = new System.Drawing.Size(52, 20);
            this.numericUpDown_electrolesioningVoltage.TabIndex = 1;
            this.numericUpDown_electrolesioningVoltage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button_electrolesioningStart
            // 
            this.button_electrolesioningStart.Location = new System.Drawing.Point(13, 117);
            this.button_electrolesioningStart.Name = "button_electrolesioningStart";
            this.button_electrolesioningStart.Size = new System.Drawing.Size(102, 49);
            this.button_electrolesioningStart.TabIndex = 0;
            this.button_electrolesioningStart.Text = "Start Lesioning";
            this.button_electrolesioningStart.UseVisualStyleBackColor = true;
            this.button_electrolesioningStart.Click += new System.EventHandler(this.button_electrolesioningStart_Click);
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.waveformGraph_openLoopStimPulse);
            this.groupBox12.Controls.Add(this.button_openLoopSelectNone);
            this.groupBox12.Controls.Add(this.button_openLoopSelectAll);
            this.groupBox12.Controls.Add(this.label36);
            this.groupBox12.Controls.Add(this.openLoopPostphaseLength);
            this.groupBox12.Controls.Add(this.label35);
            this.groupBox12.Controls.Add(this.openLoopPrephaseLength);
            this.groupBox12.Controls.Add(this.label23);
            this.groupBox12.Controls.Add(this.openLoopWidth2);
            this.groupBox12.Controls.Add(this.label7);
            this.groupBox12.Controls.Add(this.openLoopVoltage2);
            this.groupBox12.Controls.Add(this.label34);
            this.groupBox12.Controls.Add(this.openLoopInterphaseLength);
            this.groupBox12.Controls.Add(this.label22);
            this.groupBox12.Controls.Add(this.listBox_stimChannels);
            this.groupBox12.Controls.Add(this.openLoopStop);
            this.groupBox12.Controls.Add(this.openLoopStart);
            this.groupBox12.Controls.Add(this.label21);
            this.groupBox12.Controls.Add(this.openLoopWidth1);
            this.groupBox12.Controls.Add(this.label20);
            this.groupBox12.Controls.Add(this.openLoopVoltage1);
            this.groupBox12.Controls.Add(this.label19);
            this.groupBox12.Controls.Add(this.openLoopRate);
            this.groupBox12.Location = new System.Drawing.Point(8, 80);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(321, 377);
            this.groupBox12.TabIndex = 2;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Manual Stimulation";
            // 
            // waveformGraph_openLoopStimPulse
            // 
            this.waveformGraph_openLoopStimPulse.Location = new System.Drawing.Point(6, 235);
            this.waveformGraph_openLoopStimPulse.Name = "waveformGraph_openLoopStimPulse";
            this.waveformGraph_openLoopStimPulse.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.waveformPlot1});
            this.waveformGraph_openLoopStimPulse.Size = new System.Drawing.Size(309, 136);
            this.waveformGraph_openLoopStimPulse.TabIndex = 29;
            this.waveformGraph_openLoopStimPulse.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis1});
            this.waveformGraph_openLoopStimPulse.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis1});
            // 
            // waveformPlot1
            // 
            this.waveformPlot1.XAxis = this.xAxis1;
            this.waveformPlot1.YAxis = this.yAxis1;
            // 
            // xAxis1
            // 
            this.xAxis1.Caption = "Time (microseconds)";
            // 
            // yAxis1
            // 
            this.yAxis1.Caption = "Voltage (Volts)";
            // 
            // button_openLoopSelectNone
            // 
            this.button_openLoopSelectNone.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_openLoopSelectNone.Location = new System.Drawing.Point(229, 131);
            this.button_openLoopSelectNone.Name = "button_openLoopSelectNone";
            this.button_openLoopSelectNone.Size = new System.Drawing.Size(35, 32);
            this.button_openLoopSelectNone.TabIndex = 12;
            this.button_openLoopSelectNone.Text = "Select None";
            this.button_openLoopSelectNone.UseVisualStyleBackColor = true;
            this.button_openLoopSelectNone.Click += new System.EventHandler(this.button_openLoopSelectNone_Click);
            // 
            // button_openLoopSelectAll
            // 
            this.button_openLoopSelectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_openLoopSelectAll.Location = new System.Drawing.Point(270, 131);
            this.button_openLoopSelectAll.Name = "button_openLoopSelectAll";
            this.button_openLoopSelectAll.Size = new System.Drawing.Size(35, 32);
            this.button_openLoopSelectAll.TabIndex = 11;
            this.button_openLoopSelectAll.Text = "Select All";
            this.button_openLoopSelectAll.UseVisualStyleBackColor = true;
            this.button_openLoopSelectAll.Click += new System.EventHandler(this.button_openLoopSelectAll_Click);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(6, 212);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(115, 13);
            this.label36.TabIndex = 26;
            this.label36.Text = "Post-phase length (μs):";
            // 
            // openLoopPostphaseLength
            // 
            this.openLoopPostphaseLength.Location = new System.Drawing.Point(128, 210);
            this.openLoopPostphaseLength.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.openLoopPostphaseLength.Name = "openLoopPostphaseLength";
            this.openLoopPostphaseLength.Size = new System.Drawing.Size(52, 20);
            this.openLoopPostphaseLength.TabIndex = 9;
            this.openLoopPostphaseLength.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.openLoopPostphaseLength.ValueChanged += new System.EventHandler(this.openLoopPostphaseLength_ValueChanged);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(6, 186);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(110, 13);
            this.label35.TabIndex = 24;
            this.label35.Text = "Pre-phase length (μs):";
            // 
            // openLoopPrephaseLength
            // 
            this.openLoopPrephaseLength.Location = new System.Drawing.Point(128, 184);
            this.openLoopPrephaseLength.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.openLoopPrephaseLength.Name = "openLoopPrephaseLength";
            this.openLoopPrephaseLength.Size = new System.Drawing.Size(52, 20);
            this.openLoopPrephaseLength.TabIndex = 8;
            this.openLoopPrephaseLength.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.openLoopPrephaseLength.ValueChanged += new System.EventHandler(this.openLoopPrephaseLength_ValueChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 135);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(97, 13);
            this.label23.TabIndex = 22;
            this.label23.Text = "Phase 2 width (μs):";
            // 
            // openLoopWidth2
            // 
            this.openLoopWidth2.Location = new System.Drawing.Point(128, 132);
            this.openLoopWidth2.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.openLoopWidth2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.openLoopWidth2.Name = "openLoopWidth2";
            this.openLoopWidth2.Size = new System.Drawing.Size(52, 20);
            this.openLoopWidth2.TabIndex = 6;
            this.openLoopWidth2.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.openLoopWidth2.ValueChanged += new System.EventHandler(this.openLoopWidth2_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Voltage, phase 2 (V):";
            // 
            // openLoopVoltage2
            // 
            this.openLoopVoltage2.DecimalPlaces = 2;
            this.openLoopVoltage2.Location = new System.Drawing.Point(128, 80);
            this.openLoopVoltage2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.openLoopVoltage2.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.openLoopVoltage2.Name = "openLoopVoltage2";
            this.openLoopVoltage2.Size = new System.Drawing.Size(52, 20);
            this.openLoopVoltage2.TabIndex = 4;
            this.openLoopVoltage2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.openLoopVoltage2.ValueChanged += new System.EventHandler(this.openLoopVoltage2_ValueChanged);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(6, 160);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(112, 13);
            this.label34.TabIndex = 14;
            this.label34.Text = "Interphase length (μs):";
            // 
            // openLoopInterphaseLength
            // 
            this.openLoopInterphaseLength.Location = new System.Drawing.Point(128, 158);
            this.openLoopInterphaseLength.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.openLoopInterphaseLength.Name = "openLoopInterphaseLength";
            this.openLoopInterphaseLength.Size = new System.Drawing.Size(52, 20);
            this.openLoopInterphaseLength.TabIndex = 7;
            this.openLoopInterphaseLength.ValueChanged += new System.EventHandler(this.openLoopInterphaseLength_ValueChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(199, 14);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(109, 13);
            this.label22.TabIndex = 16;
            this.label22.Text = "Channels to Stimulate";
            // 
            // listBox_stimChannels
            // 
            this.listBox_stimChannels.FormattingEnabled = true;
            this.listBox_stimChannels.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.listBox_stimChannels.Location = new System.Drawing.Point(202, 30);
            this.listBox_stimChannels.Name = "listBox_stimChannels";
            this.listBox_stimChannels.ScrollAlwaysVisible = true;
            this.listBox_stimChannels.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox_stimChannels.Size = new System.Drawing.Size(103, 95);
            this.listBox_stimChannels.TabIndex = 10;
            // 
            // openLoopStop
            // 
            this.openLoopStop.Enabled = false;
            this.openLoopStop.Location = new System.Drawing.Point(266, 192);
            this.openLoopStop.Name = "openLoopStop";
            this.openLoopStop.Size = new System.Drawing.Size(49, 39);
            this.openLoopStop.TabIndex = 1;
            this.openLoopStop.Text = "Stop";
            this.openLoopStop.UseVisualStyleBackColor = true;
            this.openLoopStop.Click += new System.EventHandler(this.openLoopStop_Click);
            // 
            // openLoopStart
            // 
            this.openLoopStart.Location = new System.Drawing.Point(211, 192);
            this.openLoopStart.Name = "openLoopStart";
            this.openLoopStart.Size = new System.Drawing.Size(49, 39);
            this.openLoopStart.TabIndex = 0;
            this.openLoopStart.Text = "Start";
            this.openLoopStart.UseVisualStyleBackColor = true;
            this.openLoopStart.Click += new System.EventHandler(this.openLoopStart_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 108);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(97, 13);
            this.label21.TabIndex = 12;
            this.label21.Text = "Phase 1 width (μs):";
            // 
            // openLoopWidth1
            // 
            this.openLoopWidth1.Location = new System.Drawing.Point(128, 106);
            this.openLoopWidth1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.openLoopWidth1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.openLoopWidth1.Name = "openLoopWidth1";
            this.openLoopWidth1.Size = new System.Drawing.Size(52, 20);
            this.openLoopWidth1.TabIndex = 5;
            this.openLoopWidth1.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.openLoopWidth1.ValueChanged += new System.EventHandler(this.openLoopWidth1_ValueChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 56);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(106, 13);
            this.label20.TabIndex = 12;
            this.label20.Text = "Voltage, phase 1 (V):";
            // 
            // openLoopVoltage1
            // 
            this.openLoopVoltage1.DecimalPlaces = 2;
            this.openLoopVoltage1.Location = new System.Drawing.Point(128, 54);
            this.openLoopVoltage1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.openLoopVoltage1.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.openLoopVoltage1.Name = "openLoopVoltage1";
            this.openLoopVoltage1.Size = new System.Drawing.Size(52, 20);
            this.openLoopVoltage1.TabIndex = 3;
            this.openLoopVoltage1.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.openLoopVoltage1.ValueChanged += new System.EventHandler(this.openLoopVoltage1_ValueChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 27);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(55, 13);
            this.label19.TabIndex = 12;
            this.label19.Text = "Rate (Hz):";
            // 
            // openLoopRate
            // 
            this.openLoopRate.DecimalPlaces = 2;
            this.openLoopRate.Location = new System.Drawing.Point(128, 25);
            this.openLoopRate.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.openLoopRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.openLoopRate.Name = "openLoopRate";
            this.openLoopRate.Size = new System.Drawing.Size(52, 20);
            this.openLoopRate.TabIndex = 2;
            this.openLoopRate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.groupBox29);
            this.groupBox9.Controls.Add(this.label33);
            this.groupBox9.Controls.Add(this.stimInterphaseLength);
            this.groupBox9.Controls.Add(this.label17);
            this.groupBox9.Controls.Add(this.stimChannel);
            this.groupBox9.Controls.Add(this.label16);
            this.groupBox9.Controls.Add(this.stimWidth);
            this.groupBox9.Controls.Add(this.label15);
            this.groupBox9.Controls.Add(this.stimRate);
            this.groupBox9.Controls.Add(this.label14);
            this.groupBox9.Controls.Add(this.stimVoltage);
            this.groupBox9.Controls.Add(this.label13);
            this.groupBox9.Controls.Add(this.stimPulses);
            this.groupBox9.Controls.Add(this.button_stim);
            this.groupBox9.Location = new System.Drawing.Point(14, 598);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(321, 153);
            this.groupBox9.TabIndex = 1;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "On Demand";
            // 
            // groupBox29
            // 
            this.groupBox29.Controls.Add(this.radioButton_OnDemandBiphasic);
            this.groupBox29.Controls.Add(this.radioButton_OnDemandUniphasic);
            this.groupBox29.Location = new System.Drawing.Point(9, 98);
            this.groupBox29.Name = "groupBox29";
            this.groupBox29.Size = new System.Drawing.Size(158, 39);
            this.groupBox29.TabIndex = 2;
            this.groupBox29.TabStop = false;
            this.groupBox29.Text = "Uni- vs. Biphasic Pulses";
            // 
            // radioButton_OnDemandUniphasic
            // 
            this.radioButton_OnDemandUniphasic.AutoSize = true;
            this.radioButton_OnDemandUniphasic.Location = new System.Drawing.Point(6, 16);
            this.radioButton_OnDemandUniphasic.Name = "radioButton_OnDemandUniphasic";
            this.radioButton_OnDemandUniphasic.Size = new System.Drawing.Size(72, 17);
            this.radioButton_OnDemandUniphasic.TabIndex = 0;
            this.radioButton_OnDemandUniphasic.Text = "Uniphasic";
            this.radioButton_OnDemandUniphasic.UseVisualStyleBackColor = true;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(131, 74);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(112, 13);
            this.label33.TabIndex = 12;
            this.label33.Text = "Interphase length (μs):";
            // 
            // stimInterphaseLength
            // 
            this.stimInterphaseLength.Location = new System.Drawing.Point(256, 72);
            this.stimInterphaseLength.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.stimInterphaseLength.Name = "stimInterphaseLength";
            this.stimInterphaseLength.Size = new System.Drawing.Size(52, 20);
            this.stimInterphaseLength.TabIndex = 5;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 21);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 13);
            this.label17.TabIndex = 10;
            this.label17.Text = "Channel:";
            // 
            // stimChannel
            // 
            this.stimChannel.Location = new System.Drawing.Point(73, 20);
            this.stimChannel.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.stimChannel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stimChannel.Name = "stimChannel";
            this.stimChannel.Size = new System.Drawing.Size(52, 20);
            this.stimChannel.TabIndex = 6;
            this.stimChannel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(131, 47);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 13);
            this.label16.TabIndex = 8;
            this.label16.Text = "Phase width (μs):";
            // 
            // stimWidth
            // 
            this.stimWidth.Location = new System.Drawing.Point(256, 45);
            this.stimWidth.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.stimWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stimWidth.Name = "stimWidth";
            this.stimWidth.Size = new System.Drawing.Size(52, 20);
            this.stimWidth.TabIndex = 4;
            this.stimWidth.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 73);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "Rate (Hz):";
            // 
            // stimRate
            // 
            this.stimRate.DecimalPlaces = 2;
            this.stimRate.Location = new System.Drawing.Point(73, 72);
            this.stimRate.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.stimRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.stimRate.Name = "stimRate";
            this.stimRate.Size = new System.Drawing.Size(52, 20);
            this.stimRate.TabIndex = 3;
            this.stimRate.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(131, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Voltage (V):";
            // 
            // stimVoltage
            // 
            this.stimVoltage.DecimalPlaces = 1;
            this.stimVoltage.Location = new System.Drawing.Point(256, 19);
            this.stimVoltage.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.stimVoltage.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.stimVoltage.Name = "stimVoltage";
            this.stimVoltage.Size = new System.Drawing.Size(52, 20);
            this.stimVoltage.TabIndex = 2;
            this.stimVoltage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "# Pulses:";
            // 
            // stimPulses
            // 
            this.stimPulses.Location = new System.Drawing.Point(73, 46);
            this.stimPulses.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.stimPulses.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stimPulses.Name = "stimPulses";
            this.stimPulses.Size = new System.Drawing.Size(52, 20);
            this.stimPulses.TabIndex = 1;
            this.stimPulses.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button_stim
            // 
            this.button_stim.Location = new System.Drawing.Point(241, 99);
            this.button_stim.Name = "button_stim";
            this.button_stim.Size = new System.Drawing.Size(61, 41);
            this.button_stim.TabIndex = 0;
            this.button_stim.Text = "Stimulate";
            this.button_stim.UseVisualStyleBackColor = true;
            this.button_stim.Click += new System.EventHandler(this.button_stim_Click);
            // 
            // tabPage_ProgRef
            // 
            this.tabPage_ProgRef.Controls.Add(this.groupBox_plexonProgRef);
            this.tabPage_ProgRef.Controls.Add(this.groupBox13);
            this.tabPage_ProgRef.Location = new System.Drawing.Point(4, 22);
            this.tabPage_ProgRef.Name = "tabPage_ProgRef";
            this.tabPage_ProgRef.Size = new System.Drawing.Size(941, 780);
            this.tabPage_ProgRef.TabIndex = 3;
            this.tabPage_ProgRef.Text = "Ref";
            this.tabPage_ProgRef.UseVisualStyleBackColor = true;
            // 
            // groupBox_plexonProgRef
            // 
            this.groupBox_plexonProgRef.Controls.Add(this.button_analogResetRefs);
            this.groupBox_plexonProgRef.Controls.Add(this.checkBox_analogRefLFPs);
            this.groupBox_plexonProgRef.Controls.Add(this.label47);
            this.groupBox_plexonProgRef.Controls.Add(this.numericUpDown_analogRefLFPs);
            this.groupBox_plexonProgRef.Controls.Add(this.checkBox_analogRefSpikes);
            this.groupBox_plexonProgRef.Controls.Add(this.label48);
            this.groupBox_plexonProgRef.Controls.Add(this.numericUpDown_analogRefSpikes);
            this.groupBox_plexonProgRef.Location = new System.Drawing.Point(3, 209);
            this.groupBox_plexonProgRef.Name = "groupBox_plexonProgRef";
            this.groupBox_plexonProgRef.Size = new System.Drawing.Size(426, 95);
            this.groupBox_plexonProgRef.TabIndex = 1;
            this.groupBox_plexonProgRef.TabStop = false;
            this.groupBox_plexonProgRef.Text = "Analog Referencing (Plexon Only)";
            // 
            // button_analogResetRefs
            // 
            this.button_analogResetRefs.Location = new System.Drawing.Point(345, 63);
            this.button_analogResetRefs.Name = "button_analogResetRefs";
            this.button_analogResetRefs.Size = new System.Drawing.Size(75, 23);
            this.button_analogResetRefs.TabIndex = 4;
            this.button_analogResetRefs.Text = "Reset All";
            this.button_analogResetRefs.UseVisualStyleBackColor = true;
            this.button_analogResetRefs.Click += new System.EventHandler(this.button_analogResetRefs_Click);
            // 
            // checkBox_analogRefLFPs
            // 
            this.checkBox_analogRefLFPs.AutoSize = true;
            this.checkBox_analogRefLFPs.Location = new System.Drawing.Point(230, 19);
            this.checkBox_analogRefLFPs.Name = "checkBox_analogRefLFPs";
            this.checkBox_analogRefLFPs.Size = new System.Drawing.Size(123, 17);
            this.checkBox_analogRefLFPs.TabIndex = 2;
            this.checkBox_analogRefLFPs.Text = "LFP Referencing On";
            this.checkBox_analogRefLFPs.UseVisualStyleBackColor = true;
            this.checkBox_analogRefLFPs.CheckedChanged += new System.EventHandler(this.checkBox_analogRefLFPs_CheckedChanged);
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(227, 39);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(124, 13);
            this.label47.TabIndex = 4;
            this.label47.Text = "LFP Reference Channel:";
            // 
            // numericUpDown_analogRefLFPs
            // 
            this.numericUpDown_analogRefLFPs.Location = new System.Drawing.Point(357, 37);
            this.numericUpDown_analogRefLFPs.Name = "numericUpDown_analogRefLFPs";
            this.numericUpDown_analogRefLFPs.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown_analogRefLFPs.TabIndex = 3;
            this.numericUpDown_analogRefLFPs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_analogRefLFPs.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_analogRefLFPs.ValueChanged += new System.EventHandler(this.numericUpDown_analogRefLFPs_ValueChanged);
            // 
            // checkBox_analogRefSpikes
            // 
            this.checkBox_analogRefSpikes.AutoSize = true;
            this.checkBox_analogRefSpikes.Location = new System.Drawing.Point(8, 19);
            this.checkBox_analogRefSpikes.Name = "checkBox_analogRefSpikes";
            this.checkBox_analogRefSpikes.Size = new System.Drawing.Size(131, 17);
            this.checkBox_analogRefSpikes.TabIndex = 0;
            this.checkBox_analogRefSpikes.Text = "Spike Referencing On";
            this.checkBox_analogRefSpikes.UseVisualStyleBackColor = true;
            this.checkBox_analogRefSpikes.CheckedChanged += new System.EventHandler(this.checkBox_analogRefSpikes_CheckedChanged);
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(5, 39);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(132, 13);
            this.label48.TabIndex = 1;
            this.label48.Text = "Spike Reference Channel:";
            // 
            // numericUpDown_analogRefSpikes
            // 
            this.numericUpDown_analogRefSpikes.Location = new System.Drawing.Point(143, 37);
            this.numericUpDown_analogRefSpikes.Name = "numericUpDown_analogRefSpikes";
            this.numericUpDown_analogRefSpikes.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown_analogRefSpikes.TabIndex = 1;
            this.numericUpDown_analogRefSpikes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_analogRefSpikes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_analogRefSpikes.ValueChanged += new System.EventHandler(this.numericUpDown_analogRefSpikes_ValueChanged);
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.groupBox25);
            this.groupBox13.Controls.Add(this.checkBox_digRefLFPs);
            this.groupBox13.Controls.Add(this.label44);
            this.groupBox13.Controls.Add(this.numericUpDown_digRefLFPs);
            this.groupBox13.Controls.Add(this.checkBox_digRefSpikes);
            this.groupBox13.Controls.Add(this.label27);
            this.groupBox13.Controls.Add(this.numericUpDown_digRefSpikes);
            this.groupBox13.Location = new System.Drawing.Point(3, 5);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(426, 195);
            this.groupBox13.TabIndex = 0;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Digital Referencing";
            // 
            // groupBox25
            // 
            this.groupBox25.Controls.Add(this.numericUpDown_CommonMedianLocalReferencingChannelsPerGroup);
            this.groupBox25.Controls.Add(this.label83);
            this.groupBox25.Controls.Add(this.radioButton_spikesReferencingCommonAverage);
            this.groupBox25.Controls.Add(this.radioButton_spikesReferencingCommonMedian);
            this.groupBox25.Controls.Add(this.radioButton_spikesReferencingCommonMedianLocal);
            this.groupBox25.Controls.Add(this.radioButton_spikeReferencingNone);
            this.groupBox25.Location = new System.Drawing.Point(8, 63);
            this.groupBox25.Name = "groupBox25";
            this.groupBox25.Size = new System.Drawing.Size(200, 128);
            this.groupBox25.TabIndex = 8;
            this.groupBox25.TabStop = false;
            this.groupBox25.Text = "Spike Referencing";
            // 
            // numericUpDown_CommonMedianLocalReferencingChannelsPerGroup
            // 
            this.numericUpDown_CommonMedianLocalReferencingChannelsPerGroup.Location = new System.Drawing.Point(140, 81);
            this.numericUpDown_CommonMedianLocalReferencingChannelsPerGroup.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.numericUpDown_CommonMedianLocalReferencingChannelsPerGroup.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown_CommonMedianLocalReferencingChannelsPerGroup.Name = "numericUpDown_CommonMedianLocalReferencingChannelsPerGroup";
            this.numericUpDown_CommonMedianLocalReferencingChannelsPerGroup.Size = new System.Drawing.Size(46, 20);
            this.numericUpDown_CommonMedianLocalReferencingChannelsPerGroup.TabIndex = 9;
            this.numericUpDown_CommonMedianLocalReferencingChannelsPerGroup.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_CommonMedianLocalReferencingChannelsPerGroup.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numericUpDown_CommonMedianLocalReferencingChannelsPerGroup.ValueChanged += new System.EventHandler(this.numericUpDown_CommonMedianLocalReferencingChannelsPerGroup_ValueChanged);
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Location = new System.Drawing.Point(32, 83);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(102, 13);
            this.label83.TabIndex = 10;
            this.label83.Text = "Channels per group:";
            // 
            // radioButton_spikesReferencingCommonAverage
            // 
            this.radioButton_spikesReferencingCommonAverage.AutoSize = true;
            this.radioButton_spikesReferencingCommonAverage.Location = new System.Drawing.Point(6, 17);
            this.radioButton_spikesReferencingCommonAverage.Name = "radioButton_spikesReferencingCommonAverage";
            this.radioButton_spikesReferencingCommonAverage.Size = new System.Drawing.Size(109, 17);
            this.radioButton_spikesReferencingCommonAverage.TabIndex = 9;
            this.radioButton_spikesReferencingCommonAverage.Text = "Common Average";
            this.radioButton_spikesReferencingCommonAverage.UseVisualStyleBackColor = true;
            this.radioButton_spikesReferencingCommonAverage.CheckedChanged += new System.EventHandler(this.radioButton_spikesReferencingCommonAverage_CheckedChanged);
            // 
            // radioButton_spikesReferencingCommonMedian
            // 
            this.radioButton_spikesReferencingCommonMedian.AutoSize = true;
            this.radioButton_spikesReferencingCommonMedian.Location = new System.Drawing.Point(6, 40);
            this.radioButton_spikesReferencingCommonMedian.Name = "radioButton_spikesReferencingCommonMedian";
            this.radioButton_spikesReferencingCommonMedian.Size = new System.Drawing.Size(104, 17);
            this.radioButton_spikesReferencingCommonMedian.TabIndex = 9;
            this.radioButton_spikesReferencingCommonMedian.Text = "Common Median";
            this.radioButton_spikesReferencingCommonMedian.UseVisualStyleBackColor = true;
            this.radioButton_spikesReferencingCommonMedian.CheckedChanged += new System.EventHandler(this.radioButton_spikesReferencingCommonMedian_CheckedChanged);
            // 
            // radioButton_spikesReferencingCommonMedianLocal
            // 
            this.radioButton_spikesReferencingCommonMedianLocal.AutoSize = true;
            this.radioButton_spikesReferencingCommonMedianLocal.Location = new System.Drawing.Point(6, 63);
            this.radioButton_spikesReferencingCommonMedianLocal.Name = "radioButton_spikesReferencingCommonMedianLocal";
            this.radioButton_spikesReferencingCommonMedianLocal.Size = new System.Drawing.Size(133, 17);
            this.radioButton_spikesReferencingCommonMedianLocal.TabIndex = 9;
            this.radioButton_spikesReferencingCommonMedianLocal.Text = "Common Median Local";
            this.radioButton_spikesReferencingCommonMedianLocal.UseVisualStyleBackColor = true;
            this.radioButton_spikesReferencingCommonMedianLocal.CheckedChanged += new System.EventHandler(this.radioButton_spikesReferencingCommonMedianLocal_CheckedChanged);
            // 
            // radioButton_spikeReferencingNone
            // 
            this.radioButton_spikeReferencingNone.AutoSize = true;
            this.radioButton_spikeReferencingNone.Checked = true;
            this.radioButton_spikeReferencingNone.Location = new System.Drawing.Point(5, 99);
            this.radioButton_spikeReferencingNone.Name = "radioButton_spikeReferencingNone";
            this.radioButton_spikeReferencingNone.Size = new System.Drawing.Size(51, 17);
            this.radioButton_spikeReferencingNone.TabIndex = 9;
            this.radioButton_spikeReferencingNone.TabStop = true;
            this.radioButton_spikeReferencingNone.Text = "None";
            this.radioButton_spikeReferencingNone.UseVisualStyleBackColor = true;
            this.radioButton_spikeReferencingNone.CheckedChanged += new System.EventHandler(this.radioButton_spikeReferencingNone_CheckedChanged);
            // 
            // checkBox_digRefLFPs
            // 
            this.checkBox_digRefLFPs.AutoSize = true;
            this.checkBox_digRefLFPs.Location = new System.Drawing.Point(230, 19);
            this.checkBox_digRefLFPs.Name = "checkBox_digRefLFPs";
            this.checkBox_digRefLFPs.Size = new System.Drawing.Size(123, 17);
            this.checkBox_digRefLFPs.TabIndex = 2;
            this.checkBox_digRefLFPs.Text = "LFP Referencing On";
            this.checkBox_digRefLFPs.UseVisualStyleBackColor = true;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(227, 39);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(124, 13);
            this.label44.TabIndex = 4;
            this.label44.Text = "LFP Reference Channel:";
            // 
            // numericUpDown_digRefLFPs
            // 
            this.numericUpDown_digRefLFPs.Location = new System.Drawing.Point(357, 37);
            this.numericUpDown_digRefLFPs.Name = "numericUpDown_digRefLFPs";
            this.numericUpDown_digRefLFPs.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown_digRefLFPs.TabIndex = 3;
            this.numericUpDown_digRefLFPs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_digRefLFPs.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkBox_digRefSpikes
            // 
            this.checkBox_digRefSpikes.AutoSize = true;
            this.checkBox_digRefSpikes.Location = new System.Drawing.Point(8, 19);
            this.checkBox_digRefSpikes.Name = "checkBox_digRefSpikes";
            this.checkBox_digRefSpikes.Size = new System.Drawing.Size(213, 17);
            this.checkBox_digRefSpikes.TabIndex = 0;
            this.checkBox_digRefSpikes.Text = "Use Single Channel Reference (Spikes)";
            this.checkBox_digRefSpikes.UseVisualStyleBackColor = true;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(5, 39);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(132, 13);
            this.label27.TabIndex = 1;
            this.label27.Text = "Spike Reference Channel:";
            // 
            // numericUpDown_digRefSpikes
            // 
            this.numericUpDown_digRefSpikes.Location = new System.Drawing.Point(143, 37);
            this.numericUpDown_digRefSpikes.Name = "numericUpDown_digRefSpikes";
            this.numericUpDown_digRefSpikes.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown_digRefSpikes.TabIndex = 1;
            this.numericUpDown_digRefSpikes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_digRefSpikes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tabPage_EEG
            // 
            this.tabPage_EEG.Controls.Add(this.eegGraph);
            this.tabPage_EEG.Controls.Add(this.panel2);
            this.tabPage_EEG.Location = new System.Drawing.Point(4, 22);
            this.tabPage_EEG.Name = "tabPage_EEG";
            this.tabPage_EEG.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_EEG.Size = new System.Drawing.Size(941, 780);
            this.tabPage_EEG.TabIndex = 7;
            this.tabPage_EEG.Text = "EEG";
            this.tabPage_EEG.UseVisualStyleBackColor = true;
            // 
            // eegGraph
            // 
            this.eegGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eegGraph.Location = new System.Drawing.Point(3, 3);
            this.eegGraph.Name = "eegGraph";
            this.eegGraph.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("eegGraph.OcxState")));
            this.eegGraph.Size = new System.Drawing.Size(753, 774);
            this.eegGraph.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox14);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(756, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(182, 774);
            this.panel2.TabIndex = 1;
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.groupBox19);
            this.groupBox14.Controls.Add(this.label51);
            this.groupBox14.Controls.Add(this.textBox_eegSamplingRate);
            this.groupBox14.Controls.Add(this.comboBox_eegGain);
            this.groupBox14.Controls.Add(this.label49);
            this.groupBox14.Controls.Add(this.label50);
            this.groupBox14.Controls.Add(this.comboBox_eegNumChannels);
            this.groupBox14.Location = new System.Drawing.Point(3, 3);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(176, 406);
            this.groupBox14.TabIndex = 16;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "EEG Properties";
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.checkBox_eegFilter);
            this.groupBox19.Controls.Add(this.label52);
            this.groupBox19.Controls.Add(this.EEGFiltOrder);
            this.groupBox19.Controls.Add(this.label53);
            this.groupBox19.Controls.Add(this.EEGHighCut);
            this.groupBox19.Controls.Add(this.label54);
            this.groupBox19.Controls.Add(this.EEGLowCut);
            this.groupBox19.Location = new System.Drawing.Point(9, 128);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(161, 125);
            this.groupBox19.TabIndex = 16;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "EEG Filter";
            // 
            // checkBox_eegFilter
            // 
            this.checkBox_eegFilter.AutoSize = true;
            this.checkBox_eegFilter.Location = new System.Drawing.Point(6, 19);
            this.checkBox_eegFilter.Name = "checkBox_eegFilter";
            this.checkBox_eegFilter.Size = new System.Drawing.Size(70, 17);
            this.checkBox_eegFilter.TabIndex = 9;
            this.checkBox_eegFilter.Text = "Use Filter";
            this.checkBox_eegFilter.UseVisualStyleBackColor = true;
            this.checkBox_eegFilter.CheckedChanged += new System.EventHandler(this.checkBox_eegFilter_CheckedChanged);
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(41, 94);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(36, 13);
            this.label52.TabIndex = 8;
            this.label52.Text = "Order:";
            // 
            // EEGFiltOrder
            // 
            this.EEGFiltOrder.Location = new System.Drawing.Point(91, 92);
            this.EEGFiltOrder.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.EEGFiltOrder.Name = "EEGFiltOrder";
            this.EEGFiltOrder.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EEGFiltOrder.Size = new System.Drawing.Size(64, 20);
            this.EEGFiltOrder.TabIndex = 8;
            this.EEGFiltOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EEGFiltOrder.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.EEGFiltOrder.ValueChanged += new System.EventHandler(this.EEGFiltOrder_ValueChanged);
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(40, 68);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(50, 13);
            this.label53.TabIndex = 5;
            this.label53.Text = "High-cut:";
            // 
            // EEGHighCut
            // 
            this.EEGHighCut.Location = new System.Drawing.Point(91, 66);
            this.EEGHighCut.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.EEGHighCut.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.EEGHighCut.Name = "EEGHighCut";
            this.EEGHighCut.Size = new System.Drawing.Size(64, 20);
            this.EEGHighCut.TabIndex = 4;
            this.EEGHighCut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EEGHighCut.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.EEGHighCut.ValueChanged += new System.EventHandler(this.EEGHighCut_ValueChanged);
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(40, 42);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(48, 13);
            this.label54.TabIndex = 3;
            this.label54.Text = "Low-cut:";
            // 
            // EEGLowCut
            // 
            this.EEGLowCut.DecimalPlaces = 2;
            this.EEGLowCut.Location = new System.Drawing.Point(91, 40);
            this.EEGLowCut.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.EEGLowCut.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.EEGLowCut.Name = "EEGLowCut";
            this.EEGLowCut.Size = new System.Drawing.Size(64, 20);
            this.EEGLowCut.TabIndex = 2;
            this.EEGLowCut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EEGLowCut.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.EEGLowCut.ValueChanged += new System.EventHandler(this.EEGLowCut_ValueChanged);
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(6, 82);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(129, 13);
            this.label51.TabIndex = 11;
            this.label51.Text = "EEG Sampling Rate (Hz): ";
            // 
            // textBox_eegSamplingRate
            // 
            this.textBox_eegSamplingRate.Location = new System.Drawing.Point(94, 101);
            this.textBox_eegSamplingRate.Name = "textBox_eegSamplingRate";
            this.textBox_eegSamplingRate.Size = new System.Drawing.Size(76, 20);
            this.textBox_eegSamplingRate.TabIndex = 12;
            this.textBox_eegSamplingRate.Text = "1000";
            this.textBox_eegSamplingRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // comboBox_eegGain
            // 
            this.comboBox_eegGain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_eegGain.FormattingEnabled = true;
            this.comboBox_eegGain.Items.AddRange(new object[] {
            "1",
            "2",
            "5",
            "10",
            "20",
            "50",
            "100"});
            this.comboBox_eegGain.Location = new System.Drawing.Point(94, 47);
            this.comboBox_eegGain.Name = "comboBox_eegGain";
            this.comboBox_eegGain.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox_eegGain.Size = new System.Drawing.Size(76, 21);
            this.comboBox_eegGain.TabIndex = 11;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(6, 23);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(82, 13);
            this.label49.TabIndex = 15;
            this.label49.Text = "Num. Channels:";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(31, 50);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(57, 13);
            this.label50.TabIndex = 12;
            this.label50.Text = "EEG Gain:";
            // 
            // comboBox_eegNumChannels
            // 
            this.comboBox_eegNumChannels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_eegNumChannels.FormattingEnabled = true;
            this.comboBox_eegNumChannels.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBox_eegNumChannels.Location = new System.Drawing.Point(94, 20);
            this.comboBox_eegNumChannels.Name = "comboBox_eegNumChannels";
            this.comboBox_eegNumChannels.Size = new System.Drawing.Size(76, 21);
            this.comboBox_eegNumChannels.TabIndex = 14;
            // 
            // tabPage_LFPs
            // 
            this.tabPage_LFPs.Location = new System.Drawing.Point(4, 22);
            this.tabPage_LFPs.Name = "tabPage_LFPs";
            this.tabPage_LFPs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_LFPs.Size = new System.Drawing.Size(941, 780);
            this.tabPage_LFPs.TabIndex = 1;
            this.tabPage_LFPs.Text = "LFPs";
            this.tabPage_LFPs.UseVisualStyleBackColor = true;
            // 
            // tabPage_waveforms
            // 
            this.tabPage_waveforms.Controls.Add(this.panel3);
            this.tabPage_waveforms.Location = new System.Drawing.Point(4, 22);
            this.tabPage_waveforms.Name = "tabPage_waveforms";
            this.tabPage_waveforms.Size = new System.Drawing.Size(941, 780);
            this.tabPage_waveforms.TabIndex = 2;
            this.tabPage_waveforms.Text = "Spk Wfms";
            this.tabPage_waveforms.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button_clearSpkWfms);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 749);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(941, 31);
            this.panel3.TabIndex = 2;
            // 
            // button_clearSpkWfms
            // 
            this.button_clearSpkWfms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_clearSpkWfms.Location = new System.Drawing.Point(827, 5);
            this.button_clearSpkWfms.Name = "button_clearSpkWfms";
            this.button_clearSpkWfms.Size = new System.Drawing.Size(111, 23);
            this.button_clearSpkWfms.TabIndex = 1;
            this.button_clearSpkWfms.TabStop = false;
            this.button_clearSpkWfms.Text = "Clear Waveforms";
            this.button_clearSpkWfms.UseVisualStyleBackColor = true;
            this.button_clearSpkWfms.Click += new System.EventHandler(this.button_clearSpkWfms_Click);
            // 
            // tabPage_spikes
            // 
            this.tabPage_spikes.Location = new System.Drawing.Point(4, 22);
            this.tabPage_spikes.Name = "tabPage_spikes";
            this.tabPage_spikes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_spikes.Size = new System.Drawing.Size(941, 780);
            this.tabPage_spikes.TabIndex = 0;
            this.tabPage_spikes.Text = "Spikes";
            this.tabPage_spikes.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage_spikes);
            this.tabControl.Controls.Add(this.tabPage_waveforms);
            this.tabControl.Controls.Add(this.tabPage_LFPs);
            this.tabControl.Controls.Add(this.tabPage_MUA);
            this.tabControl.Controls.Add(this.tabPage_EEG);
            this.tabControl.Controls.Add(this.tabPage_ProgRef);
            this.tabControl.Controls.Add(this.tabPage_stim);
            this.tabControl.Controls.Add(this.tabPage_impedance);
            this.tabControl.Controls.Add(this.tabPage_diagnostics);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 24);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(949, 806);
            this.tabControl.TabIndex = 2;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPage_MUA
            // 
            this.tabPage_MUA.Location = new System.Drawing.Point(4, 22);
            this.tabPage_MUA.Name = "tabPage_MUA";
            this.tabPage_MUA.Size = new System.Drawing.Size(941, 780);
            this.tabPage_MUA.TabIndex = 8;
            this.tabPage_MUA.Text = "MUA";
            this.tabPage_MUA.UseVisualStyleBackColor = true;
            // 
            // button_BrowseOLDFile
            // 
            this.button_BrowseOLDFile.Location = new System.Drawing.Point(260, 94);
            this.button_BrowseOLDFile.Name = "button_BrowseOLDFile";
            this.button_BrowseOLDFile.Size = new System.Drawing.Size(25, 23);
            this.button_BrowseOLDFile.TabIndex = 40;
            this.button_BrowseOLDFile.Text = "...";
            this.button_BrowseOLDFile.UseVisualStyleBackColor = true;
            // 
            // textBox_digitalProtocolFileLocation
            // 
            this.textBox_digitalProtocolFileLocation.Location = new System.Drawing.Point(106, 96);
            this.textBox_digitalProtocolFileLocation.Name = "textBox_digitalProtocolFileLocation";
            this.textBox_digitalProtocolFileLocation.Size = new System.Drawing.Size(148, 20);
            this.textBox_digitalProtocolFileLocation.TabIndex = 39;
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(6, 100);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(101, 13);
            this.label61.TabIndex = 38;
            this.label61.Text = "Open Loop Dig. File";
            // 
            // checkBox_useManStimWaveform
            // 
            this.checkBox_useManStimWaveform.AutoSize = true;
            this.checkBox_useManStimWaveform.Location = new System.Drawing.Point(41, 51);
            this.checkBox_useManStimWaveform.Name = "checkBox_useManStimWaveform";
            this.checkBox_useManStimWaveform.Size = new System.Drawing.Size(208, 30);
            this.checkBox_useManStimWaveform.TabIndex = 41;
            this.checkBox_useManStimWaveform.Text = "Use pre-defined stimulation waveform?\r\n(as defined in the Manual Stim. Box)";
            this.checkBox_useManStimWaveform.UseVisualStyleBackColor = true;
            // 
            // checkBox_repeatOLStim
            // 
            this.checkBox_repeatOLStim.AutoSize = true;
            this.checkBox_repeatOLStim.Location = new System.Drawing.Point(9, 135);
            this.checkBox_repeatOLStim.Name = "checkBox_repeatOLStim";
            this.checkBox_repeatOLStim.Size = new System.Drawing.Size(277, 30);
            this.checkBox_repeatOLStim.TabIndex = 42;
            this.checkBox_repeatOLStim.Text = "Repeat protocol using automated file creation?\r\ne.g.  <yr-mo-day>_<base-fid>_<fil" +
                "e index>.spk,.stim,...";
            this.checkBox_repeatOLStim.UseVisualStyleBackColor = true;
            // 
            // NeuroRighter
            // 
            this.AcceptButton = this.buttonStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 830);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "NeuroRighter";
            this.Text = "NeuroRighter v";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NeuroControl_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.led_recording)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.switch_record)).EndInit();
            this.groupBox32.ResumeLayout(false);
            this.groupBox32.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_timedRecordingDurationSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_timedRecordingDuration)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LFPFiltOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LFPHighCut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LFPLowCut)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpikeFiltOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpikeHighCut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpikeLowCut)).EndInit();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPostSamples)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPreSamples)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdMultiplier)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl_sidebar.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox31.ResumeLayout(false);
            this.groupBox31.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_salpa_delta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_salpa_postpegzeros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_salpa_postpeg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_salpa_halfwidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.channelOut)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage_diagnostics.ResumeLayout(false);
            this.tabPage_diagnostics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scatterGraph_diagnostics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_numPeriods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_diagnosticsVoltage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_startFreq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_stopFreq)).EndInit();
            this.tabPage_impedance.ResumeLayout(false);
            this.groupBox21.ResumeLayout(false);
            this.groupBox21.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_impChannel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scatterGraph_impedance)).EndInit();
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_impNumPeriods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_impStartFreq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_impStopFreq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_impCommandVoltage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_RMeas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_RGain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_RCurr)).EndInit();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.tabPage_stim.ResumeLayout(false);
            this.groupBox33.ResumeLayout(false);
            this.groupBox30.ResumeLayout(false);
            this.groupBox30.PerformLayout();
            this.groupBox24.ResumeLayout(false);
            this.groupBox24.PerformLayout();
            this.groupBox18.ResumeLayout(false);
            this.groupBox18.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.offsetVoltage)).EndInit();
            this.groupBox23.ResumeLayout(false);
            this.groupBox23.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_IISZapper_channel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_IISZapper_phaseWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_IISZapper_rate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_IISZapper_voltage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_IISZapper_pulsePerTrain)).EndInit();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_exptNumRepeats)).EndInit();
            this.groupBox22.ResumeLayout(false);
            this.groupBox22.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_electrolesioningDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_electrolesioningVoltage)).EndInit();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.waveformGraph_openLoopStimPulse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openLoopPostphaseLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openLoopPrephaseLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openLoopWidth2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openLoopVoltage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openLoopInterphaseLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openLoopWidth1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openLoopVoltage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openLoopRate)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox29.ResumeLayout(false);
            this.groupBox29.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stimInterphaseLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stimChannel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stimWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stimRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stimVoltage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stimPulses)).EndInit();
            this.tabPage_ProgRef.ResumeLayout(false);
            this.groupBox_plexonProgRef.ResumeLayout(false);
            this.groupBox_plexonProgRef.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_analogRefLFPs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_analogRefSpikes)).EndInit();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox25.ResumeLayout(false);
            this.groupBox25.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CommonMedianLocalReferencingChannelsPerGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_digRefLFPs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_digRefSpikes)).EndInit();
            this.tabPage_EEG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eegGraph)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox19.ResumeLayout(false);
            this.groupBox19.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EEGFiltOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EEGHighCut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EEGLowCut)).EndInit();
            this.tabPage_waveforms.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_OutputFile;
        private System.Windows.Forms.Button button_BrowseOutputFile;
        private System.Windows.Forms.ToolTip toolTip_outputFilename;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBox_SALPA;
        private System.Windows.Forms.CheckBox checkBox_spikesFilter;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown SpikeHighCut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown SpikeLowCut;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown LFPHighCut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown LFPLowCut;
        private System.Windows.Forms.CheckBox checkBox_LFPsFilter;
        private System.Windows.Forms.Label label8;
        private NationalInstruments.UI.WindowsForms.Switch switch_record;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown thresholdMultiplier;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numPostSamples;
        private System.Windows.Forms.NumericUpDown numPreSamples;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.CheckBox checkBox_video;
        private System.Windows.Forms.Timer timer_expt;
        private System.ComponentModel.BackgroundWorker bw_genExpt;
        private System.ComponentModel.BackgroundWorker bw_stim;
        private System.Windows.Forms.Button button_scaleUp;
        private System.Windows.Forms.Button button_scaleDown;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.ComponentModel.BackgroundWorker bw_openLoop;
        private System.Windows.Forms.Button button_scaleReset;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.NumericUpDown LFPFiltOrder;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.NumericUpDown SpikeFiltOrder;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.CheckBox checkBox_freeze;
        private NationalInstruments.UI.WaveformPlot spkWfmPlot1;
        private NationalInstruments.UI.XAxis xAxis3;
        private NationalInstruments.UI.YAxis yAxis3;
        private NationalInstruments.UI.WindowsForms.Led led_recording;
        private System.Windows.Forms.CheckBox checkBox_spikeValidation;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_DisplaySettings;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processingSettingsToolStripMenuItem;
        private System.Windows.Forms.Label label_timeElapsed;
        private System.Windows.Forms.Timer timer_timeElapsed;
        private System.Windows.Forms.TabControl tabControl_sidebar;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ProgressBar progressBar_train;
        private System.Windows.Forms.Button button_Train;
        private System.Windows.Forms.Label label_noise;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_numChannels;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox_LFPGain;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.ComboBox comboBox_SpikeGain;
        private System.Windows.Forms.Label label_SpikeGain;
        private System.Windows.Forms.Label label_LFPSamplingRate;
        private System.Windows.Forms.Label label_SpikeSamplingRate;
        private System.Windows.Forms.TextBox textBox_spikeSamplingRate;
        private System.Windows.Forms.TextBox textBox_lfpSamplingRate;
        private System.Windows.Forms.CheckBox checkBox_artiFilt;
        private System.Windows.Forms.ImageList imageList_zoomButtons;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown channelOut;
        private System.Windows.Forms.NumericUpDown numericUpDown_timedRecordingDuration;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.CheckBox checkBox_enableTimedRecording;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.CheckBox checkBox_SaveRawSpikes;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.TextBox textBox_MUASamplingRate;
        private System.Windows.Forms.TabPage tabPage_diagnostics;
        private System.Windows.Forms.CheckBox checkBox_diagnosticsDigitalFilter;
        private System.Windows.Forms.TextBox textBox_diagnosticsMult;
        private System.Windows.Forms.TextBox textBox_voltageDivider;
        private System.Windows.Forms.TextBox textBox_diagnosticsResults;
        private NationalInstruments.UI.WindowsForms.ScatterGraph scatterGraph_diagnostics;
        private NationalInstruments.UI.ScatterPlot scatterPlot1;
        private NationalInstruments.UI.XAxis xAxis4;
        private NationalInstruments.UI.YAxis yAxis4;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.CheckBox checkBox_diagnosticsVotlageDivider;
        private System.Windows.Forms.CheckBox checkBox_diagnosticsBulk;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.NumericUpDown numericUpDown_numPeriods;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.NumericUpDown numericUpDown_diagnosticsVoltage;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.NumericUpDown numericUpDown_startFreq;
        private System.Windows.Forms.NumericUpDown numericUpDown_stopFreq;
        private System.Windows.Forms.Button button_computeGain;
        private System.Windows.Forms.TabPage tabPage_impedance;
        private System.Windows.Forms.Button button_impedanceSaveAsMAT;
        private System.Windows.Forms.GroupBox groupBox21;
        private System.Windows.Forms.CheckBox checkBox_impedanceAllChannels;
        private System.Windows.Forms.NumericUpDown numericUpDown_impChannel;
        private System.Windows.Forms.Button button_impedanceCopyDataToClipboard;
        private NationalInstruments.UI.WindowsForms.ScatterGraph scatterGraph_impedance;
        private NationalInstruments.UI.ScatterPlot scatterPlot2;
        private NationalInstruments.UI.XAxis xAxis2;
        private NationalInstruments.UI.YAxis yAxis2;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.TextBox textBox_impedanceResults;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.Label label_impedanceProgress;
        private System.Windows.Forms.ProgressBar progressBar_impedance;
        private System.Windows.Forms.CheckBox checkBox_impUseMatchedFilter;
        private System.Windows.Forms.CheckBox checkBox_impBandpassFilter;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.NumericUpDown numericUpDown_impNumPeriods;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.NumericUpDown numericUpDown_impStartFreq;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.NumericUpDown numericUpDown_impStopFreq;
        private System.Windows.Forms.NumericUpDown numericUpDown_impCommandVoltage;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.NumericUpDown numericUpDown_RMeas;
        private System.Windows.Forms.NumericUpDown numericUpDown_RGain;
        private System.Windows.Forms.NumericUpDown numericUpDown_RCurr;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.RadioButton radioButton_impVoltage;
        private System.Windows.Forms.RadioButton radioButton_impCurrent;
        private System.Windows.Forms.Button button_impedanceTest;
        private System.Windows.Forms.Button button_impedanceCancel;
        private System.Windows.Forms.TabPage tabPage_stim;
        private System.Windows.Forms.Button button_showcase;
        private System.Windows.Forms.GroupBox groupBox24;
        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.RadioButton radioButton_stimVoltageControlled;
        private System.Windows.Forms.RadioButton radioButton_stimCurrentControlled;
        private System.Windows.Forms.NumericUpDown offsetVoltage;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.GroupBox groupBox23;
        private System.Windows.Forms.Button button_IISZapper_stop;
        private System.Windows.Forms.Button button_IISZapper_start;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.NumericUpDown numericUpDown_IISZapper_channel;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.NumericUpDown numericUpDown_IISZapper_phaseWidth;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.NumericUpDown numericUpDown_IISZapper_rate;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.NumericUpDown numericUpDown_IISZapper_voltage;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.NumericUpDown numericUpDown_IISZapper_pulsePerTrain;
        private System.Windows.Forms.GroupBox groupBox22;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Button button_electrolesioningSelectNone;
        private System.Windows.Forms.Button button_electrolesioningSelectAll;
        private System.Windows.Forms.ListBox listBox_electrolesioningChannels;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.NumericUpDown numericUpDown_electrolesioningDuration;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.NumericUpDown numericUpDown_electrolesioningVoltage;
        private System.Windows.Forms.Button button_electrolesioningStart;
        private System.Windows.Forms.GroupBox groupBox12;
        private NationalInstruments.UI.WindowsForms.WaveformGraph waveformGraph_openLoopStimPulse;
        private NationalInstruments.UI.WaveformPlot waveformPlot1;
        private NationalInstruments.UI.XAxis xAxis1;
        private NationalInstruments.UI.YAxis yAxis1;
        private System.Windows.Forms.Button button_openLoopSelectNone;
        private System.Windows.Forms.Button button_openLoopSelectAll;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.NumericUpDown openLoopPostphaseLength;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.NumericUpDown openLoopPrephaseLength;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.NumericUpDown openLoopWidth2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown openLoopVoltage2;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.NumericUpDown openLoopInterphaseLength;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ListBox listBox_stimChannels;
        private System.Windows.Forms.Button openLoopStop;
        private System.Windows.Forms.Button openLoopStart;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.NumericUpDown openLoopWidth1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.NumericUpDown openLoopVoltage1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown openLoopRate;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.NumericUpDown numericUpDown_exptNumRepeats;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.TextBox textBox_exptPulseWidths;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.TextBox textBox_exptPPT;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.TextBox textBox_exptVoltages;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Button button_stopExpt;
        private System.Windows.Forms.ListBox listBox_exptStimChannels;
        private System.Windows.Forms.ProgressBar progressBar_stimExpt;
        private System.Windows.Forms.Button button_stimExpt;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.NumericUpDown stimInterphaseLength;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown stimChannel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown stimWidth;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown stimRate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown stimVoltage;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown stimPulses;
        private System.Windows.Forms.Button button_stim;
        private System.Windows.Forms.TabPage tabPage_ProgRef;
        private System.Windows.Forms.GroupBox groupBox_plexonProgRef;
        private System.Windows.Forms.Button button_analogResetRefs;
        private System.Windows.Forms.CheckBox checkBox_analogRefLFPs;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.NumericUpDown numericUpDown_analogRefLFPs;
        private System.Windows.Forms.CheckBox checkBox_analogRefSpikes;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.NumericUpDown numericUpDown_analogRefSpikes;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.GroupBox groupBox25;
        private System.Windows.Forms.RadioButton radioButton_spikesReferencingCommonAverage;
        private System.Windows.Forms.RadioButton radioButton_spikesReferencingCommonMedian;
        private System.Windows.Forms.RadioButton radioButton_spikesReferencingCommonMedianLocal;
        private System.Windows.Forms.RadioButton radioButton_spikeReferencingNone;
        private System.Windows.Forms.CheckBox checkBox_digRefLFPs;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.NumericUpDown numericUpDown_digRefLFPs;
        private System.Windows.Forms.CheckBox checkBox_digRefSpikes;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.NumericUpDown numericUpDown_digRefSpikes;
        private System.Windows.Forms.TabPage tabPage_EEG;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.CheckBox checkBox_eegFilter;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.NumericUpDown EEGFiltOrder;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.NumericUpDown EEGHighCut;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.NumericUpDown EEGLowCut;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.TextBox textBox_eegSamplingRate;
        private System.Windows.Forms.ComboBox comboBox_eegGain;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.ComboBox comboBox_eegNumChannels;
        private System.Windows.Forms.TabPage tabPage_LFPs;
        private System.Windows.Forms.TabPage tabPage_waveforms;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_clearSpkWfms;
        private System.Windows.Forms.TabPage tabPage_spikes;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage_MUA;
        private System.Windows.Forms.Button button_ElectrodeScreeningSelectNone;
        private System.Windows.Forms.Button button_ElectrodeScreeningSelectAll;
        private System.Windows.Forms.GroupBox groupBox29;
        private System.Windows.Forms.RadioButton radioButton_OnDemandBiphasic;
        private System.Windows.Forms.RadioButton radioButton_OnDemandUniphasic;
        private System.Windows.Forms.NumericUpDown numericUpDown_CommonMedianLocalReferencingChannelsPerGroup;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.GroupBox groupBox30;
        private System.Windows.Forms.ProgressBar progressBar_protocolFromFile;
        private System.Windows.Forms.Button button_stopStimFromFile;
        private System.Windows.Forms.TextBox textBox_protocolFileLocations;
        private System.Windows.Forms.Label label85;
        private System.Windows.Forms.Button button_startStimFromFile;
        private System.Windows.Forms.Button button_BrowseOLStimFile;
        private System.Windows.Forms.GroupBox groupBox31;
        private System.Windows.Forms.NumericUpDown numericUpDown_salpa_delta;
        private System.Windows.Forms.NumericUpDown numericUpDown_salpa_postpegzeros;
        private System.Windows.Forms.NumericUpDown numericUpDown_salpa_postpeg;
        private System.Windows.Forms.NumericUpDown numericUpDown_salpa_halfwidth;
        private System.Windows.Forms.Label label86;
        private System.Windows.Forms.Label label87;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.Label label88;
        private AxCWUIControlsLib.AxCWGraph eegGraph;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_lfpSamplingRate;
        private System.Windows.Forms.Button button_spikeSamplingRate;
        private System.Windows.Forms.NumericUpDown numericUpDown_timedRecordingDurationSeconds;
        private System.Windows.Forms.GroupBox groupBox32;
        private System.Windows.Forms.Label label90;
        private System.Windows.Forms.Label label89;
        private System.Windows.Forms.Label label91;
        private System.Windows.Forms.TextBox textBox_AbsArtThresh;
        private System.Windows.Forms.Label label93;
        private System.Windows.Forms.Label label92;
        protected System.Windows.Forms.ComboBox comboBox_spikeDetAlg;
        private System.Windows.Forms.GroupBox groupBox33;
        private System.Windows.Forms.ProgressBar progressBar_pnpcl;
        private System.Windows.Forms.Button stopPNPCL;
        private System.Windows.Forms.Button startPNPCL;
        private System.Windows.Forms.ComboBox pnpcl_available_dropdown;
        private System.Windows.Forms.Button refreshClosedLoopButton;
        private System.Windows.Forms.Button DebugButton;
        private System.Windows.Forms.Button button_BrowseOLDFile;
        private System.Windows.Forms.TextBox textBox_digitalProtocolFileLocation;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.CheckBox checkBox_repeatOLStim;
        private System.Windows.Forms.CheckBox checkBox_useManStimWaveform;
    }
}