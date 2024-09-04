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
            mainpanel.BackColor = Color.FromArgb(31, 31, 31);
            mainpanel.Dock = DockStyle.Fill;
            mainpanel.Location = new Point(245, 87);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(1074, 675);
            mainpanel.TabIndex = 5;
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Dock = DockStyle.Top;
            kryptonPanel2.Location = new Point(245, 0);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.Size = new Size(1074, 87);
            kryptonPanel2.StateCommon.Color1 = Color.FromArgb(15, 15, 15);
            kryptonPanel2.StateCommon.Color2 = Color.FromArgb(15, 15, 15);
            kryptonPanel2.TabIndex = 4;
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(LogOut);
            kryptonPanel1.Controls.Add(flowLayoutPanel1);
            kryptonPanel1.Dock = DockStyle.Left;
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(245, 762);
            kryptonPanel1.StateCommon.Color1 = Color.FromArgb(15, 15, 15);
            kryptonPanel1.StateCommon.Color2 = Color.FromArgb(15, 15, 15);
            kryptonPanel1.TabIndex = 3;
            // 
            // LogOut
            // 
            LogOut.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
            LogOut.Location = new Point(0, 678);
            LogOut.Name = "LogOut";
            LogOut.OverrideDefault.Back.Color1 = Color.FromArgb(79, 79, 79);
            LogOut.OverrideDefault.Back.Color2 = Color.FromArgb(79, 79, 79);
            LogOut.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(0, 153, 255);
            LogOut.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(0, 153, 255);
            LogOut.OverrideFocus.Back.Color1 = Color.FromArgb(31, 31, 31);
            LogOut.OverrideFocus.Back.Color2 = Color.FromArgb(31, 31, 31);
            LogOut.Size = new Size(239, 84);
            LogOut.StateCommon.Back.Color1 = Color.FromArgb(44, 72, 117);
            LogOut.StateCommon.Back.Color2 = Color.FromArgb(44, 72, 117);
            LogOut.StateCommon.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            LogOut.StateCommon.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            LogOut.StateDisabled.Back.Color1 = Color.FromArgb(44, 72, 117);
            LogOut.StateDisabled.Back.Color2 = Color.FromArgb(44, 72, 117);
            LogOut.StateNormal.Back.Color1 = Color.FromArgb(44, 72, 117);
            LogOut.StateNormal.Back.Color2 = Color.FromArgb(44, 72, 117);
            LogOut.StateNormal.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            LogOut.StateNormal.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            LogOut.StatePressed.Back.Color1 = Color.FromArgb(46, 46, 46);
            LogOut.StatePressed.Back.Color2 = Color.FromArgb(46, 46, 46);
            LogOut.TabIndex = 6;
            LogOut.Values.DropDownArrowColor = Color.AliceBlue;
            LogOut.Values.Text = "LogOut";
            LogOut.Click += LogOut_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(15, 15, 15);
            flowLayoutPanel1.Controls.Add(Dashboard);
            flowLayoutPanel1.Controls.Add(ViewEvents);
            flowLayoutPanel1.Controls.Add(ManageEvents);
            flowLayoutPanel1.Controls.Add(ManageBookings);
            flowLayoutPanel1.Location = new Point(0, 93);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(245, 374);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // Dashboard
            // 
            Dashboard.Location = new Point(3, 3);
            Dashboard.Name = "Dashboard";
            Dashboard.OverrideDefault.Back.Color1 = Color.FromArgb(31, 31, 31);
            Dashboard.OverrideDefault.Back.Color2 = Color.FromArgb(31, 31, 31);
            Dashboard.OverrideDefault.Border.Color1 = Color.FromArgb(31, 31, 31);
            Dashboard.OverrideDefault.Border.Color2 = Color.FromArgb(31, 31, 31);
            Dashboard.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(0, 153, 255);
            Dashboard.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(0, 153, 255);
            Dashboard.OverrideFocus.Back.Color1 = Color.FromArgb(31, 31, 31);
            Dashboard.OverrideFocus.Back.Color2 = Color.FromArgb(31, 31, 31);
            Dashboard.OverrideFocus.Border.Color1 = Color.FromArgb(31, 31, 31);
            Dashboard.OverrideFocus.Border.Color2 = Color.FromArgb(31, 31, 31);
            Dashboard.Size = new Size(245, 84);
            Dashboard.StateCommon.Back.Color1 = Color.FromArgb(44, 72, 117);
            Dashboard.StateCommon.Back.Color2 = Color.FromArgb(44, 72, 117);
            Dashboard.StateCommon.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            Dashboard.StateCommon.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            Dashboard.StateDisabled.Back.Color1 = Color.FromArgb(44, 72, 117);
            Dashboard.StateDisabled.Back.Color2 = Color.FromArgb(44, 72, 117);
            Dashboard.StateNormal.Back.Color1 = Color.FromArgb(15, 15, 15);
            Dashboard.StateNormal.Back.Color2 = Color.FromArgb(15, 15, 15);
            Dashboard.StateNormal.Border.Color1 = Color.FromArgb(15, 15, 15);
            Dashboard.StateNormal.Border.Color2 = Color.FromArgb(15, 15, 15);
            Dashboard.StateNormal.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            Dashboard.StateNormal.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            Dashboard.StatePressed.Back.Color1 = Color.FromArgb(46, 46, 46);
            Dashboard.StatePressed.Back.Color2 = Color.FromArgb(46, 46, 46);
            Dashboard.TabIndex = 2;
            Dashboard.Values.DropDownArrowColor = Color.AliceBlue;
            Dashboard.Values.Text = "Dashboard";
            Dashboard.Click += Dashboard_Click;
            // 
            // ViewEvents
            // 
            ViewEvents.Location = new Point(3, 93);
            ViewEvents.Name = "ViewEvents";
            ViewEvents.OverrideDefault.Back.Color1 = Color.FromArgb(31, 31, 31);
            ViewEvents.OverrideDefault.Back.Color2 = Color.FromArgb(31, 31, 31);
            ViewEvents.OverrideDefault.Border.Color1 = Color.FromArgb(31, 31, 31);
            ViewEvents.OverrideDefault.Border.Color2 = Color.FromArgb(31, 31, 31);
            ViewEvents.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(0, 153, 255);
            ViewEvents.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(0, 153, 255);
            ViewEvents.OverrideFocus.Back.Color1 = Color.FromArgb(31, 31, 31);
            ViewEvents.OverrideFocus.Back.Color2 = Color.FromArgb(31, 31, 31);
            ViewEvents.OverrideFocus.Border.Color1 = Color.FromArgb(31, 31, 31);
            ViewEvents.OverrideFocus.Border.Color2 = Color.FromArgb(31, 31, 31);
            ViewEvents.Size = new Size(245, 84);
            ViewEvents.StateCommon.Back.Color1 = Color.FromArgb(44, 72, 117);
            ViewEvents.StateCommon.Back.Color2 = Color.FromArgb(44, 72, 117);
            ViewEvents.StateCommon.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            ViewEvents.StateCommon.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            ViewEvents.StateDisabled.Back.Color1 = Color.FromArgb(44, 72, 117);
            ViewEvents.StateDisabled.Back.Color2 = Color.FromArgb(44, 72, 117);
            ViewEvents.StateNormal.Back.Color1 = Color.FromArgb(15, 15, 15);
            ViewEvents.StateNormal.Back.Color2 = Color.FromArgb(15, 15, 15);
            ViewEvents.StateNormal.Border.Color1 = Color.FromArgb(15, 15, 15);
            ViewEvents.StateNormal.Border.Color2 = Color.FromArgb(15, 15, 15);
            ViewEvents.StateNormal.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            ViewEvents.StateNormal.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            ViewEvents.StatePressed.Back.Color1 = Color.FromArgb(46, 46, 46);
            ViewEvents.StatePressed.Back.Color2 = Color.FromArgb(46, 46, 46);
            ViewEvents.TabIndex = 1;
            ViewEvents.Values.DropDownArrowColor = Color.AliceBlue;
            ViewEvents.Values.Text = "View Events";
            ViewEvents.Click += ViewEvents_Click;
            // 
            // ManageEvents
            // 
            ManageEvents.Location = new Point(3, 183);
            ManageEvents.Name = "ManageEvents";
            ManageEvents.OverrideDefault.Back.Color1 = Color.FromArgb(31, 31, 31);
            ManageEvents.OverrideDefault.Back.Color2 = Color.FromArgb(31, 31, 31);
            ManageEvents.OverrideDefault.Border.Color1 = Color.FromArgb(31, 31, 31);
            ManageEvents.OverrideDefault.Border.Color2 = Color.FromArgb(31, 31, 31);
            ManageEvents.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(0, 153, 255);
            ManageEvents.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(0, 153, 255);
            ManageEvents.OverrideFocus.Back.Color1 = Color.FromArgb(31, 31, 31);
            ManageEvents.OverrideFocus.Back.Color2 = Color.FromArgb(31, 31, 31);
            ManageEvents.OverrideFocus.Border.Color1 = Color.FromArgb(31, 31, 31);
            ManageEvents.OverrideFocus.Border.Color2 = Color.FromArgb(31, 31, 31);
            ManageEvents.Size = new Size(245, 84);
            ManageEvents.StateCommon.Back.Color1 = Color.FromArgb(44, 72, 117);
            ManageEvents.StateCommon.Back.Color2 = Color.FromArgb(44, 72, 117);
            ManageEvents.StateCommon.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            ManageEvents.StateCommon.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            ManageEvents.StateDisabled.Back.Color1 = Color.FromArgb(44, 72, 117);
            ManageEvents.StateDisabled.Back.Color2 = Color.FromArgb(44, 72, 117);
            ManageEvents.StateNormal.Back.Color1 = Color.FromArgb(15, 15, 15);
            ManageEvents.StateNormal.Back.Color2 = Color.FromArgb(15, 15, 15);
            ManageEvents.StateNormal.Border.Color1 = Color.FromArgb(15, 15, 15);
            ManageEvents.StateNormal.Border.Color2 = Color.FromArgb(15, 15, 15);
            ManageEvents.StateNormal.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            ManageEvents.StateNormal.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            ManageEvents.StatePressed.Back.Color1 = Color.FromArgb(46, 46, 46);
            ManageEvents.StatePressed.Back.Color2 = Color.FromArgb(46, 46, 46);
            ManageEvents.TabIndex = 5;
            ManageEvents.Values.DropDownArrowColor = Color.AliceBlue;
            ManageEvents.Values.Text = "Manage Events";
            ManageEvents.Click += ManageEvents_Click;
            // 
            // ManageBookings
            // 
            ManageBookings.Location = new Point(3, 273);
            ManageBookings.Name = "ManageBookings";
            ManageBookings.OverrideDefault.Back.Color1 = Color.FromArgb(31, 31, 31);
            ManageBookings.OverrideDefault.Back.Color2 = Color.FromArgb(31, 31, 31);
            ManageBookings.OverrideDefault.Border.Color1 = Color.FromArgb(31, 31, 31);
            ManageBookings.OverrideDefault.Border.Color2 = Color.FromArgb(31, 31, 31);
            ManageBookings.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(0, 153, 255);
            ManageBookings.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(0, 153, 255);
            ManageBookings.OverrideFocus.Back.Color1 = Color.FromArgb(31, 31, 31);
            ManageBookings.OverrideFocus.Back.Color2 = Color.FromArgb(31, 31, 31);
            ManageBookings.OverrideFocus.Border.Color1 = Color.FromArgb(31, 31, 31);
            ManageBookings.OverrideFocus.Border.Color2 = Color.FromArgb(31, 31, 31);
            ManageBookings.Size = new Size(245, 84);
            ManageBookings.StateCommon.Back.Color1 = Color.FromArgb(44, 72, 117);
            ManageBookings.StateCommon.Back.Color2 = Color.FromArgb(44, 72, 117);
            ManageBookings.StateCommon.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            ManageBookings.StateCommon.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            ManageBookings.StateDisabled.Back.Color1 = Color.FromArgb(44, 72, 117);
            ManageBookings.StateDisabled.Back.Color2 = Color.FromArgb(44, 72, 117);
            ManageBookings.StateNormal.Back.Color1 = Color.FromArgb(15, 15, 15);
            ManageBookings.StateNormal.Back.Color2 = Color.FromArgb(15, 15, 15);
            ManageBookings.StateNormal.Border.Color1 = Color.FromArgb(15, 15, 15);
            ManageBookings.StateNormal.Border.Color2 = Color.FromArgb(15, 15, 15);
            ManageBookings.StateNormal.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            ManageBookings.StateNormal.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            ManageBookings.StatePressed.Back.Color1 = Color.FromArgb(46, 46, 46);
            ManageBookings.StatePressed.Back.Color2 = Color.FromArgb(46, 46, 46);
            ManageBookings.TabIndex = 5;
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