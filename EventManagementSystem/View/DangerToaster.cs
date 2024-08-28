using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventManagementSystem.View
{
    public partial class DangerToaster : Form
    {

        int toastX, toastY;

        public DangerToaster(string message)
        {
            InitializeComponent();
            label1.Text = message;
            Position();
        }

        private void Position()
        {
            Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;

            // Calculate position
            this.Location = new Point(workingArea.Right - this.Width, workingArea.Bottom - this.Height);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            // Reposition to the bottom right on form load
            Position();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            // Reposition to the bottom right if the form is resized
            Position();
        }


    }
}
