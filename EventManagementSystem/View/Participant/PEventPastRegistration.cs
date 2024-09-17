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


    public partial class PEventPastRegistration : Form
    {

        BookingController bookingController;
        EventManagementSystem.Models.Participant user;

        public PEventPastRegistration()
        {
            InitializeComponent();
            bookingController = new BookingController();
            user = CurrentUser.UserDetails as EventManagementSystem.Models.Participant;
            LoadTable();
        }

        // Load the Table
        private void LoadTable()
        {
            DataTable dataTable = bookingController.RegisteredPastEvents(user.UserID);

            if (dataTable == null)
            {
                new DangerToaster("Database or Query Issue").Show();
            }

            RegisteredEvent.DataSource = dataTable;
        }


    }
}
