namespace noex1
{
    partial class Form5
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtcomp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.schbtn = new System.Windows.Forms.Button();
            this.txtdate = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtsamt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtcomp1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtmoney = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtamt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtname1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(3, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(532, 523);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // Column1
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "품목코드";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "물품명";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "재고량";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "입고일자";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "입고량";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "입고금액";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "입고처";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 96;
            this.label1.Text = "물품명";
            // 
            // txtname
            // 
            this.txtname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtname.Location = new System.Drawing.Point(261, 30);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(99, 21);
            this.txtname.TabIndex = 97;
            // 
            // txtcomp
            // 
            this.txtcomp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcomp.Location = new System.Drawing.Point(418, 30);
            this.txtcomp.Name = "txtcomp";
            this.txtcomp.Size = new System.Drawing.Size(98, 21);
            this.txtcomp.TabIndex = 99;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(373, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 98;
            this.label2.Text = "입고처";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 100;
            this.label3.Text = "입고일";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(170, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 12);
            this.label11.TabIndex = 104;
            this.label11.Text = "~";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("한컴 윤체 B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(3, -1);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 37);
            this.label12.TabIndex = 105;
            this.label12.Text = "입고관리";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(59, 31);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(89, 21);
            this.dateTimePicker1.TabIndex = 106;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(200, 30);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(97, 21);
            this.dateTimePicker2.TabIndex = 107;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 9);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(888, 599);
            this.tableLayoutPanel1.TabIndex = 108;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.txtcomp);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtname);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 64);
            this.panel1.TabIndex = 106;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(541, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(344, 523);
            this.panel2.TabIndex = 120;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.schbtn);
            this.groupBox1.Controls.Add(this.txtdate);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.txtsamt);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtcomp1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtmoney);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtamt);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtname1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtcode);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 523);
            this.groupBox1.TabIndex = 103;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "입고관리";
            // 
            // schbtn
            // 
            this.schbtn.Location = new System.Drawing.Point(215, 21);
            this.schbtn.Name = "schbtn";
            this.schbtn.Size = new System.Drawing.Size(75, 23);
            this.schbtn.TabIndex = 120;
            this.schbtn.Text = "검색";
            this.schbtn.UseVisualStyleBackColor = true;
            this.schbtn.Click += new System.EventHandler(this.schbtn_Click);
            // 
            // txtdate
            // 
            this.txtdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtdate.Location = new System.Drawing.Point(74, 118);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(141, 21);
            this.txtdate.TabIndex = 119;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(215, 145);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(0, 21);
            this.textBox1.TabIndex = 118;
            this.textBox1.Visible = false;
            // 
            // txtsamt
            // 
            this.txtsamt.Location = new System.Drawing.Point(74, 87);
            this.txtsamt.Name = "txtsamt";
            this.txtsamt.ReadOnly = true;
            this.txtsamt.Size = new System.Drawing.Size(141, 21);
            this.txtsamt.TabIndex = 117;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 116;
            this.label10.Text = "재고량";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(215, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(9, 0);
            this.button1.TabIndex = 104;
            this.button1.Text = "조회";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtcomp1
            // 
            this.txtcomp1.Location = new System.Drawing.Point(74, 209);
            this.txtcomp1.Name = "txtcomp1";
            this.txtcomp1.Size = new System.Drawing.Size(141, 21);
            this.txtcomp1.TabIndex = 115;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 114;
            this.label9.Text = "입고처";
            // 
            // txtmoney
            // 
            this.txtmoney.Location = new System.Drawing.Point(74, 172);
            this.txtmoney.Name = "txtmoney";
            this.txtmoney.Size = new System.Drawing.Size(141, 21);
            this.txtmoney.TabIndex = 113;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 112;
            this.label8.Text = "입고금액";
            // 
            // txtamt
            // 
            this.txtamt.Location = new System.Drawing.Point(74, 145);
            this.txtamt.Name = "txtamt";
            this.txtamt.Size = new System.Drawing.Size(141, 21);
            this.txtamt.TabIndex = 111;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 110;
            this.label7.Text = "입고량";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 108;
            this.label6.Text = "입고일자";
            // 
            // txtname1
            // 
            this.txtname1.Location = new System.Drawing.Point(74, 60);
            this.txtname1.Name = "txtname1";
            this.txtname1.ReadOnly = true;
            this.txtname1.Size = new System.Drawing.Size(141, 21);
            this.txtname1.TabIndex = 107;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 106;
            this.label5.Text = "믈품명";
            // 
            // txtcode
            // 
            this.txtcode.Location = new System.Drawing.Point(74, 23);
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(141, 21);
            this.txtcode.TabIndex = 105;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 104;
            this.label4.Text = "물품코드";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dateTimePicker2);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(541, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(344, 64);
            this.panel3.TabIndex = 121;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 650);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtcomp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker txtdate;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox txtsamt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtcomp1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtmoney;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtamt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtname1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button schbtn;
        private System.Windows.Forms.Panel panel3;
    }
}