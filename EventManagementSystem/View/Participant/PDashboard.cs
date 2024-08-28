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
    public partial class PDashboard : Form
    {
        Participant user = (Participant)CurrentUser.UserDetails;

        public PDashboard()
        {
            InitializeComponent();
/*            user = CurrentUser.UserDetails as Participant;
*/            DataTable dt = user.ViewAllEvents();
            kryptonDataGridView1.DataSource = dt;
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {

            if (kryptonDataGridView1.SelectedRows.Count > 0)
            {
                int rowIndex = kryptonDataGridView1.SelectedRows[0].Index;

                int eventID = Convert.ToInt32(kryptonDataGridView1.Rows[rowIndex].Cells[0].Value);

                MessageBox.Show(user.UserID.ToString());

                bool success = user.BookEvent(eventID,user.UserID);

                if (success)
                {
                    MessageBox.Show("You are registered successfully  to the event !!!");
                }
                else
                {
                    MessageBox.Show("There seems to be an issue !!!");
                }


            }
            else
            {
                MessageBox.Show("Please select an event !!!");
            }

        }
    }
}
