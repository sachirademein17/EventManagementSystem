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
        public UpdateAccount(User userDetails)
        {
            InitializeComponent();
            this.userDetails = userDetails ;
            SetUserDetails(userDetails);
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            EventManagementSystem.Models.Admin user = (EventManagementSystem.Models.Admin)CurrentUser.UserDetails;

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

            if (!validation)
            {
                new DangerToaster(errormsg).Show();
                return;
            }

            string username = usernametxt.Text;
            string password = passwordtxt.Text;
            string confirmPassword = confirmpasswordtxt.Text;
            string email = emailtxt.Text;
            string phoneNumber = phonenumbertxt.Text;

            User updateUser = new Organizer(userDetails.UserID, username, password, email, phoneNumber, role);

            (bool success, string message) = user.UpdateUser(updateUser,userDetails.UserName);

            if (success)
            {
                new SuccessToaster(message).Show();
            }
            else
            {
                new DangerToaster(message).Show();
            }

        }

        private void SetUserDetails(User userDetails)
        {
            usernametxt.Text = userDetails.UserName;
            emailtxt.Text = userDetails.Email;
            phonenumbertxt.Text = userDetails.PhoneNumber;

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
