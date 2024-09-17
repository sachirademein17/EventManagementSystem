using EventManagementSystem.Controllers;
using EventManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventManagementSystem.View.AdminUI
{
    public partial class PastEventLogs : Form
    {
        EventManagementSystem.Models.Admin user;
        EventController eventController;
        public PastEventLogs()
        {
            InitializeComponent();
            user = CurrentUser.UserDetails as EventManagementSystem.Models.Admin;
            eventController = new EventController();
            LoadTable();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadTable()
        {
            DataTable pastEventData = eventController.ViewPastEvents();
            eventsTable.DataSource = pastEventData;
        }

        private void CreateUser_Click(object sender, EventArgs e)
        {

            if (eventsTable.SelectedRows.Count > 0)
            {
                int rowIndex = eventsTable.SelectedRows[0].Index;
                int eventID = Convert.ToInt32(eventsTable.Rows[rowIndex].Cells[0].Value);
                new AViewParticipants(eventID).ShowDialog();
            }
        }
    }
}
