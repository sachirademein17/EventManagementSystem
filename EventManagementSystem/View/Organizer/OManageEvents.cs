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

        Organizer user = (Organizer)CurrentUser.UserDetails;


        public OManageEvents()
        {
            InitializeComponent();
            DataTable dt = user.ViewAllEvents(user.UserID);
            eventsTable.DataSource = dt;
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            AddEventForm addEventForm = new AddEventForm();
            addEventForm.Show();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            if (eventsTable.SelectedRows.Count > 0)
            {
                int rowIndex = eventsTable.SelectedRows[0].Index;
                int id = Convert.ToInt32(eventsTable.Rows[rowIndex].Cells[0].Value);
                (bool success, string message) = user.DeleteEvent(id);

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

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            

            if (eventsTable.SelectedRows.Count > 0)
            {
                int rowIndex = eventsTable.SelectedRows[0].Index;

                int eventID = Convert.ToInt32(eventsTable.Rows[rowIndex].Cells[0].Value);
                int organizerID = Convert.ToInt32(eventsTable.Rows[rowIndex].Cells[1].Value);
                string eventName = (string)eventsTable.Rows[rowIndex].Cells[2].Value;
                string description = (string)eventsTable.Rows[rowIndex].Cells[3].Value;
                DateTime startDate = (DateTime)eventsTable.Rows[rowIndex].Cells[4].Value;
                DateTime endDate = (DateTime)eventsTable.Rows[rowIndex].Cells[5].Value;
                string location = (string)eventsTable.Rows[rowIndex].Cells[6].Value;
                int maxParticipants = Convert.ToInt32(eventsTable.Rows[rowIndex].Cells[7].Value);
                int currentParticipants = Convert.ToInt32(eventsTable.Rows[rowIndex].Cells[8].Value);


                Event eventDetails = new Event(eventID, organizerID, eventName, description, startDate, endDate, location, maxParticipants, currentParticipants);
                UpdateEventForm updateEventForm = new UpdateEventForm(eventDetails);
                updateEventForm.Show();

            }
            else
            {
                new DangerToaster("Please select a row to update").Show();

            }


        }

            
    }
}
