using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EventManagementSystem.Controllers;
using EventManagementSystem.Models;
using EventManagementSystem.View;
using Microsoft.VisualBasic.ApplicationServices;

namespace EventManagementSystem
{
    public partial class UpdateEventForm : Form
    {

        int eventID;
        Organizer user;
        OManageEvents manageEvents;
        Event eventDetails;
        EventController eventController;

        public UpdateEventForm(Event eventDetails, OManageEvents manageEvents)
        {
            InitializeComponent();

            // Set previous event details into the input fields
            SetEventDetails(eventDetails);
            eventID = eventDetails.EventID;
            user = (Organizer)CurrentUser.UserDetails;
            eventController = new EventController();
            this.eventDetails = eventDetails;
            this.manageEvents = manageEvents;

            // Defining the minimum time that can be placed inside a DateTimePicker
            InitializeDateTime();

        }

        

        private void InitializeDateTime()
        {
            // Set the minimum date for the DateTimePickers
            startDatetxt.MinDate = DateTime.Now.AddHours(1);
            endDatetxt.MinDate = startDatetxt.Value.AddHours(1);
        }


            private void UpdateEvent_Click(object sender, EventArgs e)
        {

            // Checking if the start time is at least 4 hours before the event's start time
            DateTime currentTime = DateTime.Now;
            DateTime startTime = startDatetxt.Value;
            DateTime endTime = endDatetxt.Value;


            // Checking if the start time is within 4 hours
            if (this.eventDetails.EndDate.AddHours(4) < currentTime)
            {
                new DangerToaster("The start time must be at least 4 hours from now.").Show();
                return;
            }


            // Checking textbox are entered properly
            (bool validation, string validationmsg) = eventController.EventTextBoxValidation(nametxt.Text, venuetxt.Text, startDatetxt.Value, endDatetxt.Value, maxParticipantstxt.Text, this.eventDetails.CurrentParticipants, descriptiontxt.Text);

            // Giving user feedback if not entered properly
            if (!validation)
            {
                new DangerToaster(validationmsg).Show();
                return;
            }

            // Getting all the values from text boxes
            string name = nametxt.Text;
            string location = venuetxt.Text;
            //DateTime startTime = startDatetxt.Value;
            //DateTime endTime = endDatetxt.Value;
            int maxParticipants = int.Parse(maxParticipantstxt.Text);
            string description = descriptiontxt.Text;


            // The last row ( Current Participants ) is set to 0 but not used anywhere when update. Used just to create the Event Object
            // Executing the Update Event fuction
            Event eventDetails = new Event(eventID, user.UserID, name, description, startTime, endTime, location, maxParticipants, 0);
            (bool success, string message )= eventController.UpdateEvent(eventDetails);

            // giving user feedback
            if (success)
            {
                new SuccessToaster(message).Show();
                manageEvents.LoadEventsTable();
                this.Close();
            }
            else
            {
                new DangerToaster(message).Show();
            }
            
        }

        // Setting all the text fields with the previous details
        private void SetEventDetails(Event eventDetails)
        {
            eventID = eventDetails.EventID;
            nametxt.Text = eventDetails.EventName;
            venuetxt.Text= eventDetails.Location;
            startDatetxt.Value = eventDetails.StartDate;
            endDatetxt.Value = eventDetails.EndDate;
            maxParticipantstxt.Text = (eventDetails.MaxParticipants).ToString();
            descriptiontxt.Text =(eventDetails.Description).ToString();
        }


    }
}
