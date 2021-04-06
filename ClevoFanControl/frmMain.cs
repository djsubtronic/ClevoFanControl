using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenHardwareMonitor.Hardware;


namespace ClevoFanControl {
    public partial class frmMain : Form {

        private const int SLEEP_TIME_BETWEEN_MEASUREMENTS = 2000;
        int timerTickCount = 0;
        int cpuFanRampIntervals = 5;
        int gpuFanRampIntervals = 5;

        private IFanControl fan;
        private static Computer computer;

        int prevFanCPUPercentage = -1;
        int prevFanGPUPercentage = -1;

        int lastWLeft;
        int lastWTop;

        ManagementObjectSearcher wmiSearcher = new ManagementObjectSearcher("root\\WMI", "SELECT * FROM MSAcpi_ThermalZoneTemperature");
        ManagementObject cpuSensor;

        int currentCpuTemp;
        int currentGpuTemp;
        int prevCpuTemp;
        int prevGpuTemp;
        int currentCpuFan;
        int currentGpuFan;

        int cpuSameTempTicks = 0;
        int gpuSameTempTicks = 0;

        FanTable defaultCpuFanTable;
        FanTable defaultGpuFanTable;

        FanTable maxFanTable;

        FanTable userCpuFanTable;
        FanTable userGpuFanTable;

        FanTable cpuFanTable;
        FanTable gpuFanTable;

        public frmMain() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

            fan = new ClevoEcInfo();

            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(UnhandledExceptionHandler);

            computer = new Computer() {
                CPUEnabled = true,
                GPUEnabled = true
            };

            maxFanTable.Fan40 = 100;
            maxFanTable.Fan45 = 100;
            maxFanTable.Fan50 = 100;
            maxFanTable.Fan55 = 100;
            maxFanTable.Fan60 = 100;
            maxFanTable.Fan65 = 100;
            maxFanTable.Fan70 = 100;
            maxFanTable.Fan75 = 100;
            maxFanTable.Fan80 = 100;
            maxFanTable.Fan85 = 100;

            defaultCpuFanTable.Fan40 = 40;
            defaultCpuFanTable.Fan45 = 40;
            defaultCpuFanTable.Fan50 = 40;
            defaultCpuFanTable.Fan55 = 40;
            defaultCpuFanTable.Fan60 = 50;
            defaultCpuFanTable.Fan65 = 50;
            defaultCpuFanTable.Fan70 = 60;
            defaultCpuFanTable.Fan75 = 60;
            defaultCpuFanTable.Fan80 = 70;
            defaultCpuFanTable.Fan85 = 70;

            defaultGpuFanTable.Fan40 = 40;
            defaultGpuFanTable.Fan45 = 40;
            defaultGpuFanTable.Fan50 = 40;
            defaultGpuFanTable.Fan55 = 40;
            defaultGpuFanTable.Fan60 = 50;
            defaultGpuFanTable.Fan65 = 50;
            defaultGpuFanTable.Fan70 = 60;
            defaultGpuFanTable.Fan75 = 60;
            defaultGpuFanTable.Fan80 = 70;
            defaultGpuFanTable.Fan85 = 70;

            cpuFanTable = defaultCpuFanTable;
            gpuFanTable = defaultGpuFanTable;

            LoadFanTableAndConfig();

            SetSliderValuesFromTable();

            prgCPUFan.Width = 0;
            prgGPUFan.Width = 0;

            computer.Open();
            tmrMain.Interval = SLEEP_TIME_BETWEEN_MEASUREMENTS;
            tmrMain.Enabled = true;

        }

        private void UnhandledExceptionHandler(object sender, UnhandledExceptionEventArgs args) {
            SetFansToMaximum();
            MessageBox.Show("An unexpected error has occurred, fans have been set to 100% for safety.", "Clevo Fan Control Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void tmrMain_Tick(object sender, EventArgs e) {

            // Get CPU temperature and set fan speed
            currentCpuTemp = GetCurrentTemperature("CPU");
            currentGpuTemp = GetCurrentTemperature("GPU");

            currentCpuFan = CalcFanPercentage("CPU", currentCpuTemp);
            currentGpuFan = CalcFanPercentage("GPU", currentGpuTemp);

            if (currentCpuTemp > 85 && currentGpuTemp >= 85) {
                currentCpuFan = 100;
                currentGpuFan = 100;
            }

            if (currentCpuFan != prevFanCPUPercentage || timerTickCount * tmrMain.Interval * 0.001 >= 60) {
                fan?.SetFanSpeed(1, currentCpuFan);
                //RampFanSpeed(1, currentCpuFan);
                prevFanCPUPercentage = currentCpuFan;
                cpuSameTempTicks = 0;
            }

            if (currentGpuFan != prevFanGPUPercentage || timerTickCount * tmrMain.Interval * 0.001 >= 60) {
                fan?.SetFanSpeed(2, currentGpuFan);
                //RampFanSpeed(2, currentCpuFan);
                prevFanGPUPercentage = currentGpuFan;
                gpuSameTempTicks = 0;
            }

            UpdateGui();

            timerTickCount++;
            if (timerTickCount * tmrMain.Interval * 0.001 > 60) {
                GC.Collect();
                timerTickCount = 0;
            }

            prevCpuTemp = currentCpuTemp;
            prevGpuTemp = currentGpuTemp;

        }

        private int CalcFanPercentage(string device, int currentTemp) {

            int newFanPerc;

            if (device == "CPU") {

                if (currentTemp >= 85) {
                    newFanPerc = cpuFanTable.Fan85;
                } else if (currentTemp >= 80) {
                    newFanPerc = cpuFanTable.Fan80;
                } else if (currentTemp >= 75) {
                    newFanPerc = cpuFanTable.Fan75;
                } else if (currentTemp >= 70) {
                    newFanPerc = cpuFanTable.Fan70;
                } else if (currentTemp >= 65) {
                    newFanPerc = cpuFanTable.Fan65;
                } else if (currentTemp >= 60) {
                    newFanPerc = cpuFanTable.Fan60;
                } else if (currentTemp >= 55) {
                    newFanPerc = cpuFanTable.Fan55;
                } else if (currentTemp >= 50) {
                    newFanPerc = cpuFanTable.Fan50;
                } else if (currentTemp >= 45) {
                    newFanPerc = cpuFanTable.Fan45;
                } else if (currentTemp >= 40) {
                    newFanPerc = cpuFanTable.Fan40;
                } else {
                    if (btnProfileManual.Checked) {
                        newFanPerc = 0;
                    } else if (btnProfileDefault.Checked) {
                        newFanPerc = 40;
                    } else if (btnProfileMax.Checked) {
                        newFanPerc = 100;
                    } else {
                        newFanPerc = 100;
                    }
                }

                return newFanPerc;

            } else if (device == "GPU") {

                if (currentTemp >= 85) {
                    newFanPerc = gpuFanTable.Fan85;
                } else if (currentTemp >= 80) {
                    newFanPerc = gpuFanTable.Fan80;
                } else if (currentTemp >= 75) {
                    newFanPerc = gpuFanTable.Fan75;
                } else if (currentTemp >= 70) {
                    newFanPerc = gpuFanTable.Fan70;
                } else if (currentTemp >= 65) {
                    newFanPerc = gpuFanTable.Fan65;
                } else if (currentTemp >= 60) {
                    newFanPerc = gpuFanTable.Fan60;
                } else if (currentTemp >= 55) {
                    newFanPerc = gpuFanTable.Fan55;
                } else if (currentTemp >= 50) {
                    newFanPerc = gpuFanTable.Fan50;
                } else if (currentTemp >= 45) {
                    newFanPerc = gpuFanTable.Fan45;
                } else if (currentTemp >= 40) {
                    newFanPerc = gpuFanTable.Fan40;
                } else {
                    if (btnProfileManual.Checked) {
                        newFanPerc = 0;
                    } else if (btnProfileDefault.Checked) {
                        newFanPerc = 40;
                    } else if (btnProfileMax.Checked) {
                        newFanPerc = 100;
                    } else {
                        newFanPerc = 100;
                    }
                }

                return newFanPerc;

            }

            return 100;
        }

        private int GetCurrentTemperature(string device) {

            if (device == "CPU") {

                try {
                    cpuSensor = wmiSearcher.Get().OfType<ManagementObject>().FirstOrDefault();
                    int currTemp = (Convert.ToInt32(cpuSensor["CurrentTemperature"]) - 2732) / 10;
                    //GC.Collect();
                    return currTemp;
                } catch {
                    return prevCpuTemp;
                }


            } else if (device == "GPU") {

                try {
                    IHardware hardware = computer.Hardware[1];
                    hardware.Update();
                    foreach (ISensor sensor in hardware.Sensors) {
                        if (sensor.SensorType == SensorType.Temperature && sensor.Name == "GPU Core") {
                            return Convert.ToInt32(sensor.Value);
                        }
                    }
                } catch (Exception e) { }

            }

            return 0;
        }

        private void SetFansToMaximum() {
            fan?.SetFanSpeed(1, 100);
            fan?.SetFanSpeed(2, 100);
            //RampFanSpeed(1, 100);
            //RampFanSpeed(2, 100);
        }

        private void RampFanSpeed(int FanNumber, int FanSpeed) {
            if (FanNumber == 1) {
                int rampPercentage = (FanSpeed - prevFanCPUPercentage) / cpuFanRampIntervals;
                Parallel.For(1, cpuFanRampIntervals, i => {
                    fan?.SetFanSpeed(1, prevFanCPUPercentage + (i * rampPercentage));
                    Thread.Sleep(100);
                });
                //for (int i = 1; i <= cpuFanRampIntervals; i++) {
                //    fan?.SetFanSpeed(1, prevFanCPUPercentage + (i * rampPercentage));
                //    Thread.Sleep(100);
                //}
            } else if (FanNumber == 2) {
                int rampPercentage = (FanSpeed - prevFanGPUPercentage) / gpuFanRampIntervals;
                Parallel.For(1, gpuFanRampIntervals, i => {
                    fan?.SetFanSpeed(2, prevFanGPUPercentage + (i * rampPercentage));
                    Thread.Sleep(100);
                });
                //for (int i = 1; i <= gpuFanRampIntervals; i++) {
                //    Thread.Sleep(100);
                //}
            }
        }

        private void UpdateGui() {

            if (WindowState != FormWindowState.Minimized) {

                lblCPUTemp.Text = currentCpuTemp + "°";
                lblCPUFan.Text = currentCpuFan + "%";
                prgCPUFan.Width = Convert.ToInt32((Convert.ToDecimal(currentCpuFan) / 100) * (prgCPUFanContainer.Width - 4));

                if (currentGpuTemp > 0) {
                    lblGPUTemp.Text = currentGpuTemp.ToString() + "°";
                    lblGPUTemp.Font = new Font("Open Sans", 24);
                    lblGPUHeader.ForeColor = Color.Black;
                    lblGPUTemp.ForeColor = Color.Black;
                    lblGPUFanHeader.ForeColor = Color.Black;
                    lblGPUFan.ForeColor = Color.Black;
                } else {
                    lblGPUTemp.Text = "Asleep";
                    lblGPUTemp.Font = new Font("Open Sans", 24);
                    lblGPUHeader.ForeColor = Color.DimGray;
                    lblGPUTemp.ForeColor = Color.DimGray;
                    lblGPUFanHeader.ForeColor = Color.DimGray;
                    lblGPUFan.ForeColor = Color.DimGray;
                }
                lblGPUFan.Text = currentGpuFan + "%";
                prgGPUFan.Width = Convert.ToInt32((Convert.ToDecimal(currentGpuFan) / 100) * (prgGPUFanContainer.Width - 4));

            }

            string tooltip =
                "CPU\n"
                + "  Temp: " + currentCpuTemp + "°\n"
                + "  Fan: " + currentCpuFan + "%\n\n"
                + "GPU\n"
                + (currentGpuTemp > 0
                    ?
                        "  Temp: " + currentGpuTemp + "°\n"
                        + "  Fan: " + currentGpuFan + "%"
                    :
                        "  Asleep"
                );
            icoTray.Text = tooltip;

        }

        private void SetSliderValuesFromTable() {

            barCPU40.Value = cpuFanTable.Fan40;
            barCPU45.Value = cpuFanTable.Fan45;
            barCPU50.Value = cpuFanTable.Fan50;
            barCPU55.Value = cpuFanTable.Fan55;
            barCPU60.Value = cpuFanTable.Fan60;
            barCPU65.Value = cpuFanTable.Fan65;
            barCPU70.Value = cpuFanTable.Fan70;
            barCPU75.Value = cpuFanTable.Fan75;
            barCPU80.Value = cpuFanTable.Fan80;
            barCPU85.Value = cpuFanTable.Fan85;
            lblCPUFan40.Text = cpuFanTable.Fan40 + "%";
            lblCPUFan45.Text = cpuFanTable.Fan45 + "%";
            lblCPUFan50.Text = cpuFanTable.Fan50 + "%";
            lblCPUFan55.Text = cpuFanTable.Fan55 + "%";
            lblCPUFan60.Text = cpuFanTable.Fan60 + "%";
            lblCPUFan65.Text = cpuFanTable.Fan65 + "%";
            lblCPUFan70.Text = cpuFanTable.Fan70 + "%";
            lblCPUFan75.Text = cpuFanTable.Fan75 + "%";
            lblCPUFan80.Text = cpuFanTable.Fan80 + "%";
            lblCPUFan85.Text = cpuFanTable.Fan85 + "%";

            barGPU40.Value = gpuFanTable.Fan40;
            barGPU45.Value = gpuFanTable.Fan45;
            barGPU50.Value = gpuFanTable.Fan50;
            barGPU55.Value = gpuFanTable.Fan55;
            barGPU60.Value = gpuFanTable.Fan60;
            barGPU65.Value = gpuFanTable.Fan65;
            barGPU70.Value = gpuFanTable.Fan70;
            barGPU75.Value = gpuFanTable.Fan75;
            barGPU80.Value = gpuFanTable.Fan80;
            barGPU85.Value = gpuFanTable.Fan85;
            lblGPUFan40.Text = gpuFanTable.Fan40 + "%";
            lblGPUFan45.Text = gpuFanTable.Fan45 + "%";
            lblGPUFan50.Text = gpuFanTable.Fan50 + "%";
            lblGPUFan55.Text = gpuFanTable.Fan55 + "%";
            lblGPUFan60.Text = gpuFanTable.Fan60 + "%";
            lblGPUFan65.Text = gpuFanTable.Fan65 + "%";
            lblGPUFan70.Text = gpuFanTable.Fan70 + "%";
            lblGPUFan75.Text = gpuFanTable.Fan75 + "%";
            lblGPUFan80.Text = gpuFanTable.Fan80 + "%";
            lblGPUFan85.Text = gpuFanTable.Fan85 + "%";

        }

        private void LoadFanTableAndConfig() {

            var fanCurveFile = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\userfancurve.cfg";

            if (!File.Exists(fanCurveFile)) {
                SaveFanTableAndConfig();
            }

            using (var sw = new StreamReader(fanCurveFile)) {

                userCpuFanTable.Fan40 = Convert.ToInt32(sw.ReadLine());
                userCpuFanTable.Fan45 = Convert.ToInt32(sw.ReadLine());
                userCpuFanTable.Fan50 = Convert.ToInt32(sw.ReadLine());
                userCpuFanTable.Fan55 = Convert.ToInt32(sw.ReadLine());
                userCpuFanTable.Fan60 = Convert.ToInt32(sw.ReadLine());
                userCpuFanTable.Fan65 = Convert.ToInt32(sw.ReadLine());
                userCpuFanTable.Fan70 = Convert.ToInt32(sw.ReadLine());
                userCpuFanTable.Fan75 = Convert.ToInt32(sw.ReadLine());
                userCpuFanTable.Fan80 = Convert.ToInt32(sw.ReadLine());
                userCpuFanTable.Fan85 = Convert.ToInt32(sw.ReadLine());
                cpuFanTable = userCpuFanTable;

                userGpuFanTable.Fan40 = Convert.ToInt32(sw.ReadLine());
                userGpuFanTable.Fan45 = Convert.ToInt32(sw.ReadLine());
                userGpuFanTable.Fan50 = Convert.ToInt32(sw.ReadLine());
                userGpuFanTable.Fan55 = Convert.ToInt32(sw.ReadLine());
                userGpuFanTable.Fan60 = Convert.ToInt32(sw.ReadLine());
                userGpuFanTable.Fan65 = Convert.ToInt32(sw.ReadLine());
                userGpuFanTable.Fan70 = Convert.ToInt32(sw.ReadLine());
                userGpuFanTable.Fan75 = Convert.ToInt32(sw.ReadLine());
                userGpuFanTable.Fan80 = Convert.ToInt32(sw.ReadLine());
                userGpuFanTable.Fan85 = Convert.ToInt32(sw.ReadLine());
                gpuFanTable = userGpuFanTable;

            }

            var configFile = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\ClevoFanControl.cfg";

            if (!File.Exists(configFile)) {
                SaveFanTableAndConfig();
            }

            int wLeft = 0, wTop = 0;

            using (var sw = new StreamReader(configFile)) {

                var profile = sw.ReadLine();
                if (profile == "1") {
                    btnProfileManual.Checked = true;
                    mnuProfileManual.Checked = true;
                    mnuProfileDefault.Checked = false;
                    mnuProfileMax.Checked = false;
                } else if (profile == "2") {
                    btnProfileDefault.Checked = true;
                    mnuProfileManual.Checked = false;
                    mnuProfileDefault.Checked = true;
                    mnuProfileMax.Checked = false;
                } else if (profile == "3") {
                    btnProfileMax.Checked = true;
                    mnuProfileManual.Checked = false;
                    mnuProfileDefault.Checked = false;
                    mnuProfileMax.Checked = true;
                }

                wLeft = Convert.ToInt32(sw.ReadLine());
                wTop = Convert.ToInt32(sw.ReadLine());

                lastWLeft = wLeft;
                lastWTop = wTop;

                btnAlwaysOnTop.Checked = Convert.ToBoolean(sw.ReadLine());

            }

            Left = wLeft;
            Top = wTop;

            if (!IsOnScreen(this)) {
                wLeft = (Screen.PrimaryScreen.Bounds.Width / 2) - (619 / 2);
                wTop = (Screen.PrimaryScreen.Bounds.Height / 2) - (641 / 2);
                lastWLeft = wLeft;
                lastWTop = wTop;
                Left = wLeft;
                Top = wTop;
            }

        }

        private void SaveFanTableAndConfig() {

            var path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\";

            if (btnProfileManual.Checked) {

                using (var sw = new StreamWriter(path + "userfancurve.cfg")) {

                    sw.WriteLine(userCpuFanTable.Fan40);
                    sw.WriteLine(userCpuFanTable.Fan45);
                    sw.WriteLine(userCpuFanTable.Fan50);
                    sw.WriteLine(userCpuFanTable.Fan55);
                    sw.WriteLine(userCpuFanTable.Fan60);
                    sw.WriteLine(userCpuFanTable.Fan65);
                    sw.WriteLine(userCpuFanTable.Fan70);
                    sw.WriteLine(userCpuFanTable.Fan75);
                    sw.WriteLine(userCpuFanTable.Fan80);
                    sw.WriteLine(userCpuFanTable.Fan85);

                    sw.WriteLine(userGpuFanTable.Fan40);
                    sw.WriteLine(userGpuFanTable.Fan45);
                    sw.WriteLine(userGpuFanTable.Fan50);
                    sw.WriteLine(userGpuFanTable.Fan55);
                    sw.WriteLine(userGpuFanTable.Fan60);
                    sw.WriteLine(userGpuFanTable.Fan65);
                    sw.WriteLine(userGpuFanTable.Fan70);
                    sw.WriteLine(userGpuFanTable.Fan75);
                    sw.WriteLine(userGpuFanTable.Fan80);
                    sw.WriteLine(userGpuFanTable.Fan85);

                }

            }

            using (var sw = new StreamWriter(path + "ClevoFanControl.cfg")) {

                if (btnProfileManual.Checked) {
                    sw.WriteLine("1");
                } else if (btnProfileDefault.Checked) {
                    sw.WriteLine("2");
                } else if (btnProfileMax.Checked) {
                    sw.WriteLine("3");
                }

                if (Left > 10000 && Top > 10000) {
                    sw.WriteLine(Left);
                    sw.WriteLine(Top);
                } else {
                    sw.WriteLine(lastWLeft);
                    sw.WriteLine(lastWTop);
                }

                sw.WriteLine(btnAlwaysOnTop.Checked);
            }

        }
        private void ShowWindow() {
            Show();
            WindowState = FormWindowState.Normal;
            ShowInTaskbar = true;
        }
        private void ExitApp() {
            tmrMain.Enabled = false;
            computer.Close();
            SetFansToMaximum();
            fan?.Dispose();
            SaveFanTableAndConfig();
            Close();
            Application.Exit();
            Environment.Exit(1);
        }

        public bool IsOnScreen(Form form) {
            Screen[] screens = Screen.AllScreens;
            foreach (Screen screen in screens) {
                Rectangle formRectangle = new Rectangle(form.Left, form.Top,
                                                         form.Width, form.Height);

                if (screen.WorkingArea.Contains(formRectangle)) {
                    return true;
                }
            }

            return false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            if (e.CloseReason != CloseReason.WindowsShutDown) {
                e.Cancel = true;
                WindowState = FormWindowState.Minimized;
                ShowInTaskbar = false;
            }
        }

        private void mnuExit_Click(object sender, EventArgs e) {
            ExitApp();
        }

        private void mnuShowWindow_Click(object sender, EventArgs e) {
            ShowWindow();
        }

        private void icoTray_DoubleClick(object sender, EventArgs e) {
            ShowWindow();
        }

        private void cpuBarChanged(object sender, EventArgs e) {
            TrackBar t = (TrackBar)sender;
            if (t.Name == "barCPU40") {
                cpuFanTable.Fan40 = t.Value;
                userCpuFanTable.Fan40 = t.Value;
                lblCPUFan40.Text = t.Value + "%";
            } else if (t.Name == "barCPU45") {
                cpuFanTable.Fan45 = t.Value;
                userCpuFanTable.Fan45 = t.Value;
                lblCPUFan45.Text = t.Value + "%";
            } else if (t.Name == "barCPU50") {
                cpuFanTable.Fan50 = t.Value;
                userCpuFanTable.Fan50 = t.Value;
                lblCPUFan50.Text = t.Value + "%";
            } else if (t.Name == "barCPU55") {
                cpuFanTable.Fan55 = t.Value;
                userCpuFanTable.Fan55 = t.Value;
                lblCPUFan55.Text = t.Value + "%";
            } else if (t.Name == "barCPU60") {
                cpuFanTable.Fan60 = t.Value;
                userCpuFanTable.Fan60 = t.Value;
                lblCPUFan60.Text = t.Value + "%";
            } else if (t.Name == "barCPU65") {
                cpuFanTable.Fan65 = t.Value;
                userCpuFanTable.Fan65 = t.Value;
                lblCPUFan65.Text = t.Value + "%";
            } else if (t.Name == "barCPU70") {
                cpuFanTable.Fan70 = t.Value;
                userCpuFanTable.Fan70 = t.Value;
                lblCPUFan70.Text = t.Value + "%";
            } else if (t.Name == "barCPU75") {
                cpuFanTable.Fan75 = t.Value;
                userCpuFanTable.Fan75 = t.Value;
                lblCPUFan75.Text = t.Value + "%";
            } else if (t.Name == "barCPU80") {
                cpuFanTable.Fan80 = t.Value;
                userCpuFanTable.Fan80 = t.Value;
                lblCPUFan80.Text = t.Value + "%";
            } else if (t.Name == "barCPU85") {
                cpuFanTable.Fan85 = t.Value;
                userCpuFanTable.Fan85 = t.Value;
                lblCPUFan85.Text = t.Value + "%";
            }
            SaveFanTableAndConfig();
        }

        private void gpuBarChanged(object sender, EventArgs e) {
            TrackBar t = (TrackBar)sender;
            if (t.Name == "barGPU40") {
                gpuFanTable.Fan40 = t.Value;
                userGpuFanTable.Fan40 = t.Value;
                lblGPUFan40.Text = t.Value + "%";
            } else if (t.Name == "barGPU45") {
                gpuFanTable.Fan45 = t.Value;
                userGpuFanTable.Fan45 = t.Value;
                lblGPUFan45.Text = t.Value + "%";
            } else if (t.Name == "barGPU50") {
                gpuFanTable.Fan50 = t.Value;
                userGpuFanTable.Fan50 = t.Value;
                lblGPUFan50.Text = t.Value + "%";
            } else if (t.Name == "barGPU55") {
                gpuFanTable.Fan55 = t.Value;
                userGpuFanTable.Fan55 = t.Value;
                lblGPUFan55.Text = t.Value + "%";
            } else if (t.Name == "barGPU60") {
                gpuFanTable.Fan60 = t.Value;
                userGpuFanTable.Fan60 = t.Value;
                lblGPUFan60.Text = t.Value + "%";
            } else if (t.Name == "barGPU65") {
                gpuFanTable.Fan65 = t.Value;
                userGpuFanTable.Fan65 = t.Value;
                lblGPUFan65.Text = t.Value + "%";
            } else if (t.Name == "barGPU70") {
                gpuFanTable.Fan70 = t.Value;
                userGpuFanTable.Fan70 = t.Value;
                lblGPUFan70.Text = t.Value + "%";
            } else if (t.Name == "barGPU75") {
                gpuFanTable.Fan75 = t.Value;
                userGpuFanTable.Fan75 = t.Value;
                lblGPUFan75.Text = t.Value + "%";
            } else if (t.Name == "barGPU80") {
                gpuFanTable.Fan80 = t.Value;
                userGpuFanTable.Fan80 = t.Value;
                lblGPUFan80.Text = t.Value + "%";
            } else if (t.Name == "barGPU85") {
                gpuFanTable.Fan85 = t.Value;
                userGpuFanTable.Fan85 = t.Value;
                lblGPUFan85.Text = t.Value + "%";
            }
            SaveFanTableAndConfig();
        }

        private void btnProfileManual_CheckedChanged(object sender, EventArgs e) {
            if (btnProfileManual.Checked) {
                cpuFanTable = userCpuFanTable;
                gpuFanTable = userGpuFanTable;
                tabFanCurves.Enabled = true;
                mnuProfileManual.Checked = true;
                mnuProfileDefault.Checked = false;
                mnuProfileMax.Checked = false;
            }
        }

        private void btnProfileDefault_CheckedChanged(object sender, EventArgs e) {
            if (btnProfileDefault.Checked) {
                cpuFanTable = defaultCpuFanTable;
                gpuFanTable = defaultGpuFanTable;
                tabFanCurves.Enabled = false;
                mnuProfileManual.Checked = false;
                mnuProfileDefault.Checked = true;
                mnuProfileMax.Checked = false;
            }
        }

        private void btnProfileMax_CheckedChanged(object sender, EventArgs e) {
            if (btnProfileMax.Checked) {
                cpuFanTable = maxFanTable;
                gpuFanTable = maxFanTable;
                tabFanCurves.Enabled = false;
                mnuProfileManual.Checked = false;
                mnuProfileDefault.Checked = false;
                mnuProfileMax.Checked = true;
            }
        }

        private void mnuProfileManual_Click(object sender, EventArgs e) {
            btnProfileManual.Checked = true;
        }

        private void mnuProfileDefault_Click(object sender, EventArgs e) {
            btnProfileDefault.Checked = true;
        }

        private void mnuProfileMax_Click(object sender, EventArgs e) {
            btnProfileMax.Checked = true;
        }

        private void frmMain_LocationChanged(object sender, EventArgs e) {
            if (WindowState != FormWindowState.Minimized) {
                lastWLeft = Left;
                lastWTop = Top;
                SaveFanTableAndConfig();
            }
        }
        private void btnExit_Click(object sender, EventArgs e) {
            ExitApp();
        }

        private void btnAlwaysOnTop_CheckedChanged(object sender, EventArgs e) {
            TopMost = btnAlwaysOnTop.Checked;
        }
    }

    struct FanTable {
        public int Fan40;
        public int Fan45;
        public int Fan50;
        public int Fan55;
        public int Fan60;
        public int Fan65;
        public int Fan70;
        public int Fan75;
        public int Fan80;
        public int Fan85;
    }

}
