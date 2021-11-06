
namespace ClevoFanControl {
    partial class frmMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblCPUHeader = new System.Windows.Forms.Label();
            this.lblCPUTemp = new System.Windows.Forms.Label();
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.lblCPUFanHeader = new System.Windows.Forms.Label();
            this.lblCPUFan = new System.Windows.Forms.Label();
            this.icoTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.mnuMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuShowWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuProfileManual = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProfileDefault = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProfile50 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProfileMax = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlCPUStats = new System.Windows.Forms.Panel();
            this.lblCPUMaxTemp = new System.Windows.Forms.Label();
            this.imgStatIntel = new System.Windows.Forms.PictureBox();
            this.pnlGPUStats = new System.Windows.Forms.Panel();
            this.lblGPUMaxTemp = new System.Windows.Forms.Label();
            this.imgStatNvidia = new System.Windows.Forms.PictureBox();
            this.lblGPUHeader = new System.Windows.Forms.Label();
            this.lblGPUFanHeader = new System.Windows.Forms.Label();
            this.lblGPUFan = new System.Windows.Forms.Label();
            this.lblGPUTemp = new System.Windows.Forms.Label();
            this.pnlFanDuties = new System.Windows.Forms.Panel();
            this.imgStatFan = new System.Windows.Forms.PictureBox();
            this.lblGPUPrgHeader = new System.Windows.Forms.Label();
            this.prgGPUFanContainer = new System.Windows.Forms.Panel();
            this.prgGPUFan = new System.Windows.Forms.PictureBox();
            this.lblCPUPrgHeader = new System.Windows.Forms.Label();
            this.prgCPUFanContainer = new System.Windows.Forms.Panel();
            this.prgCPUFan = new System.Windows.Forms.PictureBox();
            this.lblFanDutyHeader = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabFanCurves = new System.Windows.Forms.TabControl();
            this.tabFanCurveCPU = new System.Windows.Forms.TabPage();
            this.cpuPlot = new CurveEditorControl.PlotCanvasContainer();
            this.tabFanCurveGPU = new System.Windows.Forms.TabPage();
            this.gpuPlot = new CurveEditorControl.PlotCanvasContainer();
            this.lblFanCurveHeader = new System.Windows.Forms.Label();
            this.pnlProfiles = new System.Windows.Forms.Panel();
            this.btnProfile50 = new System.Windows.Forms.RadioButton();
            this.btnProfileMax = new System.Windows.Forms.RadioButton();
            this.btnProfileManual = new System.Windows.Forms.RadioButton();
            this.btnProfileDefault = new System.Windows.Forms.RadioButton();
            this.lblProfilesHeader = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAlwaysOnTop = new System.Windows.Forms.CheckBox();
            this.btnACFans = new System.Windows.Forms.CheckBox();
            this.tipTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.tmrHighCpuDelay = new System.Windows.Forms.Timer(this.components);
            this.lblCpuSafetyTemp = new System.Windows.Forms.Label();
            this.lblCpuSafetyTemp2 = new System.Windows.Forms.Label();
            this.txtCpuSafetyTemp = new System.Windows.Forms.NumericUpDown();
            this.txtGpuSafetyTemp = new System.Windows.Forms.NumericUpDown();
            this.lblGpuSafetyTemp2 = new System.Windows.Forms.Label();
            this.lblGpuSafetyTemp = new System.Windows.Forms.Label();
            this.btnGpuBattMonitor = new System.Windows.Forms.CheckBox();
            this.tmrGui = new System.Windows.Forms.Timer(this.components);
            this.mnuMain.SuspendLayout();
            this.pnlCPUStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgStatIntel)).BeginInit();
            this.pnlGPUStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgStatNvidia)).BeginInit();
            this.pnlFanDuties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgStatFan)).BeginInit();
            this.prgGPUFanContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prgGPUFan)).BeginInit();
            this.prgCPUFanContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prgCPUFan)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabFanCurves.SuspendLayout();
            this.tabFanCurveCPU.SuspendLayout();
            this.tabFanCurveGPU.SuspendLayout();
            this.pnlProfiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCpuSafetyTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGpuSafetyTemp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCPUHeader
            // 
            this.lblCPUHeader.AutoSize = true;
            this.lblCPUHeader.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPUHeader.ForeColor = System.Drawing.Color.Black;
            this.lblCPUHeader.Location = new System.Drawing.Point(4, 9);
            this.lblCPUHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCPUHeader.Name = "lblCPUHeader";
            this.lblCPUHeader.Size = new System.Drawing.Size(42, 22);
            this.lblCPUHeader.TabIndex = 0;
            this.lblCPUHeader.Text = "CPU";
            // 
            // lblCPUTemp
            // 
            this.lblCPUTemp.BackColor = System.Drawing.Color.Transparent;
            this.lblCPUTemp.Font = new System.Drawing.Font("Open Sans", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPUTemp.ForeColor = System.Drawing.Color.Black;
            this.lblCPUTemp.Location = new System.Drawing.Point(6, 38);
            this.lblCPUTemp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCPUTemp.Name = "lblCPUTemp";
            this.lblCPUTemp.Size = new System.Drawing.Size(122, 48);
            this.lblCPUTemp.TabIndex = 2;
            this.lblCPUTemp.Text = "0";
            this.lblCPUTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrMain
            // 
            this.tmrMain.Interval = 1000;
            this.tmrMain.Tick += new System.EventHandler(this.tmrMain_Tick);
            // 
            // lblCPUFanHeader
            // 
            this.lblCPUFanHeader.AutoSize = true;
            this.lblCPUFanHeader.ForeColor = System.Drawing.Color.Black;
            this.lblCPUFanHeader.Location = new System.Drawing.Point(4, 99);
            this.lblCPUFanHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCPUFanHeader.Name = "lblCPUFanHeader";
            this.lblCPUFanHeader.Size = new System.Drawing.Size(71, 20);
            this.lblCPUFanHeader.TabIndex = 5;
            this.lblCPUFanHeader.Text = "Fan Duty";
            // 
            // lblCPUFan
            // 
            this.lblCPUFan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCPUFan.ForeColor = System.Drawing.Color.Black;
            this.lblCPUFan.Location = new System.Drawing.Point(50, 99);
            this.lblCPUFan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCPUFan.Name = "lblCPUFan";
            this.lblCPUFan.Size = new System.Drawing.Size(78, 20);
            this.lblCPUFan.TabIndex = 7;
            this.lblCPUFan.Text = "0%";
            this.lblCPUFan.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // icoTray
            // 
            this.icoTray.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.icoTray.BalloonTipText = "Clevo Fan Control";
            this.icoTray.BalloonTipTitle = "Clevo Fan Control";
            this.icoTray.ContextMenuStrip = this.mnuMain;
            this.icoTray.Icon = ((System.Drawing.Icon)(resources.GetObject("icoTray.Icon")));
            this.icoTray.Text = "Clevo Fan Control";
            this.icoTray.Visible = true;
            this.icoTray.DoubleClick += new System.EventHandler(this.icoTray_DoubleClick);
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuShowWindow,
            this.mnuSeparator1,
            this.mnuProfileManual,
            this.mnuProfileDefault,
            this.mnuProfile50,
            this.mnuProfileMax,
            this.mnuSeparator2,
            this.mnuAbout,
            this.mnuExit});
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(183, 170);
            // 
            // mnuShowWindow
            // 
            this.mnuShowWindow.Name = "mnuShowWindow";
            this.mnuShowWindow.Size = new System.Drawing.Size(182, 22);
            this.mnuShowWindow.Text = "&Show Window";
            this.mnuShowWindow.Click += new System.EventHandler(this.mnuShowWindow_Click);
            // 
            // mnuSeparator1
            // 
            this.mnuSeparator1.Name = "mnuSeparator1";
            this.mnuSeparator1.Size = new System.Drawing.Size(179, 6);
            // 
            // mnuProfileManual
            // 
            this.mnuProfileManual.Name = "mnuProfileManual";
            this.mnuProfileManual.Size = new System.Drawing.Size(182, 22);
            this.mnuProfileManual.Text = "Manual Profile";
            this.mnuProfileManual.Click += new System.EventHandler(this.mnuProfileManual_Click);
            // 
            // mnuProfileDefault
            // 
            this.mnuProfileDefault.Name = "mnuProfileDefault";
            this.mnuProfileDefault.Size = new System.Drawing.Size(182, 22);
            this.mnuProfileDefault.Text = "Clevo Default Profile";
            this.mnuProfileDefault.Click += new System.EventHandler(this.mnuProfileDefault_Click);
            // 
            // mnuProfile50
            // 
            this.mnuProfile50.Name = "mnuProfile50";
            this.mnuProfile50.Size = new System.Drawing.Size(182, 22);
            this.mnuProfile50.Text = "50% Speed Profile";
            this.mnuProfile50.Click += new System.EventHandler(this.mnuProfile50_Click);
            // 
            // mnuProfileMax
            // 
            this.mnuProfileMax.Name = "mnuProfileMax";
            this.mnuProfileMax.Size = new System.Drawing.Size(182, 22);
            this.mnuProfileMax.Text = "Maximum Profile";
            this.mnuProfileMax.Click += new System.EventHandler(this.mnuProfileMax_Click);
            // 
            // mnuSeparator2
            // 
            this.mnuSeparator2.Name = "mnuSeparator2";
            this.mnuSeparator2.Size = new System.Drawing.Size(179, 6);
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(182, 22);
            this.mnuAbout.Text = "&About";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(182, 22);
            this.mnuExit.Text = "E&xit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // pnlCPUStats
            // 
            this.pnlCPUStats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCPUStats.Controls.Add(this.lblCPUMaxTemp);
            this.pnlCPUStats.Controls.Add(this.imgStatIntel);
            this.pnlCPUStats.Controls.Add(this.lblCPUHeader);
            this.pnlCPUStats.Controls.Add(this.lblCPUFanHeader);
            this.pnlCPUStats.Controls.Add(this.lblCPUFan);
            this.pnlCPUStats.Controls.Add(this.lblCPUTemp);
            this.pnlCPUStats.Location = new System.Drawing.Point(12, 12);
            this.pnlCPUStats.Name = "pnlCPUStats";
            this.pnlCPUStats.Size = new System.Drawing.Size(135, 130);
            this.pnlCPUStats.TabIndex = 11;
            // 
            // lblCPUMaxTemp
            // 
            this.lblCPUMaxTemp.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPUMaxTemp.ForeColor = System.Drawing.Color.Black;
            this.lblCPUMaxTemp.Location = new System.Drawing.Point(5, 77);
            this.lblCPUMaxTemp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCPUMaxTemp.Name = "lblCPUMaxTemp";
            this.lblCPUMaxTemp.Size = new System.Drawing.Size(123, 20);
            this.lblCPUMaxTemp.TabIndex = 11;
            this.lblCPUMaxTemp.Text = "Max: 0";
            this.lblCPUMaxTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tipTooltip.SetToolTip(this.lblCPUMaxTemp, "Click to reset CPU max temperature");
            this.lblCPUMaxTemp.Click += new System.EventHandler(this.lblCPUMaxTemp_Click);
            // 
            // imgStatIntel
            // 
            this.imgStatIntel.Image = global::ClevoFanControl.Properties.Resources.intel;
            this.imgStatIntel.Location = new System.Drawing.Point(88, 3);
            this.imgStatIntel.Name = "imgStatIntel";
            this.imgStatIntel.Size = new System.Drawing.Size(40, 40);
            this.imgStatIntel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgStatIntel.TabIndex = 8;
            this.imgStatIntel.TabStop = false;
            // 
            // pnlGPUStats
            // 
            this.pnlGPUStats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGPUStats.Controls.Add(this.lblGPUMaxTemp);
            this.pnlGPUStats.Controls.Add(this.imgStatNvidia);
            this.pnlGPUStats.Controls.Add(this.lblGPUHeader);
            this.pnlGPUStats.Controls.Add(this.lblGPUFanHeader);
            this.pnlGPUStats.Controls.Add(this.lblGPUFan);
            this.pnlGPUStats.Controls.Add(this.lblGPUTemp);
            this.pnlGPUStats.Location = new System.Drawing.Point(153, 12);
            this.pnlGPUStats.Name = "pnlGPUStats";
            this.pnlGPUStats.Size = new System.Drawing.Size(135, 130);
            this.pnlGPUStats.TabIndex = 12;
            // 
            // lblGPUMaxTemp
            // 
            this.lblGPUMaxTemp.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPUMaxTemp.ForeColor = System.Drawing.Color.Black;
            this.lblGPUMaxTemp.Location = new System.Drawing.Point(5, 77);
            this.lblGPUMaxTemp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGPUMaxTemp.Name = "lblGPUMaxTemp";
            this.lblGPUMaxTemp.Size = new System.Drawing.Size(123, 20);
            this.lblGPUMaxTemp.TabIndex = 10;
            this.lblGPUMaxTemp.Text = "Max: 0";
            this.lblGPUMaxTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tipTooltip.SetToolTip(this.lblGPUMaxTemp, "Click to reset GPU max temperature");
            this.lblGPUMaxTemp.Click += new System.EventHandler(this.lblGPUMaxTemp_Click);
            // 
            // imgStatNvidia
            // 
            this.imgStatNvidia.Image = global::ClevoFanControl.Properties.Resources.nvidia;
            this.imgStatNvidia.Location = new System.Drawing.Point(88, 3);
            this.imgStatNvidia.Name = "imgStatNvidia";
            this.imgStatNvidia.Size = new System.Drawing.Size(40, 40);
            this.imgStatNvidia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgStatNvidia.TabIndex = 9;
            this.imgStatNvidia.TabStop = false;
            // 
            // lblGPUHeader
            // 
            this.lblGPUHeader.AutoSize = true;
            this.lblGPUHeader.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPUHeader.ForeColor = System.Drawing.Color.Black;
            this.lblGPUHeader.Location = new System.Drawing.Point(4, 9);
            this.lblGPUHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGPUHeader.Name = "lblGPUHeader";
            this.lblGPUHeader.Size = new System.Drawing.Size(44, 22);
            this.lblGPUHeader.TabIndex = 0;
            this.lblGPUHeader.Text = "GPU";
            // 
            // lblGPUFanHeader
            // 
            this.lblGPUFanHeader.AutoSize = true;
            this.lblGPUFanHeader.ForeColor = System.Drawing.Color.Black;
            this.lblGPUFanHeader.Location = new System.Drawing.Point(4, 99);
            this.lblGPUFanHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGPUFanHeader.Name = "lblGPUFanHeader";
            this.lblGPUFanHeader.Size = new System.Drawing.Size(71, 20);
            this.lblGPUFanHeader.TabIndex = 5;
            this.lblGPUFanHeader.Text = "Fan Duty";
            // 
            // lblGPUFan
            // 
            this.lblGPUFan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGPUFan.ForeColor = System.Drawing.Color.Black;
            this.lblGPUFan.Location = new System.Drawing.Point(50, 99);
            this.lblGPUFan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGPUFan.Name = "lblGPUFan";
            this.lblGPUFan.Size = new System.Drawing.Size(78, 20);
            this.lblGPUFan.TabIndex = 7;
            this.lblGPUFan.Text = "0%";
            this.lblGPUFan.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblGPUTemp
            // 
            this.lblGPUTemp.BackColor = System.Drawing.Color.Transparent;
            this.lblGPUTemp.Font = new System.Drawing.Font("Open Sans", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPUTemp.ForeColor = System.Drawing.Color.Black;
            this.lblGPUTemp.Location = new System.Drawing.Point(6, 38);
            this.lblGPUTemp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGPUTemp.Name = "lblGPUTemp";
            this.lblGPUTemp.Size = new System.Drawing.Size(122, 48);
            this.lblGPUTemp.TabIndex = 2;
            this.lblGPUTemp.Text = "0";
            this.lblGPUTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlFanDuties
            // 
            this.pnlFanDuties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFanDuties.Controls.Add(this.imgStatFan);
            this.pnlFanDuties.Controls.Add(this.lblGPUPrgHeader);
            this.pnlFanDuties.Controls.Add(this.prgGPUFanContainer);
            this.pnlFanDuties.Controls.Add(this.lblCPUPrgHeader);
            this.pnlFanDuties.Controls.Add(this.prgCPUFanContainer);
            this.pnlFanDuties.Controls.Add(this.lblFanDutyHeader);
            this.pnlFanDuties.Location = new System.Drawing.Point(294, 12);
            this.pnlFanDuties.Name = "pnlFanDuties";
            this.pnlFanDuties.Size = new System.Drawing.Size(297, 130);
            this.pnlFanDuties.TabIndex = 12;
            // 
            // imgStatFan
            // 
            this.imgStatFan.Image = global::ClevoFanControl.Properties.Resources.clevofancontrol;
            this.imgStatFan.Location = new System.Drawing.Point(254, 5);
            this.imgStatFan.Name = "imgStatFan";
            this.imgStatFan.Size = new System.Drawing.Size(36, 36);
            this.imgStatFan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgStatFan.TabIndex = 10;
            this.imgStatFan.TabStop = false;
            // 
            // lblGPUPrgHeader
            // 
            this.lblGPUPrgHeader.AutoSize = true;
            this.lblGPUPrgHeader.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPUPrgHeader.ForeColor = System.Drawing.Color.Black;
            this.lblGPUPrgHeader.Location = new System.Drawing.Point(18, 77);
            this.lblGPUPrgHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGPUPrgHeader.Name = "lblGPUPrgHeader";
            this.lblGPUPrgHeader.Size = new System.Drawing.Size(40, 20);
            this.lblGPUPrgHeader.TabIndex = 4;
            this.lblGPUPrgHeader.Text = "GPU";
            // 
            // prgGPUFanContainer
            // 
            this.prgGPUFanContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prgGPUFanContainer.Controls.Add(this.prgGPUFan);
            this.prgGPUFanContainer.Location = new System.Drawing.Point(63, 81);
            this.prgGPUFanContainer.Name = "prgGPUFanContainer";
            this.prgGPUFanContainer.Size = new System.Drawing.Size(208, 14);
            this.prgGPUFanContainer.TabIndex = 3;
            // 
            // prgGPUFan
            // 
            this.prgGPUFan.BackColor = System.Drawing.Color.DimGray;
            this.prgGPUFan.Location = new System.Drawing.Point(1, 1);
            this.prgGPUFan.Name = "prgGPUFan";
            this.prgGPUFan.Size = new System.Drawing.Size(376, 10);
            this.prgGPUFan.TabIndex = 0;
            this.prgGPUFan.TabStop = false;
            // 
            // lblCPUPrgHeader
            // 
            this.lblCPUPrgHeader.AutoSize = true;
            this.lblCPUPrgHeader.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPUPrgHeader.ForeColor = System.Drawing.Color.Black;
            this.lblCPUPrgHeader.Location = new System.Drawing.Point(18, 46);
            this.lblCPUPrgHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCPUPrgHeader.Name = "lblCPUPrgHeader";
            this.lblCPUPrgHeader.Size = new System.Drawing.Size(38, 20);
            this.lblCPUPrgHeader.TabIndex = 2;
            this.lblCPUPrgHeader.Text = "CPU";
            // 
            // prgCPUFanContainer
            // 
            this.prgCPUFanContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prgCPUFanContainer.Controls.Add(this.prgCPUFan);
            this.prgCPUFanContainer.Location = new System.Drawing.Point(63, 50);
            this.prgCPUFanContainer.Name = "prgCPUFanContainer";
            this.prgCPUFanContainer.Size = new System.Drawing.Size(208, 14);
            this.prgCPUFanContainer.TabIndex = 1;
            // 
            // prgCPUFan
            // 
            this.prgCPUFan.BackColor = System.Drawing.Color.DimGray;
            this.prgCPUFan.Location = new System.Drawing.Point(1, 1);
            this.prgCPUFan.Name = "prgCPUFan";
            this.prgCPUFan.Size = new System.Drawing.Size(376, 10);
            this.prgCPUFan.TabIndex = 0;
            this.prgCPUFan.TabStop = false;
            // 
            // lblFanDutyHeader
            // 
            this.lblFanDutyHeader.AutoSize = true;
            this.lblFanDutyHeader.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFanDutyHeader.ForeColor = System.Drawing.Color.Black;
            this.lblFanDutyHeader.Location = new System.Drawing.Point(4, 9);
            this.lblFanDutyHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFanDutyHeader.Name = "lblFanDutyHeader";
            this.lblFanDutyHeader.Size = new System.Drawing.Size(91, 22);
            this.lblFanDutyHeader.TabIndex = 0;
            this.lblFanDutyHeader.Text = "Fan Duties";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tabFanCurves);
            this.panel1.Controls.Add(this.lblFanCurveHeader);
            this.panel1.Location = new System.Drawing.Point(12, 199);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 356);
            this.panel1.TabIndex = 12;
            // 
            // tabFanCurves
            // 
            this.tabFanCurves.Controls.Add(this.tabFanCurveCPU);
            this.tabFanCurves.Controls.Add(this.tabFanCurveGPU);
            this.tabFanCurves.Font = new System.Drawing.Font("Open Sans Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabFanCurves.Location = new System.Drawing.Point(3, 34);
            this.tabFanCurves.Name = "tabFanCurves";
            this.tabFanCurves.SelectedIndex = 0;
            this.tabFanCurves.Size = new System.Drawing.Size(573, 317);
            this.tabFanCurves.TabIndex = 1;
            // 
            // tabFanCurveCPU
            // 
            this.tabFanCurveCPU.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabFanCurveCPU.Controls.Add(this.cpuPlot);
            this.tabFanCurveCPU.Location = new System.Drawing.Point(4, 29);
            this.tabFanCurveCPU.Name = "tabFanCurveCPU";
            this.tabFanCurveCPU.Padding = new System.Windows.Forms.Padding(3);
            this.tabFanCurveCPU.Size = new System.Drawing.Size(565, 284);
            this.tabFanCurveCPU.TabIndex = 0;
            this.tabFanCurveCPU.Text = "CPU";
            // 
            // cpuPlot
            // 
            this.cpuPlot.Font = new System.Drawing.Font("Open Sans", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuPlot.Location = new System.Drawing.Point(16, 7);
            this.cpuPlot.Margin = new System.Windows.Forms.Padding(0);
            this.cpuPlot.Name = "cpuPlot";
            this.cpuPlot.Size = new System.Drawing.Size(534, 270);
            this.cpuPlot.TabIndex = 0;
            this.cpuPlot.Value01 = 50;
            this.cpuPlot.Value02 = 50;
            this.cpuPlot.Value03 = 50;
            this.cpuPlot.Value04 = 50;
            this.cpuPlot.Value05 = 50;
            this.cpuPlot.Value06 = 50;
            this.cpuPlot.Value07 = 50;
            this.cpuPlot.Value08 = 50;
            this.cpuPlot.Value09 = 50;
            this.cpuPlot.Value10 = 50;
            this.cpuPlot.XAxisItem01 = "40°";
            this.cpuPlot.XAxisItem02 = "45°";
            this.cpuPlot.XAxisItem03 = "50°";
            this.cpuPlot.XAxisItem04 = "55°";
            this.cpuPlot.XAxisItem05 = "60°";
            this.cpuPlot.XAxisItem06 = "65°";
            this.cpuPlot.XAxisItem07 = "70°";
            this.cpuPlot.XAxisItem08 = "75°";
            this.cpuPlot.XAxisItem09 = "80°";
            this.cpuPlot.XAxisItem10 = "90°";
            this.cpuPlot.PlotChanged += new System.Action<object, CurveEditorControl.PlotChangedEventArgs>(this.cpuPlot_PlotChanged);
            // 
            // tabFanCurveGPU
            // 
            this.tabFanCurveGPU.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabFanCurveGPU.Controls.Add(this.gpuPlot);
            this.tabFanCurveGPU.Location = new System.Drawing.Point(4, 29);
            this.tabFanCurveGPU.Name = "tabFanCurveGPU";
            this.tabFanCurveGPU.Padding = new System.Windows.Forms.Padding(3);
            this.tabFanCurveGPU.Size = new System.Drawing.Size(565, 284);
            this.tabFanCurveGPU.TabIndex = 1;
            this.tabFanCurveGPU.Text = "GPU";
            // 
            // gpuPlot
            // 
            this.gpuPlot.Font = new System.Drawing.Font("Open Sans", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpuPlot.Location = new System.Drawing.Point(16, 7);
            this.gpuPlot.Margin = new System.Windows.Forms.Padding(0);
            this.gpuPlot.Name = "gpuPlot";
            this.gpuPlot.Size = new System.Drawing.Size(534, 270);
            this.gpuPlot.TabIndex = 1;
            this.gpuPlot.Value01 = 50;
            this.gpuPlot.Value02 = 50;
            this.gpuPlot.Value03 = 50;
            this.gpuPlot.Value04 = 50;
            this.gpuPlot.Value05 = 50;
            this.gpuPlot.Value06 = 50;
            this.gpuPlot.Value07 = 50;
            this.gpuPlot.Value08 = 50;
            this.gpuPlot.Value09 = 50;
            this.gpuPlot.Value10 = 50;
            this.gpuPlot.XAxisItem01 = "40°";
            this.gpuPlot.XAxisItem02 = "45°";
            this.gpuPlot.XAxisItem03 = "50°";
            this.gpuPlot.XAxisItem04 = "55°";
            this.gpuPlot.XAxisItem05 = "60°";
            this.gpuPlot.XAxisItem06 = "65°";
            this.gpuPlot.XAxisItem07 = "70°";
            this.gpuPlot.XAxisItem08 = "75°";
            this.gpuPlot.XAxisItem09 = "80°";
            this.gpuPlot.XAxisItem10 = "90°";
            this.gpuPlot.PlotChanged += new System.Action<object, CurveEditorControl.PlotChangedEventArgs>(this.gpuPlot_PlotChanged);
            // 
            // lblFanCurveHeader
            // 
            this.lblFanCurveHeader.AutoSize = true;
            this.lblFanCurveHeader.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFanCurveHeader.ForeColor = System.Drawing.Color.Black;
            this.lblFanCurveHeader.Location = new System.Drawing.Point(4, 9);
            this.lblFanCurveHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFanCurveHeader.Name = "lblFanCurveHeader";
            this.lblFanCurveHeader.Size = new System.Drawing.Size(95, 22);
            this.lblFanCurveHeader.TabIndex = 0;
            this.lblFanCurveHeader.Text = "Fan Curves";
            // 
            // pnlProfiles
            // 
            this.pnlProfiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProfiles.Controls.Add(this.btnProfile50);
            this.pnlProfiles.Controls.Add(this.btnProfileMax);
            this.pnlProfiles.Controls.Add(this.btnProfileManual);
            this.pnlProfiles.Controls.Add(this.btnProfileDefault);
            this.pnlProfiles.Controls.Add(this.lblProfilesHeader);
            this.pnlProfiles.Location = new System.Drawing.Point(12, 148);
            this.pnlProfiles.Name = "pnlProfiles";
            this.pnlProfiles.Size = new System.Drawing.Size(579, 45);
            this.pnlProfiles.TabIndex = 13;
            // 
            // btnProfile50
            // 
            this.btnProfile50.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnProfile50.Location = new System.Drawing.Point(323, 6);
            this.btnProfile50.Name = "btnProfile50";
            this.btnProfile50.Size = new System.Drawing.Size(120, 30);
            this.btnProfile50.TabIndex = 5;
            this.btnProfile50.Text = "50% Speed";
            this.btnProfile50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnProfile50.UseVisualStyleBackColor = true;
            this.btnProfile50.CheckedChanged += new System.EventHandler(this.btnProfile50_CheckedChanged);
            // 
            // btnProfileMax
            // 
            this.btnProfileMax.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnProfileMax.Location = new System.Drawing.Point(449, 6);
            this.btnProfileMax.Name = "btnProfileMax";
            this.btnProfileMax.Size = new System.Drawing.Size(120, 30);
            this.btnProfileMax.TabIndex = 4;
            this.btnProfileMax.Text = "Maximum";
            this.btnProfileMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnProfileMax.UseVisualStyleBackColor = true;
            this.btnProfileMax.CheckedChanged += new System.EventHandler(this.btnProfileMax_CheckedChanged);
            // 
            // btnProfileManual
            // 
            this.btnProfileManual.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnProfileManual.Checked = true;
            this.btnProfileManual.Location = new System.Drawing.Point(71, 6);
            this.btnProfileManual.Name = "btnProfileManual";
            this.btnProfileManual.Size = new System.Drawing.Size(120, 30);
            this.btnProfileManual.TabIndex = 3;
            this.btnProfileManual.TabStop = true;
            this.btnProfileManual.Text = "Manual";
            this.btnProfileManual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnProfileManual.UseVisualStyleBackColor = true;
            this.btnProfileManual.CheckedChanged += new System.EventHandler(this.btnProfileManual_CheckedChanged);
            // 
            // btnProfileDefault
            // 
            this.btnProfileDefault.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnProfileDefault.Location = new System.Drawing.Point(197, 6);
            this.btnProfileDefault.Name = "btnProfileDefault";
            this.btnProfileDefault.Size = new System.Drawing.Size(120, 30);
            this.btnProfileDefault.TabIndex = 2;
            this.btnProfileDefault.Text = "Clevo Default";
            this.btnProfileDefault.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnProfileDefault.UseVisualStyleBackColor = true;
            this.btnProfileDefault.CheckedChanged += new System.EventHandler(this.btnProfileDefault_CheckedChanged);
            // 
            // lblProfilesHeader
            // 
            this.lblProfilesHeader.AutoSize = true;
            this.lblProfilesHeader.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfilesHeader.ForeColor = System.Drawing.Color.Black;
            this.lblProfilesHeader.Location = new System.Drawing.Point(5, 10);
            this.lblProfilesHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProfilesHeader.Name = "lblProfilesHeader";
            this.lblProfilesHeader.Size = new System.Drawing.Size(60, 22);
            this.lblProfilesHeader.TabIndex = 1;
            this.lblProfilesHeader.Text = "Profile";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(456, 599);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(135, 30);
            this.btnExit.TabIndex = 14;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAlwaysOnTop
            // 
            this.btnAlwaysOnTop.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnAlwaysOnTop.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlwaysOnTop.Location = new System.Drawing.Point(12, 599);
            this.btnAlwaysOnTop.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnAlwaysOnTop.Name = "btnAlwaysOnTop";
            this.btnAlwaysOnTop.Size = new System.Drawing.Size(130, 30);
            this.btnAlwaysOnTop.TabIndex = 15;
            this.btnAlwaysOnTop.Text = "Always on Top";
            this.btnAlwaysOnTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAlwaysOnTop.UseVisualStyleBackColor = true;
            this.btnAlwaysOnTop.CheckedChanged += new System.EventHandler(this.btnAlwaysOnTop_CheckedChanged);
            // 
            // btnACFans
            // 
            this.btnACFans.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnACFans.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnACFans.Location = new System.Drawing.Point(148, 599);
            this.btnACFans.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnACFans.Name = "btnACFans";
            this.btnACFans.Size = new System.Drawing.Size(130, 30);
            this.btnACFans.TabIndex = 16;
            this.btnACFans.Text = "Min 30% on AC";
            this.btnACFans.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnACFans.UseVisualStyleBackColor = true;
            // 
            // tmrHighCpuDelay
            // 
            this.tmrHighCpuDelay.Interval = 2500;
            this.tmrHighCpuDelay.Tick += new System.EventHandler(this.tmrHighCpuDelay_Tick);
            // 
            // lblCpuSafetyTemp
            // 
            this.lblCpuSafetyTemp.AutoSize = true;
            this.lblCpuSafetyTemp.Location = new System.Drawing.Point(12, 568);
            this.lblCpuSafetyTemp.Name = "lblCpuSafetyTemp";
            this.lblCpuSafetyTemp.Size = new System.Drawing.Size(127, 20);
            this.lblCpuSafetyTemp.TabIndex = 17;
            this.lblCpuSafetyTemp.Text = "CPU safety temp:";
            // 
            // lblCpuSafetyTemp2
            // 
            this.lblCpuSafetyTemp2.AutoSize = true;
            this.lblCpuSafetyTemp2.Location = new System.Drawing.Point(180, 568);
            this.lblCpuSafetyTemp2.Name = "lblCpuSafetyTemp2";
            this.lblCpuSafetyTemp2.Size = new System.Drawing.Size(15, 20);
            this.lblCpuSafetyTemp2.TabIndex = 20;
            this.lblCpuSafetyTemp2.Text = "°";
            // 
            // txtCpuSafetyTemp
            // 
            this.txtCpuSafetyTemp.Location = new System.Drawing.Point(137, 566);
            this.txtCpuSafetyTemp.Minimum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.txtCpuSafetyTemp.Name = "txtCpuSafetyTemp";
            this.txtCpuSafetyTemp.Size = new System.Drawing.Size(45, 28);
            this.txtCpuSafetyTemp.TabIndex = 21;
            this.txtCpuSafetyTemp.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.txtCpuSafetyTemp.ValueChanged += new System.EventHandler(this.txtCpuSafetyTemp_ValueChanged);
            // 
            // txtGpuSafetyTemp
            // 
            this.txtGpuSafetyTemp.Location = new System.Drawing.Point(330, 566);
            this.txtGpuSafetyTemp.Minimum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.txtGpuSafetyTemp.Name = "txtGpuSafetyTemp";
            this.txtGpuSafetyTemp.Size = new System.Drawing.Size(45, 28);
            this.txtGpuSafetyTemp.TabIndex = 24;
            this.txtGpuSafetyTemp.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.txtGpuSafetyTemp.ValueChanged += new System.EventHandler(this.txtGpuSafetyTemp_ValueChanged);
            // 
            // lblGpuSafetyTemp2
            // 
            this.lblGpuSafetyTemp2.AutoSize = true;
            this.lblGpuSafetyTemp2.Location = new System.Drawing.Point(373, 568);
            this.lblGpuSafetyTemp2.Name = "lblGpuSafetyTemp2";
            this.lblGpuSafetyTemp2.Size = new System.Drawing.Size(15, 20);
            this.lblGpuSafetyTemp2.TabIndex = 23;
            this.lblGpuSafetyTemp2.Text = "°";
            // 
            // lblGpuSafetyTemp
            // 
            this.lblGpuSafetyTemp.AutoSize = true;
            this.lblGpuSafetyTemp.Location = new System.Drawing.Point(205, 568);
            this.lblGpuSafetyTemp.Name = "lblGpuSafetyTemp";
            this.lblGpuSafetyTemp.Size = new System.Drawing.Size(129, 20);
            this.lblGpuSafetyTemp.TabIndex = 22;
            this.lblGpuSafetyTemp.Text = "GPU safety temp:";
            // 
            // btnGpuBattMonitor
            // 
            this.btnGpuBattMonitor.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnGpuBattMonitor.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGpuBattMonitor.Location = new System.Drawing.Point(284, 599);
            this.btnGpuBattMonitor.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnGpuBattMonitor.Name = "btnGpuBattMonitor";
            this.btnGpuBattMonitor.Size = new System.Drawing.Size(130, 30);
            this.btnGpuBattMonitor.TabIndex = 25;
            this.btnGpuBattMonitor.Text = "GPU Batt. Monitor";
            this.btnGpuBattMonitor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGpuBattMonitor.UseVisualStyleBackColor = true;
            this.btnGpuBattMonitor.CheckedChanged += new System.EventHandler(this.btnGpuBattMonitor_CheckedChanged);
            // 
            // tmrGui
            // 
            this.tmrGui.Enabled = true;
            this.tmrGui.Interval = 1000;
            this.tmrGui.Tick += new System.EventHandler(this.tmrGui_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(609, 657);
            this.Controls.Add(this.btnGpuBattMonitor);
            this.Controls.Add(this.txtGpuSafetyTemp);
            this.Controls.Add(this.lblGpuSafetyTemp2);
            this.Controls.Add(this.lblGpuSafetyTemp);
            this.Controls.Add(this.txtCpuSafetyTemp);
            this.Controls.Add(this.lblCpuSafetyTemp2);
            this.Controls.Add(this.lblCpuSafetyTemp);
            this.Controls.Add(this.btnACFans);
            this.Controls.Add(this.btnAlwaysOnTop);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pnlProfiles);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlFanDuties);
            this.Controls.Add(this.pnlGPUStats);
            this.Controls.Add(this.pnlCPUStats);
            this.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clevo Fan Control";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LocationChanged += new System.EventHandler(this.frmMain_LocationChanged);
            this.mnuMain.ResumeLayout(false);
            this.pnlCPUStats.ResumeLayout(false);
            this.pnlCPUStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgStatIntel)).EndInit();
            this.pnlGPUStats.ResumeLayout(false);
            this.pnlGPUStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgStatNvidia)).EndInit();
            this.pnlFanDuties.ResumeLayout(false);
            this.pnlFanDuties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgStatFan)).EndInit();
            this.prgGPUFanContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.prgGPUFan)).EndInit();
            this.prgCPUFanContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.prgCPUFan)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabFanCurves.ResumeLayout(false);
            this.tabFanCurveCPU.ResumeLayout(false);
            this.tabFanCurveGPU.ResumeLayout(false);
            this.pnlProfiles.ResumeLayout(false);
            this.pnlProfiles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCpuSafetyTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGpuSafetyTemp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCPUHeader;
        private System.Windows.Forms.Label lblCPUTemp;
        private System.Windows.Forms.Timer tmrMain;
        private System.Windows.Forms.Label lblCPUFanHeader;
        private System.Windows.Forms.Label lblCPUFan;
        private System.Windows.Forms.NotifyIcon icoTray;
        private System.Windows.Forms.ContextMenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuShowWindow;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Panel pnlCPUStats;
        private System.Windows.Forms.Panel pnlGPUStats;
        private System.Windows.Forms.Label lblGPUHeader;
        private System.Windows.Forms.Label lblGPUTemp;
        private System.Windows.Forms.Label lblGPUFanHeader;
        private System.Windows.Forms.Label lblGPUFan;
        private System.Windows.Forms.Panel pnlFanDuties;
        private System.Windows.Forms.Label lblFanDutyHeader;
        private System.Windows.Forms.Panel prgCPUFanContainer;
        private System.Windows.Forms.PictureBox prgCPUFan;
        private System.Windows.Forms.Label lblGPUPrgHeader;
        private System.Windows.Forms.Panel prgGPUFanContainer;
        private System.Windows.Forms.PictureBox prgGPUFan;
        private System.Windows.Forms.Label lblCPUPrgHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabFanCurves;
        private System.Windows.Forms.TabPage tabFanCurveCPU;
        private System.Windows.Forms.TabPage tabFanCurveGPU;
        private System.Windows.Forms.Label lblFanCurveHeader;
        private System.Windows.Forms.PictureBox imgStatIntel;
        private System.Windows.Forms.PictureBox imgStatNvidia;
        private System.Windows.Forms.PictureBox imgStatFan;
        private System.Windows.Forms.Panel pnlProfiles;
        private System.Windows.Forms.RadioButton btnProfileManual;
        private System.Windows.Forms.RadioButton btnProfileDefault;
        private System.Windows.Forms.Label lblProfilesHeader;
        private System.Windows.Forms.RadioButton btnProfileMax;
        private System.Windows.Forms.ToolStripSeparator mnuSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuProfileManual;
        private System.Windows.Forms.ToolStripMenuItem mnuProfileDefault;
        private System.Windows.Forms.ToolStripMenuItem mnuProfileMax;
        private System.Windows.Forms.ToolStripSeparator mnuSeparator2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckBox btnAlwaysOnTop;
        private System.Windows.Forms.CheckBox btnACFans;
        private System.Windows.Forms.Label lblCPUMaxTemp;
        private System.Windows.Forms.Label lblGPUMaxTemp;
        private System.Windows.Forms.ToolTip tipTooltip;
        private System.Windows.Forms.Timer tmrHighCpuDelay;
        private System.Windows.Forms.Label lblCpuSafetyTemp;
        private System.Windows.Forms.Label lblCpuSafetyTemp2;
        private System.Windows.Forms.NumericUpDown txtCpuSafetyTemp;
        private System.Windows.Forms.NumericUpDown txtGpuSafetyTemp;
        private System.Windows.Forms.Label lblGpuSafetyTemp2;
        private System.Windows.Forms.Label lblGpuSafetyTemp;
        private System.Windows.Forms.CheckBox btnGpuBattMonitor;
        private System.Windows.Forms.RadioButton btnProfile50;
        private System.Windows.Forms.ToolStripMenuItem mnuProfile50;
        private CurveEditorControl.PlotCanvasContainer cpuPlot;
        private CurveEditorControl.PlotCanvasContainer gpuPlot;
        private System.Windows.Forms.Timer tmrGui;
    }
}

