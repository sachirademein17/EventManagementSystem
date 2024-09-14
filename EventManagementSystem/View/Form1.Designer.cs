
namespace EventManagementSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            usernametxt = new TextBox();
            passwordtxt = new TextBox();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            checkBox1 = new CheckBox();
            kryptonLinkLabel1 = new Krypton.Toolkit.KryptonLinkLabel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // usernametxt
            // 
            usernametxt.BackColor = Color.FromArgb(245, 247, 250);
            usernametxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernametxt.ForeColor = Color.FromArgb(74, 74, 74);
            usernametxt.Location = new Point(110, 304);
            usernametxt.Name = "usernametxt";
            usernametxt.Size = new Size(270, 39);
            usernametxt.TabIndex = 3;
            // 
            // passwordtxt
            // 
            passwordtxt.BackColor = Color.FromArgb(245, 247, 250);
            passwordtxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordtxt.ForeColor = Color.FromArgb(74, 74, 74);
            passwordtxt.Location = new Point(110, 426);
            passwordtxt.Name = "passwordtxt";
            passwordtxt.PasswordChar = '•';
            passwordtxt.Size = new Size(270, 39);
            passwordtxt.TabIndex = 5;
            // 
            // kryptonButton1
            // 
            kryptonButton1.Cursor = Cursors.Hand;
            kryptonButton1.Location = new Point(123, 527);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.OverrideDefault.Back.Color1 = Color.FromArgb(126, 211, 33);
            kryptonButton1.OverrideDefault.Back.Color2 = Color.FromArgb(162, 214, 0);
            kryptonButton1.OverrideDefault.Content.ShortText.Color1 = Color.White;
            kryptonButton1.OverrideDefault.Content.ShortText.Color2 = Color.White;
            kryptonButton1.Size = new Size(244, 38);
            kryptonButton1.StateNormal.Back.Color1 = Color.FromArgb(126, 211, 33);
            kryptonButton1.StateNormal.Back.Color2 = Color.FromArgb(162, 214, 0);
            kryptonButton1.StateNormal.Content.ShortText.Color1 = Color.White;
            kryptonButton1.StateNormal.Content.ShortText.Color2 = Color.White;
            kryptonButton1.StatePressed.Back.Color1 = Color.FromArgb(74, 144, 226);
            kryptonButton1.StatePressed.Back.Color2 = Color.FromArgb(123, 146, 192);
            kryptonButton1.StatePressed.Content.ShortText.Color1 = Color.White;
            kryptonButton1.StatePressed.Content.ShortText.Color2 = Color.White;
            kryptonButton1.StateTracking.Back.Color1 = Color.FromArgb(65, 117, 5);
            kryptonButton1.StateTracking.Back.Color2 = Color.FromArgb(91, 159, 0);
            kryptonButton1.StateTracking.Content.ShortText.Color1 = Color.White;
            kryptonButton1.StateTracking.Content.ShortText.Color2 = Color.White;
            kryptonButton1.TabIndex = 10;
            kryptonButton1.Values.DropDownArrowColor = Color.Empty;
            kryptonButton1.Values.Text = "LOGIN";
            kryptonButton1.Click += kryptonButton1_Click;
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(checkBox1);
            kryptonPanel1.Controls.Add(kryptonLinkLabel1);
            kryptonPanel1.Controls.Add(label3);
            kryptonPanel1.Controls.Add(kryptonButton1);
            kryptonPanel1.Controls.Add(label2);
            kryptonPanel1.Controls.Add(label1);
            kryptonPanel1.Controls.Add(pictureBox1);
            kryptonPanel1.Dock = DockStyle.Fill;
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(491, 701);
            kryptonPanel1.StateNormal.Color1 = Color.FromArgb(74, 144, 226);
            kryptonPanel1.StateNormal.Color2 = Color.FromArgb(80, 227, 194);
            kryptonPanel1.StateNormal.ColorAngle = 45F;
            kryptonPanel1.StateNormal.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            kryptonPanel1.StateNormal.Draw = Krypton.Toolkit.InheritBool.True;
            kryptonPanel1.StateNormal.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.HighSpeed;
            kryptonPanel1.TabIndex = 16;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(110, 482);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(162, 29);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // kryptonLinkLabel1
            // 
            kryptonLinkLabel1.Location = new Point(159, 626);
            kryptonLinkLabel1.Name = "kryptonLinkLabel1";
            kryptonLinkLabel1.OverrideFocus.ShortText.Color1 = Color.Purple;
            kryptonLinkLabel1.OverrideFocus.ShortText.Color2 = Color.Purple;
            kryptonLinkLabel1.OverrideNotVisited.ShortText.Color1 = Color.White;
            kryptonLinkLabel1.OverrideNotVisited.ShortText.Color2 = Color.White;
            kryptonLinkLabel1.Size = new Size(138, 29);
            kryptonLinkLabel1.TabIndex = 8;
            kryptonLinkLabel1.Values.Text = "Create Account";
            kryptonLinkLabel1.LinkClicked += kryptonLinkLabel1_LinkClicked_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 11F);
            label3.ForeColor = Color.Azure;
            label3.Location = new Point(123, 584);
            label3.Name = "label3";
            label3.Size = new Size(243, 30);
            label3.TabIndex = 3;
            label3.Text = "Don't have an account ?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(105, 387);
            label2.Name = "label2";
            label2.Size = new Size(103, 30);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(105, 265);
            label1.Name = "label1";
            label1.Size = new Size(111, 30);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.login;
            pictureBox1.Location = new Point(159, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(172, 168);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(491, 701);
            Controls.Add(passwordtxt);
            Controls.Add(usernametxt);
            Controls.Add(kryptonPanel1);
            ForeColor = Color.FromArgb(224, 224, 224);
            Name = "Form1";
            Text = "Sign In";
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void kryptonLinkLabel1_LinkClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

#endregion
        private TextBox usernametxt;
        private TextBox passwordtxt;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Krypton.Toolkit.KryptonLinkLabel kryptonLinkLabel1;
        private CheckBox checkBox1;
    }
}
