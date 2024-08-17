using System.Diagnostics;
using System.Drawing.Text;

namespace EventManagementSystem
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
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
            string validation = DBConnection.Authentication(username, password);

            if (validation != "issue")
            {
                if (validation == "Organizer")
                {
                    Organizer__Dashboard organizer__Dashboard = new Organizer__Dashboard();
                    organizer__Dashboard.Show();
                    this.Hide();
                }else if (validation == "Admin")
                {
                    Admin_Dashboard admin_Dashboard = new Admin_Dashboard();
                    admin_Dashboard.Show();
                    this.Hide();
                }
                else
                {
                    Participant_Dashboard participant_Dashboard = new Participant_Dashboard();
                    participant_Dashboard.Show();
                    this.Hide();
                }
                
                    
            }
        }



        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}