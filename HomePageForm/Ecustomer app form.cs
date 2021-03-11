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
    public partial class Ecustomer_view_Form : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=ZIGGY\ZIGGY;Initial Catalog=heartLand_project;Integrated Security=True;User ID=sa;Password=password1");
        DataSet ds;
        public Ecustomer_view_Form()
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employe_page epf = new Employe_page();
            epf.Show();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homeform hf = new Homeform();
            hf.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Ecustomer_view_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'heartLand_projectDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.heartLand_projectDataSet.Customer);

        }
        DataTable dt;
        DataRow dr;
        private void cmdsubmit_Click(object sender, EventArgs e)
        {
            dt = heartLand_projectDataSet.Tables["Customer"];
            dr = dt.NewRow();
            //dr[0] = txtbname.Text;
            //dr[1] = textid.Text;
            dr[2] = textname.Text;
            dr[3] = textdateTime1.Text;
            dr[4] = textcombo1.Text;
            dr[5] = textadd.Text;
            dr[6] = textcombo2.Text;
            dr[7] = textcombo3.Text;
            dr[8] = textcontact.Text;
            dr[9] = textzip.Text;
          
            dt.Rows.Add(dr);
            customerTableAdapter.Update(heartLand_projectDataSet);



            textid.Clear();
            textname.Clear();
            textadd.Clear();         
            textcontact.Clear();
            textzip.Clear();




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

        private void label4_Click(object sender, EventArgs e)
        {
            //dr[0] = image
            //txtid.Text="";
            textname.Text = "";
            textdateTime1.Text = "";
            textcombo1.Text = "";
            textadd.Text = "";
            textcombo2.Text = "";
            textcombo3.Text = "";
            textcontact.Text = "";
            textzip.Text = "";
           
        }

        private void btnupload_Click(object sender, EventArgs e)
        {

        }
    }
}
