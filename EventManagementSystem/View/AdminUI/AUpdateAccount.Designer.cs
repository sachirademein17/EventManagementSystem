namespace EventManagementSystem.View.Admin
{
    partial class AUpdateAccount
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
            organizerrole = new RadioButton();
            participantrole = new RadioButton();
            label6 = new Label();
            phonenumbertxt = new TextBox();
            label7 = new Label();
            emailtxt = new TextBox();
            label5 = new Label();
            confirmpasswordtxt = new TextBox();
            label4 = new Label();
            passwordtxt = new TextBox();
            label3 = new Label();
            label1 = new Label();
            usernametxt = new TextBox();
            label2 = new Label();
            UpdateUser = new Krypton.Toolkit.KryptonButton();
            SuspendLayout();
            // 
            // organizerrole
            // 
            organizerrole.AutoSize = true;
            organizerrole.ForeColor = SystemColors.ControlLightLight;
            organizerrole.Location = new Point(665, 463);
            organizerrole.Name = "organizerrole";
            organizerrole.Size = new Size(114, 29);
            organizerrole.TabIndex = 36;
            organizerrole.Text = "Organizer";
            organizerrole.UseVisualStyleBackColor = true;
            // 
            // participantrole
            // 
            participantrole.AutoSize = true;
            participantrole.Checked = true;
            participantrole.ForeColor = SystemColors.ControlLightLight;
            participantrole.Location = new Point(509, 463);
            participantrole.Name = "participantrole";
            participantrole.Size = new Size(119, 29);
            participantrole.TabIndex = 35;
            participantrole.TabStop = true;
            participantrole.Text = "Participant";
            participantrole.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Transparent;
            label6.Location = new Point(509, 158);
            label6.Name = "label6";
            label6.Size = new Size(74, 29);
            label6.TabIndex = 31;
            label6.Text = "Email";
            // 
            // phonenumbertxt
            // 
            phonenumbertxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phonenumbertxt.Location = new Point(509, 334);
            phonenumbertxt.Name = "phonenumbertxt";
            phonenumbertxt.PasswordChar = '∗';
            phonenumbertxt.Size = new Size(270, 35);
            phonenumbertxt.TabIndex = 34;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(176, 176, 176);
            label7.Location = new Point(509, 282);
            label7.Name = "label7";
            label7.Size = new Size(176, 29);
            label7.TabIndex = 33;
            label7.Text = "Phone Number";
            // 
            // emailtxt
            // 
            emailtxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailtxt.Location = new Point(509, 210);
            emailtxt.Name = "emailtxt";
            emailtxt.Size = new Size(270, 35);
            emailtxt.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(176, 176, 176);
            label5.Location = new Point(519, 405);
            label5.Name = "label5";
            label5.Size = new Size(64, 29);
            label5.TabIndex = 30;
            label5.Text = "Role";
            // 
            // confirmpasswordtxt
            // 
            confirmpasswordtxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            confirmpasswordtxt.Location = new Point(94, 457);
            confirmpasswordtxt.Name = "confirmpasswordtxt";
            confirmpasswordtxt.PasswordChar = '∗';
            confirmpasswordtxt.Size = new Size(270, 35);
            confirmpasswordtxt.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(176, 176, 176);
            label4.Location = new Point(94, 405);
            label4.Name = "label4";
            label4.Size = new Size(210, 29);
            label4.TabIndex = 27;
            label4.Text = "Confirm Password";
            // 
            // passwordtxt
            // 
            passwordtxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordtxt.Location = new Point(94, 334);
            passwordtxt.Name = "passwordtxt";
            passwordtxt.PasswordChar = '∗';
            passwordtxt.Size = new Size(270, 35);
            passwordtxt.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(176, 176, 176);
            label3.Location = new Point(94, 282);
            label3.Name = "label3";
            label3.Size = new Size(120, 29);
            label3.TabIndex = 25;
            label3.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 16F);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(310, 64);
            label1.Name = "label1";
            label1.Size = new Size(246, 37);
            label1.TabIndex = 24;
            label1.Text = "Update Account";
            // 
            // usernametxt
            // 
            usernametxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernametxt.Location = new Point(94, 210);
            usernametxt.Name = "usernametxt";
            usernametxt.Size = new Size(270, 35);
            usernametxt.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(94, 158);
            label2.Name = "label2";
            label2.Size = new Size(124, 29);
            label2.TabIndex = 22;
            label2.Text = "Username";
            // 
            // UpdateUser
            // 
            UpdateUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            UpdateUser.Cursor = Cursors.Hand;
            UpdateUser.Location = new Point(321, 561);
            UpdateUser.Name = "UpdateUser";
            UpdateUser.OverrideDefault.Back.Color1 = Color.FromArgb(0, 140, 255);
            UpdateUser.OverrideDefault.Back.Color2 = Color.FromArgb(0, 120, 230);
            UpdateUser.Size = new Size(230, 38);
            UpdateUser.StateCommon.Back.Color1 = Color.FromArgb(0, 140, 255);
            UpdateUser.StateCommon.Back.Color2 = Color.FromArgb(0, 120, 230);
            UpdateUser.StateCommon.Back.ColorAngle = 45F;
            UpdateUser.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            UpdateUser.StateCommon.Border.Color1 = Color.FromArgb(0, 120, 230);
            UpdateUser.StateCommon.Border.Color2 = Color.FromArgb(0, 140, 255);
            UpdateUser.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            UpdateUser.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            UpdateUser.StateCommon.Border.Rounding = 20F;
            UpdateUser.StateCommon.Border.Width = 1;
            UpdateUser.StateCommon.Content.ShortText.Color1 = Color.White;
            UpdateUser.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            UpdateUser.StateNormal.Back.Color1 = Color.FromArgb(0, 140, 255);
            UpdateUser.StateNormal.Back.Color2 = Color.FromArgb(0, 120, 230);
            UpdateUser.StateNormal.Back.ColorAngle = 45F;
            UpdateUser.StatePressed.Back.Color1 = Color.FromArgb(0, 120, 230);
            UpdateUser.StatePressed.Back.Color2 = Color.FromArgb(0, 100, 200);
            UpdateUser.StatePressed.Border.Rounding = 20F;
            UpdateUser.TabIndex = 37;
            UpdateUser.Values.DropDownArrowColor = Color.Empty;
            UpdateUser.Values.Text = "UPDATE";
            UpdateUser.Click += UpdateUser_Click_1;
            // 
            // AUpdateAccount
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 28, 28);
            ClientSize = new Size(873, 667);
            Controls.Add(UpdateUser);
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
            Name = "AUpdateAccount";
            Text = "UpdateAccount";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton organizerrole;
        private RadioButton participantrole;
        private Label label6;
        private TextBox phonenumbertxt;
        private Label label7;
        private TextBox emailtxt;
        private Label label5;
        private TextBox confirmpasswordtxt;
        private Label label4;
        private TextBox passwordtxt;
        private Label label3;
        private Label label1;
        private TextBox usernametxt;
        private Label label2;
        private Krypton.Toolkit.KryptonButton UpdateUser;
    }
}