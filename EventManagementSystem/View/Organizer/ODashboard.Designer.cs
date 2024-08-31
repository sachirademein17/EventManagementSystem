namespace EventManagementSystem
{
    partial class ODashboard
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
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            Username = new Label();
            panel3 = new Panel();
            Role = new Label();
            label2 = new Label();
            panel4 = new Panel();
            Email = new Label();
            label3 = new Label();
            panel5 = new Panel();
            PhoneNumber = new Label();
            label4 = new Label();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            kryptonButton2 = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Properties.Resources.profile;
            pictureBox1.Location = new Point(-3, -5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(335, 196);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(Username);
            panel2.ForeColor = SystemColors.ControlLightLight;
            panel2.Location = new Point(0, 198);
            panel2.Name = "panel2";
            panel2.Size = new Size(328, 39);
            panel2.TabIndex = 1;
            // 
            // Username
            // 
            Username.Dock = DockStyle.Fill;
            Username.Font = new Font("Microsoft Sans Serif", 12F);
            Username.Location = new Point(0, 0);
            Username.Name = "Username";
            Username.Size = new Size(328, 39);
            Username.TabIndex = 0;
            Username.Text = "UserName";
            Username.TextAlign = ContentAlignment.MiddleCenter;
            Username.Click += Username_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(Role);
            panel3.Controls.Add(label2);
            panel3.ForeColor = SystemColors.ControlLightLight;
            panel3.Location = new Point(0, 240);
            panel3.Name = "panel3";
            panel3.Size = new Size(328, 39);
            panel3.TabIndex = 2;
            // 
            // Role
            // 
            Role.Dock = DockStyle.Fill;
            Role.Font = new Font("Microsoft Sans Serif", 12F);
            Role.Location = new Point(0, 0);
            Role.Name = "Role";
            Role.Size = new Size(328, 39);
            Role.TabIndex = 1;
            Role.Text = "Role";
            Role.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.Location = new Point(-3, 0);
            label2.Name = "label2";
            label2.Size = new Size(428, 0);
            label2.TabIndex = 0;
            label2.Text = "UserName";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.Controls.Add(Email);
            panel4.Controls.Add(label3);
            panel4.ForeColor = SystemColors.ControlLightLight;
            panel4.Location = new Point(0, 282);
            panel4.Name = "panel4";
            panel4.Size = new Size(328, 39);
            panel4.TabIndex = 3;
            // 
            // Email
            // 
            Email.Dock = DockStyle.Fill;
            Email.Font = new Font("Microsoft Sans Serif", 12F);
            Email.Location = new Point(0, 0);
            Email.Name = "Email";
            Email.Size = new Size(328, 39);
            Email.TabIndex = 1;
            Email.Text = "Email";
            Email.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.Font = new Font("Microsoft Sans Serif", 12F);
            label3.Location = new Point(-3, 0);
            label3.Name = "label3";
            label3.Size = new Size(428, 0);
            label3.TabIndex = 0;
            label3.Text = "UserName";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.Controls.Add(PhoneNumber);
            panel5.Controls.Add(label4);
            panel5.ForeColor = SystemColors.ControlLightLight;
            panel5.Location = new Point(0, 324);
            panel5.Name = "panel5";
            panel5.Size = new Size(328, 39);
            panel5.TabIndex = 4;
            // 
            // PhoneNumber
            // 
            PhoneNumber.Dock = DockStyle.Fill;
            PhoneNumber.Font = new Font("Microsoft Sans Serif", 12F);
            PhoneNumber.Location = new Point(0, 0);
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.Size = new Size(328, 39);
            PhoneNumber.TabIndex = 1;
            PhoneNumber.Text = "Phone Number";
            PhoneNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.Font = new Font("Microsoft Sans Serif", 12F);
            label4.Location = new Point(-3, 0);
            label4.Name = "label4";
            label4.Size = new Size(428, 0);
            label4.TabIndex = 0;
            label4.Text = "UserName";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(kryptonButton1);
            kryptonPanel1.Controls.Add(kryptonButton2);
            kryptonPanel1.Controls.Add(pictureBox1);
            kryptonPanel1.Controls.Add(panel5);
            kryptonPanel1.Controls.Add(panel3);
            kryptonPanel1.Controls.Add(panel4);
            kryptonPanel1.Controls.Add(panel2);
            kryptonPanel1.Dock = DockStyle.Left;
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(328, 675);
            kryptonPanel1.StateNormal.Color1 = Color.FromArgb(42, 42, 42);
            kryptonPanel1.StateNormal.Color2 = Color.FromArgb(42, 42, 42);
            kryptonPanel1.TabIndex = 5;
            // 
            // kryptonButton1
            // 
            kryptonButton1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            kryptonButton1.Location = new Point(-3, 591);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.OverrideDefault.Back.Color1 = Color.FromArgb(31, 31, 31);
            kryptonButton1.OverrideDefault.Back.Color2 = Color.FromArgb(31, 31, 31);
            kryptonButton1.OverrideDefault.Border.Color1 = Color.FromArgb(31, 31, 31);
            kryptonButton1.OverrideDefault.Border.Color2 = Color.FromArgb(31, 31, 31);
            kryptonButton1.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(0, 153, 255);
            kryptonButton1.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(0, 153, 255);
            kryptonButton1.OverrideFocus.Back.Color1 = Color.FromArgb(31, 31, 31);
            kryptonButton1.OverrideFocus.Back.Color2 = Color.FromArgb(31, 31, 31);
            kryptonButton1.OverrideFocus.Border.Color1 = Color.FromArgb(31, 31, 31);
            kryptonButton1.OverrideFocus.Border.Color2 = Color.FromArgb(31, 31, 31);
            kryptonButton1.Size = new Size(328, 84);
            kryptonButton1.StateCommon.Back.Color1 = Color.FromArgb(44, 72, 117);
            kryptonButton1.StateCommon.Back.Color2 = Color.FromArgb(44, 72, 117);
            kryptonButton1.StateCommon.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButton1.StateCommon.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButton1.StateDisabled.Back.Color1 = Color.FromArgb(44, 72, 117);
            kryptonButton1.StateDisabled.Back.Color2 = Color.FromArgb(44, 72, 117);
            kryptonButton1.StateNormal.Back.Color1 = Color.FromArgb(54, 69, 79);
            kryptonButton1.StateNormal.Back.Color2 = Color.FromArgb(79, 85, 90);
            kryptonButton1.StateNormal.Back.ColorAngle = 45F;
            kryptonButton1.StateNormal.Border.Color1 = Color.FromArgb(15, 15, 15);
            kryptonButton1.StateNormal.Border.Color2 = Color.FromArgb(15, 15, 15);
            kryptonButton1.StateNormal.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButton1.StateNormal.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButton1.StatePressed.Back.Color1 = Color.FromArgb(46, 46, 46);
            kryptonButton1.StatePressed.Back.Color2 = Color.FromArgb(46, 46, 46);
            kryptonButton1.TabIndex = 6;
            kryptonButton1.Values.DropDownArrowColor = Color.AliceBlue;
            kryptonButton1.Values.Text = "Delete Profile";
            kryptonButton1.Click += kryptonButton1_Click;
            // 
            // kryptonButton2
            // 
            kryptonButton2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            kryptonButton2.Location = new Point(-3, 510);
            kryptonButton2.Name = "kryptonButton2";
            kryptonButton2.OverrideDefault.Back.Color1 = Color.FromArgb(31, 31, 31);
            kryptonButton2.OverrideDefault.Back.Color2 = Color.FromArgb(31, 31, 31);
            kryptonButton2.OverrideDefault.Border.Color1 = Color.FromArgb(31, 31, 31);
            kryptonButton2.OverrideDefault.Border.Color2 = Color.FromArgb(31, 31, 31);
            kryptonButton2.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(0, 153, 255);
            kryptonButton2.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(0, 153, 255);
            kryptonButton2.OverrideFocus.Back.Color1 = Color.FromArgb(31, 31, 31);
            kryptonButton2.OverrideFocus.Back.Color2 = Color.FromArgb(31, 31, 31);
            kryptonButton2.OverrideFocus.Border.Color1 = Color.FromArgb(31, 31, 31);
            kryptonButton2.OverrideFocus.Border.Color2 = Color.FromArgb(31, 31, 31);
            kryptonButton2.Size = new Size(328, 84);
            kryptonButton2.StateCommon.Back.Color1 = Color.FromArgb(44, 72, 117);
            kryptonButton2.StateCommon.Back.Color2 = Color.FromArgb(44, 72, 117);
            kryptonButton2.StateCommon.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButton2.StateCommon.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButton2.StateDisabled.Back.Color1 = Color.FromArgb(44, 72, 117);
            kryptonButton2.StateDisabled.Back.Color2 = Color.FromArgb(44, 72, 117);
            kryptonButton2.StateNormal.Back.Color1 = Color.FromArgb(54, 69, 79);
            kryptonButton2.StateNormal.Back.Color2 = Color.FromArgb(79, 85, 90);
            kryptonButton2.StateNormal.Back.ColorAngle = 45F;
            kryptonButton2.StateNormal.Border.Color1 = Color.FromArgb(15, 15, 15);
            kryptonButton2.StateNormal.Border.Color2 = Color.FromArgb(15, 15, 15);
            kryptonButton2.StateNormal.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButton2.StateNormal.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButton2.StatePressed.Back.Color1 = Color.FromArgb(46, 46, 46);
            kryptonButton2.StatePressed.Back.Color2 = Color.FromArgb(46, 46, 46);
            kryptonButton2.TabIndex = 5;
            kryptonButton2.Values.DropDownArrowColor = Color.AliceBlue;
            kryptonButton2.Values.Text = "Change Password";
            kryptonButton2.Click += kryptonButton2_Click;
            // 
            // ODashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 42, 42);
            ClientSize = new Size(1074, 675);
            Controls.Add(kryptonPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ODashboard";
            Text = "ODashboard";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label Username;
        private Panel panel3;
        private Label Role;
        private Label label2;
        private Panel panel4;
        private Label Email;
        private Label label3;
        private Panel panel5;
        private Label PhoneNumber;
        private Label label4;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonButton kryptonButton2;
    }
}