using System;
using System.Drawing;
using System.Windows.Forms;
using Client.Properties;
using System.Diagnostics;
using System.Threading;
using Guna.UI2.WinForms;

namespace Client
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
            btnMorning.PerformClick();
            Thread ShutdownThread = new Thread(() =>
            {
                while (true)
                {
                    Thread.Sleep(1000);
                    if (Convert.ToDateTime(Core.ReadDefaults("ShutDownTime")).ToLongTimeString() == DateTime.Now.ToLongTimeString() && Core.IsShutDownDay(DateTime.Now.DayOfWeek.ToString()))
                    {
                        lblheader.Font = new Font(Core.setPoppins().Families[0], 9, lblheader.Font.Style);
                        lblheader.ForeColor = Color.Red;
                        lblheader.Text = "Preparing to Shutdown ...";
                        Thread.Sleep(1000);
                        for (int i = 59; i >=0; i--)
                        {
                            if (i <= 5)
                            {
                                lblheader.Text = $"Shutdown in {i}s";
                            }
                            else
                            {
                                lblheader.Text = $"Shutdown in {i}s Click here to cancel";
                                lblheader.Cursor = Cursors.Hand;
                                if (Core.cancel_shutown)
                                {
                                    Core.cancel_shutown = false;
                                    lblheader.ForeColor = Color.Gainsboro;
                                    lblheader.Cursor = Cursors.Default;
                                    lblheader.Font = new Font(Core.setRaleway().Families[0], 16, lblheader.Font.Style);
                                    lblheader.Text = "MRC Bell System";
                                    break;
                                }
                            }
                            if (i == 0)
                            {
                                Thread.Sleep(1000);
                                lblheader.ForeColor = Color.FromArgb(30, 136, 229);
                                lblheader.Text = "See you !";
                                Thread.Sleep(1000);
                                var psi = new ProcessStartInfo("shutdown", "/s /t 1");
                                psi.CreateNoWindow = true;
                                psi.UseShellExecute = false;
                                Thread.Sleep(1000);
                                Process.Start(psi);
                                Process.GetCurrentProcess().Kill();
                            }
                            Thread.Sleep(1000);
                            Core.shutdown_timer = i;
                        }
                    }
                }
            });
            /*ShutdownThread.Start();*/
            foreach (Control controls in Controls)
            {
                controls.Font = new Font(Core.setRaleway().Families[0], controls.Font.Size, controls.Font.Style);
                if(controls.Name == "pnlslider")
                {
                    foreach(Control buttons in controls.Controls)
                    {
                        buttons.Font = new Font(Core.setRaleway().Families[0], buttons.Font.Size, buttons.Font.Style);
                    }
                }
            }

            lblmail.Font = new Font(Core.setRaleway().Families[0], lblmail.Font.Size, lblmail.Font.Style);
            lblheader.Font = new Font(Core.setRaleway().Families[0], lblheader.Font.Size, lblheader.Font.Style);
            
            checkConnection();

            System.Windows.Forms.Timer timeViewr = new System.Windows.Forms.Timer();
            timeViewr.Enabled = true;
            timeViewr.Interval = 1000;
            timeViewr.Tick += ViewDateTime;
        }


        private bool is_minimized = false;
        private void checkConnection()
        {
            Thread Connected = new Thread(() =>
            {
                while(true)
                {
                    if (Core.CheckForInternetConnection())
                    {
                        mailcontainer.BorderColor = Color.FromArgb(128, 255, 128);
                    }
                    else
                    {
                        mailcontainer.BorderColor = Color.Red;
                    }
                    Thread.Sleep(5000);
                }
            });
            Connected.Start();
        }
        private void ViewDateTime(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToShortTimeString();
            lblDate.Text = DateTime.Now.ToLongDateString().ToUpper();
            lblDay.Text = DateTime.Now.DayOfWeek.ToString().ToUpper();
        }
        private void Exit(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }
        private void Minimize_Dash(object sender, EventArgs e)
        {
            Thread minimizeThread = new Thread(() =>
            {
                double i = 1.0;
                while(i >= 0)
                {
                    Opacity = i;
                    i = i - 0.1;
                    Thread.Sleep(5);
                }
                if(WindowState == FormWindowState.Normal) WindowState = FormWindowState.Minimized;
                is_minimized = true;
                return;
                
            });
            minimizeThread.Start();
        }
        private void showNormal_Dash(object sender, EventArgs e)
        {
            if (is_minimized && WindowState == FormWindowState.Normal)
            {
                Thread showNormalThread = new Thread(() =>
                {
                    double i = 0;
                    while (i <= 1)
                    {
                        i = i + 0.1;
                        if (i == 1.0)
                        {
                            Opacity = 1;
                        }
                        else
                        {
                            Opacity = i;
                        }
                        Thread.Sleep(40);
                    }
                    is_minimized = false;
                    return;
                });
                showNormalThread.Start();
            }
        }
        private void SelectedBtn(object sender, EventArgs e)
        {
            var btn = (Guna2Button)sender;
            Guna2Button[] buttons = {btnsch , btnMorning , btnManual };
            foreach(Guna2Button items in buttons)
            {
                if(items.Name == btn.Name)
                {
                    btn.FillColor = Color.FromArgb(30, 136, 229);
                }
                else
                {
                    items.FillColor = Color.FromArgb(32, 33, 32);
                }
            }

            if(btn == btnMorning)
            {
                PageContain.SetPage(Morning);
            }
            else if(btn == btnManual)
            {
                PageContain.SetPage(CustomUser);
            }
        }

        private void showSettings(object sender, EventArgs e)
        {
            Gear gr = new Gear();
            gr.Show();
        }

        private void CancelShutDown(object sender, EventArgs e)
        {
            if(Core.shutdown_timer != 0 && Core.shutdown_timer >5)
            {
                Core.cancel_shutown = true;
            }
        }

        private void showAdd(object sender, EventArgs e)
        {
            Adder adder = new Adder();
            adder.Show();
            
        }

        private void Maximize_Dash(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {

                WindowState = FormWindowState.Maximized;
            }
            else
            {

                WindowState = FormWindowState.Normal;
            }
        }
    }
}
