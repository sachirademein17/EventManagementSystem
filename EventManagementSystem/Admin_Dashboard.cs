﻿using System;
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
    public partial class Admin_Dashboard : Form
    {
        public Admin_Dashboard()
        {
            InitializeComponent();
            loadform(new ADashboard());
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
            loadform(new ADashboard());
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            loadform(new AManageEvents());
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            loadform(new AManageOrganizers());
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            loadform(new AManageParticipants());
        }

        private void kryptonButton4_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
