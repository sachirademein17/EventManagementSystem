using EventManagementSystem.Controllers;
using EventManagementSystem.Database;
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


        private void InitializeDateTime()
        {
            // Setting the start time 2 hours from now
            DateTime initialStartTime = DateTime.Now.AddHours(2);
            startDatetxt.Value = initialStartTime;
            endDatetxt.Value = initialStartTime.AddHours(1);

            // Set the minimum date for the DateTimePickers
            startDatetxt.MinDate = DateTime.Now.AddHours(1);
            endDatetxt.MinDate = startDatetxt.Value.AddHours(1);
        }


        // Fuctionality to create an event
        private void CreateEvent_Click(object sender, EventArgs e)
        {

            // Checking all the input value are valid and not empty
            (bool validation, string validationmsg) = eventController.EventTextBoxValidation(nametxt.Text, venuetxt.Text, startDatetxt.Value, endDatetxt.Value, maxParticipantstxt.Text,0, descriptiontxt.Text);


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


        // Change the end date & time according to the start date & time
        private void startDatetxt_ValueChanged(object sender, EventArgs e)
        {
            endDatetxt.Value = startDatetxt.Value.AddHours(1);
        }

        private void nametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void startDatetxt_ValueChanged_1(object sender, EventArgs e)
        {

        }
    }
}
