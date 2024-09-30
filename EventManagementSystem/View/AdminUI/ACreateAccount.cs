using EventManagementSystem.Controllers;
using EventManagementSystem.CrudManagers;
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
    public partial class ACreateAccount : Form
    {
        Admin user;
        UserController userController;
        AManageUsers usersTable;

        public ACreateAccount(Admin user, AManageUsers usersTable)
        {
            InitializeComponent();
            this.user = user;
            userController = new UserController();
            this.usersTable = usersTable;
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


            (bool validation, string errormsg) = userController.UserTextBoxValidation(usernametxt.Text, passwordtxt.Text, confirmpasswordtxt.Text, emailtxt.Text, phonenumbertxt.Text, role);

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

            (bool success, string message) = userController.AddUser(adduser);

            // Give user feedback
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

    }
}
