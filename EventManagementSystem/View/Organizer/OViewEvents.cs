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
    public partial class OViewEvents : Form
    {
        EventController eventController;
        Organizer user;
        public OViewEvents(Organizer user)
        {
            InitializeComponent();
            this.user = user;
            eventController = new EventController();
            LoadTable();
        }

        // Load the past event table
        private void LoadTable()
        {
            DataTable datatable = eventController.ViewPastEvents(user.UserID);

            if (datatable != null)
            {
                eventsTable.DataSource = datatable;
            }
            else
            {
                new DangerToaster("Cannot load past events").Show();
            }

            }
        }
}
