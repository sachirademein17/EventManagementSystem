using EventManagementSystem.Models;
using EventManagementSystem.View;
using System.Diagnostics;
using System.Drawing.Text;

namespace EventManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            string username = usernametxt.Text;
            string password = passwordtxt.Text;


            User user = User.LogIn(username, password);
            /*            CurrentUser.UserDetails = user;
            */
            new CurrentUser(user);

            if (user != null)
            {
                new SuccessToaster("Logging Success").Show();

                if (user.Role == "Admin")
                {
                    Admin_Dashboard admin_Dashboard = new Admin_Dashboard();
                    admin_Dashboard.Show();
                    this.Hide();
                }
                else if (user.Role == "Organizer")
                {
                    Organizer__Dashboard organizer__Dashboard = new Organizer__Dashboard();
                    organizer__Dashboard.Show();
                    this.Hide();
                }
                else if (user.Role == "Participant")
                {
                    Participant_Dashboard participant_Dashboard = new Participant_Dashboard();
                    participant_Dashboard.Show();
                    this.Hide();
                }
            }
            else
            {
                new DangerToaster("Logging Unsuccess").Show();
            }
        }

        private void kryptonLinkLabel1_LinkClicked_1(object sender, EventArgs e)
        {
            new AddNewUser().Show();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                passwordtxt.PasswordChar = '\0';
            }
            else
            {
                passwordtxt.PasswordChar = '•';
            }

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}