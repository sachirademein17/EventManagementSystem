using EventManagementSystem.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventManagementSystem.View.AdminUI
{
    public partial class AViewParticipants : Form
    {
        int eventID;
        EventController eventController;
        public AViewParticipants(int eventID)
        {
            InitializeComponent();
            this.eventID = eventID;
            eventController = new EventController();
            LoadTable();
        }

        private void AViewParticipants_Load(object sender, EventArgs e)
        {

        }


        private void LoadTable()
        {
            DataTable dataTable = eventController.ViewAllRegisteredParticipants(eventID);
            kryptonDataGridView1.DataSource = dataTable;
        }
    }
}
