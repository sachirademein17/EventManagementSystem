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
            DBConnection.Connection();
            Admin_Dashboard admin_Dashboard = new Admin_Dashboard();   
            Organizer__Dashboard organizer__Dashboard = new Organizer__Dashboard();
            Participant_Dashboard participant_Dashboard = new Participant_Dashboard();
            participant_Dashboard.Show();
            this.Hide();
        }
    }


}
