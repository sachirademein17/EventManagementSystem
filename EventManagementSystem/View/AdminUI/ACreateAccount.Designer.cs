namespace EventManagementSystem
{
    partial class ACreateAccount
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
            usernametxt = new TextBox();
            passwordtxt = new TextBox();
            confirmpasswordtxt = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            phonenumbertxt = new TextBox();
            label7 = new Label();
            emailtxt = new TextBox();
            participantrole = new RadioButton();
            organizerrole = new RadioButton();
            CreateUser = new Krypton.Toolkit.KryptonButton();
            adminrole = new RadioButton();
            SuspendLayout();
            // 
            // usernametxt
            // 
            usernametxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernametxt.Location = new Point(101, 202);
            usernametxt.Name = "usernametxt";
            usernametxt.Size = new Size(270, 35);
            usernametxt.TabIndex = 5;
            // 
            // passwordtxt
            // 
            passwordtxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordtxt.Location = new Point(101, 326);
            passwordtxt.Name = "passwordtxt";
            passwordtxt.PasswordChar = '∗';
            passwordtxt.Size = new Size(270, 35);
            passwordtxt.TabIndex = 8;
            // 
            // confirmpasswordtxt
            // 
            confirmpasswordtxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            confirmpasswordtxt.Location = new Point(101, 449);
            confirmpasswordtxt.Name = "confirmpasswordtxt";
            confirmpasswordtxt.PasswordChar = '∗';
            confirmpasswordtxt.Size = new Size(270, 35);
            confirmpasswordtxt.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(176, 176, 176);
            label4.Location = new Point(101, 397);
            label4.Name = "label4";
            label4.Size = new Size(210, 29);
            label4.TabIndex = 9;
            label4.Text = "Confirm Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(176, 176, 176);
            label3.Location = new Point(101, 274);
            label3.Name = "label3";
            label3.Size = new Size(120, 29);
            label3.TabIndex = 7;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(101, 150);
            label2.Name = "label2";
            label2.Size = new Size(124, 29);
            label2.TabIndex = 4;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 16F);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(317, 56);
            label1.Name = "label1";
            label1.Size = new Size(238, 37);
            label1.TabIndex = 6;
            label1.Text = "Create Account";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(176, 176, 176);
            label5.Location = new Point(526, 397);
            label5.Name = "label5";
            label5.Size = new Size(64, 29);
            label5.TabIndex = 12;
            label5.Text = "Role";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Transparent;
            label6.Location = new Point(516, 150);
            label6.Name = "label6";
            label6.Size = new Size(74, 29);
            label6.TabIndex = 16;
            label6.Text = "Email";
            // 
            // phonenumbertxt
            // 
            phonenumbertxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phonenumbertxt.Location = new Point(516, 326);
            phonenumbertxt.Name = "phonenumbertxt";
            phonenumbertxt.PasswordChar = '∗';
            phonenumbertxt.Size = new Size(270, 35);
            phonenumbertxt.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(176, 176, 176);
            label7.Location = new Point(516, 274);
            label7.Name = "label7";
            label7.Size = new Size(176, 29);
            label7.TabIndex = 18;
            label7.Text = "Phone Number";
            // 
            // emailtxt
            // 
            emailtxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailtxt.Location = new Point(516, 202);
            emailtxt.Name = "emailtxt";
            emailtxt.Size = new Size(270, 35);
            emailtxt.TabIndex = 17;
            // 
            // participantrole
            // 
            participantrole.AutoSize = true;
            participantrole.Checked = true;
            participantrole.ForeColor = SystemColors.ControlLightLight;
            participantrole.Location = new Point(516, 455);
            participantrole.Name = "participantrole";
            participantrole.Size = new Size(119, 29);
            participantrole.TabIndex = 20;
            participantrole.TabStop = true;
            participantrole.Text = "Participant";
            participantrole.UseVisualStyleBackColor = true;
            // 
            // organizerrole
            // 
            organizerrole.AutoSize = true;
            organizerrole.ForeColor = SystemColors.ControlLightLight;
            organizerrole.Location = new Point(672, 455);
            organizerrole.Name = "organizerrole";
            organizerrole.Size = new Size(114, 29);
            organizerrole.TabIndex = 21;
            organizerrole.Text = "Organizer";
            organizerrole.UseVisualStyleBackColor = true;
            // 
            // CreateUser
            // 
            CreateUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CreateUser.Cursor = Cursors.Hand;
            CreateUser.Location = new Point(314, 556);
            CreateUser.Name = "CreateUser";
            CreateUser.OverrideDefault.Back.Color1 = Color.FromArgb(0, 209, 161);
            CreateUser.OverrideDefault.Back.Color2 = Color.FromArgb(0, 177, 151);
            CreateUser.Size = new Size(244, 38);
            CreateUser.StateCommon.Back.Color1 = Color.FromArgb(0, 209, 161);
            CreateUser.StateCommon.Back.Color2 = Color.FromArgb(0, 177, 151);
            CreateUser.StateCommon.Back.ColorAngle = 45F;
            CreateUser.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            CreateUser.StateCommon.Border.Color1 = Color.FromArgb(0, 177, 151);
            CreateUser.StateCommon.Border.Color2 = Color.FromArgb(0, 209, 161);
            CreateUser.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            CreateUser.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            CreateUser.StateCommon.Border.Rounding = 20F;
            CreateUser.StateCommon.Border.Width = 1;
            CreateUser.StateCommon.Content.ShortText.Color1 = Color.White;
            CreateUser.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            CreateUser.StateNormal.Back.Color1 = Color.FromArgb(0, 209, 161);
            CreateUser.StateNormal.Back.Color2 = Color.FromArgb(0, 177, 151);
            CreateUser.StateNormal.Back.ColorAngle = 45F;
            CreateUser.StatePressed.Back.Color1 = Color.FromArgb(0, 177, 151);
            CreateUser.StatePressed.Back.Color2 = Color.FromArgb(0, 140, 120);
            CreateUser.StatePressed.Border.Rounding = 20F;
            CreateUser.TabIndex = 22;
            CreateUser.Values.DropDownArrowColor = Color.Empty;
            CreateUser.Values.Text = "CREATE";
            CreateUser.Click += CreateUser_Click_1;
            // 
            // adminrole
            // 
            adminrole.AutoSize = true;
            adminrole.ForeColor = SystemColors.ControlLightLight;
            adminrole.Location = new Point(589, 490);
            adminrole.Name = "adminrole";
            adminrole.Size = new Size(90, 29);
            adminrole.TabIndex = 23;
            adminrole.Text = "Admin";
            adminrole.UseVisualStyleBackColor = true;
            // 
            // ACreateAccount
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 28, 28);
            ClientSize = new Size(873, 667);
            Controls.Add(adminrole);
            Controls.Add(CreateUser);
            Controls.Add(organizerrole);
            Controls.Add(participantrole);
            Controls.Add(label6);
            Controls.Add(phonenumbertxt);
            Controls.Add(label7);
            Controls.Add(emailtxt);
            Controls.Add(label5);
            Controls.Add(confirmpasswordtxt);
            Controls.Add(label4);
            Controls.Add(passwordtxt);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(usernametxt);
            Controls.Add(label2);
            Name = "ACreateAccount";
            Text = "CreateAccount";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernametxt;
        private TextBox passwordtxt;
        private TextBox confirmpasswordtxt;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label6;
        private TextBox phonenumbertxt;
        private Label label7;
        private TextBox emailtxt;
        private RadioButton participantrole;
        private RadioButton organizerrole;
        private Krypton.Toolkit.KryptonButton CreateUser;
        private RadioButton adminrole;
    }
}