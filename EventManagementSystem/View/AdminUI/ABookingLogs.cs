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

        // fuctionality to load the datagrid of Booking Logs
        private void LoadTable(int eventID)
        {
            DataTable dt = bookingController.RegisteredParticipants(eventID);

            // checking whether the dataTable is null and validating it
            if (dt != null)
            {
                eventsTable.DataSource = dt;
            }
            else
            {
                new DangerToaster("Unable to load the Booking Logs");
            }


        }
    }
}