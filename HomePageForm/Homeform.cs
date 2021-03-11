
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
namespace HomePageForm
{
    public partial class Homeform : Form
    {
        public Homeform()
        {
            InitializeComponent();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Administrator af = new Administrator();
            af.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Senior_Management sm = new Senior_Management();
            sm.Show();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employe_Login ef = new Employe_Login();
            ef.Show();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homeform hf = new Homeform();
            hf.Show();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Photos pf = new Photos();
            pf.Show();
        }

        [DllImport("user32")]
        public static extern void LockWorkStation();
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            LockWorkStation();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void timer1_Tick(object sender, EventArgs e)
        {

            string [] picsa= {"jj"};


       // pictureBox4.Image 

      
        
	}

     

        private void panel6_MouseEnter(object sender, EventArgs e)
        {

            panel6.BackColor = Color.Crimson;
           
        }

        private void panel6_MouseLeave(object sender, EventArgs e)
        {

            panel6.BackColor = Color.SteelBlue;
            
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            About_form af = new About_form();
            af.Show();
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            panel6.BackColor = Color.Crimson;
           
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            panel6.BackColor = Color.Crimson;
           
        }

        private void panel9_MouseEnter(object sender, EventArgs e)
        {
            panel9.BackColor = Color.Crimson;
        }

        private void panel9_MouseLeave(object sender, EventArgs e)
        {
            panel9.BackColor = Color.Red;
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            panel9.BackColor = Color.Crimson;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            panel9.BackColor = Color.Crimson;
        }

        private void panel5_MouseEnter(object sender, EventArgs e)
        {
            panel5.BackColor = Color.Red;
        }

        private void panel5_MouseLeave(object sender, EventArgs e)
        {
            panel5.BackColor = Color.Crimson;
        }

        private void pictureBox9_MouseEnter(object sender, EventArgs e)
        {
            panel5.BackColor = Color.Red;
        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            panel5.BackColor = Color.Crimson;
        }

        private void panel3_MouseEnter(object sender, EventArgs e)
        {
            panel3.BackColor = Color.LightSkyBlue;
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            panel3.BackColor = Color.ForestGreen;
        }

        private void pictureBox10_MouseEnter(object sender, EventArgs e)
        {
            panel3.BackColor = Color.LightSkyBlue;
        }

        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {
            panel3.BackColor = Color.ForestGreen;
        }

        private void panel4_MouseEnter(object sender, EventArgs e)
        {
            panel4.BackColor = Color.Tomato;
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            panel4.BackColor = Color.Gold;
        }

        private void pictureBox11_MouseEnter(object sender, EventArgs e)
        {
            panel4.BackColor = Color.Tomato;
        }

        private void pictureBox11_MouseLeave(object sender, EventArgs e)
        {
            panel4.BackColor = Color.Gold;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel11_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void panel11_MouseLeave(object sender, EventArgs e)
        {
           
        }  
           
    
    
    }

        }
  