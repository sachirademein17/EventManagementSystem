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
            label2 = new Label();
            label1 = new Label();
            BookingEvent = new Krypton.Toolkit.KryptonButton();
            kryptonDataGridView1 = new Krypton.Toolkit.KryptonDataGridView();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
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
            // kryptonDataGridView1
            // 
            kryptonDataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            kryptonDataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            kryptonDataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            kryptonDataGridView1.BorderStyle = BorderStyle.None;
            kryptonDataGridView1.ColumnHeadersHeight = 51;
            kryptonDataGridView1.Location = new Point(37, 131);
            kryptonDataGridView1.Name = "kryptonDataGridView1";
            kryptonDataGridView1.RowHeadersWidth = 62;
            kryptonDataGridView1.Size = new Size(1001, 514);
            kryptonDataGridView1.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            kryptonDataGridView1.StateCommon.DataCell.Back.Color1 = Color.FromArgb(40, 40, 40);
            kryptonDataGridView1.StateCommon.DataCell.Back.Color2 = Color.FromArgb(50, 50, 50);
            kryptonDataGridView1.StateCommon.DataCell.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Switch25;
            kryptonDataGridView1.StateCommon.DataCell.Content.Color1 = Color.LightGray;
            kryptonDataGridView1.StateCommon.DataCell.Content.Font = new Font("Segoe UI", 10F);
            kryptonDataGridView1.StateCommon.HeaderColumn.Back.Color1 = Color.FromArgb(45, 45, 48);
            kryptonDataGridView1.StateCommon.HeaderColumn.Back.Color2 = Color.FromArgb(31, 31, 31);
            kryptonDataGridView1.StateCommon.HeaderColumn.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            kryptonDataGridView1.StateCommon.HeaderColumn.Border.Color1 = Color.Cyan;
            kryptonDataGridView1.StateCommon.HeaderColumn.Content.Color1 = Color.White;
            kryptonDataGridView1.StateCommon.HeaderColumn.Content.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            kryptonDataGridView1.StateSelected.DataCell.Back.Color1 = Color.Cyan;
            kryptonDataGridView1.StateSelected.DataCell.Content.Color1 = Color.Black;
            kryptonDataGridView1.TabIndex = 12;
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
            kryptonPanel1.StateNormal.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            kryptonPanel1.TabIndex = 0;
            // 
            // PDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 42, 42);
            ClientSize = new Size(1074, 675);
            Controls.Add(kryptonDataGridView1);
            Controls.Add(BookingEvent);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(kryptonPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PDashboard";
            Text = "PDashboard";
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private Krypton.Toolkit.KryptonButton BookingEvent;
        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
    }
}