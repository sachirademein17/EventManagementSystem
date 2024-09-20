﻿namespace EventManagementSystem
{
    partial class AdminUpdateEvents
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
            descriptiontxt = new TextBox();
            label8 = new Label();
            label4 = new Label();
            venuetxt = new TextBox();
            label5 = new Label();
            maxParticipantstxt = new TextBox();
            label6 = new Label();
            label1 = new Label();
            UpdateEvemt = new Krypton.Toolkit.KryptonButton();
            nametxt = new TextBox();
            label2 = new Label();
            endDatetxt = new Krypton.Toolkit.KryptonDateTimePicker();
            startDatetxt = new Krypton.Toolkit.KryptonDateTimePicker();
            SuspendLayout();
            // 
            // descriptiontxt
            // 
            descriptiontxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            descriptiontxt.Location = new Point(83, 413);
            descriptiontxt.Multiline = true;
            descriptiontxt.Name = "descriptiontxt";
            descriptiontxt.Size = new Size(820, 197);
            descriptiontxt.TabIndex = 51;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(176, 176, 176);
            label8.Location = new Point(83, 366);
            label8.Name = "label8";
            label8.Size = new Size(135, 29);
            label8.TabIndex = 50;
            label8.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(176, 176, 176);
            label4.Location = new Point(633, 156);
            label4.Name = "label4";
            label4.Size = new Size(112, 29);
            label4.TabIndex = 46;
            label4.Text = "End Date";
            // 
            // venuetxt
            // 
            venuetxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            venuetxt.Location = new Point(633, 93);
            venuetxt.Name = "venuetxt";
            venuetxt.Size = new Size(270, 35);
            venuetxt.TabIndex = 45;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(176, 176, 176);
            label5.Location = new Point(633, 46);
            label5.Name = "label5";
            label5.Size = new Size(82, 29);
            label5.TabIndex = 44;
            label5.Text = "Venue";
            // 
            // maxParticipantstxt
            // 
            maxParticipantstxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maxParticipantstxt.Location = new Point(83, 301);
            maxParticipantstxt.Name = "maxParticipantstxt";
            maxParticipantstxt.Size = new Size(270, 35);
            maxParticipantstxt.TabIndex = 43;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(176, 176, 176);
            label6.Location = new Point(83, 254);
            label6.Name = "label6";
            label6.Size = new Size(188, 29);
            label6.TabIndex = 42;
            label6.Text = "Max Participants";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(176, 176, 176);
            label1.Location = new Point(83, 156);
            label1.Name = "label1";
            label1.Size = new Size(118, 29);
            label1.TabIndex = 40;
            label1.Text = "Start Date";
            // 
            // UpdateEvemt
            // 
            UpdateEvemt.Cursor = Cursors.Hand;
            UpdateEvemt.Location = new Point(633, 665);
            UpdateEvemt.Name = "UpdateEvemt";
            UpdateEvemt.OverrideDefault.Back.Color1 = Color.FromArgb(0, 122, 204);
            UpdateEvemt.OverrideDefault.Back.Color2 = Color.FromArgb(0, 122, 204);
            UpdateEvemt.Size = new Size(244, 38);
            UpdateEvemt.StateCommon.Back.Color1 = Color.FromArgb(0, 122, 204);
            UpdateEvemt.StateCommon.Back.Color2 = Color.FromArgb(0, 122, 204);
            UpdateEvemt.StateCommon.Content.ShortText.Color1 = Color.White;
            UpdateEvemt.StateCommon.Content.ShortText.Font = new Font("Stencil", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UpdateEvemt.StateNormal.Back.Color1 = Color.FromArgb(0, 122, 204);
            UpdateEvemt.StateNormal.Back.Color2 = Color.FromArgb(0, 122, 204);
            UpdateEvemt.StateNormal.Content.ShortText.Color1 = Color.White;
            UpdateEvemt.StateNormal.Content.ShortText.Font = new Font("Stencil", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UpdateEvemt.StatePressed.Back.Color1 = Color.FromArgb(0, 90, 153);
            UpdateEvemt.StatePressed.Back.Color2 = Color.FromArgb(0, 90, 153);
            UpdateEvemt.TabIndex = 39;
            UpdateEvemt.Values.DropDownArrowColor = Color.Empty;
            UpdateEvemt.Values.Text = "UPDATE";
            UpdateEvemt.Click += UpdateEvemt_Click;
            // 
            // nametxt
            // 
            nametxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nametxt.Location = new Point(83, 93);
            nametxt.Name = "nametxt";
            nametxt.Size = new Size(270, 35);
            nametxt.TabIndex = 38;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(176, 176, 176);
            label2.Location = new Point(83, 46);
            label2.Name = "label2";
            label2.Size = new Size(78, 29);
            label2.TabIndex = 37;
            label2.Text = "Name";
            // 
            // endDatetxt
            // 
            endDatetxt.CustomFormat = "dd/MM/yyyy hh:mm tt";
            endDatetxt.Format = DateTimePickerFormat.Custom;
            endDatetxt.Location = new Point(633, 198);
            endDatetxt.Name = "endDatetxt";
            endDatetxt.ShowUpDown = true;
            endDatetxt.Size = new Size(270, 30);
            endDatetxt.TabIndex = 53;
            // 
            // startDatetxt
            // 
            startDatetxt.CustomFormat = "dd/MM/yyyy hh:mm tt";
            startDatetxt.Format = DateTimePickerFormat.Custom;
            startDatetxt.Location = new Point(83, 198);
            startDatetxt.Name = "startDatetxt";
            startDatetxt.ShowUpDown = true;
            startDatetxt.Size = new Size(270, 30);
            startDatetxt.TabIndex = 52;
            // 
            // AdminUpdateEvents
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 28, 28);
            ClientSize = new Size(986, 749);
            Controls.Add(endDatetxt);
            Controls.Add(startDatetxt);
            Controls.Add(descriptiontxt);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(venuetxt);
            Controls.Add(label5);
            Controls.Add(maxParticipantstxt);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(UpdateEvemt);
            Controls.Add(nametxt);
            Controls.Add(label2);
            Name = "AdminUpdateEvents";
            Text = "AdminUpdateEvents";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox descriptiontxt;
        private Label label8;
        private Label label4;
        private TextBox venuetxt;
        private Label label5;
        private TextBox maxParticipantstxt;
        private Label label6;
        private Label label1;
        private Krypton.Toolkit.KryptonButton UpdateEvemt;
        private TextBox nametxt;
        private Label label2;
        private Krypton.Toolkit.KryptonDateTimePicker endDatetxt;
        private Krypton.Toolkit.KryptonDateTimePicker startDatetxt;
    }
}