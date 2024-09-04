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
            bookingsTable = new DataGridView();
            label2 = new Label();
            CancelBooking = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)bookingsTable).BeginInit();
            SuspendLayout();
            // 
            // bookingsTable
            // 
            bookingsTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bookingsTable.BackgroundColor = Color.FromArgb(61, 61, 61);
            bookingsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bookingsTable.Location = new Point(37, 126);
            bookingsTable.Name = "bookingsTable";
            bookingsTable.RowHeadersWidth = 62;
            bookingsTable.Size = new Size(1001, 513);
            bookingsTable.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 16F);
            label2.ForeColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(37, 36);
            label2.Name = "label2";
            label2.Size = new Size(187, 37);
            label2.TabIndex = 9;
            label2.Text = "BOOKINGS";
            // 
            // CancelBooking
            // 
            CancelBooking.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CancelBooking.Cursor = Cursors.Hand;
            CancelBooking.Location = new Point(794, 36);
            CancelBooking.Name = "CancelBooking";
            CancelBooking.OverrideDefault.Back.Color1 = Color.FromArgb(97, 118, 227);
            CancelBooking.OverrideDefault.Back.Color2 = Color.FromArgb(97, 118, 227);
            CancelBooking.OverrideDefault.Content.ShortText.Color1 = Color.White;
            CancelBooking.OverrideDefault.Content.ShortText.Color2 = Color.White;
            CancelBooking.Size = new Size(244, 38);
            CancelBooking.StateCommon.Back.Color1 = Color.FromArgb(97, 118, 227);
            CancelBooking.StateCommon.Back.Color2 = Color.FromArgb(97, 118, 227);
            CancelBooking.StateCommon.Content.ShortText.Color1 = Color.White;
            CancelBooking.StateCommon.Content.ShortText.Font = new Font("Stencil", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CancelBooking.StateNormal.Back.Color1 = Color.FromArgb(67, 198, 172);
            CancelBooking.StateNormal.Back.Color2 = Color.FromArgb(25, 22, 84);
            CancelBooking.StateNormal.Back.ColorAngle = 45F;
            CancelBooking.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            CancelBooking.StateNormal.Content.ShortText.Color1 = Color.White;
            CancelBooking.StateNormal.Content.ShortText.Font = new Font("Stencil", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CancelBooking.StatePressed.Back.Color1 = Color.FromArgb(67, 87, 181);
            CancelBooking.StatePressed.Back.Color2 = Color.FromArgb(67, 87, 181);
            CancelBooking.TabIndex = 11;
            CancelBooking.Values.DropDownArrowColor = Color.Empty;
            CancelBooking.Values.Text = "Cancel Booking";
            CancelBooking.Click += CancelBooking_Click;
            // 
            // OManageBookings
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 42, 42);
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