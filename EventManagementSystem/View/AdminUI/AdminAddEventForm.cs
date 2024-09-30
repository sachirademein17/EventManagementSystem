using EventManagementSystem.Controllers;
using EventManagementSystem.CrudManagers;
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
    public partial class AdminAddEventForm : Form
    {

        Admin user;
        AdminAddEventForm addEventForm;
        EventController eventController;
        AManageEvents eventsTable;

        public AdminAddEventForm(Admin user, AManageEvents eventsTable)
        {
            InitializeComponent();
            this.user = user;
            this.eventsTable = eventsTable;
            eventController = new EventController();
        }


        // Fuctionality to create an event
        private void CreateEvent_Click_1(object sender, EventArgs e)
        {

            // Checking all the input value are valid and not empty
            (bool validation, string validationmsg) = eventController.EventTextBoxValidation(nametxt.Text, venuetxt.Text, startDatetxt.Value, endDatetxt.Value, maxParticipantstxt.Text, 0, descriptiontxt.Text);


            // If Input Details are not valid show error message & exit 
            if (!validation)
            {
                new DangerToaster(validationmsg).Show();
                return;
            }

            // Gather information from textboxes
            string eventName = nametxt.Text;
            string description = descriptiontxt.Text;
            DateTime startDate = startDatetxt.Value;
            DateTime endDate = endDatetxt.Value;
            string location = venuetxt.Text;
            int maxParticipants = int.Parse(maxParticipantstxt.Text);

            Event eventDetails = new Event(0, user.UserID, eventName, description, startDate, endDate, location, maxParticipants, 0);

            // Execute Create Event functionality
            (bool success, string message) = eventController.CreateEvent(eventDetails);

            // Show user feedback
            if (success)
            {
                new SuccessToaster(message).Show();
                eventsTable.LoadTable();
                this.Close();
            }
            else
            {
                new DangerToaster(message).Show();
            }

        }


        

        private void startDatetxt_ValueChanged_1(object sender, EventArgs e)
        {

        }

        
    }
}
