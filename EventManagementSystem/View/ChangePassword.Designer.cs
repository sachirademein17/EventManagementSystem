namespace EventManagementSystem.View
{
    partial class ChangePassword
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
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            confirmnewpasswordtxt = new TextBox();
            newpasswordtxt = new TextBox();
            label3 = new Label();
            label4 = new Label();
            passwordtxt = new TextBox();
            usernametxt = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // kryptonButton1
            // 
            kryptonButton1.Cursor = Cursors.Hand;
            kryptonButton1.Location = new Point(123, 599);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Size = new Size(244, 38);
            kryptonButton1.StateNormal.Back.Color1 = Color.DodgerBlue;
            kryptonButton1.StateNormal.Back.Color2 = SystemColors.HotTrack;
            kryptonButton1.StateNormal.Content.ShortText.Color1 = Color.White;
            kryptonButton1.StateNormal.Content.ShortText.Color2 = Color.White;
            kryptonButton1.StatePressed.Back.Color1 = Color.FromArgb(44, 72, 117);
            kryptonButton1.StatePressed.Back.Color2 = Color.FromArgb(44, 72, 117);
            kryptonButton1.StatePressed.Content.ShortText.Color1 = Color.White;
            kryptonButton1.StatePressed.Content.ShortText.Color2 = Color.White;
            kryptonButton1.TabIndex = 10;
            kryptonButton1.Values.DropDownArrowColor = Color.Empty;
            kryptonButton1.Values.Text = "Change";
            kryptonButton1.Click += kryptonButton1_Click;
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(confirmnewpasswordtxt);
            kryptonPanel1.Controls.Add(newpasswordtxt);
            kryptonPanel1.Controls.Add(label3);
            kryptonPanel1.Controls.Add(label4);
            kryptonPanel1.Controls.Add(passwordtxt);
            kryptonPanel1.Controls.Add(usernametxt);
            kryptonPanel1.Controls.Add(label2);
            kryptonPanel1.Controls.Add(label1);
            kryptonPanel1.Controls.Add(kryptonButton1);
            kryptonPanel1.Dock = DockStyle.Fill;
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(491, 701);
            kryptonPanel1.StateNormal.Color1 = Color.FromArgb(31, 31, 31);
            kryptonPanel1.StateNormal.Color2 = Color.FromArgb(15, 15, 15);
            kryptonPanel1.StateNormal.ColorAngle = 45F;
            kryptonPanel1.StateNormal.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            kryptonPanel1.StateNormal.Draw = Krypton.Toolkit.InheritBool.True;
            kryptonPanel1.StateNormal.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.HighSpeed;
            kryptonPanel1.TabIndex = 17;
            // 
            // confirmnewpasswordtxt
            // 
            confirmnewpasswordtxt.BackColor = Color.FromArgb(31, 31, 31);
            confirmnewpasswordtxt.BorderStyle = BorderStyle.FixedSingle;
            confirmnewpasswordtxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            confirmnewpasswordtxt.ForeColor = Color.FromArgb(255, 211, 128);
            confirmnewpasswordtxt.Location = new Point(113, 461);
            confirmnewpasswordtxt.Name = "confirmnewpasswordtxt";
            confirmnewpasswordtxt.PasswordChar = '•';
            confirmnewpasswordtxt.Size = new Size(270, 35);
            confirmnewpasswordtxt.TabIndex = 18;
            // 
            // newpasswordtxt
            // 
            newpasswordtxt.BackColor = Color.FromArgb(31, 31, 31);
            newpasswordtxt.BorderStyle = BorderStyle.FixedSingle;
            newpasswordtxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newpasswordtxt.ForeColor = Color.FromArgb(255, 211, 128);
            newpasswordtxt.Location = new Point(113, 339);
            newpasswordtxt.Name = "newpasswordtxt";
            newpasswordtxt.Size = new Size(270, 35);
            newpasswordtxt.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 11F);
            label3.ForeColor = Color.FromArgb(224, 224, 224);
            label3.Location = new Point(108, 422);
            label3.Name = "label3";
            label3.Size = new Size(241, 26);
            label3.TabIndex = 16;
            label3.Text = "Confirm New Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 11F);
            label4.ForeColor = Color.FromArgb(224, 224, 224);
            label4.Location = new Point(108, 300);
            label4.Name = "label4";
            label4.Size = new Size(158, 26);
            label4.TabIndex = 15;
            label4.Text = "New Password";
            // 
            // passwordtxt
            // 
            passwordtxt.BackColor = Color.FromArgb(31, 31, 31);
            passwordtxt.BorderStyle = BorderStyle.FixedSingle;
            passwordtxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordtxt.ForeColor = Color.FromArgb(255, 211, 128);
            passwordtxt.Location = new Point(113, 212);
            passwordtxt.Name = "passwordtxt";
            passwordtxt.PasswordChar = '•';
            passwordtxt.Size = new Size(270, 35);
            passwordtxt.TabIndex = 14;
            // 
            // usernametxt
            // 
            usernametxt.BackColor = Color.FromArgb(31, 31, 31);
            usernametxt.BorderStyle = BorderStyle.FixedSingle;
            usernametxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernametxt.ForeColor = Color.FromArgb(255, 211, 128);
            usernametxt.Location = new Point(113, 90);
            usernametxt.Name = "usernametxt";
            usernametxt.Size = new Size(270, 35);
            usernametxt.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 11F);
            label2.ForeColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(108, 173);
            label2.Name = "label2";
            label2.Size = new Size(148, 26);
            label2.TabIndex = 12;
            label2.Text = "Old Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 11F);
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(108, 51);
            label1.Name = "label1";
            label1.Size = new Size(113, 26);
            label1.TabIndex = 11;
            label1.Text = "Username";
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 701);
            Controls.Add(kryptonPanel1);
            Name = "ChangePassword";
            Text = "ChangePassword";
            Load += ChangePassword_Load;
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private TextBox confirmnewpasswordtxt;
        private TextBox newpasswordtxt;
        private Label label3;
        private Label label4;
        private TextBox passwordtxt;
        private TextBox usernametxt;
        private Label label2;
        private Label label1;
    }
}