using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.Data;
using Client.Properties;

namespace Client
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginData signData = Core.Sign(Settings.Default.token);
            if (signData.LOGIN_KEY == "LOGGED_OUT" && signData.APP == "Client")
            {
                Application.Run(new LogIn());
            }
            else if (Settings.Default.token.Length >= 100 && signData.APP == "Client")
            {
                Application.Run(new DashBoard());
            }
        }
    }
}
