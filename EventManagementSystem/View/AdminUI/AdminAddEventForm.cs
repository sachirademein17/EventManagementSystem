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

        public AdminAddEventForm()
        {
            InitializeComponent();
            user = (Admin)CurrentUser.UserDetails;
        }

        // Fuctionality to create an event
        private void CreateEvent_Click(object sender, EventArgs e)
        {

            // Gather information from textboxes
            string eventName = nametxt.Text;
            string description = descriptiontxt.Text;
            DateTime startDate = startDatetxt.Value;
            DateTime endDate = endDatetxt.Value;
            string location = venuetxt.Text;
            int maxParticipants = int.Parse(maxParticipantstxt.Text);
            int currentParticipants = int.Parse(currentParticipantstxt.Text);

            Event eventDetails = new Event(1, user.UserID, eventName, description, startDate, endDate, location, maxParticipants, currentParticipants);

            // Execute Create Event functionality
            (bool success, string message) = user.CreateEvent(eventDetails);

            // Show user feedback
            if (success)
            {
                new SuccessToaster(message).Show();
                this.Close();
            }
            else
            {
                new DangerToaster(message).Show();
            }

        }
    }
}
