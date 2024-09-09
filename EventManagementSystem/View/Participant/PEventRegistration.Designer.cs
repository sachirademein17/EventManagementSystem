namespace EventManagementSystem
{
    partial class PEventRegistration
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
            RegisteredEvent = new Krypton.Toolkit.KryptonDataGridView();
            label1 = new Label();
            CancelBooking = new Krypton.Toolkit.KryptonButton();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)RegisteredEvent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            SuspendLayout();
            // 
            // RegisteredEvent
            // 
            RegisteredEvent.BorderStyle = BorderStyle.None;
            RegisteredEvent.ColumnHeadersHeight = 51;
            RegisteredEvent.Location = new Point(44, 118);
            RegisteredEvent.Name = "RegisteredEvent";
            RegisteredEvent.RowHeadersWidth = 62;
            RegisteredEvent.Size = new Size(988, 517);
            RegisteredEvent.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(64, 64, 64);
            label1.Font = new Font("Microsoft Sans Serif", 16F);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(44, 38);
            label1.Name = "label1";
            label1.Size = new Size(274, 37);
            label1.TabIndex = 10;
            label1.Text = "Registered Events";
            // 
            // CancelBooking
            // 
            CancelBooking.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CancelBooking.Cursor = Cursors.Hand;
            CancelBooking.Location = new Point(788, 38);
            CancelBooking.Name = "CancelBooking";
            CancelBooking.Size = new Size(244, 38);
            CancelBooking.StateCommon.Back.Color1 = Color.FromArgb(244, 67, 54);
            CancelBooking.StateCommon.Back.Color2 = Color.FromArgb(239, 83, 80);
            CancelBooking.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            CancelBooking.StateCommon.Border.Color1 = Color.FromArgb(244, 67, 54);
            CancelBooking.StateCommon.Border.Color2 = Color.FromArgb(239, 83, 80);
            CancelBooking.StateCommon.Border.Rounding = 20F;
            CancelBooking.StateCommon.Border.Width = 1;
            CancelBooking.StateCommon.Content.ShortText.Color1 = Color.White;
            CancelBooking.StateCommon.Content.ShortText.Font = new Font("Stencil", 10F);
            CancelBooking.StatePressed.Back.Color1 = Color.FromArgb(198, 40, 40);
            CancelBooking.StatePressed.Back.Color2 = Color.FromArgb(255, 23, 68);
            CancelBooking.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            CancelBooking.StatePressed.Content.ShortText.Color1 = Color.White;
            CancelBooking.StateTracking.Back.Color1 = Color.FromArgb(211, 47, 47);
            CancelBooking.StateTracking.Back.Color2 = Color.FromArgb(255, 82, 82);
            CancelBooking.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            CancelBooking.StateTracking.Content.ShortText.Color1 = Color.White;
            CancelBooking.TabIndex = 12;
            CancelBooking.Values.DropDownArrowColor = Color.Empty;
            CancelBooking.Values.Text = "Cancel";
            CancelBooking.Click += CancelBooking_Click;
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Dock = DockStyle.Fill;
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(1074, 675);
            kryptonPanel1.StateNormal.Color1 = Color.FromArgb(75, 75, 75);
            kryptonPanel1.StateNormal.Color2 = Color.Gray;
            kryptonPanel1.StateNormal.ColorAngle = 90F;
            kryptonPanel1.StateNormal.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            kryptonPanel1.TabIndex = 13;
            // 
            // PEventRegistration
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 42, 42);
            ClientSize = new Size(1074, 675);
            Controls.Add(CancelBooking);
            Controls.Add(label1);
            Controls.Add(RegisteredEvent);
            Controls.Add(kryptonPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PEventRegistration";
            Text = "PEventRegistration";
            ((System.ComponentModel.ISupportInitialize)RegisteredEvent).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView RegisteredEvent;
        private Label label1;
        private Krypton.Toolkit.KryptonButton CancelBooking;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
    }
}