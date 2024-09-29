using EventManagementSystem.Controllers;
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
    public partial class PDashboard : Form
    {
        Participant user;
        BookingController bookingController;

        public PDashboard(Participant user)
        {
            InitializeComponent();
            this.user = user;
            bookingController = new BookingController();
            // Load the table
            LoadTable();
        }

        // Button that performs the booking functionality
        private void BookingEvent_Click(object sender, EventArgs e)
        {
            // Checking whether a row is selected
            if (eventsTable.SelectedRows.Count > 0)
            {
                // Getting the eventID from the DataGridView
                int rowIndex = eventsTable.SelectedRows[0].Index;
                int eventID = Convert.ToInt32(eventsTable.Rows[rowIndex].Cells[0].Value);

                // Perform thebook event fuctionality
                (bool success, string message) = bookingController.BookEvent(eventID, user.UserID);


                // Give user feedback
                if (success)
                {
                    new SuccessToaster(message).Show();
                }
                else
                {
                    new DangerToaster(message).Show();
                }


            }
            else
            {
                new DangerToaster("Please select an event !!!").Show();
            }

        }

        // Load table
        private void LoadTable()
        {
            DataTable dt = bookingController.ViewAllAvailableEvents();
            if (dt == null)
            {
                new DangerToaster("Can't Load the events").Show();
            }
            eventsTable.DataSource = dt;
        }

        private void PDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
