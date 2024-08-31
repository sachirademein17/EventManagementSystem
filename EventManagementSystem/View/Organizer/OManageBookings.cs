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
        Organizer user = (Organizer)CurrentUser.UserDetails;

        public OManageBookings()
        {
            InitializeComponent();

            DataTable dt = user.ViewAllBookings(user.UserID);
            bookingsTable.DataSource = dt;
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            if (bookingsTable.SelectedRows.Count > 0)
            {
                int rowIndex = bookingsTable.SelectedRows[0].Index;
                int id = Convert.ToInt32(bookingsTable.Rows[rowIndex].Cells[0].Value);
                (bool success, string message) = user.DeleteBooking(id);

                if (success)
                {
                    new SuccessToaster(message).Show();
                    bookingsTable.Rows.RemoveAt(rowIndex);
                }
                else
                {
                    new DangerToaster(message).Show();
                }
            }
            else
            {
                new DangerToaster("Please Select a Row To Delete");

            }
        }
    }
}
