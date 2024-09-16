namespace EventManagementSystem
{
    partial class AManageUsers
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
            UpdateUser = new Krypton.Toolkit.KryptonButton();
            DeleteUser = new Krypton.Toolkit.KryptonButton();
            usersTable = new DataGridView();
            CreateUser = new Krypton.Toolkit.KryptonButton();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)usersTable).BeginInit();
            SuspendLayout();
            // 
            // UpdateUser
            // 
            UpdateUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            UpdateUser.Cursor = Cursors.Hand;
            UpdateUser.Location = new Point(204, 35);
            UpdateUser.Name = "UpdateUser";
            UpdateUser.OverrideDefault.Back.Color1 = Color.FromArgb(0, 122, 204);
            UpdateUser.OverrideDefault.Back.Color2 = Color.FromArgb(0, 122, 204);
            UpdateUser.Size = new Size(244, 38);
            UpdateUser.StateCommon.Back.Color1 = Color.FromArgb(0, 122, 204);
            UpdateUser.StateCommon.Back.Color2 = Color.FromArgb(0, 122, 204);
            UpdateUser.StateCommon.Content.ShortText.Color1 = Color.White;
            UpdateUser.StateCommon.Content.ShortText.Font = new Font("Stencil", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UpdateUser.StateNormal.Back.Color1 = Color.FromArgb(0, 122, 204);
            UpdateUser.StateNormal.Back.Color2 = Color.FromArgb(0, 122, 204);
            UpdateUser.StateNormal.Content.ShortText.Color1 = Color.White;
            UpdateUser.StateNormal.Content.ShortText.Font = new Font("Stencil", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UpdateUser.StatePressed.Back.Color1 = Color.FromArgb(0, 90, 153);
            UpdateUser.StatePressed.Back.Color2 = Color.FromArgb(0, 90, 153);
            UpdateUser.TabIndex = 20;
            UpdateUser.Values.DropDownArrowColor = Color.Empty;
            UpdateUser.Values.Text = "UPDATE";
            UpdateUser.Click += UpdateUser_Click;
            // 
            // DeleteUser
            // 
            DeleteUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DeleteUser.Cursor = Cursors.Hand;
            DeleteUser.Location = new Point(496, 35);
            DeleteUser.Name = "DeleteUser";
            DeleteUser.OverrideDefault.Back.Color1 = Color.FromArgb(0, 122, 204);
            DeleteUser.OverrideDefault.Back.Color2 = Color.FromArgb(0, 122, 204);
            DeleteUser.Size = new Size(244, 38);
            DeleteUser.StateCommon.Back.Color1 = Color.FromArgb(0, 122, 204);
            DeleteUser.StateCommon.Back.Color2 = Color.FromArgb(0, 122, 204);
            DeleteUser.StateCommon.Content.ShortText.Color1 = Color.White;
            DeleteUser.StateCommon.Content.ShortText.Font = new Font("Stencil", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeleteUser.StateNormal.Back.Color1 = Color.FromArgb(0, 122, 204);
            DeleteUser.StateNormal.Back.Color2 = Color.FromArgb(0, 122, 204);
            DeleteUser.StateNormal.Content.ShortText.Color1 = Color.White;
            DeleteUser.StateNormal.Content.ShortText.Font = new Font("Stencil", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeleteUser.StatePressed.Back.Color1 = Color.FromArgb(0, 90, 153);
            DeleteUser.StatePressed.Back.Color2 = Color.FromArgb(0, 90, 153);
            DeleteUser.TabIndex = 19;
            DeleteUser.Values.DropDownArrowColor = Color.Empty;
            DeleteUser.Values.Text = "Delete";
            DeleteUser.Click += DeleteUser_Click;
            // 
            // usersTable
            // 
            usersTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            usersTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            usersTable.Location = new Point(12, 126);
            usersTable.Name = "usersTable";
            usersTable.RowHeadersWidth = 62;
            usersTable.Size = new Size(1050, 537);
            usersTable.TabIndex = 18;
            // 
            // CreateUser
            // 
            CreateUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CreateUser.Cursor = Cursors.Hand;
            CreateUser.Location = new Point(794, 35);
            CreateUser.Name = "CreateUser";
            CreateUser.OverrideDefault.Back.Color1 = Color.FromArgb(0, 122, 204);
            CreateUser.OverrideDefault.Back.Color2 = Color.FromArgb(0, 122, 204);
            CreateUser.Size = new Size(244, 38);
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
            CreateUser.TabIndex = 17;
            CreateUser.Values.DropDownArrowColor = Color.Empty;
            CreateUser.Values.Text = "CREATE";
            CreateUser.Click += CreateUser_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 16F);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(37, 36);
            label2.Name = "label2";
            label2.Size = new Size(125, 37);
            label2.TabIndex = 16;
            label2.Text = "USERS";
            // 
            // AManageUsers
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 42, 42);
            ClientSize = new Size(1074, 675);
            Controls.Add(UpdateUser);
            Controls.Add(DeleteUser);
            Controls.Add(usersTable);
            Controls.Add(CreateUser);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AManageUsers";
            Text = "AManageOrganizers";
            ((System.ComponentModel.ISupportInitialize)usersTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonButton UpdateUser;
        private Krypton.Toolkit.KryptonButton DeleteUser;
        private DataGridView usersTable;
        private Krypton.Toolkit.KryptonButton CreateUser;
        private Label label2;
    }
}