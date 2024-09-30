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

namespace EventManagementSystem.View.Admin
{
    public partial class AUpdateAccount : Form
    {
        User userDetails;
        EventManagementSystem.Models.Admin user;
        UserController userController;
        AManageUsers usersTable;

        public AUpdateAccount(User userDetails, EventManagementSystem.Models.Admin user, AManageUsers usersTable)
        {
            InitializeComponent();
            this.user = user;
            this.userDetails = userDetails;
            this.usersTable = usersTable;
            userController = new UserController();
            SetUserDetails(userDetails);
        }

        // Perform the Update User functionality
        private void UpdateUser_Click_1(object sender, EventArgs e)
        {
            // Getting the role value
            string role;
            if (participantrole.Checked)
            {
                role = participantrole.Text;
            }
            else
            {
                role = organizerrole.Text;
            }


            (bool validation, string errormsg) = userController.UserTextBoxValidation(usernametxt.Text, passwordtxt.Text, confirmpasswordtxt.Text, emailtxt.Text, phonenumbertxt.Text, role);

            // Checking whether the validation is success
            if (!validation)
            {
                new DangerToaster(errormsg).Show();
                return;
            }

            // Get all the user inputs from textboxes
            string username = usernametxt.Text;
            string password = passwordtxt.Text;
            string confirmPassword = confirmpasswordtxt.Text;
            string email = emailtxt.Text;
            string phoneNumber = phonenumbertxt.Text;

            User updateUser = new Organizer(userDetails.UserID, username, password, email, phoneNumber, role);

            // Execute the Update User functionality
            (bool success, string message) = userController.UpdateUser(updateUser, userDetails.UserName);

            // give user feedback
            if (success)
            {
                new SuccessToaster(message).Show();
                usersTable.LoadTable();
                this.Close();
            }
            else
            {
                new DangerToaster(message).Show();
            }

        }

        // Set Input fields according to the previous user details
        private void SetUserDetails(User userDetails)
        {
            usernametxt.Text = userDetails.UserName;
            emailtxt.Text = userDetails.Email;
            phonenumbertxt.Text = userDetails.PhoneNumber;
            passwordtxt.Text = userDetails.PasswordHash;


            if (userDetails.Role == "Participant")
            {
                participantrole.Checked = true;
            }
            else
            {
                organizerrole.Checked = true;
            }
        }

       
    }
}
