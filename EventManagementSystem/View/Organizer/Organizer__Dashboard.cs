using EventManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventManagementSystem
{
    public partial class Organizer__Dashboard : Form
    {
        public Organizer__Dashboard()
        {
            InitializeComponent();
            loadform(new ODashboard());
        }

        // Functionality to load forms in the main form 
        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
            {
                this.mainpanel.Controls.RemoveAt(0);
            }
            Form form = Form as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(form);
            this.mainpanel.Tag = form;
            form.Show();
        }

        // Load View Events form
        private void ViewEvents_Click(object sender, EventArgs e)
        {
            loadform(new OViewEvents());
        }

        // Load Dashboard form
        private void Dashboard_Click(object sender, EventArgs e)
        {
            loadform(new ODashboard());
        }

        // Load Manage Events form
        private void ManageEvents_Click(object sender, EventArgs e)
        {
            loadform(new OManageEvents());
        }

        // Load Manage Bookings form
        private void ManageBookings_Click(object sender, EventArgs e)
        {
            loadform(new OManageBookings());
        }

        // LogOut fuctionality
        private void LogOut_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
