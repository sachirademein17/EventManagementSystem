namespace EventManagementSystem
{
    partial class PDashboard
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
            label1 = new Label();
            BookingEvent = new Krypton.Toolkit.KryptonButton();
            eventsTable = new Krypton.Toolkit.KryptonDataGridView();
            ((System.ComponentModel.ISupportInitialize)eventsTable).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 16F);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(37, 36);
            label2.Name = "label2";
            label2.Size = new Size(146, 37);
            label2.TabIndex = 9;
            label2.Text = "EVENTS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16F);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(37, 36);
            label1.Name = "label1";
            label1.Size = new Size(146, 37);
            label1.TabIndex = 9;
            label1.Text = "EVENTS";
            // 
            // BookingEvent
            // 
            BookingEvent.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BookingEvent.Cursor = Cursors.Hand;
            BookingEvent.Location = new Point(794, 36);
            BookingEvent.Name = "BookingEvent";
            BookingEvent.OverrideDefault.Back.Color1 = Color.FromArgb(255, 152, 0);
            BookingEvent.OverrideDefault.Back.Color2 = Color.FromArgb(255, 183, 77);
            BookingEvent.OverrideDefault.Back.ColorAngle = 45F;
            BookingEvent.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            BookingEvent.Size = new Size(244, 38);
            BookingEvent.StateCommon.Back.Color1 = Color.FromArgb(255, 152, 0);
            BookingEvent.StateCommon.Back.Color2 = Color.FromArgb(255, 183, 77);
            BookingEvent.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            BookingEvent.StateCommon.Border.Color1 = Color.FromArgb(255, 152, 0);
            BookingEvent.StateCommon.Border.Color2 = Color.FromArgb(255, 183, 77);
            BookingEvent.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            BookingEvent.StateCommon.Border.Rounding = 20F;
            BookingEvent.StateCommon.Border.Width = 1;
            BookingEvent.StateCommon.Content.ShortText.Color1 = Color.White;
            BookingEvent.StateCommon.Content.ShortText.Font = new Font("Stencil", 10F);
            BookingEvent.StatePressed.Back.Color1 = Color.FromArgb(239, 108, 0);
            BookingEvent.StatePressed.Back.Color2 = Color.FromArgb(255, 143, 0);
            BookingEvent.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            BookingEvent.StatePressed.Content.ShortText.Color1 = Color.White;
            BookingEvent.StateTracking.Back.Color1 = Color.FromArgb(245, 124, 0);
            BookingEvent.StateTracking.Back.Color2 = Color.FromArgb(255, 179, 0);
            BookingEvent.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            BookingEvent.StateTracking.Content.ShortText.Color1 = Color.White;
            BookingEvent.TabIndex = 11;
            BookingEvent.Values.DropDownArrowColor = Color.Empty;
            BookingEvent.Values.Text = "BOOK";
            BookingEvent.Click += BookingEvent_Click;
            // 
            // eventsTable
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(35, 35, 35);
            eventsTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            eventsTable.BorderStyle = BorderStyle.None;
            eventsTable.ColumnHeadersHeight = 51;
            eventsTable.Location = new Point(12, 117);
            eventsTable.Name = "eventsTable";
            eventsTable.RowHeadersWidth = 62;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(40, 40, 40);
            eventsTable.RowsDefaultCellStyle = dataGridViewCellStyle2;
            eventsTable.Size = new Size(1050, 546);
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
            eventsTable.TabIndex = 18;
            // 
            // PDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 42, 42);
            ClientSize = new Size(1074, 675);
            Controls.Add(eventsTable);
            Controls.Add(BookingEvent);
            Controls.Add(label1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PDashboard";
            Text = "PDashboard";
            Load += PDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)eventsTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private Krypton.Toolkit.KryptonButton BookingEvent;
        private Krypton.Toolkit.KryptonDataGridView eventsTable;
    }
}