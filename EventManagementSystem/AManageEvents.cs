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

namespace EventManagementSystem
{
    public partial class AManageEvents : Form
    {
        Admin user = (Admin)CurrentUser.UserDetails;

        public AManageEvents()
        {
            InitializeComponent();
            DataTable dt = user.ViewAllEvents();
            eventsTable.DataSource = dt;
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            AdminAddEventForm adminAddEventForm = new AdminAddEventForm();
            adminAddEventForm.Show();

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {

            if (eventsTable.SelectedRows.Count > 0)
            {
                int rowIndex = eventsTable.SelectedRows[0].Index;
                int id = Convert.ToInt32(eventsTable.Rows[rowIndex].Cells[0].Value);
                bool success = user.DeleteEvent(id);

                if (success)
                {
                    MessageBox.Show("The Event was successfully removed !!!");
                    eventsTable.Rows.RemoveAt(rowIndex);
                }
                else
                {
                    MessageBox.Show("Please select a row to delete !!!");
                }
            }

        }
    }
}
