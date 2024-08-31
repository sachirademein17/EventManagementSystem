namespace EventManagementSystem
{
    partial class AddEventForm
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
            nametxt = new TextBox();
            label2 = new Label();
            label1 = new Label();
            startDatetxt = new Krypton.Toolkit.KryptonDateTimePicker();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            venuetxt = new TextBox();
            label5 = new Label();
            label6 = new Label();
            maxParticipantstxt = new TextBox();
            descriptiontxt = new TextBox();
            label8 = new Label();
            endDatetxt = new Krypton.Toolkit.KryptonDateTimePicker();
            SuspendLayout();
            // 
            // kryptonButton1
            // 
            kryptonButton1.Cursor = Cursors.Hand;
            kryptonButton1.Location = new Point(638, 670);
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
            kryptonButton1.TabIndex = 9;
            kryptonButton1.Values.DropDownArrowColor = Color.Empty;
            kryptonButton1.Values.Text = "CREATE";
            kryptonButton1.Click += kryptonButton1_Click;
            // 
            // nametxt
            // 
            nametxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nametxt.Location = new Point(88, 98);
            nametxt.Name = "nametxt";
            nametxt.Size = new Size(270, 35);
            nametxt.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(176, 176, 176);
            label2.Location = new Point(88, 51);
            label2.Name = "label2";
            label2.Size = new Size(78, 29);
            label2.TabIndex = 7;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(176, 176, 176);
            label1.Location = new Point(88, 161);
            label1.Name = "label1";
            label1.Size = new Size(118, 29);
            label1.TabIndex = 10;
            label1.Text = "Start Date";
            // 
            // startDatetxt
            // 
            startDatetxt.CustomFormat = "dd/MM/yyyy hh:mm tt";
            startDatetxt.Format = DateTimePickerFormat.Custom;
            startDatetxt.Location = new Point(88, 203);
            startDatetxt.Name = "startDatetxt";
            startDatetxt.ShowUpDown = true;
            startDatetxt.Size = new Size(270, 30);
            startDatetxt.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(88, 306);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(270, 35);
            textBox1.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(176, 176, 176);
            label3.Location = new Point(88, 259);
            label3.Name = "label3";
            label3.Size = new Size(82, 29);
            label3.TabIndex = 12;
            label3.Text = "Venue";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(176, 176, 176);
            label4.Location = new Point(638, 161);
            label4.Name = "label4";
            label4.Size = new Size(112, 29);
            label4.TabIndex = 16;
            label4.Text = "End Date";
            // 
            // venuetxt
            // 
            venuetxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            venuetxt.Location = new Point(638, 98);
            venuetxt.Name = "venuetxt";
            venuetxt.Size = new Size(270, 35);
            venuetxt.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(176, 176, 176);
            label5.Location = new Point(638, 51);
            label5.Name = "label5";
            label5.Size = new Size(82, 29);
            label5.TabIndex = 14;
            label5.Text = "Venue";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(176, 176, 176);
            label6.Location = new Point(88, 259);
            label6.Name = "label6";
            label6.Size = new Size(188, 29);
            label6.TabIndex = 12;
            label6.Text = "Max Participants";
            // 
            // maxParticipantstxt
            // 
            maxParticipantstxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maxParticipantstxt.Location = new Point(88, 306);
            maxParticipantstxt.Name = "maxParticipantstxt";
            maxParticipantstxt.Size = new Size(270, 35);
            maxParticipantstxt.TabIndex = 13;
            // 
            // descriptiontxt
            // 
            descriptiontxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            descriptiontxt.Location = new Point(88, 418);
            descriptiontxt.Multiline = true;
            descriptiontxt.Name = "descriptiontxt";
            descriptiontxt.Size = new Size(820, 197);
            descriptiontxt.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(176, 176, 176);
            label8.Location = new Point(88, 371);
            label8.Name = "label8";
            label8.Size = new Size(135, 29);
            label8.TabIndex = 20;
            label8.Text = "Description";
            // 
            // endDatetxt
            // 
            endDatetxt.CustomFormat = "dd/MM/yyyy hh:mm tt";
            endDatetxt.Format = DateTimePickerFormat.Custom;
            endDatetxt.Location = new Point(638, 203);
            endDatetxt.Name = "endDatetxt";
            endDatetxt.ShowUpDown = true;
            endDatetxt.Size = new Size(270, 30);
            endDatetxt.TabIndex = 22;
            // 
            // AddEventForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 28, 28);
            ClientSize = new Size(986, 749);
            Controls.Add(endDatetxt);
            Controls.Add(descriptiontxt);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(venuetxt);
            Controls.Add(label5);
            Controls.Add(maxParticipantstxt);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(startDatetxt);
            Controls.Add(label1);
            Controls.Add(kryptonButton1);
            Controls.Add(nametxt);
            Controls.Add(label2);
            Name = "AddEventForm";
            Text = "show";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private TextBox nametxt;
        private Label label2;
        private Label label1;
        private Krypton.Toolkit.KryptonDateTimePicker startDatetxt;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private TextBox venuetxt;
        private Label label5;
        private Label label6;
        private TextBox maxParticipantstxt;
        private TextBox descriptiontxt;
        private Label label8;
        private Krypton.Toolkit.KryptonDateTimePicker endDatetxt;
    }
}