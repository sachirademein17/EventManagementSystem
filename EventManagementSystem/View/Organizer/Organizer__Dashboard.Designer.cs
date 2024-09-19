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
            LogOut = new Krypton.Toolkit.KryptonButton();
            flowLayoutPanel1 = new FlowLayoutPanel();
            Dashboard = new Krypton.Toolkit.KryptonButton();
            ViewEvents = new Krypton.Toolkit.KryptonButton();
            ManageEvents = new Krypton.Toolkit.KryptonButton();
            ManageBookings = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
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
            kryptonPanel2.StateCommon.Color1 = Color.FromArgb(15, 15, 15);
            kryptonPanel2.StateCommon.Color2 = Color.FromArgb(31, 31, 31);
            kryptonPanel2.StateCommon.ColorAngle = 45F;
            kryptonPanel2.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            kryptonPanel2.TabIndex = 4;
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(LogOut);
            kryptonPanel1.Controls.Add(flowLayoutPanel1);
            kryptonPanel1.Dock = DockStyle.Left;
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(250, 762);
            kryptonPanel1.StateCommon.Color1 = Color.FromArgb(15, 15, 15);
            kryptonPanel1.StateCommon.Color2 = Color.FromArgb(31, 31, 31);
            kryptonPanel1.StateCommon.ColorAngle = 45F;
            kryptonPanel1.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            kryptonPanel1.TabIndex = 3;
            // 
            // LogOut
            // 
            LogOut.ButtonStyle = Krypton.Toolkit.ButtonStyle.NavigatorMini;
            LogOut.Location = new Point(0, 678);
            LogOut.Name = "LogOut";
            LogOut.Size = new Size(263, 84);
            LogOut.TabIndex = 0;
            LogOut.Values.Text = "LogOut";
            LogOut.Click += LogOut_Click;

            // Default state
            LogOut.StateCommon.Back.Color1 = Color.FromArgb(200, 50, 50); // Dark Red
            LogOut.StateCommon.Back.Color2 = Color.FromArgb(255, 0, 0);   // Bright Red
            LogOut.StateCommon.Back.ColorAngle = 45F;
            LogOut.StateCommon.Content.ShortText.Color1 = Color.White; // White Text
            LogOut.StateCommon.Content.ShortText.Color2 = Color.White; // White Text

            // Disabled state
            LogOut.StateDisabled.Back.Color1 = Color.FromArgb(150, 30, 30); // Darker Red
            LogOut.StateDisabled.Back.Color2 = Color.FromArgb(150, 30, 30); // Darker Red
            LogOut.StateDisabled.Content.ShortText.Color1 = Color.FromArgb(100, 100, 100); // Gray
            LogOut.StateDisabled.Content.ShortText.Color2 = Color.FromArgb(100, 100, 100); // Gray

            // Normal state
            LogOut.StateNormal.Back.Color1 = Color.FromArgb(200, 50, 50); // Dark Red
            LogOut.StateNormal.Back.Color2 = Color.FromArgb(255, 0, 0);   // Bright Red
            LogOut.StateNormal.Back.ColorAngle = 45F;
            LogOut.StateNormal.Content.ShortText.Color1 = Color.White; // White Text
            LogOut.StateNormal.Content.ShortText.Color2 = Color.White; // White Text

            // Pressed state
            LogOut.StatePressed.Back.Color1 = Color.FromArgb(150, 0, 0); // Dark Red
            LogOut.StatePressed.Back.Color2 = Color.FromArgb(180, 0, 0); // Even Darker Red
            LogOut.StatePressed.Back.ColorAngle = 45F;
            LogOut.StatePressed.Content.ShortText.Color1 = Color.White; // White Text
            LogOut.StatePressed.Content.ShortText.Color2 = Color.White; // White Text

            // Focus state
            LogOut.OverrideFocus.Back.Color1 = Color.FromArgb(180, 0, 0); // Dark Red
            LogOut.OverrideFocus.Back.Color2 = Color.FromArgb(220, 0, 0); // Bright Red
            LogOut.OverrideFocus.Back.ColorAngle = 45F;
            LogOut.OverrideFocus.Content.ShortText.Color1 = Color.White; // White Text
            LogOut.OverrideFocus.Content.ShortText.Color2 = Color.White; // White Text

            // Dropdown arrow color
            LogOut.Values.DropDownArrowColor = Color.White; // White

            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.Controls.Add(Dashboard);
            flowLayoutPanel1.Controls.Add(ViewEvents);
            flowLayoutPanel1.Controls.Add(ManageEvents);
            flowLayoutPanel1.Controls.Add(ManageBookings);
            flowLayoutPanel1.Location = new Point(0, 93);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(245, 391);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // Dashboard
            // 
            Dashboard.ButtonStyle = Krypton.Toolkit.ButtonStyle.NavigatorMini;
            Dashboard.Location = new Point(3, 3);
            Dashboard.Name = "Dashboard";
            Dashboard.OverrideDefault.Back.Color1 = Color.FromArgb(31, 31, 31);
            Dashboard.OverrideDefault.Back.Color2 = Color.FromArgb(31, 31, 31);
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
            // ViewEvents
            // 
            ViewEvents.ButtonStyle = Krypton.Toolkit.ButtonStyle.NavigatorMini;
            ViewEvents.Location = new Point(3, 99);
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
            // ManageEvents
            // 
            ManageEvents.ButtonStyle = Krypton.Toolkit.ButtonStyle.NavigatorMini;
            ManageEvents.Location = new Point(3, 195);
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
            // ManageBookings
            // 
            ManageBookings.ButtonStyle = Krypton.Toolkit.ButtonStyle.NavigatorMini;
            ManageBookings.Location = new Point(3, 291);
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
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel mainpanel;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Krypton.Toolkit.KryptonButton Dashboard;
        private Krypton.Toolkit.KryptonButton ViewEvents;
        private Krypton.Toolkit.KryptonButton ManageEvents;
        private Krypton.Toolkit.KryptonButton ManageBookings;
        private Krypton.Toolkit.KryptonButton LogOut;
    }
}