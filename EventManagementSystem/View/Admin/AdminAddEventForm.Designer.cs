namespace EventManagementSystem
{
    partial class AdminAddEventForm
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
            currentParticipantstxt = new TextBox();
            label7 = new Label();
            endDatetxt = new Krypton.Toolkit.KryptonDateTimePicker();
            label4 = new Label();
            venuetxt = new TextBox();
            label5 = new Label();
            maxParticipantstxt = new TextBox();
            label6 = new Label();
            startDatetxt = new Krypton.Toolkit.KryptonDateTimePicker();
            label1 = new Label();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            nametxt = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // descriptiontxt
            // 
            descriptiontxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            descriptiontxt.Location = new Point(83, 413);
            descriptiontxt.Multiline = true;
            descriptiontxt.Name = "descriptiontxt";
            descriptiontxt.Size = new Size(820, 197);
            descriptiontxt.TabIndex = 36;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(176, 176, 176);
            label8.Location = new Point(83, 366);
            label8.Name = "label8";
            label8.Size = new Size(135, 29);
            label8.TabIndex = 35;
            label8.Text = "Description";
            // 
            // currentParticipantstxt
            // 
            currentParticipantstxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            currentParticipantstxt.Location = new Point(633, 301);
            currentParticipantstxt.Name = "currentParticipantstxt";
            currentParticipantstxt.Size = new Size(270, 35);
            currentParticipantstxt.TabIndex = 34;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(176, 176, 176);
            label7.Location = new Point(633, 254);
            label7.Name = "label7";
            label7.Size = new Size(223, 29);
            label7.TabIndex = 33;
            label7.Text = "Current Participants";
            // 
            // endDatetxt
            // 
            endDatetxt.Location = new Point(633, 198);
            endDatetxt.Name = "endDatetxt";
            endDatetxt.ShowUpDown = true;
            endDatetxt.Size = new Size(270, 30);
            endDatetxt.TabIndex = 32;
            endDatetxt.ValueNullable = new DateTime(2024, 8, 19, 12, 33, 54, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(176, 176, 176);
            label4.Location = new Point(633, 156);
            label4.Name = "label4";
            label4.Size = new Size(112, 29);
            label4.TabIndex = 31;
            label4.Text = "End Date";
            // 
            // venuetxt
            // 
            venuetxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            venuetxt.Location = new Point(633, 93);
            venuetxt.Name = "venuetxt";
            venuetxt.Size = new Size(270, 35);
            venuetxt.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(176, 176, 176);
            label5.Location = new Point(633, 46);
            label5.Name = "label5";
            label5.Size = new Size(82, 29);
            label5.TabIndex = 29;
            label5.Text = "Venue";
            // 
            // maxParticipantstxt
            // 
            maxParticipantstxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maxParticipantstxt.Location = new Point(83, 301);
            maxParticipantstxt.Name = "maxParticipantstxt";
            maxParticipantstxt.Size = new Size(270, 35);
            maxParticipantstxt.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(176, 176, 176);
            label6.Location = new Point(83, 254);
            label6.Name = "label6";
            label6.Size = new Size(188, 29);
            label6.TabIndex = 27;
            label6.Text = "Max Participants";
            // 
            // startDatetxt
            // 
            startDatetxt.Location = new Point(83, 198);
            startDatetxt.Name = "startDatetxt";
            startDatetxt.ShowUpDown = true;
            startDatetxt.Size = new Size(270, 30);
            startDatetxt.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(176, 176, 176);
            label1.Location = new Point(83, 156);
            label1.Name = "label1";
            label1.Size = new Size(118, 29);
            label1.TabIndex = 25;
            label1.Text = "Start Date";
            // 
            // kryptonButton1
            // 
            kryptonButton1.Cursor = Cursors.Hand;
            kryptonButton1.Location = new Point(633, 665);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.OverrideDefault.Back.Color1 = Color.FromArgb(0, 122, 204);
            kryptonButton1.OverrideDefault.Back.Color2 = Color.FromArgb(0, 122, 204);
            kryptonButton1.Size = new Size(244, 38);
            kryptonButton1.StateCommon.Back.Color1 = Color.FromArgb(0, 122, 204);
            kryptonButton1.StateCommon.Back.Color2 = Color.FromArgb(0, 122, 204);
            kryptonButton1.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButton1.StateCommon.Content.ShortText.Font = new Font("Stencil", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonButton1.StateNormal.Back.Color1 = Color.FromArgb(0, 122, 204);
            kryptonButton1.StateNormal.Back.Color2 = Color.FromArgb(0, 122, 204);
            kryptonButton1.StateNormal.Content.ShortText.Color1 = Color.White;
            kryptonButton1.StateNormal.Content.ShortText.Font = new Font("Stencil", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonButton1.StatePressed.Back.Color1 = Color.FromArgb(0, 90, 153);
            kryptonButton1.StatePressed.Back.Color2 = Color.FromArgb(0, 90, 153);
            kryptonButton1.TabIndex = 24;
            kryptonButton1.Values.DropDownArrowColor = Color.Empty;
            kryptonButton1.Values.Text = "CREATE";
            kryptonButton1.Click += kryptonButton1_Click;
            // 
            // nametxt
            // 
            nametxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nametxt.Location = new Point(83, 93);
            nametxt.Name = "nametxt";
            nametxt.Size = new Size(270, 35);
            nametxt.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(176, 176, 176);
            label2.Location = new Point(83, 46);
            label2.Name = "label2";
            label2.Size = new Size(78, 29);
            label2.TabIndex = 22;
            label2.Text = "Name";
            // 
            // AdminAddEventForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(986, 749);
            Controls.Add(descriptiontxt);
            Controls.Add(label8);
            Controls.Add(currentParticipantstxt);
            Controls.Add(label7);
            Controls.Add(endDatetxt);
            Controls.Add(label4);
            Controls.Add(venuetxt);
            Controls.Add(label5);
            Controls.Add(maxParticipantstxt);
            Controls.Add(label6);
            Controls.Add(startDatetxt);
            Controls.Add(label1);
            Controls.Add(kryptonButton1);
            Controls.Add(nametxt);
            Controls.Add(label2);
            ForeColor = Color.Black;
            Name = "AdminAddEventForm";
            Text = "AdminAddEventForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox descriptiontxt;
        private Label label8;
        private TextBox currentParticipantstxt;
        private Label label7;
        private Krypton.Toolkit.KryptonDateTimePicker endDatetxt;
        private Label label4;
        private TextBox venuetxt;
        private Label label5;
        private TextBox maxParticipantstxt;
        private Label label6;
        private Krypton.Toolkit.KryptonDateTimePicker startDatetxt;
        private Label label1;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private TextBox nametxt;
        private Label label2;
    }
}