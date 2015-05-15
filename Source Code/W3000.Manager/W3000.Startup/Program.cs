using System;
using System.Runtime.Remoting;
using System.Threading;
using System.Windows.Forms;
using W3000.Manager;
using W3000.Manager.FormMisc;
using DevExpress.LookAndFeel;

namespace W3000.Startup
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            RemotingConfiguration.Configure(string.Format("{0}.config", Application.ExecutablePath), false);

            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            Application.ThreadException += Application_ThreadException;

            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Data.CurrencyDataController.DisableThreadingProblemsDetection = true;
            UserLookAndFeel.Default.SetSkinStyle("Money Twins");

            FormLogin frmLogin = new FormLogin(new LoginService());
            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                FormMain frmMain = new FormMain(frmLogin.UserId);
                Application.Run(frmMain);
            }
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            try
            {
                FormFatalError dlg = new FormFatalError((Exception) e.ExceptionObject);
                dlg.ShowDialog();

                Cursor.Current = Cursors.Default;
            }
            catch
            {
            }
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            try
            {
                FormFatalError dlg = new FormFatalError(e.Exception);
                dlg.ShowDialog();

                Cursor.Current = Cursors.Default;
            }
            catch
            {
            }
        }
    }
}
