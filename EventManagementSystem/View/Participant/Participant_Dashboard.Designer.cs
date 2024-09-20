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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Participant_Dashboard));
            mainpanel = new Panel();
            kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            button2 = new Button();
            button3 = new Button();
            button1 = new Button();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            PhoneNumber = new Label();
            pictureBox1 = new PictureBox();
            LogOut = new Krypton.Toolkit.KryptonButton();
            Email = new Label();
            BookingsLogs = new Krypton.Toolkit.KryptonButton();
            Username = new Label();
            ViewBookings = new Krypton.Toolkit.KryptonButton();
            Role = new Label();
            ViewEvents = new Krypton.Toolkit.KryptonButton();
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
            mainpanel.Location = new Point(245, 87);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(1074, 675);
            mainpanel.TabIndex = 8;
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Controls.Add(button2);
            kryptonPanel2.Controls.Add(button3);
            kryptonPanel2.Controls.Add(button1);
            kryptonPanel2.Dock = DockStyle.Top;
            kryptonPanel2.Location = new Point(245, 0);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.Size = new Size(1074, 87);
            kryptonPanel2.StateNormal.Color1 = Color.FromArgb(0, 114, 184);
            kryptonPanel2.StateNormal.Color2 = Color.DeepSkyBlue;
            kryptonPanel2.StateNormal.ColorAngle = 45F;
            kryptonPanel2.StateNormal.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            kryptonPanel2.TabIndex = 7;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.Transparent;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.Image = Properties.Resources.minimize;
            button2.Location = new Point(872, 18);
            button2.Name = "button2";
            button2.Size = new Size(55, 51);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.BackColor = Color.Transparent;
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(939, 18);
            button3.Name = "button3";
            button3.Size = new Size(55, 51);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.Transparent;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Image = Properties.Resources.close;
            button1.Location = new Point(1006, 18);
            button1.Name = "button1";
            button1.Size = new Size(55, 51);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(PhoneNumber);
            kryptonPanel1.Controls.Add(pictureBox1);
            kryptonPanel1.Controls.Add(LogOut);
            kryptonPanel1.Controls.Add(Email);
            kryptonPanel1.Controls.Add(BookingsLogs);
            kryptonPanel1.Controls.Add(Username);
            kryptonPanel1.Controls.Add(ViewBookings);
            kryptonPanel1.Controls.Add(Role);
            kryptonPanel1.Controls.Add(ViewEvents);
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
            // PhoneNumber
            // 
            PhoneNumber.AutoSize = true;
            PhoneNumber.BackColor = Color.Transparent;
            PhoneNumber.Location = new Point(86, 255);
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.Size = new Size(59, 25);
            PhoneNumber.TabIndex = 20;
            PhoneNumber.Text = "label4";
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
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
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
            LogOut.Size = new Size(242, 84);
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
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.BackColor = Color.Transparent;
            Email.Location = new Point(86, 230);
            Email.Name = "Email";
            Email.Size = new Size(59, 25);
            Email.TabIndex = 19;
            Email.Text = "label3";
            // 
            // BookingsLogs
            // 
            BookingsLogs.ButtonStyle = Krypton.Toolkit.ButtonStyle.NavigatorMini;
            BookingsLogs.Location = new Point(0, 536);
            BookingsLogs.Name = "BookingsLogs";
            BookingsLogs.OverrideDefault.Back.Color1 = Color.FromArgb(75, 75, 75);
            BookingsLogs.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            BookingsLogs.OverrideDefault.Border.Color1 = Color.FromArgb(0, 114, 184);
            BookingsLogs.OverrideDefault.Content.ShortText.Color1 = Color.LimeGreen;
            BookingsLogs.OverrideDefault.Content.ShortText.Color2 = Color.ForestGreen;
            BookingsLogs.OverrideDefault.Content.ShortText.ColorAngle = 45F;
            BookingsLogs.OverrideDefault.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            BookingsLogs.Size = new Size(245, 95);
            BookingsLogs.StateCommon.Back.Color1 = Color.FromArgb(0, 90, 156);
            BookingsLogs.StateCommon.Back.Color2 = Color.FromArgb(0, 63, 107);
            BookingsLogs.StateCommon.Back.ColorAngle = 45F;
            BookingsLogs.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            BookingsLogs.StateCommon.Content.ShortText.Color1 = Color.White;
            BookingsLogs.StateCommon.Content.ShortText.Color2 = Color.White;
            BookingsLogs.StatePressed.Back.Color1 = Color.FromArgb(0, 63, 107);
            BookingsLogs.StatePressed.Back.Color2 = Color.FromArgb(0, 42, 71);
            BookingsLogs.StatePressed.Content.ShortText.Color1 = Color.White;
            BookingsLogs.StatePressed.Content.ShortText.Color2 = Color.White;
            BookingsLogs.StateTracking.Back.Color1 = Color.FromArgb(0, 111, 184);
            BookingsLogs.StateTracking.Back.Color2 = Color.FromArgb(0, 77, 128);
            BookingsLogs.StateTracking.Content.ShortText.Color1 = Color.White;
            BookingsLogs.StateTracking.Content.ShortText.Color2 = Color.White;
            BookingsLogs.TabIndex = 8;
            BookingsLogs.Values.DropDownArrowColor = Color.AliceBlue;
            BookingsLogs.Values.Text = "Booking Logs";
            BookingsLogs.Click += BookingsLogs_Click;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.BackColor = Color.Transparent;
            Username.Location = new Point(86, 161);
            Username.Name = "Username";
            Username.Size = new Size(59, 25);
            Username.TabIndex = 17;
            Username.Text = "label1";
            // 
            // ViewBookings
            // 
            ViewBookings.ButtonStyle = Krypton.Toolkit.ButtonStyle.NavigatorMini;
            ViewBookings.Location = new Point(0, 435);
            ViewBookings.Name = "ViewBookings";
            ViewBookings.OverrideDefault.Back.Color1 = Color.FromArgb(75, 75, 75);
            ViewBookings.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            ViewBookings.OverrideDefault.Border.Color1 = Color.FromArgb(0, 114, 184);
            ViewBookings.OverrideDefault.Content.ShortText.Color1 = Color.LimeGreen;
            ViewBookings.OverrideDefault.Content.ShortText.Color2 = Color.ForestGreen;
            ViewBookings.OverrideDefault.Content.ShortText.ColorAngle = 45F;
            ViewBookings.OverrideDefault.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            ViewBookings.Size = new Size(245, 95);
            ViewBookings.StateCommon.Back.Color1 = Color.FromArgb(0, 90, 156);
            ViewBookings.StateCommon.Back.Color2 = Color.FromArgb(0, 63, 107);
            ViewBookings.StateCommon.Back.ColorAngle = 45F;
            ViewBookings.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            ViewBookings.StateCommon.Content.ShortText.Color1 = Color.White;
            ViewBookings.StateCommon.Content.ShortText.Color2 = Color.White;
            ViewBookings.StatePressed.Back.Color1 = Color.FromArgb(0, 63, 107);
            ViewBookings.StatePressed.Back.Color2 = Color.FromArgb(0, 42, 71);
            ViewBookings.StatePressed.Content.ShortText.Color1 = Color.White;
            ViewBookings.StatePressed.Content.ShortText.Color2 = Color.White;
            ViewBookings.StateTracking.Back.Color1 = Color.FromArgb(0, 111, 184);
            ViewBookings.StateTracking.Back.Color2 = Color.FromArgb(0, 77, 128);
            ViewBookings.StateTracking.Content.ShortText.Color1 = Color.White;
            ViewBookings.StateTracking.Content.ShortText.Color2 = Color.White;
            ViewBookings.TabIndex = 7;
            ViewBookings.Values.DropDownArrowColor = Color.AliceBlue;
            ViewBookings.Values.Text = "View Bookings";
            ViewBookings.Click += ViewBookings_Click;
            // 
            // Role
            // 
            Role.AutoSize = true;
            Role.BackColor = Color.Transparent;
            Role.Location = new Point(86, 196);
            Role.Name = "Role";
            Role.Size = new Size(59, 25);
            Role.TabIndex = 18;
            Role.Text = "label2";
            // 
            // ViewEvents
            // 
            ViewEvents.ButtonStyle = Krypton.Toolkit.ButtonStyle.NavigatorMini;
            ViewEvents.Location = new Point(0, 334);
            ViewEvents.Name = "ViewEvents";
            ViewEvents.OverrideDefault.Back.Color1 = Color.FromArgb(75, 75, 75);
            ViewEvents.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            ViewEvents.OverrideDefault.Border.Color1 = Color.FromArgb(0, 114, 184);
            ViewEvents.OverrideDefault.Content.ShortText.Color1 = Color.LimeGreen;
            ViewEvents.OverrideDefault.Content.ShortText.Color2 = Color.ForestGreen;
            ViewEvents.OverrideDefault.Content.ShortText.ColorAngle = 45F;
            ViewEvents.OverrideDefault.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            ViewEvents.Size = new Size(245, 95);
            ViewEvents.StateCommon.Back.Color1 = Color.FromArgb(0, 90, 156);
            ViewEvents.StateCommon.Back.Color2 = Color.FromArgb(0, 63, 107);
            ViewEvents.StateCommon.Back.ColorAngle = 45F;
            ViewEvents.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            ViewEvents.StateCommon.Content.ShortText.Color1 = Color.White;
            ViewEvents.StateCommon.Content.ShortText.Color2 = Color.White;
            ViewEvents.StatePressed.Back.Color1 = Color.FromArgb(0, 63, 107);
            ViewEvents.StatePressed.Back.Color2 = Color.FromArgb(0, 42, 71);
            ViewEvents.StatePressed.Content.ShortText.Color1 = Color.White;
            ViewEvents.StatePressed.Content.ShortText.Color2 = Color.White;
            ViewEvents.StateTracking.Back.Color1 = Color.FromArgb(0, 111, 184);
            ViewEvents.StateTracking.Back.Color2 = Color.FromArgb(0, 77, 128);
            ViewEvents.StateTracking.Content.ShortText.Color1 = Color.White;
            ViewEvents.StateTracking.Content.ShortText.Color2 = Color.White;
            ViewEvents.TabIndex = 6;
            ViewEvents.Values.DropDownArrowColor = Color.AliceBlue;
            ViewEvents.Values.Text = "View Events";
            ViewEvents.Click += ViewEvents_Click;
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
            kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainpanel;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Button button2;
        private Button button3;
        private Button button1;
        private Krypton.Toolkit.KryptonButton BookingsLogs;
        private Krypton.Toolkit.KryptonButton ViewBookings;
        private Krypton.Toolkit.KryptonButton ViewEvents;
        private Label PhoneNumber;
        private PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonButton LogOut;
        private Label Email;
        private Label Username;
        private Label Role;
    }
}