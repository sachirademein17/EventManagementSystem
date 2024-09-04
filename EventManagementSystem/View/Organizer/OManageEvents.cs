using EventManagementSystem.Models;
using EventManagementSystem.View;
using Google.Protobuf.WellKnownTypes;
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
        private Organizer user;


        public OManageEvents()
        {
            InitializeComponent();
            user = (Organizer)CurrentUser.UserDetails;
            LoadEventsTable();
        }

        // Create Event Button Functionality
        private void CreateEvent_Click(object sender, EventArgs e)
        {
            // Redirect to the form that create events
            AddEventForm addEventForm = new AddEventForm(this);
            addEventForm.Show();
        }

        // Delete Event Button Functionality
        private void DeleteEvent_Click(object sender, EventArgs e)
        {
            //Checking whether a row is selected 
            if (eventsTable.SelectedRows.Count > 0)
            {
                // Getting EventID from an event
                int rowIndex = eventsTable.SelectedRows[0].Index;
                int eventID = Convert.ToInt32(eventsTable.Rows[rowIndex].Cells[0].Value);

                // Executing Event Deleting Fuctionality
                (bool success, string message) = user.DeleteEvent(eventID);

                // Show message for User
                if (success)
                {
                    new SuccessToaster(message).Show();   
                    
                    // Remove the row from the DataGridView
                    eventsTable.Rows.RemoveAt(rowIndex);
                }
                else
                {
                    new DangerToaster(message).Show();
                }
            }
            else
            {
                // Show this if event row is not selected
                new DangerToaster("Please Select a Row To Delete").Show();

            }
        }

        // Update Event Button Fuctionality
        private void UpdateEvent_Click(object sender, EventArgs e)
        {

            //Checking whether a row is selected 
            if (eventsTable.SelectedRows.Count > 0)
            {
                // Getting all the details from the selected row
                int rowIndex = eventsTable.SelectedRows[0].Index;
                int eventID = Convert.ToInt32(eventsTable.Rows[rowIndex].Cells[0].Value);
                string eventName = (string)eventsTable.Rows[rowIndex].Cells[1].Value;
                string description = (string)eventsTable.Rows[rowIndex].Cells[2].Value;
                DateTime startDate = (DateTime)eventsTable.Rows[rowIndex].Cells[3].Value;
                DateTime endDate = (DateTime)eventsTable.Rows[rowIndex].Cells[4].Value;
                string location = (string)eventsTable.Rows[rowIndex].Cells[5].Value;
                int maxParticipants = Convert.ToInt32(eventsTable.Rows[rowIndex].Cells[6].Value);
                int currentParticipants = Convert.ToInt32(eventsTable.Rows[rowIndex].Cells[7].Value);
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
                    UpdateEventForm updateEventForm = new UpdateEventForm(eventDetails, this);
                    updateEventForm.Show();
                }
                              

            }
            else
            {
                new DangerToaster("Please select a row to update").Show();

            }
        }

        // Load The DataGridView
        public void LoadEventsTable()
        {
            DataTable dt = user.ViewAllEvents(user.UserID);
            eventsTable.DataSource = dt;
        }



    }
}
