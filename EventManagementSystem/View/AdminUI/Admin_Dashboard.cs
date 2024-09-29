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


        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            loadform(new AManageEvents(user));
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            loadform(new AManageUsers(user));
        }

        private void kryptonButton5_Click(object sender, EventArgs e)
        {
            loadform(new APastEventLogs(user));
        }

        private void LoadUserDetail(Admin user)
        {
            Username.Text = user.UserName;
            Email.Text = user.Email;
            PhoneNumber.Text = user.PhoneNumber;
            Role.Text = user.Role;
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            (bool success, string message) = user.LogOut();
            new LogIn().Show();
            this.Close();
            new SuccessToaster(message);
        }

        private void UpdateProfile_Click(object sender, EventArgs e)
        {
            user.UpdateProfile(user, this);
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        bool minMax = true;



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

        private void RestoreBtn_Click_1(object sender, EventArgs e)
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
    }
}
