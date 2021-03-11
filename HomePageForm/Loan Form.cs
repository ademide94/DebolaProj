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
    public partial class Loan_Form : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=ZIGGY\ZIGGY;Initial Catalog=heartLand_project;Integrated Security=True;User ID=sa;Password=password1");
        DataSet ds;
        public Loan_Form()
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
            Eenter_login_id_form elif = new Eenter_login_id_form();
            elif.Show();
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

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Loan_Form_Load(object sender, EventArgs e)
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




            txtno.Text = "";
            tname.Text="";
            txtloan.Text="";
            taddress.Text = "";
            tdateTime1.Text = "";
            temail.Text = "";
            tprovider.Text = "";
            tincome.Text = "";
            tUpDown1.Text = "";
            tcomBox2.Text = "";
            



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

        private void label3_Click(object sender, EventArgs e)
        {
            txtno.Text = "";
            tname.Text = "";
            txtloan.Text = "";
            taddress.Text = "";
            tdateTime1.Text = "";
            temail.Text = "";
            tprovider.Text = "";
            tincome.Text = "";
            tUpDown1.Text = "";
            tcomBox2.Text = "";
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
