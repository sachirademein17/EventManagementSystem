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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            UpdateEvent = new Krypton.Toolkit.KryptonButton();
            DeleteEvent = new Krypton.Toolkit.KryptonButton();
            CreateEvent = new Krypton.Toolkit.KryptonButton();
            label2 = new Label();
            ViewBookings = new Krypton.Toolkit.KryptonButton();
            eventsTable = new Krypton.Toolkit.KryptonDataGridView();
            ((System.ComponentModel.ISupportInitialize)eventsTable).BeginInit();
            SuspendLayout();
            // 
            // UpdateEvent
            // 
            UpdateEvent.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            UpdateEvent.Cursor = Cursors.Hand;
            UpdateEvent.Location = new Point(517, 35);
            UpdateEvent.Name = "UpdateEvent";
            UpdateEvent.OverrideDefault.Back.Color1 = Color.FromArgb(0, 122, 204);
            UpdateEvent.OverrideDefault.Back.Color2 = Color.FromArgb(0, 122, 204);
            UpdateEvent.Size = new Size(145, 38);
            UpdateEvent.StateCommon.Back.Color1 = Color.FromArgb(0, 122, 204);
            UpdateEvent.StateCommon.Back.Color2 = Color.FromArgb(0, 122, 204);
            UpdateEvent.StateCommon.Content.ShortText.Color1 = Color.White;
            UpdateEvent.StateCommon.Content.ShortText.Font = new Font("Stencil", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UpdateEvent.StateNormal.Back.Color1 = Color.FromArgb(0, 122, 204);
            UpdateEvent.StateNormal.Back.Color2 = Color.FromArgb(0, 122, 204);
            UpdateEvent.StateNormal.Content.ShortText.Color1 = Color.White;
            UpdateEvent.StateNormal.Content.ShortText.Font = new Font("Stencil", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UpdateEvent.StatePressed.Back.Color1 = Color.FromArgb(0, 90, 153);
            UpdateEvent.StatePressed.Back.Color2 = Color.FromArgb(0, 90, 153);
            UpdateEvent.TabIndex = 15;
            UpdateEvent.Values.DropDownArrowColor = Color.Empty;
            UpdateEvent.Values.Text = "UPDATE";
            UpdateEvent.Click += UpdateEvent_Click;
            // 
            // DeleteEvent
            // 
            DeleteEvent.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DeleteEvent.Cursor = Cursors.Hand;
            DeleteEvent.Location = new Point(705, 35);
            DeleteEvent.Name = "DeleteEvent";
            DeleteEvent.OverrideDefault.Back.Color1 = Color.FromArgb(0, 122, 204);
            DeleteEvent.OverrideDefault.Back.Color2 = Color.FromArgb(0, 122, 204);
            DeleteEvent.Size = new Size(145, 38);
            DeleteEvent.StateCommon.Back.Color1 = Color.FromArgb(0, 122, 204);
            DeleteEvent.StateCommon.Back.Color2 = Color.FromArgb(0, 122, 204);
            DeleteEvent.StateCommon.Content.ShortText.Color1 = Color.White;
            DeleteEvent.StateCommon.Content.ShortText.Font = new Font("Stencil", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeleteEvent.StateNormal.Back.Color1 = Color.FromArgb(0, 122, 204);
            DeleteEvent.StateNormal.Back.Color2 = Color.FromArgb(0, 122, 204);
            DeleteEvent.StateNormal.Content.ShortText.Color1 = Color.White;
            DeleteEvent.StateNormal.Content.ShortText.Font = new Font("Stencil", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeleteEvent.StatePressed.Back.Color1 = Color.FromArgb(0, 90, 153);
            DeleteEvent.StatePressed.Back.Color2 = Color.FromArgb(0, 90, 153);
            DeleteEvent.TabIndex = 14;
            DeleteEvent.Values.DropDownArrowColor = Color.Empty;
            DeleteEvent.Values.Text = "Delete";
            DeleteEvent.Click += DeleteEvent_Click;
            // 
            // CreateEvent
            // 
            CreateEvent.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CreateEvent.Cursor = Cursors.Hand;
            CreateEvent.Location = new Point(893, 35);
            CreateEvent.Name = "CreateEvent";
            CreateEvent.OverrideDefault.Back.Color1 = Color.FromArgb(0, 122, 204);
            CreateEvent.OverrideDefault.Back.Color2 = Color.FromArgb(0, 122, 204);
            CreateEvent.Size = new Size(145, 38);
            CreateEvent.StateCommon.Back.Color1 = Color.FromArgb(0, 122, 204);
            CreateEvent.StateCommon.Back.Color2 = Color.FromArgb(0, 122, 204);
            CreateEvent.StateCommon.Content.ShortText.Color1 = Color.White;
            CreateEvent.StateCommon.Content.ShortText.Font = new Font("Stencil", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CreateEvent.StateNormal.Back.Color1 = Color.FromArgb(0, 122, 204);
            CreateEvent.StateNormal.Back.Color2 = Color.FromArgb(0, 122, 204);
            CreateEvent.StateNormal.Content.ShortText.Color1 = Color.White;
            CreateEvent.StateNormal.Content.ShortText.Font = new Font("Stencil", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CreateEvent.StatePressed.Back.Color1 = Color.FromArgb(0, 90, 153);
            CreateEvent.StatePressed.Back.Color2 = Color.FromArgb(0, 90, 153);
            CreateEvent.TabIndex = 12;
            CreateEvent.Values.DropDownArrowColor = Color.Empty;
            CreateEvent.Values.Text = "CREATE";
            CreateEvent.Click += CreateEvent_Click;
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
            // ViewBookings
            // 
            ViewBookings.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ViewBookings.Cursor = Cursors.Hand;
            ViewBookings.Location = new Point(329, 35);
            ViewBookings.Name = "ViewBookings";
            ViewBookings.OverrideDefault.Back.Color1 = Color.FromArgb(0, 122, 204);
            ViewBookings.OverrideDefault.Back.Color2 = Color.FromArgb(0, 122, 204);
            ViewBookings.Size = new Size(145, 38);
            ViewBookings.StateCommon.Back.Color1 = Color.FromArgb(0, 122, 204);
            ViewBookings.StateCommon.Back.Color2 = Color.FromArgb(0, 122, 204);
            ViewBookings.StateCommon.Content.ShortText.Color1 = Color.White;
            ViewBookings.StateCommon.Content.ShortText.Font = new Font("Stencil", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ViewBookings.StateNormal.Back.Color1 = Color.FromArgb(0, 122, 204);
            ViewBookings.StateNormal.Back.Color2 = Color.FromArgb(0, 122, 204);
            ViewBookings.StateNormal.Content.ShortText.Color1 = Color.White;
            ViewBookings.StateNormal.Content.ShortText.Font = new Font("Stencil", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ViewBookings.StatePressed.Back.Color1 = Color.FromArgb(0, 90, 153);
            ViewBookings.StatePressed.Back.Color2 = Color.FromArgb(0, 90, 153);
            ViewBookings.TabIndex = 16;
            ViewBookings.Values.DropDownArrowColor = Color.Empty;
            ViewBookings.Values.Text = "BOOKINGS";
            ViewBookings.Click += ViewBookings_Click;
            // 
            // eventsTable
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(35, 35, 35);
            eventsTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            eventsTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            eventsTable.BorderStyle = BorderStyle.None;
            eventsTable.ColumnHeadersHeight = 51;
            eventsTable.Location = new Point(12, 117);
            eventsTable.Name = "eventsTable";
            eventsTable.ReadOnly = true;
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
            eventsTable.TabIndex = 17;
            // 
            // AManageEvents
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 42, 42);
            ClientSize = new Size(1074, 675);
            Controls.Add(eventsTable);
            Controls.Add(ViewBookings);
            Controls.Add(UpdateEvent);
            Controls.Add(DeleteEvent);
            Controls.Add(CreateEvent);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AManageEvents";
            Text = "AManageEvents";
            ((System.ComponentModel.ISupportInitialize)eventsTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonButton UpdateEvent;
        private Krypton.Toolkit.KryptonButton DeleteEvent;
        private Krypton.Toolkit.KryptonButton CreateEvent;
        private Label label2;
        private Krypton.Toolkit.KryptonButton ViewBookings;
        private Krypton.Toolkit.KryptonDataGridView eventsTable;
    }
}