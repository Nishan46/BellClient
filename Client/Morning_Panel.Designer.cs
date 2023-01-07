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
            this.SuspendLayout();
            // 
            // lblheader
            // 
            this.lblheader.Font = new System.Drawing.Font("Poppins", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(182)))), ((int)(((byte)(186)))));
            this.lblheader.Location = new System.Drawing.Point(13, 15);
            this.lblheader.Name = "lblheader";
            this.lblheader.Size = new System.Drawing.Size(280, 50);
            this.lblheader.TabIndex = 5;
            this.lblheader.Text = "MORNING TABLE";
            this.lblheader.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Morning_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.lblheader);
            this.Name = "Morning_Panel";
            this.Size = new System.Drawing.Size(608, 528);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblheader;
    }
}
