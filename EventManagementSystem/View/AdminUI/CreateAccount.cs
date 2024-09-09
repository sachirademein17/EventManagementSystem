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
    public partial class CreateAccount : Form
    {
        Admin user;

        public CreateAccount()
        {
            InitializeComponent();
            user = (Admin)CurrentUser.UserDetails;
        }

        private void CreateUser_Click(object sender, EventArgs e)
        {

            // Get the role value
            string role;
            if (participantrole.Checked)
            {
                role = participantrole.Text;
            }
            else
            {
                role = organizerrole.Text;
            }


            (bool validation, string errormsg) = user.UserTextBoxValidation(usernametxt.Text, passwordtxt.Text, confirmpasswordtxt.Text, emailtxt.Text, phonenumbertxt.Text, role);

            // Check textboxes are properly entered by user
            if (!validation)
            {
                new DangerToaster(errormsg).Show();
                return;
            }

            // Get all the user details
            string username = usernametxt.Text;
            string password = passwordtxt.Text;
            string email = emailtxt.Text;
            string phoneNumber = phonenumbertxt.Text;

            User adduser = new Admin(1, username, password, email, phoneNumber, role);

            (bool success, string message) = user.AddUser(adduser);

            // Give user feedback
            if (success)
            {
                new SuccessToaster(message).Show();
            }
            else
            {
                new DangerToaster(message).Show();
            }


        }

    }
}
