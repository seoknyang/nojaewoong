namespace noex1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconButton6 = new FontAwesome.Sharp.IconButton();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.CurrentForm = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.iconButton12 = new FontAwesome.Sharp.IconButton();
            this.iconButton11 = new FontAwesome.Sharp.IconButton();
            this.iconButton10 = new FontAwesome.Sharp.IconButton();
            this.iconButton9 = new FontAwesome.Sharp.IconButton();
            this.iconButton7 = new FontAwesome.Sharp.IconButton();
            this.iconButton8 = new FontAwesome.Sharp.IconButton();
            this.panelMenu.SuspendLayout();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(271, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "물품관리 프로그램";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.panelMenu.Controls.Add(this.iconButton6);
            this.panelMenu.Controls.Add(this.iconButton5);
            this.panelMenu.Controls.Add(this.iconButton4);
            this.panelMenu.Controls.Add(this.iconButton3);
            this.panelMenu.Controls.Add(this.iconButton2);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Controls.Add(this.iconButton1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 633);
            this.panelMenu.TabIndex = 16;
            // 
            // iconButton6
            // 
            this.iconButton6.FlatAppearance.BorderSize = 0;
            this.iconButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.Cubes;
            this.iconButton6.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton6.IconSize = 32;
            this.iconButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton6.Location = new System.Drawing.Point(-3, 406);
            this.iconButton6.Name = "iconButton6";
            this.iconButton6.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton6.Size = new System.Drawing.Size(200, 60);
            this.iconButton6.TabIndex = 20;
            this.iconButton6.Tag = "Form9";
            this.iconButton6.Text = "재고관리";
            this.iconButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton6.UseVisualStyleBackColor = true;
            this.iconButton6.Click += new System.EventHandler(this.iconButton6_Click);
            // 
            // iconButton5
            // 
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.TrashRestore;
            this.iconButton5.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 32;
            this.iconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.Location = new System.Drawing.Point(-3, 340);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton5.Size = new System.Drawing.Size(200, 60);
            this.iconButton5.TabIndex = 19;
            this.iconButton5.Tag = "Form8";
            this.iconButton5.Text = "폐기관리";
            this.iconButton5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton5.UseVisualStyleBackColor = true;
            this.iconButton5.Click += new System.EventHandler(this.iconButton5_Click);
            // 
            // iconButton4
            // 
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.iconButton4.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 32;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.Location = new System.Drawing.Point(0, 277);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton4.Size = new System.Drawing.Size(200, 60);
            this.iconButton4.TabIndex = 18;
            this.iconButton4.Tag = "Form7";
            this.iconButton4.Text = "출고관리";
            this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton4.UseVisualStyleBackColor = true;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // iconButton3
            // 
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.iconButton3.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 32;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(3, 212);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton3.Size = new System.Drawing.Size(200, 60);
            this.iconButton3.TabIndex = 17;
            this.iconButton3.Tag = "Form5";
            this.iconButton3.Text = "입고관리";
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Cube;
            this.iconButton2.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 32;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(3, 146);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton2.Size = new System.Drawing.Size(200, 60);
            this.iconButton2.TabIndex = 16;
            this.iconButton2.Tag = "Form4";
            this.iconButton2.Text = "물품정보";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImage = global::noex1.Properties.Resources.logo;
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iconButton1.BackColor = System.Drawing.Color.SteelBlue;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 32;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(-3, 570);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton1.Size = new System.Drawing.Size(200, 60);
            this.iconButton1.TabIndex = 15;
            this.iconButton1.Tag = "Form3";
            this.iconButton1.Text = "관리자페이지";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.SteelBlue;
            this.panelTitle.Controls.Add(this.CurrentForm);
            this.panelTitle.Controls.Add(this.iconPictureBox1);
            this.panelTitle.Controls.Add(this.label1);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(200, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(963, 80);
            this.panelTitle.TabIndex = 17;
            // 
            // CurrentForm
            // 
            this.CurrentForm.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.CurrentForm.AutoSize = true;
            this.CurrentForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CurrentForm.ForeColor = System.Drawing.Color.White;
            this.CurrentForm.Location = new System.Drawing.Point(63, 35);
            this.CurrentForm.Name = "CurrentForm";
            this.CurrentForm.Size = new System.Drawing.Size(61, 20);
            this.CurrentForm.TabIndex = 10;
            this.CurrentForm.Text = "HOME";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 54;
            this.iconPictureBox1.Location = new System.Drawing.Point(3, 20);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(54, 74);
            this.iconPictureBox1.TabIndex = 9;
            this.iconPictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Location = new System.Drawing.Point(200, 118);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(933, 515);
            this.tabControl1.TabIndex = 11;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseClick);
            this.tabControl1.Resize += new System.EventHandler(this.tabControl1_Resize);
            // 
            // iconButton12
            // 
            this.iconButton12.BackColor = System.Drawing.SystemColors.Control;
            this.iconButton12.Enabled = false;
            this.iconButton12.FlatAppearance.BorderSize = 0;
            this.iconButton12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconButton12.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.iconButton12.IconColor = System.Drawing.Color.Black;
            this.iconButton12.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton12.IconSize = 32;
            this.iconButton12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton12.Location = new System.Drawing.Point(1029, 86);
            this.iconButton12.Name = "iconButton12";
            this.iconButton12.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton12.Size = new System.Drawing.Size(65, 34);
            this.iconButton12.TabIndex = 26;
            this.iconButton12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton12.UseVisualStyleBackColor = false;
            this.iconButton12.Click += new System.EventHandler(this.iconButton12_Click);
            // 
            // iconButton11
            // 
            this.iconButton11.BackColor = System.Drawing.SystemColors.Control;
            this.iconButton11.Enabled = false;
            this.iconButton11.FlatAppearance.BorderSize = 0;
            this.iconButton11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconButton11.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.iconButton11.IconColor = System.Drawing.Color.Black;
            this.iconButton11.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton11.IconSize = 32;
            this.iconButton11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton11.Location = new System.Drawing.Point(958, 86);
            this.iconButton11.Name = "iconButton11";
            this.iconButton11.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton11.Size = new System.Drawing.Size(65, 34);
            this.iconButton11.TabIndex = 25;
            this.iconButton11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton11.UseVisualStyleBackColor = false;
            this.iconButton11.Click += new System.EventHandler(this.iconButton11_Click);
            // 
            // iconButton10
            // 
            this.iconButton10.BackColor = System.Drawing.SystemColors.Control;
            this.iconButton10.Enabled = false;
            this.iconButton10.FlatAppearance.BorderSize = 0;
            this.iconButton10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconButton10.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.iconButton10.IconColor = System.Drawing.Color.Black;
            this.iconButton10.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton10.IconSize = 32;
            this.iconButton10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton10.Location = new System.Drawing.Point(887, 86);
            this.iconButton10.Name = "iconButton10";
            this.iconButton10.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton10.Size = new System.Drawing.Size(65, 34);
            this.iconButton10.TabIndex = 24;
            this.iconButton10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton10.UseVisualStyleBackColor = false;
            this.iconButton10.Click += new System.EventHandler(this.iconButton10_Click);
            // 
            // iconButton9
            // 
            this.iconButton9.BackColor = System.Drawing.SystemColors.Control;
            this.iconButton9.Enabled = false;
            this.iconButton9.FlatAppearance.BorderSize = 0;
            this.iconButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconButton9.IconChar = FontAwesome.Sharp.IconChar.Highlighter;
            this.iconButton9.IconColor = System.Drawing.Color.Black;
            this.iconButton9.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton9.IconSize = 32;
            this.iconButton9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton9.Location = new System.Drawing.Point(816, 86);
            this.iconButton9.Name = "iconButton9";
            this.iconButton9.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton9.Size = new System.Drawing.Size(65, 34);
            this.iconButton9.TabIndex = 23;
            this.iconButton9.Text = "+";
            this.iconButton9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton9.UseVisualStyleBackColor = false;
            this.iconButton9.Click += new System.EventHandler(this.iconButton9_Click);
            // 
            // iconButton7
            // 
            this.iconButton7.BackColor = System.Drawing.SystemColors.Control;
            this.iconButton7.Enabled = false;
            this.iconButton7.FlatAppearance.BorderSize = 0;
            this.iconButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconButton7.IconChar = FontAwesome.Sharp.IconChar.FileSignature;
            this.iconButton7.IconColor = System.Drawing.Color.Black;
            this.iconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton7.IconSize = 32;
            this.iconButton7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton7.Location = new System.Drawing.Point(755, 86);
            this.iconButton7.Name = "iconButton7";
            this.iconButton7.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton7.Size = new System.Drawing.Size(65, 34);
            this.iconButton7.TabIndex = 22;
            this.iconButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton7.UseVisualStyleBackColor = false;
            this.iconButton7.Click += new System.EventHandler(this.iconButton7_Click);
            // 
            // iconButton8
            // 
            this.iconButton8.BackColor = System.Drawing.SystemColors.Control;
            this.iconButton8.Enabled = false;
            this.iconButton8.FlatAppearance.BorderSize = 0;
            this.iconButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconButton8.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton8.IconColor = System.Drawing.Color.Black;
            this.iconButton8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton8.IconSize = 32;
            this.iconButton8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton8.Location = new System.Drawing.Point(684, 86);
            this.iconButton8.Name = "iconButton8";
            this.iconButton8.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton8.Size = new System.Drawing.Size(65, 34);
            this.iconButton8.TabIndex = 21;
            this.iconButton8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton8.UseVisualStyleBackColor = false;
            this.iconButton8.Click += new System.EventHandler(this.iconButton8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1163, 633);
            this.Controls.Add(this.iconButton12);
            this.Controls.Add(this.iconButton11);
            this.Controls.Add(this.iconButton10);
            this.Controls.Add(this.iconButton9);
            this.Controls.Add(this.iconButton7);
            this.Controls.Add(this.iconButton8);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton iconButton6;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTitle;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label CurrentForm;
        private System.Windows.Forms.TabControl tabControl1;
        private FontAwesome.Sharp.IconButton iconButton8;
        private FontAwesome.Sharp.IconButton iconButton7;
        private FontAwesome.Sharp.IconButton iconButton9;
        private FontAwesome.Sharp.IconButton iconButton10;
        private FontAwesome.Sharp.IconButton iconButton11;
        private FontAwesome.Sharp.IconButton iconButton12;
    }
}

