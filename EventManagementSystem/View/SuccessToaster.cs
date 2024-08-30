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

    public partial class SuccessToaster : Form
    {

        int toastX, toastY;
        private System.Windows.Forms.Timer myTimer;

        public SuccessToaster(string message)
        {
            InitializeComponent();
            label1.Text = message;
            Position();
            myTimer = new System.Windows.Forms.Timer();

            myTimer.Interval = 2000;
            myTimer.Tick += MyTimer_Tick;
            myTimer.Start();
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            myTimer.Stop();
            this.Close();
        }

        private void Position()
        {
            Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;
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