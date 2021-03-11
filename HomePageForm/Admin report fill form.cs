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
    public partial class Admin_report_fill_form : Form
    {
        string connstring = "Data Source=ZIGGY\\ZIGGY;Initial Catalog=heartLand_project;Persist Security Info=True;User ID=sa;Password=password1";
        int id;
        SqlConnection con = new SqlConnection("Data Source=ZIGGY\\ZIGGY;Initial Catalog=heartLand_project;Persist Security Info=True;User ID=sa;Password=password1");
        DataSet ds;
        public Admin_report_fill_form()
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

        private void label15_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homeform hf = new Homeform();
            hf.Show();
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

        private void label46_Click(object sender, EventArgs e)
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

        private void Messanger_dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                DataGridViewRow row = this.Messanger_dataGridView4.Rows[e.RowIndex];
                comboBox1.Text = row.Cells["Message_To"].Value.ToString();
                txtfrom.Text = row.Cells["Message_From"].Value.ToString();
                txtreport.Text = row.Cells["_Message"].Value.ToString();


            }
        }
        SqlCommand com;
        SqlDataReader dreader;
        DataTable dt;
        DataRow dr;
        private void cmdelete_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(connstring);
            con.Open();
            com = new SqlCommand("delete from Messanger where Message_To = " + comboBox1.Text + " ", con);
            try
            {

                comboBox1.Text = ("");
                txtfrom.Text = ("");
                txtreport.Text = ("");
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

        private void panel23_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
