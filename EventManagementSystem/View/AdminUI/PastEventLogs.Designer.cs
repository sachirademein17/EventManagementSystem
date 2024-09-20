namespace EventManagementSystem.View.AdminUI
{
    partial class PastEventLogs
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
            eventsTable = new DataGridView();
            label2 = new Label();
            ViewBookings = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)eventsTable).BeginInit();
            SuspendLayout();
            // 
            // eventsTable
            // 
            eventsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            eventsTable.Location = new Point(12, 104);
            eventsTable.Name = "eventsTable";
            eventsTable.RowHeadersWidth = 62;
            eventsTable.Size = new Size(1050, 559);
            eventsTable.TabIndex = 0;
            eventsTable.CellContentClick += dataGridView1_CellContentClick;
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
            // ViewBookings
            // 
            ViewBookings.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ViewBookings.Cursor = Cursors.Hand;
            ViewBookings.Location = new Point(905, 27);
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
            ViewBookings.TabIndex = 18;
            ViewBookings.Values.DropDownArrowColor = Color.Empty;
            ViewBookings.Values.Text = "BOOKINGS";
            ViewBookings.Click += ViewBookings_Click;
            // 
            // PastEventLogs
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 42, 42);
            ClientSize = new Size(1074, 675);
            Controls.Add(ViewBookings);
            Controls.Add(label2);
            Controls.Add(eventsTable);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PastEventLogs";
            Text = "PastEventLogs";
            ((System.ComponentModel.ISupportInitialize)eventsTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView eventsTable;
        private Label label2;
        private Krypton.Toolkit.KryptonButton ViewBookings;
    }
}