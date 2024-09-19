using EventManagementSystem.Models;
using EventManagementSystem.View;
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
    public partial class ODashboard : Form
    {

        User user = CurrentUser.UserDetails;
        Form dashboard;
        public ODashboard(Form dashboard)
        {
            InitializeComponent();
            LoadUserDetails();
            this.dashboard = dashboard;
        }

        private void Username_Click(object sender, EventArgs e)
        {
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            (bool success, string message) = User.DeleteProfile(user.UserID);

            if (success)
            {
                new SuccessToaster(message).Show();
                dashboard.Close();
                new Form1().Show();
                this.Close();
            }
            else
            {
                new DangerToaster(message).Show();
            }
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            new UpdateProfile().Show();
        }

        public void LoadUserDetails()
        {
            Username.Text = user.UserName;
            Role.Text = user.Role;
            Email.Text = user.Email;
            PhoneNumber.Text = user.PhoneNumber;
        }
    }
}
