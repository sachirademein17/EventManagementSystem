﻿namespace EventManagementSystem.View.AdminUI
{
    partial class APastEventLogs
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
            eventsTable = new Krypton.Toolkit.KryptonDataGridView();
            ViewBookings = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)eventsTable).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 16F);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(34, 27);
            label2.Name = "label2";
            label2.Size = new Size(249, 37);
            label2.TabIndex = 17;
            label2.Text = "Past Events Log";
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
            eventsTable.TabIndex = 19;
            // 
            // ViewBookings
            // 
            ViewBookings.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ViewBookings.Cursor = Cursors.Hand;
            ViewBookings.Location = new Point(883, 27);
            ViewBookings.Name = "ViewBookings";
            ViewBookings.OverrideDefault.Back.Color1 = Color.FromArgb(255, 152, 0);
            ViewBookings.OverrideDefault.Back.Color2 = Color.FromArgb(255, 183, 77);
            ViewBookings.OverrideDefault.Back.ColorAngle = 45F;
            ViewBookings.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            ViewBookings.Size = new Size(167, 38);
            ViewBookings.StateCommon.Back.Color1 = Color.FromArgb(255, 152, 0);
            ViewBookings.StateCommon.Back.Color2 = Color.FromArgb(255, 183, 77);
            ViewBookings.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            ViewBookings.StateCommon.Border.Color1 = Color.FromArgb(255, 152, 0);
            ViewBookings.StateCommon.Border.Color2 = Color.FromArgb(255, 183, 77);
            ViewBookings.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            ViewBookings.StateCommon.Border.Rounding = 20F;
            ViewBookings.StateCommon.Border.Width = 1;
            ViewBookings.StateCommon.Content.ShortText.Color1 = Color.White;
            ViewBookings.StateCommon.Content.ShortText.Font = new Font("Stencil", 10F);
            ViewBookings.StatePressed.Back.Color1 = Color.FromArgb(239, 108, 0);
            ViewBookings.StatePressed.Back.Color2 = Color.FromArgb(255, 143, 0);
            ViewBookings.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            ViewBookings.StatePressed.Content.ShortText.Color1 = Color.White;
            ViewBookings.StateTracking.Back.Color1 = Color.FromArgb(245, 124, 0);
            ViewBookings.StateTracking.Back.Color2 = Color.FromArgb(255, 179, 0);
            ViewBookings.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            ViewBookings.StateTracking.Content.ShortText.Color1 = Color.White;
            ViewBookings.TabIndex = 22;
            ViewBookings.Values.DropDownArrowColor = Color.Empty;
            ViewBookings.Values.Text = "BOOK";
            ViewBookings.Click += ViewBookings_Click_1;
            // 
            // APastEventLogs
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 42, 42);
            ClientSize = new Size(1074, 675);
            Controls.Add(ViewBookings);
            Controls.Add(eventsTable);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "APastEventLogs";
            Text = "PastEventLogs";
            ((System.ComponentModel.ISupportInitialize)eventsTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Krypton.Toolkit.KryptonDataGridView eventsTable;
        private Krypton.Toolkit.KryptonButton ViewBookings;
    }
}