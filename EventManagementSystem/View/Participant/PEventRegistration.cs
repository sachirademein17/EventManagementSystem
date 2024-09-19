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
using System.Windows.Forms.Design;

namespace EventManagementSystem
{
    public partial class PEventRegistration : Form
    {
        Participant user;
        BookingController bookingController;
        public PEventRegistration()
        {
            InitializeComponent();
            user = (Participant)CurrentUser.UserDetails;
            bookingController = new BookingController();
            // Load the table
            LoadTable();
        }

        // Button performing the Cancel Booking function
        private void CancelBooking_Click(object sender, EventArgs e)
        {
            // Checking whether a row is selected
            if (RegisteredEvent.SelectedRows.Count > 0)
            {
                // Executing the cancel booking fuction
                int rowIndex = RegisteredEvent.SelectedRows[0].Index;
                int bookingID = Convert.ToInt32(RegisteredEvent.Rows[rowIndex].Cells[0].Value);
                (bool success, string message) = bookingController.CancelBooking(bookingID);

                // Giving user feedback 
                if (success)
                {
                    new SuccessToaster(message).Show();
                    RegisteredEvent.Rows.RemoveAt(rowIndex);
                }
                else
                {
                    new DangerToaster(message).Show();
                }
            }
            else
            {
                new DangerToaster("Please select an event to cancel").Show();
            }

        }

        // Load the Table
        private void LoadTable()
        {
            DataTable dataTable = bookingController.GetRegisteredEvents(user.UserID);

            if (dataTable == null) {
                new DangerToaster("Database or Query Issue").Show();
            }

            RegisteredEvent.DataSource = dataTable;
        }
    }
}
