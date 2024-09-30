using EventManagementSystem.Controllers;
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
        public Point mouseLocation;
        public Participant_Dashboard(EventManagementSystem.Models.User user)
        {
            InitializeComponent();
            this.user = user as Participant;
            loadform(new PDashboard(this.user));
            LoadUserDetail();
        }

        // fuctionality to add the form as a section
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


        
        // Load user details on log
        private void LoadUserDetail()
        {
            Username.Text = user.UserName;
            Email.Text = user.Email;
            PhoneNumber.Text = user.PhoneNumber;
            Role.Text = user.Role;
        }

        // close the application
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        bool minMax = true;

        // minimize and maximize button
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

        // Hide and restore the application
        private void RestoreBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        // logout from the profile
        private void LogOut_Click_1(object sender, EventArgs e)
        {
            user.LogOut();
            this.Close();
            new LogIn().Show();
        }

        // Move to the view events section
        private void ViewEvents_Click_1(object sender, EventArgs e)
        {
            loadform(new PDashboard(user));

        }

        // Move to the view booking section
        private void ViewBookings_Click_1(object sender, EventArgs e)
        {
            loadform(new PEventRegistration(user));

        }

        // Move to the booking logs section
        private void BookingLogs_Click(object sender, EventArgs e)
        {
            loadform(new PBookingLogs(user));

        }

        // Move the application around the window
        private void mouse_down(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void mouse_move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }

        }

        // Updat the user profile
        private void UpdateProfile_Click(object sender, EventArgs e)
        {
            user.UpdateProfile(user, this);

        }

        // Delte the user profile
        private void DeleteProfile_Click(object sender, EventArgs e)
        {
            UserController controller = new UserController();
            (bool success, string message) = controller.RemoveUser(user.UserID);
            new LogIn().Show();
            this.Close();
        }
    }
}
