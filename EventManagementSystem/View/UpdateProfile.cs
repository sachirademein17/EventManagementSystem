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

namespace EventManagementSystem.View
{
    public partial class UpdateProfile : Form
    {
        User user;
        UserController UserController;
        Form dashboard;
        public UpdateProfile(User user, Form dashboard)
        {
            InitializeComponent();
            this.user = user;
            this.dashboard = dashboard;
            UserController = new UserController();
            SetUserDetails(user);
        }

        private void UpdateUser_Click(object sender, EventArgs e)
        {
            // Getting the role value
            string role = user.Role;

            (bool validation, string errormsg) = UserController.UserTextBoxValidation(usernametxt.Text, passwordtxt.Text, confirmpasswordtxt.Text, emailtxt.Text, phonenumbertxt.Text, role);

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

            User updateUser = new Organizer(user.UserID, username, password, email, phoneNumber, role);

            // Execute the Update User functionality
            (bool success, string message) = UserController.UpdateUser(updateUser, user.UserName);

            // give user feedback
            if (success)
            {
                new SuccessToaster(message).Show();
                dashboard.Close();
                new LogIn().Show(); 
                this.Close();   
            }
            else
            {
                new DangerToaster(message).Show();
            }
        }

        // Set Input fields according to the previous user details
        private void SetUserDetails(User user)
        {
            usernametxt.Text = user.UserName;
            emailtxt.Text = user.Email;
            phonenumbertxt.Text = user.PhoneNumber;
            passwordtxt.Text = user.PasswordHash;
        }
    }
}
