namespace Client
{
    partial class Morning_Panel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblheader = new System.Windows.Forms.Label();
            this.container1 = new Client.Controls.Container();
            this.SuspendLayout();
            // 
            // lblheader
            // 
            this.lblheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblheader.Font = new System.Drawing.Font("Poppins", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(182)))), ((int)(((byte)(186)))));
            this.lblheader.Location = new System.Drawing.Point(0, 0);
            this.lblheader.Name = "lblheader";
            this.lblheader.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblheader.Size = new System.Drawing.Size(630, 68);
            this.lblheader.TabIndex = 5;
            this.lblheader.Text = "MORNING TABLE";
            this.lblheader.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // container1
            // 
            this.container1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.container1.Dock = System.Windows.Forms.DockStyle.Top;
            this.container1.Location = new System.Drawing.Point(0, 68);
            this.container1.Name = "container1";
            this.container1.Size = new System.Drawing.Size(630, 202);
            this.container1.TabIndex = 6;
            // 
            // Morning_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.container1);
            this.Controls.Add(this.lblheader);
            this.Name = "Morning_Panel";
            this.Size = new System.Drawing.Size(630, 528);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblheader;
        private Controls.Container container1;
    }
}
