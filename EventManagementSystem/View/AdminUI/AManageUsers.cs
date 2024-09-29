using EventManagementSystem.Controllers;
using EventManagementSystem.Models;
using EventManagementSystem.View;
using EventManagementSystem.View.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace EventManagementSystem
{
    public partial class AManageUsers : Form
    {
        Admin user;
        UserController userController;

        public AManageUsers(Admin user)
        {
            InitializeComponent();
            this.user = user;
            userController = new UserController();
            LoadTable();
        }

        // Redirect to the Create Account form
        private void CreateUser_Click(object sender, EventArgs e)
        {
            new ACreateAccount(user, this).ShowDialog();
        }

        // Perform the Delete User functionality
        private void DeleteUser_Click(object sender, EventArgs e)
        {
            // Check whether a user row is selected
            if (usersTable.SelectedRows.Count > 0)
            {
                // Execute the Remove User fuctionality
                int rowIndex = usersTable.SelectedRows[0].Index;
                int id = Convert.ToInt32(usersTable.Rows[rowIndex].Cells[0].Value);
                (bool success, string message) = userController.RemoveUser(id);

                // Give user feedback
                if (success)
                {
                    new SuccessToaster(message).Show();
                    usersTable.Rows.RemoveAt(rowIndex);
                }
                else
                {
                    new DangerToaster(message).Show();
                }
            }
            else
            {

                new DangerToaster("Please Select a Row To Delete");

            }
        }
        
        // Perform the Update User functionality
        private void UpdateUser_Click(object sender, EventArgs e)
        {
            // Check whether a user is selected
            if (usersTable.SelectedRows.Count > 0)
            {
                // Get all the details of that user
                int rowIndex = usersTable.SelectedRows[0].Index;
                int id = Convert.ToInt32(usersTable.Rows[rowIndex].Cells[0].Value);
                string username = (string)usersTable.Rows[rowIndex].Cells[1].Value;
                string password = (string)usersTable.Rows[rowIndex].Cells[2].Value;
                string role = (string)usersTable.Rows[rowIndex].Cells[3].Value;
                string email = (string)usersTable.Rows[rowIndex].Cells[4].Value;
                string phoneNumber = (string)usersTable.Rows[rowIndex].Cells[5].Value;

                Admin userDetails = new Admin(id, username, password, email, phoneNumber, role);

                // Redirect to the Update Account form
                new AUpdateAccount(userDetails, user, this).ShowDialog();

            }
            else
            {

                new DangerToaster("Please Select a Row To Delete");

            }


        }

        // Load the DataGridView
        public void LoadTable()
        {
            DataTable dt = userController.ViewAllUsers();
            usersTable.DataSource = dt;
        }

    }
}
