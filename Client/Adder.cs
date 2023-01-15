using Client.BellData;
using Guna.UI2.WinForms;
using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Client
{
    public partial class Adder : Form
    {
        public Adder()
        {
            InitializeComponent();
            TopMost = true;
            btnMorning.PerformClick();
        }

        private void Close(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void setPage(object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;
            if (btn == btnMorning)
            {
                addpages.SetPage(Morning);
            }
            else if (btn == btnTable)
            {
                addpages.SetPage(TimeTable);
            }
            else if (btn == btnUser)
            {
                addpages.SetPage(CustomBtns);
            }
        }

        private void AddRecord(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure about entered details ? " ," Sure?" , MessageBoxButtons.YesNo , MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Thread addThread = new Thread(async () =>
                {
                    Thread.Sleep(1000);
                    Core.MorningList.Add(Core.morningData);
                    using (StreamWriter sw = new StreamWriter($@"{Core.BaseDir}\Db\Morning.Db.json"))
                    {
                        await sw.WriteAsync(Core.MorningToJson(Core.MorningList));
                        Core.morningData = new MorningData();
                        UseWaitCursor = false;
                        btnAdd.Text = "Successfully Added";
                        Core.hasToUpdate = true;
                        ActiveForm.Close();
                    }
                });
                btnAdd.Text = "ADD";
                UseWaitCursor = true;
                addThread.Start();
            }
        }
        private void GetFile(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to add a play list at once ?" ,"Do you ?", MessageBoxButtons.YesNo , MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                folderBrowserDialog.ShowNewFolderButton = true;
                if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    Core.morningData.Path = folderBrowserDialog.SelectedPath;
                    btnTracks.Text = folderBrowserDialog.SelectedPath;
                    btnAdd.Enabled = true;
                }
            }
            else
            {
                OpenFileDialog op = new OpenFileDialog();
                if (op.ShowDialog() == DialogResult.OK)
                {
                    Core.morningData.Path = op.FileName;
                    btnTracks.Text = op.SafeFileName;
                    btnAdd.Enabled = true;
                }
            }

            Core.morningData.StartTime = timeStart.Value;
            Core.morningData.EndTime = timeEnd.Value;
            Core.morningData.Name = txtname.Text;
            Core.morningData.LastUpdated = DateTime.Now;
            Core.morningData.Id = $"{DateTime.Now.ToString("MMyyyy")} {DateTime.Now} {Core.Random.Next(100000, 999999)}";
            Core.morningData.Monday = Monday.Checked;
            Core.morningData.Tuesday = Tuesday.Checked;
            Core.morningData.Wednesday = Wednesday.Checked;
            Core.morningData.Thursday = Thursday.Checked;
            Core.morningData.Friday = Friday.Checked;
            Core.morningData.Saturday = Saturday.Checked;
            Core.morningData.Sunday = Sunday.Checked;
        }
    }
}


















/*btnTracks.Text = op.SafeFileName;
FileStream fs = new FileStream(op.FileName,
                               FileMode.Open,
                               FileAccess.Read);
BinaryReader br = new BinaryReader(fs);
long numBytes = new FileInfo(op.FileName).Length;
byte[] buff = br.ReadBytes((int)numBytes);
Core.Base64oftrack = Convert.ToBase64String(buff);*/