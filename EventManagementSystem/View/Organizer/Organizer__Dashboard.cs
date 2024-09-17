using EventManagementSystem.Models;
using EventManagementSystem.View;
using Microsoft.VisualBasic.ApplicationServices;
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
        Organizer user;
        public Organizer__Dashboard()
        {
            InitializeComponent();
            user = CurrentUser.UserDetails as Organizer;
            loadform(new ODashboard(this));
            LoadUserDetails(user);
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
            loadform(new ODashboard(this));
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
            new Form1().Show();
            user.LogOut();
            this.Close();
        }

        public void LoadUserDetails(EventManagementSystem.Models.User user)
        {
            Username.Text = user.UserName;
            Role.Text = user.Role;
            Email.Text = user.Email;
            PhoneNumber.Text = user.PhoneNumber;
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            new UpdateProfile(this).Show();
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        bool minMax = true;

        private void kryptonButton2_Click(object sender, EventArgs e)
        {

            if (minMax)
            {
                this.WindowState = FormWindowState.Maximized;
                minMax = false;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                minMax = true;
            }

        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
