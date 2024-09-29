using EventManagementSystem.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventManagementSystem.View.AdminUI
{
    public partial class ABookingLogs : Form
    {
        BookingController bookingController;
        public ABookingLogs(int eventID)
        {
            InitializeComponent();
            bookingController = new BookingController();
            LoadTable(eventID);
        }


        private void LoadTable(int eventID)
        {
            DataTable dt = bookingController.RegisteredParticipants(eventID);
            eventsTable.DataSource = dt;
        }


    }
}
