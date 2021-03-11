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
    public partial class Payment_Form : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=ZIGGY\ZIGGY;Initial Catalog=heartLand_project;Integrated Security=True;User ID=sa;Password=password1");
       
        
        public Payment_Form()
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            this.Hide();
            Seniorman_page spf = new Seniorman_page();
            spf.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        DataTable dt;
        DataRow dr;
        private void label7_Click(object sender, EventArgs e)
        {
            dt = heartLand_projectDataSet.Tables["Payment"];
            dr = dt.NewRow();
            //dr[0] = textid.Text;
            dr[1] = textno.Text;
            dr[2] = dateTimePicker1.Text;
            dr[3] = textamount.Text;
            dt.Rows.Add(dr);
            paymentTableAdapter.Update(heartLand_projectDataSet);


            textno.Clear();
            textamount.Clear();




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

        private void Payment_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'heartLand_projectDataSet.Payment' table. You can move, or remove it, as needed.
            this.paymentTableAdapter.Fill(this.heartLand_projectDataSet.Payment);

           

        }

        private void textamount_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            textid.Text = "";
            textno.Text = "";
            dateTimePicker1.Text = "";
            textamount.Text = "";
           
        }
    }
}
