
namespace EventManagementSystem
{
    partial class Admin_Dashboard
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
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            UpdateProfile = new Krypton.Toolkit.KryptonButton();
            LogOut = new Krypton.Toolkit.KryptonButton();
            PhoneNumber = new Label();
            Email = new Label();
            Role = new Label();
            Username = new Label();
            pictureBox1 = new PictureBox();
            kryptonButton5 = new Krypton.Toolkit.KryptonButton();
            kryptonButton3 = new Krypton.Toolkit.KryptonButton();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            mainpanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).BeginInit();
            SuspendLayout();
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(UpdateProfile);
            kryptonPanel1.Controls.Add(LogOut);
            kryptonPanel1.Controls.Add(PhoneNumber);
            kryptonPanel1.Controls.Add(Email);
            kryptonPanel1.Controls.Add(Role);
            kryptonPanel1.Controls.Add(Username);
            kryptonPanel1.Controls.Add(pictureBox1);
            kryptonPanel1.Controls.Add(kryptonButton5);
            kryptonPanel1.Controls.Add(kryptonButton3);
            kryptonPanel1.Controls.Add(kryptonButton1);
            kryptonPanel1.Dock = DockStyle.Left;
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(245, 762);
            kryptonPanel1.StateNormal.Color1 = Color.FromArgb(0, 114, 184);
            kryptonPanel1.StateNormal.Color2 = Color.DeepSkyBlue;
            kryptonPanel1.StateNormal.ColorAngle = 90F;
            kryptonPanel1.StateNormal.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            kryptonPanel1.TabIndex = 0;
            // 
            // UpdateProfile
            // 
            UpdateProfile.Location = new Point(149, 105);
            UpdateProfile.Name = "UpdateProfile";
            UpdateProfile.Size = new Size(35, 35);
            UpdateProfile.StateCommon.Back.Image = Properties.Resources.pen;
            UpdateProfile.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            UpdateProfile.StateCommon.Border.Rounding = 20F;
            UpdateProfile.TabIndex = 0;
            UpdateProfile.Values.DropDownArrowColor = Color.Empty;
            UpdateProfile.Values.Text = "";
            UpdateProfile.Click += UpdateProfile_Click;
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
            LogOut.TabIndex = 15;
            LogOut.Values.DropDownArrowColor = Color.White;
            LogOut.Values.Text = "LogOut";
            LogOut.Click += LogOut_Click;
            // 
            // PhoneNumber
            // 
            PhoneNumber.AutoSize = true;
            PhoneNumber.BackColor = Color.Transparent;
            PhoneNumber.Location = new Point(77, 255);
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.Size = new Size(59, 25);
            PhoneNumber.TabIndex = 20;
            PhoneNumber.Text = "label4";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.BackColor = Color.Transparent;
            Email.Location = new Point(77, 230);
            Email.Name = "Email";
            Email.Size = new Size(59, 25);
            Email.TabIndex = 19;
            Email.Text = "label3";
            // 
            // Role
            // 
            Role.AutoSize = true;
            Role.BackColor = Color.Transparent;
            Role.Location = new Point(77, 196);
            Role.Name = "Role";
            Role.Size = new Size(59, 25);
            Role.TabIndex = 18;
            Role.Text = "label2";
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.BackColor = Color.Transparent;
            Username.Location = new Point(77, 161);
            Username.Name = "Username";
            Username.Size = new Size(59, 25);
            Username.TabIndex = 17;
            Username.Text = "label1";
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
            // kryptonButton5
            // 
            kryptonButton5.ButtonStyle = Krypton.Toolkit.ButtonStyle.NavigatorMini;
            kryptonButton5.Location = new Point(0, 456);
            kryptonButton5.Name = "kryptonButton5";
            kryptonButton5.OverrideDefault.Back.Color1 = Color.FromArgb(28, 28, 28);
            kryptonButton5.OverrideDefault.Back.Color2 = Color.FromArgb(28, 28, 28);
            kryptonButton5.OverrideDefault.Border.Color1 = Color.FromArgb(0, 153, 255);
            kryptonButton5.OverrideDefault.Border.Color2 = Color.FromArgb(0, 153, 255);
            kryptonButton5.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(0, 153, 255);
            kryptonButton5.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(0, 153, 255);
            kryptonButton5.OverrideDefault.Content.ShortText.ColorAngle = 45F;
            kryptonButton5.OverrideDefault.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            kryptonButton5.OverrideFocus.Back.Color1 = Color.FromArgb(25, 25, 25);
            kryptonButton5.OverrideFocus.Back.Color2 = Color.FromArgb(25, 25, 25);
            kryptonButton5.OverrideFocus.Border.Color1 = Color.FromArgb(0, 122, 204);
            kryptonButton5.OverrideFocus.Border.Color2 = Color.FromArgb(0, 122, 204);
            kryptonButton5.Size = new Size(245, 95);
            kryptonButton5.StateCommon.Back.Color1 = Color.FromArgb(0, 90, 156);
            kryptonButton5.StateCommon.Back.Color2 = Color.FromArgb(0, 63, 107);
            kryptonButton5.StateCommon.Back.ColorAngle = 45F;
            kryptonButton5.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            kryptonButton5.StateCommon.Border.Color1 = Color.FromArgb(0, 63, 107);
            kryptonButton5.StateCommon.Border.Color2 = Color.FromArgb(0, 90, 156);
            kryptonButton5.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButton5.StateCommon.Content.ShortText.Color2 = Color.White;
            kryptonButton5.StatePressed.Back.Color1 = Color.FromArgb(0, 63, 107);
            kryptonButton5.StatePressed.Back.Color2 = Color.FromArgb(0, 42, 71);
            kryptonButton5.StatePressed.Border.Color1 = Color.FromArgb(0, 42, 71);
            kryptonButton5.StatePressed.Border.Color2 = Color.FromArgb(0, 63, 107);
            kryptonButton5.StatePressed.Content.ShortText.Color1 = Color.White;
            kryptonButton5.StatePressed.Content.ShortText.Color2 = Color.White;
            kryptonButton5.StateTracking.Back.Color1 = Color.FromArgb(0, 111, 184);
            kryptonButton5.StateTracking.Back.Color2 = Color.FromArgb(0, 77, 128);
            kryptonButton5.StateTracking.Border.Color1 = Color.FromArgb(0, 111, 184);
            kryptonButton5.StateTracking.Border.Color2 = Color.FromArgb(0, 77, 128);
            kryptonButton5.StateTracking.Content.ShortText.Color1 = Color.White;
            kryptonButton5.StateTracking.Content.ShortText.Color2 = Color.White;
            kryptonButton5.TabIndex = 7;
            kryptonButton5.Values.DropDownArrowColor = Color.AliceBlue;
            kryptonButton5.Values.Text = "Past Event Logs";
            kryptonButton5.Click += kryptonButton5_Click;
            // 
            // kryptonButton3
            // 
            kryptonButton3.ButtonStyle = Krypton.Toolkit.ButtonStyle.NavigatorMini;
            kryptonButton3.Location = new Point(0, 577);
            kryptonButton3.Name = "kryptonButton3";
            kryptonButton3.OverrideDefault.Back.Color1 = Color.FromArgb(28, 28, 28);
            kryptonButton3.OverrideDefault.Back.Color2 = Color.FromArgb(28, 28, 28);
            kryptonButton3.OverrideDefault.Border.Color1 = Color.FromArgb(0, 153, 255);
            kryptonButton3.OverrideDefault.Border.Color2 = Color.FromArgb(0, 153, 255);
            kryptonButton3.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(0, 153, 255);
            kryptonButton3.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(0, 153, 255);
            kryptonButton3.OverrideDefault.Content.ShortText.ColorAngle = 45F;
            kryptonButton3.OverrideDefault.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            kryptonButton3.OverrideFocus.Back.Color1 = Color.FromArgb(25, 25, 25);
            kryptonButton3.OverrideFocus.Back.Color2 = Color.FromArgb(25, 25, 25);
            kryptonButton3.OverrideFocus.Border.Color1 = Color.FromArgb(0, 122, 204);
            kryptonButton3.OverrideFocus.Border.Color2 = Color.FromArgb(0, 122, 204);
            kryptonButton3.Size = new Size(245, 95);
            kryptonButton3.StateCommon.Back.Color1 = Color.FromArgb(0, 90, 156);
            kryptonButton3.StateCommon.Back.Color2 = Color.FromArgb(0, 63, 107);
            kryptonButton3.StateCommon.Back.ColorAngle = 45F;
            kryptonButton3.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            kryptonButton3.StateCommon.Border.Color1 = Color.FromArgb(0, 63, 107);
            kryptonButton3.StateCommon.Border.Color2 = Color.FromArgb(0, 90, 156);
            kryptonButton3.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButton3.StateCommon.Content.ShortText.Color2 = Color.White;
            kryptonButton3.StatePressed.Back.Color1 = Color.FromArgb(0, 63, 107);
            kryptonButton3.StatePressed.Back.Color2 = Color.FromArgb(0, 42, 71);
            kryptonButton3.StatePressed.Border.Color1 = Color.FromArgb(0, 42, 71);
            kryptonButton3.StatePressed.Border.Color2 = Color.FromArgb(0, 63, 107);
            kryptonButton3.StatePressed.Content.ShortText.Color1 = Color.White;
            kryptonButton3.StatePressed.Content.ShortText.Color2 = Color.White;
            kryptonButton3.StateTracking.Back.Color1 = Color.FromArgb(0, 111, 184);
            kryptonButton3.StateTracking.Back.Color2 = Color.FromArgb(0, 77, 128);
            kryptonButton3.StateTracking.Border.Color1 = Color.FromArgb(0, 111, 184);
            kryptonButton3.StateTracking.Border.Color2 = Color.FromArgb(0, 77, 128);
            kryptonButton3.StateTracking.Content.ShortText.Color1 = Color.White;
            kryptonButton3.StateTracking.Content.ShortText.Color2 = Color.White;
            kryptonButton3.TabIndex = 3;
            kryptonButton3.Values.DropDownArrowColor = Color.AliceBlue;
            kryptonButton3.Values.Text = "Profile";
            kryptonButton3.Click += kryptonButton3_Click;
            // 
            // kryptonButton1
            // 
            kryptonButton1.ButtonStyle = Krypton.Toolkit.ButtonStyle.NavigatorMini;
            kryptonButton1.Location = new Point(3, 341);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.OverrideDefault.Back.Color1 = Color.FromArgb(28, 28, 28);
            kryptonButton1.OverrideDefault.Back.Color2 = Color.FromArgb(28, 28, 28);
            kryptonButton1.OverrideDefault.Border.Color1 = Color.FromArgb(0, 153, 255);
            kryptonButton1.OverrideDefault.Border.Color2 = Color.FromArgb(0, 153, 255);
            kryptonButton1.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(0, 153, 255);
            kryptonButton1.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(0, 153, 255);
            kryptonButton1.OverrideDefault.Content.ShortText.ColorAngle = 45F;
            kryptonButton1.OverrideDefault.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            kryptonButton1.OverrideFocus.Back.Color1 = Color.FromArgb(25, 25, 25);
            kryptonButton1.OverrideFocus.Back.Color2 = Color.FromArgb(25, 25, 25);
            kryptonButton1.OverrideFocus.Border.Color1 = Color.FromArgb(0, 122, 204);
            kryptonButton1.OverrideFocus.Border.Color2 = Color.FromArgb(0, 122, 204);
            kryptonButton1.Size = new Size(245, 95);
            kryptonButton1.StateCommon.Back.Color1 = Color.FromArgb(0, 90, 156);
            kryptonButton1.StateCommon.Back.Color2 = Color.FromArgb(0, 63, 107);
            kryptonButton1.StateCommon.Back.ColorAngle = 45F;
            kryptonButton1.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            kryptonButton1.StateCommon.Border.Color1 = Color.FromArgb(0, 63, 107);
            kryptonButton1.StateCommon.Border.Color2 = Color.FromArgb(0, 90, 156);
            kryptonButton1.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButton1.StateCommon.Content.ShortText.Color2 = Color.White;
            kryptonButton1.StatePressed.Back.Color1 = Color.FromArgb(0, 63, 107);
            kryptonButton1.StatePressed.Back.Color2 = Color.FromArgb(0, 42, 71);
            kryptonButton1.StatePressed.Border.Color1 = Color.FromArgb(0, 42, 71);
            kryptonButton1.StatePressed.Border.Color2 = Color.FromArgb(0, 63, 107);
            kryptonButton1.StatePressed.Content.ShortText.Color1 = Color.White;
            kryptonButton1.StatePressed.Content.ShortText.Color2 = Color.White;
            kryptonButton1.StateTracking.Back.Color1 = Color.FromArgb(0, 111, 184);
            kryptonButton1.StateTracking.Back.Color2 = Color.FromArgb(0, 77, 128);
            kryptonButton1.StateTracking.Border.Color1 = Color.FromArgb(0, 111, 184);
            kryptonButton1.StateTracking.Border.Color2 = Color.FromArgb(0, 77, 128);
            kryptonButton1.StateTracking.Content.ShortText.Color1 = Color.White;
            kryptonButton1.StateTracking.Content.ShortText.Color2 = Color.White;
            kryptonButton1.TabIndex = 2;
            kryptonButton1.Values.DropDownArrowColor = Color.AliceBlue;
            kryptonButton1.Values.Text = "Manage Events";
            kryptonButton1.Click += kryptonButton1_Click;
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Dock = DockStyle.Top;
            kryptonPanel2.Location = new Point(245, 0);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.Size = new Size(1074, 87);
            kryptonPanel2.StateCommon.Color1 = Color.FromArgb(28, 28, 28);
            kryptonPanel2.StateNormal.Color1 = Color.FromArgb(0, 114, 184);
            kryptonPanel2.StateNormal.Color2 = Color.DeepSkyBlue;
            kryptonPanel2.StateNormal.ColorAngle = 45F;
            kryptonPanel2.StateNormal.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            kryptonPanel2.TabIndex = 1;
            // 
            // mainpanel
            // 
            mainpanel.BackColor = Color.FromArgb(42, 42, 42);
            mainpanel.Dock = DockStyle.Fill;
            mainpanel.Location = new Point(245, 87);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(1074, 675);
            mainpanel.TabIndex = 2;
            // 
            // Admin_Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1319, 762);
            Controls.Add(mainpanel);
            Controls.Add(kryptonPanel2);
            Controls.Add(kryptonPanel1);
            Name = "Admin_Dashboard";
            Text = "Admin_Dashboard";
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).EndInit();
            ResumeLayout(false);
        }

        /* private void Admin_Dashboard_Load(object sender, EventArgs e)
         {
             throw new NotImplementedException();
         }*/

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Panel mainpanel;
        private Krypton.Toolkit.KryptonButton kryptonButton3;
        private Krypton.Toolkit.KryptonButton kryptonButton5;
        private Krypton.Toolkit.KryptonButton LogOut;
        private Label PhoneNumber;
        private Label Email;
        private Label Role;
        private Label Username;
        private PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonButton UpdateProfile;
    }
}