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
        public AddEventForm()
        {
            InitializeComponent();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            Organizer user = (Organizer)CurrentUser.UserDetails;


            (bool validation, string validationmsg) = user.TextBoxValidation(nametxt.Text, venuetxt.Text, startDatetxt.Value, endDatetxt.Value, maxParticipantstxt.Text, descriptiontxt.Text);

            if (!validation)
            {
                new DangerToaster(validationmsg).Show();
                return;
            }

            string eventName = nametxt.Text;
            string description = descriptiontxt.Text;
            DateTime startDate = startDatetxt.Value;
            DateTime endDate = endDatetxt.Value;
            string location = venuetxt.Text;
            int maxParticipants = int.Parse(maxParticipantstxt.Text);



            Event eventDetails = new Event(1, user.UserID, eventName, description, startDate, endDate, location, maxParticipants, 0);

            (bool success,string message) = user.CreateEvent(eventDetails);

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

        private void currentParticipantstxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
