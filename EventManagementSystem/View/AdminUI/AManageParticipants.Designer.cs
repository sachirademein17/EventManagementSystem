﻿namespace EventManagementSystem
{
    partial class AManageParticipants
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
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16F);
            label1.ForeColor = Color.FromArgb(255, 0, 127);
            label1.Location = new Point(450, 319);
            label1.Name = "label1";
            label1.Size = new Size(309, 37);
            label1.TabIndex = 2;
            label1.Text = "Manage Participants";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AManageParticipants
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 42, 42);
            ClientSize = new Size(1074, 675);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AManageParticipants";
            Text = "AManageParticipants";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}