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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label2 = new Label();
            CreateEvent = new KryptonButton();
            eventsTable = new DataGridView();
            DeleteEvent = new KryptonButton();
            UpdateEvent = new KryptonButton();
            kryptonPanel1 = new KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)eventsTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
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
            // eventsTable
            // 
            eventsTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(40, 40, 40);
            eventsTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            eventsTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            eventsTable.BackgroundColor = Color.FromArgb(25, 25, 25);
            eventsTable.BorderStyle = BorderStyle.None;
            eventsTable.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(44, 72, 117);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            eventsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            eventsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(31, 31, 31);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(44, 72, 117);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            eventsTable.DefaultCellStyle = dataGridViewCellStyle3;
            eventsTable.GridColor = Color.FromArgb(61, 61, 61);
            eventsTable.Location = new Point(31, 119);
            eventsTable.Name = "eventsTable";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(31, 31, 31);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            eventsTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            eventsTable.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            eventsTable.Size = new Size(1001, 513);
            eventsTable.TabIndex = 8;
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
            // kryptonPanel1
            // 
            kryptonPanel1.Dock = DockStyle.Fill;
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(1074, 675);
            kryptonPanel1.StateNormal.Color1 = Color.FromArgb(75, 75, 75);
            kryptonPanel1.StateNormal.Color2 = Color.Gray;
            kryptonPanel1.StateNormal.ColorAngle = 90F;
            kryptonPanel1.StateNormal.ColorStyle = PaletteColorStyle.Linear;
            kryptonPanel1.TabIndex = 10;
            // 
            // OManageEvents
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 47, 47);
            ClientSize = new Size(1074, 675);
            Controls.Add(UpdateEvent);
            Controls.Add(DeleteEvent);
            Controls.Add(eventsTable);
            Controls.Add(CreateEvent);
            Controls.Add(label2);
            Controls.Add(kryptonPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OManageEvents";
            Text = "OManageEvents";
            ((System.ComponentModel.ISupportInitialize)eventsTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Krypton.Toolkit.KryptonButton CreateEvent;
        private DataGridView eventsTable;
        private Krypton.Toolkit.KryptonButton DeleteEvent;
        private Krypton.Toolkit.KryptonButton UpdateEvent;
        private KryptonPanel kryptonPanel1;
    }
}