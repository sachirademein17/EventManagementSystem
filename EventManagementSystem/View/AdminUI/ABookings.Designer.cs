﻿namespace EventManagementSystem
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            eventsTable = new Krypton.Toolkit.KryptonDataGridView();
            CancelBooking = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)eventsTable).BeginInit();
            SuspendLayout();
            // 
            // eventsTable
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(35, 35, 35);
            eventsTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            eventsTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            eventsTable.BorderStyle = BorderStyle.None;
            eventsTable.ColumnHeadersHeight = 51;
            eventsTable.Location = new Point(12, 91);
            eventsTable.Name = "eventsTable";
            eventsTable.ReadOnly = true;
            eventsTable.RowHeadersWidth = 62;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(40, 40, 40);
            eventsTable.RowsDefaultCellStyle = dataGridViewCellStyle2;
            eventsTable.Size = new Size(1050, 572);
            eventsTable.StateCommon.Background.Color1 = Color.FromArgb(30, 30, 30);
            eventsTable.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            eventsTable.StateCommon.DataCell.Back.Color1 = Color.FromArgb(40, 40, 40);
            eventsTable.StateCommon.DataCell.Back.Color2 = Color.FromArgb(40, 40, 40);
            eventsTable.StateCommon.DataCell.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounded;
            eventsTable.StateCommon.DataCell.Content.Color1 = Color.LightGray;
            eventsTable.StateCommon.DataCell.Content.Font = new Font("Segoe UI", 9F);
            eventsTable.StateCommon.HeaderColumn.Back.Color1 = Color.FromArgb(60, 60, 60);
            eventsTable.StateCommon.HeaderColumn.Back.Color2 = Color.FromArgb(80, 80, 80);
            eventsTable.StateCommon.HeaderColumn.Content.Color1 = Color.White;
            eventsTable.StateCommon.HeaderColumn.Content.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            eventsTable.StateSelected.DataCell.Back.Color1 = Color.FromArgb(60, 180, 75);
            eventsTable.StateSelected.DataCell.Back.Color2 = Color.FromArgb(50, 150, 65);
            eventsTable.StateSelected.DataCell.Back.ColorAngle = 45F;
            eventsTable.StateSelected.DataCell.Border.Color1 = Color.FromArgb(255, 255, 255);
            eventsTable.StateSelected.DataCell.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            eventsTable.StateSelected.DataCell.Border.Width = 2;
            eventsTable.StateSelected.DataCell.Content.Color1 = Color.White;
            eventsTable.StateTracking.HeaderRow.Back.Color1 = Color.FromArgb(70, 70, 70);
            eventsTable.StateTracking.HeaderRow.Back.Color2 = Color.FromArgb(60, 60, 60);
            eventsTable.StateTracking.HeaderRow.Back.ColorAngle = 0F;
            eventsTable.StateTracking.HeaderRow.Content.Color1 = Color.White;
            eventsTable.TabIndex = 20;
            // 
            // CancelBooking
            // 
            CancelBooking.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CancelBooking.Cursor = Cursors.Hand;
            CancelBooking.Location = new Point(794, 25);
            CancelBooking.Name = "CancelBooking";
            CancelBooking.OverrideDefault.Back.Color1 = Color.FromArgb(255, 94, 87);
            CancelBooking.OverrideDefault.Back.Color2 = Color.FromArgb(255, 67, 67);
            CancelBooking.Size = new Size(244, 38);
            CancelBooking.StateCommon.Back.Color1 = Color.FromArgb(255, 94, 87);
            CancelBooking.StateCommon.Back.Color2 = Color.FromArgb(255, 67, 67);
            CancelBooking.StateCommon.Back.ColorAngle = 45F;
            CancelBooking.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            CancelBooking.StateCommon.Border.Color1 = Color.FromArgb(255, 67, 67);
            CancelBooking.StateCommon.Border.Color2 = Color.FromArgb(255, 94, 87);
            CancelBooking.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            CancelBooking.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            CancelBooking.StateCommon.Border.Rounding = 20F;
            CancelBooking.StateCommon.Border.Width = 1;
            CancelBooking.StateCommon.Content.ShortText.Color1 = Color.White;
            CancelBooking.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            CancelBooking.StateNormal.Back.Color1 = Color.FromArgb(255, 94, 87);
            CancelBooking.StateNormal.Back.Color2 = Color.FromArgb(255, 67, 67);
            CancelBooking.StateNormal.Back.ColorAngle = 45F;
            CancelBooking.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            CancelBooking.StateNormal.Content.ShortText.Color1 = Color.White;
            CancelBooking.StateNormal.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            CancelBooking.StatePressed.Back.Color1 = Color.FromArgb(220, 40, 40);
            CancelBooking.StatePressed.Back.Color2 = Color.FromArgb(200, 30, 30);
            CancelBooking.StatePressed.Border.Rounding = 20F;
            CancelBooking.TabIndex = 21;
            CancelBooking.Values.DropDownArrowColor = Color.Empty;
            CancelBooking.Values.Text = "Cancel Booking";
            CancelBooking.Click += CancelBooking_Click_1;
            // 
            // ABookings
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 42, 42);
            ClientSize = new Size(1074, 675);
            Controls.Add(CancelBooking);
            Controls.Add(eventsTable);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ABookings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ADashboard";
            ((System.ComponentModel.ISupportInitialize)eventsTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Krypton.Toolkit.KryptonDataGridView eventsTable;
        private Krypton.Toolkit.KryptonButton CancelBooking;
    }
}