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
    public partial class Sbranch_form : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=ZIGGY\ZIGGY;Initial Catalog=heartLand_project;Integrated Security=True;User ID=sa;Password=password1");
        DataSet ds;
        public Sbranch_form()
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Seniorman_page sp = new Seniorman_page();
            sp.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homeform hf = new Homeform();
            hf.Show();
        }

        private void Sbranch_form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'heartLand_projectDataSet1.Branch' table. You can move, or remove it, as needed.
            this.branchTableAdapter.Fill(this.heartLand_projectDataSet1.Branch);


        }
        DataTable dt;
        DataRow dr;
        private void label8_Click(object sender, EventArgs e)
        {
            dt = heartLand_projectDataSet1.Tables["Branch"];
            dr = dt.NewRow();
            dr[0] = txtbname.Text;
            //dr[1] = txtcode.Text;
            dr[2] = txtaddress.Text;
            dr[3] = txtnumber.Text;
            dr[4] = txtcombo1.Text;
            dr[5] = txtcombo2.Text;
            dr[6] = txtzipcode.Text;
            dt.Rows.Add(dr);
            branchTableAdapter.Update(heartLand_projectDataSet1);



            txtbname.Clear();
            txtcode.Clear();
            txtaddress.Clear();
            txtnumber.Clear();

            txtzipcode.Clear();




            //conn = new SqlConnection(connstring);
            //conn.Open();
            //comm = new SqlCommand("insert into employee values(" + txtCode.Text + ",'" + txtName.Text + "'," + txtAddress.Text + ",'" + txtState.Text + "'," + txtCountry.Text + ")", conn);
            try
            {

                MessageBox.Show("Saved...");
            }
            catch (Exception)
            {
                MessageBox.Show("Not Saved");
            }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            txtbname.Text = "";
            //txtcode.Text = "";
            txtaddress.Text = "";
            txtaddress.Text = "";
            txtnumber.Text = "";
            txtcombo1.Text = "";
            txtcombo2.Text = "";
            txtzipcode.Text = "";
        }
    }
}
