namespace EventManagementSystem
{
    partial class Organizer__Dashboard
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
        /// 

        private Color primaryBackColor = Color.FromArgb(30, 30, 30);
        private Color primaryForeColor = Color.White;
        private Color primaryHoverColor = Color.FromArgb(50, 50, 50);
        private Color secondaryBackColor = Color.FromArgb(46, 46, 46);
        private Color buttonDefaultBackColor = Color.FromArgb(46, 46, 46);
        private Color buttonPressedBackColor = Color.FromArgb(97, 118, 227);
        private Color buttonHoverBackColor = Color.FromArgb(50, 50, 50);


        private void InitializeComponent()
        {
            mainpanel = new Panel();
            kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            closebtn = new Krypton.Toolkit.KryptonButton();
            kryptonButton2 = new Krypton.Toolkit.KryptonButton();
            kryptonButton3 = new Krypton.Toolkit.KryptonButton();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            PhoneNumber = new Label();
            Dashboard = new Krypton.Toolkit.KryptonButton();
            Email = new Label();
            Username = new Label();
            ManageBookings = new Krypton.Toolkit.KryptonButton();
            pictureBox1 = new PictureBox();
            ManageEvents = new Krypton.Toolkit.KryptonButton();
            ViewEvents = new Krypton.Toolkit.KryptonButton();
            Role = new Label();
            LogOut = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).BeginInit();
            kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // mainpanel
            // 
            mainpanel.BackColor = Color.FromArgb(28, 28, 28);
            mainpanel.Dock = DockStyle.Fill;
            mainpanel.Location = new Point(250, 38);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(1069, 724);
            mainpanel.TabIndex = 5;
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Controls.Add(closebtn);
            kryptonPanel2.Controls.Add(kryptonButton2);
            kryptonPanel2.Controls.Add(kryptonButton3);
            kryptonPanel2.Dock = DockStyle.Top;
            kryptonPanel2.Location = new Point(250, 0);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.Size = new Size(1069, 38);
            kryptonPanel2.StateCommon.Color1 = Color.FromArgb(0, 114, 184);
            kryptonPanel2.StateCommon.Color2 = Color.DeepSkyBlue;
            kryptonPanel2.StateCommon.ColorAngle = 45F;
            kryptonPanel2.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            kryptonPanel2.TabIndex = 4;
            // 
            // closebtn
            // 
            closebtn.Location = new Point(967, 6);
            closebtn.Name = "closebtn";
            closebtn.Size = new Size(26, 26);
            closebtn.StateCommon.Back.Color1 = Color.FromArgb(128, 128, 255);
            closebtn.StateCommon.Back.Color2 = Color.Blue;
            closebtn.StateCommon.Border.Rounding = 20F;
            closebtn.TabIndex = 3;
            closebtn.Values.DropDownArrowColor = Color.Empty;
            closebtn.Values.Text = "";
            closebtn.Click += closebtn_Click;
            // 
            // kryptonButton2
            // 
            kryptonButton2.Location = new Point(999, 6);
            kryptonButton2.Name = "kryptonButton2";
            kryptonButton2.Size = new Size(26, 26);
            kryptonButton2.StateCommon.Back.Color1 = Color.FromArgb(255, 255, 128);
            kryptonButton2.StateCommon.Back.Color2 = Color.Yellow;
            kryptonButton2.StateCommon.Border.Rounding = 20F;
            kryptonButton2.TabIndex = 4;
            kryptonButton2.Values.DropDownArrowColor = Color.Empty;
            kryptonButton2.Values.Text = "";
            kryptonButton2.Click += kryptonButton2_Click;
            // 
            // kryptonButton3
            // 
            kryptonButton3.Location = new Point(1031, 6);
            kryptonButton3.Name = "kryptonButton3";
            kryptonButton3.Size = new Size(26, 26);
            kryptonButton3.StateCommon.Back.Color1 = Color.Red;
            kryptonButton3.StateCommon.Back.Color2 = Color.DarkRed;
            kryptonButton3.StateCommon.Border.Rounding = 20F;
            kryptonButton3.TabIndex = 5;
            kryptonButton3.Values.DropDownArrowColor = Color.Empty;
            kryptonButton3.Values.Text = "";
            kryptonButton3.Click += kryptonButton3_Click;
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(kryptonButton1);
            kryptonPanel1.Controls.Add(PhoneNumber);
            kryptonPanel1.Controls.Add(Dashboard);
            kryptonPanel1.Controls.Add(Email);
            kryptonPanel1.Controls.Add(Username);
            kryptonPanel1.Controls.Add(ManageBookings);
            kryptonPanel1.Controls.Add(pictureBox1);
            kryptonPanel1.Controls.Add(ManageEvents);
            kryptonPanel1.Controls.Add(ViewEvents);
            kryptonPanel1.Controls.Add(Role);
            kryptonPanel1.Controls.Add(LogOut);
            kryptonPanel1.Dock = DockStyle.Left;
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(250, 762);
            kryptonPanel1.StateCommon.Color1 = Color.FromArgb(0, 114, 184);
            kryptonPanel1.StateCommon.Color2 = Color.DeepSkyBlue;
            kryptonPanel1.StateCommon.ColorAngle = 90F;
            kryptonPanel1.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            kryptonPanel1.TabIndex = 3;
            // 
            // kryptonButton1
            // 
            kryptonButton1.Cursor = Cursors.Hand;
            kryptonButton1.Location = new Point(159, 105);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Size = new Size(38, 38);
            kryptonButton1.StateCommon.Back.Color1 = Color.Transparent;
            kryptonButton1.StateCommon.Back.Color2 = Color.Transparent;
            kryptonButton1.StateCommon.Back.Image = Properties.Resources.pen;
            kryptonButton1.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            kryptonButton1.StateCommon.Border.Rounding = 20F;
            kryptonButton1.TabIndex = 0;
            kryptonButton1.Values.DropDownArrowColor = Color.Empty;
            kryptonButton1.Values.Text = "";
            kryptonButton1.Click += kryptonButton1_Click;
            // 
            // PhoneNumber
            // 
            PhoneNumber.BackColor = Color.Transparent;
            PhoneNumber.Font = new Font("Microsoft Sans Serif", 8F);
            PhoneNumber.ForeColor = SystemColors.ControlLightLight;
            PhoneNumber.Location = new Point(3, 256);
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.Size = new Size(250, 27);
            PhoneNumber.TabIndex = 8;
            PhoneNumber.Text = "Phone Number";
            PhoneNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Dashboard
            // 
            Dashboard.ButtonStyle = Krypton.Toolkit.ButtonStyle.NavigatorMini;
            Dashboard.Location = new Point(0, 294);
            Dashboard.Name = "Dashboard";
            Dashboard.OverrideDefault.Back.Color1 = Color.FromArgb(28,28,28);
            Dashboard.OverrideDefault.Back.Color2 = Color.FromArgb(28,28,28);
            Dashboard.OverrideDefault.Border.Color1 = Color.FromArgb(0, 153, 255);
            Dashboard.OverrideDefault.Border.Color2 = Color.FromArgb(0, 153, 255);
            Dashboard.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(0, 153, 255);
            Dashboard.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(0, 153, 255);
            Dashboard.OverrideFocus.Back.Color1 = Color.FromArgb(25, 25, 25);
            Dashboard.OverrideFocus.Back.Color2 = Color.FromArgb(25, 25, 25);
            Dashboard.OverrideFocus.Border.Color1 = Color.FromArgb(0, 122, 204);
            Dashboard.OverrideFocus.Border.Color2 = Color.FromArgb(0, 122, 204);
            Dashboard.Size = new Size(260, 90);
            Dashboard.StateCommon.Back.Color1 = Color.FromArgb(44, 72, 117);
            Dashboard.StateCommon.Back.Color2 = Color.FromArgb(31, 31, 31);
            Dashboard.StateCommon.Border.Color1 = Color.FromArgb(44, 72, 117);
            Dashboard.StateCommon.Border.Color2 = Color.FromArgb(31, 31, 31);
            Dashboard.StateCommon.Border.Rounding = 8F;
            Dashboard.StateCommon.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            Dashboard.StateDisabled.Back.Color1 = Color.FromArgb(44, 72, 117);
            Dashboard.StateDisabled.Back.Color2 = Color.FromArgb(44, 72, 117);
            Dashboard.StateDisabled.Content.ShortText.Color1 = Color.FromArgb(150, 150, 150);
            Dashboard.StateDisabled.Content.ShortText.Color2 = Color.FromArgb(150, 150, 150);
            Dashboard.StateNormal.Back.Color1 = Color.FromArgb(15, 15, 15);
            Dashboard.StateNormal.Back.Color2 = Color.FromArgb(15, 15, 15);
            Dashboard.StateNormal.Border.Color1 = Color.FromArgb(15, 15, 15);
            Dashboard.StateNormal.Border.Color2 = Color.FromArgb(15, 15, 15);
            Dashboard.StateNormal.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            Dashboard.StatePressed.Back.Color1 = Color.FromArgb(46, 46, 46);
            Dashboard.StatePressed.Back.Color2 = Color.FromArgb(46, 46, 46);
            Dashboard.StateTracking.Back.Color1 = Color.FromArgb(60, 60, 60);
            Dashboard.StateTracking.Back.Color2 = Color.FromArgb(60, 60, 60);
            Dashboard.StateTracking.Border.Color1 = Color.FromArgb(0, 153, 255);
            Dashboard.StateTracking.Border.Color2 = Color.FromArgb(0, 153, 255);
            Dashboard.TabIndex = 6;
            Dashboard.Values.DropDownArrowColor = Color.AliceBlue;
            Dashboard.Values.Text = "Dashboard";
            Dashboard.Click += Dashboard_Click;
            // 
            // Email
            // 
            Email.BackColor = Color.Transparent;
            Email.Font = new Font("Microsoft Sans Serif", 8F);
            Email.ForeColor = SystemColors.ControlLightLight;
            Email.Location = new Point(0, 229);
            Email.Name = "Email";
            Email.Size = new Size(250, 27);
            Email.TabIndex = 6;
            Email.Text = "Email";
            Email.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Username
            // 
            Username.BackColor = Color.Transparent;
            Username.Font = new Font("Microsoft Sans Serif", 12F);
            Username.ForeColor = SystemColors.ControlLightLight;
            Username.Location = new Point(3, 163);
            Username.Name = "Username";
            Username.Size = new Size(250, 39);
            Username.TabIndex = 5;
            Username.Text = "UserName";
            Username.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ManageBookings
            // 
            ManageBookings.ButtonStyle = Krypton.Toolkit.ButtonStyle.NavigatorMini;
            ManageBookings.Location = new Point(0, 582);
            ManageBookings.Name = "ManageBookings";
            ManageBookings.OverrideDefault.Back.Color1 = Color.FromArgb(31, 31, 31);
            ManageBookings.OverrideDefault.Back.Color2 = Color.FromArgb(31, 31, 31);
            ManageBookings.OverrideDefault.Border.Color1 = Color.FromArgb(0, 153, 255);
            ManageBookings.OverrideDefault.Border.Color2 = Color.FromArgb(0, 153, 255);
            ManageBookings.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(0, 153, 255);
            ManageBookings.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(0, 153, 255);
            ManageBookings.OverrideFocus.Back.Color1 = Color.FromArgb(25, 25, 25);
            ManageBookings.OverrideFocus.Back.Color2 = Color.FromArgb(25, 25, 25);
            ManageBookings.OverrideFocus.Border.Color1 = Color.FromArgb(0, 122, 204);
            ManageBookings.OverrideFocus.Border.Color2 = Color.FromArgb(0, 122, 204);
            ManageBookings.Size = new Size(260, 90);
            ManageBookings.StateCommon.Back.Color1 = Color.FromArgb(44, 72, 117);
            ManageBookings.StateCommon.Back.Color2 = Color.FromArgb(31, 31, 31);
            ManageBookings.StateCommon.Border.Color1 = Color.FromArgb(44, 72, 117);
            ManageBookings.StateCommon.Border.Color2 = Color.FromArgb(31, 31, 31);
            ManageBookings.StateCommon.Border.Rounding = 8F;
            ManageBookings.StateCommon.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            ManageBookings.StateDisabled.Back.Color1 = Color.FromArgb(44, 72, 117);
            ManageBookings.StateDisabled.Back.Color2 = Color.FromArgb(44, 72, 117);
            ManageBookings.StateDisabled.Content.ShortText.Color1 = Color.FromArgb(150, 150, 150);
            ManageBookings.StateDisabled.Content.ShortText.Color2 = Color.FromArgb(150, 150, 150);
            ManageBookings.StateNormal.Back.Color1 = Color.FromArgb(15, 15, 15);
            ManageBookings.StateNormal.Back.Color2 = Color.FromArgb(15, 15, 15);
            ManageBookings.StateNormal.Border.Color1 = Color.FromArgb(15, 15, 15);
            ManageBookings.StateNormal.Border.Color2 = Color.FromArgb(15, 15, 15);
            ManageBookings.StateNormal.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            ManageBookings.StatePressed.Back.Color1 = Color.FromArgb(46, 46, 46);
            ManageBookings.StatePressed.Back.Color2 = Color.FromArgb(46, 46, 46);
            ManageBookings.StateTracking.Back.Color1 = Color.FromArgb(60, 60, 60);
            ManageBookings.StateTracking.Back.Color2 = Color.FromArgb(60, 60, 60);
            ManageBookings.StateTracking.Border.Color1 = Color.FromArgb(0, 153, 255);
            ManageBookings.StateTracking.Border.Color2 = Color.FromArgb(0, 153, 255);
            ManageBookings.TabIndex = 6;
            ManageBookings.Values.DropDownArrowColor = Color.AliceBlue;
            ManageBookings.Values.Text = "Manage Bookings";
            ManageBookings.Click += ManageBookings_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.profile;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 160);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // ManageEvents
            // 
            ManageEvents.ButtonStyle = Krypton.Toolkit.ButtonStyle.NavigatorMini;
            ManageEvents.Location = new Point(0, 486);
            ManageEvents.Name = "ManageEvents";
            ManageEvents.OverrideDefault.Back.Color1 = Color.FromArgb(31, 31, 31);
            ManageEvents.OverrideDefault.Back.Color2 = Color.FromArgb(31, 31, 31);
            ManageEvents.OverrideDefault.Border.Color1 = Color.FromArgb(0, 153, 255);
            ManageEvents.OverrideDefault.Border.Color2 = Color.FromArgb(0, 153, 255);
            ManageEvents.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(0, 153, 255);
            ManageEvents.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(0, 153, 255);
            ManageEvents.OverrideFocus.Back.Color1 = Color.FromArgb(25, 25, 25);
            ManageEvents.OverrideFocus.Back.Color2 = Color.FromArgb(25, 25, 25);
            ManageEvents.OverrideFocus.Border.Color1 = Color.FromArgb(0, 122, 204);
            ManageEvents.OverrideFocus.Border.Color2 = Color.FromArgb(0, 122, 204);
            ManageEvents.Size = new Size(260, 90);
            ManageEvents.StateCommon.Back.Color1 = Color.FromArgb(44, 72, 117);
            ManageEvents.StateCommon.Back.Color2 = Color.FromArgb(31, 31, 31);
            ManageEvents.StateCommon.Border.Color1 = Color.FromArgb(44, 72, 117);
            ManageEvents.StateCommon.Border.Color2 = Color.FromArgb(31, 31, 31);
            ManageEvents.StateCommon.Border.Rounding = 8F;
            ManageEvents.StateCommon.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            ManageEvents.StateDisabled.Back.Color1 = Color.FromArgb(44, 72, 117);
            ManageEvents.StateDisabled.Back.Color2 = Color.FromArgb(44, 72, 117);
            ManageEvents.StateDisabled.Content.ShortText.Color1 = Color.FromArgb(150, 150, 150);
            ManageEvents.StateDisabled.Content.ShortText.Color2 = Color.FromArgb(150, 150, 150);
            ManageEvents.StateNormal.Back.Color1 = Color.FromArgb(15, 15, 15);
            ManageEvents.StateNormal.Back.Color2 = Color.FromArgb(15, 15, 15);
            ManageEvents.StateNormal.Border.Color1 = Color.FromArgb(15, 15, 15);
            ManageEvents.StateNormal.Border.Color2 = Color.FromArgb(15, 15, 15);
            ManageEvents.StateNormal.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            ManageEvents.StatePressed.Back.Color1 = Color.FromArgb(46, 46, 46);
            ManageEvents.StatePressed.Back.Color2 = Color.FromArgb(46, 46, 46);
            ManageEvents.StateTracking.Back.Color1 = Color.FromArgb(60, 60, 60);
            ManageEvents.StateTracking.Back.Color2 = Color.FromArgb(60, 60, 60);
            ManageEvents.StateTracking.Border.Color1 = Color.FromArgb(0, 153, 255);
            ManageEvents.StateTracking.Border.Color2 = Color.FromArgb(0, 153, 255);
            ManageEvents.TabIndex = 5;
            ManageEvents.Values.DropDownArrowColor = Color.AliceBlue;
            ManageEvents.Values.Text = "Manage Events";
            ManageEvents.Click += ManageEvents_Click;
            // 
            // ViewEvents
            // 
            ViewEvents.ButtonStyle = Krypton.Toolkit.ButtonStyle.NavigatorMini;
            ViewEvents.Location = new Point(0, 390);
            ViewEvents.Name = "ViewEvents";
            ViewEvents.OverrideDefault.Back.Color1 = Color.FromArgb(31, 31, 31);
            ViewEvents.OverrideDefault.Back.Color2 = Color.FromArgb(31, 31, 31);
            ViewEvents.OverrideDefault.Border.Color1 = Color.FromArgb(0, 153, 255);
            ViewEvents.OverrideDefault.Border.Color2 = Color.FromArgb(0, 153, 255);
            ViewEvents.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(0, 153, 255);
            ViewEvents.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(0, 153, 255);
            ViewEvents.OverrideFocus.Back.Color1 = Color.FromArgb(25, 25, 25);
            ViewEvents.OverrideFocus.Back.Color2 = Color.FromArgb(25, 25, 25);
            ViewEvents.OverrideFocus.Border.Color1 = Color.FromArgb(0, 122, 204);
            ViewEvents.OverrideFocus.Border.Color2 = Color.FromArgb(0, 122, 204);
            ViewEvents.Size = new Size(260, 90);
            ViewEvents.StateCommon.Back.Color1 = Color.FromArgb(44, 72, 117);
            ViewEvents.StateCommon.Back.Color2 = Color.FromArgb(31, 31, 31);
            ViewEvents.StateCommon.Border.Color1 = Color.FromArgb(44, 72, 117);
            ViewEvents.StateCommon.Border.Color2 = Color.FromArgb(31, 31, 31);
            ViewEvents.StateCommon.Border.Rounding = 8F;
            ViewEvents.StateCommon.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            ViewEvents.StateDisabled.Back.Color1 = Color.FromArgb(44, 72, 117);
            ViewEvents.StateDisabled.Back.Color2 = Color.FromArgb(44, 72, 117);
            ViewEvents.StateDisabled.Content.ShortText.Color1 = Color.FromArgb(150, 150, 150);
            ViewEvents.StateDisabled.Content.ShortText.Color2 = Color.FromArgb(150, 150, 150);
            ViewEvents.StateNormal.Back.Color1 = Color.FromArgb(15, 15, 15);
            ViewEvents.StateNormal.Back.Color2 = Color.FromArgb(15, 15, 15);
            ViewEvents.StateNormal.Border.Color1 = Color.FromArgb(15, 15, 15);
            ViewEvents.StateNormal.Border.Color2 = Color.FromArgb(15, 15, 15);
            ViewEvents.StateNormal.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            ViewEvents.StatePressed.Back.Color1 = Color.FromArgb(46, 46, 46);
            ViewEvents.StatePressed.Back.Color2 = Color.FromArgb(46, 46, 46);
            ViewEvents.StateTracking.Back.Color1 = Color.FromArgb(60, 60, 60);
            ViewEvents.StateTracking.Back.Color2 = Color.FromArgb(60, 60, 60);
            ViewEvents.StateTracking.Border.Color1 = Color.FromArgb(0, 153, 255);
            ViewEvents.StateTracking.Border.Color2 = Color.FromArgb(0, 153, 255);
            ViewEvents.TabIndex = 5;
            ViewEvents.Values.DropDownArrowColor = Color.AliceBlue;
            ViewEvents.Values.Text = "View Events";
            ViewEvents.Click += ViewEvents_Click;
            // 
            // Role
            // 
            Role.BackColor = Color.Transparent;
            Role.Font = new Font("Microsoft Sans Serif", 8F);
            Role.ForeColor = SystemColors.ControlLightLight;
            Role.Location = new Point(0, 202);
            Role.Name = "Role";
            Role.Size = new Size(250, 27);
            Role.TabIndex = 7;
            Role.Text = "Role";
            Role.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LogOut
            // 
            LogOut.ButtonStyle = Krypton.Toolkit.ButtonStyle.NavigatorMini;
            LogOut.Location = new Point(0, 678);
            LogOut.Name = "LogOut";
            LogOut.OverrideFocus.Back.Color1 = Color.FromArgb(180, 0, 0);
            LogOut.OverrideFocus.Back.Color2 = Color.FromArgb(220, 0, 0);
            LogOut.OverrideFocus.Back.ColorAngle = 45F;
            LogOut.OverrideFocus.Content.ShortText.Color1 = Color.White;
            LogOut.OverrideFocus.Content.ShortText.Color2 = Color.White;
            LogOut.Size = new Size(263, 84);
            LogOut.StateCommon.Back.Color1 = Color.FromArgb(200, 50, 50);
            LogOut.StateCommon.Back.Color2 = Color.FromArgb(255, 0, 0);
            LogOut.StateCommon.Back.ColorAngle = 45F;
            LogOut.StateCommon.Content.ShortText.Color1 = Color.White;
            LogOut.StateCommon.Content.ShortText.Color2 = Color.White;
            LogOut.StateDisabled.Back.Color1 = Color.FromArgb(150, 30, 30);
            LogOut.StateDisabled.Back.Color2 = Color.FromArgb(150, 30, 30);
            LogOut.StateDisabled.Content.ShortText.Color1 = Color.FromArgb(100, 100, 100);
            LogOut.StateDisabled.Content.ShortText.Color2 = Color.FromArgb(100, 100, 100);
            LogOut.StateNormal.Back.Color1 = Color.FromArgb(200, 50, 50);
            LogOut.StateNormal.Back.Color2 = Color.FromArgb(255, 0, 0);
            LogOut.StateNormal.Back.ColorAngle = 45F;
            LogOut.StateNormal.Content.ShortText.Color1 = Color.White;
            LogOut.StateNormal.Content.ShortText.Color2 = Color.White;
            LogOut.StatePressed.Back.Color1 = Color.FromArgb(150, 0, 0);
            LogOut.StatePressed.Back.Color2 = Color.FromArgb(180, 0, 0);
            LogOut.StatePressed.Back.ColorAngle = 45F;
            LogOut.StatePressed.Content.ShortText.Color1 = Color.White;
            LogOut.StatePressed.Content.ShortText.Color2 = Color.White;
            LogOut.TabIndex = 0;
            LogOut.Values.DropDownArrowColor = Color.White;
            LogOut.Values.Text = "LogOut";
            LogOut.Click += LogOut_Click;
            // 
            // Organizer__Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1319, 762);
            Controls.Add(mainpanel);
            Controls.Add(kryptonPanel2);
            Controls.Add(kryptonPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Organizer__Dashboard";
            Text = "Organizer__Dashboard";
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).EndInit();
            kryptonPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainpanel;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonButton Dashboard;
        private Krypton.Toolkit.KryptonButton ViewEvents;
        private Krypton.Toolkit.KryptonButton ManageEvents;
        private Krypton.Toolkit.KryptonButton ManageBookings;
        private Krypton.Toolkit.KryptonButton LogOut;
        private PictureBox pictureBox1;
        private Label Email;
        private Label Role;
        private Label Username;
        private Label PhoneNumber;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonButton closebtn;
        private Krypton.Toolkit.KryptonButton kryptonButton2;
        private Krypton.Toolkit.KryptonButton kryptonButton3;
    }
}