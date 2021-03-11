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
    public partial class Senior_reg_form : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=ZIGGY\ZIGGY;Initial Catalog=heartLand_project;Integrated Security=True;User ID=sa;Password=password1");
        DataSet ds;
        public Senior_reg_form()
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
            Admin_page apf = new Admin_page();
            apf.Show();
        }

        private void Senior_reg_form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'heartLand_projectDataSet1.SeniorManagement' table. You can move, or remove it, as needed.
            this.seniorManagementTableAdapter.Fill(this.heartLand_projectDataSet1.SeniorManagement);


        }
        DataTable dt;
        DataRow dr;
        private void cmdsend_Click(object sender, EventArgs e)
        {
            dt = heartLand_projectDataSet1.Tables["SeniorManagement"];
            dr = dt.NewRow();
            //dr[0] = image
            //dr[1] = txtid.Text;
            dr[2] = txtfirstname.Text;
            dr[3] = txtlastname.Text;
            dr[4] = txtdateTime2.Text;
            dr[5] = txtaddress.Text;
            dr[6] = txtcomBox1.Text;
            dr[7] = txtcomBox2.Text;
            dr[8] = txtcomBox3.Text;
            dr[9] = txtcode.Text;
            dr[10] = txtusername.Text;
            dr[11] = txtpassword.Text;
            dr[12] = txtemail.Text;
            dr[13] = txtphone.Text;
            dt.Rows.Add(dr);
            seniorManagementTableAdapter.Update(heartLand_projectDataSet1);





            txtfirstname.Clear();
            txtlastname.Clear();
            txtaddress.Clear();
            txtcode.Clear();
            txtusername.Clear();
            txtpassword.Clear();
            txtemail.Clear();
            txtphone.Clear();




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

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmdclear_Click(object sender, EventArgs e)
        {
            //dr[0] = image
            //txtid.Text="";
            txtfirstname.Text = "";
            txtlastname.Text = "";
            txtdateTime2.Text = "";
            txtaddress.Text = "";
            txtcomBox1.Text = "";
            txtcomBox2.Text = "";
            txtcomBox3.Text = "";
            txtcode.Text = "";
            txtusername.Text = "";
            txtpassword.Text = "";
            txtemail.Text = "";
            txtphone.Text = "";
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
