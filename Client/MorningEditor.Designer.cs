namespace Client
{
    partial class MorningEditor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.timeStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.timeEnd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtname = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnTracks = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.Drager = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.btndelete = new Guna.UI2.WinForms.Guna2Button();
            this.Sunday = new Guna.UI2.WinForms.Guna2CheckBox();
            this.Saturday = new Guna.UI2.WinForms.Guna2CheckBox();
            this.Friday = new Guna.UI2.WinForms.Guna2CheckBox();
            this.Thursday = new Guna.UI2.WinForms.Guna2CheckBox();
            this.Wednesday = new Guna.UI2.WinForms.Guna2CheckBox();
            this.Tuesday = new Guna.UI2.WinForms.Guna2CheckBox();
            this.Monday = new Guna.UI2.WinForms.Guna2CheckBox();
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
            this.lblheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblheader.Font = new System.Drawing.Font("Poppins", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(182)))), ((int)(((byte)(186)))));
            this.lblheader.Location = new System.Drawing.Point(0, 0);
            this.lblheader.Name = "lblheader";
            this.lblheader.Size = new System.Drawing.Size(343, 40);
            this.lblheader.TabIndex = 5;
            this.lblheader.Text = "Update Window";
            this.lblheader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Raleway", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(7, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Start time :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Raleway", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(7, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "End Time :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Raleway", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(7, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name :";
            // 
            // lblname
            // 
            this.lblname.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblname.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(161)))), ((int)(((byte)(62)))));
            this.lblname.Location = new System.Drawing.Point(0, 40);
            this.lblname.Name = "lblname";
            this.lblname.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblname.Size = new System.Drawing.Size(343, 48);
            this.lblname.TabIndex = 5;
            this.lblname.Text = "Morning Songs";
            this.lblname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timeStart
            // 
            this.timeStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeStart.BorderRadius = 1;
            this.timeStart.BorderThickness = 1;
            this.timeStart.Checked = true;
            this.timeStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.timeStart.FillColor = System.Drawing.Color.Black;
            this.timeStart.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(182)))), ((int)(((byte)(186)))));
            this.timeStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeStart.Location = new System.Drawing.Point(82, 143);
            this.timeStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.timeStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.timeStart.Name = "timeStart";
            this.timeStart.Size = new System.Drawing.Size(252, 30);
            this.timeStart.TabIndex = 8;
            this.timeStart.Value = new System.DateTime(2023, 1, 6, 22, 22, 35, 304);
            // 
            // timeEnd
            // 
            this.timeEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeEnd.BorderRadius = 1;
            this.timeEnd.BorderThickness = 1;
            this.timeEnd.Checked = true;
            this.timeEnd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.timeEnd.FillColor = System.Drawing.Color.Black;
            this.timeEnd.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeEnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(182)))), ((int)(((byte)(186)))));
            this.timeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeEnd.Location = new System.Drawing.Point(82, 179);
            this.timeEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.timeEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.timeEnd.Name = "timeEnd";
            this.timeEnd.Size = new System.Drawing.Size(252, 30);
            this.timeEnd.TabIndex = 8;
            this.timeEnd.Value = new System.DateTime(2023, 1, 6, 22, 22, 35, 304);
            // 
            // txtname
            // 
            this.txtname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtname.BorderRadius = 1;
            this.txtname.BorderThickness = 0;
            this.txtname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtname.DefaultText = "";
            this.txtname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtname.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txtname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtname.Font = new System.Drawing.Font("Raleway", 8.999999F, System.Drawing.FontStyle.Bold);
            this.txtname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(182)))), ((int)(((byte)(186)))));
            this.txtname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtname.Location = new System.Drawing.Point(58, 101);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.PasswordChar = '\0';
            this.txtname.PlaceholderText = "Morning Songs";
            this.txtname.SelectedText = "";
            this.txtname.Size = new System.Drawing.Size(276, 36);
            this.txtname.TabIndex = 0;
            // 
            // btnTracks
            // 
            this.btnTracks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTracks.BorderColor = System.Drawing.Color.Empty;
            this.btnTracks.BorderRadius = 5;
            this.btnTracks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTracks.CustomizableEdges.BottomLeft = false;
            this.btnTracks.CustomizableEdges.BottomRight = false;
            this.btnTracks.CustomizableEdges.TopLeft = false;
            this.btnTracks.CustomizableEdges.TopRight = false;
            this.btnTracks.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTracks.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTracks.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTracks.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTracks.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnTracks.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btnTracks.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTracks.ForeColor = System.Drawing.Color.White;
            this.btnTracks.ImageSize = new System.Drawing.Size(18, 18);
            this.btnTracks.Location = new System.Drawing.Point(10, 293);
            this.btnTracks.Name = "btnTracks";
            this.btnTracks.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnTracks.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(161)))), ((int)(((byte)(62)))));
            this.btnTracks.PressedDepth = 100;
            this.btnTracks.Size = new System.Drawing.Size(324, 36);
            this.btnTracks.TabIndex = 24;
            this.btnTracks.Text = "SELECT TRACK/TRACKS";
            this.btnTracks.Click += new System.EventHandler(this.SelectTrack);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BorderColor = System.Drawing.Color.Empty;
            this.btnUpdate.BorderRadius = 5;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.CustomizableEdges.BottomLeft = false;
            this.btnUpdate.CustomizableEdges.BottomRight = false;
            this.btnUpdate.CustomizableEdges.TopLeft = false;
            this.btnUpdate.CustomizableEdges.TopRight = false;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FillColor = System.Drawing.Color.Green;
            this.btnUpdate.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btnUpdate.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.ImageSize = new System.Drawing.Size(18, 18);
            this.btnUpdate.Location = new System.Drawing.Point(10, 335);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnUpdate.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btnUpdate.PressedDepth = 100;
            this.btnUpdate.Size = new System.Drawing.Size(324, 36);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.Click += new System.EventHandler(this.Update);
            // 
            // guna2Button4
            // 
            this.guna2Button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.guna2Button4.Location = new System.Drawing.Point(303, 0);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.PressedColor = System.Drawing.Color.Red;
            this.guna2Button4.PressedDepth = 100;
            this.guna2Button4.Size = new System.Drawing.Size(40, 40);
            this.guna2Button4.TabIndex = 25;
            this.guna2Button4.Click += new System.EventHandler(this.Close);
            // 
            // Drager
            // 
            this.Drager.DockIndicatorTransparencyValue = 0.6D;
            this.Drager.DragStartTransparencyValue = 1D;
            this.Drager.TargetControl = this.lblheader;
            this.Drager.UseTransparentDrag = true;
            // 
            // btndelete
            // 
            this.btndelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btndelete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btndelete.BorderRadius = 1;
            this.btndelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndelete.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btndelete.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btndelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btndelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btndelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btndelete.Font = new System.Drawing.Font("Raleway Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btndelete.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btndelete.Location = new System.Drawing.Point(10, 377);
            this.btndelete.Name = "btndelete";
            this.btndelete.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btndelete.PressedDepth = 100;
            this.btndelete.Size = new System.Drawing.Size(324, 36);
            this.btndelete.TabIndex = 26;
            this.btndelete.Text = "DELETE";
            this.btndelete.Click += new System.EventHandler(this.Delete);
            // 
            // Sunday
            // 
            this.Sunday.AutoSize = true;
            this.Sunday.BackColor = System.Drawing.Color.Transparent;
            this.Sunday.Checked = true;
            this.Sunday.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(161)))), ((int)(((byte)(62)))));
            this.Sunday.CheckedState.BorderRadius = 0;
            this.Sunday.CheckedState.BorderThickness = 0;
            this.Sunday.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(161)))), ((int)(((byte)(62)))));
            this.Sunday.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Sunday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sunday.Font = new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sunday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(182)))), ((int)(((byte)(186)))));
            this.Sunday.Location = new System.Drawing.Point(267, 251);
            this.Sunday.Name = "Sunday";
            this.Sunday.Size = new System.Drawing.Size(65, 20);
            this.Sunday.TabIndex = 27;
            this.Sunday.Text = "Sunday";
            this.Sunday.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Sunday.UncheckedState.BorderRadius = 0;
            this.Sunday.UncheckedState.BorderThickness = 0;
            this.Sunday.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Sunday.UseVisualStyleBackColor = false;
            // 
            // Saturday
            // 
            this.Saturday.AutoSize = true;
            this.Saturday.BackColor = System.Drawing.Color.Transparent;
            this.Saturday.Checked = true;
            this.Saturday.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(161)))), ((int)(((byte)(62)))));
            this.Saturday.CheckedState.BorderRadius = 0;
            this.Saturday.CheckedState.BorderThickness = 0;
            this.Saturday.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(161)))), ((int)(((byte)(62)))));
            this.Saturday.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Saturday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Saturday.Font = new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Saturday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(182)))), ((int)(((byte)(186)))));
            this.Saturday.Location = new System.Drawing.Point(267, 225);
            this.Saturday.Name = "Saturday";
            this.Saturday.Size = new System.Drawing.Size(73, 20);
            this.Saturday.TabIndex = 28;
            this.Saturday.Text = "Saturday";
            this.Saturday.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Saturday.UncheckedState.BorderRadius = 0;
            this.Saturday.UncheckedState.BorderThickness = 0;
            this.Saturday.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Saturday.UseVisualStyleBackColor = false;
            // 
            // Friday
            // 
            this.Friday.AutoSize = true;
            this.Friday.BackColor = System.Drawing.Color.Transparent;
            this.Friday.Checked = true;
            this.Friday.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.Friday.CheckedState.BorderRadius = 0;
            this.Friday.CheckedState.BorderThickness = 0;
            this.Friday.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.Friday.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Friday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Friday.Font = new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Friday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(182)))), ((int)(((byte)(186)))));
            this.Friday.Location = new System.Drawing.Point(89, 251);
            this.Friday.Name = "Friday";
            this.Friday.Size = new System.Drawing.Size(57, 20);
            this.Friday.TabIndex = 29;
            this.Friday.Text = "Friday";
            this.Friday.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Friday.UncheckedState.BorderRadius = 0;
            this.Friday.UncheckedState.BorderThickness = 0;
            this.Friday.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Friday.UseVisualStyleBackColor = false;
            // 
            // Thursday
            // 
            this.Thursday.AutoSize = true;
            this.Thursday.BackColor = System.Drawing.Color.Transparent;
            this.Thursday.Checked = true;
            this.Thursday.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.Thursday.CheckedState.BorderRadius = 0;
            this.Thursday.CheckedState.BorderThickness = 0;
            this.Thursday.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.Thursday.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Thursday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Thursday.Font = new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thursday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(182)))), ((int)(((byte)(186)))));
            this.Thursday.Location = new System.Drawing.Point(12, 251);
            this.Thursday.Name = "Thursday";
            this.Thursday.Size = new System.Drawing.Size(74, 20);
            this.Thursday.TabIndex = 30;
            this.Thursday.Text = "Thursday";
            this.Thursday.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Thursday.UncheckedState.BorderRadius = 0;
            this.Thursday.UncheckedState.BorderThickness = 0;
            this.Thursday.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Thursday.UseVisualStyleBackColor = false;
            // 
            // Wednesday
            // 
            this.Wednesday.AutoSize = true;
            this.Wednesday.BackColor = System.Drawing.Color.Transparent;
            this.Wednesday.Checked = true;
            this.Wednesday.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.Wednesday.CheckedState.BorderRadius = 0;
            this.Wednesday.CheckedState.BorderThickness = 0;
            this.Wednesday.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.Wednesday.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Wednesday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Wednesday.Font = new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wednesday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(182)))), ((int)(((byte)(186)))));
            this.Wednesday.Location = new System.Drawing.Point(164, 225);
            this.Wednesday.Name = "Wednesday";
            this.Wednesday.Size = new System.Drawing.Size(86, 20);
            this.Wednesday.TabIndex = 31;
            this.Wednesday.Text = "Wednesday";
            this.Wednesday.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Wednesday.UncheckedState.BorderRadius = 0;
            this.Wednesday.UncheckedState.BorderThickness = 0;
            this.Wednesday.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Wednesday.UseVisualStyleBackColor = false;
            // 
            // Tuesday
            // 
            this.Tuesday.AutoSize = true;
            this.Tuesday.BackColor = System.Drawing.Color.Transparent;
            this.Tuesday.Checked = true;
            this.Tuesday.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.Tuesday.CheckedState.BorderRadius = 0;
            this.Tuesday.CheckedState.BorderThickness = 0;
            this.Tuesday.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.Tuesday.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Tuesday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tuesday.Font = new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tuesday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(182)))), ((int)(((byte)(186)))));
            this.Tuesday.Location = new System.Drawing.Point(89, 225);
            this.Tuesday.Name = "Tuesday";
            this.Tuesday.Size = new System.Drawing.Size(69, 20);
            this.Tuesday.TabIndex = 32;
            this.Tuesday.Text = "Tuesday";
            this.Tuesday.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Tuesday.UncheckedState.BorderRadius = 0;
            this.Tuesday.UncheckedState.BorderThickness = 0;
            this.Tuesday.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Tuesday.UseVisualStyleBackColor = false;
            // 
            // Monday
            // 
            this.Monday.AutoSize = true;
            this.Monday.BackColor = System.Drawing.Color.Transparent;
            this.Monday.Checked = true;
            this.Monday.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.Monday.CheckedState.BorderRadius = 0;
            this.Monday.CheckedState.BorderThickness = 0;
            this.Monday.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.Monday.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Monday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Monday.Font = new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Monday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(182)))), ((int)(((byte)(186)))));
            this.Monday.Location = new System.Drawing.Point(12, 225);
            this.Monday.Name = "Monday";
            this.Monday.Size = new System.Drawing.Size(71, 20);
            this.Monday.TabIndex = 33;
            this.Monday.Text = " Monday";
            this.Monday.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Monday.UncheckedState.BorderRadius = 0;
            this.Monday.UncheckedState.BorderThickness = 0;
            this.Monday.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Monday.UseVisualStyleBackColor = false;
            // 
            // MorningEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(343, 422);
            this.Controls.Add(this.Sunday);
            this.Controls.Add(this.Saturday);
            this.Controls.Add(this.Friday);
            this.Controls.Add(this.Thursday);
            this.Controls.Add(this.Wednesday);
            this.Controls.Add(this.Tuesday);
            this.Controls.Add(this.Monday);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.guna2Button4);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnTracks);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.timeEnd);
            this.Controls.Add(this.timeStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblheader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MorningEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm FormDS;
        private System.Windows.Forms.Label lblheader;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblname;
        private Guna.UI2.WinForms.Guna2DateTimePicker timeStart;
        private Guna.UI2.WinForms.Guna2DateTimePicker timeEnd;
        private Guna.UI2.WinForms.Guna2TextBox txtname;
        private Guna.UI2.WinForms.Guna2Button btnTracks;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2DragControl Drager;
        private Guna.UI2.WinForms.Guna2Button btndelete;
        private Guna.UI2.WinForms.Guna2CheckBox Sunday;
        private Guna.UI2.WinForms.Guna2CheckBox Saturday;
        private Guna.UI2.WinForms.Guna2CheckBox Friday;
        private Guna.UI2.WinForms.Guna2CheckBox Thursday;
        private Guna.UI2.WinForms.Guna2CheckBox Wednesday;
        private Guna.UI2.WinForms.Guna2CheckBox Tuesday;
        private Guna.UI2.WinForms.Guna2CheckBox Monday;
    }
}