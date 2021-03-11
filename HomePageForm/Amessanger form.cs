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
    public partial class Amessanger_form : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=ZIGGY\ZIGGY;Initial Catalog=heartLand_project;Integrated Security=True;User ID=sa;Password=password1");
        DataSet ds;
        public Amessanger_form()
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_page apf = new Admin_page();
            apf.Show();
        }

        private void Amessanger_form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'heartLand_projectDataSet1.Messanger' table. You can move, or remove it, as needed.
            this.messangerTableAdapter.Fill(this.heartLand_projectDataSet1.Messanger);
            // TODO: This line of code loads data into the 'heartLand_projectDataSet.Messanger' table. You can move, or remove it, as needed.
            this.messangerTableAdapter.Fill(this.heartLand_projectDataSet1.Messanger);

        }
        DataTable dt;
        DataRow dr;
        private void cmdsend_Click(object sender, EventArgs e)
        {
            dt = heartLand_projectDataSet1.Tables["Messanger"];
            dr = dt.NewRow();
            dr[0] = comboBox1.Text;
            dr[1] = txtcombo1.Text;
            dr[2] = txtreport.Text;

            dt.Rows.Add(dr);
            messangerTableAdapter.Update(heartLand_projectDataSet1);

            txtreport.Clear();





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

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmdclear_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            txtcombo1.Text = "";
            txtreport.Text = "";
            
        }
    }
}
