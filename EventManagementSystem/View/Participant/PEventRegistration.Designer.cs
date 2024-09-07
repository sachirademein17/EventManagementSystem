namespace EventManagementSystem
{
    partial class PEventRegistration
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
            RegisteredEvent = new Krypton.Toolkit.KryptonDataGridView();
            label1 = new Label();
            CancelBooking = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)RegisteredEvent).BeginInit();
            SuspendLayout();
            // 
            // RegisteredEvent
            // 
            RegisteredEvent.BorderStyle = BorderStyle.None;
            RegisteredEvent.ColumnHeadersHeight = 51;
            RegisteredEvent.Location = new Point(44, 118);
            RegisteredEvent.Name = "RegisteredEvent";
            RegisteredEvent.RowHeadersWidth = 62;
            RegisteredEvent.Size = new Size(988, 517);
            RegisteredEvent.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16F);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(44, 38);
            label1.Name = "label1";
            label1.Size = new Size(274, 37);
            label1.TabIndex = 10;
            label1.Text = "Registered Events";
            // 
            // CancelBooking
            // 
            CancelBooking.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CancelBooking.Cursor = Cursors.Hand;
            CancelBooking.Location = new Point(788, 38);
            CancelBooking.Name = "CancelBooking";
            CancelBooking.OverrideDefault.Back.Color1 = Color.FromArgb(0, 122, 204);
            CancelBooking.OverrideDefault.Back.Color2 = Color.FromArgb(0, 122, 204);
            CancelBooking.Size = new Size(244, 38);
            CancelBooking.StateCommon.Back.Color1 = Color.FromArgb(0, 122, 204);
            CancelBooking.StateCommon.Back.Color2 = Color.FromArgb(0, 122, 204);
            CancelBooking.StateCommon.Content.ShortText.Color1 = Color.White;
            CancelBooking.StateCommon.Content.ShortText.Font = new Font("Stencil", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CancelBooking.StateNormal.Back.Color1 = Color.FromArgb(0, 122, 204);
            CancelBooking.StateNormal.Back.Color2 = Color.FromArgb(0, 122, 204);
            CancelBooking.StateNormal.Content.ShortText.Color1 = Color.White;
            CancelBooking.StateNormal.Content.ShortText.Font = new Font("Stencil", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CancelBooking.StatePressed.Back.Color1 = Color.FromArgb(0, 90, 153);
            CancelBooking.StatePressed.Back.Color2 = Color.FromArgb(0, 90, 153);
            CancelBooking.TabIndex = 12;
            CancelBooking.Values.DropDownArrowColor = Color.Empty;
            CancelBooking.Values.Text = "Cancel Booking";
            CancelBooking.Click += CancelBooking_Click;
            // 
            // PEventRegistration
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 42, 42);
            ClientSize = new Size(1074, 675);
            Controls.Add(CancelBooking);
            Controls.Add(label1);
            Controls.Add(RegisteredEvent);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PEventRegistration";
            Text = "PEventRegistration";
            ((System.ComponentModel.ISupportInitialize)RegisteredEvent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView RegisteredEvent;
        private Label label1;
        private Krypton.Toolkit.KryptonButton CancelBooking;
    }
}