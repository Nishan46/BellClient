
using Client.Data;
using Client.Properties;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Gear : Form
    {
        public Gear()
        {
            InitializeComponent();
            this.TopMost = true;
            CheckStartupValues();
            checkShutDownDays();
            AcceptButton = btnLogOut;
            timeShut.Value = Convert.ToDateTime(Core.ReadDefaults("ShutDownTime"));
        }

        private void HideThis(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void ChangeShutDownTime(object sender, EventArgs e)
        {       
            Core.WriteDefaults("ShutDownTime", timeShut.Value.ToString());
        }
        private void setStartupValues(object sender, EventArgs e)
        {
            if (checkRegs.Checked)
            {
                Core.registryKey.SetValue("MRC Bell System V", Application.ExecutablePath);
            }
            else
            {
                Core.registryKey.DeleteValue("MRC Bell System V", false);
            }
        }
        private void CheckStartupValues()
        {
            if (Core.registryKey.GetValue("MRC Bell System V") == null)
            {
                checkRegs.Checked = false;
            }
            else
            {
                checkRegs.Checked = true;
            }
        }
        private void setUpShutDownDates(object sender, EventArgs e)
        {
            Guna2CheckBox checkbox = (Guna2CheckBox)sender;
            Core.WriteDefaults(checkbox.Name, checkbox.Checked);
        }
        private void checkShutDownDays()
        {
            Guna2CheckBox[] boxes = { Monday, Tuesday, Wednesday, Thursday, Friday };
            foreach (var items in boxes)
            {
                items.Checked = Convert.ToBoolean(Core.ReadDefaults(items.Name));
            }   
        }

        private void LogOutFunction(bool value)
        {
            txtCode.Enabled = value;
            btnLogOut.Enabled = value;
        }

        private void PrepareLogOut(object sender, EventArgs e)
        {
            Thread PrepareThread = new Thread(() =>
            {
                Thread.Sleep(3000);
                if (Core.CheckForInternetConnection())
                {
                    txtstatus.Text = "Sending Logout Code ...";
                    Thread.Sleep(2000);
                    Random random = new Random();
                    Core.Code = random.Next(100000, 999999).ToString();
                    Core.SendEmail(Core.Code , "LogOut");
                    UseWaitCursor = false;
                    txtstatus.Text = "We Sent Logout Bell-Code to your Email.";
                    LogOutFunction(true);
                    return;
                }
                else
                {
                    txtstatus.Text = "Connection Faliure try again by clicking 'LogOut ?' text";
                    UseWaitCursor = false;
                    LogOutFunction(false);
                    return;
                }
            });
            PrepareThread.Start();
            txtstatus.Text = "Checking internet connection ...";
            UseWaitCursor = true;

        }

        private void LogOut(object sender, EventArgs e)
        {
            Thread logOutThread = new Thread(() =>
            {
                Thread.Sleep(2000);
                if (Core.Code == txtCode.Text)
                {
                    Settings.Default.token = Core.Get_Token("LOGGED_OUT").ToString();
                    Settings.Default.Save();
                    txtstatus.Text = "Successfully Logged out ! Restarting application ...";
                    Thread.Sleep(2000);
                    UseWaitCursor = false;
                    Application.Restart();
                    Process.GetCurrentProcess().Kill();
                    return;
                }
                else
                {
                    txtstatus.Text = "Invalid Credintials ! if you didn't get Bell-Code you can simply click 'LogOut ?' text again...";
                    UseWaitCursor = false;
                    return;
                }
            });
            txtstatus.Text = "Logging Out ...";
            logOutThread.Start();
        }
    }
}
