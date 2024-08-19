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
            label2 = new Label();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            eventsTable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)eventsTable).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 16F);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(31, 29);
            label2.Name = "label2";
            label2.Size = new Size(146, 37);
            label2.TabIndex = 2;
            label2.Text = "EVENTS";
            // 
            // kryptonButton1
            // 
            kryptonButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            kryptonButton1.Cursor = Cursors.Hand;
            kryptonButton1.Location = new Point(788, 28);
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
            kryptonButton1.TabIndex = 7;
            kryptonButton1.Values.DropDownArrowColor = Color.Empty;
            kryptonButton1.Values.Text = "CREATE";
            kryptonButton1.Click += kryptonButton1_Click;
            // 
            // eventsTable
            // 
            eventsTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            eventsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            eventsTable.Location = new Point(31, 119);
            eventsTable.Name = "eventsTable";
            eventsTable.RowHeadersWidth = 62;
            eventsTable.Size = new Size(1001, 513);
            eventsTable.TabIndex = 8;
            // 
            // OManageEvents
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 42, 42);
            ClientSize = new Size(1074, 675);
            Controls.Add(eventsTable);
            Controls.Add(kryptonButton1);
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
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private DataGridView eventsTable;
    }
}