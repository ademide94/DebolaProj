using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace HomePageForm
{
   
    public partial class Senior_Management : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=ZIGGY\ZIGGY;Initial Catalog=heartLand_project;Integrated Security=True;User ID=sa;Password=password1");
        DataSet ds;
        int Ctr;
        public Senior_Management()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homeform hf = new Homeform();
            hf.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            textUsername.Text = "Senior";
            textPassword.Text = "";
            string a = textPassword.Text;
            textPassword.PasswordChar = '*';
        }

        private void icon1_Click_1(object sender, EventArgs e)
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

        private void label15_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Homeform hf = new Homeform();
            hf.Show();
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            string a = textPassword.Text;
            textPassword.PasswordChar = '\0';
        }

        private void label3_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select Count(*)  From SeniorManagement where UserName = '" + textUsername.Text + "' and _Password = '" + textPassword.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("You have  Successfully Login!, Welcome ", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Close();
                Seniorman_page spf = new Seniorman_page();
                spf.Show();
            }
            else
            {
                MessageBox.Show("Please Check Your Username and Password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
        
        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {
            label12.Text = DateTime.Now.DayOfWeek.ToString();

            timer1.Start();
            label6.Text = DateTime.Now.ToString("T");
            label10.Text = DateTime.Now.ToString("M");


            label13.Text = DateTime.Now.Year.ToString();
        }

        [DllImport("user32")]
        public static extern void LockWorkStation();
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            LockWorkStation();
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label6.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Senior_Management_Load(object sender, EventArgs e)
        {

        }
    }
}
