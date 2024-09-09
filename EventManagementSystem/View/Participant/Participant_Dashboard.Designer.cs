﻿namespace EventManagementSystem
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
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            LogOut = new Krypton.Toolkit.KryptonButton();
            flowLayoutPanel1 = new FlowLayoutPanel();
            EventRegistration = new Krypton.Toolkit.KryptonButton();
            Dashboard = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
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
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(LogOut);
            kryptonPanel1.Controls.Add(flowLayoutPanel1);
            kryptonPanel1.Dock = DockStyle.Left;
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(245, 762);
            kryptonPanel1.StateNormal.Color1 = Color.FromArgb(0, 114, 184);
            kryptonPanel1.StateNormal.Color2 = Color.DeepSkyBlue;
            kryptonPanel1.StateNormal.ColorAngle = 45F;
            kryptonPanel1.StateNormal.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            kryptonPanel1.TabIndex = 6;
            // 
            // LogOut
            // 
            LogOut.ButtonStyle = Krypton.Toolkit.ButtonStyle.NavigatorMini;
            LogOut.Location = new Point(0, 667);
            LogOut.Name = "LogOut";
            LogOut.OverrideDefault.Back.Color1 = Color.FromArgb(28, 28, 28);
            LogOut.OverrideDefault.Back.Color2 = Color.FromArgb(28, 28, 28);
            LogOut.OverrideDefault.Content.ShortText.Color1 = Color.White;
            LogOut.OverrideDefault.Content.ShortText.Color2 = Color.White;
            LogOut.Size = new Size(258, 95);
            LogOut.StateCommon.Back.Color1 = Color.FromArgb(28, 28, 28);
            LogOut.StateCommon.Back.Color2 = Color.FromArgb(28, 28, 28);
            LogOut.StateCommon.Content.ShortText.Color1 = Color.White;
            LogOut.StateCommon.Content.ShortText.Color2 = Color.White;
            LogOut.TabIndex = 5;
            LogOut.Values.DropDownArrowColor = Color.AliceBlue;
            LogOut.Values.Text = "LogOut";
            LogOut.Click += LogOut_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.Controls.Add(EventRegistration);
            flowLayoutPanel1.Controls.Add(Dashboard);
            flowLayoutPanel1.Location = new Point(0, 93);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(245, 374);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // EventRegistration
            // 
            EventRegistration.ButtonStyle = Krypton.Toolkit.ButtonStyle.NavigatorMini;
            EventRegistration.Location = new Point(3, 3);
            EventRegistration.Name = "EventRegistration";
            EventRegistration.Size = new Size(258, 95);
            EventRegistration.StateCommon.Back.Color1 = Color.FromArgb(126, 211, 33);
            EventRegistration.StateCommon.Back.Color2 = Color.FromArgb(162, 214, 0);
            EventRegistration.StateCommon.Content.ShortText.Color1 = Color.White;
            EventRegistration.StateCommon.Content.ShortText.Color2 = Color.White;
            EventRegistration.StatePressed.Back.Color1 = Color.FromArgb(74, 144, 226);
            EventRegistration.StatePressed.Back.Color2 = Color.FromArgb(123, 146, 192);
            EventRegistration.StatePressed.Content.ShortText.Color1 = Color.White;
            EventRegistration.StatePressed.Content.ShortText.Color2 = Color.White;
            EventRegistration.StateTracking.Back.Color1 = Color.FromArgb(65, 117, 5);
            EventRegistration.StateTracking.Back.Color2 = Color.FromArgb(91, 159, 0);
            EventRegistration.StateTracking.Content.ShortText.Color1 = Color.White;
            EventRegistration.StateTracking.Content.ShortText.Color2 = Color.White;
            EventRegistration.TabIndex = 4;
            EventRegistration.Values.DropDownArrowColor = Color.AliceBlue;
            EventRegistration.Values.Text = "Event Registration";
            EventRegistration.Click += EventRegistration_Click;
            // 
            // Dashboard
            // 
            Dashboard.ButtonStyle = Krypton.Toolkit.ButtonStyle.NavigatorMini;
            Dashboard.Location = new Point(3, 104);
            Dashboard.Name = "Dashboard";
            Dashboard.Size = new Size(258, 95);
            Dashboard.StateCommon.Back.Color1 = Color.FromArgb(126, 211, 33);
            Dashboard.StateCommon.Back.Color2 = Color.FromArgb(162, 214, 0);
            Dashboard.StateCommon.Content.ShortText.Color1 = Color.White;
            Dashboard.StateCommon.Content.ShortText.Color2 = Color.White;
            Dashboard.StatePressed.Back.Color1 = Color.FromArgb(74, 144, 226);
            Dashboard.StatePressed.Back.Color2 = Color.FromArgb(123, 146, 192);
            Dashboard.StatePressed.Content.ShortText.Color1 = Color.White;
            Dashboard.StatePressed.Content.ShortText.Color2 = Color.White;
            Dashboard.StateTracking.Back.Color1 = Color.FromArgb(65, 117, 5);
            Dashboard.StateTracking.Back.Color2 = Color.FromArgb(91, 159, 0);
            Dashboard.StateTracking.Content.ShortText.Color1 = Color.White;
            Dashboard.StateTracking.Content.ShortText.Color2 = Color.White;
            Dashboard.TabIndex = 3;
            Dashboard.Values.DropDownArrowColor = Color.AliceBlue;
            Dashboard.Values.Text = "Dashboard";
            Dashboard.Click += Dashboard_Click;
            // 
            // Participant_Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1319, 762);
            Controls.Add(mainpanel);
            Controls.Add(kryptonPanel2);
            Controls.Add(kryptonPanel1);
            Name = "Participant_Dashboard";
            Text = "Participant_Dashboard";
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
        private Krypton.Toolkit.KryptonButton EventRegistration;
        private Krypton.Toolkit.KryptonButton LogOut;
    }
}