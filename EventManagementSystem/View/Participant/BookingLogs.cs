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
    public partial class BookingLogs : Form
    {
        BookingController bookingController;
        public BookingLogs()
        {
            InitializeComponent();
            bookingController = new BookingController();
            LoadTable();
        }

        public void LoadTable()
        {
            DataTable dt = bookingController.GetRegisteredEventLogs(CurrentUser.UserDetails.UserID);
            kryptonDataGridView1.DataSource = dt;
        }
    }
}
