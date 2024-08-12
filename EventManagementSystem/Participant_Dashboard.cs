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
    public partial class Participant_Dashboard : Form
    {
        public Participant_Dashboard()
        {
            InitializeComponent();
            loadform(new PDashboard());
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


        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            loadform(new PDashboard());
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            loadform(new PEventRegistration());
        }
    }
}
