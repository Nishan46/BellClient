namespace Client
{
    partial class Adder
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
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adder));
            this.FormDS = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btnMorning = new Guna.UI2.WinForms.Guna2Button();
            this.lblheader = new System.Windows.Forms.Label();
            this.btnTable = new Guna.UI2.WinForms.Guna2Button();
            this.btnUser = new Guna.UI2.WinForms.Guna2Button();
            this.addpages = new Bunifu.UI.WinForms.BunifuPages();
            this.Morning = new System.Windows.Forms.TabPage();
            this.Sunday = new Guna.UI2.WinForms.Guna2CheckBox();
            this.Saturday = new Guna.UI2.WinForms.Guna2CheckBox();
            this.Friday = new Guna.UI2.WinForms.Guna2CheckBox();
            this.Thursday = new Guna.UI2.WinForms.Guna2CheckBox();
            this.Wednesday = new Guna.UI2.WinForms.Guna2CheckBox();
            this.Tuesday = new Guna.UI2.WinForms.Guna2CheckBox();
            this.Monday = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnTracks = new Guna.UI2.WinForms.Guna2Button();
            this.txtname = new Guna.UI2.WinForms.Guna2TextBox();
            this.timeEnd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.timeStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TimeTable = new System.Windows.Forms.TabPage();
            this.CustomBtns = new System.Windows.Forms.TabPage();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.Drager = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.addpages.SuspendLayout();
            this.Morning.SuspendLayout();
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
            // btnMorning
            // 
            this.btnMorning.BorderColor = System.Drawing.Color.Empty;
            this.btnMorning.BorderRadius = 5;
            this.btnMorning.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMorning.CustomizableEdges.BottomLeft = false;
            this.btnMorning.CustomizableEdges.BottomRight = false;
            this.btnMorning.CustomizableEdges.TopLeft = false;
            this.btnMorning.CustomizableEdges.TopRight = false;
            this.btnMorning.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMorning.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMorning.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMorning.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMorning.FillColor = System.Drawing.Color.Green;
            this.btnMorning.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btnMorning.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMorning.ForeColor = System.Drawing.Color.White;
            this.btnMorning.ImageSize = new System.Drawing.Size(18, 18);
            this.btnMorning.Location = new System.Drawing.Point(7, 53);
            this.btnMorning.Name = "btnMorning";
            this.btnMorning.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnMorning.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btnMorning.PressedDepth = 100;
            this.btnMorning.Size = new System.Drawing.Size(159, 69);
            this.btnMorning.TabIndex = 25;
            this.btnMorning.Text = "MORNING ITEMS";
            this.btnMorning.Click += new System.EventHandler(this.setPage);
            // 
            // lblheader
            // 
            this.lblheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblheader.Font = new System.Drawing.Font("Poppins", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(182)))), ((int)(((byte)(186)))));
            this.lblheader.Location = new System.Drawing.Point(0, 0);
            this.lblheader.Name = "lblheader";
            this.lblheader.Size = new System.Drawing.Size(348, 40);
            this.lblheader.TabIndex = 26;
            this.lblheader.Text = "ADD NEW ITEMS";
            this.lblheader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnTable
            // 
            this.btnTable.BorderColor = System.Drawing.Color.Empty;
            this.btnTable.BorderRadius = 5;
            this.btnTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTable.CustomizableEdges.BottomLeft = false;
            this.btnTable.CustomizableEdges.BottomRight = false;
            this.btnTable.CustomizableEdges.TopLeft = false;
            this.btnTable.CustomizableEdges.TopRight = false;
            this.btnTable.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTable.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTable.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btnTable.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btnTable.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTable.ForeColor = System.Drawing.Color.White;
            this.btnTable.ImageSize = new System.Drawing.Size(18, 18);
            this.btnTable.Location = new System.Drawing.Point(172, 53);
            this.btnTable.Name = "btnTable";
            this.btnTable.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnTable.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btnTable.PressedDepth = 100;
            this.btnTable.Size = new System.Drawing.Size(168, 69);
            this.btnTable.TabIndex = 25;
            this.btnTable.Text = "TIME TABLE";
            this.btnTable.Click += new System.EventHandler(this.setPage);
            // 
            // btnUser
            // 
            this.btnUser.BorderColor = System.Drawing.Color.Empty;
            this.btnUser.BorderRadius = 5;
            this.btnUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUser.CustomizableEdges.BottomLeft = false;
            this.btnUser.CustomizableEdges.BottomRight = false;
            this.btnUser.CustomizableEdges.TopLeft = false;
            this.btnUser.CustomizableEdges.TopRight = false;
            this.btnUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnUser.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btnUser.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.ImageSize = new System.Drawing.Size(18, 18);
            this.btnUser.Location = new System.Drawing.Point(6, 128);
            this.btnUser.Name = "btnUser";
            this.btnUser.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnUser.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btnUser.PressedDepth = 100;
            this.btnUser.Size = new System.Drawing.Size(334, 69);
            this.btnUser.TabIndex = 25;
            this.btnUser.Text = "CUSTOM USER BUTTONS";
            this.btnUser.Click += new System.EventHandler(this.setPage);
            // 
            // addpages
            // 
            this.addpages.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.addpages.AllowTransitions = true;
            this.addpages.Controls.Add(this.Morning);
            this.addpages.Controls.Add(this.TimeTable);
            this.addpages.Controls.Add(this.CustomBtns);
            this.addpages.Location = new System.Drawing.Point(6, 203);
            this.addpages.Multiline = true;
            this.addpages.Name = "addpages";
            this.addpages.Page = this.Morning;
            this.addpages.PageIndex = 0;
            this.addpages.PageName = "Morning";
            this.addpages.PageTitle = "Morning";
            this.addpages.SelectedIndex = 0;
            this.addpages.Size = new System.Drawing.Size(334, 334);
            this.addpages.TabIndex = 27;
            animation1.AnimateOnlyDifferences = false;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.addpages.Transition = animation1;
            this.addpages.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // Morning
            // 
            this.Morning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Morning.Controls.Add(this.Sunday);
            this.Morning.Controls.Add(this.Saturday);
            this.Morning.Controls.Add(this.Friday);
            this.Morning.Controls.Add(this.Thursday);
            this.Morning.Controls.Add(this.Wednesday);
            this.Morning.Controls.Add(this.Tuesday);
            this.Morning.Controls.Add(this.Monday);
            this.Morning.Controls.Add(this.btnAdd);
            this.Morning.Controls.Add(this.btnTracks);
            this.Morning.Controls.Add(this.txtname);
            this.Morning.Controls.Add(this.timeEnd);
            this.Morning.Controls.Add(this.timeStart);
            this.Morning.Controls.Add(this.label4);
            this.Morning.Controls.Add(this.label3);
            this.Morning.Controls.Add(this.label1);
            this.Morning.Controls.Add(this.label2);
            this.Morning.Location = new System.Drawing.Point(4, 4);
            this.Morning.Name = "Morning";
            this.Morning.Padding = new System.Windows.Forms.Padding(3);
            this.Morning.Size = new System.Drawing.Size(326, 308);
            this.Morning.TabIndex = 0;
            this.Morning.Text = "Morning";
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
            this.Sunday.Location = new System.Drawing.Point(248, 194);
            this.Sunday.Name = "Sunday";
            this.Sunday.Size = new System.Drawing.Size(65, 20);
            this.Sunday.TabIndex = 33;
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
            this.Saturday.Location = new System.Drawing.Point(248, 168);
            this.Saturday.Name = "Saturday";
            this.Saturday.Size = new System.Drawing.Size(73, 20);
            this.Saturday.TabIndex = 34;
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
            this.Friday.Location = new System.Drawing.Point(183, 168);
            this.Friday.Name = "Friday";
            this.Friday.Size = new System.Drawing.Size(57, 20);
            this.Friday.TabIndex = 35;
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
            this.Thursday.Location = new System.Drawing.Point(91, 194);
            this.Thursday.Name = "Thursday";
            this.Thursday.Size = new System.Drawing.Size(74, 20);
            this.Thursday.TabIndex = 36;
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
            this.Wednesday.Location = new System.Drawing.Point(91, 168);
            this.Wednesday.Name = "Wednesday";
            this.Wednesday.Size = new System.Drawing.Size(86, 20);
            this.Wednesday.TabIndex = 37;
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
            this.Tuesday.Location = new System.Drawing.Point(14, 194);
            this.Tuesday.Name = "Tuesday";
            this.Tuesday.Size = new System.Drawing.Size(69, 20);
            this.Tuesday.TabIndex = 38;
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
            this.Monday.Location = new System.Drawing.Point(14, 168);
            this.Monday.Name = "Monday";
            this.Monday.Size = new System.Drawing.Size(71, 20);
            this.Monday.TabIndex = 39;
            this.Monday.Text = " Monday";
            this.Monday.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Monday.UncheckedState.BorderRadius = 0;
            this.Monday.UncheckedState.BorderThickness = 0;
            this.Monday.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Monday.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BorderColor = System.Drawing.Color.Empty;
            this.btnAdd.BorderRadius = 5;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.CustomizableEdges.BottomLeft = false;
            this.btnAdd.CustomizableEdges.BottomRight = false;
            this.btnAdd.CustomizableEdges.TopLeft = false;
            this.btnAdd.CustomizableEdges.TopRight = false;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdd.Enabled = false;
            this.btnAdd.FillColor = System.Drawing.Color.Green;
            this.btnAdd.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btnAdd.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.ImageSize = new System.Drawing.Size(18, 18);
            this.btnAdd.Location = new System.Drawing.Point(14, 267);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnAdd.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btnAdd.PressedDepth = 100;
            this.btnAdd.Size = new System.Drawing.Size(299, 36);
            this.btnAdd.TabIndex = 31;
            this.btnAdd.Text = "ADD";
            this.btnAdd.Click += new System.EventHandler(this.AddRecord);
            // 
            // btnTracks
            // 
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
            this.btnTracks.Location = new System.Drawing.Point(14, 225);
            this.btnTracks.Name = "btnTracks";
            this.btnTracks.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnTracks.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(161)))), ((int)(((byte)(62)))));
            this.btnTracks.PressedDepth = 100;
            this.btnTracks.Size = new System.Drawing.Size(299, 36);
            this.btnTracks.TabIndex = 32;
            this.btnTracks.Text = "SELECT TRACK/TRACKS";
            this.btnTracks.Click += new System.EventHandler(this.GetFile);
            // 
            // txtname
            // 
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
            this.txtname.Location = new System.Drawing.Point(62, 54);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.PasswordChar = '\0';
            this.txtname.PlaceholderText = "Morning Songs";
            this.txtname.SelectedText = "";
            this.txtname.Size = new System.Drawing.Size(251, 36);
            this.txtname.TabIndex = 0;
            // 
            // timeEnd
            // 
            this.timeEnd.BorderRadius = 1;
            this.timeEnd.BorderThickness = 1;
            this.timeEnd.Checked = true;
            this.timeEnd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.timeEnd.FillColor = System.Drawing.Color.Black;
            this.timeEnd.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeEnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(182)))), ((int)(((byte)(186)))));
            this.timeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeEnd.Location = new System.Drawing.Point(86, 132);
            this.timeEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.timeEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.timeEnd.Name = "timeEnd";
            this.timeEnd.Size = new System.Drawing.Size(227, 30);
            this.timeEnd.TabIndex = 29;
            this.timeEnd.Value = new System.DateTime(2023, 1, 6, 22, 22, 35, 304);
            // 
            // timeStart
            // 
            this.timeStart.BorderRadius = 1;
            this.timeStart.BorderThickness = 1;
            this.timeStart.Checked = true;
            this.timeStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.timeStart.FillColor = System.Drawing.Color.Black;
            this.timeStart.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(182)))), ((int)(((byte)(186)))));
            this.timeStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeStart.Location = new System.Drawing.Point(86, 96);
            this.timeStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.timeStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.timeStart.Name = "timeStart";
            this.timeStart.Size = new System.Drawing.Size(227, 30);
            this.timeStart.TabIndex = 30;
            this.timeStart.Value = new System.DateTime(2023, 1, 6, 22, 22, 35, 304);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(103, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 22);
            this.label4.TabIndex = 26;
            this.label4.Text = "MORNING ITEMS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Raleway", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(11, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Raleway", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(11, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "End Time :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Raleway", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(11, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Start time :";
            // 
            // TimeTable
            // 
            this.TimeTable.BackColor = System.Drawing.Color.IndianRed;
            this.TimeTable.Location = new System.Drawing.Point(4, 4);
            this.TimeTable.Name = "TimeTable";
            this.TimeTable.Padding = new System.Windows.Forms.Padding(3);
            this.TimeTable.Size = new System.Drawing.Size(326, 308);
            this.TimeTable.TabIndex = 1;
            this.TimeTable.Text = "TimeTable";
            // 
            // CustomBtns
            // 
            this.CustomBtns.BackColor = System.Drawing.Color.DarkOrange;
            this.CustomBtns.Location = new System.Drawing.Point(4, 4);
            this.CustomBtns.Name = "CustomBtns";
            this.CustomBtns.Size = new System.Drawing.Size(326, 308);
            this.CustomBtns.TabIndex = 2;
            this.CustomBtns.Text = "CustomBtns";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(234)))));
            this.btnClose.Image = global::Client.Properties.Resources.Close_White;
            this.btnClose.ImageSize = new System.Drawing.Size(15, 15);
            this.btnClose.Location = new System.Drawing.Point(308, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedColor = System.Drawing.Color.Red;
            this.btnClose.PressedDepth = 100;
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 33;
            this.btnClose.Click += new System.EventHandler(this.Close);
            // 
            // Drager
            // 
            this.Drager.DockIndicatorTransparencyValue = 0.6D;
            this.Drager.DragStartTransparencyValue = 1D;
            this.Drager.TargetControl = this.lblheader;
            this.Drager.UseTransparentDrag = true;
            // 
            // Adder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(348, 527);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.addpages);
            this.Controls.Add(this.lblheader);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnTable);
            this.Controls.Add(this.btnMorning);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Adder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adder";
            this.addpages.ResumeLayout(false);
            this.Morning.ResumeLayout(false);
            this.Morning.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm FormDS;
        private Guna.UI2.WinForms.Guna2Button btnMorning;
        private System.Windows.Forms.Label lblheader;
        private Guna.UI2.WinForms.Guna2Button btnUser;
        private Guna.UI2.WinForms.Guna2Button btnTable;
        private Bunifu.UI.WinForms.BunifuPages addpages;
        private System.Windows.Forms.TabPage Morning;
        private System.Windows.Forms.TabPage TimeTable;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnTracks;
        private Guna.UI2.WinForms.Guna2TextBox txtname;
        private Guna.UI2.WinForms.Guna2DateTimePicker timeEnd;
        private Guna.UI2.WinForms.Guna2DateTimePicker timeStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2DragControl Drager;
        private System.Windows.Forms.TabPage CustomBtns;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2CheckBox Sunday;
        private Guna.UI2.WinForms.Guna2CheckBox Saturday;
        private Guna.UI2.WinForms.Guna2CheckBox Friday;
        private Guna.UI2.WinForms.Guna2CheckBox Thursday;
        private Guna.UI2.WinForms.Guna2CheckBox Wednesday;
        private Guna.UI2.WinForms.Guna2CheckBox Tuesday;
        private Guna.UI2.WinForms.Guna2CheckBox Monday;
    }
}