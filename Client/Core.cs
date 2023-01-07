using System;
using System.Reflection;
using System.Windows.Forms;
using Client.Data;
using Newtonsoft.Json;
using System.Net.Mail;
using System.Net;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.Win32;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Collections.Generic;
using System.Diagnostics;

namespace Client
{
    public static class Core
    {
        public static RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
        public static string Code = "NOT-NULL";
        public static bool code_resend = true;
        public static bool cancel_shutown = false;
        public static int shutdown_timer = 0;

        private static PrivateFontCollection fontCollection = new PrivateFontCollection();
        #region DLL_IMPORTS
        private static string initial_file_path = $@"{Application.StartupPath}\bin\initials.dll";
        private static string defaults_file_path = $@"{Application.StartupPath}\bin\Defaults.dll";
        public static object Get_Token(string pass_key)
        {
            var type = Assembly.LoadFile(initial_file_path).GetType("Initials.Core");
            var obj = Activator.CreateInstance(type);
            return type.GetMethod("Get_Token").Invoke(obj, new object[] { pass_key });

        }

        public static AuthData Auth(string token, string password)
        {
            var type = Assembly.LoadFile(initial_file_path).GetType("Initials.Core");
            var obj = Activator.CreateInstance(type);
            AuthData authData = JsonConvert.DeserializeObject<AuthData>(type.GetMethod("Auth").Invoke(obj, new object[] { token, password }).ToString());
            return authData;
        }

        public static LoginData Sign(string token)
        {
            var type = Assembly.LoadFile(initial_file_path).GetType("Initials.Core");
            var obj = Activator.CreateInstance(type);
            LoginData loginData = JsonConvert.DeserializeObject<LoginData>(type.GetMethod("Sign").Invoke(obj, new object[] { token }).ToString());
            return loginData;
        }

        public static void WriteDefaults(string Setting , object Value)
        {
            var type = Assembly.LoadFile(defaults_file_path).GetType("Defaults.Core");
            var obj = Activator.CreateInstance(type);
            type.GetMethod("Write").Invoke(obj, new object[] { Setting , Value });
        }

        public static object ReadDefaults(string Setting)
        {
            var type = Assembly.LoadFile(defaults_file_path).GetType("Defaults.Core");
            var obj = Activator.CreateInstance(type);
            return type.GetMethod("Read").Invoke(obj, new object[] { Setting });
        }

        #endregion

        public static void SendEmail(string Code , string Way)
        {
            string from = "mrcollegebellsystem@gmail.com";
            string fromPass = "kxgolvjyspajogwt";

            MailMessage message = new MailMessage();
            message.From = new MailAddress(from , "MRC Bell System" , Encoding.UTF8);
            message.Subject = $"Bell Code({Way}) : {Code} ";
            message.IsBodyHtml = true;
            message.To.Add(new MailAddress("mediaunitmrc@gmail.com"));
            message.Body = $"You can use this code for authenticate our bell system.\nBell Code({Way}) : {Code}.";

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(from, fromPass),
                EnableSsl = true,
            };
            smtpClient.Send(message);
        }

        public static PrivateFontCollection setRaleway()
        {  
            int font_length = Properties.Resources.Raleway_Medium.Length;
            byte[] font_data = Properties.Resources.Raleway_Medium;
            IntPtr data = Marshal.AllocCoTaskMem(font_length);
            Marshal.Copy(font_data, 0, data, font_length);
            fontCollection.AddMemoryFont(data, font_length);
            return fontCollection;
        }
        public static PrivateFontCollection setPoppins()
        {
            int font_length = Properties.Resources.Poppins_Medium.Length;
            byte[] font_data = Properties.Resources.Poppins_Medium;
            IntPtr data = Marshal.AllocCoTaskMem(font_length);
            Marshal.Copy(font_data, 0, data, font_length);
            fontCollection.AddMemoryFont(data, font_length);
            return fontCollection;
        }

        public static bool CheckForInternetConnection()
        {
            try
            {
                var request = (HttpWebRequest)WebRequest.Create("https://google.com");
                request.KeepAlive = false;
                request.Timeout = 10000;
                using (var response = (HttpWebResponse)request.GetResponse())
                    return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool IsShutDownDay(string day)
        {
            return Convert.ToBoolean(ReadDefaults(day));
        }
    }
}
