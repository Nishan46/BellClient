using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;
using Client.Properties;

namespace Client
{
    public partial class LogIn : Form
    {
        
        public LogIn()
        {
            InitializeComponent();
            this.AcceptButton = btnLogin;
            foreach (Control controls in this.Controls)
            {
                if(controls.Name != "txtCode")
                {
                    controls.Font = new Font(Core.setRaleway().Families[0], controls.Font.Size, controls.Font.Style);
                }
            }
            UseWaitCursor = true;
            SendEmail();
            ShowLoader(true);
        }

        private void ShowLoader(bool show)
        {
            if(show)
            {
                loader.Animated = true;
                loader.Visible = true;
            }
            else
            {
                loader.Animated = false;
                loader.Visible = false;
            }
        }
        private void SendEmail()
        {
            Thread SendEmailThread = new Thread(() =>
            {
                Thread.Sleep(4000);
                if (Core.CheckForInternetConnection())
                {
                    Random random = new Random();
                    Core.Code = random.Next(100000, 999999).ToString();
                    Core.SendEmail(Core.Code , "LogIn");
                    UseWaitCursor = false;
                    btnLogin.Enabled = true;
                    ShowLoader(false);
                    return;
                }
                else
                {
                    MessageBox.Show("Connection Failure !\nCheck your connection", "No Internet Connection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    UseWaitCursor = false;
                    ShowLoader(false);
                    return;
                }

            });
            SendEmailThread.Start();

        }

        private void Exit(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void CodeResend(object sender, EventArgs e)
        {

           if(Core.code_resend)
            {
                Thread codeThread = new Thread(() => {
                    Thread.Sleep(2000);
                    UseWaitCursor = false;
                    ShowLoader(false);
                    for (int i = 59; i >= 0; i--)
                    {
                        resendlbl.Text = $"We sent Bell-Code to \nmediaunitmrc@gmail.com\n" +
                        $"resend code again {i}S";
                        Thread.Sleep(1000);
                        
                    }
                    resendlbl.Text = "Resend Bell-Code ?";
                    Core.code_resend = true;
                    return;
                });

                Thread Check_ConnectionThread = new Thread(() =>
                {
                    UseWaitCursor = true;
                    Thread.Sleep(2000);
                    if (Core.CheckForInternetConnection())
                    {
                        SendEmail();
                        codeThread.Start();
                        return;
                    }
                    else
                    {
                        resendlbl.Text = "Connection Faliure !";
                        MessageBox.Show("Connection Failure !\nCheck your connection", "No Internet Connection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        UseWaitCursor = false;
                        ShowLoader(false);
                        resendlbl.Text = "Resend Bell-Code ?";
                        return;
                    }

                });
                resendlbl.Text = "Checking internet connection ...";
                Check_ConnectionThread.Start();
                ShowLoader(true);
                Core.code_resend = false;
            }

        }

        private void Log(object sender, EventArgs e)
        {
            ShowLoader(true);
            if(txtCode.Text == Core.Code)
            {
                string token = Core.Get_Token(Core.Code).ToString();
                Settings.Default["token"] = token;
                Settings.Default.Save();
                ShowLoader(false);
                DashBoard ds = new DashBoard();
                ds.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Bell Code !" , "Invalid Credintials" , MessageBoxButtons.OK , MessageBoxIcon.Error);
                ShowLoader(false);
            }
        }
    }
}
