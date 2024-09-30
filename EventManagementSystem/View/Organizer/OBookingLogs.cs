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
        Organizer user;
        public OBookingLogs(Organizer user)
        {
            InitializeComponent();
            this.dashboard = dashboard;
            this.user = user;
            bookingController = new BookingController();
            LoadTable();
        }

        private void LoadTable()
        {
            DataTable dt = bookingController.ViewAllBookingLog(user.UserID);

            if (dt != null)
            {
                eventsTable.DataSource = dt;

            }
            else
            {
                new DangerToaster("Cannot load all bookings ").Show();
            }
            }

        }
}
