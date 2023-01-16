using Client.BellData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class MorningEditor : Form
    {
        public MorningEditor()
        {
            InitializeComponent();
            TopMost = true;
            foreach (MorningData morningDatas in Core.MorningList)
            {
                if (morningDatas.Id == Core.edit_id)
                {
                    lblname.Text = morningDatas.Name;
                    timeStart.Value = morningDatas.StartTime;
                    timeEnd.Value = morningDatas.EndTime;
                    txtname.Text = morningDatas.Name;
                    Monday.Checked = morningDatas.Monday;
                    Tuesday.Checked = morningDatas.Tuesday;
                    Wednesday.Checked = morningDatas.Wednesday;
                    Thursday.Checked = morningDatas.Thursday;
                    Friday.Checked = morningDatas.Friday;
                    Saturday.Checked = morningDatas.Saturday;
                    Sunday.Checked = morningDatas.Sunday;
                    break;
                }
            }
        }

        string update_path = "";

        private void Close(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void Update(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Are you sure about entered details ? ", " Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Thread updateThread = new Thread(async () =>
                {
                    Thread.Sleep(1000);
                    foreach (MorningData morningData in Core.MorningList)
                    {
                        if (morningData.Id == Core.edit_id)
                        {
                            morningData.StartTime = timeStart.Value;
                            morningData.EndTime = timeEnd.Value;
                            morningData.Name = txtname.Text;
                            morningData.Path = update_path;
                            morningData.LastUpdated = DateTime.Now;
                            morningData.Monday = Monday.Checked;
                            morningData.Tuesday = Tuesday.Checked;
                            morningData.Wednesday = Wednesday.Checked;
                            morningData.Thursday = Thursday.Checked;
                            morningData.Friday = Friday.Checked;
                            morningData.Saturday = Saturday.Checked;
                            morningData.Sunday = Sunday.Checked;
                        }
                        btnUpdate.Text = "Successfully Updated";
                    }
                    btnUpdate.Text = "UPDATE";
                    UseWaitCursor = false;
                    using (StreamWriter sw = new StreamWriter($@"{Core.BaseDir}\Db\Morning.Db.json"))
                    {
                        await sw.WriteAsync(Core.MorningToJson(Core.MorningList));
                        Core.morningData = new MorningData();
                        UseWaitCursor = false;
                        Core.hasToUpdate = true;
                        ActiveForm.Close();
                    }
                });
                UseWaitCursor = true;
                updateThread.Start();
            }
        }
        
        private void Delete(object sender, EventArgs e)
        {
            Thread deleteThread = new Thread( async () =>
            {
                Thread.Sleep(1000);
                foreach(MorningData items in Core.MorningList)
                {
                    if (items.Id == Core.edit_id)
                    {
                        Core.MorningList.Remove(items);
                        btndelete.Text = "Successfully Deleted";
                        using (StreamWriter sw = new StreamWriter($@"{Core.BaseDir}\Db\Morning.Db.json"))
                        {
                            await sw.WriteAsync(Core.MorningToJson(Core.MorningList));
                            Core.morningData = new MorningData();
                            UseWaitCursor = false;
                            Core.hasToUpdate = true;
                            ActiveForm.Close();
                        } 
                        break;
                        
                    }
                }
                return;
            });
            UseWaitCursor = true;
            deleteThread.Start();
        }

        private void SelectTrack(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to add a play list at once ?", "Do you ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                folderBrowserDialog.ShowNewFolderButton = true;
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    update_path = folderBrowserDialog.SelectedPath;
                    btnTracks.Text = folderBrowserDialog.SelectedPath;
                    btnUpdate.Enabled = true;
                }
            }
            else
            {
                OpenFileDialog op = new OpenFileDialog();
                if (op.ShowDialog() == DialogResult.OK)
                {
                    update_path = op.FileName;
                    btnTracks.Text = op.SafeFileName;
                    btnUpdate.Enabled = true;
                }
            }
            
        }
    }
}
