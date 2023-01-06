namespace Client
{
    partial class LogIn
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
            this.logo = new System.Windows.Forms.PictureBox();
            this.CloseBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.FormDS = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.headertxt = new System.Windows.Forms.Label();
            this.txtCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Drager = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.resendlbl = new System.Windows.Forms.Label();
            this.loader = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.Image = global::Client.Properties.Resources.sch;
            this.logo.Location = new System.Drawing.Point(85, 42);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(133, 124);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // CloseBtn
            // 
            this.CloseBtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBtn.HoverState.ImageSize = new System.Drawing.Size(26, 26);
            this.CloseBtn.Image = global::Client.Properties.Resources.Close_White;
            this.CloseBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.CloseBtn.ImageRotate = 0F;
            this.CloseBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.CloseBtn.Location = new System.Drawing.Point(238, 14);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.PressedState.ImageSize = new System.Drawing.Size(27, 27);
            this.CloseBtn.Size = new System.Drawing.Size(30, 30);
            this.CloseBtn.TabIndex = 1;
            this.CloseBtn.Click += new System.EventHandler(this.Exit);
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
            // headertxt
            // 
            this.headertxt.BackColor = System.Drawing.Color.Transparent;
            this.headertxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headertxt.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headertxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(182)))), ((int)(((byte)(186)))));
            this.headertxt.Location = new System.Drawing.Point(0, 0);
            this.headertxt.Name = "headertxt";
            this.headertxt.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.headertxt.Size = new System.Drawing.Size(292, 47);
            this.headertxt.TabIndex = 2;
            this.headertxt.Text = "Bell System";
            this.headertxt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtCode
            // 
            this.txtCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtCode.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.txtCode.BorderThickness = 0;
            this.txtCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCode.DefaultText = "";
            this.txtCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCode.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCode.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(182)))), ((int)(((byte)(186)))));
            this.txtCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCode.Location = new System.Drawing.Point(51, 183);
            this.txtCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCode.MaxLength = 6;
            this.txtCode.Name = "txtCode";
            this.txtCode.PasswordChar = '\0';
            this.txtCode.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtCode.PlaceholderText = "Bell-Code";
            this.txtCode.SelectedText = "";
            this.txtCode.Size = new System.Drawing.Size(200, 64);
            this.txtCode.TabIndex = 4;
            this.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLogin
            // 
            this.btnLogin.BorderRadius = 2;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(161)))), ((int)(((byte)(62)))));
            this.btnLogin.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(81, 253);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(140, 35);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnLogin.Click += new System.EventHandler(this.Log);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 318);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.CloseBtn);
            this.panel2.Controls.Add(this.headertxt);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 47);
            this.panel2.TabIndex = 6;
            // 
            // Drager
            // 
            this.Drager.DockIndicatorTransparencyValue = 0.6D;
            this.Drager.DragStartTransparencyValue = 1D;
            this.Drager.TargetControl = this.headertxt;
            this.Drager.UseTransparentDrag = true;
            // 
            // resendlbl
            // 
            this.resendlbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.resendlbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resendlbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.resendlbl.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resendlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(182)))), ((int)(((byte)(186)))));
            this.resendlbl.Location = new System.Drawing.Point(0, 318);
            this.resendlbl.Name = "resendlbl";
            this.resendlbl.Padding = new System.Windows.Forms.Padding(5);
            this.resendlbl.Size = new System.Drawing.Size(293, 92);
            this.resendlbl.TabIndex = 11;
            this.resendlbl.Text = "Resend Bell-Code ?";
            this.resendlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.resendlbl.Click += new System.EventHandler(this.CodeResend);
            // 
            // loader
            // 
            this.loader.AnimationSpeed = 2F;
            this.loader.BackColor = System.Drawing.Color.Transparent;
            this.loader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.loader.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.loader.ForeColor = System.Drawing.Color.DimGray;
            this.loader.Location = new System.Drawing.Point(81, 169);
            this.loader.Minimum = 0;
            this.loader.Name = "loader";
            this.loader.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.loader.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.loader.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.loader.Size = new System.Drawing.Size(140, 140);
            this.loader.TabIndex = 12;
            this.loader.Value = 60;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(293, 410);
            this.Controls.Add(this.loader);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.resendlbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private Guna.UI2.WinForms.Guna2ImageButton CloseBtn;
        private Guna.UI2.WinForms.Guna2BorderlessForm FormDS;
        private Guna.UI2.WinForms.Guna2TextBox txtCode;
        private System.Windows.Forms.Label headertxt;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2DragControl Drager;
        private System.Windows.Forms.Label resendlbl;
        private Guna.UI2.WinForms.Guna2CircleProgressBar loader;
    }
}