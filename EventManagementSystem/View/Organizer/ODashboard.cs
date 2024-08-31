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

        public ODashboard()
        {
            InitializeComponent();
            Username.Text = user.UserName;
            Role.Text = user.Role;
            Email.Text = user.Email;
            PhoneNumber.Text = user.PhoneNumber;
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
            }
            else
            {
                new DangerToaster(message).Show();
            }
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            new ChangePassword().Show();
        }
    }
}
