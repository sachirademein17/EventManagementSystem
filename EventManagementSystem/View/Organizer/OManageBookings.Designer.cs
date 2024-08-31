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
            kryptonButton3 = new Krypton.Toolkit.KryptonButton();
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
            // kryptonButton3
            // 
            kryptonButton3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            kryptonButton3.Cursor = Cursors.Hand;
            kryptonButton3.Location = new Point(794, 36);
            kryptonButton3.Name = "kryptonButton3";
            kryptonButton3.OverrideDefault.Back.Color1 = Color.FromArgb(97, 118, 227);
            kryptonButton3.OverrideDefault.Back.Color2 = Color.FromArgb(97, 118, 227);
            kryptonButton3.OverrideDefault.Content.ShortText.Color1 = Color.White;
            kryptonButton3.OverrideDefault.Content.ShortText.Color2 = Color.White;
            kryptonButton3.Size = new Size(244, 38);
            kryptonButton3.StateCommon.Back.Color1 = Color.FromArgb(97, 118, 227);
            kryptonButton3.StateCommon.Back.Color2 = Color.FromArgb(97, 118, 227);
            kryptonButton3.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButton3.StateCommon.Content.ShortText.Font = new Font("Stencil", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonButton3.StateNormal.Back.Color1 = Color.FromArgb(67, 198, 172);
            kryptonButton3.StateNormal.Back.Color2 = Color.FromArgb(25, 22, 84);
            kryptonButton3.StateNormal.Back.ColorAngle = 45F;
            kryptonButton3.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            kryptonButton3.StateNormal.Content.ShortText.Color1 = Color.White;
            kryptonButton3.StateNormal.Content.ShortText.Font = new Font("Stencil", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonButton3.StatePressed.Back.Color1 = Color.FromArgb(67, 87, 181);
            kryptonButton3.StatePressed.Back.Color2 = Color.FromArgb(67, 87, 181);
            kryptonButton3.TabIndex = 11;
            kryptonButton3.Values.DropDownArrowColor = Color.Empty;
            kryptonButton3.Values.Text = "REMOVE";
            kryptonButton3.Click += kryptonButton3_Click;
            // 
            // OManageBookings
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 42, 42);
            ClientSize = new Size(1074, 675);
            Controls.Add(kryptonButton3);
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
        private Krypton.Toolkit.KryptonButton kryptonButton3;
    }
}