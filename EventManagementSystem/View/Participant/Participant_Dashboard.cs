using EventManagementSystem.Models;
using EventManagementSystem.View.Participant;
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
    public partial class Participant_Dashboard : Form
    {
        Participant user;
        public Participant_Dashboard()
        {
            InitializeComponent();
            user = CurrentUser.UserDetails as Participant;
            loadform(new PDashboard());
            LoadUserDetail();
        }


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


        private void Dashboard_Click(object sender, EventArgs e)
        {
            loadform(new PDashboard());
        }

        private void EventRegistration_Click(object sender, EventArgs e)
        {
            loadform(new PEventRegistration());
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            CurrentUser.ClearUserDetails();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void LoadUserDetail()
        {
            Username.Text = user.UserName;
            Email.Text = user.Email;
            PhoneNumber.Text = user.PhoneNumber;
            Role.Text = user.Role;
        }

        private void ViewBookings_Click(object sender, EventArgs e)
        {
        }

        private void ViewEvents_Click(object sender, EventArgs e)
        {

        }

        private void BookingsLogs_Click(object sender, EventArgs e)
        {
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        bool minMax = true;

        private void MinmaxBtn_Click(object sender, EventArgs e)
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

        private void RestoreBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void LogOut_Click_1(object sender, EventArgs e)
        {
            user.LogOut();
            this.Close();
            new Form1().Show();
        }

        private void ViewEvents_Click_1(object sender, EventArgs e)
        {
            loadform(new PDashboard());

        }

        private void ViewBookings_Click_1(object sender, EventArgs e)
        {
            loadform(new PEventRegistration());

        }

        private void BookingLogs_Click(object sender, EventArgs e)
        {
            loadform(new BookingLogs());

        }
    }
}
