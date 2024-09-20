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

namespace EventManagementSystem
{
    public partial class OViewEvents : Form
    {
        EventController eventController;
        public OViewEvents()
        {
            InitializeComponent();
            eventController = new EventController();
            LoadTable();
        }

        // Load the past event table
        private void LoadTable()
        {
            DataTable datatable = eventController.ViewPastEvents(CurrentUser.UserDetails.UserID);
            eventsTable.DataSource = datatable; 
        }
    }
}
