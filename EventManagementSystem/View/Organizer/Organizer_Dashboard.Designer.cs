namespace EventManagementSystem
{
    partial class Organizer_Dashboard
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
            CloseBtn = new Krypton.Toolkit.KryptonButton();
            MinmaxBtn = new Krypton.Toolkit.KryptonButton();
            RestoreBtn = new Krypton.Toolkit.KryptonButton();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            ManageBookings = new Krypton.Toolkit.KryptonButton();
            PhoneNumber = new Label();
            Email = new Label();
            Role = new Label();
            Username = new Label();
            BookingLogs = new Krypton.Toolkit.KryptonButton();
            ManageEvents = new Krypton.Toolkit.KryptonButton();
            EventLogs = new Krypton.Toolkit.KryptonButton();
            pictureBox1 = new PictureBox();
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
            mainpanel.Location = new Point(250, 40);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(1069, 722);
            mainpanel.TabIndex = 5;
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Controls.Add(CloseBtn);
            kryptonPanel2.Controls.Add(MinmaxBtn);
            kryptonPanel2.Controls.Add(RestoreBtn);
            kryptonPanel2.Dock = DockStyle.Top;
            kryptonPanel2.Location = new Point(250, 0);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.Size = new Size(1069, 40);
            kryptonPanel2.StateCommon.Color1 = Color.FromArgb(0, 114, 184);
            kryptonPanel2.StateCommon.Color2 = Color.DeepSkyBlue;
            kryptonPanel2.StateCommon.ColorAngle = 45F;
            kryptonPanel2.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            kryptonPanel2.TabIndex = 4;
            kryptonPanel2.MouseDown += mouse_down;
            kryptonPanel2.MouseMove += mouse_move;
            // 
            // CloseBtn
            // 
            CloseBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CloseBtn.Location = new Point(1027, 9);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.OverrideDefault.Back.Color1 = Color.FromArgb(255, 100, 90);
            CloseBtn.OverrideDefault.Back.Color2 = Color.FromArgb(255, 70, 70);
            CloseBtn.OverrideDefault.Border.Color1 = Color.FromArgb(255, 100, 90);
            CloseBtn.OverrideDefault.Border.Color2 = Color.FromArgb(255, 70, 70);
            CloseBtn.Size = new Size(26, 25);
            CloseBtn.StateCommon.Back.Color1 = Color.FromArgb(255, 100, 90);
            CloseBtn.StateCommon.Back.Color2 = Color.FromArgb(255, 70, 70);
            CloseBtn.StateCommon.Border.Color1 = Color.FromArgb(255, 100, 90);
            CloseBtn.StateCommon.Border.Color2 = Color.FromArgb(255, 70, 70);
            CloseBtn.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            CloseBtn.StateCommon.Border.Rounding = 20F;
            CloseBtn.StateTracking.Back.Color1 = Color.FromArgb(230, 85, 85);
            CloseBtn.StateTracking.Back.Color2 = Color.FromArgb(200, 60, 60);
            CloseBtn.TabIndex = 3;
            CloseBtn.Values.DropDownArrowColor = Color.Empty;
            CloseBtn.Values.Text = "";
            CloseBtn.Click += CloseBtn_Click;
            // 
            // MinmaxBtn
            // 
            MinmaxBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MinmaxBtn.Location = new Point(986, 9);
            MinmaxBtn.Name = "MinmaxBtn";
            MinmaxBtn.OverrideDefault.Back.Color1 = Color.FromArgb(255, 189, 46);
            MinmaxBtn.OverrideDefault.Back.Color2 = Color.FromArgb(255, 174, 40);
            MinmaxBtn.OverrideDefault.Border.Color1 = Color.FromArgb(255, 189, 46);
            MinmaxBtn.OverrideDefault.Border.Color2 = Color.FromArgb(255, 174, 40);
            MinmaxBtn.Size = new Size(26, 25);
            MinmaxBtn.StateCommon.Back.Color1 = Color.FromArgb(255, 189, 46);
            MinmaxBtn.StateCommon.Back.Color2 = Color.FromArgb(255, 174, 40);
            MinmaxBtn.StateCommon.Border.Color1 = Color.FromArgb(255, 189, 46);
            MinmaxBtn.StateCommon.Border.Color2 = Color.FromArgb(255, 174, 40);
            MinmaxBtn.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            MinmaxBtn.StateCommon.Border.Rounding = 20F;
            MinmaxBtn.StateTracking.Back.Color1 = Color.FromArgb(224, 162, 30);
            MinmaxBtn.StateTracking.Back.Color2 = Color.FromArgb(224, 145, 24);
            MinmaxBtn.TabIndex = 5;
            MinmaxBtn.Values.DropDownArrowColor = Color.Empty;
            MinmaxBtn.Values.Text = "";
            MinmaxBtn.Click += MinmaxBtn_Click;
            // 
            // RestoreBtn
            // 
            RestoreBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RestoreBtn.Location = new Point(947, 9);
            RestoreBtn.Name = "RestoreBtn";
            RestoreBtn.OverrideDefault.Back.Color1 = Color.FromArgb(40, 200, 64);
            RestoreBtn.OverrideDefault.Back.Color2 = Color.FromArgb(34, 180, 58);
            RestoreBtn.OverrideDefault.Border.Color1 = Color.FromArgb(40, 200, 64);
            RestoreBtn.OverrideDefault.Border.Color2 = Color.FromArgb(34, 180, 58);
            RestoreBtn.Size = new Size(26, 25);
            RestoreBtn.StateCommon.Back.Color1 = Color.FromArgb(40, 200, 64);
            RestoreBtn.StateCommon.Back.Color2 = Color.FromArgb(34, 180, 58);
            RestoreBtn.StateCommon.Border.Color1 = Color.FromArgb(40, 200, 64);
            RestoreBtn.StateCommon.Border.Color2 = Color.FromArgb(34, 180, 58);
            RestoreBtn.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            RestoreBtn.StateCommon.Border.Rounding = 20F;
            RestoreBtn.StateTracking.Back.Color1 = Color.FromArgb(36, 161, 51);
            RestoreBtn.StateTracking.Back.Color2 = Color.FromArgb(30, 140, 45);
            RestoreBtn.TabIndex = 4;
            RestoreBtn.Values.DropDownArrowColor = Color.Empty;
            RestoreBtn.Values.Text = "";
            RestoreBtn.Click += RestoreBtn_Click;
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(ManageBookings);
            kryptonPanel1.Controls.Add(PhoneNumber);
            kryptonPanel1.Controls.Add(Email);
            kryptonPanel1.Controls.Add(Role);
            kryptonPanel1.Controls.Add(Username);
            kryptonPanel1.Controls.Add(BookingLogs);
            kryptonPanel1.Controls.Add(ManageEvents);
            kryptonPanel1.Controls.Add(EventLogs);
            kryptonPanel1.Controls.Add(pictureBox1);
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
            // ManageBookings
            // 
            ManageBookings.ButtonStyle = Krypton.Toolkit.ButtonStyle.NavigatorMini;
            ManageBookings.Location = new Point(-1, 581);
            ManageBookings.Name = "ManageBookings";
            ManageBookings.OverrideDefault.Back.Color1 = Color.FromArgb(28, 28, 28);
            ManageBookings.OverrideDefault.Back.Color2 = Color.FromArgb(28, 28, 28);
            ManageBookings.OverrideDefault.Border.Color1 = Color.FromArgb(0, 153, 255);
            ManageBookings.OverrideDefault.Border.Color2 = Color.FromArgb(0, 153, 255);
            ManageBookings.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(0, 153, 255);
            ManageBookings.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(0, 153, 255);
            ManageBookings.OverrideDefault.Content.ShortText.ColorAngle = 45F;
            ManageBookings.OverrideDefault.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            ManageBookings.OverrideFocus.Back.Color1 = Color.FromArgb(25, 25, 25);
            ManageBookings.OverrideFocus.Back.Color2 = Color.FromArgb(25, 25, 25);
            ManageBookings.OverrideFocus.Border.Color1 = Color.FromArgb(0, 122, 204);
            ManageBookings.OverrideFocus.Border.Color2 = Color.FromArgb(0, 122, 204);
            ManageBookings.Size = new Size(251, 95);
            ManageBookings.StateCommon.Back.Color1 = Color.FromArgb(0, 90, 156);
            ManageBookings.StateCommon.Back.Color2 = Color.FromArgb(0, 63, 107);
            ManageBookings.StateCommon.Back.ColorAngle = 45F;
            ManageBookings.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            ManageBookings.StateCommon.Border.Color1 = Color.FromArgb(0, 63, 107);
            ManageBookings.StateCommon.Border.Color2 = Color.FromArgb(0, 90, 156);
            ManageBookings.StateCommon.Content.ShortText.Color1 = Color.White;
            ManageBookings.StateCommon.Content.ShortText.Color2 = Color.White;
            ManageBookings.StatePressed.Back.Color1 = Color.FromArgb(0, 63, 107);
            ManageBookings.StatePressed.Back.Color2 = Color.FromArgb(0, 42, 71);
            ManageBookings.StatePressed.Border.Color1 = Color.FromArgb(0, 42, 71);
            ManageBookings.StatePressed.Border.Color2 = Color.FromArgb(0, 63, 107);
            ManageBookings.StatePressed.Content.ShortText.Color1 = Color.White;
            ManageBookings.StatePressed.Content.ShortText.Color2 = Color.White;
            ManageBookings.StateTracking.Back.Color1 = Color.FromArgb(0, 111, 184);
            ManageBookings.StateTracking.Back.Color2 = Color.FromArgb(0, 77, 128);
            ManageBookings.StateTracking.Border.Color1 = Color.FromArgb(0, 111, 184);
            ManageBookings.StateTracking.Border.Color2 = Color.FromArgb(0, 77, 128);
            ManageBookings.StateTracking.Content.ShortText.Color1 = Color.White;
            ManageBookings.StateTracking.Content.ShortText.Color2 = Color.White;
            ManageBookings.TabIndex = 5;
            ManageBookings.Values.DropDownArrowColor = Color.AliceBlue;
            ManageBookings.Values.Text = "Manage Bookings";
            ManageBookings.Click += ManageBookings_Click_1;
            // 
            // PhoneNumber
            // 
            PhoneNumber.BackColor = Color.Transparent;
            PhoneNumber.Location = new Point(-1, 255);
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.Size = new Size(245, 25);
            PhoneNumber.TabIndex = 24;
            PhoneNumber.Text = "label4";
            PhoneNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Email
            // 
            Email.BackColor = Color.Transparent;
            Email.Location = new Point(-1, 226);
            Email.Name = "Email";
            Email.Size = new Size(245, 25);
            Email.TabIndex = 23;
            Email.Text = "label3";
            Email.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Role
            // 
            Role.BackColor = Color.Transparent;
            Role.Location = new Point(-1, 196);
            Role.Name = "Role";
            Role.Size = new Size(245, 25);
            Role.TabIndex = 22;
            Role.Text = "label2";
            Role.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Username
            // 
            Username.BackColor = Color.Transparent;
            Username.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Username.Location = new Point(-1, 161);
            Username.Name = "Username";
            Username.Size = new Size(245, 32);
            Username.TabIndex = 21;
            Username.Text = "label1";
            Username.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BookingLogs
            // 
            BookingLogs.ButtonStyle = Krypton.Toolkit.ButtonStyle.NavigatorMini;
            BookingLogs.Location = new Point(-1, 296);
            BookingLogs.Name = "BookingLogs";
            BookingLogs.OverrideDefault.Back.Color1 = Color.FromArgb(28, 28, 28);
            BookingLogs.OverrideDefault.Back.Color2 = Color.FromArgb(28, 28, 28);
            BookingLogs.OverrideDefault.Border.Color1 = Color.FromArgb(0, 153, 255);
            BookingLogs.OverrideDefault.Border.Color2 = Color.FromArgb(0, 153, 255);
            BookingLogs.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(0, 153, 255);
            BookingLogs.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(0, 153, 255);
            BookingLogs.OverrideDefault.Content.ShortText.ColorAngle = 45F;
            BookingLogs.OverrideDefault.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            BookingLogs.OverrideFocus.Back.Color1 = Color.FromArgb(25, 25, 25);
            BookingLogs.OverrideFocus.Back.Color2 = Color.FromArgb(25, 25, 25);
            BookingLogs.OverrideFocus.Border.Color1 = Color.FromArgb(0, 122, 204);
            BookingLogs.OverrideFocus.Border.Color2 = Color.FromArgb(0, 122, 204);
            BookingLogs.Size = new Size(251, 95);
            BookingLogs.StateCommon.Back.Color1 = Color.FromArgb(0, 90, 156);
            BookingLogs.StateCommon.Back.Color2 = Color.FromArgb(0, 63, 107);
            BookingLogs.StateCommon.Back.ColorAngle = 45F;
            BookingLogs.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            BookingLogs.StateCommon.Border.Color1 = Color.FromArgb(0, 63, 107);
            BookingLogs.StateCommon.Border.Color2 = Color.FromArgb(0, 90, 156);
            BookingLogs.StateCommon.Content.ShortText.Color1 = Color.White;
            BookingLogs.StateCommon.Content.ShortText.Color2 = Color.White;
            BookingLogs.StatePressed.Back.Color1 = Color.FromArgb(0, 63, 107);
            BookingLogs.StatePressed.Back.Color2 = Color.FromArgb(0, 42, 71);
            BookingLogs.StatePressed.Border.Color1 = Color.FromArgb(0, 42, 71);
            BookingLogs.StatePressed.Border.Color2 = Color.FromArgb(0, 63, 107);
            BookingLogs.StatePressed.Content.ShortText.Color1 = Color.White;
            BookingLogs.StatePressed.Content.ShortText.Color2 = Color.White;
            BookingLogs.StateTracking.Back.Color1 = Color.FromArgb(0, 111, 184);
            BookingLogs.StateTracking.Back.Color2 = Color.FromArgb(0, 77, 128);
            BookingLogs.StateTracking.Border.Color1 = Color.FromArgb(0, 111, 184);
            BookingLogs.StateTracking.Border.Color2 = Color.FromArgb(0, 77, 128);
            BookingLogs.StateTracking.Content.ShortText.Color1 = Color.White;
            BookingLogs.StateTracking.Content.ShortText.Color2 = Color.White;
            BookingLogs.TabIndex = 3;
            BookingLogs.Values.DropDownArrowColor = Color.AliceBlue;
            BookingLogs.Values.Text = "Booking Logs";
            BookingLogs.Click += BookingLogs_Click_1;
            // 
            // ManageEvents
            // 
            ManageEvents.ButtonStyle = Krypton.Toolkit.ButtonStyle.NavigatorMini;
            ManageEvents.Location = new Point(-1, 486);
            ManageEvents.Name = "ManageEvents";
            ManageEvents.OverrideDefault.Back.Color1 = Color.FromArgb(28, 28, 28);
            ManageEvents.OverrideDefault.Back.Color2 = Color.FromArgb(28, 28, 28);
            ManageEvents.OverrideDefault.Border.Color1 = Color.FromArgb(0, 153, 255);
            ManageEvents.OverrideDefault.Border.Color2 = Color.FromArgb(0, 153, 255);
            ManageEvents.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(0, 153, 255);
            ManageEvents.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(0, 153, 255);
            ManageEvents.OverrideDefault.Content.ShortText.ColorAngle = 45F;
            ManageEvents.OverrideDefault.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            ManageEvents.OverrideFocus.Back.Color1 = Color.FromArgb(25, 25, 25);
            ManageEvents.OverrideFocus.Back.Color2 = Color.FromArgb(25, 25, 25);
            ManageEvents.OverrideFocus.Border.Color1 = Color.FromArgb(0, 122, 204);
            ManageEvents.OverrideFocus.Border.Color2 = Color.FromArgb(0, 122, 204);
            ManageEvents.Size = new Size(251, 95);
            ManageEvents.StateCommon.Back.Color1 = Color.FromArgb(0, 90, 156);
            ManageEvents.StateCommon.Back.Color2 = Color.FromArgb(0, 63, 107);
            ManageEvents.StateCommon.Back.ColorAngle = 45F;
            ManageEvents.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            ManageEvents.StateCommon.Border.Color1 = Color.FromArgb(0, 63, 107);
            ManageEvents.StateCommon.Border.Color2 = Color.FromArgb(0, 90, 156);
            ManageEvents.StateCommon.Content.ShortText.Color1 = Color.White;
            ManageEvents.StateCommon.Content.ShortText.Color2 = Color.White;
            ManageEvents.StatePressed.Back.Color1 = Color.FromArgb(0, 63, 107);
            ManageEvents.StatePressed.Back.Color2 = Color.FromArgb(0, 42, 71);
            ManageEvents.StatePressed.Border.Color1 = Color.FromArgb(0, 42, 71);
            ManageEvents.StatePressed.Border.Color2 = Color.FromArgb(0, 63, 107);
            ManageEvents.StatePressed.Content.ShortText.Color1 = Color.White;
            ManageEvents.StatePressed.Content.ShortText.Color2 = Color.White;
            ManageEvents.StateTracking.Back.Color1 = Color.FromArgb(0, 111, 184);
            ManageEvents.StateTracking.Back.Color2 = Color.FromArgb(0, 77, 128);
            ManageEvents.StateTracking.Border.Color1 = Color.FromArgb(0, 111, 184);
            ManageEvents.StateTracking.Border.Color2 = Color.FromArgb(0, 77, 128);
            ManageEvents.StateTracking.Content.ShortText.Color1 = Color.White;
            ManageEvents.StateTracking.Content.ShortText.Color2 = Color.White;
            ManageEvents.TabIndex = 3;
            ManageEvents.Values.DropDownArrowColor = Color.AliceBlue;
            ManageEvents.Values.Text = "Manage Events";
            ManageEvents.Click += ManageEvents_Click_1;
            // 
            // EventLogs
            // 
            EventLogs.ButtonStyle = Krypton.Toolkit.ButtonStyle.NavigatorMini;
            EventLogs.Location = new Point(-1, 391);
            EventLogs.Name = "EventLogs";
            EventLogs.OverrideDefault.Back.Color1 = Color.FromArgb(28, 28, 28);
            EventLogs.OverrideDefault.Back.Color2 = Color.FromArgb(28, 28, 28);
            EventLogs.OverrideDefault.Border.Color1 = Color.FromArgb(0, 153, 255);
            EventLogs.OverrideDefault.Border.Color2 = Color.FromArgb(0, 153, 255);
            EventLogs.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(0, 153, 255);
            EventLogs.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(0, 153, 255);
            EventLogs.OverrideDefault.Content.ShortText.ColorAngle = 45F;
            EventLogs.OverrideDefault.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            EventLogs.OverrideFocus.Back.Color1 = Color.FromArgb(25, 25, 25);
            EventLogs.OverrideFocus.Back.Color2 = Color.FromArgb(25, 25, 25);
            EventLogs.OverrideFocus.Border.Color1 = Color.FromArgb(0, 122, 204);
            EventLogs.OverrideFocus.Border.Color2 = Color.FromArgb(0, 122, 204);
            EventLogs.Size = new Size(251, 95);
            EventLogs.StateCommon.Back.Color1 = Color.FromArgb(0, 90, 156);
            EventLogs.StateCommon.Back.Color2 = Color.FromArgb(0, 63, 107);
            EventLogs.StateCommon.Back.ColorAngle = 45F;
            EventLogs.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            EventLogs.StateCommon.Border.Color1 = Color.FromArgb(0, 63, 107);
            EventLogs.StateCommon.Border.Color2 = Color.FromArgb(0, 90, 156);
            EventLogs.StateCommon.Content.ShortText.Color1 = Color.White;
            EventLogs.StateCommon.Content.ShortText.Color2 = Color.White;
            EventLogs.StatePressed.Back.Color1 = Color.FromArgb(0, 63, 107);
            EventLogs.StatePressed.Back.Color2 = Color.FromArgb(0, 42, 71);
            EventLogs.StatePressed.Border.Color1 = Color.FromArgb(0, 42, 71);
            EventLogs.StatePressed.Border.Color2 = Color.FromArgb(0, 63, 107);
            EventLogs.StatePressed.Content.ShortText.Color1 = Color.White;
            EventLogs.StatePressed.Content.ShortText.Color2 = Color.White;
            EventLogs.StateTracking.Back.Color1 = Color.FromArgb(0, 111, 184);
            EventLogs.StateTracking.Back.Color2 = Color.FromArgb(0, 77, 128);
            EventLogs.StateTracking.Border.Color1 = Color.FromArgb(0, 111, 184);
            EventLogs.StateTracking.Border.Color2 = Color.FromArgb(0, 77, 128);
            EventLogs.StateTracking.Content.ShortText.Color1 = Color.White;
            EventLogs.StateTracking.Content.ShortText.Color2 = Color.White;
            EventLogs.TabIndex = 4;
            EventLogs.Values.DropDownArrowColor = Color.AliceBlue;
            EventLogs.Values.Text = "Events Logs";
            EventLogs.Click += EventLogs_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.profile;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 158);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // LogOut
            // 
            LogOut.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
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
            // Organizer_Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1319, 762);
            Controls.Add(mainpanel);
            Controls.Add(kryptonPanel2);
            Controls.Add(kryptonPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Organizer_Dashboard";
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
        private Krypton.Toolkit.KryptonButton LogOut;
        private Krypton.Toolkit.KryptonButton EventLogs;
        //private Krypton.Toolkit.KryptonButton ManageEvents;
        private Label PhoneNumber;
        private Label Email;
        private Label Role;
        private Label Username;
        private Krypton.Toolkit.KryptonButton CloseBtn;
        private Krypton.Toolkit.KryptonButton MinmaxBtn;
        private Krypton.Toolkit.KryptonButton RestoreBtn;
        private Krypton.Toolkit.KryptonButton ManageBookings;
        private PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonButton BookingLogs;
        private Krypton.Toolkit.KryptonButton kryptonButton3;
        private Krypton.Toolkit.KryptonButton kryptonButton2;
        private Krypton.Toolkit.KryptonButton ManageEvents;
    }
}