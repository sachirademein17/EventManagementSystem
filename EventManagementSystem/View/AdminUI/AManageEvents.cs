using EventManagementSystem.Controllers;
using EventManagementSystem.Models;
using EventManagementSystem.View;
using EventManagementSystem.View.AdminUI;
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
    public partial class AManageEvents : Form
    {
        Admin user;
        EventController eventController;

        public AManageEvents()
        {
            InitializeComponent();
            user = (Admin)CurrentUser.UserDetails;
            eventController = new EventController();
            LoadTable();
        }

        // Create event functionality
        private void CreateEvent_Click(object sender, EventArgs e)
        {
            // Redirects to the add event form
            AdminAddEventForm adminAddEventForm = new AdminAddEventForm();
            adminAddEventForm.Show();

        }

        // Delete event functionality
        private void DeleteEvent_Click(object sender, EventArgs e)
        {
            // Check whether a event row is selected
            if (eventsTable.SelectedRows.Count > 0)
            {
                // Executing the delete event fuction
                int rowIndex = eventsTable.SelectedRows[0].Index;
                int eventID = Convert.ToInt32(eventsTable.Rows[rowIndex].Cells[0].Value);
                (bool success, string message) = eventController.DeleteEvent(eventID);

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

        // Update event functionality
        private void UpdateEvent_Click(object sender, EventArgs e)
        {
            //Checking whether a row is selected 
            if (eventsTable.SelectedRows.Count > 0)
            {
                // Getting all the details from the selected row
                int rowIndex = eventsTable.SelectedRows[0].Index;
                int eventID = Convert.ToInt32(eventsTable.Rows[rowIndex].Cells[0].Value);
                string eventName = (string)eventsTable.Rows[rowIndex].Cells[1].Value;
                string description = (string)eventsTable.Rows[rowIndex].Cells[3].Value;
                DateTime startDate = (DateTime)eventsTable.Rows[rowIndex].Cells[4].Value;
                DateTime endDate = (DateTime)eventsTable.Rows[rowIndex].Cells[5].Value;
                string location = (string)eventsTable.Rows[rowIndex].Cells[6].Value;
                int maxParticipants = Convert.ToInt32(eventsTable.Rows[rowIndex].Cells[7].Value);
                int currentParticipants = Convert.ToInt32(eventsTable.Rows[rowIndex].Cells[8].Value);
                int organizerID = user.UserID;

                // Creating an Event Object
                Event eventDetails = new Event(eventID, organizerID, eventName, description, startDate, endDate, location, maxParticipants, currentParticipants);

                // Check if the event starts over 4 hours from now. if no can't update event
                if (eventDetails.StartDate.AddHours(4) < DateTime.Now)
                {
                    new DangerToaster("Too Late to Update the Event").Show();
                }
                else
                {
                    AdminUpdateEvents updateEventForm = new AdminUpdateEvents(eventDetails);
                    updateEventForm.Show();
                }


            }
            else
            {
                new DangerToaster("Please select a row to update").Show();

            }

        }

        private void LoadTable()
        {
            DataTable dt = eventController.ViewUpcomingEvents();
            eventsTable.DataSource = dt;
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
