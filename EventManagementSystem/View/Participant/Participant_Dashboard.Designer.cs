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
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            Dashboard = new Krypton.Toolkit.KryptonButton();
            EventRegistration = new Krypton.Toolkit.KryptonButton();
            LogOut = new Krypton.Toolkit.KryptonButton();
            button1 = new Button();
            button3 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).BeginInit();
            kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
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
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(Dashboard);
            kryptonPanel1.Controls.Add(EventRegistration);
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
            // Dashboard
            // 
            Dashboard.ButtonStyle = Krypton.Toolkit.ButtonStyle.NavigatorMini;
            Dashboard.Location = new Point(0, 182);
            Dashboard.Name = "Dashboard";
            Dashboard.OverrideDefault.Back.Color1 = Color.FromArgb(75, 75, 75);
            Dashboard.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            Dashboard.OverrideDefault.Border.Color1 = Color.FromArgb(0, 114, 184);
            Dashboard.OverrideDefault.Content.ShortText.Color1 = Color.LimeGreen;
            Dashboard.OverrideDefault.Content.ShortText.Color2 = Color.ForestGreen;
            Dashboard.OverrideDefault.Content.ShortText.ColorAngle = 45F;
            Dashboard.OverrideDefault.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            Dashboard.Size = new Size(258, 95);
            Dashboard.StateCommon.Back.Color1 = Color.FromArgb(0, 90, 156);
            Dashboard.StateCommon.Back.Color2 = Color.FromArgb(0, 63, 107);
            Dashboard.StateCommon.Back.ColorAngle = 45F;
            Dashboard.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            Dashboard.StateCommon.Content.ShortText.Color1 = Color.White;
            Dashboard.StateCommon.Content.ShortText.Color2 = Color.White;
            Dashboard.StatePressed.Back.Color1 = Color.FromArgb(0, 63, 107);
            Dashboard.StatePressed.Back.Color2 = Color.FromArgb(0, 42, 71);
            Dashboard.StatePressed.Content.ShortText.Color1 = Color.White;
            Dashboard.StatePressed.Content.ShortText.Color2 = Color.White;
            Dashboard.StateTracking.Back.Color1 = Color.FromArgb(0, 111, 184);
            Dashboard.StateTracking.Back.Color2 = Color.FromArgb(0, 77, 128);
            Dashboard.StateTracking.Content.ShortText.Color1 = Color.White;
            Dashboard.StateTracking.Content.ShortText.Color2 = Color.White;
            Dashboard.TabIndex = 3;
            Dashboard.Values.DropDownArrowColor = Color.AliceBlue;
            Dashboard.Values.Text = "Dashboard";
            Dashboard.Click += Dashboard_Click;
            // 
            // EventRegistration
            // 
            EventRegistration.ButtonStyle = Krypton.Toolkit.ButtonStyle.NavigatorMini;
            EventRegistration.Location = new Point(0, 87);
            EventRegistration.Name = "EventRegistration";
            EventRegistration.OverrideDefault.Back.Color1 = Color.FromArgb(75, 75, 75);
            EventRegistration.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            EventRegistration.OverrideDefault.Border.Color1 = Color.FromArgb(0, 114, 184);
            EventRegistration.OverrideDefault.Content.ShortText.Color1 = Color.LimeGreen;
            EventRegistration.OverrideDefault.Content.ShortText.Color2 = Color.ForestGreen;
            EventRegistration.OverrideDefault.Content.ShortText.ColorAngle = 45F;
            EventRegistration.OverrideDefault.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            EventRegistration.Size = new Size(258, 95);
            EventRegistration.StateCommon.Back.Color1 = Color.FromArgb(0, 90, 156);
            EventRegistration.StateCommon.Back.Color2 = Color.FromArgb(0, 63, 107);
            EventRegistration.StateCommon.Back.ColorAngle = 45F;
            EventRegistration.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            EventRegistration.StateCommon.Content.ShortText.Color1 = Color.White;
            EventRegistration.StateCommon.Content.ShortText.Color2 = Color.White;
            EventRegistration.StatePressed.Back.Color1 = Color.FromArgb(0, 63, 107);
            EventRegistration.StatePressed.Back.Color2 = Color.FromArgb(0, 42, 71);
            EventRegistration.StatePressed.Content.ShortText.Color1 = Color.White;
            EventRegistration.StatePressed.Content.ShortText.Color2 = Color.White;
            EventRegistration.StateTracking.Back.Color1 = Color.FromArgb(0, 111, 184);
            EventRegistration.StateTracking.Back.Color2 = Color.FromArgb(0, 77, 128);
            EventRegistration.StateTracking.Content.ShortText.Color1 = Color.White;
            EventRegistration.StateTracking.Content.ShortText.Color2 = Color.White;
            EventRegistration.TabIndex = 4;
            EventRegistration.Values.DropDownArrowColor = Color.AliceBlue;
            EventRegistration.Values.Text = "Event Registration";
            EventRegistration.Click += EventRegistration_Click;
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
            ResumeLayout(false);
        }

        #endregion

        private Panel mainpanel;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonButton Dashboard;
        private Krypton.Toolkit.KryptonButton EventRegistration;
        private Krypton.Toolkit.KryptonButton LogOut;
        private Button button2;
        private Button button3;
        private Button button1;
    }
}