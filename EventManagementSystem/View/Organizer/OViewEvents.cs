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
    public partial class OViewEvents : Form
    {
        Organizer user;
        public OViewEvents()
        {
            InitializeComponent();
            user = CurrentUser.UserDetails as Organizer;
            LoadTable();
        }

        private void LoadTable()
        {
            DataTable dt = user.ViewAllPastEvent(user.UserID);
            eventTable.DataSource = dt; 
        }
    }
}
