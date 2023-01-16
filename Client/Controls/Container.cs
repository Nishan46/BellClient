using Bunifu.UI.WinForms;
using Client.BellData;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Client.Controls
{
    public partial class Container : UserControl
    {
        public DateTime lastChecked;
        public string path;

        WindowsMediaPlayer player = new WindowsMediaPlayer();
        public Container()
        {
            InitializeComponent();
            System.Windows.Forms.Timer ticker = new System.Windows.Forms.Timer();
            ticker.Enabled = true;
            ticker.Interval = 1000;
            ticker.Tick += Ticking;
            
        }

        private void Ticking(object sender, EventArgs e)
        {
            try
            {
                seekBar.Value = Convert.ToInt32((player.controls.currentPosition / player.controls.currentItem.duration * 100));
                lblcp.Text = player.controls.currentPositionString;
                lblduration.Text = player.controls.currentItem.durationString;
            }
            catch (Exception)
            {

            }
            btnEdit.Enabled = Core.can_edit;
            btnEdit.Update();
            btnEdit.Refresh();
            if(lblendTime.Text == DateTime.Now.ToLongTimeString())
            {
                StopTrack(vol , player);
            }

            if(player.playState == WMPPlayState.wmppsPlaying)
            {
                Core.can_edit = false;
                btnEdit.Enabled = false;
            }
            else
            {
                Core.can_edit = true;
            }
            
        }

        private void Edit(object sender, EventArgs e)
        {
            foreach(MorningData morningData in Core.MorningList)
            {
                if(morningData.Name == lblheader.Text)
                {
                    Core.edit_id = morningData.Id;
                }
            }
            MorningEditor morningEditor = new MorningEditor();
            morningEditor.Show();
        }

        private void Play(object sender, EventArgs e)
        {
            player = new WindowsMediaPlayer();
            player.URL = path;
            player.controls.play();
            player.settings.volume = vol.Value;
        }

        private void ChangeVolume(object sender, ScrollEventArgs e)
        {
            player.settings.volume = e.NewValue;
        }

        private void vol_ValueChanged(object sender, EventArgs e)
        {
            player.settings.volume = vol.Value;
        }

        private void StopTrack(Guna2TrackBar bar , WindowsMediaPlayer players)
        {
            Thread volDownThread = new Thread(() =>
            {
                for (int i = bar.Maximum; i >= 0; i--)
                {
                    bar.Value = i;
                    Thread.Sleep(50);
                    if(i == 0)
                    {
                        players.controls.stop();
                    }
                }
                return;
            });
            volDownThread.Start();
        }
        private void Stop(object sender, EventArgs e)
        {
            if(player.playState == WMPPlayState.wmppsPlaying)
            {
                player.controls.stop();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
        }
    }
}
