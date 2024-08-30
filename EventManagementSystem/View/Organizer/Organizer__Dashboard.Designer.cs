﻿namespace EventManagementSystem
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
            kryptonButton5 = new Krypton.Toolkit.KryptonButton();
            flowLayoutPanel1 = new FlowLayoutPanel();
            kryptonButton2 = new Krypton.Toolkit.KryptonButton();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            kryptonButton3 = new Krypton.Toolkit.KryptonButton();
            kryptonButton4 = new Krypton.Toolkit.KryptonButton();
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
            kryptonPanel1.Controls.Add(kryptonButton5);
            kryptonPanel1.Controls.Add(flowLayoutPanel1);
            kryptonPanel1.Dock = DockStyle.Left;
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(245, 762);
            kryptonPanel1.StateCommon.Color1 = Color.FromArgb(15, 15, 15);
            kryptonPanel1.StateCommon.Color2 = Color.FromArgb(15, 15, 15);
            kryptonPanel1.TabIndex = 3;
            // 
            // kryptonButton5
            // 
            kryptonButton5.ButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
            kryptonButton5.Location = new Point(0, 678);
            kryptonButton5.Name = "kryptonButton5";
            kryptonButton5.OverrideDefault.Back.Color1 = Color.FromArgb(79, 79, 79);
            kryptonButton5.OverrideDefault.Back.Color2 = Color.FromArgb(79, 79, 79);
            kryptonButton5.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(0, 153, 255);
            kryptonButton5.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(0, 153, 255);
            kryptonButton5.OverrideFocus.Back.Color1 = Color.FromArgb(31, 31, 31);
            kryptonButton5.OverrideFocus.Back.Color2 = Color.FromArgb(31, 31, 31);
            kryptonButton5.Size = new Size(239, 84);
            kryptonButton5.StateCommon.Back.Color1 = Color.FromArgb(44, 72, 117);
            kryptonButton5.StateCommon.Back.Color2 = Color.FromArgb(44, 72, 117);
            kryptonButton5.StateCommon.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButton5.StateCommon.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButton5.StateDisabled.Back.Color1 = Color.FromArgb(44, 72, 117);
            kryptonButton5.StateDisabled.Back.Color2 = Color.FromArgb(44, 72, 117);
            kryptonButton5.StateNormal.Back.Color1 = Color.FromArgb(44, 72, 117);
            kryptonButton5.StateNormal.Back.Color2 = Color.FromArgb(44, 72, 117);
            kryptonButton5.StateNormal.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButton5.StateNormal.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButton5.StatePressed.Back.Color1 = Color.FromArgb(46, 46, 46);
            kryptonButton5.StatePressed.Back.Color2 = Color.FromArgb(46, 46, 46);
            kryptonButton5.TabIndex = 6;
            kryptonButton5.Values.DropDownArrowColor = Color.AliceBlue;
            kryptonButton5.Values.Text = "LogOut";
            kryptonButton5.Click += kryptonButton5_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(15, 15, 15);
            flowLayoutPanel1.Controls.Add(kryptonButton2);
            flowLayoutPanel1.Controls.Add(kryptonButton1);
            flowLayoutPanel1.Controls.Add(kryptonButton3);
            flowLayoutPanel1.Controls.Add(kryptonButton4);
            flowLayoutPanel1.Location = new Point(0, 93);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(245, 374);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // kryptonButton2
            // 
            kryptonButton2.Location = new Point(3, 3);
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
            kryptonButton2.Size = new Size(245, 84);
            kryptonButton2.StateCommon.Back.Color1 = Color.FromArgb(44, 72, 117);
            kryptonButton2.StateCommon.Back.Color2 = Color.FromArgb(44, 72, 117);
            kryptonButton2.StateCommon.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButton2.StateCommon.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButton2.StateDisabled.Back.Color1 = Color.FromArgb(44, 72, 117);
            kryptonButton2.StateDisabled.Back.Color2 = Color.FromArgb(44, 72, 117);
            kryptonButton2.StateNormal.Back.Color1 = Color.FromArgb(15, 15, 15);
            kryptonButton2.StateNormal.Back.Color2 = Color.FromArgb(15, 15, 15);
            kryptonButton2.StateNormal.Border.Color1 = Color.FromArgb(15, 15, 15);
            kryptonButton2.StateNormal.Border.Color2 = Color.FromArgb(15, 15, 15);
            kryptonButton2.StateNormal.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButton2.StateNormal.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButton2.StatePressed.Back.Color1 = Color.FromArgb(46, 46, 46);
            kryptonButton2.StatePressed.Back.Color2 = Color.FromArgb(46, 46, 46);
            kryptonButton2.TabIndex = 2;
            kryptonButton2.Values.DropDownArrowColor = Color.AliceBlue;
            kryptonButton2.Values.Text = "Dashboard";
            kryptonButton2.Click += kryptonButton2_Click;
            // 
            // kryptonButton1
            // 
            kryptonButton1.Location = new Point(3, 93);
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
            kryptonButton1.Size = new Size(245, 84);
            kryptonButton1.StateCommon.Back.Color1 = Color.FromArgb(44, 72, 117);
            kryptonButton1.StateCommon.Back.Color2 = Color.FromArgb(44, 72, 117);
            kryptonButton1.StateCommon.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButton1.StateCommon.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButton1.StateDisabled.Back.Color1 = Color.FromArgb(44, 72, 117);
            kryptonButton1.StateDisabled.Back.Color2 = Color.FromArgb(44, 72, 117);
            kryptonButton1.StateNormal.Back.Color1 = Color.FromArgb(15, 15, 15);
            kryptonButton1.StateNormal.Back.Color2 = Color.FromArgb(15, 15, 15);
            kryptonButton1.StateNormal.Border.Color1 = Color.FromArgb(15, 15, 15);
            kryptonButton1.StateNormal.Border.Color2 = Color.FromArgb(15, 15, 15);
            kryptonButton1.StateNormal.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButton1.StateNormal.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButton1.StatePressed.Back.Color1 = Color.FromArgb(46, 46, 46);
            kryptonButton1.StatePressed.Back.Color2 = Color.FromArgb(46, 46, 46);
            kryptonButton1.TabIndex = 1;
            kryptonButton1.Values.DropDownArrowColor = Color.AliceBlue;
            kryptonButton1.Values.Text = "View Events";
            kryptonButton1.Click += kryptonButton1_Click;
            // 
            // kryptonButton3
            // 
            kryptonButton3.Location = new Point(3, 183);
            kryptonButton3.Name = "kryptonButton3";
            kryptonButton3.OverrideDefault.Back.Color1 = Color.FromArgb(31, 31, 31);
            kryptonButton3.OverrideDefault.Back.Color2 = Color.FromArgb(31, 31, 31);
            kryptonButton3.OverrideDefault.Border.Color1 = Color.FromArgb(31, 31, 31);
            kryptonButton3.OverrideDefault.Border.Color2 = Color.FromArgb(31, 31, 31);
            kryptonButton3.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(0, 153, 255);
            kryptonButton3.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(0, 153, 255);
            kryptonButton3.OverrideFocus.Back.Color1 = Color.FromArgb(31, 31, 31);
            kryptonButton3.OverrideFocus.Back.Color2 = Color.FromArgb(31, 31, 31);
            kryptonButton3.OverrideFocus.Border.Color1 = Color.FromArgb(31, 31, 31);
            kryptonButton3.OverrideFocus.Border.Color2 = Color.FromArgb(31, 31, 31);
            kryptonButton3.Size = new Size(245, 84);
            kryptonButton3.StateCommon.Back.Color1 = Color.FromArgb(44, 72, 117);
            kryptonButton3.StateCommon.Back.Color2 = Color.FromArgb(44, 72, 117);
            kryptonButton3.StateCommon.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButton3.StateCommon.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButton3.StateDisabled.Back.Color1 = Color.FromArgb(44, 72, 117);
            kryptonButton3.StateDisabled.Back.Color2 = Color.FromArgb(44, 72, 117);
            kryptonButton3.StateNormal.Back.Color1 = Color.FromArgb(15, 15, 15);
            kryptonButton3.StateNormal.Back.Color2 = Color.FromArgb(15, 15, 15);
            kryptonButton3.StateNormal.Border.Color1 = Color.FromArgb(15, 15, 15);
            kryptonButton3.StateNormal.Border.Color2 = Color.FromArgb(15, 15, 15);
            kryptonButton3.StateNormal.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButton3.StateNormal.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButton3.StatePressed.Back.Color1 = Color.FromArgb(46, 46, 46);
            kryptonButton3.StatePressed.Back.Color2 = Color.FromArgb(46, 46, 46);
            kryptonButton3.TabIndex = 5;
            kryptonButton3.Values.DropDownArrowColor = Color.AliceBlue;
            kryptonButton3.Values.Text = "Manage Events";
            kryptonButton3.Click += kryptonButton3_Click;
            // 
            // kryptonButton4
            // 
            kryptonButton4.Location = new Point(3, 273);
            kryptonButton4.Name = "kryptonButton4";
            kryptonButton4.OverrideDefault.Back.Color1 = Color.FromArgb(31, 31, 31);
            kryptonButton4.OverrideDefault.Back.Color2 = Color.FromArgb(31, 31, 31);
            kryptonButton4.OverrideDefault.Border.Color1 = Color.FromArgb(31, 31, 31);
            kryptonButton4.OverrideDefault.Border.Color2 = Color.FromArgb(31, 31, 31);
            kryptonButton4.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(0, 153, 255);
            kryptonButton4.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(0, 153, 255);
            kryptonButton4.OverrideFocus.Back.Color1 = Color.FromArgb(31, 31, 31);
            kryptonButton4.OverrideFocus.Back.Color2 = Color.FromArgb(31, 31, 31);
            kryptonButton4.OverrideFocus.Border.Color1 = Color.FromArgb(31, 31, 31);
            kryptonButton4.OverrideFocus.Border.Color2 = Color.FromArgb(31, 31, 31);
            kryptonButton4.Size = new Size(245, 84);
            kryptonButton4.StateCommon.Back.Color1 = Color.FromArgb(44, 72, 117);
            kryptonButton4.StateCommon.Back.Color2 = Color.FromArgb(44, 72, 117);
            kryptonButton4.StateCommon.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButton4.StateCommon.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButton4.StateDisabled.Back.Color1 = Color.FromArgb(44, 72, 117);
            kryptonButton4.StateDisabled.Back.Color2 = Color.FromArgb(44, 72, 117);
            kryptonButton4.StateNormal.Back.Color1 = Color.FromArgb(15, 15, 15);
            kryptonButton4.StateNormal.Back.Color2 = Color.FromArgb(15, 15, 15);
            kryptonButton4.StateNormal.Border.Color1 = Color.FromArgb(15, 15, 15);
            kryptonButton4.StateNormal.Border.Color2 = Color.FromArgb(15, 15, 15);
            kryptonButton4.StateNormal.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButton4.StateNormal.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButton4.StatePressed.Back.Color1 = Color.FromArgb(46, 46, 46);
            kryptonButton4.StatePressed.Back.Color2 = Color.FromArgb(46, 46, 46);
            kryptonButton4.TabIndex = 5;
            kryptonButton4.Values.DropDownArrowColor = Color.AliceBlue;
            kryptonButton4.Values.Text = "View Participants";
            kryptonButton4.Click += kryptonButton4_Click;
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
        private Krypton.Toolkit.KryptonButton kryptonButton2;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonButton kryptonButton3;
        private Krypton.Toolkit.KryptonButton kryptonButton4;
        private Krypton.Toolkit.KryptonButton kryptonButton5;
    }
}