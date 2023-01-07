namespace Client
{
    partial class Gear
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
            this.label2 = new System.Windows.Forms.Label();
            this.checkRegs = new Guna.UI2.WinForms.Guna2CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Monday = new Guna.UI2.WinForms.Guna2CheckBox();
            this.Tuesday = new Guna.UI2.WinForms.Guna2CheckBox();
            this.Wednesday = new Guna.UI2.WinForms.Guna2CheckBox();
            this.Thursday = new Guna.UI2.WinForms.Guna2CheckBox();
            this.Friday = new Guna.UI2.WinForms.Guna2CheckBox();
            this.timeShut = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.lblmsg = new System.Windows.Forms.Label();
            this.lblQLogOut = new System.Windows.Forms.Label();
            this.txtCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLogOut = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.Drager = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.txtstatus = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.Saturday = new Guna.UI2.WinForms.Guna2CheckBox();
            this.Sunday = new Guna.UI2.WinForms.Guna2CheckBox();
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
            this.lblheader.Location = new System.Drawing.Point(8, 0);
            this.lblheader.Name = "lblheader";
            this.lblheader.Size = new System.Drawing.Size(280, 50);
            this.lblheader.TabIndex = 4;
            this.lblheader.Text = "Settings";
            this.lblheader.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Raleway", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Preferances";
            // 
            // checkRegs
            // 
            this.checkRegs.AutoSize = true;
            this.checkRegs.Checked = true;
            this.checkRegs.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(161)))), ((int)(((byte)(62)))));
            this.checkRegs.CheckedState.BorderRadius = 0;
            this.checkRegs.CheckedState.BorderThickness = 0;
            this.checkRegs.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(161)))), ((int)(((byte)(62)))));
            this.checkRegs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkRegs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkRegs.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Bold);
            this.checkRegs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(182)))), ((int)(((byte)(186)))));
            this.checkRegs.Location = new System.Drawing.Point(11, 65);
            this.checkRegs.Name = "checkRegs";
            this.checkRegs.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkRegs.Size = new System.Drawing.Size(170, 25);
            this.checkRegs.TabIndex = 6;
            this.checkRegs.Text = "Start with windows";
            this.checkRegs.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkRegs.UncheckedState.BorderRadius = 0;
            this.checkRegs.UncheckedState.BorderThickness = 0;
            this.checkRegs.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkRegs.CheckedChanged += new System.EventHandler(this.setStartupValues);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Raleway", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(12, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Securtiy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(182)))), ((int)(((byte)(186)))));
            this.label4.Location = new System.Drawing.Point(11, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Shut Down Computer";
            // 
            // Monday
            // 
            this.Monday.AutoSize = true;
            this.Monday.Checked = true;
            this.Monday.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.Monday.CheckedState.BorderRadius = 0;
            this.Monday.CheckedState.BorderThickness = 0;
            this.Monday.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.Monday.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Monday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Monday.Font = new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Monday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(182)))), ((int)(((byte)(186)))));
            this.Monday.Location = new System.Drawing.Point(26, 169);
            this.Monday.Name = "Monday";
            this.Monday.Size = new System.Drawing.Size(71, 20);
            this.Monday.TabIndex = 6;
            this.Monday.Text = " Monday";
            this.Monday.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Monday.UncheckedState.BorderRadius = 0;
            this.Monday.UncheckedState.BorderThickness = 0;
            this.Monday.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Monday.CheckedChanged += new System.EventHandler(this.setUpShutDownDates);
            // 
            // Tuesday
            // 
            this.Tuesday.AutoSize = true;
            this.Tuesday.Checked = true;
            this.Tuesday.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.Tuesday.CheckedState.BorderRadius = 0;
            this.Tuesday.CheckedState.BorderThickness = 0;
            this.Tuesday.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.Tuesday.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Tuesday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tuesday.Font = new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tuesday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(182)))), ((int)(((byte)(186)))));
            this.Tuesday.Location = new System.Drawing.Point(26, 192);
            this.Tuesday.Name = "Tuesday";
            this.Tuesday.Size = new System.Drawing.Size(69, 20);
            this.Tuesday.TabIndex = 6;
            this.Tuesday.Text = "Tuesday";
            this.Tuesday.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Tuesday.UncheckedState.BorderRadius = 0;
            this.Tuesday.UncheckedState.BorderThickness = 0;
            this.Tuesday.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Tuesday.CheckedChanged += new System.EventHandler(this.setUpShutDownDates);
            // 
            // Wednesday
            // 
            this.Wednesday.AutoSize = true;
            this.Wednesday.Checked = true;
            this.Wednesday.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.Wednesday.CheckedState.BorderRadius = 0;
            this.Wednesday.CheckedState.BorderThickness = 0;
            this.Wednesday.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.Wednesday.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Wednesday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Wednesday.Font = new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wednesday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(182)))), ((int)(((byte)(186)))));
            this.Wednesday.Location = new System.Drawing.Point(26, 215);
            this.Wednesday.Name = "Wednesday";
            this.Wednesday.Size = new System.Drawing.Size(86, 20);
            this.Wednesday.TabIndex = 6;
            this.Wednesday.Text = "Wednesday";
            this.Wednesday.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Wednesday.UncheckedState.BorderRadius = 0;
            this.Wednesday.UncheckedState.BorderThickness = 0;
            this.Wednesday.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Wednesday.CheckedChanged += new System.EventHandler(this.setUpShutDownDates);
            // 
            // Thursday
            // 
            this.Thursday.AutoSize = true;
            this.Thursday.Checked = true;
            this.Thursday.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.Thursday.CheckedState.BorderRadius = 0;
            this.Thursday.CheckedState.BorderThickness = 0;
            this.Thursday.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.Thursday.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Thursday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Thursday.Font = new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thursday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(182)))), ((int)(((byte)(186)))));
            this.Thursday.Location = new System.Drawing.Point(115, 169);
            this.Thursday.Name = "Thursday";
            this.Thursday.Size = new System.Drawing.Size(74, 20);
            this.Thursday.TabIndex = 6;
            this.Thursday.Text = "Thursday";
            this.Thursday.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Thursday.UncheckedState.BorderRadius = 0;
            this.Thursday.UncheckedState.BorderThickness = 0;
            this.Thursday.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Thursday.CheckedChanged += new System.EventHandler(this.setUpShutDownDates);
            // 
            // Friday
            // 
            this.Friday.AutoSize = true;
            this.Friday.Checked = true;
            this.Friday.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.Friday.CheckedState.BorderRadius = 0;
            this.Friday.CheckedState.BorderThickness = 0;
            this.Friday.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.Friday.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Friday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Friday.Font = new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Friday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(182)))), ((int)(((byte)(186)))));
            this.Friday.Location = new System.Drawing.Point(115, 192);
            this.Friday.Name = "Friday";
            this.Friday.Size = new System.Drawing.Size(57, 20);
            this.Friday.TabIndex = 6;
            this.Friday.Text = "Friday";
            this.Friday.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Friday.UncheckedState.BorderRadius = 0;
            this.Friday.UncheckedState.BorderThickness = 0;
            this.Friday.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Friday.CheckedChanged += new System.EventHandler(this.setUpShutDownDates);
            // 
            // timeShut
            // 
            this.timeShut.BorderRadius = 5;
            this.timeShut.BorderThickness = 1;
            this.timeShut.Checked = true;
            this.timeShut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.timeShut.FillColor = System.Drawing.Color.Black;
            this.timeShut.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeShut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(182)))), ((int)(((byte)(186)))));
            this.timeShut.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeShut.Location = new System.Drawing.Point(178, 117);
            this.timeShut.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.timeShut.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.timeShut.Name = "timeShut";
            this.timeShut.Size = new System.Drawing.Size(143, 30);
            this.timeShut.TabIndex = 7;
            this.timeShut.Value = new System.DateTime(2023, 1, 6, 22, 22, 35, 304);
            this.timeShut.ValueChanged += new System.EventHandler(this.ChangeShutDownTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Raleway", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(12, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Interrupts";
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.Font = new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmsg.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblmsg.Location = new System.Drawing.Point(12, 262);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(288, 32);
            this.lblmsg.TabIndex = 4;
            this.lblmsg.Text = "You\'ve logged in as mrcollegebellsystem@gmail.com\r\nand this is your primary accou" +
    "nt.";
            // 
            // lblQLogOut
            // 
            this.lblQLogOut.AutoSize = true;
            this.lblQLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblQLogOut.Font = new System.Drawing.Font("Raleway", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblQLogOut.Location = new System.Drawing.Point(14, 321);
            this.lblQLogOut.Name = "lblQLogOut";
            this.lblQLogOut.Size = new System.Drawing.Size(75, 21);
            this.lblQLogOut.TabIndex = 4;
            this.lblQLogOut.Text = "LogOut ?";
            this.lblQLogOut.Click += new System.EventHandler(this.PrepareLogOut);
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.Color.Transparent;
            this.txtCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.txtCode.BorderRadius = 4;
            this.txtCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCode.DefaultText = "";
            this.txtCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.txtCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.txtCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCode.Enabled = false;
            this.txtCode.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.txtCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCode.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(182)))), ((int)(((byte)(186)))));
            this.txtCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCode.Location = new System.Drawing.Point(115, 312);
            this.txtCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCode.MaxLength = 6;
            this.txtCode.Name = "txtCode";
            this.txtCode.PasswordChar = '\0';
            this.txtCode.PlaceholderText = "Bell-Code";
            this.txtCode.SelectedText = "";
            this.txtCode.Size = new System.Drawing.Size(100, 41);
            this.txtCode.TabIndex = 8;
            this.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnLogOut.BorderRadius = 5;
            this.btnLogOut.BorderThickness = 1;
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnLogOut.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnLogOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnLogOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogOut.Enabled = false;
            this.btnLogOut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnLogOut.Font = new System.Drawing.Font("Raleway Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btnLogOut.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btnLogOut.Location = new System.Drawing.Point(221, 311);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnLogOut.PressedDepth = 100;
            this.btnLogOut.Size = new System.Drawing.Size(100, 41);
            this.btnLogOut.TabIndex = 9;
            this.btnLogOut.Text = "LOGOUT";
            this.btnLogOut.Click += new System.EventHandler(this.LogOut);
            // 
            // guna2Button4
            // 
            this.guna2Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2Button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(234)))));
            this.guna2Button4.Image = global::Client.Properties.Resources.Close_White;
            this.guna2Button4.ImageSize = new System.Drawing.Size(15, 15);
            this.guna2Button4.Location = new System.Drawing.Point(296, 0);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.PressedColor = System.Drawing.Color.Red;
            this.guna2Button4.PressedDepth = 100;
            this.guna2Button4.Size = new System.Drawing.Size(40, 40);
            this.guna2Button4.TabIndex = 10;
            this.guna2Button4.Click += new System.EventHandler(this.HideThis);
            // 
            // Drager
            // 
            this.Drager.DockIndicatorTransparencyValue = 0.6D;
            this.Drager.DragStartTransparencyValue = 1D;
            this.Drager.TargetControl = this.lblheader;
            this.Drager.UseTransparentDrag = true;
            // 
            // txtstatus
            // 
            this.txtstatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtstatus.Font = new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.txtstatus.Location = new System.Drawing.Point(0, 357);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Padding = new System.Windows.Forms.Padding(10, 0, 0, 5);
            this.txtstatus.Size = new System.Drawing.Size(338, 40);
            this.txtstatus.TabIndex = 4;
            this.txtstatus.Text = "For Logout, first click Red \"LogOut ?\" text and then we will sent you an email wi" +
    "th Logout Bell-Code.";
            this.txtstatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbltime
            // 
            this.lbltime.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.ForeColor = System.Drawing.Color.DimGray;
            this.lbltime.Location = new System.Drawing.Point(178, 147);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(143, 17);
            this.lbltime.TabIndex = 4;
            this.lbltime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Saturday
            // 
            this.Saturday.AutoSize = true;
            this.Saturday.Checked = true;
            this.Saturday.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.Saturday.CheckedState.BorderRadius = 0;
            this.Saturday.CheckedState.BorderThickness = 0;
            this.Saturday.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.Saturday.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Saturday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Saturday.Font = new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Saturday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(182)))), ((int)(((byte)(186)))));
            this.Saturday.Location = new System.Drawing.Point(245, 169);
            this.Saturday.Name = "Saturday";
            this.Saturday.Size = new System.Drawing.Size(73, 20);
            this.Saturday.TabIndex = 6;
            this.Saturday.Text = "Saturday";
            this.Saturday.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Saturday.UncheckedState.BorderRadius = 0;
            this.Saturday.UncheckedState.BorderThickness = 0;
            this.Saturday.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Saturday.CheckedChanged += new System.EventHandler(this.setUpShutDownDates);
            // 
            // Sunday
            // 
            this.Sunday.AutoSize = true;
            this.Sunday.Checked = true;
            this.Sunday.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.Sunday.CheckedState.BorderRadius = 0;
            this.Sunday.CheckedState.BorderThickness = 0;
            this.Sunday.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.Sunday.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Sunday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sunday.Font = new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sunday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(182)))), ((int)(((byte)(186)))));
            this.Sunday.Location = new System.Drawing.Point(245, 192);
            this.Sunday.Name = "Sunday";
            this.Sunday.Size = new System.Drawing.Size(65, 20);
            this.Sunday.TabIndex = 6;
            this.Sunday.Text = "Sunday";
            this.Sunday.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Sunday.UncheckedState.BorderRadius = 0;
            this.Sunday.UncheckedState.BorderThickness = 0;
            this.Sunday.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Sunday.CheckedChanged += new System.EventHandler(this.setUpShutDownDates);
            // 
            // Gear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(338, 397);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2Button4);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.timeShut);
            this.Controls.Add(this.Sunday);
            this.Controls.Add(this.Saturday);
            this.Controls.Add(this.Friday);
            this.Controls.Add(this.Thursday);
            this.Controls.Add(this.Wednesday);
            this.Controls.Add(this.Tuesday);
            this.Controls.Add(this.Monday);
            this.Controls.Add(this.checkRegs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtstatus);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.lblQLogOut);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblheader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Gear";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gear";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm FormDS;
        private System.Windows.Forms.Label lblheader;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2CheckBox checkRegs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2CheckBox Friday;
        private Guna.UI2.WinForms.Guna2CheckBox Thursday;
        private Guna.UI2.WinForms.Guna2CheckBox Wednesday;
        private Guna.UI2.WinForms.Guna2CheckBox Tuesday;
        private Guna.UI2.WinForms.Guna2CheckBox Monday;
        private Guna.UI2.WinForms.Guna2DateTimePicker timeShut;
        private Guna.UI2.WinForms.Guna2TextBox txtCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.Label lblQLogOut;
        private Guna.UI2.WinForms.Guna2Button btnLogOut;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2DragControl Drager;
        private System.Windows.Forms.Label txtstatus;
        private System.Windows.Forms.Label lbltime;
        private Guna.UI2.WinForms.Guna2CheckBox Sunday;
        private Guna.UI2.WinForms.Guna2CheckBox Saturday;
    }
}