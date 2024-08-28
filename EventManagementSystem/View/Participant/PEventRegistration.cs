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
using System.Windows.Forms.Design;

namespace EventManagementSystem
{
    public partial class PEventRegistration : Form
    {
        Participant user = (Participant)CurrentUser.UserDetails;
        public PEventRegistration()
        {
            InitializeComponent();
            DataTable dt = user.GetRegisteredEvents(user.UserID);
            RegisteredEvent.DataSource = dt;
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {

            if (RegisteredEvent.SelectedRows.Count > 0)
            {
                int rowIndex = RegisteredEvent.SelectedRows[0].Index;
                int id = Convert.ToInt32(RegisteredEvent.Rows[rowIndex].Cells[0].Value);
                bool success = user.CancelBooking(id, user.UserID);

                if (success)
                {
                    MessageBox.Show("The Event was successfully removed !!!");
                    RegisteredEvent.Rows.RemoveAt(rowIndex);
                }
                else
                {
                    MessageBox.Show("Please select a row to delete !!!");
                }
            }

        }
    }
}
