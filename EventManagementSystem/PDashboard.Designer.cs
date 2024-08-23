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
            eventsTable = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            PViewEvents = new DataGridView();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)eventsTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PViewEvents).BeginInit();
            SuspendLayout();
            // 
            // eventsTable
            // 
            eventsTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            eventsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            eventsTable.Location = new Point(37, 126);
            eventsTable.Name = "eventsTable";
            eventsTable.RowHeadersWidth = 62;
            eventsTable.Size = new Size(1001, 513);
            eventsTable.TabIndex = 10;
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
            // PViewEvents
            // 
            PViewEvents.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PViewEvents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PViewEvents.Location = new Point(37, 126);
            PViewEvents.Name = "PViewEvents";
            PViewEvents.RowHeadersWidth = 62;
            PViewEvents.Size = new Size(1001, 513);
            PViewEvents.TabIndex = 10;
            // 
            // kryptonButton1
            // 
            kryptonButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            kryptonButton1.Cursor = Cursors.Hand;
            kryptonButton1.Location = new Point(794, 36);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.OverrideDefault.Back.Color1 = Color.FromArgb(0, 122, 204);
            kryptonButton1.OverrideDefault.Back.Color2 = Color.FromArgb(0, 122, 204);
            kryptonButton1.Size = new Size(244, 38);
            kryptonButton1.StateCommon.Back.Color1 = Color.FromArgb(0, 122, 204);
            kryptonButton1.StateCommon.Back.Color2 = Color.FromArgb(0, 122, 204);
            kryptonButton1.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButton1.StateCommon.Content.ShortText.Font = new Font("Stencil", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonButton1.StateNormal.Back.Color1 = Color.FromArgb(0, 122, 204);
            kryptonButton1.StateNormal.Back.Color2 = Color.FromArgb(0, 122, 204);
            kryptonButton1.StateNormal.Content.ShortText.Color1 = Color.White;
            kryptonButton1.StateNormal.Content.ShortText.Font = new Font("Stencil", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonButton1.StatePressed.Back.Color1 = Color.FromArgb(0, 90, 153);
            kryptonButton1.StatePressed.Back.Color2 = Color.FromArgb(0, 90, 153);
            kryptonButton1.TabIndex = 11;
            kryptonButton1.Values.DropDownArrowColor = Color.Empty;
            kryptonButton1.Values.Text = "BOOK";
            kryptonButton1.Click += kryptonButton1_Click;
            // 
            // PDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 42, 42);
            ClientSize = new Size(1074, 675);
            Controls.Add(kryptonButton1);
            Controls.Add(PViewEvents);
            Controls.Add(eventsTable);
            Controls.Add(label1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PDashboard";
            Text = "PDashboard";
            ((System.ComponentModel.ISupportInitialize)eventsTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)PViewEvents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView eventsTable;
        private Label label2;
        private Label label1;
        private DataGridView PViewEvents;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
    }
}