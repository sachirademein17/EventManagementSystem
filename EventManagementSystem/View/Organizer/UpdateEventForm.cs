using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EventManagementSystem.Models;
using EventManagementSystem.View;
using Microsoft.VisualBasic.ApplicationServices;

namespace EventManagementSystem
{
    public partial class UpdateEventForm : Form
    {

        public UpdateEventForm(Event eventDetails)
        {
            InitializeComponent();
            SetEventDetails(eventDetails);
            eventID = eventDetails.EventID;
        }

        int eventID;

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            Organizer user = (Organizer)CurrentUser.UserDetails;


            (bool validation, string validationmsg) = user.TextBoxValidation(nametxt.Text, venuetxt.Text, startDatetxt.Value, endDatetxt.Value, maxParticipantstxt.Text, descriptiontxt.Text);

            if (!validation)
            {
                new DangerToaster(validationmsg).Show();
                return;
            }

            string name = nametxt.Text;
            string location = venuetxt.Text;
            DateTime startTime = startDatetxt.Value;
            DateTime endTime = endDatetxt.Value;
            int maxParticipants = int.Parse(maxParticipantstxt.Text);
            string description = descriptiontxt.Text;



            Event eventDetails = new Event(eventID, user.UserID, name, description, startTime, endTime, location, maxParticipants, 0);
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
            venuetxt.Text= eventDetails.Location;
            startDatetxt.Value = eventDetails.StartDate;
            endDatetxt.Value = eventDetails.EndDate;
            maxParticipantstxt.Text = (eventDetails.MaxParticipants).ToString();
            descriptiontxt.Text =(eventDetails.Description).ToString();
        }


    }
}
