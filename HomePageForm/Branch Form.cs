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
    public partial class Branch_Form : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=ZIGGY\ZIGGY;Initial Catalog=heartLand_project;Integrated Security=True;User ID=sa;Password=password1");
        DataSet ds;
        public Branch_Form()
        {
            InitializeComponent();
        }

        private void icon1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void icon1_Click_1(object sender, EventArgs e)
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

        private void pictureBox2_Click_1(object sender, EventArgs e)
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
            Employe_page epf = new Employe_page();
            epf.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        DataTable dt;
        DataRow dr;
        private void label8_Click(object sender, EventArgs e)
        {
            dt = heartLand_projectDataSet1.Tables["branch"];
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

        private void label8_MouseHover(object sender, EventArgs e)
        {
    
        }

        private void Branch_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'heartLand_projectDataSet1.Branch' table. You can move, or remove it, as needed.
            this.branchTableAdapter.Fill(this.heartLand_projectDataSet1.Branch);
          

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
