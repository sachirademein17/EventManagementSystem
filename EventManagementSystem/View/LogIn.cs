using EventManagementSystem.Controllers;
using EventManagementSystem.Models;
using EventManagementSystem.View;
using System.Diagnostics;
using System.Drawing.Text;

namespace EventManagementSystem
{
    public partial class LogIn : Form
    {
        UserController userController;
        public Point mouseLocation;
        public LogIn()
        {
            InitializeComponent();
            userController = new UserController();
        }



        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            string username = usernametxt.Text;
            string password = passwordtxt.Text;


            User user = userController.LogIn(username, password);


            if (user != null)
            {
                new SuccessToaster("Logging Success").Show();

                if (user.Role == "Admin")
                {
                    Admin_Dashboard admin_Dashboard = new Admin_Dashboard(user);
                    admin_Dashboard.Show();
                    this.Hide();
                }
                else if (user.Role == "Organizer")
                {
                    Organizer_Dashboard organizer__Dashboard = new Organizer_Dashboard(user);
                    organizer__Dashboard.Show();
                    this.Hide();
                }
                else if (user.Role == "Participant")
                {
                    Participant_Dashboard participant_Dashboard = new Participant_Dashboard(user);
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

        private void mouse_down(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);

        }

        private void mouse_move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }

        }
    }
}