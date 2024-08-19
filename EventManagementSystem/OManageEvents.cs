using EventManagementSystem.Models;
using MySql.Data.MySqlClient;
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
    public partial class OManageEvents : Form
    {
        public OManageEvents()
        {
            InitializeComponent();
            Organizer user = (Organizer)CurrentUser.UserDetails;
            DataTable dt = user.ViewAllEvents(user.UserID);
            eventsTable.DataSource = dt;
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            AddEventForm addEventForm = new AddEventForm();
            addEventForm.Show();
        }
    }
}
