using EventManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventManagementSystem.View
{
    public partial class AddNewUser : Form
    {

        EventManagementSystem.Models.Admin user; 

        public AddNewUser()
        {
            InitializeComponent();
            user = new EventManagementSystem.Models.Admin(1,"Admin","Admin","Admin","11","Admin");
        }

        private void CreateUser_Click(object sender, EventArgs e)
        {
            new SuccessToaster("\r\n    this.Controls.Add(myLabel);\r\n    this.AutoSize = true;  // Form resizes based on the label content\r\n    this.AutoSizeMode = AutoSizeMode.GrowAndShrink; // Allow shrinking as well").Show();
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
               // new DangerToaster(errormsg).Show();
                return;
            }

            // Get all the user details
            string username = usernametxt.Text;
            string password = passwordtxt.Text;
            string email = emailtxt.Text;
            string phoneNumber = phonenumbertxt.Text;

            User adduser = new EventManagementSystem.Models.Admin(1, username, password, email, phoneNumber, role);

            (bool success, string message) = user.AddUser(adduser);

            // Give user feedback
            if (success)
            {
                new SuccessToaster(message).Show();
                this.Close();
            }
            else
            {
                new DangerToaster(message).Show();
            }

        }
    }
}
