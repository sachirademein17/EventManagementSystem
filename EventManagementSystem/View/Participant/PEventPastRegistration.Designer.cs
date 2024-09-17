namespace EventManagementSystem.View.Participant
{
    partial class PEventPastRegistration
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
            RegisteredEvent = new Krypton.Toolkit.KryptonDataGridView();
            ((System.ComponentModel.ISupportInitialize)RegisteredEvent).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(64, 64, 64);
            label1.Font = new Font("Microsoft Sans Serif", 16F);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(43, 39);
            label1.Name = "label1";
            label1.Size = new Size(347, 37);
            label1.TabIndex = 12;
            label1.Text = "Registered Past Events";
            // 
            // RegisteredEvent
            // 
            RegisteredEvent.BorderStyle = BorderStyle.None;
            RegisteredEvent.ColumnHeadersHeight = 51;
            RegisteredEvent.Location = new Point(12, 119);
            RegisteredEvent.Name = "RegisteredEvent";
            RegisteredEvent.RowHeadersWidth = 62;
            RegisteredEvent.Size = new Size(1050, 544);
            RegisteredEvent.TabIndex = 11;
            // 
            // PEventPastRegistration
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1074, 675);
            Controls.Add(label1);
            Controls.Add(RegisteredEvent);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PEventPastRegistration";
            Text = "PEventPastRegistration";
            ((System.ComponentModel.ISupportInitialize)RegisteredEvent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Krypton.Toolkit.KryptonDataGridView RegisteredEvent;
    }
}