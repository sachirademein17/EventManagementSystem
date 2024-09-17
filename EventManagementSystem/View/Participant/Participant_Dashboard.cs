using EventManagementSystem.Models;
using EventManagementSystem.View.Participant;
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

        Participant user;
        public Participant_Dashboard()
        {
            InitializeComponent();
            user = CurrentUser.UserDetails as Participant;
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


        private void Dashboard_Click(object sender, EventArgs e)
        {
            loadform(new PDashboard());
        }

        private void EventRegistration_Click(object sender, EventArgs e)
        {
            loadform(new PEventRegistration());
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            user.LogOut();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        bool minMax = true;

        private void kryptonButton1_Click(object sender, EventArgs e)
        {



            if (minMax)
            {
                this.WindowState = FormWindowState.Maximized;
                minMax = false;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                minMax = true;
            }

        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            loadform(new PEventPastRegistration());
        }
    }
}
