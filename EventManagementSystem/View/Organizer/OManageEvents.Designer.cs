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
            CreateEvent = new Krypton.Toolkit.KryptonButton();
            eventsTable = new DataGridView();
            DeleteEvent = new Krypton.Toolkit.KryptonButton();
            UpdateEvent = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)eventsTable).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 16F);
            label2.ForeColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(31, 29);
            label2.Name = "label2";
            label2.Size = new Size(146, 37);
            label2.TabIndex = 2;
            label2.Text = "EVENTS";
            // 
            // CreateEvent
            // 
            CreateEvent.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CreateEvent.Cursor = Cursors.Hand;
            CreateEvent.Location = new Point(788, 28);
            CreateEvent.Name = "CreateEvent";
            CreateEvent.OverrideDefault.Back.Color1 = Color.FromArgb(97, 118, 227);
            CreateEvent.OverrideDefault.Back.Color2 = Color.FromArgb(97, 118, 227);
            CreateEvent.OverrideDefault.Content.ShortText.Color1 = Color.White;
            CreateEvent.OverrideDefault.Content.ShortText.Color2 = Color.White;
            CreateEvent.Size = new Size(244, 38);
            CreateEvent.StateCommon.Back.Color1 = Color.FromArgb(97, 118, 227);
            CreateEvent.StateCommon.Back.Color2 = Color.FromArgb(97, 118, 227);
            CreateEvent.StateCommon.Content.ShortText.Color1 = Color.White;
            CreateEvent.StateCommon.Content.ShortText.Font = new Font("Stencil", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CreateEvent.StateNormal.Back.Color1 = Color.FromArgb(67, 198, 172);
            CreateEvent.StateNormal.Back.Color2 = Color.FromArgb(25, 22, 84);
            CreateEvent.StateNormal.Back.ColorAngle = 45F;
            CreateEvent.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            CreateEvent.StateNormal.Content.ShortText.Color1 = Color.White;
            CreateEvent.StateNormal.Content.ShortText.Font = new Font("Stencil", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CreateEvent.StatePressed.Back.Color1 = Color.FromArgb(67, 87, 181);
            CreateEvent.StatePressed.Back.Color2 = Color.FromArgb(67, 87, 181);
            CreateEvent.TabIndex = 7;
            CreateEvent.Values.DropDownArrowColor = Color.Empty;
            CreateEvent.Values.Text = "CREATE";
            CreateEvent.Click += CreateEvent_Click;
            // 
            // eventsTable
            // 
            eventsTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            eventsTable.BackgroundColor = Color.FromArgb(61, 61, 61);
            eventsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            eventsTable.Location = new Point(31, 119);
            eventsTable.Name = "eventsTable";
            eventsTable.RowHeadersWidth = 62;
            eventsTable.Size = new Size(1001, 513);
            eventsTable.TabIndex = 8;
            // 
            // DeleteEvent
            // 
            DeleteEvent.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DeleteEvent.Cursor = Cursors.Hand;
            DeleteEvent.Location = new Point(490, 28);
            DeleteEvent.Name = "DeleteEvent";
            DeleteEvent.OverrideDefault.Back.Color1 = Color.FromArgb(97, 118, 227);
            DeleteEvent.OverrideDefault.Back.Color2 = Color.FromArgb(97, 118, 227);
            DeleteEvent.OverrideDefault.Content.ShortText.Color1 = Color.White;
            DeleteEvent.OverrideDefault.Content.ShortText.Color2 = Color.White;
            DeleteEvent.Size = new Size(244, 38);
            DeleteEvent.StateCommon.Back.Color1 = Color.FromArgb(97, 118, 227);
            DeleteEvent.StateCommon.Back.Color2 = Color.FromArgb(97, 118, 227);
            DeleteEvent.StateCommon.Content.ShortText.Color1 = Color.White;
            DeleteEvent.StateCommon.Content.ShortText.Font = new Font("Stencil", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeleteEvent.StateNormal.Back.Color1 = Color.FromArgb(67, 198, 172);
            DeleteEvent.StateNormal.Back.Color2 = Color.FromArgb(25, 22, 84);
            DeleteEvent.StateNormal.Back.ColorAngle = 45F;
            DeleteEvent.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            DeleteEvent.StateNormal.Content.ShortText.Color1 = Color.White;
            DeleteEvent.StateNormal.Content.ShortText.Font = new Font("Stencil", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeleteEvent.StatePressed.Back.Color1 = Color.FromArgb(67, 87, 181);
            DeleteEvent.StatePressed.Back.Color2 = Color.FromArgb(67, 87, 181);
            DeleteEvent.TabIndex = 9;
            DeleteEvent.Values.DropDownArrowColor = Color.Empty;
            DeleteEvent.Values.Text = "Delete";
            DeleteEvent.Click += DeleteEvent_Click;
            // 
            // UpdateEvent
            // 
            UpdateEvent.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            UpdateEvent.Cursor = Cursors.Hand;
            UpdateEvent.Location = new Point(198, 28);
            UpdateEvent.Name = "UpdateEvent";
            UpdateEvent.OverrideDefault.Back.Color1 = Color.FromArgb(97, 118, 227);
            UpdateEvent.OverrideDefault.Back.Color2 = Color.FromArgb(97, 118, 227);
            UpdateEvent.OverrideDefault.Content.ShortText.Color1 = Color.White;
            UpdateEvent.OverrideDefault.Content.ShortText.Color2 = Color.White;
            UpdateEvent.Size = new Size(244, 38);
            UpdateEvent.StateCommon.Back.Color1 = Color.FromArgb(97, 118, 227);
            UpdateEvent.StateCommon.Back.Color2 = Color.FromArgb(97, 118, 227);
            UpdateEvent.StateCommon.Content.ShortText.Color1 = Color.White;
            UpdateEvent.StateCommon.Content.ShortText.Font = new Font("Stencil", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UpdateEvent.StateNormal.Back.Color1 = Color.FromArgb(67, 198, 172);
            UpdateEvent.StateNormal.Back.Color2 = Color.FromArgb(25, 22, 84);
            UpdateEvent.StateNormal.Back.ColorAngle = 45F;
            UpdateEvent.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            UpdateEvent.StateNormal.Content.ShortText.Color1 = Color.White;
            UpdateEvent.StateNormal.Content.ShortText.Font = new Font("Stencil", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UpdateEvent.StatePressed.Back.Color1 = Color.FromArgb(67, 87, 181);
            UpdateEvent.StatePressed.Back.Color2 = Color.FromArgb(67, 87, 181);
            UpdateEvent.TabIndex = 10;
            UpdateEvent.Values.DropDownArrowColor = Color.Empty;
            UpdateEvent.Values.Text = "UPDATE";
            UpdateEvent.Click += UpdateEvent_Click;
            // 
            // OManageEvents
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            ClientSize = new Size(1074, 675);
            Controls.Add(UpdateEvent);
            Controls.Add(DeleteEvent);
            Controls.Add(eventsTable);
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
        private DataGridView eventsTable;
        private Krypton.Toolkit.KryptonButton DeleteEvent;
        private Krypton.Toolkit.KryptonButton UpdateEvent;
    }
}