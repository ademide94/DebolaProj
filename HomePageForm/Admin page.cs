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
    public partial class Admin_page : Form
    {
        public Admin_page()
        {
            InitializeComponent();
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

        private void label15_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homeform hf = new Homeform();
            hf.Show();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Administrator apf = new Administrator();         
            apf.Show();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            this.Hide();
            Administrator apf = new Administrator();
            apf.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Aloan_details_reg adrf = new Aloan_details_reg();
            adrf.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Abranch_details_reg abrf = new Abranch_details_reg();
            abrf.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Aemplye_details_form aedf = new Aemplye_details_form();
            aedf.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Acustomer_detail acdf = new Acustomer_detail();
            acdf.Show();

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Apayment_reg_form aprf = new Apayment_reg_form();
            aprf.Show();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Admin_report_fill_form arff = new Admin_report_fill_form();
            arff.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Amessanger_form amf = new Amessanger_form();
            amf.Show();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            this.Hide();
            Senior_reg_form srff = new Senior_reg_form();
            srff.Show();
        }
    }
}
