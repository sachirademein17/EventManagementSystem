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
    public partial class APastEventLogs : Form
    {
        EventManagementSystem.Models.Admin user;
        EventController eventController;
        public APastEventLogs(EventManagementSystem.Models.Admin user)
        {
            InitializeComponent();
            this.user = user;
            eventController = new EventController();
            LoadTable();
        }


        private void LoadTable()
        {
            DataTable pastEventData = eventController.ViewPastEvents();

            if (pastEventData != null)
            {
                eventsTable.DataSource = pastEventData;
            }
            else
            {
                new DangerToaster("Unable to load the past events Table").Show();
            }
            }

            private void ViewBookings_Click_1(object sender, EventArgs e)
        {
            // Check whether a event row is selected
            if (eventsTable.SelectedRows.Count > 0)
            {
                // Executing the delete event fuction
                int rowIndex = eventsTable.SelectedRows[0].Index;
                int eventID = Convert.ToInt32(eventsTable.Rows[rowIndex].Cells[0].Value);

                new ABookingLogs(eventID).Show();
            }
            else
            {
                new DangerToaster("Please Select a Row To Delete").Show();
            }
        }

        
    }
}
