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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            label2 = new Label();
            usersTable = new Krypton.Toolkit.KryptonDataGridView();
            UpdateUser = new Krypton.Toolkit.KryptonButton();
            DeleteUser = new Krypton.Toolkit.KryptonButton();
            CreateUser = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)usersTable).BeginInit();
            SuspendLayout();
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
            // usersTable
            // 
            usersTable.AllowDrop = true;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(35, 35, 35);
            usersTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            usersTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            usersTable.BorderStyle = BorderStyle.None;
            usersTable.ColumnHeadersHeight = 51;
            usersTable.Location = new Point(12, 117);
            usersTable.Name = "usersTable";
            usersTable.ReadOnly = true;
            usersTable.RowHeadersWidth = 62;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(40, 40, 40);
            usersTable.RowsDefaultCellStyle = dataGridViewCellStyle6;
            usersTable.Size = new Size(1050, 546);
            usersTable.StateCommon.Background.Color1 = Color.FromArgb(30, 30, 30);
            usersTable.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            usersTable.StateCommon.DataCell.Back.Color1 = Color.FromArgb(40, 40, 40);
            usersTable.StateCommon.DataCell.Back.Color2 = Color.FromArgb(40, 40, 40);
            usersTable.StateCommon.DataCell.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounded;
            usersTable.StateCommon.DataCell.Content.Color1 = Color.LightGray;
            usersTable.StateCommon.DataCell.Content.Font = new Font("Segoe UI", 9F);
            usersTable.StateCommon.HeaderColumn.Back.Color1 = Color.FromArgb(60, 60, 60);
            usersTable.StateCommon.HeaderColumn.Back.Color2 = Color.FromArgb(80, 80, 80);
            usersTable.StateCommon.HeaderColumn.Content.Color1 = Color.White;
            usersTable.StateCommon.HeaderColumn.Content.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            usersTable.StateSelected.DataCell.Back.Color1 = Color.FromArgb(60, 180, 75);
            usersTable.StateSelected.DataCell.Back.Color2 = Color.FromArgb(50, 150, 65);
            usersTable.StateSelected.DataCell.Back.ColorAngle = 45F;
            usersTable.StateSelected.DataCell.Border.Color1 = Color.FromArgb(255, 255, 255);
            usersTable.StateSelected.DataCell.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            usersTable.StateSelected.DataCell.Border.Width = 2;
            usersTable.StateSelected.DataCell.Content.Color1 = Color.White;
            usersTable.StateTracking.HeaderRow.Back.Color1 = Color.FromArgb(70, 70, 70);
            usersTable.StateTracking.HeaderRow.Back.Color2 = Color.FromArgb(60, 60, 60);
            usersTable.StateTracking.HeaderRow.Back.ColorAngle = 0F;
            usersTable.StateTracking.HeaderRow.Content.Color1 = Color.White;
            usersTable.TabIndex = 21;
            // 
            // UpdateUser
            // 
            UpdateUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            UpdateUser.Cursor = Cursors.Hand;
            UpdateUser.Location = new Point(676, 36);
            UpdateUser.Name = "UpdateUser";
            UpdateUser.OverrideDefault.Back.Color1 = Color.FromArgb(0, 140, 255);
            UpdateUser.OverrideDefault.Back.Color2 = Color.FromArgb(0, 120, 230);
            UpdateUser.Size = new Size(167, 38);
            UpdateUser.StateCommon.Back.Color1 = Color.FromArgb(0, 140, 255);
            UpdateUser.StateCommon.Back.Color2 = Color.FromArgb(0, 120, 230);
            UpdateUser.StateCommon.Back.ColorAngle = 45F;
            UpdateUser.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            UpdateUser.StateCommon.Border.Color1 = Color.FromArgb(0, 120, 230);
            UpdateUser.StateCommon.Border.Color2 = Color.FromArgb(0, 140, 255);
            UpdateUser.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            UpdateUser.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            UpdateUser.StateCommon.Border.Rounding = 20F;
            UpdateUser.StateCommon.Border.Width = 1;
            UpdateUser.StateCommon.Content.ShortText.Color1 = Color.White;
            UpdateUser.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            UpdateUser.StateNormal.Back.Color1 = Color.FromArgb(0, 140, 255);
            UpdateUser.StateNormal.Back.Color2 = Color.FromArgb(0, 120, 230);
            UpdateUser.StateNormal.Back.ColorAngle = 45F;
            UpdateUser.StatePressed.Back.Color1 = Color.FromArgb(0, 120, 230);
            UpdateUser.StatePressed.Back.Color2 = Color.FromArgb(0, 100, 200);
            UpdateUser.StatePressed.Border.Rounding = 20F;
            UpdateUser.TabIndex = 22;
            UpdateUser.Values.DropDownArrowColor = Color.Empty;
            UpdateUser.Values.Text = "UPDATE";
            UpdateUser.Click += UpdateUser_Click_1;
            // 
            // DeleteUser
            // 
            DeleteUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DeleteUser.Cursor = Cursors.Hand;
            DeleteUser.Location = new Point(460, 36);
            DeleteUser.Name = "DeleteUser";
            DeleteUser.OverrideDefault.Back.Color1 = Color.FromArgb(255, 94, 87);
            DeleteUser.OverrideDefault.Back.Color2 = Color.FromArgb(255, 67, 67);
            DeleteUser.Size = new Size(167, 38);
            DeleteUser.StateCommon.Back.Color1 = Color.FromArgb(255, 94, 87);
            DeleteUser.StateCommon.Back.Color2 = Color.FromArgb(255, 67, 67);
            DeleteUser.StateCommon.Back.ColorAngle = 45F;
            DeleteUser.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            DeleteUser.StateCommon.Border.Color1 = Color.FromArgb(255, 67, 67);
            DeleteUser.StateCommon.Border.Color2 = Color.FromArgb(255, 94, 87);
            DeleteUser.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            DeleteUser.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            DeleteUser.StateCommon.Border.Rounding = 20F;
            DeleteUser.StateCommon.Border.Width = 1;
            DeleteUser.StateCommon.Content.ShortText.Color1 = Color.White;
            DeleteUser.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            DeleteUser.StateNormal.Back.Color1 = Color.FromArgb(255, 94, 87);
            DeleteUser.StateNormal.Back.Color2 = Color.FromArgb(255, 67, 67);
            DeleteUser.StateNormal.Back.ColorAngle = 45F;
            DeleteUser.StatePressed.Back.Color1 = Color.FromArgb(220, 40, 40);
            DeleteUser.StatePressed.Back.Color2 = Color.FromArgb(200, 30, 30);
            DeleteUser.StatePressed.Border.Rounding = 20F;
            DeleteUser.TabIndex = 23;
            DeleteUser.Values.DropDownArrowColor = Color.Empty;
            DeleteUser.Values.Text = "DELETE";
            DeleteUser.Click += DeleteUser_Click_1;
            // 
            // CreateUser
            // 
            CreateUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CreateUser.Cursor = Cursors.Hand;
            CreateUser.Location = new Point(892, 36);
            CreateUser.Name = "CreateUser";
            CreateUser.OverrideDefault.Back.Color1 = Color.FromArgb(0, 209, 161);
            CreateUser.OverrideDefault.Back.Color2 = Color.FromArgb(0, 177, 151);
            CreateUser.Size = new Size(167, 38);
            CreateUser.StateCommon.Back.Color1 = Color.FromArgb(0, 209, 161);
            CreateUser.StateCommon.Back.Color2 = Color.FromArgb(0, 177, 151);
            CreateUser.StateCommon.Back.ColorAngle = 45F;
            CreateUser.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            CreateUser.StateCommon.Border.Color1 = Color.FromArgb(0, 177, 151);
            CreateUser.StateCommon.Border.Color2 = Color.FromArgb(0, 209, 161);
            CreateUser.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            CreateUser.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            CreateUser.StateCommon.Border.Rounding = 20F;
            CreateUser.StateCommon.Border.Width = 1;
            CreateUser.StateCommon.Content.ShortText.Color1 = Color.White;
            CreateUser.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            CreateUser.StateNormal.Back.Color1 = Color.FromArgb(0, 209, 161);
            CreateUser.StateNormal.Back.Color2 = Color.FromArgb(0, 177, 151);
            CreateUser.StateNormal.Back.ColorAngle = 45F;
            CreateUser.StatePressed.Back.Color1 = Color.FromArgb(0, 177, 151);
            CreateUser.StatePressed.Back.Color2 = Color.FromArgb(0, 140, 120);
            CreateUser.StatePressed.Border.Rounding = 20F;
            CreateUser.TabIndex = 24;
            CreateUser.Values.DropDownArrowColor = Color.Empty;
            CreateUser.Values.Text = "CREATE";
            CreateUser.Click += CreateUser_Click_1;
            // 
            // AManageUsers
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 42, 42);
            ClientSize = new Size(1074, 675);
            Controls.Add(UpdateUser);
            Controls.Add(DeleteUser);
            Controls.Add(CreateUser);
            Controls.Add(usersTable);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AManageUsers";
            Text = "AManageOrganizers";
            ((System.ComponentModel.ISupportInitialize)usersTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Krypton.Toolkit.KryptonDataGridView usersTable;
        private Krypton.Toolkit.KryptonButton UpdateUser;
        private Krypton.Toolkit.KryptonButton DeleteUser;
        private Krypton.Toolkit.KryptonButton CreateUser;
    }
}