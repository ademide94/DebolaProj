namespace HomePageForm
{
    partial class Semploye_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Semploye_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.txtdateTime1 = new System.Windows.Forms.DateTimePicker();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.heartLand_projectDataSet = new HomePageForm.heartLand_projectDataSet();
            this.txtdateTime2 = new System.Windows.Forms.DateTimePicker();
            this.cmdLoad = new System.Windows.Forms.Button();
            this.txtcomBox3 = new System.Windows.Forms.ComboBox();
            this.txtcomBox2 = new System.Windows.Forms.ComboBox();
            this.txtcomBox1 = new System.Windows.Forms.ComboBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.imagebox = new System.Windows.Forms.PictureBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.icon1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.employeeTableAdapter = new HomePageForm.heartLand_projectDataSetTableAdapters.EmployeeTableAdapter();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heartLand_projectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagebox)).BeginInit();
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
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1314, 693);
            this.panel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel6.Controls.Add(this.label12);
            this.panel6.Location = new System.Drawing.Point(864, 679);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(108, 32);
            this.panel6.TabIndex = 31;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(22, 2);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 30);
            this.label12.TabIndex = 0;
            this.label12.Text = "Clear";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(687, 680);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(108, 32);
            this.panel5.TabIndex = 31;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "Submit";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.txtdateTime1);
            this.panel4.Controls.Add(this.txtdateTime2);
            this.panel4.Controls.Add(this.cmdLoad);
            this.panel4.Controls.Add(this.txtcomBox3);
            this.panel4.Controls.Add(this.txtcomBox2);
            this.panel4.Controls.Add(this.txtcomBox1);
            this.panel4.Controls.Add(this.txtusername);
            this.panel4.Controls.Add(this.txtcode);
            this.panel4.Controls.Add(this.txtphone);
            this.panel4.Controls.Add(this.txtemail);
            this.panel4.Controls.Add(this.textBox6);
            this.panel4.Controls.Add(this.txtpassword);
            this.panel4.Controls.Add(this.txtaddress);
            this.panel4.Controls.Add(this.txtname);
            this.panel4.Controls.Add(this.txtid);
            this.panel4.Controls.Add(this.imagebox);
            this.panel4.Controls.Add(this.label20);
            this.panel4.Controls.Add(this.label19);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.shapeContainer1);
            this.panel4.Location = new System.Drawing.Point(293, 97);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1006, 569);
            this.panel4.TabIndex = 7;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel7.Controls.Add(this.label21);
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1006, 59);
            this.panel7.TabIndex = 31;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI Light", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(297, 8);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(443, 48);
            this.label21.TabIndex = 11;
            this.label21.Text = "Employee Registration Form";
            // 
            // txtdateTime1
            // 
            this.txtdateTime1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Date_of_birth", true));
            this.txtdateTime1.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdateTime1.Location = new System.Drawing.Point(206, 188);
            this.txtdateTime1.Name = "txtdateTime1";
            this.txtdateTime1.Size = new System.Drawing.Size(234, 33);
            this.txtdateTime1.TabIndex = 29;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.heartLand_projectDataSet;
            // 
            // heartLand_projectDataSet
            // 
            this.heartLand_projectDataSet.DataSetName = "heartLand_projectDataSet";
            this.heartLand_projectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtdateTime2
            // 
            this.txtdateTime2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Date_of_joint", true));
            this.txtdateTime2.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdateTime2.Location = new System.Drawing.Point(206, 245);
            this.txtdateTime2.Name = "txtdateTime2";
            this.txtdateTime2.Size = new System.Drawing.Size(234, 33);
            this.txtdateTime2.TabIndex = 29;
            // 
            // cmdLoad
            // 
            this.cmdLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmdLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLoad.ForeColor = System.Drawing.Color.White;
            this.cmdLoad.Location = new System.Drawing.Point(659, 292);
            this.cmdLoad.Name = "cmdLoad";
            this.cmdLoad.Size = new System.Drawing.Size(239, 38);
            this.cmdLoad.TabIndex = 28;
            this.cmdLoad.Text = "Load";
            this.cmdLoad.UseVisualStyleBackColor = false;
            // 
            // txtcomBox3
            // 
            this.txtcomBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Designation", true));
            this.txtcomBox3.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcomBox3.FormattingEnabled = true;
            this.txtcomBox3.Items.AddRange(new object[] {
            "Representative",
            "Accountant",
            "Sales Manager ",
            "Administrator"});
            this.txtcomBox3.Location = new System.Drawing.Point(206, 465);
            this.txtcomBox3.Name = "txtcomBox3";
            this.txtcomBox3.Size = new System.Drawing.Size(234, 33);
            this.txtcomBox3.TabIndex = 27;
            // 
            // txtcomBox2
            // 
            this.txtcomBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Emp_State", true));
            this.txtcomBox2.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcomBox2.FormattingEnabled = true;
            this.txtcomBox2.Items.AddRange(new object[] {
            "Lagos",
            "Jos",
            "Osun",
            "Oyo",
            "Ilorin"});
            this.txtcomBox2.Location = new System.Drawing.Point(206, 411);
            this.txtcomBox2.Name = "txtcomBox2";
            this.txtcomBox2.Size = new System.Drawing.Size(234, 33);
            this.txtcomBox2.TabIndex = 27;
            // 
            // txtcomBox1
            // 
            this.txtcomBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "City", true));
            this.txtcomBox1.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcomBox1.FormattingEnabled = true;
            this.txtcomBox1.Items.AddRange(new object[] {
            "",
            "    Algeria",
            "    Argentina",
            "    Australia",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Chad",
            "Chile",
            "China",
            "Colombia",
            "Egypt",
            "Ethiopia",
            "Finland",
            "France",
            "    Germany",
            "    Ghana",
            "    Hong Kong",
            "    Italy",
            "    Jamaica",
            "    Japan",
            "    Kenya",
            "    Korea, North",
            "    Korea, South",
            "    Liberia",
            "    Libya",
            "    Madagascar",
            "    Malawi",
            "    Malaysia",
            "    Mexico",
            "    Netherlands",
            "    New Zealand",
            "    Niger",
            "    Nigeria",
            "    North Korea",
            "    Norway"});
            this.txtcomBox1.Location = new System.Drawing.Point(206, 355);
            this.txtcomBox1.Name = "txtcomBox1";
            this.txtcomBox1.Size = new System.Drawing.Size(234, 33);
            this.txtcomBox1.TabIndex = 26;
            // 
            // txtusername
            // 
            this.txtusername.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Username", true));
            this.txtusername.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(737, 349);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(227, 33);
            this.txtusername.TabIndex = 23;
            // 
            // txtcode
            // 
            this.txtcode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Code", true));
            this.txtcode.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcode.Location = new System.Drawing.Point(206, 521);
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(234, 33);
            this.txtcode.TabIndex = 22;
            // 
            // txtphone
            // 
            this.txtphone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Phone_no", true));
            this.txtphone.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphone.Location = new System.Drawing.Point(737, 521);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(227, 33);
            this.txtphone.TabIndex = 22;
            // 
            // txtemail
            // 
            this.txtemail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Email", true));
            this.txtemail.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(737, 465);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(227, 33);
            this.txtemail.TabIndex = 22;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(737, 465);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(227, 26);
            this.textBox6.TabIndex = 22;
            // 
            // txtpassword
            // 
            this.txtpassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "_Password", true));
            this.txtpassword.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(737, 408);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(227, 33);
            this.txtpassword.TabIndex = 22;
            // 
            // txtaddress
            // 
            this.txtaddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "_Address", true));
            this.txtaddress.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.Location = new System.Drawing.Point(206, 298);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(234, 33);
            this.txtaddress.TabIndex = 21;
            // 
            // txtname
            // 
            this.txtname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Name", true));
            this.txtname.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(206, 138);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(234, 33);
            this.txtname.TabIndex = 20;
            // 
            // txtid
            // 
            this.txtid.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Emp_ID", true));
            this.txtid.Enabled = false;
            this.txtid.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(206, 84);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(234, 33);
            this.txtid.TabIndex = 19;
            // 
            // imagebox
            // 
            this.imagebox.Image = ((System.Drawing.Image)(resources.GetObject("imagebox.Image")));
            this.imagebox.Location = new System.Drawing.Point(641, 84);
            this.imagebox.Name = "imagebox";
            this.imagebox.Size = new System.Drawing.Size(272, 199);
            this.imagebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagebox.TabIndex = 18;
            this.imagebox.TabStop = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(600, 352);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(95, 25);
            this.label20.TabIndex = 16;
            this.label20.Text = "UserName";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(600, 411);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(85, 25);
            this.label19.TabIndex = 16;
            this.label19.Text = "Password";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(600, 524);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 25);
            this.label16.TabIndex = 16;
            this.label16.Text = "Phone No";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 193);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 25);
            this.label10.TabIndex = 16;
            this.label10.Text = "Date of Birth";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(600, 466);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(132, 25);
            this.label18.TabIndex = 15;
            this.label18.Text = "E-mail Address";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 245);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 25);
            this.label11.TabIndex = 15;
            this.label11.Text = "Date of Joining";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 414);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "State";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(26, 473);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "Designation";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "City";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 524);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Employee Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Employee ID";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1006, 569);
            this.shapeContainer1.TabIndex = 30;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackColor = System.Drawing.Color.DarkRed;
            this.rectangleShape1.BorderColor = System.Drawing.Color.Red;
            this.rectangleShape1.Location = new System.Drawing.Point(638, 82);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(276, 202);
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
            this.panel3.TabIndex = 6;
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
            this.panel2.TabIndex = 4;
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
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // Semploye_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 693);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Semploye_Form";
            this.Text = "Semploye_Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Semploye_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heartLand_projectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagebox)).EndInit();
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

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox icon1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button cmdLoad;
        private System.Windows.Forms.ComboBox txtcomBox2;
        private System.Windows.Forms.ComboBox txtcomBox1;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.PictureBox imagebox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ComboBox txtcomBox3;
        private System.Windows.Forms.DateTimePicker txtdateTime2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.DateTimePicker txtdateTime1;
        private System.Windows.Forms.Panel panel7;
        private heartLand_projectDataSet heartLand_projectDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private heartLand_projectDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
    }
}