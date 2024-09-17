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
    public partial class ODashboard : Form
    {

        User user = CurrentUser.UserDetails;
        Form dashboard;
        BookingController bookingController;
        public ODashboard(Form dashboard)
        {
            InitializeComponent();
            bookingController = new BookingController();
            this.dashboard = dashboard;
            LoadTable();
        }

        private void Username_Click(object sender, EventArgs e)
        {
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            (bool success, string message) = user.DeleteProfile(user.UserID);

            if (success)
            {
                new SuccessToaster(message).Show();
                dashboard.Close();
                new Form1().Show();
                this.Close();
            }
            else
            {
                new DangerToaster(message).Show();
            }
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
        }

        public void LoadTable()
        {
            DataTable table = bookingController.ViewAllPastBookings(user.UserID);
            kryptonDataGridView1.DataSource = table;
        }

        private void UpdateEvent_Click(object sender, EventArgs e)
        {

        }
    }
}
