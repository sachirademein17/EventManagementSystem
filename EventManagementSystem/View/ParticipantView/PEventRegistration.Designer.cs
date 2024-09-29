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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            CancelBooking = new Krypton.Toolkit.KryptonButton();
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
            // RegisteredEvent
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(35, 35, 35);
            RegisteredEvent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            RegisteredEvent.BorderStyle = BorderStyle.None;
            RegisteredEvent.ColumnHeadersHeight = 51;
            RegisteredEvent.Location = new Point(12, 117);
            RegisteredEvent.Name = "RegisteredEvent";
            RegisteredEvent.RowHeadersWidth = 62;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(40, 40, 40);
            RegisteredEvent.RowsDefaultCellStyle = dataGridViewCellStyle2;
            RegisteredEvent.Size = new Size(1050, 546);
            RegisteredEvent.StateCommon.Background.Color1 = Color.FromArgb(30, 30, 30);
            RegisteredEvent.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            RegisteredEvent.StateCommon.DataCell.Back.Color1 = Color.FromArgb(40, 40, 40);
            RegisteredEvent.StateCommon.DataCell.Back.Color2 = Color.FromArgb(40, 40, 40);
            RegisteredEvent.StateCommon.DataCell.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounded;
            RegisteredEvent.StateCommon.DataCell.Content.Color1 = Color.LightGray;
            RegisteredEvent.StateCommon.DataCell.Content.Font = new Font("Segoe UI", 9F);
            RegisteredEvent.StateCommon.HeaderColumn.Back.Color1 = Color.FromArgb(60, 60, 60);
            RegisteredEvent.StateCommon.HeaderColumn.Back.Color2 = Color.FromArgb(80, 80, 80);
            RegisteredEvent.StateCommon.HeaderColumn.Content.Color1 = Color.White;
            RegisteredEvent.StateCommon.HeaderColumn.Content.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            RegisteredEvent.StateSelected.DataCell.Back.Color1 = Color.FromArgb(60, 180, 75);
            RegisteredEvent.StateSelected.DataCell.Back.Color2 = Color.FromArgb(50, 150, 65);
            RegisteredEvent.StateSelected.DataCell.Back.ColorAngle = 45F;
            RegisteredEvent.StateSelected.DataCell.Border.Color1 = Color.FromArgb(255, 255, 255);
            RegisteredEvent.StateSelected.DataCell.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            RegisteredEvent.StateSelected.DataCell.Border.Width = 2;
            RegisteredEvent.StateSelected.DataCell.Content.Color1 = Color.White;
            RegisteredEvent.StateTracking.HeaderRow.Back.Color1 = Color.FromArgb(70, 70, 70);
            RegisteredEvent.StateTracking.HeaderRow.Back.Color2 = Color.FromArgb(60, 60, 60);
            RegisteredEvent.StateTracking.HeaderRow.Back.ColorAngle = 0F;
            RegisteredEvent.StateTracking.HeaderRow.Content.Color1 = Color.White;
            RegisteredEvent.TabIndex = 18;
            // 
            // PEventRegistration
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 42, 42);
            ClientSize = new Size(1074, 675);
            Controls.Add(RegisteredEvent);
            Controls.Add(CancelBooking);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PEventRegistration";
            Text = "PEventRegistration";
            ((System.ComponentModel.ISupportInitialize)RegisteredEvent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Krypton.Toolkit.KryptonButton CancelBooking;
        private Krypton.Toolkit.KryptonDataGridView RegisteredEvent;
    }
}