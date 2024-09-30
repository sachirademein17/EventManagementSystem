using EventManagementSystem.Controllers;
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
    public partial class Organizer_Dashboard : Form
    {
        Organizer user;
        public Point mouseLocation;

        public Organizer_Dashboard(User user)
        {
            InitializeComponent();
            this.user = user as Organizer;
            loadform(new OBookingLogs(this.user));
            LoadUserDetail();
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



        // LogOut fuctionality
        private void LogOut_Click(object sender, EventArgs e)
        {
            LogIn form1 = new LogIn();
            form1.Show();
            this.user.LogOut();
            this.Close();
        }


        private void LoadUserDetail()
        {
            Username.Text = user.UserName;
            Email.Text = user.Email;
            PhoneNumber.Text = user.PhoneNumber;
            Role.Text = user.Role;
        }

        private void BookingLogs_Click(object sender, EventArgs e)
        {

        }

        private void EventLogs_Click(object sender, EventArgs e)
        {
        }

        private void ManageEvents_Click(object sender, EventArgs e)
        {
        }

        private void ManageBookings_Click(object sender, EventArgs e)
        {
        }

        private void BookingLogs_Click_1(object sender, EventArgs e)
        {
            loadform(new OBookingLogs(user));
        }

        private void EventLogs_Click_1(object sender, EventArgs e)
        {
            loadform(new OViewEvents(user));
        }

        private void ManageEvents_Click_1(object sender, EventArgs e)
        {
            loadform(new OManageEvents(user));
        }

        private void ManageBookings_Click_1(object sender, EventArgs e)
        {
            loadform(new OManageBookings(user));
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

        private void UpdateProfile_Click(object sender, EventArgs e)
        {
            user.UpdateProfile(user, this);

        }

        private void DeleteProfile_Click(object sender, EventArgs e)
        {
            UserController controller = new UserController();
            (bool success, string message) = controller.RemoveUser(user.UserID);
            new LogIn().Show();
            this.Close();
        }
    }
}
