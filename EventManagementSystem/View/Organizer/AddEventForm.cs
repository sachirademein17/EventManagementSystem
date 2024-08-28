using EventManagementSystem.Models;
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

            string eventName = nametxt.Text;
            string description = descriptiontxt.Text;
            DateTime startDate = startDatetxt.Value;
            DateTime endDate = endDatetxt.Value;
            string location = venuetxt.Text;
            int maxParticipants = int.Parse(maxParticipantstxt.Text);
            int currentParticipants = int.Parse(currentParticipantstxt.Text);

            Event eventDetails = new Event(1, user.UserID, eventName, description, startDate, endDate, location, maxParticipants, currentParticipants);

            bool success = user.CreateEvent(eventDetails);

            if (success)
            {
                MessageBox.Show("Event Created !!!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Event Not Created !!!");
            }




        }

        private void currentParticipantstxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
