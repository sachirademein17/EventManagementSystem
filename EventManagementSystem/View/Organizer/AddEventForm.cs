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
    public partial class AddEventForm : Form
    {

        // Creating a Organizer Object for the Current User ( To Get Current User Details )
        Organizer user;
        OManageEvents manageEvents;
        EventController eventController;

        public AddEventForm(OManageEvents manageEvents, Organizer user)
        {
            InitializeComponent();

            // Defining the Current User Object
            this.user = user;

            eventController = new EventController();

            // Defining the OManageEvents Object ( To load the DataGridView )
            this.manageEvents = manageEvents;


            // Setting Date & Time in the DateTimePickers
            InitializeDateTime();

            // Making the the start & the end time change 
            this.startDatetxt.ValueChanged += new System.EventHandler(this.startDatetxt_ValueChanged);


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

        private void kryptonButton1_Click(object sender, EventArgs e)
        {


            // Checking all the input value are valid and not empty
            (bool validation, string validationmsg) = eventController.EventTextBoxValidation(nametxt.Text, venuetxt.Text, startDatetxt.Value, endDatetxt.Value, maxParticipantstxt.Text,0, descriptiontxt.Text);


            // If Input Details are not valid show error message & exit 
            if (!validation)
            {
                new DangerToaster(validationmsg).Show();
                return;
            }


            // After all the validation get the input values to variables
            string eventName = nametxt.Text;
            string description = descriptiontxt.Text;
            DateTime startDate = startDatetxt.Value;
            DateTime endDate = endDatetxt.Value;
            string location = venuetxt.Text;
            int maxParticipants = int.Parse(maxParticipantstxt.Text);


            // Creating a Event object using the input values
            /* The First & the Last fields are 0
              First field UserID is set to auto increment in SQL
              Last field Current Participant No is starting from 0 
             */
            Event eventDetails = new Event(0, user.UserID, eventName, description, startDate, endDate, location, maxParticipants, 0);


            // Creating the event
            (bool success, string message) = eventController.CreateEvent(eventDetails);


            // According to the process show the output
            if (success)
            {
                new SuccessToaster(message).Show();

                // Load the datagrid view after the Event is created
                manageEvents.LoadEventsTable();
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

        private void startDatetxt_ValueChanged_1(object sender, EventArgs e)
        {

        }
    }
}
