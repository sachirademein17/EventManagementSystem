using EventManagementSystem.Models;
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
        EventManagementSystem.Models.Admin user;
        public Admin_Dashboard()
        {
            InitializeComponent();
            user = CurrentUser.UserDetails as EventManagementSystem.Models.Admin;
            LoadUserDetails();
            loadform(new ADashboard());
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

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            loadform(new ADashboard());
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            loadform(new AManageEvents());
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            loadform(new AManageUsers());
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            loadform(new AManageParticipants());
        }

        private void kryptonButton4_Click_1(object sender, EventArgs e)
        {
            new Form1().Show();
            user.LogOut();
            this.Close();
        }

        private void kryptonButton5_Click(object sender, EventArgs e)
        {
            loadform(new PastEventLogs());
        }

        public void LoadUserDetails()
        {
            Username.Text = user.UserName;
            Role.Text = user.Role;
            Email.Text = user.Email;
            PhoneNumber.Text = user.PhoneNumber;
        }

        private void kryptonButton7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        bool minMax = true;

        private void kryptonButton6_Click(object sender, EventArgs e)
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
