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
    public partial class Acustomer_detail : Form
    {
        string connstring = "Data Source=ZIGGY\\ZIGGY;Initial Catalog=heartLand_project;Persist Security Info=True;User ID=sa;Password=password1";
        int id;

        SqlConnection con = new SqlConnection("Data Source=ZIGGY\\ZIGGY;Initial Catalog=heartLand_project;Persist Security Info=True;User ID=sa;Password=password1");
        DataSet ds;
        public Acustomer_detail()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_page apf = new Admin_page();
            apf.Show();
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

        private void label4_Click(object sender, EventArgs e)
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

        private void Customer_dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                DataGridViewRow row = this.Customer_dataGridView1.Rows[e.RowIndex];
                textid.Text = row.Cells["CustomerID"].Value.ToString();
                txtname.Text = row.Cells["Name"].Value.ToString();
                txtdatebirth.Text = row.Cells["Date_of_Bath"].Value.ToString();
                textcombo1.Text = row.Cells["Marital_status"].Value.ToString();
                textadd.Text = row.Cells["_Address"].Value.ToString();
                textcombo2.Text = row.Cells["City"].Value.ToString();
                textcombo3.Text = row.Cells["_State"].Value.ToString();
                textcontact.Text = row.Cells["Contact"].Value.ToString();
                textzip.Text = row.Cells["Zip_code"].Value.ToString();

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
            com = new SqlCommand("delete from Customer where CustomerID = " + textid.Text + " ", con);
            try
            {

                textid.Text = ("");
                txtname.Text = ("");
                txtdatebirth.Text = ("");
                textcombo1.Text = ("");
                textadd.Text = ("");
                textcombo2.Text = ("");
                textcombo3.Text = ("");
                textcontact.Text = ("");
                textzip.Text = ("");
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
            con = new SqlConnection(connstring);
            con.Open();
            com = new SqlCommand("update Customer set Name='"+txtname.Text+"',Date_of_Bath ="+txtdatebirth.Text+",Marital_status ='"+textcombo1.Text+"',_Address="+textadd.Text+",City ='"+textcombo2.Text+"',_State="+textcombo3.Text+",Contact='"+textcontact.Text+"',Zip_code ="+textzip.Text+"", con);   
            try
            {
                com.ExecuteNonQuery();
                MessageBox.Show("Updated..");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
