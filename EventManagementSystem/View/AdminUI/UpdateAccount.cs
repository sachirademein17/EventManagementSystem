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
    public partial class UpdateAccount : Form
    {
        User userDetails;
        EventManagementSystem.Models.Admin user;
        public UpdateAccount(User userDetails)
        {
            InitializeComponent();
            user = (EventManagementSystem.Models.Admin)CurrentUser.UserDetails;
            this.userDetails = userDetails ;
            SetUserDetails(userDetails);
        }

        // Perform the Update User functionality
        private void UpdateUser_Click(object sender, EventArgs e)
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


            (bool validation, string errormsg) = user.UserTextBoxValidation(usernametxt.Text, passwordtxt.Text, confirmpasswordtxt.Text, emailtxt.Text, phonenumbertxt.Text, role);

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
            (bool success, string message) = user.UpdateUser(updateUser,userDetails.UserName);

            // give user feedback
            if (success)
            {
                new SuccessToaster(message).Show();
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
