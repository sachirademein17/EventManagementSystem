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
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            PhoneNumber = new Label();
            Email = new Label();
            Role = new Label();
            Username = new Label();
            pictureBox1 = new PictureBox();
            EventLogs = new Krypton.Toolkit.KryptonButton();
            ManageEvents = new Krypton.Toolkit.KryptonButton();
            ManageBookings = new Krypton.Toolkit.KryptonButton();
            BookingLogs = new Krypton.Toolkit.KryptonButton();
            LogOut = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // mainpanel
            // 
            mainpanel.BackColor = Color.FromArgb(28, 28, 28);
            mainpanel.Dock = DockStyle.Fill;
            mainpanel.Location = new Point(250, 87);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(1069, 675);
            mainpanel.TabIndex = 5;
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Dock = DockStyle.Top;
            kryptonPanel2.Location = new Point(250, 0);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.Size = new Size(1069, 87);
            kryptonPanel2.StateCommon.Color1 = Color.FromArgb(0, 114, 184);
            kryptonPanel2.StateCommon.Color2 = Color.DeepSkyBlue;
            kryptonPanel2.StateCommon.ColorAngle = 45F;
            kryptonPanel2.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            kryptonPanel2.TabIndex = 4;
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(PhoneNumber);
            kryptonPanel1.Controls.Add(Email);
            kryptonPanel1.Controls.Add(Role);
            kryptonPanel1.Controls.Add(Username);
            kryptonPanel1.Controls.Add(pictureBox1);
            kryptonPanel1.Controls.Add(EventLogs);
            kryptonPanel1.Controls.Add(ManageEvents);
            kryptonPanel1.Controls.Add(ManageBookings);
            kryptonPanel1.Controls.Add(BookingLogs);
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
            // PhoneNumber
            // 
            PhoneNumber.AutoSize = true;
            PhoneNumber.BackColor = Color.Transparent;
            PhoneNumber.Location = new Point(86, 268);
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.Size = new Size(59, 25);
            PhoneNumber.TabIndex = 14;
            PhoneNumber.Text = "label4";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.BackColor = Color.Transparent;
            Email.Location = new Point(86, 230);
            Email.Name = "Email";
            Email.Size = new Size(59, 25);
            Email.TabIndex = 13;
            Email.Text = "label3";
            // 
            // Role
            // 
            Role.AutoSize = true;
            Role.BackColor = Color.Transparent;
            Role.Location = new Point(86, 196);
            Role.Name = "Role";
            Role.Size = new Size(59, 25);
            Role.TabIndex = 12;
            Role.Text = "label2";
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.BackColor = Color.Transparent;
            Username.Location = new Point(86, 161);
            Username.Name = "Username";
            Username.Size = new Size(59, 25);
            Username.TabIndex = 11;
            Username.Text = "label1";
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
            // EventLogs
            // 
            EventLogs.ButtonStyle = Krypton.Toolkit.ButtonStyle.NavigatorMini;
            EventLogs.Location = new Point(3, 409);
            EventLogs.Name = "EventLogs";
            EventLogs.OverrideDefault.Back.Color1 = Color.FromArgb(75, 75, 75);
            EventLogs.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            EventLogs.OverrideDefault.Border.Color1 = Color.FromArgb(0, 114, 184);
            EventLogs.OverrideDefault.Content.ShortText.Color1 = Color.LimeGreen;
            EventLogs.OverrideDefault.Content.ShortText.Color2 = Color.ForestGreen;
            EventLogs.OverrideDefault.Content.ShortText.ColorAngle = 45F;
            EventLogs.OverrideDefault.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            EventLogs.Size = new Size(245, 95);
            EventLogs.StateCommon.Back.Color1 = Color.FromArgb(0, 90, 156);
            EventLogs.StateCommon.Back.Color2 = Color.FromArgb(0, 63, 107);
            EventLogs.StateCommon.Back.ColorAngle = 45F;
            EventLogs.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            EventLogs.StateCommon.Content.ShortText.Color1 = Color.White;
            EventLogs.StateCommon.Content.ShortText.Color2 = Color.White;
            EventLogs.StatePressed.Back.Color1 = Color.FromArgb(0, 63, 107);
            EventLogs.StatePressed.Back.Color2 = Color.FromArgb(0, 42, 71);
            EventLogs.StatePressed.Content.ShortText.Color1 = Color.White;
            EventLogs.StatePressed.Content.ShortText.Color2 = Color.White;
            EventLogs.StateTracking.Back.Color1 = Color.FromArgb(0, 111, 184);
            EventLogs.StateTracking.Back.Color2 = Color.FromArgb(0, 77, 128);
            EventLogs.StateTracking.Content.ShortText.Color1 = Color.White;
            EventLogs.StateTracking.Content.ShortText.Color2 = Color.White;
            EventLogs.TabIndex = 9;
            EventLogs.Values.DropDownArrowColor = Color.AliceBlue;
            EventLogs.Values.Text = "Events Logs";
            EventLogs.Click += EventLogs_Click;
            // 
            // ManageEvents
            // 
            ManageEvents.ButtonStyle = Krypton.Toolkit.ButtonStyle.NavigatorMini;
            ManageEvents.Location = new Point(5, 498);
            ManageEvents.Name = "ManageEvents";
            ManageEvents.OverrideDefault.Back.Color1 = Color.FromArgb(75, 75, 75);
            ManageEvents.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            ManageEvents.OverrideDefault.Border.Color1 = Color.FromArgb(0, 114, 184);
            ManageEvents.OverrideDefault.Content.ShortText.Color1 = Color.LimeGreen;
            ManageEvents.OverrideDefault.Content.ShortText.Color2 = Color.ForestGreen;
            ManageEvents.OverrideDefault.Content.ShortText.ColorAngle = 45F;
            ManageEvents.OverrideDefault.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            ManageEvents.Size = new Size(245, 95);
            ManageEvents.StateCommon.Back.Color1 = Color.FromArgb(0, 90, 156);
            ManageEvents.StateCommon.Back.Color2 = Color.FromArgb(0, 63, 107);
            ManageEvents.StateCommon.Back.ColorAngle = 45F;
            ManageEvents.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            ManageEvents.StateCommon.Content.ShortText.Color1 = Color.White;
            ManageEvents.StateCommon.Content.ShortText.Color2 = Color.White;
            ManageEvents.StatePressed.Back.Color1 = Color.FromArgb(0, 63, 107);
            ManageEvents.StatePressed.Back.Color2 = Color.FromArgb(0, 42, 71);
            ManageEvents.StatePressed.Content.ShortText.Color1 = Color.White;
            ManageEvents.StatePressed.Content.ShortText.Color2 = Color.White;
            ManageEvents.StateTracking.Back.Color1 = Color.FromArgb(0, 111, 184);
            ManageEvents.StateTracking.Back.Color2 = Color.FromArgb(0, 77, 128);
            ManageEvents.StateTracking.Content.ShortText.Color1 = Color.White;
            ManageEvents.StateTracking.Content.ShortText.Color2 = Color.White;
            ManageEvents.TabIndex = 8;
            ManageEvents.Values.DropDownArrowColor = Color.AliceBlue;
            ManageEvents.Values.Text = "Manage Events";
            ManageEvents.Click += ManageEvents_Click;
            // 
            // ManageBookings
            // 
            ManageBookings.ButtonStyle = Krypton.Toolkit.ButtonStyle.NavigatorMini;
            ManageBookings.Location = new Point(5, 589);
            ManageBookings.Name = "ManageBookings";
            ManageBookings.OverrideDefault.Back.Color1 = Color.FromArgb(75, 75, 75);
            ManageBookings.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            ManageBookings.OverrideDefault.Border.Color1 = Color.FromArgb(0, 114, 184);
            ManageBookings.OverrideDefault.Content.ShortText.Color1 = Color.LimeGreen;
            ManageBookings.OverrideDefault.Content.ShortText.Color2 = Color.ForestGreen;
            ManageBookings.OverrideDefault.Content.ShortText.ColorAngle = 45F;
            ManageBookings.OverrideDefault.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            ManageBookings.Size = new Size(245, 95);
            ManageBookings.StateCommon.Back.Color1 = Color.FromArgb(0, 90, 156);
            ManageBookings.StateCommon.Back.Color2 = Color.FromArgb(0, 63, 107);
            ManageBookings.StateCommon.Back.ColorAngle = 45F;
            ManageBookings.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            ManageBookings.StateCommon.Content.ShortText.Color1 = Color.White;
            ManageBookings.StateCommon.Content.ShortText.Color2 = Color.White;
            ManageBookings.StatePressed.Back.Color1 = Color.FromArgb(0, 63, 107);
            ManageBookings.StatePressed.Back.Color2 = Color.FromArgb(0, 42, 71);
            ManageBookings.StatePressed.Content.ShortText.Color1 = Color.White;
            ManageBookings.StatePressed.Content.ShortText.Color2 = Color.White;
            ManageBookings.StateTracking.Back.Color1 = Color.FromArgb(0, 111, 184);
            ManageBookings.StateTracking.Back.Color2 = Color.FromArgb(0, 77, 128);
            ManageBookings.StateTracking.Content.ShortText.Color1 = Color.White;
            ManageBookings.StateTracking.Content.ShortText.Color2 = Color.White;
            ManageBookings.TabIndex = 7;
            ManageBookings.Values.DropDownArrowColor = Color.AliceBlue;
            ManageBookings.Values.Text = "Manage Bookings";
            ManageBookings.Click += ManageBookings_Click;
            // 
            // BookingLogs
            // 
            BookingLogs.ButtonStyle = Krypton.Toolkit.ButtonStyle.NavigatorMini;
            BookingLogs.Location = new Point(2, 308);
            BookingLogs.Name = "BookingLogs";
            BookingLogs.OverrideDefault.Back.Color1 = Color.FromArgb(75, 75, 75);
            BookingLogs.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            BookingLogs.OverrideDefault.Border.Color1 = Color.FromArgb(0, 114, 184);
            BookingLogs.OverrideDefault.Content.ShortText.Color1 = Color.LimeGreen;
            BookingLogs.OverrideDefault.Content.ShortText.Color2 = Color.ForestGreen;
            BookingLogs.OverrideDefault.Content.ShortText.ColorAngle = 45F;
            BookingLogs.OverrideDefault.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            BookingLogs.Size = new Size(245, 95);
            BookingLogs.StateCommon.Back.Color1 = Color.FromArgb(0, 90, 156);
            BookingLogs.StateCommon.Back.Color2 = Color.FromArgb(0, 63, 107);
            BookingLogs.StateCommon.Back.ColorAngle = 45F;
            BookingLogs.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            BookingLogs.StateCommon.Content.ShortText.Color1 = Color.White;
            BookingLogs.StateCommon.Content.ShortText.Color2 = Color.White;
            BookingLogs.StatePressed.Back.Color1 = Color.FromArgb(0, 63, 107);
            BookingLogs.StatePressed.Back.Color2 = Color.FromArgb(0, 42, 71);
            BookingLogs.StatePressed.Content.ShortText.Color1 = Color.White;
            BookingLogs.StatePressed.Content.ShortText.Color2 = Color.White;
            BookingLogs.StateTracking.Back.Color1 = Color.FromArgb(0, 111, 184);
            BookingLogs.StateTracking.Back.Color2 = Color.FromArgb(0, 77, 128);
            BookingLogs.StateTracking.Content.ShortText.Color1 = Color.White;
            BookingLogs.StateTracking.Content.ShortText.Color2 = Color.White;
            BookingLogs.TabIndex = 6;
            BookingLogs.Values.DropDownArrowColor = Color.AliceBlue;
            BookingLogs.Values.Text = "Booking Logs";
            BookingLogs.Click += BookingLogs_Click;
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
            Name = "Organizer__Dashboard";
            Text = "Organizer__Dashboard";
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainpanel;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonButton Dashboard;
        private Krypton.Toolkit.KryptonButton LogOut;
        private Krypton.Toolkit.KryptonButton BookingLogs;
        private Krypton.Toolkit.KryptonButton EventLogs;
        private Krypton.Toolkit.KryptonButton ManageEvents;
        private Krypton.Toolkit.KryptonButton ManageBookings;
        private Label PhoneNumber;
        private Label Email;
        private Label Role;
        private Label Username;
        private PictureBox pictureBox1;
    }
}