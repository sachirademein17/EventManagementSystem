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
    public partial class AdminUpdateEvents : Form
    {

        Event eventDetails;
        Admin user;
        EventController eventController;

        public AdminUpdateEvents(Event eventDetails)
        {
            InitializeComponent();
            this.eventDetails = eventDetails;
            SetEventDetails(eventDetails);
            user = (Admin)CurrentUser.UserDetails;
            eventController = new EventController();    
        }

        // Update Event fuctionality
        private void UpdateEvemt_Click(object sender, EventArgs e)
        {

            // Get the values from the textboxes
            string name = nametxt.Text;
            string location = venuetxt.Text;
            DateTime startTime = startDatetxt.Value;
            DateTime endTime = endDatetxt.Value;
            int maxParticipants = int.Parse(maxParticipantstxt.Text);
            int currentParticipants = this.eventDetails.CurrentParticipants;
            string description = descriptiontxt.Text;



            Event eventDetails = new Event(this.eventDetails.EventID, user.UserID, name, description, startTime, endTime, location, maxParticipants, currentParticipants);
            
            // Executing the update event functionality
            (bool success, string message )= eventController.UpdateEvent(eventDetails);

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


        // Set all the textfields with the previous details
        private void SetEventDetails(Event eventDetails)
        {
            nametxt.Text = eventDetails.EventName;
            venuetxt.Text = eventDetails.Location;
            startDatetxt.Value = eventDetails.StartDate;
            endDatetxt.Value = eventDetails.EndDate;
            maxParticipantstxt.Text = (eventDetails.MaxParticipants).ToString();
            descriptiontxt.Text = (eventDetails.Description).ToString();
        }

    }
}
