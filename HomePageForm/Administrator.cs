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
    public partial class Administrator : Form
    {
     
        private int ValidateData()
        {
            int flag = 0;
            if (textUsername.Text == "")
            {
                textUsername.Focus();
                errorProvider1.SetError(textUsername, "Please Fill In Name");
                flag = 1;
            }
            if (textPassword.Text == "")
            {
                textPassword.Focus();
                errorProvider1.SetError(textPassword, "Please Fill In phonenumber");
                flag = 1;
            }
            return flag;
        }
        public Administrator()
        {
            InitializeComponent();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homeform hf = new Homeform();
            hf.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            textUsername.Text = "Admin";
            textPassword.Text = "";
            string a = textPassword.Text;
            textPassword.PasswordChar = '*';
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homeform hf = new Homeform();
            hf.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
            string a = textPassword.Text;
            textPassword.PasswordChar = '\0';


            
           
        }

        private void pictureBox6_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        
        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void Administrator_Load(object sender, EventArgs e)
        {
            label6.Text = DateTime.Now.DayOfWeek.ToString();

            label4.Text = DateTime.Now.ToString("T");
            label5.Text = DateTime.Now.ToString("M");


            label13.Text = DateTime.Now.Year.ToString();

            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        [DllImport("user32")]
        public static extern void LockWorkStation();
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            LockWorkStation();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_reg_form arf = new Admin_reg_form();
            arf.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            label6.Text = DateTime.Now.DayOfWeek.ToString();

            timer1.Start();
            label4.Text = DateTime.Now.ToString("T");
            label5.Text = DateTime.Now.ToString("M");


            label13.Text = DateTime.Now.Year.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
        SqlConnection con = new SqlConnection(@"Data Source=ZIGGY\ZIGGY;Initial Catalog=heartLand_project;Integrated Security=True;User ID=sa;Password=password1");
        private void panel6_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select Count(*)  From Administarator where UserName = '" + textUsername.Text + "' and _Password = '" + textPassword.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("You have  Successfully Login!, Welcome ", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Close();
                Admin_page apf = new Admin_page();
                apf.Show();
            }
            else
            {
                MessageBox.Show("Please Check Your Username and Password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
