namespace noex1
{
    partial class Form2
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
            this.loginbtn = new System.Windows.Forms.Button();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginbtn
            // 
            this.loginbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loginbtn.FlatAppearance.BorderSize = 0;
            this.loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.loginbtn.Location = new System.Drawing.Point(30, 404);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(269, 40);
            this.loginbtn.TabIndex = 4;
            this.loginbtn.Text = "종료";
            this.loginbtn.UseVisualStyleBackColor = false;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // logoutbtn
            // 
            this.logoutbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.logoutbtn.FlatAppearance.BorderSize = 0;
            this.logoutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.logoutbtn.Location = new System.Drawing.Point(30, 354);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(269, 44);
            this.logoutbtn.TabIndex = 3;
            this.logoutbtn.Text = "로그인";
            this.logoutbtn.UseVisualStyleBackColor = false;
            this.logoutbtn.Click += new System.EventHandler(this.logout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::noex1.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(10, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::noex1.Properties.Resources.pexels_photo_2847648__1_;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.pass);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.loginbtn);
            this.panel5.Controls.Add(this.name);
            this.panel5.Controls.Add(this.logoutbtn);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Location = new System.Drawing.Point(-9, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(317, 462);
            this.panel5.TabIndex = 16;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // pass
            // 
            this.pass.BackColor = System.Drawing.SystemColors.Control;
            this.pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pass.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pass.Location = new System.Drawing.Point(30, 299);
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.Size = new System.Drawing.Size(269, 32);
            this.pass.TabIndex = 2;
            this.pass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pass_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("한컴 윤체 B", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(26, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "비밀번호";
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.SystemColors.Control;
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.name.Location = new System.Drawing.Point(30, 236);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(269, 32);
            this.name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("한컴 윤체 M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(26, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "아이디";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 457);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label1;
    }
}