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
            UpdateEvent = new Krypton.Toolkit.KryptonButton();
            DeleteEvent = new Krypton.Toolkit.KryptonButton();
            eventsTable = new DataGridView();
            CreateEvent = new Krypton.Toolkit.KryptonButton();
            label2 = new Label();
            CreateUser = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)eventsTable).BeginInit();
            SuspendLayout();
            // 
            // UpdateEvent
            // 
            UpdateEvent.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            UpdateEvent.Cursor = Cursors.Hand;
            UpdateEvent.Location = new Point(582, 35);
            UpdateEvent.Name = "UpdateEvent";
            UpdateEvent.OverrideDefault.Back.Color1 = Color.FromArgb(0, 122, 204);
            UpdateEvent.OverrideDefault.Back.Color2 = Color.FromArgb(0, 122, 204);
            UpdateEvent.Size = new Size(111, 38);
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
            DeleteEvent.Location = new Point(713, 35);
            DeleteEvent.Name = "DeleteEvent";
            DeleteEvent.OverrideDefault.Back.Color1 = Color.FromArgb(0, 122, 204);
            DeleteEvent.OverrideDefault.Back.Color2 = Color.FromArgb(0, 122, 204);
            DeleteEvent.Size = new Size(122, 38);
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
            // eventsTable
            // 
            eventsTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            eventsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            eventsTable.Location = new Point(37, 126);
            eventsTable.Name = "eventsTable";
            eventsTable.RowHeadersWidth = 62;
            eventsTable.Size = new Size(1001, 513);
            eventsTable.TabIndex = 13;
            // 
            // CreateEvent
            // 
            CreateEvent.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CreateEvent.Cursor = Cursors.Hand;
            CreateEvent.Location = new Point(868, 35);
            CreateEvent.Name = "CreateEvent";
            CreateEvent.OverrideDefault.Back.Color1 = Color.FromArgb(0, 122, 204);
            CreateEvent.OverrideDefault.Back.Color2 = Color.FromArgb(0, 122, 204);
            CreateEvent.Size = new Size(170, 38);
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
            // CreateUser
            // 
            CreateUser.Cursor = Cursors.Hand;
            CreateUser.Location = new Point(361, 36);
            CreateUser.Name = "CreateUser";
            CreateUser.OverrideDefault.Back.Color1 = Color.FromArgb(0, 122, 204);
            CreateUser.OverrideDefault.Back.Color2 = Color.FromArgb(0, 122, 204);
            CreateUser.Size = new Size(202, 38);
            CreateUser.StateCommon.Back.Color1 = Color.FromArgb(0, 122, 204);
            CreateUser.StateCommon.Back.Color2 = Color.FromArgb(0, 122, 204);
            CreateUser.StateCommon.Content.ShortText.Color1 = Color.White;
            CreateUser.StateCommon.Content.ShortText.Font = new Font("Stencil", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CreateUser.StateNormal.Back.Color1 = Color.FromArgb(0, 122, 204);
            CreateUser.StateNormal.Back.Color2 = Color.FromArgb(0, 122, 204);
            CreateUser.StateNormal.Content.ShortText.Color1 = Color.White;
            CreateUser.StateNormal.Content.ShortText.Font = new Font("Stencil", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CreateUser.StatePressed.Back.Color1 = Color.FromArgb(0, 90, 153);
            CreateUser.StatePressed.Back.Color2 = Color.FromArgb(0, 90, 153);
            CreateUser.TabIndex = 19;
            CreateUser.Values.DropDownArrowColor = Color.Empty;
            CreateUser.Values.Text = "View Participants";
            CreateUser.Click += CreateUser_Click;
            // 
            // AManageEvents
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 42, 42);
            ClientSize = new Size(1074, 675);
            Controls.Add(CreateUser);
            Controls.Add(UpdateEvent);
            Controls.Add(DeleteEvent);
            Controls.Add(eventsTable);
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
        private DataGridView eventsTable;
        private Krypton.Toolkit.KryptonButton CreateEvent;
        private Label label2;
        private Krypton.Toolkit.KryptonButton CreateUser;
    }
}