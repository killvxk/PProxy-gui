using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace PProxy_gui
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var mutex = new Mutex(false, "Global\\PProxy"))
            {
                if (!mutex.WaitOne(0, false))
                {
                    MessageBox.Show("程序已在运行中", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Environment.Exit(1);
                }

                Directory.SetCurrentDirectory(Application.StartupPath);

                if (!Directory.Exists(Properties.Resources.s_prefix))
                {
                    Directory.CreateDirectory(Properties.Resources.s_prefix);
                }
                if (!Directory.Exists(Properties.Resources.p_prefix))
                {
                    Directory.CreateDirectory(Properties.Resources.p_prefix);
                }

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new View.MainView());
            }
        }
    }
}
