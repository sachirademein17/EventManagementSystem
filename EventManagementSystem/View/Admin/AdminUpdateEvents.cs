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

        int eventID;

        public AdminUpdateEvents(Event eventDetails)
        {
            InitializeComponent();
            eventID = eventDetails.EventID;
            SetEventDetails(eventDetails);
        }


        private void kryptonButton1_Click(object sender, EventArgs e)
        {

            string name = nametxt.Text;
            string location = venuetxt.Text;
            DateTime startTime = startDatetxt.Value;
            DateTime endTime = endDatetxt.Value;
            int maxParticipants = int.Parse(maxParticipantstxt.Text);
            int currentParticipants = int.Parse(currentParticipantstxt.Text);
            string description = descriptiontxt.Text;

            Admin user = (Admin)CurrentUser.UserDetails;


            Event eventDetails = new Event(eventID, user.UserID, name, description, startTime, endTime, location, maxParticipants, currentParticipants);
            
            (bool success, string message )= user.UpdateEvent(eventDetails);

            if (success)
            {
                new SuccessToaster(message).Show();
            }
            else
            {
                new DangerToaster(message).Show();
            }


        }

        private void SetEventDetails(Event eventDetails)
        {
            eventID = eventDetails.EventID;
            nametxt.Text = eventDetails.EventName;
            venuetxt.Text = eventDetails.Location;
            startDatetxt.Value = eventDetails.StartDate;
            endDatetxt.Value = eventDetails.EndDate;
            maxParticipantstxt.Text = (eventDetails.MaxParticipants).ToString();
            currentParticipantstxt.Text = (eventDetails.CurrentParticipants).ToString();
            descriptiontxt.Text = (eventDetails.Description).ToString();
        }

    }
}
