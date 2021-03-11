using System;
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
    public partial class Photos : Form
    {
        public Photos()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void icon1_Click_1(object sender, EventArgs e)
        {
            if (panel1.Width == 89)
            {
                panel1.Width = 210;
            }
            else if (panel1.Width == 210)
            {
                panel1.Width = 89;
            }
        }

        private void label15_Click_1(object sender, EventArgs e)
        {
            Homeform hf = new Homeform();
            hf.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Picture1 p1 = new Picture1();
            p1.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Picture1 fp = new Picture1();
            fp.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Picture2 p2 = new Picture2();
            p2.Show();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            if (panel1.Width == 89)
            {
                panel1.Width = 210;
            }
            else if (panel1.Width == 210)
            {
                panel1.Width = 89;
            }
        }

        private void icon1_Click(object sender, EventArgs e)
        {
            if (panel1.Width == 89)
            {
                panel1.Width = 210;
            }
            else if (panel1.Width == 210)
            {
                panel1.Width = 89;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (panel1.Width == 89)
            {
                panel1.Width = 210;
            }
            else if (panel1.Width == 210)
            {
                panel1.Width = 89;
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homeform hf = new Homeform();
            hf.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homeform hf = new Homeform();
            hf.Show();
        }
    }
}
