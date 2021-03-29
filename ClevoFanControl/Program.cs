using System;
using System.Windows.Forms;

namespace ClevoFanControl {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {

            var exists = System.Diagnostics.Process.GetProcessesByName(System.IO.Path.GetFileNameWithoutExtension(System.Reflection.Assembly.GetEntryAssembly().Location)).Length > 1;
            if (exists) {
                MessageBox.Show("Clevo Fan Control is already running.", "Clevo Fan Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Environment.Exit(1);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
