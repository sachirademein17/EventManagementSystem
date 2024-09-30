namespace EventManagementSystem
{
    partial class AManageEvents
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            label2 = new Label();
            eventsTable = new Krypton.Toolkit.KryptonDataGridView();
            UpdateEvent = new Krypton.Toolkit.KryptonButton();
            DeleteEvent = new Krypton.Toolkit.KryptonButton();
            CreateEvent = new Krypton.Toolkit.KryptonButton();
            ViewBookings = new Krypton.Toolkit.KryptonButton();
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
            label2.TabIndex = 11;
            label2.Text = "EVENTS";
            // 
            // eventsTable
            // 
            dataGridViewCellStyle7.BackColor = Color.FromArgb(35, 35, 35);
            eventsTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            eventsTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            eventsTable.BorderStyle = BorderStyle.None;
            eventsTable.ColumnHeadersHeight = 51;
            eventsTable.Location = new Point(12, 117);
            eventsTable.Name = "eventsTable";
            eventsTable.ReadOnly = true;
            eventsTable.RowHeadersWidth = 62;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(40, 40, 40);
            eventsTable.RowsDefaultCellStyle = dataGridViewCellStyle8;
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
            eventsTable.TabIndex = 17;
            // 
            // UpdateEvent
            // 
            UpdateEvent.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            UpdateEvent.Cursor = Cursors.Hand;
            UpdateEvent.Location = new Point(679, 35);
            UpdateEvent.Name = "UpdateEvent";
            UpdateEvent.OverrideDefault.Back.Color1 = Color.FromArgb(0, 140, 255);
            UpdateEvent.OverrideDefault.Back.Color2 = Color.FromArgb(0, 120, 230);
            UpdateEvent.Size = new Size(167, 38);
            UpdateEvent.StateCommon.Back.Color1 = Color.FromArgb(0, 140, 255);
            UpdateEvent.StateCommon.Back.Color2 = Color.FromArgb(0, 120, 230);
            UpdateEvent.StateCommon.Back.ColorAngle = 45F;
            UpdateEvent.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            UpdateEvent.StateCommon.Border.Color1 = Color.FromArgb(0, 120, 230);
            UpdateEvent.StateCommon.Border.Color2 = Color.FromArgb(0, 140, 255);
            UpdateEvent.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            UpdateEvent.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            UpdateEvent.StateCommon.Border.Rounding = 20F;
            UpdateEvent.StateCommon.Border.Width = 1;
            UpdateEvent.StateCommon.Content.ShortText.Color1 = Color.White;
            UpdateEvent.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            UpdateEvent.StateNormal.Back.Color1 = Color.FromArgb(0, 140, 255);
            UpdateEvent.StateNormal.Back.Color2 = Color.FromArgb(0, 120, 230);
            UpdateEvent.StateNormal.Back.ColorAngle = 45F;
            UpdateEvent.StatePressed.Back.Color1 = Color.FromArgb(0, 120, 230);
            UpdateEvent.StatePressed.Back.Color2 = Color.FromArgb(0, 100, 200);
            UpdateEvent.StatePressed.Border.Rounding = 20F;
            UpdateEvent.TabIndex = 18;
            UpdateEvent.Values.DropDownArrowColor = Color.Empty;
            UpdateEvent.Values.Text = "UPDATE";
            UpdateEvent.Click += UpdateEvent_Click_1;
            // 
            // DeleteEvent
            // 
            DeleteEvent.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DeleteEvent.Cursor = Cursors.Hand;
            DeleteEvent.Location = new Point(463, 35);
            DeleteEvent.Name = "DeleteEvent";
            DeleteEvent.OverrideDefault.Back.Color1 = Color.FromArgb(255, 94, 87);
            DeleteEvent.OverrideDefault.Back.Color2 = Color.FromArgb(255, 67, 67);
            DeleteEvent.Size = new Size(167, 38);
            DeleteEvent.StateCommon.Back.Color1 = Color.FromArgb(255, 94, 87);
            DeleteEvent.StateCommon.Back.Color2 = Color.FromArgb(255, 67, 67);
            DeleteEvent.StateCommon.Back.ColorAngle = 45F;
            DeleteEvent.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            DeleteEvent.StateCommon.Border.Color1 = Color.FromArgb(255, 67, 67);
            DeleteEvent.StateCommon.Border.Color2 = Color.FromArgb(255, 94, 87);
            DeleteEvent.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            DeleteEvent.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            DeleteEvent.StateCommon.Border.Rounding = 20F;
            DeleteEvent.StateCommon.Border.Width = 1;
            DeleteEvent.StateCommon.Content.ShortText.Color1 = Color.White;
            DeleteEvent.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            DeleteEvent.StateNormal.Back.Color1 = Color.FromArgb(255, 94, 87);
            DeleteEvent.StateNormal.Back.Color2 = Color.FromArgb(255, 67, 67);
            DeleteEvent.StateNormal.Back.ColorAngle = 45F;
            DeleteEvent.StatePressed.Back.Color1 = Color.FromArgb(220, 40, 40);
            DeleteEvent.StatePressed.Back.Color2 = Color.FromArgb(200, 30, 30);
            DeleteEvent.StatePressed.Border.Rounding = 20F;
            DeleteEvent.TabIndex = 19;
            DeleteEvent.Values.DropDownArrowColor = Color.Empty;
            DeleteEvent.Values.Text = "DELETE";
            DeleteEvent.Click += DeleteEvent_Click_1;
            // 
            // CreateEvent
            // 
            CreateEvent.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CreateEvent.Cursor = Cursors.Hand;
            CreateEvent.Location = new Point(895, 35);
            CreateEvent.Name = "CreateEvent";
            CreateEvent.OverrideDefault.Back.Color1 = Color.FromArgb(0, 209, 161);
            CreateEvent.OverrideDefault.Back.Color2 = Color.FromArgb(0, 177, 151);
            CreateEvent.Size = new Size(167, 38);
            CreateEvent.StateCommon.Back.Color1 = Color.FromArgb(0, 209, 161);
            CreateEvent.StateCommon.Back.Color2 = Color.FromArgb(0, 177, 151);
            CreateEvent.StateCommon.Back.ColorAngle = 45F;
            CreateEvent.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            CreateEvent.StateCommon.Border.Color1 = Color.FromArgb(0, 177, 151);
            CreateEvent.StateCommon.Border.Color2 = Color.FromArgb(0, 209, 161);
            CreateEvent.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            CreateEvent.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            CreateEvent.StateCommon.Border.Rounding = 20F;
            CreateEvent.StateCommon.Border.Width = 1;
            CreateEvent.StateCommon.Content.ShortText.Color1 = Color.White;
            CreateEvent.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            CreateEvent.StateNormal.Back.Color1 = Color.FromArgb(0, 209, 161);
            CreateEvent.StateNormal.Back.Color2 = Color.FromArgb(0, 177, 151);
            CreateEvent.StateNormal.Back.ColorAngle = 45F;
            CreateEvent.StatePressed.Back.Color1 = Color.FromArgb(0, 177, 151);
            CreateEvent.StatePressed.Back.Color2 = Color.FromArgb(0, 140, 120);
            CreateEvent.StatePressed.Border.Rounding = 20F;
            CreateEvent.TabIndex = 20;
            CreateEvent.Values.DropDownArrowColor = Color.Empty;
            CreateEvent.Values.Text = "CREATE";
            CreateEvent.Click += CreateEvent_Click_1;
            // 
            // ViewBookings
            // 
            ViewBookings.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ViewBookings.Cursor = Cursors.Hand;
            ViewBookings.Location = new Point(247, 35);
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
            ViewBookings.TabIndex = 21;
            ViewBookings.Values.DropDownArrowColor = Color.Empty;
            ViewBookings.Values.Text = "BOOK";
            ViewBookings.Click += ViewBookings_Click_1;
            // 
            // AManageEvents
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 42, 42);
            ClientSize = new Size(1074, 675);
            Controls.Add(ViewBookings);
            Controls.Add(UpdateEvent);
            Controls.Add(DeleteEvent);
            Controls.Add(CreateEvent);
            Controls.Add(eventsTable);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AManageEvents";
            Text = "AManageEvents";
            ((System.ComponentModel.ISupportInitialize)eventsTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Krypton.Toolkit.KryptonDataGridView eventsTable;
        private Krypton.Toolkit.KryptonButton UpdateEvent;
        private Krypton.Toolkit.KryptonButton DeleteEvent;
        private Krypton.Toolkit.KryptonButton CreateEvent;
        private Krypton.Toolkit.KryptonButton ViewBookings;
    }
}