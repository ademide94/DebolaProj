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
using System.Data.SqlClient;

namespace HomePageForm
{
    public partial class Aloan_details_reg : Form
    {
        string connstring = "Data Source=ZIGGY\\ZIGGY;Initial Catalog=heartLand_project;Persist Security Info=True;User ID=sa;Password=password1";
        int id;
        SqlConnection con = new SqlConnection("Data Source=ZIGGY\\ZIGGY;Initial Catalog=heartLand_project;Persist Security Info=True;User ID=sa;Password=password1");
        DataSet ds;
        public Aloan_details_reg()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_page apf = new Admin_page();
            apf.Show();
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

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

            this.Hide();
            Admin_page apf = new Admin_page();
            apf.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Loan", con);
            ds = new DataSet();
            sda.Fill(ds, "Loan");

            Loan_dataGridView1.DataSource = ds.Tables[0].DefaultView;

            con.Close();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Loan_dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.Loan_dataGridView1.Rows[e.RowIndex];
               textno.Text = row.Cells["Loan_ref_no"].Value.ToString();
                 textname.Text = row.Cells["Name"].Value.ToString();
                comboBox1.Text = row.Cells["LoanType"].Value.ToString();
                textadd.Text = row.Cells["_Address"].Value.ToString();
                dateTime1.Text = row.Cells["Application_date"].Value.ToString();
                texteadd.Text = row.Cells["Email_address"].Value.ToString();
                textguarantee.Text = row.Cells["Guarantee_Provided"].Value.ToString();
                textincom.Text = row.Cells["Annual_income"].Value.ToString();
                textloan.Text = row.Cells["Amount_of_Loan"].Value.ToString();
                textcode.Text = row.Cells["Loan_program_code"].Value.ToString();

            }
        }
        SqlCommand com;
        SqlDataReader dreader;
        DataTable dt;
        DataRow dr;
        private void label13_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(connstring);
            con.Open();
            com = new SqlCommand("delete from Loan where Loan_ref_no = " + textno.Text + " ", con);
            try
            {
                textno.Text = ("");
                textname.Text = ("");            
                comboBox1.Text = ("");
                textadd.Text = ("");
                dateTime1.Text = ("");
                texteadd.Text = ("");
                textguarantee.Text = ("");
                textincom.Text = ("");
                textloan.Text = ("");
                textcode.Text = ("");
                com.ExecuteNonQuery();
                MessageBox.Show("Deleted...");



            }
            catch (Exception x)
            {
                MessageBox.Show(" Not Deleted" + x.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {
            con.Open();
            string queary = "UPDATE Loan SET Name  = '" + textname.Text + "', LoanType = '" + comboBox1 + "',_Address = '" + textadd + "',Application_date = '" + dateTime1 + "',Email_address ='" + texteadd + "',Guarantee_Provided = '" + textguarantee + "',Annual_income = '" + textincom + "',Amount_of_Loan = '" + textloan + "',Loan_program_code = '" + textcode + "'";
            com = new SqlCommand(queary, con);

            int j = com.ExecuteNonQuery();
             if (j > 0)
             {
                 MessageBox.Show("Record updated Successfully");
             }
             con.Close();
        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
