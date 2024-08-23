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
            DataTable dt = user.ViewAllEvents();
            PViewEvents.DataSource = dt;
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
