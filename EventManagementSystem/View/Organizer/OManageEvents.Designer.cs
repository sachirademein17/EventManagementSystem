using Krypton.Toolkit;

namespace EventManagementSystem
{
    partial class OManageEvents
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
            CreateEvent = new KryptonButton();
            DeleteEvent = new KryptonButton();
            UpdateEvent = new KryptonButton();
            eventsTable = new KryptonDataGridView();
            ((System.ComponentModel.ISupportInitialize)eventsTable).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(31, 29);
            label2.Name = "label2";
            label2.Size = new Size(137, 45);
            label2.TabIndex = 2;
            label2.Text = "EVENTS";
            // 
            // CreateEvent
            // 
            CreateEvent.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CreateEvent.Cursor = Cursors.Hand;
            CreateEvent.Location = new Point(788, 28);
            CreateEvent.Name = "CreateEvent";
            CreateEvent.Size = new Size(244, 38);
            CreateEvent.StateCommon.Back.Color1 = Color.FromArgb(0, 209, 161);
            CreateEvent.StateCommon.Back.Color2 = Color.FromArgb(0, 177, 151);
            CreateEvent.StateCommon.Back.ColorAngle = 45F;
            CreateEvent.StateCommon.Back.ColorStyle = PaletteColorStyle.Linear;
            CreateEvent.StateCommon.Border.Color1 = Color.FromArgb(0, 177, 151);
            CreateEvent.StateCommon.Border.Color2 = Color.FromArgb(0, 209, 161);
            CreateEvent.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            CreateEvent.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
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
            CreateEvent.TabIndex = 9;
            CreateEvent.Values.DropDownArrowColor = Color.Empty;
            CreateEvent.Values.Text = "CREATE";
            CreateEvent.Click += CreateEvent_Click;
            // 
            // DeleteEvent
            // 
            DeleteEvent.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DeleteEvent.Cursor = Cursors.Hand;
            DeleteEvent.Location = new Point(263, 29);
            DeleteEvent.Name = "DeleteEvent";
            DeleteEvent.Size = new Size(244, 38);
            DeleteEvent.StateCommon.Back.Color1 = Color.FromArgb(255, 94, 87);
            DeleteEvent.StateCommon.Back.Color2 = Color.FromArgb(255, 67, 67);
            DeleteEvent.StateCommon.Back.ColorAngle = 45F;
            DeleteEvent.StateCommon.Back.ColorStyle = PaletteColorStyle.Linear;
            DeleteEvent.StateCommon.Border.Color1 = Color.FromArgb(255, 67, 67);
            DeleteEvent.StateCommon.Border.Color2 = Color.FromArgb(255, 94, 87);
            DeleteEvent.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            DeleteEvent.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
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
            DeleteEvent.TabIndex = 1;
            DeleteEvent.Values.DropDownArrowColor = Color.Empty;
            DeleteEvent.Values.Text = "DELETE";
            DeleteEvent.Click += DeleteEvent_Click;
            // 
            // UpdateEvent
            // 
            UpdateEvent.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            UpdateEvent.Cursor = Cursors.Hand;
            UpdateEvent.Location = new Point(525, 29);
            UpdateEvent.Name = "UpdateEvent";
            UpdateEvent.Size = new Size(244, 38);
            UpdateEvent.StateCommon.Back.Color1 = Color.FromArgb(0, 140, 255);
            UpdateEvent.StateCommon.Back.Color2 = Color.FromArgb(0, 120, 230);
            UpdateEvent.StateCommon.Back.ColorAngle = 45F;
            UpdateEvent.StateCommon.Back.ColorStyle = PaletteColorStyle.Linear;
            UpdateEvent.StateCommon.Border.Color1 = Color.FromArgb(0, 120, 230);
            UpdateEvent.StateCommon.Border.Color2 = Color.FromArgb(0, 140, 255);
            UpdateEvent.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            UpdateEvent.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
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
            UpdateEvent.TabIndex = 0;
            UpdateEvent.Values.DropDownArrowColor = Color.Empty;
            UpdateEvent.Values.Text = "UPDATE";
            UpdateEvent.Click += UpdateEvent_Click;
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
            eventsTable.StateCommon.BackStyle = PaletteBackStyle.GridBackgroundList;
            eventsTable.StateCommon.DataCell.Back.Color1 = Color.FromArgb(40, 40, 40);
            eventsTable.StateCommon.DataCell.Back.Color2 = Color.FromArgb(40, 40, 40);
            eventsTable.StateCommon.DataCell.Back.ColorStyle = PaletteColorStyle.Rounded;
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
            eventsTable.StateSelected.DataCell.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            eventsTable.StateSelected.DataCell.Border.Width = 2;
            eventsTable.StateSelected.DataCell.Content.Color1 = Color.White;
            eventsTable.StateTracking.HeaderRow.Back.Color1 = Color.FromArgb(70, 70, 70);
            eventsTable.StateTracking.HeaderRow.Back.Color2 = Color.FromArgb(60, 60, 60);
            eventsTable.StateTracking.HeaderRow.Back.ColorAngle = 0F;
            eventsTable.StateTracking.HeaderRow.Content.Color1 = Color.White;
            eventsTable.TabIndex = 18;
            // 
            // OManageEvents
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 47, 47);
            ClientSize = new Size(1074, 675);
            Controls.Add(eventsTable);
            Controls.Add(UpdateEvent);
            Controls.Add(DeleteEvent);
            Controls.Add(CreateEvent);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OManageEvents";
            Text = "OManageEvents";
            ((System.ComponentModel.ISupportInitialize)eventsTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Krypton.Toolkit.KryptonButton CreateEvent;
        private Krypton.Toolkit.KryptonButton DeleteEvent;
        private Krypton.Toolkit.KryptonButton UpdateEvent;
        private KryptonDataGridView eventsTable;
    }
}