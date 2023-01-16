using Client.BellData;
using Client.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Client
{
    public partial class Morning_Panel : UserControl
    {
        
        public Morning_Panel()
        {
            InitializeComponent();
            
           
        }

        private void Updates_Tick(object sender, EventArgs e)
        {
            if (Core.hasToUpdate)
            {

                pnldraw.Controls.Clear();
                for (int i = Core.MorningList.Count-1; i >=0 ; i--)
                {
                    MorningData morningData = Core.MorningList[i];
                    Controls.Container container = new Controls.Container();
                    container.lblheader.Text = morningData.Name;
                    container.lblstartTime.Text = morningData.StartTime.ToLongTimeString();
                    container.lblendTime.Text = morningData.EndTime.ToLongTimeString();
                    container.Monday.Checked = morningData.Monday;
                    container.Tuesday.Checked = morningData.Tuesday;
                    container.Wednesday.Checked = morningData.Wednesday;
                    container.Thursday.Checked = morningData.Thursday;
                    container.Friday.Checked = morningData.Friday;
                    container.Saturday.Checked = morningData.Saturday;
                    container.Sunday.Checked = morningData.Sunday;
                    container.lastChecked = morningData.LastUpdated;
                    container.path = morningData.Path;
                    container.Dock = DockStyle.Top;
                    pnldraw.Controls.Add(container);
                }
                Core.hasToUpdate = false;
            }

        }

        private void Loading(object sender, EventArgs e)
        {
            pnldraw.Controls.Clear();
            for(int i = Core.MorningList.Count -1; i>=0; i--)
            {
                MorningData morningData = Core.MorningList[i];
                Controls.Container container = new Controls.Container();
                container.lblheader.Text = morningData.Name;
                container.lblstartTime.Text = morningData.StartTime.ToLongTimeString();
                container.lblendTime.Text = morningData.EndTime.ToLongTimeString();
                container.Monday.Checked = morningData.Monday;
                container.Tuesday.Checked = morningData.Tuesday;
                container.Wednesday.Checked = morningData.Wednesday;
                container.Thursday.Checked = morningData.Thursday;
                container.Friday.Checked = morningData.Friday;
                container.Saturday.Checked = morningData.Saturday;
                container.Sunday.Checked = morningData.Sunday;
                container.lastChecked = morningData.LastUpdated;
                container.path = morningData.Path;
                container.Dock = DockStyle.Top;
                pnldraw.Controls.Add(container);
            }
        }
    }
}