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

namespace EventManagementSystem.View
{
    public partial class ChangePassword : Form
    {

        User user = CurrentUser.UserDetails;

        public ChangePassword()
        {
            InitializeComponent();
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {

            string username = usernametxt.Text;
            string password = passwordtxt.Text;
            string newPassword = newpasswordtxt.Text;
            string confirmNewPassword = confirmnewpasswordtxt.Text;


            if (usernametxt.Text.Equals(user.UserName) && passwordtxt.Text.Equals(user.PasswordHash))
            {
                if (newpasswordtxt.Text.Equals(confirmnewpasswordtxt.Text))
                {
                    (bool success, string message) = User.ChangePassword(user.PasswordHash, user.UserID);

                    if (success)
                    {
                        new SuccessToaster(message).Show();
                    }
                    else
                    {
                        new DangerToaster(message).Show();
                    }
                }
                else
                {
                    new DangerToaster("Please Confirm Password").Show();
                }

            }
            else
            {
                new DangerToaster("Incorret Username Password").Show();
            }
        }
    }
}
