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
    public partial class Aemplye_details_form : Form
    {
        string connstring = "Data Source=ZIGGY\\ZIGGY;Initial Catalog=heartLand_project;Persist Security Info=True;User ID=sa;Password=password1";
        int id;

        SqlConnection con = new SqlConnection("Data Source=ZIGGY\\ZIGGY;Initial Catalog=heartLand_project;Persist Security Info=True;User ID=sa;Password=password1");
        DataSet ds;

        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Label label17;
        private Label label15;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox icon1;
        private PictureBox pictureBox1;
        private DataGridView Employee_dataGridView1;
        private Panel panel4;
        private Label label16;
        private Label label18;
        private Label label11;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label20;
        private Label label19;
        private Label label4;
        private Label label10;
        private Label label21;
        private PictureBox pictureBox4;
        private TextBox txtusername;
        private TextBox txtphone;
        private TextBox txtemail;
        private TextBox txtpassword;
        private TextBox txtcomBox2;
        private TextBox txtcomBox1;
        private TextBox txtaddress;
        private TextBox txtdateTime2;
        private TextBox txtcode;
        private TextBox txtname;
        private TextBox txtid;
        private Label label9;
        private Panel panel5;
        private TextBox txtcomBox3;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Panel panel6;
        private Label cmddelete;
        private Panel panel15;
        private Label cmdupdate;
        private Panel panel14;
        private Label cmdview;
        private TextBox txtdateTime1;
        private Label label22;
        private Panel panel1;
    
        public Aemplye_details_form()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aemplye_details_form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cmddelete = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.cmdupdate = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.cmdview = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtdateTime1 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtcomBox2 = new System.Windows.Forms.TextBox();
            this.txtcomBox1 = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtdateTime2 = new System.Windows.Forms.TextBox();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtcomBox3 = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.Employee_dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.icon1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Employee_dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel15);
            this.panel1.Controls.Add(this.panel14);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.Employee_dataGridView1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1314, 693);
            this.panel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel6.Controls.Add(this.cmddelete);
            this.panel6.Location = new System.Drawing.Point(1194, 633);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(108, 33);
            this.panel6.TabIndex = 30;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // cmddelete
            // 
            this.cmddelete.AutoSize = true;
            this.cmddelete.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmddelete.ForeColor = System.Drawing.SystemColors.Control;
            this.cmddelete.Location = new System.Drawing.Point(20, 5);
            this.cmddelete.Name = "cmddelete";
            this.cmddelete.Size = new System.Drawing.Size(65, 25);
            this.cmddelete.TabIndex = 0;
            this.cmddelete.Text = "Delete";
            this.cmddelete.Click += new System.EventHandler(this.cmddelete_Click);
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel15.Controls.Add(this.cmdupdate);
            this.panel15.Location = new System.Drawing.Point(1194, 575);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(108, 33);
            this.panel15.TabIndex = 31;
            // 
            // cmdupdate
            // 
            this.cmdupdate.AutoSize = true;
            this.cmdupdate.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdupdate.ForeColor = System.Drawing.SystemColors.Control;
            this.cmdupdate.Location = new System.Drawing.Point(20, 5);
            this.cmdupdate.Name = "cmdupdate";
            this.cmdupdate.Size = new System.Drawing.Size(71, 25);
            this.cmdupdate.TabIndex = 0;
            this.cmdupdate.Text = "Update";
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel14.Controls.Add(this.cmdview);
            this.panel14.Location = new System.Drawing.Point(1194, 516);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(108, 33);
            this.panel14.TabIndex = 32;
            this.panel14.Paint += new System.Windows.Forms.PaintEventHandler(this.panel14_Paint);
            // 
            // cmdview
            // 
            this.cmdview.AutoSize = true;
            this.cmdview.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdview.ForeColor = System.Drawing.SystemColors.Control;
            this.cmdview.Location = new System.Drawing.Point(28, 5);
            this.cmdview.Name = "cmdview";
            this.cmdview.Size = new System.Drawing.Size(50, 25);
            this.cmdview.TabIndex = 0;
            this.cmdview.Text = "View";
            this.cmdview.Click += new System.EventHandler(this.cmdview_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel5.Location = new System.Drawing.Point(258, 149);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1044, 13);
            this.panel5.TabIndex = 20;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel4.Controls.Add(this.txtdateTime1);
            this.panel4.Controls.Add(this.label22);
            this.panel4.Controls.Add(this.txtusername);
            this.panel4.Controls.Add(this.txtphone);
            this.panel4.Controls.Add(this.txtemail);
            this.panel4.Controls.Add(this.txtpassword);
            this.panel4.Controls.Add(this.txtcomBox2);
            this.panel4.Controls.Add(this.txtcomBox1);
            this.panel4.Controls.Add(this.txtaddress);
            this.panel4.Controls.Add(this.txtdateTime2);
            this.panel4.Controls.Add(this.txtcode);
            this.panel4.Controls.Add(this.txtname);
            this.panel4.Controls.Add(this.txtcomBox3);
            this.panel4.Controls.Add(this.txtid);
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.label20);
            this.panel4.Controls.Add(this.label19);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label21);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.shapeContainer1);
            this.panel4.Location = new System.Drawing.Point(258, 149);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1044, 357);
            this.panel4.TabIndex = 16;
            // 
            // txtdateTime1
            // 
            this.txtdateTime1.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdateTime1.Location = new System.Drawing.Point(463, 125);
            this.txtdateTime1.Name = "txtdateTime1";
            this.txtdateTime1.Size = new System.Drawing.Size(194, 33);
            this.txtdateTime1.TabIndex = 36;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(334, 127);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(112, 25);
            this.label22.TabIndex = 22;
            this.label22.Text = "Date of Birth";
            // 
            // txtusername
            // 
            this.txtusername.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(815, 127);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(194, 33);
            this.txtusername.TabIndex = 36;
            // 
            // txtphone
            // 
            this.txtphone.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphone.Location = new System.Drawing.Point(815, 260);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(194, 33);
            this.txtphone.TabIndex = 36;
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(815, 215);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(194, 33);
            this.txtemail.TabIndex = 36;
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(815, 171);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(194, 33);
            this.txtpassword.TabIndex = 36;
            // 
            // txtcomBox2
            // 
            this.txtcomBox2.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcomBox2.Location = new System.Drawing.Point(463, 304);
            this.txtcomBox2.Name = "txtcomBox2";
            this.txtcomBox2.Size = new System.Drawing.Size(194, 33);
            this.txtcomBox2.TabIndex = 36;
            // 
            // txtcomBox1
            // 
            this.txtcomBox1.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcomBox1.Location = new System.Drawing.Point(463, 257);
            this.txtcomBox1.Name = "txtcomBox1";
            this.txtcomBox1.Size = new System.Drawing.Size(194, 33);
            this.txtcomBox1.TabIndex = 36;
            // 
            // txtaddress
            // 
            this.txtaddress.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.Location = new System.Drawing.Point(463, 212);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(194, 33);
            this.txtaddress.TabIndex = 36;
            // 
            // txtdateTime2
            // 
            this.txtdateTime2.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdateTime2.Location = new System.Drawing.Point(463, 168);
            this.txtdateTime2.Name = "txtdateTime2";
            this.txtdateTime2.Size = new System.Drawing.Size(194, 33);
            this.txtdateTime2.TabIndex = 36;
            // 
            // txtcode
            // 
            this.txtcode.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcode.Location = new System.Drawing.Point(815, 80);
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(194, 33);
            this.txtcode.TabIndex = 36;
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(463, 80);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(194, 33);
            this.txtname.TabIndex = 36;
            // 
            // txtcomBox3
            // 
            this.txtcomBox3.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcomBox3.Location = new System.Drawing.Point(815, 33);
            this.txtcomBox3.Name = "txtcomBox3";
            this.txtcomBox3.Size = new System.Drawing.Size(194, 33);
            this.txtcomBox3.TabIndex = 36;
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(463, 33);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(194, 33);
            this.txtid.TabIndex = 36;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(30, 28);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(261, 207);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 35;
            this.pictureBox4.TabStop = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(696, 130);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(95, 25);
            this.label20.TabIndex = 32;
            this.label20.Text = "UserName";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(706, 174);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(85, 25);
            this.label19.TabIndex = 33;
            this.label19.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(699, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 34;
            this.label4.Text = "Phone No";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(684, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 25);
            this.label10.TabIndex = 31;
            this.label10.Text = "Designation";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(735, 83);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(56, 25);
            this.label21.TabIndex = 29;
            this.label21.Text = "Code";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(817, 448);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 20);
            this.label16.TabIndex = 25;
            this.label16.Text = "Phone No";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(659, 218);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(132, 25);
            this.label18.TabIndex = 21;
            this.label18.Text = "E-mail Address";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(315, 171);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 25);
            this.label11.TabIndex = 22;
            this.label11.Text = "Date of Joining";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(385, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 25);
            this.label8.TabIndex = 27;
            this.label8.Text = "State";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(394, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 25);
            this.label7.TabIndex = 24;
            this.label7.Text = "City";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(370, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(244, 448);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(304, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "Employee Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(338, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Customer ID";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1044, 357);
            this.shapeContainer1.TabIndex = 37;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackColor = System.Drawing.Color.DarkRed;
            this.rectangleShape1.BorderColor = System.Drawing.Color.Red;
            this.rectangleShape1.Location = new System.Drawing.Point(25, 24);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(269, 213);
            // 
            // Employee_dataGridView1
            // 
            this.Employee_dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.Employee_dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Employee_dataGridView1.Location = new System.Drawing.Point(258, 516);
            this.Employee_dataGridView1.Name = "Employee_dataGridView1";
            this.Employee_dataGridView1.Size = new System.Drawing.Size(930, 150);
            this.Employee_dataGridView1.TabIndex = 15;
            this.Employee_dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Employee_dataGridView1_CellClick);
            this.Employee_dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.icon1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 56);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(89, 637);
            this.panel3.TabIndex = 12;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(99, 377);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 20);
            this.label17.TabIndex = 4;
            this.label17.Text = "LogOut";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(99, 209);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 20);
            this.label15.TabIndex = 4;
            this.label15.Text = "Home";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(9, 368);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(69, 52);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 179);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(83, 69);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // icon1
            // 
            this.icon1.Image = ((System.Drawing.Image)(resources.GetObject("icon1.Image")));
            this.icon1.Location = new System.Drawing.Point(3, 41);
            this.icon1.Name = "icon1";
            this.icon1.Size = new System.Drawing.Size(83, 65);
            this.icon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon1.TabIndex = 1;
            this.icon1.TabStop = false;
            this.icon1.Click += new System.EventHandler(this.icon1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 549);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 75);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1314, 56);
            this.panel2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(95, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "HeartLand Home Finance";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Crimson;
            this.label9.Location = new System.Drawing.Point(549, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(430, 55);
            this.label9.TabIndex = 18;
            this.label9.Text = "Employee Register";
            // 
            // Aemplye_details_form
            // 
            this.ClientSize = new System.Drawing.Size(1314, 693);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Aemplye_details_form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Employee_dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Admin_page apf = new Admin_page();
            apf.Show();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            Homeform hf = new Homeform();
            hf.Show();
        }

        private void cmdview_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Employee", con);
            ds = new DataSet();
            sda.Fill(ds, "Employee");

            Employee_dataGridView1.DataSource = ds.Tables[0].DefaultView;

            con.Close();
        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Employee_dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                DataGridViewRow row = this.Employee_dataGridView1.Rows[e.RowIndex];
                txtid.Text = row.Cells["Emp_ID"].Value.ToString();
                txtname.Text = row.Cells["Name"].Value.ToString();
                txtdateTime1.Text = row.Cells["Date_of_birth"].Value.ToString();
                txtdateTime2.Text = row.Cells["Date_of_joint"].Value.ToString();
                txtaddress.Text = row.Cells["_Address"].Value.ToString();
                txtcomBox1.Text = row.Cells["City"].Value.ToString();
                txtcomBox2.Text = row.Cells["Emp_State"].Value.ToString();
                txtcomBox3.Text = row.Cells["Designation"].Value.ToString();
                txtcode.Text = row.Cells["Code"].Value.ToString();
                txtusername.Text = row.Cells["Username"].Value.ToString();
                txtpassword.Text = row.Cells["_Password"].Value.ToString();
                txtemail.Text = row.Cells["Email"].Value.ToString();
                txtphone.Text = row.Cells["Phone_no"].Value.ToString();

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
            com = new SqlCommand("delete from Employee where Emp_ID = " + txtid.Text + " ", con);
            try
            {

                txtid.Text = ("");
                txtname.Text = ("");
                txtdateTime1.Text = ("");
                txtdateTime2.Text = ("");
                txtaddress.Text = ("");
                txtcomBox1.Text = ("");
                txtcomBox2.Text = ("");
                txtcomBox3.Text = ("");
                txtcode.Text = ("");
                txtusername.Text = ("");
                txtpassword.Text = ("");
                txtemail.Text = ("");
                txtphone.Text = ("");
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
    }
}
