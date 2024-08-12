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
            mainpanel = new Panel();
            kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            kryptonButton2 = new Krypton.Toolkit.KryptonButton();
            kryptonButton3 = new Krypton.Toolkit.KryptonButton();
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
            kryptonPanel2.StateCommon.Color1 = Color.FromArgb(28, 28, 28);
            kryptonPanel2.TabIndex = 7;
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(flowLayoutPanel1);
            kryptonPanel1.Dock = DockStyle.Left;
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(245, 762);
            kryptonPanel1.StateNormal.Color1 = Color.FromArgb(28, 28, 28);
            kryptonPanel1.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(28, 28, 28);
            flowLayoutPanel1.Controls.Add(kryptonButton2);
            flowLayoutPanel1.Controls.Add(kryptonButton3);
            flowLayoutPanel1.Location = new Point(0, 93);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(245, 374);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // kryptonButton2
            // 
            kryptonButton2.ButtonStyle = Krypton.Toolkit.ButtonStyle.LowProfile;
            kryptonButton2.Location = new Point(3, 3);
            kryptonButton2.Name = "kryptonButton2";
            kryptonButton2.OverrideDefault.Back.Color1 = Color.FromArgb(28, 28, 28);
            kryptonButton2.OverrideDefault.Back.Color2 = Color.FromArgb(28, 28, 28);
            kryptonButton2.OverrideDefault.Content.ShortText.Color1 = Color.White;
            kryptonButton2.OverrideDefault.Content.ShortText.Color2 = Color.White;
            kryptonButton2.Size = new Size(239, 95);
            kryptonButton2.StateCommon.Back.Color1 = Color.FromArgb(28, 28, 28);
            kryptonButton2.StateCommon.Back.Color2 = Color.FromArgb(28, 28, 28);
            kryptonButton2.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButton2.StateCommon.Content.ShortText.Color2 = Color.White;
            kryptonButton2.TabIndex = 3;
            kryptonButton2.Values.DropDownArrowColor = Color.AliceBlue;
            kryptonButton2.Values.Text = "Dashboard";
            kryptonButton2.Click += kryptonButton2_Click;
            // 
            // kryptonButton3
            // 
            kryptonButton3.ButtonStyle = Krypton.Toolkit.ButtonStyle.LowProfile;
            kryptonButton3.Location = new Point(3, 104);
            kryptonButton3.Name = "kryptonButton3";
            kryptonButton3.OverrideDefault.Back.Color1 = Color.FromArgb(28, 28, 28);
            kryptonButton3.OverrideDefault.Back.Color2 = Color.FromArgb(28, 28, 28);
            kryptonButton3.OverrideDefault.Content.ShortText.Color1 = Color.White;
            kryptonButton3.OverrideDefault.Content.ShortText.Color2 = Color.White;
            kryptonButton3.Size = new Size(239, 84);
            kryptonButton3.StateCommon.Back.Color1 = Color.FromArgb(28, 28, 28);
            kryptonButton3.StateCommon.Back.Color2 = Color.FromArgb(28, 28, 28);
            kryptonButton3.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButton3.StateCommon.Content.ShortText.Color2 = Color.White;
            kryptonButton3.TabIndex = 4;
            kryptonButton3.Values.DropDownArrowColor = Color.AliceBlue;
            kryptonButton3.Values.Text = "Event Registration";
            kryptonButton3.Click += kryptonButton3_Click;
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
        private Krypton.Toolkit.KryptonButton kryptonButton2;
        private Krypton.Toolkit.KryptonButton kryptonButton3;
    }
}