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
    public partial class Sloan_form : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=ZIGGY\ZIGGY;Initial Catalog=heartLand_project;Integrated Security=True;User ID=sa;Password=password1");
        DataSet ds;
        public Sloan_form()
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
            Seniorman_page spf = new Seniorman_page();
            spf.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void Sloan_form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'heartLand_projectDataSet.Loan' table. You can move, or remove it, as needed.
            this.loanTableAdapter.Fill(this.heartLand_projectDataSet.Loan);

        }
        DataTable dt;
        DataRow dr;
        private void cmdsubmit_Click(object sender, EventArgs e)
        {
            dt = heartLand_projectDataSet.Tables["Loan"];
            dr = dt.NewRow();
            //dr[0] = txtno.Text;
            dr[1] = tname.Text;
            dr[2] = txtloan.Text;
            dr[3] = taddress.Text;
            dr[4] = tdateTime1.Text;
            dr[5] = temail.Text;
            dr[6] = tprovider.Text;
            dr[7] = tincome.Text;
            dr[8] = tUpDown1.Text;
            dr[9] = tcomBox2.Text;
            dt.Rows.Add(dr);
            loanTableAdapter.Update(heartLand_projectDataSet);





            tname.Clear();
            taddress.Clear();
            temail.Clear();
            tprovider.Clear();
            tincome.Clear();




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
    }
}
