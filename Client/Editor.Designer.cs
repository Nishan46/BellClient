namespace Client
{
    partial class Editor
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.FormDS = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.lblheader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FormDS
            // 
            this.FormDS.AnimateWindow = true;
            this.FormDS.AnimationInterval = 200;
            this.FormDS.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.G2402080114300C350C1C0D2412390C1404.G243B3E2E39012726;
            this.FormDS.BorderRadius = 5;
            this.FormDS.ContainerControl = this;
            this.FormDS.DockIndicatorTransparencyValue = 0.6D;
            this.FormDS.DragStartTransparencyValue = 1D;
            this.FormDS.TransparentWhileDrag = true;
            // 
            // lblheader
            // 
            this.lblheader.Font = new System.Drawing.Font("Poppins", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(182)))), ((int)(((byte)(186)))));
            this.lblheader.Location = new System.Drawing.Point(1, 0);
            this.lblheader.Name = "lblheader";
            this.lblheader.Size = new System.Drawing.Size(280, 50);
            this.lblheader.TabIndex = 5;
            this.lblheader.Text = "Update Window";
            this.lblheader.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(300, 288);
            this.Controls.Add(this.lblheader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Editor";
            this.Text = "Editor";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm FormDS;
        private System.Windows.Forms.Label lblheader;
    }
}