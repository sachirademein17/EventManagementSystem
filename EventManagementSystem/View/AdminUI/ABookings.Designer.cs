namespace EventManagementSystem
{
    partial class ABookings
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
            CancelBooking = new Krypton.Toolkit.KryptonButton();
            eventsTable = new Krypton.Toolkit.KryptonDataGridView();
            ((System.ComponentModel.ISupportInitialize)eventsTable).BeginInit();
            SuspendLayout();
            // 
            // CancelBooking
            // 
            CancelBooking.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CancelBooking.Cursor = Cursors.Hand;
            CancelBooking.Location = new Point(836, 30);
            CancelBooking.Name = "CancelBooking";
            CancelBooking.OverrideDefault.Back.Color1 = Color.FromArgb(0, 122, 204);
            CancelBooking.OverrideDefault.Back.Color2 = Color.FromArgb(0, 122, 204);
            CancelBooking.Size = new Size(205, 38);
            CancelBooking.StateCommon.Back.Color1 = Color.FromArgb(0, 122, 204);
            CancelBooking.StateCommon.Back.Color2 = Color.FromArgb(0, 122, 204);
            CancelBooking.StateCommon.Content.ShortText.Color1 = Color.White;
            CancelBooking.StateCommon.Content.ShortText.Font = new Font("Stencil", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CancelBooking.StateNormal.Back.Color1 = Color.FromArgb(0, 122, 204);
            CancelBooking.StateNormal.Back.Color2 = Color.FromArgb(0, 122, 204);
            CancelBooking.StateNormal.Content.ShortText.Color1 = Color.White;
            CancelBooking.StateNormal.Content.ShortText.Font = new Font("Stencil", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CancelBooking.StatePressed.Back.Color1 = Color.FromArgb(0, 90, 153);
            CancelBooking.StatePressed.Back.Color2 = Color.FromArgb(0, 90, 153);
            CancelBooking.TabIndex = 17;
            CancelBooking.Values.DropDownArrowColor = Color.Empty;
            CancelBooking.Values.Text = "Cancel Booking";
            CancelBooking.Click += CancelBooking_Click;
            // 
            // eventsTable
            // 
            eventsTable.BorderStyle = BorderStyle.None;
            eventsTable.ColumnHeadersHeight = 51;
            eventsTable.Location = new Point(12, 130);
            eventsTable.Name = "eventsTable";
            eventsTable.RowHeadersWidth = 62;
            eventsTable.Size = new Size(1050, 533);
            eventsTable.TabIndex = 18;
            // 
            // ABookings
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 42, 42);
            ClientSize = new Size(1074, 675);
            Controls.Add(eventsTable);
            Controls.Add(CancelBooking);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ABookings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ADashboard";
            ((System.ComponentModel.ISupportInitialize)eventsTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Krypton.Toolkit.KryptonButton CancelBooking;
        private Krypton.Toolkit.KryptonDataGridView eventsTable;
    }
}