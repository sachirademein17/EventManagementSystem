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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            bookingsTable = new DataGridView();
            label2 = new Label();
            CancelBooking = new KryptonButton();
            ((System.ComponentModel.ISupportInitialize)bookingsTable).BeginInit();
            SuspendLayout();
            // 
            // bookingsTable
            // 
            bookingsTable.AllowUserToAddRows = false;
            bookingsTable.AllowUserToDeleteRows = false;
            bookingsTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(40, 40, 40);
            bookingsTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            bookingsTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bookingsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            bookingsTable.BackgroundColor = Color.FromArgb(25, 25, 25);
            bookingsTable.BorderStyle = BorderStyle.Fixed3D;
            bookingsTable.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(44, 72, 117);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            bookingsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            bookingsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(31, 31, 31);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(44, 72, 117);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            bookingsTable.DefaultCellStyle = dataGridViewCellStyle3;
            bookingsTable.GridColor = Color.FromArgb(61, 61, 61);
            bookingsTable.Location = new Point(31, 119);
            bookingsTable.Name = "bookingsTable";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(31, 31, 31);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            bookingsTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            bookingsTable.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            bookingsTable.Size = new Size(1001, 513);
            bookingsTable.TabIndex = 6;
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
            // OManageBookings
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 47, 47);
            ClientSize = new Size(1074, 675);
            Controls.Add(CancelBooking);
            Controls.Add(bookingsTable);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OManageBookings";
            Text = "OViewParticipants";
            ((System.ComponentModel.ISupportInitialize)bookingsTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView bookingsTable;
        private Label label2;
        private Krypton.Toolkit.KryptonButton CancelBooking;
    }
}