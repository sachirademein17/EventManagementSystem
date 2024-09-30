using EventManagementSystem.Controllers;
using EventManagementSystem.Models;
using EventManagementSystem.View;
using EventManagementSystem.View.AdminUI;
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
    public partial class Admin_Dashboard : Form
    {

        Admin user;
        public Point mouseLocation;

        public Admin_Dashboard(User user)
        {
            InitializeComponent();
            this.user = user as Admin;
            LoadUserDetail(this.user);
            loadform(new AManageEvents(this.user));
        }


        // Dock the windows from into the application as a section
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

        // Move to the manage events section
        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            loadform(new AManageEvents(user));
        }

        // Move to the manage users section
        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            loadform(new AManageUsers(user));
        }

        // Move to the past event logs section
        private void kryptonButton5_Click(object sender, EventArgs e)
        {
            loadform(new APastEventLogs(user));
        }

        // Load the user details on the log
        private void LoadUserDetail(Admin user)
        {
            Username.Text = user.UserName;
            Email.Text = user.Email;
            PhoneNumber.Text = user.PhoneNumber;
            Role.Text = user.Role;
        }

        // Logout from the account
        private void LogOut_Click(object sender, EventArgs e)
        {
            (bool success, string message) = user.LogOut();
            new LogIn().Show();
            this.Close();
            new SuccessToaster(message);
        }

        // Update the profile
        private void UpdateProfile_Click(object sender, EventArgs e)
        {
            user.UpdateProfile(user, this);
        }

        // Close the application
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        bool minMax = true;


        // Minimize and maximize application
        private void MinmaxBtn_Click_1(object sender, EventArgs e)
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
        private void RestoreBtn_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        //Move the window fuctionality

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

        // Delete user profile
        private void DeleteProfile_Click(object sender, EventArgs e)
        {
            UserController controller = new UserController();
            (bool success, string message) = controller.RemoveUser(user.UserID);
            new LogIn().Show();
            this.Close();
        }
    }
}
