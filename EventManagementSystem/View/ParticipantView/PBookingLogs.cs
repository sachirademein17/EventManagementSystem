using EventManagementSystem.Controllers;
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

namespace EventManagementSystem.View.Participant
{
    public partial class PBookingLogs : Form
    {
        BookingController bookingController;
        EventManagementSystem.Models.Participant user;
        public PBookingLogs(EventManagementSystem.Models.Participant user)
        {
            InitializeComponent();
            this.user = user;   
            bookingController = new BookingController();
            LoadTable();
        }

        public void LoadTable()
        {
            DataTable dt = bookingController.GetRegisteredEventLogs(user.UserID);

            if (dt != null)
            {
                eventsTable.DataSource = dt;
            }
            else
            {
                new DangerToaster("Cannot load Registered Event Logs").Show();
            }
            }
        }
}
