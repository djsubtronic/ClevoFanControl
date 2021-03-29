
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
            this.mnuProfileMax = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlCPUStats = new System.Windows.Forms.Panel();
            this.imgStatIntel = new System.Windows.Forms.PictureBox();
            this.pnlGPUStats = new System.Windows.Forms.Panel();
            this.imgStatNvidia = new System.Windows.Forms.PictureBox();
            this.lblGPUHeader = new System.Windows.Forms.Label();
            this.lblGPUTemp = new System.Windows.Forms.Label();
            this.lblGPUFanHeader = new System.Windows.Forms.Label();
            this.lblGPUFan = new System.Windows.Forms.Label();
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
            this.lblCPUFan85 = new System.Windows.Forms.Label();
            this.lblCPUFan80 = new System.Windows.Forms.Label();
            this.lblCPUFan75 = new System.Windows.Forms.Label();
            this.lblCPUFan70 = new System.Windows.Forms.Label();
            this.lblCPUFan65 = new System.Windows.Forms.Label();
            this.lblCPUFan60 = new System.Windows.Forms.Label();
            this.lblCPUFan55 = new System.Windows.Forms.Label();
            this.lblCPUFan50 = new System.Windows.Forms.Label();
            this.lblCPUFan45 = new System.Windows.Forms.Label();
            this.lblCPUFan40 = new System.Windows.Forms.Label();
            this.lblIndicatorCPU85 = new System.Windows.Forms.Label();
            this.lblIndicatorCPU80 = new System.Windows.Forms.Label();
            this.lblIndicatorCPU75 = new System.Windows.Forms.Label();
            this.lblIndicatorCPU70 = new System.Windows.Forms.Label();
            this.lblIndicatorCPU65 = new System.Windows.Forms.Label();
            this.lblIndicatorCPU60 = new System.Windows.Forms.Label();
            this.lblIndicatorCPU55 = new System.Windows.Forms.Label();
            this.lblIndicatorCPU50 = new System.Windows.Forms.Label();
            this.lblIndicatorCPU45 = new System.Windows.Forms.Label();
            this.lblIndicatorCPU40 = new System.Windows.Forms.Label();
            this.barCPU85 = new System.Windows.Forms.TrackBar();
            this.barCPU80 = new System.Windows.Forms.TrackBar();
            this.barCPU75 = new System.Windows.Forms.TrackBar();
            this.barCPU70 = new System.Windows.Forms.TrackBar();
            this.barCPU65 = new System.Windows.Forms.TrackBar();
            this.barCPU60 = new System.Windows.Forms.TrackBar();
            this.barCPU55 = new System.Windows.Forms.TrackBar();
            this.barCPU50 = new System.Windows.Forms.TrackBar();
            this.barCPU45 = new System.Windows.Forms.TrackBar();
            this.barCPU40 = new System.Windows.Forms.TrackBar();
            this.tabFanCurveGPU = new System.Windows.Forms.TabPage();
            this.lblGPUFan85 = new System.Windows.Forms.Label();
            this.lblGPUFan80 = new System.Windows.Forms.Label();
            this.lblGPUFan75 = new System.Windows.Forms.Label();
            this.lblGPUFan70 = new System.Windows.Forms.Label();
            this.lblGPUFan65 = new System.Windows.Forms.Label();
            this.lblGPUFan60 = new System.Windows.Forms.Label();
            this.lblGPUFan55 = new System.Windows.Forms.Label();
            this.lblGPUFan50 = new System.Windows.Forms.Label();
            this.lblGPUFan45 = new System.Windows.Forms.Label();
            this.lblGPUFan40 = new System.Windows.Forms.Label();
            this.lblIndicatorGPU85 = new System.Windows.Forms.Label();
            this.lblIndicatorGPU80 = new System.Windows.Forms.Label();
            this.lblIndicatorGPU75 = new System.Windows.Forms.Label();
            this.lblIndicatorGPU70 = new System.Windows.Forms.Label();
            this.lblIndicatorGPU65 = new System.Windows.Forms.Label();
            this.lblIndicatorGPU60 = new System.Windows.Forms.Label();
            this.lblIndicatorGPU55 = new System.Windows.Forms.Label();
            this.lblIndicatorGPU50 = new System.Windows.Forms.Label();
            this.lblIndicatorGPU45 = new System.Windows.Forms.Label();
            this.lblIndicatorGPU40 = new System.Windows.Forms.Label();
            this.barGPU85 = new System.Windows.Forms.TrackBar();
            this.barGPU80 = new System.Windows.Forms.TrackBar();
            this.barGPU75 = new System.Windows.Forms.TrackBar();
            this.barGPU70 = new System.Windows.Forms.TrackBar();
            this.barGPU65 = new System.Windows.Forms.TrackBar();
            this.barGPU60 = new System.Windows.Forms.TrackBar();
            this.barGPU55 = new System.Windows.Forms.TrackBar();
            this.barGPU50 = new System.Windows.Forms.TrackBar();
            this.barGPU45 = new System.Windows.Forms.TrackBar();
            this.barGPU40 = new System.Windows.Forms.TrackBar();
            this.lblFanCurveHeader = new System.Windows.Forms.Label();
            this.pnlProfiles = new System.Windows.Forms.Panel();
            this.btnProfileMax = new System.Windows.Forms.RadioButton();
            this.btnProfileManual = new System.Windows.Forms.RadioButton();
            this.btnProfileDefault = new System.Windows.Forms.RadioButton();
            this.lblProfilesHeader = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAlwaysOnTop = new System.Windows.Forms.CheckBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.barCPU85)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barCPU80)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barCPU75)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barCPU70)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barCPU65)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barCPU60)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barCPU55)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barCPU50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barCPU45)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barCPU40)).BeginInit();
            this.tabFanCurveGPU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barGPU85)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barGPU80)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barGPU75)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barGPU70)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barGPU65)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barGPU60)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barGPU55)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barGPU50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barGPU45)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barGPU40)).BeginInit();
            this.pnlProfiles.SuspendLayout();
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
            this.lblCPUTemp.Font = new System.Drawing.Font("Open Sans", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPUTemp.ForeColor = System.Drawing.Color.Black;
            this.lblCPUTemp.Location = new System.Drawing.Point(6, 41);
            this.lblCPUTemp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCPUTemp.Name = "lblCPUTemp";
            this.lblCPUTemp.Size = new System.Drawing.Size(122, 45);
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
            this.mnuProfileMax,
            this.mnuSeparator2,
            this.mnuAbout,
            this.mnuExit});
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(183, 148);
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
            this.pnlCPUStats.Controls.Add(this.imgStatIntel);
            this.pnlCPUStats.Controls.Add(this.lblCPUHeader);
            this.pnlCPUStats.Controls.Add(this.lblCPUTemp);
            this.pnlCPUStats.Controls.Add(this.lblCPUFanHeader);
            this.pnlCPUStats.Controls.Add(this.lblCPUFan);
            this.pnlCPUStats.Location = new System.Drawing.Point(12, 12);
            this.pnlCPUStats.Name = "pnlCPUStats";
            this.pnlCPUStats.Size = new System.Drawing.Size(135, 130);
            this.pnlCPUStats.TabIndex = 11;
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
            this.pnlGPUStats.Controls.Add(this.imgStatNvidia);
            this.pnlGPUStats.Controls.Add(this.lblGPUHeader);
            this.pnlGPUStats.Controls.Add(this.lblGPUTemp);
            this.pnlGPUStats.Controls.Add(this.lblGPUFanHeader);
            this.pnlGPUStats.Controls.Add(this.lblGPUFan);
            this.pnlGPUStats.Location = new System.Drawing.Point(153, 12);
            this.pnlGPUStats.Name = "pnlGPUStats";
            this.pnlGPUStats.Size = new System.Drawing.Size(135, 130);
            this.pnlGPUStats.TabIndex = 12;
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
            // lblGPUTemp
            // 
            this.lblGPUTemp.Font = new System.Drawing.Font("Open Sans", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPUTemp.ForeColor = System.Drawing.Color.Black;
            this.lblGPUTemp.Location = new System.Drawing.Point(6, 41);
            this.lblGPUTemp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGPUTemp.Name = "lblGPUTemp";
            this.lblGPUTemp.Size = new System.Drawing.Size(122, 45);
            this.lblGPUTemp.TabIndex = 2;
            this.lblGPUTemp.Text = "0";
            this.lblGPUTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.tabFanCurveCPU.Controls.Add(this.lblCPUFan85);
            this.tabFanCurveCPU.Controls.Add(this.lblCPUFan80);
            this.tabFanCurveCPU.Controls.Add(this.lblCPUFan75);
            this.tabFanCurveCPU.Controls.Add(this.lblCPUFan70);
            this.tabFanCurveCPU.Controls.Add(this.lblCPUFan65);
            this.tabFanCurveCPU.Controls.Add(this.lblCPUFan60);
            this.tabFanCurveCPU.Controls.Add(this.lblCPUFan55);
            this.tabFanCurveCPU.Controls.Add(this.lblCPUFan50);
            this.tabFanCurveCPU.Controls.Add(this.lblCPUFan45);
            this.tabFanCurveCPU.Controls.Add(this.lblCPUFan40);
            this.tabFanCurveCPU.Controls.Add(this.lblIndicatorCPU85);
            this.tabFanCurveCPU.Controls.Add(this.lblIndicatorCPU80);
            this.tabFanCurveCPU.Controls.Add(this.lblIndicatorCPU75);
            this.tabFanCurveCPU.Controls.Add(this.lblIndicatorCPU70);
            this.tabFanCurveCPU.Controls.Add(this.lblIndicatorCPU65);
            this.tabFanCurveCPU.Controls.Add(this.lblIndicatorCPU60);
            this.tabFanCurveCPU.Controls.Add(this.lblIndicatorCPU55);
            this.tabFanCurveCPU.Controls.Add(this.lblIndicatorCPU50);
            this.tabFanCurveCPU.Controls.Add(this.lblIndicatorCPU45);
            this.tabFanCurveCPU.Controls.Add(this.lblIndicatorCPU40);
            this.tabFanCurveCPU.Controls.Add(this.barCPU85);
            this.tabFanCurveCPU.Controls.Add(this.barCPU80);
            this.tabFanCurveCPU.Controls.Add(this.barCPU75);
            this.tabFanCurveCPU.Controls.Add(this.barCPU70);
            this.tabFanCurveCPU.Controls.Add(this.barCPU65);
            this.tabFanCurveCPU.Controls.Add(this.barCPU60);
            this.tabFanCurveCPU.Controls.Add(this.barCPU55);
            this.tabFanCurveCPU.Controls.Add(this.barCPU50);
            this.tabFanCurveCPU.Controls.Add(this.barCPU45);
            this.tabFanCurveCPU.Controls.Add(this.barCPU40);
            this.tabFanCurveCPU.Location = new System.Drawing.Point(4, 29);
            this.tabFanCurveCPU.Name = "tabFanCurveCPU";
            this.tabFanCurveCPU.Padding = new System.Windows.Forms.Padding(3);
            this.tabFanCurveCPU.Size = new System.Drawing.Size(565, 284);
            this.tabFanCurveCPU.TabIndex = 0;
            this.tabFanCurveCPU.Text = "CPU";
            // 
            // lblCPUFan85
            // 
            this.lblCPUFan85.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPUFan85.ForeColor = System.Drawing.Color.Black;
            this.lblCPUFan85.Location = new System.Drawing.Point(491, 17);
            this.lblCPUFan85.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCPUFan85.Name = "lblCPUFan85";
            this.lblCPUFan85.Size = new System.Drawing.Size(45, 20);
            this.lblCPUFan85.TabIndex = 29;
            this.lblCPUFan85.Text = "0";
            this.lblCPUFan85.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCPUFan80
            // 
            this.lblCPUFan80.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPUFan80.ForeColor = System.Drawing.Color.Black;
            this.lblCPUFan80.Location = new System.Drawing.Point(440, 17);
            this.lblCPUFan80.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCPUFan80.Name = "lblCPUFan80";
            this.lblCPUFan80.Size = new System.Drawing.Size(45, 20);
            this.lblCPUFan80.TabIndex = 28;
            this.lblCPUFan80.Text = "0";
            this.lblCPUFan80.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCPUFan75
            // 
            this.lblCPUFan75.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPUFan75.ForeColor = System.Drawing.Color.Black;
            this.lblCPUFan75.Location = new System.Drawing.Point(389, 17);
            this.lblCPUFan75.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCPUFan75.Name = "lblCPUFan75";
            this.lblCPUFan75.Size = new System.Drawing.Size(45, 20);
            this.lblCPUFan75.TabIndex = 27;
            this.lblCPUFan75.Text = "0";
            this.lblCPUFan75.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCPUFan70
            // 
            this.lblCPUFan70.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPUFan70.ForeColor = System.Drawing.Color.Black;
            this.lblCPUFan70.Location = new System.Drawing.Point(338, 17);
            this.lblCPUFan70.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCPUFan70.Name = "lblCPUFan70";
            this.lblCPUFan70.Size = new System.Drawing.Size(45, 20);
            this.lblCPUFan70.TabIndex = 26;
            this.lblCPUFan70.Text = "0";
            this.lblCPUFan70.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCPUFan65
            // 
            this.lblCPUFan65.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPUFan65.ForeColor = System.Drawing.Color.Black;
            this.lblCPUFan65.Location = new System.Drawing.Point(287, 17);
            this.lblCPUFan65.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCPUFan65.Name = "lblCPUFan65";
            this.lblCPUFan65.Size = new System.Drawing.Size(45, 20);
            this.lblCPUFan65.TabIndex = 25;
            this.lblCPUFan65.Text = "0";
            this.lblCPUFan65.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCPUFan60
            // 
            this.lblCPUFan60.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPUFan60.ForeColor = System.Drawing.Color.Black;
            this.lblCPUFan60.Location = new System.Drawing.Point(236, 17);
            this.lblCPUFan60.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCPUFan60.Name = "lblCPUFan60";
            this.lblCPUFan60.Size = new System.Drawing.Size(45, 20);
            this.lblCPUFan60.TabIndex = 24;
            this.lblCPUFan60.Text = "0";
            this.lblCPUFan60.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCPUFan55
            // 
            this.lblCPUFan55.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPUFan55.ForeColor = System.Drawing.Color.Black;
            this.lblCPUFan55.Location = new System.Drawing.Point(185, 17);
            this.lblCPUFan55.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCPUFan55.Name = "lblCPUFan55";
            this.lblCPUFan55.Size = new System.Drawing.Size(45, 20);
            this.lblCPUFan55.TabIndex = 23;
            this.lblCPUFan55.Text = "0";
            this.lblCPUFan55.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCPUFan50
            // 
            this.lblCPUFan50.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPUFan50.ForeColor = System.Drawing.Color.Black;
            this.lblCPUFan50.Location = new System.Drawing.Point(134, 17);
            this.lblCPUFan50.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCPUFan50.Name = "lblCPUFan50";
            this.lblCPUFan50.Size = new System.Drawing.Size(45, 20);
            this.lblCPUFan50.TabIndex = 22;
            this.lblCPUFan50.Text = "0";
            this.lblCPUFan50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCPUFan45
            // 
            this.lblCPUFan45.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPUFan45.ForeColor = System.Drawing.Color.Black;
            this.lblCPUFan45.Location = new System.Drawing.Point(79, 17);
            this.lblCPUFan45.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCPUFan45.Name = "lblCPUFan45";
            this.lblCPUFan45.Size = new System.Drawing.Size(45, 20);
            this.lblCPUFan45.TabIndex = 21;
            this.lblCPUFan45.Text = "0";
            this.lblCPUFan45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCPUFan40
            // 
            this.lblCPUFan40.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPUFan40.ForeColor = System.Drawing.Color.Black;
            this.lblCPUFan40.Location = new System.Drawing.Point(27, 17);
            this.lblCPUFan40.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCPUFan40.Name = "lblCPUFan40";
            this.lblCPUFan40.Size = new System.Drawing.Size(45, 20);
            this.lblCPUFan40.TabIndex = 20;
            this.lblCPUFan40.Text = "0";
            this.lblCPUFan40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIndicatorCPU85
            // 
            this.lblIndicatorCPU85.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicatorCPU85.ForeColor = System.Drawing.Color.Black;
            this.lblIndicatorCPU85.Location = new System.Drawing.Point(491, 243);
            this.lblIndicatorCPU85.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIndicatorCPU85.Name = "lblIndicatorCPU85";
            this.lblIndicatorCPU85.Size = new System.Drawing.Size(45, 20);
            this.lblIndicatorCPU85.TabIndex = 19;
            this.lblIndicatorCPU85.Text = "85°";
            this.lblIndicatorCPU85.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIndicatorCPU80
            // 
            this.lblIndicatorCPU80.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicatorCPU80.ForeColor = System.Drawing.Color.Black;
            this.lblIndicatorCPU80.Location = new System.Drawing.Point(440, 243);
            this.lblIndicatorCPU80.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIndicatorCPU80.Name = "lblIndicatorCPU80";
            this.lblIndicatorCPU80.Size = new System.Drawing.Size(45, 20);
            this.lblIndicatorCPU80.TabIndex = 18;
            this.lblIndicatorCPU80.Text = "80°";
            this.lblIndicatorCPU80.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIndicatorCPU75
            // 
            this.lblIndicatorCPU75.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicatorCPU75.ForeColor = System.Drawing.Color.Black;
            this.lblIndicatorCPU75.Location = new System.Drawing.Point(389, 243);
            this.lblIndicatorCPU75.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIndicatorCPU75.Name = "lblIndicatorCPU75";
            this.lblIndicatorCPU75.Size = new System.Drawing.Size(45, 20);
            this.lblIndicatorCPU75.TabIndex = 17;
            this.lblIndicatorCPU75.Text = "75°";
            this.lblIndicatorCPU75.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIndicatorCPU70
            // 
            this.lblIndicatorCPU70.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicatorCPU70.ForeColor = System.Drawing.Color.Black;
            this.lblIndicatorCPU70.Location = new System.Drawing.Point(338, 243);
            this.lblIndicatorCPU70.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIndicatorCPU70.Name = "lblIndicatorCPU70";
            this.lblIndicatorCPU70.Size = new System.Drawing.Size(45, 20);
            this.lblIndicatorCPU70.TabIndex = 16;
            this.lblIndicatorCPU70.Text = "70°";
            this.lblIndicatorCPU70.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIndicatorCPU65
            // 
            this.lblIndicatorCPU65.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicatorCPU65.ForeColor = System.Drawing.Color.Black;
            this.lblIndicatorCPU65.Location = new System.Drawing.Point(287, 243);
            this.lblIndicatorCPU65.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIndicatorCPU65.Name = "lblIndicatorCPU65";
            this.lblIndicatorCPU65.Size = new System.Drawing.Size(45, 20);
            this.lblIndicatorCPU65.TabIndex = 15;
            this.lblIndicatorCPU65.Text = "65°";
            this.lblIndicatorCPU65.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIndicatorCPU60
            // 
            this.lblIndicatorCPU60.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicatorCPU60.ForeColor = System.Drawing.Color.Black;
            this.lblIndicatorCPU60.Location = new System.Drawing.Point(236, 243);
            this.lblIndicatorCPU60.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIndicatorCPU60.Name = "lblIndicatorCPU60";
            this.lblIndicatorCPU60.Size = new System.Drawing.Size(45, 20);
            this.lblIndicatorCPU60.TabIndex = 14;
            this.lblIndicatorCPU60.Text = "60°";
            this.lblIndicatorCPU60.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIndicatorCPU55
            // 
            this.lblIndicatorCPU55.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicatorCPU55.ForeColor = System.Drawing.Color.Black;
            this.lblIndicatorCPU55.Location = new System.Drawing.Point(185, 243);
            this.lblIndicatorCPU55.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIndicatorCPU55.Name = "lblIndicatorCPU55";
            this.lblIndicatorCPU55.Size = new System.Drawing.Size(45, 20);
            this.lblIndicatorCPU55.TabIndex = 13;
            this.lblIndicatorCPU55.Text = "55°";
            this.lblIndicatorCPU55.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIndicatorCPU50
            // 
            this.lblIndicatorCPU50.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicatorCPU50.ForeColor = System.Drawing.Color.Black;
            this.lblIndicatorCPU50.Location = new System.Drawing.Point(134, 243);
            this.lblIndicatorCPU50.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIndicatorCPU50.Name = "lblIndicatorCPU50";
            this.lblIndicatorCPU50.Size = new System.Drawing.Size(45, 20);
            this.lblIndicatorCPU50.TabIndex = 12;
            this.lblIndicatorCPU50.Text = "50°";
            this.lblIndicatorCPU50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIndicatorCPU45
            // 
            this.lblIndicatorCPU45.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicatorCPU45.ForeColor = System.Drawing.Color.Black;
            this.lblIndicatorCPU45.Location = new System.Drawing.Point(79, 243);
            this.lblIndicatorCPU45.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIndicatorCPU45.Name = "lblIndicatorCPU45";
            this.lblIndicatorCPU45.Size = new System.Drawing.Size(45, 20);
            this.lblIndicatorCPU45.TabIndex = 11;
            this.lblIndicatorCPU45.Text = "45°";
            this.lblIndicatorCPU45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIndicatorCPU40
            // 
            this.lblIndicatorCPU40.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicatorCPU40.ForeColor = System.Drawing.Color.Black;
            this.lblIndicatorCPU40.Location = new System.Drawing.Point(27, 243);
            this.lblIndicatorCPU40.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIndicatorCPU40.Name = "lblIndicatorCPU40";
            this.lblIndicatorCPU40.Size = new System.Drawing.Size(45, 20);
            this.lblIndicatorCPU40.TabIndex = 8;
            this.lblIndicatorCPU40.Text = "40°";
            this.lblIndicatorCPU40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // barCPU85
            // 
            this.barCPU85.Location = new System.Drawing.Point(493, 40);
            this.barCPU85.Maximum = 100;
            this.barCPU85.Name = "barCPU85";
            this.barCPU85.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.barCPU85.Size = new System.Drawing.Size(45, 200);
            this.barCPU85.TabIndex = 10;
            this.barCPU85.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.barCPU85.Scroll += new System.EventHandler(this.cpuBarChanged);
            // 
            // barCPU80
            // 
            this.barCPU80.Location = new System.Drawing.Point(442, 40);
            this.barCPU80.Maximum = 100;
            this.barCPU80.Name = "barCPU80";
            this.barCPU80.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.barCPU80.Size = new System.Drawing.Size(45, 200);
            this.barCPU80.TabIndex = 9;
            this.barCPU80.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.barCPU80.Scroll += new System.EventHandler(this.cpuBarChanged);
            // 
            // barCPU75
            // 
            this.barCPU75.Location = new System.Drawing.Point(391, 40);
            this.barCPU75.Maximum = 100;
            this.barCPU75.Name = "barCPU75";
            this.barCPU75.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.barCPU75.Size = new System.Drawing.Size(45, 200);
            this.barCPU75.TabIndex = 8;
            this.barCPU75.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.barCPU75.Scroll += new System.EventHandler(this.cpuBarChanged);
            // 
            // barCPU70
            // 
            this.barCPU70.Location = new System.Drawing.Point(340, 40);
            this.barCPU70.Maximum = 100;
            this.barCPU70.Name = "barCPU70";
            this.barCPU70.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.barCPU70.Size = new System.Drawing.Size(45, 200);
            this.barCPU70.TabIndex = 7;
            this.barCPU70.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.barCPU70.Scroll += new System.EventHandler(this.cpuBarChanged);
            // 
            // barCPU65
            // 
            this.barCPU65.Location = new System.Drawing.Point(289, 40);
            this.barCPU65.Maximum = 100;
            this.barCPU65.Name = "barCPU65";
            this.barCPU65.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.barCPU65.Size = new System.Drawing.Size(45, 200);
            this.barCPU65.TabIndex = 6;
            this.barCPU65.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.barCPU65.Scroll += new System.EventHandler(this.cpuBarChanged);
            // 
            // barCPU60
            // 
            this.barCPU60.Location = new System.Drawing.Point(238, 40);
            this.barCPU60.Maximum = 100;
            this.barCPU60.Name = "barCPU60";
            this.barCPU60.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.barCPU60.Size = new System.Drawing.Size(45, 200);
            this.barCPU60.TabIndex = 5;
            this.barCPU60.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.barCPU60.Scroll += new System.EventHandler(this.cpuBarChanged);
            // 
            // barCPU55
            // 
            this.barCPU55.Location = new System.Drawing.Point(187, 40);
            this.barCPU55.Maximum = 100;
            this.barCPU55.Name = "barCPU55";
            this.barCPU55.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.barCPU55.Size = new System.Drawing.Size(45, 200);
            this.barCPU55.TabIndex = 4;
            this.barCPU55.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.barCPU55.Scroll += new System.EventHandler(this.cpuBarChanged);
            // 
            // barCPU50
            // 
            this.barCPU50.Location = new System.Drawing.Point(136, 40);
            this.barCPU50.Maximum = 100;
            this.barCPU50.Name = "barCPU50";
            this.barCPU50.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.barCPU50.Size = new System.Drawing.Size(45, 200);
            this.barCPU50.TabIndex = 3;
            this.barCPU50.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.barCPU50.Scroll += new System.EventHandler(this.cpuBarChanged);
            // 
            // barCPU45
            // 
            this.barCPU45.Location = new System.Drawing.Point(81, 40);
            this.barCPU45.Maximum = 100;
            this.barCPU45.Name = "barCPU45";
            this.barCPU45.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.barCPU45.Size = new System.Drawing.Size(45, 200);
            this.barCPU45.TabIndex = 2;
            this.barCPU45.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.barCPU45.Scroll += new System.EventHandler(this.cpuBarChanged);
            // 
            // barCPU40
            // 
            this.barCPU40.Location = new System.Drawing.Point(27, 40);
            this.barCPU40.Maximum = 100;
            this.barCPU40.Name = "barCPU40";
            this.barCPU40.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.barCPU40.Size = new System.Drawing.Size(45, 200);
            this.barCPU40.TabIndex = 1;
            this.barCPU40.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.barCPU40.Scroll += new System.EventHandler(this.cpuBarChanged);
            // 
            // tabFanCurveGPU
            // 
            this.tabFanCurveGPU.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabFanCurveGPU.Controls.Add(this.lblGPUFan85);
            this.tabFanCurveGPU.Controls.Add(this.lblGPUFan80);
            this.tabFanCurveGPU.Controls.Add(this.lblGPUFan75);
            this.tabFanCurveGPU.Controls.Add(this.lblGPUFan70);
            this.tabFanCurveGPU.Controls.Add(this.lblGPUFan65);
            this.tabFanCurveGPU.Controls.Add(this.lblGPUFan60);
            this.tabFanCurveGPU.Controls.Add(this.lblGPUFan55);
            this.tabFanCurveGPU.Controls.Add(this.lblGPUFan50);
            this.tabFanCurveGPU.Controls.Add(this.lblGPUFan45);
            this.tabFanCurveGPU.Controls.Add(this.lblGPUFan40);
            this.tabFanCurveGPU.Controls.Add(this.lblIndicatorGPU85);
            this.tabFanCurveGPU.Controls.Add(this.lblIndicatorGPU80);
            this.tabFanCurveGPU.Controls.Add(this.lblIndicatorGPU75);
            this.tabFanCurveGPU.Controls.Add(this.lblIndicatorGPU70);
            this.tabFanCurveGPU.Controls.Add(this.lblIndicatorGPU65);
            this.tabFanCurveGPU.Controls.Add(this.lblIndicatorGPU60);
            this.tabFanCurveGPU.Controls.Add(this.lblIndicatorGPU55);
            this.tabFanCurveGPU.Controls.Add(this.lblIndicatorGPU50);
            this.tabFanCurveGPU.Controls.Add(this.lblIndicatorGPU45);
            this.tabFanCurveGPU.Controls.Add(this.lblIndicatorGPU40);
            this.tabFanCurveGPU.Controls.Add(this.barGPU85);
            this.tabFanCurveGPU.Controls.Add(this.barGPU80);
            this.tabFanCurveGPU.Controls.Add(this.barGPU75);
            this.tabFanCurveGPU.Controls.Add(this.barGPU70);
            this.tabFanCurveGPU.Controls.Add(this.barGPU65);
            this.tabFanCurveGPU.Controls.Add(this.barGPU60);
            this.tabFanCurveGPU.Controls.Add(this.barGPU55);
            this.tabFanCurveGPU.Controls.Add(this.barGPU50);
            this.tabFanCurveGPU.Controls.Add(this.barGPU45);
            this.tabFanCurveGPU.Controls.Add(this.barGPU40);
            this.tabFanCurveGPU.Location = new System.Drawing.Point(4, 29);
            this.tabFanCurveGPU.Name = "tabFanCurveGPU";
            this.tabFanCurveGPU.Padding = new System.Windows.Forms.Padding(3);
            this.tabFanCurveGPU.Size = new System.Drawing.Size(565, 284);
            this.tabFanCurveGPU.TabIndex = 1;
            this.tabFanCurveGPU.Text = "GPU";
            // 
            // lblGPUFan85
            // 
            this.lblGPUFan85.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPUFan85.ForeColor = System.Drawing.Color.Black;
            this.lblGPUFan85.Location = new System.Drawing.Point(491, 17);
            this.lblGPUFan85.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGPUFan85.Name = "lblGPUFan85";
            this.lblGPUFan85.Size = new System.Drawing.Size(45, 20);
            this.lblGPUFan85.TabIndex = 59;
            this.lblGPUFan85.Text = "0";
            this.lblGPUFan85.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGPUFan80
            // 
            this.lblGPUFan80.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPUFan80.ForeColor = System.Drawing.Color.Black;
            this.lblGPUFan80.Location = new System.Drawing.Point(440, 17);
            this.lblGPUFan80.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGPUFan80.Name = "lblGPUFan80";
            this.lblGPUFan80.Size = new System.Drawing.Size(45, 20);
            this.lblGPUFan80.TabIndex = 58;
            this.lblGPUFan80.Text = "0";
            this.lblGPUFan80.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGPUFan75
            // 
            this.lblGPUFan75.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPUFan75.ForeColor = System.Drawing.Color.Black;
            this.lblGPUFan75.Location = new System.Drawing.Point(389, 17);
            this.lblGPUFan75.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGPUFan75.Name = "lblGPUFan75";
            this.lblGPUFan75.Size = new System.Drawing.Size(45, 20);
            this.lblGPUFan75.TabIndex = 57;
            this.lblGPUFan75.Text = "0";
            this.lblGPUFan75.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGPUFan70
            // 
            this.lblGPUFan70.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPUFan70.ForeColor = System.Drawing.Color.Black;
            this.lblGPUFan70.Location = new System.Drawing.Point(338, 17);
            this.lblGPUFan70.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGPUFan70.Name = "lblGPUFan70";
            this.lblGPUFan70.Size = new System.Drawing.Size(45, 20);
            this.lblGPUFan70.TabIndex = 56;
            this.lblGPUFan70.Text = "0";
            this.lblGPUFan70.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGPUFan65
            // 
            this.lblGPUFan65.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPUFan65.ForeColor = System.Drawing.Color.Black;
            this.lblGPUFan65.Location = new System.Drawing.Point(287, 17);
            this.lblGPUFan65.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGPUFan65.Name = "lblGPUFan65";
            this.lblGPUFan65.Size = new System.Drawing.Size(45, 20);
            this.lblGPUFan65.TabIndex = 55;
            this.lblGPUFan65.Text = "0";
            this.lblGPUFan65.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGPUFan60
            // 
            this.lblGPUFan60.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPUFan60.ForeColor = System.Drawing.Color.Black;
            this.lblGPUFan60.Location = new System.Drawing.Point(236, 17);
            this.lblGPUFan60.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGPUFan60.Name = "lblGPUFan60";
            this.lblGPUFan60.Size = new System.Drawing.Size(45, 20);
            this.lblGPUFan60.TabIndex = 54;
            this.lblGPUFan60.Text = "0";
            this.lblGPUFan60.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGPUFan55
            // 
            this.lblGPUFan55.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPUFan55.ForeColor = System.Drawing.Color.Black;
            this.lblGPUFan55.Location = new System.Drawing.Point(185, 17);
            this.lblGPUFan55.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGPUFan55.Name = "lblGPUFan55";
            this.lblGPUFan55.Size = new System.Drawing.Size(45, 20);
            this.lblGPUFan55.TabIndex = 53;
            this.lblGPUFan55.Text = "0";
            this.lblGPUFan55.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGPUFan50
            // 
            this.lblGPUFan50.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPUFan50.ForeColor = System.Drawing.Color.Black;
            this.lblGPUFan50.Location = new System.Drawing.Point(134, 17);
            this.lblGPUFan50.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGPUFan50.Name = "lblGPUFan50";
            this.lblGPUFan50.Size = new System.Drawing.Size(45, 20);
            this.lblGPUFan50.TabIndex = 52;
            this.lblGPUFan50.Text = "0";
            this.lblGPUFan50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGPUFan45
            // 
            this.lblGPUFan45.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPUFan45.ForeColor = System.Drawing.Color.Black;
            this.lblGPUFan45.Location = new System.Drawing.Point(79, 17);
            this.lblGPUFan45.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGPUFan45.Name = "lblGPUFan45";
            this.lblGPUFan45.Size = new System.Drawing.Size(45, 20);
            this.lblGPUFan45.TabIndex = 51;
            this.lblGPUFan45.Text = "0";
            this.lblGPUFan45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGPUFan40
            // 
            this.lblGPUFan40.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPUFan40.ForeColor = System.Drawing.Color.Black;
            this.lblGPUFan40.Location = new System.Drawing.Point(27, 17);
            this.lblGPUFan40.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGPUFan40.Name = "lblGPUFan40";
            this.lblGPUFan40.Size = new System.Drawing.Size(45, 20);
            this.lblGPUFan40.TabIndex = 50;
            this.lblGPUFan40.Text = "0";
            this.lblGPUFan40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIndicatorGPU85
            // 
            this.lblIndicatorGPU85.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicatorGPU85.ForeColor = System.Drawing.Color.Black;
            this.lblIndicatorGPU85.Location = new System.Drawing.Point(491, 243);
            this.lblIndicatorGPU85.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIndicatorGPU85.Name = "lblIndicatorGPU85";
            this.lblIndicatorGPU85.Size = new System.Drawing.Size(45, 20);
            this.lblIndicatorGPU85.TabIndex = 49;
            this.lblIndicatorGPU85.Text = "85°";
            this.lblIndicatorGPU85.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIndicatorGPU80
            // 
            this.lblIndicatorGPU80.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicatorGPU80.ForeColor = System.Drawing.Color.Black;
            this.lblIndicatorGPU80.Location = new System.Drawing.Point(440, 243);
            this.lblIndicatorGPU80.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIndicatorGPU80.Name = "lblIndicatorGPU80";
            this.lblIndicatorGPU80.Size = new System.Drawing.Size(45, 20);
            this.lblIndicatorGPU80.TabIndex = 48;
            this.lblIndicatorGPU80.Text = "80°";
            this.lblIndicatorGPU80.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIndicatorGPU75
            // 
            this.lblIndicatorGPU75.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicatorGPU75.ForeColor = System.Drawing.Color.Black;
            this.lblIndicatorGPU75.Location = new System.Drawing.Point(389, 243);
            this.lblIndicatorGPU75.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIndicatorGPU75.Name = "lblIndicatorGPU75";
            this.lblIndicatorGPU75.Size = new System.Drawing.Size(45, 20);
            this.lblIndicatorGPU75.TabIndex = 47;
            this.lblIndicatorGPU75.Text = "75°";
            this.lblIndicatorGPU75.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIndicatorGPU70
            // 
            this.lblIndicatorGPU70.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicatorGPU70.ForeColor = System.Drawing.Color.Black;
            this.lblIndicatorGPU70.Location = new System.Drawing.Point(338, 243);
            this.lblIndicatorGPU70.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIndicatorGPU70.Name = "lblIndicatorGPU70";
            this.lblIndicatorGPU70.Size = new System.Drawing.Size(45, 20);
            this.lblIndicatorGPU70.TabIndex = 46;
            this.lblIndicatorGPU70.Text = "70°";
            this.lblIndicatorGPU70.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIndicatorGPU65
            // 
            this.lblIndicatorGPU65.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicatorGPU65.ForeColor = System.Drawing.Color.Black;
            this.lblIndicatorGPU65.Location = new System.Drawing.Point(287, 243);
            this.lblIndicatorGPU65.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIndicatorGPU65.Name = "lblIndicatorGPU65";
            this.lblIndicatorGPU65.Size = new System.Drawing.Size(45, 20);
            this.lblIndicatorGPU65.TabIndex = 45;
            this.lblIndicatorGPU65.Text = "65°";
            this.lblIndicatorGPU65.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIndicatorGPU60
            // 
            this.lblIndicatorGPU60.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicatorGPU60.ForeColor = System.Drawing.Color.Black;
            this.lblIndicatorGPU60.Location = new System.Drawing.Point(236, 243);
            this.lblIndicatorGPU60.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIndicatorGPU60.Name = "lblIndicatorGPU60";
            this.lblIndicatorGPU60.Size = new System.Drawing.Size(45, 20);
            this.lblIndicatorGPU60.TabIndex = 44;
            this.lblIndicatorGPU60.Text = "60°";
            this.lblIndicatorGPU60.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIndicatorGPU55
            // 
            this.lblIndicatorGPU55.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicatorGPU55.ForeColor = System.Drawing.Color.Black;
            this.lblIndicatorGPU55.Location = new System.Drawing.Point(185, 243);
            this.lblIndicatorGPU55.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIndicatorGPU55.Name = "lblIndicatorGPU55";
            this.lblIndicatorGPU55.Size = new System.Drawing.Size(45, 20);
            this.lblIndicatorGPU55.TabIndex = 43;
            this.lblIndicatorGPU55.Text = "55°";
            this.lblIndicatorGPU55.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIndicatorGPU50
            // 
            this.lblIndicatorGPU50.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicatorGPU50.ForeColor = System.Drawing.Color.Black;
            this.lblIndicatorGPU50.Location = new System.Drawing.Point(134, 243);
            this.lblIndicatorGPU50.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIndicatorGPU50.Name = "lblIndicatorGPU50";
            this.lblIndicatorGPU50.Size = new System.Drawing.Size(45, 20);
            this.lblIndicatorGPU50.TabIndex = 42;
            this.lblIndicatorGPU50.Text = "50°";
            this.lblIndicatorGPU50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIndicatorGPU45
            // 
            this.lblIndicatorGPU45.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicatorGPU45.ForeColor = System.Drawing.Color.Black;
            this.lblIndicatorGPU45.Location = new System.Drawing.Point(79, 243);
            this.lblIndicatorGPU45.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIndicatorGPU45.Name = "lblIndicatorGPU45";
            this.lblIndicatorGPU45.Size = new System.Drawing.Size(45, 20);
            this.lblIndicatorGPU45.TabIndex = 41;
            this.lblIndicatorGPU45.Text = "45°";
            this.lblIndicatorGPU45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIndicatorGPU40
            // 
            this.lblIndicatorGPU40.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicatorGPU40.ForeColor = System.Drawing.Color.Black;
            this.lblIndicatorGPU40.Location = new System.Drawing.Point(27, 243);
            this.lblIndicatorGPU40.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIndicatorGPU40.Name = "lblIndicatorGPU40";
            this.lblIndicatorGPU40.Size = new System.Drawing.Size(45, 20);
            this.lblIndicatorGPU40.TabIndex = 38;
            this.lblIndicatorGPU40.Text = "40°";
            this.lblIndicatorGPU40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // barGPU85
            // 
            this.barGPU85.Location = new System.Drawing.Point(493, 40);
            this.barGPU85.Maximum = 100;
            this.barGPU85.Name = "barGPU85";
            this.barGPU85.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.barGPU85.Size = new System.Drawing.Size(45, 200);
            this.barGPU85.TabIndex = 40;
            this.barGPU85.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.barGPU85.Scroll += new System.EventHandler(this.gpuBarChanged);
            // 
            // barGPU80
            // 
            this.barGPU80.Location = new System.Drawing.Point(442, 40);
            this.barGPU80.Maximum = 100;
            this.barGPU80.Name = "barGPU80";
            this.barGPU80.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.barGPU80.Size = new System.Drawing.Size(45, 200);
            this.barGPU80.TabIndex = 39;
            this.barGPU80.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.barGPU80.Scroll += new System.EventHandler(this.gpuBarChanged);
            // 
            // barGPU75
            // 
            this.barGPU75.Location = new System.Drawing.Point(391, 40);
            this.barGPU75.Maximum = 100;
            this.barGPU75.Name = "barGPU75";
            this.barGPU75.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.barGPU75.Size = new System.Drawing.Size(45, 200);
            this.barGPU75.TabIndex = 37;
            this.barGPU75.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.barGPU75.Scroll += new System.EventHandler(this.gpuBarChanged);
            // 
            // barGPU70
            // 
            this.barGPU70.Location = new System.Drawing.Point(340, 40);
            this.barGPU70.Maximum = 100;
            this.barGPU70.Name = "barGPU70";
            this.barGPU70.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.barGPU70.Size = new System.Drawing.Size(45, 200);
            this.barGPU70.TabIndex = 36;
            this.barGPU70.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.barGPU70.Scroll += new System.EventHandler(this.gpuBarChanged);
            // 
            // barGPU65
            // 
            this.barGPU65.Location = new System.Drawing.Point(289, 40);
            this.barGPU65.Maximum = 100;
            this.barGPU65.Name = "barGPU65";
            this.barGPU65.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.barGPU65.Size = new System.Drawing.Size(45, 200);
            this.barGPU65.TabIndex = 35;
            this.barGPU65.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.barGPU65.Scroll += new System.EventHandler(this.gpuBarChanged);
            // 
            // barGPU60
            // 
            this.barGPU60.Location = new System.Drawing.Point(238, 40);
            this.barGPU60.Maximum = 100;
            this.barGPU60.Name = "barGPU60";
            this.barGPU60.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.barGPU60.Size = new System.Drawing.Size(45, 200);
            this.barGPU60.TabIndex = 34;
            this.barGPU60.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.barGPU60.Scroll += new System.EventHandler(this.gpuBarChanged);
            // 
            // barGPU55
            // 
            this.barGPU55.Location = new System.Drawing.Point(187, 40);
            this.barGPU55.Maximum = 100;
            this.barGPU55.Name = "barGPU55";
            this.barGPU55.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.barGPU55.Size = new System.Drawing.Size(45, 200);
            this.barGPU55.TabIndex = 33;
            this.barGPU55.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.barGPU55.Scroll += new System.EventHandler(this.gpuBarChanged);
            // 
            // barGPU50
            // 
            this.barGPU50.Location = new System.Drawing.Point(136, 40);
            this.barGPU50.Maximum = 100;
            this.barGPU50.Name = "barGPU50";
            this.barGPU50.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.barGPU50.Size = new System.Drawing.Size(45, 200);
            this.barGPU50.TabIndex = 32;
            this.barGPU50.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.barGPU50.Scroll += new System.EventHandler(this.gpuBarChanged);
            // 
            // barGPU45
            // 
            this.barGPU45.Location = new System.Drawing.Point(81, 40);
            this.barGPU45.Maximum = 100;
            this.barGPU45.Name = "barGPU45";
            this.barGPU45.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.barGPU45.Size = new System.Drawing.Size(45, 200);
            this.barGPU45.TabIndex = 31;
            this.barGPU45.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.barGPU45.Scroll += new System.EventHandler(this.gpuBarChanged);
            // 
            // barGPU40
            // 
            this.barGPU40.Location = new System.Drawing.Point(27, 40);
            this.barGPU40.Maximum = 100;
            this.barGPU40.Name = "barGPU40";
            this.barGPU40.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.barGPU40.Size = new System.Drawing.Size(45, 200);
            this.barGPU40.TabIndex = 30;
            this.barGPU40.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.barGPU40.Scroll += new System.EventHandler(this.gpuBarChanged);
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
            this.pnlProfiles.Controls.Add(this.btnProfileMax);
            this.pnlProfiles.Controls.Add(this.btnProfileManual);
            this.pnlProfiles.Controls.Add(this.btnProfileDefault);
            this.pnlProfiles.Controls.Add(this.lblProfilesHeader);
            this.pnlProfiles.Location = new System.Drawing.Point(12, 148);
            this.pnlProfiles.Name = "pnlProfiles";
            this.pnlProfiles.Size = new System.Drawing.Size(579, 45);
            this.pnlProfiles.TabIndex = 13;
            // 
            // btnProfileMax
            // 
            this.btnProfileMax.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnProfileMax.Location = new System.Drawing.Point(403, 6);
            this.btnProfileMax.Name = "btnProfileMax";
            this.btnProfileMax.Size = new System.Drawing.Size(160, 30);
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
            this.btnProfileManual.Size = new System.Drawing.Size(160, 30);
            this.btnProfileManual.TabIndex = 3;
            this.btnProfileManual.Text = "Manual";
            this.btnProfileManual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnProfileManual.UseVisualStyleBackColor = true;
            this.btnProfileManual.CheckedChanged += new System.EventHandler(this.btnProfileManual_CheckedChanged);
            // 
            // btnProfileDefault
            // 
            this.btnProfileDefault.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnProfileDefault.Location = new System.Drawing.Point(237, 6);
            this.btnProfileDefault.Name = "btnProfileDefault";
            this.btnProfileDefault.Size = new System.Drawing.Size(160, 30);
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
            this.btnExit.Location = new System.Drawing.Point(456, 561);
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
            this.btnAlwaysOnTop.AutoSize = true;
            this.btnAlwaysOnTop.Location = new System.Drawing.Point(12, 561);
            this.btnAlwaysOnTop.Name = "btnAlwaysOnTop";
            this.btnAlwaysOnTop.Size = new System.Drawing.Size(122, 30);
            this.btnAlwaysOnTop.TabIndex = 15;
            this.btnAlwaysOnTop.Text = "Always On Top";
            this.btnAlwaysOnTop.UseVisualStyleBackColor = true;
            this.btnAlwaysOnTop.CheckedChanged += new System.EventHandler(this.btnAlwaysOnTop_CheckedChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(603, 602);
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
            this.tabFanCurveCPU.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barCPU85)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barCPU80)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barCPU75)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barCPU70)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barCPU65)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barCPU60)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barCPU55)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barCPU50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barCPU45)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barCPU40)).EndInit();
            this.tabFanCurveGPU.ResumeLayout(false);
            this.tabFanCurveGPU.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barGPU85)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barGPU80)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barGPU75)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barGPU70)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barGPU65)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barGPU60)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barGPU55)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barGPU50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barGPU45)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barGPU40)).EndInit();
            this.pnlProfiles.ResumeLayout(false);
            this.pnlProfiles.PerformLayout();
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
        private System.Windows.Forms.TrackBar barCPU40;
        private System.Windows.Forms.TabPage tabFanCurveGPU;
        private System.Windows.Forms.Label lblFanCurveHeader;
        private System.Windows.Forms.Label lblIndicatorCPU40;
        private System.Windows.Forms.TrackBar barCPU85;
        private System.Windows.Forms.TrackBar barCPU80;
        private System.Windows.Forms.TrackBar barCPU75;
        private System.Windows.Forms.TrackBar barCPU70;
        private System.Windows.Forms.TrackBar barCPU65;
        private System.Windows.Forms.TrackBar barCPU60;
        private System.Windows.Forms.TrackBar barCPU55;
        private System.Windows.Forms.TrackBar barCPU50;
        private System.Windows.Forms.TrackBar barCPU45;
        private System.Windows.Forms.Label lblIndicatorCPU85;
        private System.Windows.Forms.Label lblIndicatorCPU80;
        private System.Windows.Forms.Label lblIndicatorCPU75;
        private System.Windows.Forms.Label lblIndicatorCPU70;
        private System.Windows.Forms.Label lblIndicatorCPU65;
        private System.Windows.Forms.Label lblIndicatorCPU60;
        private System.Windows.Forms.Label lblIndicatorCPU55;
        private System.Windows.Forms.Label lblIndicatorCPU50;
        private System.Windows.Forms.Label lblIndicatorCPU45;
        private System.Windows.Forms.Label lblCPUFan85;
        private System.Windows.Forms.Label lblCPUFan80;
        private System.Windows.Forms.Label lblCPUFan75;
        private System.Windows.Forms.Label lblCPUFan70;
        private System.Windows.Forms.Label lblCPUFan65;
        private System.Windows.Forms.Label lblCPUFan60;
        private System.Windows.Forms.Label lblCPUFan55;
        private System.Windows.Forms.Label lblCPUFan50;
        private System.Windows.Forms.Label lblCPUFan45;
        private System.Windows.Forms.Label lblCPUFan40;
        private System.Windows.Forms.Label lblGPUFan85;
        private System.Windows.Forms.Label lblGPUFan80;
        private System.Windows.Forms.Label lblGPUFan75;
        private System.Windows.Forms.Label lblGPUFan70;
        private System.Windows.Forms.Label lblGPUFan65;
        private System.Windows.Forms.Label lblGPUFan60;
        private System.Windows.Forms.Label lblGPUFan55;
        private System.Windows.Forms.Label lblGPUFan50;
        private System.Windows.Forms.Label lblGPUFan45;
        private System.Windows.Forms.Label lblGPUFan40;
        private System.Windows.Forms.Label lblIndicatorGPU85;
        private System.Windows.Forms.Label lblIndicatorGPU80;
        private System.Windows.Forms.Label lblIndicatorGPU75;
        private System.Windows.Forms.Label lblIndicatorGPU70;
        private System.Windows.Forms.Label lblIndicatorGPU65;
        private System.Windows.Forms.Label lblIndicatorGPU60;
        private System.Windows.Forms.Label lblIndicatorGPU55;
        private System.Windows.Forms.Label lblIndicatorGPU50;
        private System.Windows.Forms.Label lblIndicatorGPU45;
        private System.Windows.Forms.Label lblIndicatorGPU40;
        private System.Windows.Forms.TrackBar barGPU85;
        private System.Windows.Forms.TrackBar barGPU80;
        private System.Windows.Forms.TrackBar barGPU75;
        private System.Windows.Forms.TrackBar barGPU70;
        private System.Windows.Forms.TrackBar barGPU65;
        private System.Windows.Forms.TrackBar barGPU60;
        private System.Windows.Forms.TrackBar barGPU55;
        private System.Windows.Forms.TrackBar barGPU50;
        private System.Windows.Forms.TrackBar barGPU45;
        private System.Windows.Forms.TrackBar barGPU40;
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
    }
}

