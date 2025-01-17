﻿using EventManagementSystem.Controllers;
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
using System.Windows.Forms.Design;

namespace EventManagementSystem
{
    public partial class OManageBookings : Form
    {
        Organizer user;
        BookingController bookingController;
        public OManageBookings(Organizer user)
        {
            InitializeComponent();
            this.user = user;
            bookingController = new BookingController();
            LoadBookingTable();
        }

        // Cancel Booking fuctionality Button
        private void CancelBooking_Click(object sender, EventArgs e)
        {
            // Checking whether a booking row is selected
            if (bookingsTable.SelectedRows.Count > 0)
            {
                // Excuting the CancelBooking fuctionality
                int rowIndex = bookingsTable.SelectedRows[0].Index;
                int bookingID = Convert.ToInt32(bookingsTable.Rows[rowIndex].Cells[0].Value);
                (bool success, string message) = bookingController.CancelBooking(bookingID);

                // Giving user feedback
                if (success)
                {
                    new SuccessToaster(message).Show();
                    bookingsTable.Rows.RemoveAt(rowIndex);
                    LoadBookingTable();
                }
                else
                {
                    new DangerToaster(message).Show();
                }
            }
            else
            {
                new DangerToaster("Please Select a Row To Delete").Show();

            }
        }

        // Loading BookingTable DataGridView
        private void LoadBookingTable()
        {
            DataTable dt = bookingController.ViewAllBookings(user.UserID);

            if (dt != null)
            {
                bookingsTable.DataSource = dt;
            }
            else
            {
                new DangerToaster("Cannot laod the booking table").Show();
            }
            }

        }
}
