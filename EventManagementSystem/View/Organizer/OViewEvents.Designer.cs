namespace EventManagementSystem
{
    partial class OViewEvents
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
            eventTable = new Krypton.Toolkit.KryptonDataGridView();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)eventTable).BeginInit();
            SuspendLayout();
            // 
            // eventTable
            // 
            eventTable.BorderStyle = BorderStyle.None;
            eventTable.ColumnHeadersHeight = 51;
            eventTable.Location = new Point(12, 98);
            eventTable.Name = "eventTable";
            eventTable.RowHeadersWidth = 62;
            eventTable.Size = new Size(1050, 565);
            eventTable.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(24, 26);
            label2.Name = "label2";
            label2.Size = new Size(181, 45);
            label2.TabIndex = 3;
            label2.Text = "Event Logs";
            // 
            // OViewEvents
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 42, 42);
            ClientSize = new Size(1074, 675);
            Controls.Add(label2);
            Controls.Add(eventTable);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OViewEvents";
            Text = "OViewEvents";
            ((System.ComponentModel.ISupportInitialize)eventTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView eventTable;
        private Label label2;
    }
}