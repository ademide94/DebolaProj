namespace HomePageForm
{
    partial class Ereport_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ereport_form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtcombo1 = new System.Windows.Forms.ComboBox();
            this.messangerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.heartLand_projectDataSet1 = new HomePageForm.heartLand_projectDataSet1();
            this.txtcombo2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmdsend = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.cmdclear = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtreport = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.icon1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.messangerTableAdapter = new HomePageForm.heartLand_projectDataSet1TableAdapters.MessangerTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.messangerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heartLand_projectDataSet1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel9.SuspendLayout();
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
            this.panel1.Controls.Add(this.txtcombo1);
            this.panel1.Controls.Add(this.txtcombo2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtreport);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1314, 693);
            this.panel1.TabIndex = 0;
            // 
            // txtcombo1
            // 
            this.txtcombo1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.messangerBindingSource, "Message_To", true));
            this.txtcombo1.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcombo1.FormattingEnabled = true;
            this.txtcombo1.Items.AddRange(new object[] {
            "Administartor",
            "SeniorManagement",
            "Employee"});
            this.txtcombo1.Location = new System.Drawing.Point(369, 200);
            this.txtcombo1.Name = "txtcombo1";
            this.txtcombo1.Size = new System.Drawing.Size(314, 33);
            this.txtcombo1.TabIndex = 40;
            // 
            // messangerBindingSource
            // 
            this.messangerBindingSource.DataMember = "Messanger";
            this.messangerBindingSource.DataSource = this.heartLand_projectDataSet1;
            // 
            // heartLand_projectDataSet1
            // 
            this.heartLand_projectDataSet1.DataSetName = "heartLand_projectDataSet1";
            this.heartLand_projectDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtcombo2
            // 
            this.txtcombo2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.messangerBindingSource, "Message_From", true));
            this.txtcombo2.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcombo2.FormattingEnabled = true;
            this.txtcombo2.Items.AddRange(new object[] {
            "Administrator",
            "Senior Management",
            "Employee"});
            this.txtcombo2.Location = new System.Drawing.Point(973, 200);
            this.txtcombo2.Name = "txtcombo2";
            this.txtcombo2.Size = new System.Drawing.Size(297, 33);
            this.txtcombo2.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(851, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 37);
            this.label3.TabIndex = 38;
            this.label3.Text = "From:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel4.Controls.Add(this.cmdsend);
            this.panel4.Location = new System.Drawing.Point(451, 558);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(108, 33);
            this.panel4.TabIndex = 33;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // cmdsend
            // 
            this.cmdsend.AutoSize = true;
            this.cmdsend.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdsend.ForeColor = System.Drawing.SystemColors.Control;
            this.cmdsend.Location = new System.Drawing.Point(28, 4);
            this.cmdsend.Name = "cmdsend";
            this.cmdsend.Size = new System.Drawing.Size(52, 25);
            this.cmdsend.TabIndex = 0;
            this.cmdsend.Text = "Send";
            this.cmdsend.Click += new System.EventHandler(this.cmdsend_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel9.Controls.Add(this.cmdclear);
            this.panel9.Location = new System.Drawing.Point(300, 558);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(108, 33);
            this.panel9.TabIndex = 34;
            // 
            // cmdclear
            // 
            this.cmdclear.AutoSize = true;
            this.cmdclear.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdclear.ForeColor = System.Drawing.SystemColors.Control;
            this.cmdclear.Location = new System.Drawing.Point(26, 4);
            this.cmdclear.Name = "cmdclear";
            this.cmdclear.Size = new System.Drawing.Size(53, 25);
            this.cmdclear.TabIndex = 0;
            this.cmdclear.Text = "Clear";
            this.cmdclear.Click += new System.EventHandler(this.cmdclear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(295, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 37);
            this.label5.TabIndex = 31;
            this.label5.Text = "To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(294, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 42);
            this.label2.TabIndex = 32;
            this.label2.Text = "Report";
            // 
            // txtreport
            // 
            this.txtreport.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.messangerBindingSource, "_Message", true));
            this.txtreport.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtreport.Location = new System.Drawing.Point(301, 249);
            this.txtreport.Multiline = true;
            this.txtreport.Name = "txtreport";
            this.txtreport.Size = new System.Drawing.Size(968, 286);
            this.txtreport.TabIndex = 30;
            this.txtreport.TextChanged += new System.EventHandler(this.txtreport_TextChanged);
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
            this.panel3.TabIndex = 15;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(99, 377);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 20);
            this.label17.TabIndex = 4;
            this.label17.Text = "Back";
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
            this.panel2.TabIndex = 14;
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
            // messangerTableAdapter
            // 
            this.messangerTableAdapter.ClearBeforeFill = true;
            // 
            // Ereport_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 693);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ereport_form";
            this.Text = "Ereport_form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Ereport_form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.messangerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heartLand_projectDataSet1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
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
        private System.Windows.Forms.Label cmdsend;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label cmdclear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtreport;
        private System.Windows.Forms.ComboBox txtcombo1;
        private System.Windows.Forms.ComboBox txtcombo2;
        private System.Windows.Forms.Label label3;
        private heartLand_projectDataSet1 heartLand_projectDataSet1;
        private System.Windows.Forms.BindingSource messangerBindingSource;
        private heartLand_projectDataSet1TableAdapters.MessangerTableAdapter messangerTableAdapter;
    }
}