﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomePageForm
{
    public partial class Picture1 : Form
    {
        public Picture1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            Photos pf = new Photos();
            pf.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Photos pf = new Photos();
            pf.Show();
        }
    }
}
