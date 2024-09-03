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
        Admin user = (Admin)CurrentUser.UserDetails;
        public AManageUsers()
        {
            InitializeComponent();
            DataTable dt = user.ViewAllUsers();
            usersTable.DataSource = dt;
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            new CreateAccount().Show();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            if (usersTable.SelectedRows.Count > 0)
            {
                int rowIndex = usersTable.SelectedRows[0].Index;
                int id = Convert.ToInt32(usersTable.Rows[rowIndex].Cells[0].Value);
                (bool success, string message) = user.RemoveUser(id);

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

        private void kryptonButton3_Click(object sender, EventArgs e)
        {

            if (usersTable.SelectedRows.Count > 0)
            {
                int rowIndex = usersTable.SelectedRows[0].Index;
                int id = Convert.ToInt32(usersTable.Rows[rowIndex].Cells[0].Value);
                string username = (string)usersTable.Rows[rowIndex].Cells[1].Value;
                string password = (string)usersTable.Rows[rowIndex].Cells[2].Value;
                string role = (string)usersTable.Rows[rowIndex].Cells[3].Value;
                string email = (string)usersTable.Rows[rowIndex].Cells[4].Value;
                string phoneNumber = (string)usersTable.Rows[rowIndex].Cells[5].Value;

                Admin userDetails = new Admin(id, username, password, email, phoneNumber, role);

                new UpdateAccount(userDetails).Show();

            }
            else
            {

                new DangerToaster("Please Select a Row To Delete");

            }


        }
    }
}
