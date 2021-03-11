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
    public partial class Abranch_details_reg : Form
    {
        string connstring = "Data Source=ZIGGY\\ZIGGY;Initial Catalog=heartLand_project;Persist Security Info=True;User ID=sa;Password=password1";
        int id;
        SqlConnection con = new SqlConnection("Data Source=ZIGGY\\ZIGGY;Initial Catalog=heartLand_project;Persist Security Info=True;User ID=sa;Password=password1");
        DataSet ds;
        public Abranch_details_reg()
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
            Admin_page apf = new Admin_page();
            apf.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            Homeform hf = new Homeform();
            hf.Show();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Branch", con);
            ds = new DataSet();
            sda.Fill(ds, "Branch");

            branchdataGridView1.DataSource = ds.Tables[0].DefaultView;

            con.Close();
        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void branchdataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                DataGridViewRow row = this.branchdataGridView1.Rows[e.RowIndex];
                txtbname.Text = row.Cells["BranchName"].Value.ToString();
                txtcode.Text = row.Cells["Branchcode"].Value.ToString();
                txtaddress.Text = row.Cells["_Address"].Value.ToString();
                txtnumber.Text = row.Cells["Phone_no"].Value.ToString();
                txtcombo1.Text = row.Cells["_state"].Value.ToString();
                txtcombo2.Text = row.Cells["City"].Value.ToString();
                txtzipcode.Text = row.Cells["Zip_code"].Value.ToString();

            }
        }
        SqlCommand com;
        SqlDataReader dreader;
        DataTable dt;
        DataRow dr;
        private void cmddelete_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(connstring);
            con.Open();
            com = new SqlCommand("delete from Branch where Branchcode = " + txtcode.Text + " ", con);
            try
            {

                txtbname.Text = ("");
                txtcode.Text = ("");
                txtaddress.Text = ("");
                txtnumber.Text = ("");
                txtcombo1.Text = ("");
                txtcombo2.Text = ("");
                txtzipcode.Text = ("");
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

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
