namespace EventManagementSystem
{
    partial class ODashboard
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
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridView1).BeginInit();
            SuspendLayout();
            // 
            // kryptonDataGridView1
            // 
            kryptonDataGridView1.BorderStyle = BorderStyle.None;
            kryptonDataGridView1.ColumnHeadersHeight = 51;
            kryptonDataGridView1.Location = new Point(12, 126);
            kryptonDataGridView1.Name = "kryptonDataGridView1";
            kryptonDataGridView1.RowHeadersWidth = 62;
            kryptonDataGridView1.Size = new Size(1050, 537);
            kryptonDataGridView1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(12, 34);
            label2.Name = "label2";
            label2.Size = new Size(232, 45);
            label2.TabIndex = 3;
            label2.Text = "Past Bookings";
            // 
            // ODashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1074, 675);
            Controls.Add(label2);
            Controls.Add(kryptonDataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ODashboard";
            Text = "ODashboard";
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private Label label2;
    }
}