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
    public partial class OBookingLogs : Form
    {

        BookingController bookingController;
        Form dashboard;
        public OBookingLogs()
        {
            InitializeComponent();
            this.dashboard = dashboard;
            bookingController = new BookingController();
            LoadTable();
        }

        private void LoadTable()
        {
            DataTable dt = bookingController.ViewAllBookingLog(CurrentUser.UserDetails.UserID);
            eventsTable.DataSource = dt;
        }

    }
}
