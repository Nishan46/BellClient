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
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.pnldraw = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnldraw
            // 
            this.pnldraw.AutoScroll = true;
            this.pnldraw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnldraw.Location = new System.Drawing.Point(0, 0);
            this.pnldraw.Name = "pnldraw";
            this.pnldraw.Size = new System.Drawing.Size(630, 528);
            this.pnldraw.TabIndex = 6;
            // 
            // Morning_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.Controls.Add(this.pnldraw);
            this.Name = "Morning_Panel";
            this.Size = new System.Drawing.Size(630, 528);
            this.Load += new System.EventHandler(this.Loading);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Panel pnldraw;
    }
}
