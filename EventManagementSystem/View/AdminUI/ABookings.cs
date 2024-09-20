using EventManagementSystem.Controllers;
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
    public partial class ABookings : Form
    {
        BookingController bookingController;
        public ABookings(int eventID)
        {
            InitializeComponent();
            bookingController = new BookingController();
            LoadTable(eventID);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CancelBooking_Click(object sender, EventArgs e)
        {
            // Check whether a event row is selected
            if (eventsTable.SelectedRows.Count > 0)
            {
                // Executing the delete event fuction
                int rowIndex = eventsTable.SelectedRows[0].Index;
                int eventID = Convert.ToInt32(eventsTable.Rows[rowIndex].Cells[0].Value);
                (bool success, string message) = bookingController.CancelBooking(eventID);

                // Give user feedback
                if (success)
                {
                    new SuccessToaster(message).Show();
                    eventsTable.Rows.RemoveAt(rowIndex);
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

        private void LoadTable(int eventID)
        {
            DataTable dt = bookingController.RegisteredParticipants(eventID);
            eventsTable.DataSource = dt;
        }
    }
}
