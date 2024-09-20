namespace EventManagementSystem
{
    partial class Participant_Dashboard
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
            mainpanel = new Panel();
            kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            CloseBtn = new Krypton.Toolkit.KryptonButton();
            RestoreBtn = new Krypton.Toolkit.KryptonButton();
            MinmaxBtn = new Krypton.Toolkit.KryptonButton();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            BookingLogs = new Krypton.Toolkit.KryptonButton();
            ViewBookings = new Krypton.Toolkit.KryptonButton();
            ViewEvents = new Krypton.Toolkit.KryptonButton();
            PhoneNumber = new Label();
            Email = new Label();
            Role = new Label();
            Username = new Label();
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
            mainpanel.BackColor = Color.FromArgb(42, 42, 42);
            mainpanel.Dock = DockStyle.Fill;
            mainpanel.Location = new Point(245, 40);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(1074, 722);
            mainpanel.TabIndex = 8;
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Controls.Add(CloseBtn);
            kryptonPanel2.Controls.Add(RestoreBtn);
            kryptonPanel2.Controls.Add(MinmaxBtn);
            kryptonPanel2.Dock = DockStyle.Top;
            kryptonPanel2.Location = new Point(245, 0);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.Size = new Size(1074, 40);
            kryptonPanel2.StateNormal.Color1 = Color.FromArgb(0, 114, 184);
            kryptonPanel2.StateNormal.Color2 = Color.DeepSkyBlue;
            kryptonPanel2.StateNormal.ColorAngle = 45F;
            kryptonPanel2.StateNormal.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            kryptonPanel2.TabIndex = 7;
            // 
            // CloseBtn
            // 
            CloseBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CloseBtn.Location = new Point(1036, 9);
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
            // RestoreBtn
            // 
            RestoreBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RestoreBtn.Location = new Point(956, 9);
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
            // MinmaxBtn
            // 
            MinmaxBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MinmaxBtn.Location = new Point(995, 9);
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
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(BookingLogs);
            kryptonPanel1.Controls.Add(ViewBookings);
            kryptonPanel1.Controls.Add(ViewEvents);
            kryptonPanel1.Controls.Add(PhoneNumber);
            kryptonPanel1.Controls.Add(Email);
            kryptonPanel1.Controls.Add(Role);
            kryptonPanel1.Controls.Add(Username);
            kryptonPanel1.Controls.Add(pictureBox1);
            kryptonPanel1.Controls.Add(LogOut);
            kryptonPanel1.Dock = DockStyle.Left;
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(245, 762);
            kryptonPanel1.StateNormal.Color1 = Color.FromArgb(0, 114, 184);
            kryptonPanel1.StateNormal.Color2 = Color.DeepSkyBlue;
            kryptonPanel1.StateNormal.ColorAngle = 90F;
            kryptonPanel1.StateNormal.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            kryptonPanel1.TabIndex = 6;
            // 
            // BookingLogs
            // 
            BookingLogs.ButtonStyle = Krypton.Toolkit.ButtonStyle.NavigatorMini;
            BookingLogs.Location = new Point(0, 492);
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
            BookingLogs.Size = new Size(245, 95);
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
            BookingLogs.TabIndex = 8;
            BookingLogs.Values.DropDownArrowColor = Color.AliceBlue;
            BookingLogs.Values.Text = "Booking Logs";
            BookingLogs.Click += BookingLogs_Click;
            // 
            // ViewBookings
            // 
            ViewBookings.ButtonStyle = Krypton.Toolkit.ButtonStyle.NavigatorMini;
            ViewBookings.Location = new Point(0, 397);
            ViewBookings.Name = "ViewBookings";
            ViewBookings.OverrideDefault.Back.Color1 = Color.FromArgb(28, 28, 28);
            ViewBookings.OverrideDefault.Back.Color2 = Color.FromArgb(28, 28, 28);
            ViewBookings.OverrideDefault.Border.Color1 = Color.FromArgb(0, 153, 255);
            ViewBookings.OverrideDefault.Border.Color2 = Color.FromArgb(0, 153, 255);
            ViewBookings.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(0, 153, 255);
            ViewBookings.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(0, 153, 255);
            ViewBookings.OverrideDefault.Content.ShortText.ColorAngle = 45F;
            ViewBookings.OverrideDefault.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            ViewBookings.OverrideFocus.Back.Color1 = Color.FromArgb(25, 25, 25);
            ViewBookings.OverrideFocus.Back.Color2 = Color.FromArgb(25, 25, 25);
            ViewBookings.OverrideFocus.Border.Color1 = Color.FromArgb(0, 122, 204);
            ViewBookings.OverrideFocus.Border.Color2 = Color.FromArgb(0, 122, 204);
            ViewBookings.Size = new Size(245, 95);
            ViewBookings.StateCommon.Back.Color1 = Color.FromArgb(0, 90, 156);
            ViewBookings.StateCommon.Back.Color2 = Color.FromArgb(0, 63, 107);
            ViewBookings.StateCommon.Back.ColorAngle = 45F;
            ViewBookings.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            ViewBookings.StateCommon.Border.Color1 = Color.FromArgb(0, 63, 107);
            ViewBookings.StateCommon.Border.Color2 = Color.FromArgb(0, 90, 156);
            ViewBookings.StateCommon.Content.ShortText.Color1 = Color.White;
            ViewBookings.StateCommon.Content.ShortText.Color2 = Color.White;
            ViewBookings.StatePressed.Back.Color1 = Color.FromArgb(0, 63, 107);
            ViewBookings.StatePressed.Back.Color2 = Color.FromArgb(0, 42, 71);
            ViewBookings.StatePressed.Border.Color1 = Color.FromArgb(0, 42, 71);
            ViewBookings.StatePressed.Border.Color2 = Color.FromArgb(0, 63, 107);
            ViewBookings.StatePressed.Content.ShortText.Color1 = Color.White;
            ViewBookings.StatePressed.Content.ShortText.Color2 = Color.White;
            ViewBookings.StateTracking.Back.Color1 = Color.FromArgb(0, 111, 184);
            ViewBookings.StateTracking.Back.Color2 = Color.FromArgb(0, 77, 128);
            ViewBookings.StateTracking.Border.Color1 = Color.FromArgb(0, 111, 184);
            ViewBookings.StateTracking.Border.Color2 = Color.FromArgb(0, 77, 128);
            ViewBookings.StateTracking.Content.ShortText.Color1 = Color.White;
            ViewBookings.StateTracking.Content.ShortText.Color2 = Color.White;
            ViewBookings.TabIndex = 9;
            ViewBookings.Values.DropDownArrowColor = Color.AliceBlue;
            ViewBookings.Values.Text = "View Bookings";
            ViewBookings.Click += ViewBookings_Click_1;
            // 
            // ViewEvents
            // 
            ViewEvents.ButtonStyle = Krypton.Toolkit.ButtonStyle.NavigatorMini;
            ViewEvents.Location = new Point(0, 302);
            ViewEvents.Name = "ViewEvents";
            ViewEvents.OverrideDefault.Back.Color1 = Color.FromArgb(28, 28, 28);
            ViewEvents.OverrideDefault.Back.Color2 = Color.FromArgb(28, 28, 28);
            ViewEvents.OverrideDefault.Border.Color1 = Color.FromArgb(0, 153, 255);
            ViewEvents.OverrideDefault.Border.Color2 = Color.FromArgb(0, 153, 255);
            ViewEvents.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(0, 153, 255);
            ViewEvents.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(0, 153, 255);
            ViewEvents.OverrideDefault.Content.ShortText.ColorAngle = 45F;
            ViewEvents.OverrideDefault.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            ViewEvents.OverrideFocus.Back.Color1 = Color.FromArgb(25, 25, 25);
            ViewEvents.OverrideFocus.Back.Color2 = Color.FromArgb(25, 25, 25);
            ViewEvents.OverrideFocus.Border.Color1 = Color.FromArgb(0, 122, 204);
            ViewEvents.OverrideFocus.Border.Color2 = Color.FromArgb(0, 122, 204);
            ViewEvents.Size = new Size(245, 95);
            ViewEvents.StateCommon.Back.Color1 = Color.FromArgb(0, 90, 156);
            ViewEvents.StateCommon.Back.Color2 = Color.FromArgb(0, 63, 107);
            ViewEvents.StateCommon.Back.ColorAngle = 45F;
            ViewEvents.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            ViewEvents.StateCommon.Border.Color1 = Color.FromArgb(0, 63, 107);
            ViewEvents.StateCommon.Border.Color2 = Color.FromArgb(0, 90, 156);
            ViewEvents.StateCommon.Content.ShortText.Color1 = Color.White;
            ViewEvents.StateCommon.Content.ShortText.Color2 = Color.White;
            ViewEvents.StatePressed.Back.Color1 = Color.FromArgb(0, 63, 107);
            ViewEvents.StatePressed.Back.Color2 = Color.FromArgb(0, 42, 71);
            ViewEvents.StatePressed.Border.Color1 = Color.FromArgb(0, 42, 71);
            ViewEvents.StatePressed.Border.Color2 = Color.FromArgb(0, 63, 107);
            ViewEvents.StatePressed.Content.ShortText.Color1 = Color.White;
            ViewEvents.StatePressed.Content.ShortText.Color2 = Color.White;
            ViewEvents.StateTracking.Back.Color1 = Color.FromArgb(0, 111, 184);
            ViewEvents.StateTracking.Back.Color2 = Color.FromArgb(0, 77, 128);
            ViewEvents.StateTracking.Border.Color1 = Color.FromArgb(0, 111, 184);
            ViewEvents.StateTracking.Border.Color2 = Color.FromArgb(0, 77, 128);
            ViewEvents.StateTracking.Content.ShortText.Color1 = Color.White;
            ViewEvents.StateTracking.Content.ShortText.Color2 = Color.White;
            ViewEvents.TabIndex = 10;
            ViewEvents.Values.DropDownArrowColor = Color.AliceBlue;
            ViewEvents.Values.Text = "View Events";
            ViewEvents.Click += ViewEvents_Click_1;
            // 
            // PhoneNumber
            // 
            PhoneNumber.BackColor = Color.Transparent;
            PhoneNumber.Location = new Point(0, 255);
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.Size = new Size(245, 25);
            PhoneNumber.TabIndex = 29;
            PhoneNumber.Text = "label4";
            PhoneNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Email
            // 
            Email.BackColor = Color.Transparent;
            Email.Location = new Point(0, 226);
            Email.Name = "Email";
            Email.Size = new Size(245, 25);
            Email.TabIndex = 28;
            Email.Text = "label3";
            Email.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Role
            // 
            Role.BackColor = Color.Transparent;
            Role.Location = new Point(0, 196);
            Role.Name = "Role";
            Role.Size = new Size(245, 25);
            Role.TabIndex = 27;
            Role.Text = "label2";
            Role.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Username
            // 
            Username.BackColor = Color.Transparent;
            Username.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Username.Location = new Point(0, 161);
            Username.Name = "Username";
            Username.Size = new Size(245, 32);
            Username.TabIndex = 26;
            Username.Text = "label1";
            Username.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.profile;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(245, 158);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // LogOut
            // 
            LogOut.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            LogOut.ButtonStyle = Krypton.Toolkit.ButtonStyle.NavigatorMini;
            LogOut.Location = new Point(0, 667);
            LogOut.Name = "LogOut";
            LogOut.OverrideFocus.Back.Color1 = Color.FromArgb(180, 0, 0);
            LogOut.OverrideFocus.Back.Color2 = Color.FromArgb(220, 0, 0);
            LogOut.OverrideFocus.Back.ColorAngle = 45F;
            LogOut.OverrideFocus.Content.ShortText.Color1 = Color.White;
            LogOut.OverrideFocus.Content.ShortText.Color2 = Color.White;
            LogOut.Size = new Size(245, 95);
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
            LogOut.TabIndex = 15;
            LogOut.Values.DropDownArrowColor = Color.White;
            LogOut.Values.Text = "LogOut";
            LogOut.Click += LogOut_Click_1;
            // 
            // Participant_Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1319, 762);
            Controls.Add(mainpanel);
            Controls.Add(kryptonPanel2);
            Controls.Add(kryptonPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Participant_Dashboard";
            Text = "Participant_Dashboard";
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
        private Krypton.Toolkit.KryptonButton BookingsLogs;
       // private Krypton.Toolkit.KryptonButton ViewBookings;
       // private Krypton.Toolkit.KryptonButton ViewEvents;
        private Label PhoneNumber;
        private PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonButton LogOut;
        private Label Email;
        private Label Username;
        private Label Role;
        private Krypton.Toolkit.KryptonButton CloseBtn;
        private Krypton.Toolkit.KryptonButton RestoreBtn;
        private Krypton.Toolkit.KryptonButton MinmaxBtn;
        private Krypton.Toolkit.KryptonButton ViewEvents;
        private Krypton.Toolkit.KryptonButton ViewBookings;
        private Krypton.Toolkit.KryptonButton BookingLogs;
    }
}