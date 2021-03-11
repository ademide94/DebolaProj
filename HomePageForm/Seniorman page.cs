using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HomePageForm
{
    public partial class Seniorman_page : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ZIGGY\\ZIGGY;Initial Catalog=heartLand_project;Persist Security Info=True;User ID=sa;Password=password1");
        public Seniorman_page()
        {
            InitializeComponent();
        }

        private void icon1_Click(object sender, EventArgs e)
        {
            if (panel3.Width == 89)
            {
                panel3.Width = 210;
            }
            else if (panel3.Width == 210)
            {
                panel3.Width = 89;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (panel3.Width == 89)
            {
                panel3.Width = 210;
            }
            else if (panel3.Width == 210)
            {
                panel3.Width = 89;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Senior_Management sf = new Senior_Management();
            sf.Show();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homeform hf = new Homeform();
            hf.Show();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            this.Hide();
            Senior_Management smf = new Senior_Management();
            smf.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Semploye_Form sef = new Semploye_Form();
            sef.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sbranch_form sbf = new Sbranch_form();
            sbf.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sloanprogram_from slpf = new Sloanprogram_from();
            slpf.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

            this.Hide();
            Sview_Form svf = new Sview_Form();
            svf.Show();

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Senter_login_id_form self = new Senter_login_id_form();
            self.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
           
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sreport_form srf = new Sreport_form();
            srf.Show();
        }

        private void pictureBox9_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
