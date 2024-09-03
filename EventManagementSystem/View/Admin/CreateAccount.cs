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
        Admin user = (Admin)CurrentUser.UserDetails;

        public CreateAccount()
        {
            InitializeComponent();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {

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

            User adduser = new Organizer(1, username, password, email, phoneNumber, role);

            (bool success, string message) = user.AddUser(adduser);

            if (success)
            {
                new SuccessToaster(message).Show();
            }
            else
            {
                new DangerToaster(message).Show();
            }


        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void organizerrole_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
