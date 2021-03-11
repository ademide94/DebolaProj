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
    public partial class View_Datails_form : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ZIGGY\\ZIGGY;Initial Catalog=heartLand_project;Persist Security Info=True;User ID=sa;Password=password1");
        DataSet ds;
        public View_Datails_form()
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

        private void label15_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homeform hf = new Homeform();
            hf.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employe_page epf = new Employe_page();
            epf.Show();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            
        }

        private void label52_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Branch", con);
            ds = new DataSet();
            sda.Fill(ds, "Branch");

            branchdataGridView6.DataSource = ds.Tables[0].DefaultView;

            con.Close();
        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmdview_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Customer", con);
            ds = new DataSet();
            sda.Fill(ds, "Customer");

            Customer_dataGridView1.DataSource = ds.Tables[0].DefaultView;

            con.Close();
        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Loan", con);
            ds = new DataSet();
            sda.Fill(ds, "Loan");

            Loan_dataGridView2.DataSource = ds.Tables[0].DefaultView;

            con.Close();
        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Employee", con);
            ds = new DataSet();
            sda.Fill(ds, "Employee");

            Employee_dataGridView4.DataSource = ds.Tables[0].DefaultView;

            con.Close();
        }

        private void panel19_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label51_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Payment", con);
            ds = new DataSet();
            sda.Fill(ds, "Payment");

            Payment_dataGridView4.DataSource = ds.Tables[0].DefaultView;

            con.Close();
        }

        private void panel24_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label53_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Messanger", con);
            ds = new DataSet();
            sda.Fill(ds, "Messanger");

            Messanger_dataGridView4.DataSource = ds.Tables[0].DefaultView;

            con.Close();
        }

        private void panel22_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Customer_dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.Customer_dataGridView1.Rows[e.RowIndex];
                textid.Text = row.Cells["CustomerID"].Value.ToString();
                textname.Text = row.Cells["Name"].Value.ToString();
                textdateTime1.Text = row.Cells["Date_of_Bath"].Value.ToString();
                textcombo1.Text = row.Cells["Marital_status"].Value.ToString();
                textadd.Text = row.Cells["_Address"].Value.ToString();
                textcombo2.Text = row.Cells["City"].Value.ToString();
                textcombo3.Text = row.Cells["_State"].Value.ToString();
                textcontact.Text = row.Cells["Contact"].Value.ToString();
                textzip.Text = row.Cells["Zip_code"].Value.ToString();

            }
        }

        private void Loan_dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.Loan_dataGridView2.Rows[e.RowIndex];
                txtno.Text = row.Cells["Loan_ref_no"].Value.ToString();
                tname.Text = row.Cells["Name"].Value.ToString();
                txtloan.Text = row.Cells["LoanType"].Value.ToString();
                taddress.Text = row.Cells["_Address"].Value.ToString();
                tdateTime1.Text = row.Cells["Application_date"].Value.ToString();
                temail.Text = row.Cells["Email_address"].Value.ToString();
                tprovider.Text = row.Cells["Guarantee_Provided"].Value.ToString();
                tincome.Text = row.Cells["Annual_income"].Value.ToString();
                tUpDown1.Text = row.Cells["Amount_of_Loan"].Value.ToString();
                tcomBox2.Text = row.Cells["Loan_program_code"].Value.ToString();

            }
        }

        private void Employee_dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.Employee_dataGridView4.Rows[e.RowIndex];
                txtid.Text = row.Cells["Emp_ID"].Value.ToString();
                txtname.Text = row.Cells["Name"].Value.ToString();
                txtdateTime1.Text = row.Cells["Date_of_birth"].Value.ToString();
                txtdateTime2.Text = row.Cells["Date_of_joint"].Value.ToString();
                txtaddress.Text = row.Cells["_Address"].Value.ToString();
                txtcomBox1.Text = row.Cells["City"].Value.ToString();
                txtcomBox2.Text = row.Cells["Emp_State"].Value.ToString();
                txtcomBox3.Text = row.Cells["Designation"].Value.ToString();
                txtcode.Text = row.Cells["Code"].Value.ToString();
                txtusername.Text = row.Cells["Username"].Value.ToString();
                txtpassword.Text = row.Cells["_Password"].Value.ToString();
                txtemail.Text = row.Cells["Email"].Value.ToString();
                txtphone.Text = row.Cells["Phone_no"].Value.ToString();

            }
        }

        private void Payment_dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.Payment_dataGridView4.Rows[e.RowIndex];
                txtref_no.Text = row.Cells["Ref_No"].Value.ToString();
                textno.Text = row.Cells["Check_Number"].Value.ToString();
                txt_check_date.Text = row.Cells["Check_Date"].Value.ToString();
                textamount.Text = row.Cells["Amount"].Value.ToString();

            }
        }

        private void branchdataGridView6_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.branchdataGridView6.Rows[e.RowIndex];
            txtbname.Text = row.Cells["BranchName"].Value.ToString();
            textBox1.Text = row.Cells["Branchcode"].Value.ToString();
            textBox2.Text = row.Cells["_Address"].Value.ToString();
            txtnumber.Text = row.Cells["Phone_no"].Value.ToString();
            txtcombo1.Text = row.Cells["_state"].Value.ToString();
            txtcombo2.Text = row.Cells["City"].Value.ToString();
            txtzipcode.Text = row.Cells["Zip_code"].Value.ToString();
        }

        private void Messanger_dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.Messanger_dataGridView4.Rows[e.RowIndex];
                txtfrom.Text = row.Cells["Message_From"].Value.ToString();
                txtreport.Text = row.Cells["_Message"].Value.ToString();


            }
        }

        private void Loan_dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
