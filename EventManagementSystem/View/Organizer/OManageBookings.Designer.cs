using Krypton.Toolkit;

namespace EventManagementSystem
{
    partial class OManageBookings
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
            label2 = new Label();
            CancelBooking = new KryptonButton();
            bookingsTable = new KryptonDataGridView();
            ((System.ComponentModel.ISupportInitialize)bookingsTable).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(31, 29);
            label2.Name = "label2";
            label2.Size = new Size(186, 45);
            label2.TabIndex = 2;
            label2.Text = "BOOKINGS";
            // 
            // CancelBooking
            // 
            CancelBooking.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CancelBooking.Cursor = Cursors.Hand;
            CancelBooking.Location = new Point(794, 36);
            CancelBooking.Name = "CancelBooking";
            CancelBooking.Size = new Size(244, 38);
            CancelBooking.StateCommon.Back.Color1 = Color.FromArgb(255, 94, 87);
            CancelBooking.StateCommon.Back.Color2 = Color.FromArgb(255, 67, 67);
            CancelBooking.StateCommon.Back.ColorAngle = 45F;
            CancelBooking.StateCommon.Back.ColorStyle = PaletteColorStyle.Linear;
            CancelBooking.StateCommon.Border.Color1 = Color.FromArgb(255, 67, 67);
            CancelBooking.StateCommon.Border.Color2 = Color.FromArgb(255, 94, 87);
            CancelBooking.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            CancelBooking.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            CancelBooking.StateCommon.Border.Rounding = 20F;
            CancelBooking.StateCommon.Border.Width = 1;
            CancelBooking.StateCommon.Content.ShortText.Color1 = Color.White;
            CancelBooking.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            CancelBooking.StateNormal.Back.Color1 = Color.FromArgb(255, 94, 87);
            CancelBooking.StateNormal.Back.Color2 = Color.FromArgb(255, 67, 67);
            CancelBooking.StateNormal.Back.ColorAngle = 45F;
            CancelBooking.StateNormal.Back.ColorStyle = PaletteColorStyle.Linear;
            CancelBooking.StateNormal.Content.ShortText.Color1 = Color.White;
            CancelBooking.StateNormal.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            CancelBooking.StatePressed.Back.Color1 = Color.FromArgb(220, 40, 40);
            CancelBooking.StatePressed.Back.Color2 = Color.FromArgb(200, 30, 30);
            CancelBooking.StatePressed.Border.Rounding = 20F;
            CancelBooking.TabIndex = 11;
            CancelBooking.Values.DropDownArrowColor = Color.Empty;
            CancelBooking.Values.Text = "Cancel Booking";
            CancelBooking.Click += CancelBooking_Click;
            // 
            // bookingsTable
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(35, 35, 35);
            bookingsTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            bookingsTable.BorderStyle = BorderStyle.None;
            bookingsTable.ColumnHeadersHeight = 51;
            bookingsTable.Location = new Point(12, 117);
            bookingsTable.Name = "bookingsTable";
            bookingsTable.RowHeadersWidth = 62;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(40, 40, 40);
            bookingsTable.RowsDefaultCellStyle = dataGridViewCellStyle2;
            bookingsTable.Size = new Size(1050, 546);
            bookingsTable.StateCommon.Background.Color1 = Color.FromArgb(30, 30, 30);
            bookingsTable.StateCommon.BackStyle = PaletteBackStyle.GridBackgroundList;
            bookingsTable.StateCommon.DataCell.Back.Color1 = Color.FromArgb(40, 40, 40);
            bookingsTable.StateCommon.DataCell.Back.Color2 = Color.FromArgb(40, 40, 40);
            bookingsTable.StateCommon.DataCell.Back.ColorStyle = PaletteColorStyle.Rounded;
            bookingsTable.StateCommon.DataCell.Content.Color1 = Color.LightGray;
            bookingsTable.StateCommon.DataCell.Content.Font = new Font("Segoe UI", 9F);
            bookingsTable.StateCommon.HeaderColumn.Back.Color1 = Color.FromArgb(60, 60, 60);
            bookingsTable.StateCommon.HeaderColumn.Back.Color2 = Color.FromArgb(80, 80, 80);
            bookingsTable.StateCommon.HeaderColumn.Content.Color1 = Color.White;
            bookingsTable.StateCommon.HeaderColumn.Content.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            bookingsTable.StateSelected.DataCell.Back.Color1 = Color.FromArgb(60, 180, 75);
            bookingsTable.StateSelected.DataCell.Back.Color2 = Color.FromArgb(50, 150, 65);
            bookingsTable.StateSelected.DataCell.Back.ColorAngle = 45F;
            bookingsTable.StateSelected.DataCell.Border.Color1 = Color.FromArgb(255, 255, 255);
            bookingsTable.StateSelected.DataCell.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            bookingsTable.StateSelected.DataCell.Border.Width = 2;
            bookingsTable.StateSelected.DataCell.Content.Color1 = Color.White;
            bookingsTable.StateTracking.HeaderRow.Back.Color1 = Color.FromArgb(70, 70, 70);
            bookingsTable.StateTracking.HeaderRow.Back.Color2 = Color.FromArgb(60, 60, 60);
            bookingsTable.StateTracking.HeaderRow.Back.ColorAngle = 0F;
            bookingsTable.StateTracking.HeaderRow.Content.Color1 = Color.White;
            bookingsTable.TabIndex = 18;
            // 
            // OManageBookings
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 47, 47);
            ClientSize = new Size(1074, 675);
            Controls.Add(bookingsTable);
            Controls.Add(CancelBooking);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OManageBookings";
            Text = "OViewParticipants";
            ((System.ComponentModel.ISupportInitialize)bookingsTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Krypton.Toolkit.KryptonButton CancelBooking;
        private KryptonDataGridView bookingsTable;
    }
}