namespace EventManagementSystem.View.AdminUI
{
    partial class AViewParticipants
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
            kryptonDataGridView1 = new Krypton.Toolkit.KryptonDataGridView();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridView1).BeginInit();
            SuspendLayout();
            // 
            // kryptonDataGridView1
            // 
            kryptonDataGridView1.BorderStyle = BorderStyle.None;
            kryptonDataGridView1.ColumnHeadersHeight = 51;
            kryptonDataGridView1.Location = new Point(12, 12);
            kryptonDataGridView1.Name = "kryptonDataGridView1";
            kryptonDataGridView1.RowHeadersWidth = 62;
            kryptonDataGridView1.Size = new Size(1067, 600);
            kryptonDataGridView1.TabIndex = 0;
            // 
            // AViewParticipants
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 28, 28);
            ClientSize = new Size(1095, 624);
            Controls.Add(kryptonDataGridView1);
            Name = "AViewParticipants";
            Text = "AViewParticipants";
            Load += AViewParticipants_Load;
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
    }
}