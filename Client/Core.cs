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
using Client.BellData;
using System.IO;
using System.ComponentModel;

namespace Client
{
    public static class Core
    {
        #region extensions
        private static readonly byte[] BMP = { 66, 77 };
        private static readonly byte[] DOC = { 208, 207, 17, 224, 161, 177, 26, 225 };
        private static readonly byte[] EXE_DLL = { 77, 90 };
        private static readonly byte[] GIF = { 71, 73, 70, 56 };
        private static readonly byte[] ICO = { 0, 0, 1, 0 };
        private static readonly byte[] JPG = { 255, 216, 255 };
        private static readonly byte[] MP3 = { 255, 251, 48 };
        private static readonly byte[] OGG = { 79, 103, 103, 83, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static readonly byte[] PDF = { 37, 80, 68, 70, 45, 49, 46 };
        private static readonly byte[] PNG = { 137, 80, 78, 71, 13, 10, 26, 10, 0, 0, 0, 13, 73, 72, 68, 82 };
        private static readonly byte[] RAR = { 82, 97, 114, 33, 26, 7, 0 };
        private static readonly byte[] SWF = { 70, 87, 83 };
        private static readonly byte[] TIFF = { 73, 73, 42, 0 };
        private static readonly byte[] TORRENT = { 100, 56, 58, 97, 110, 110, 111, 117, 110, 99, 101 };
        private static readonly byte[] TTF = { 0, 1, 0, 0, 0 };
        private static readonly byte[] WAV_AVI = { 82, 73, 70, 70 };
        private static readonly byte[] WMV_WMA = { 48, 38, 178, 117, 142, 102, 207, 17, 166, 217, 0, 170, 0, 98, 206, 108 };
        private static readonly byte[] ZIP_DOCX = { 80, 75, 3, 4 };

        #endregion

        public static RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
        public static string Code = "NOT-NULL";
        public static bool code_resend = true;
        public static bool cancel_shutown = false;
        public static int shutdown_timer = 0;
        public static string edit_id = "";
        public static Random Random = new Random();
        public static string Base64oftrack = "";
        public static MorningData morningData = new MorningData();
        public static List<MorningData> MorningList = new List<MorningData>();
        public static string BaseDir = $@"{Application.StartupPath}\Client";
        public static bool hasToUpdate = false;

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


        public static string MorningToJson(List<MorningData> obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
        public static string GetMimeType(byte[] file)
        {

            string mime = "application/octet-stream";


            foreach (byte b in file)
            {
                if (file.Take(b).SequenceEqual(PNG))
                {
                    mime = "png";
                }
                else if (file.Take(b).SequenceEqual(RAR))
                {
                    mime = "rar";
                }
                else if (file.Take(b).SequenceEqual(ZIP_DOCX))
                {
                    mime = "zip";
                }
                else if (file.Take(b).SequenceEqual(JPG))
                {
                    mime = "jpg";
                }
                else if (file.Take(b).SequenceEqual(BMP))
                {
                    mime = "bmp";
                }

            }

            return mime;
        }
        public static List<MorningData> TotheMorning(string path)
        {
            using(StreamReader sr = new StreamReader(path))
            {
                return JsonConvert.DeserializeObject<List<MorningData>>(sr.ReadToEnd());
            }
        }
    }
}
