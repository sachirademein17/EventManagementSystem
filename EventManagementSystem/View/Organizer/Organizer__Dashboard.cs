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
    public partial class Organizer__Dashboard : Form
    {
        public Organizer__Dashboard()
        {
            InitializeComponent();
            loadform(new ODashboard());
        }

        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
            {
                this.mainpanel.Controls.RemoveAt(0);
            }
            Form form = Form as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(form);
            this.mainpanel.Tag = form;
            form.Show();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            loadform(new OViewEvents());
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            loadform(new ODashboard());
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            loadform(new OManageEvents());
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            loadform(new OViewParticipants());
        }

        private void kryptonButton5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
