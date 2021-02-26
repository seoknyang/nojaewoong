using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;


namespace noex1
{
    
    public partial class Form1 : Form
    {

        private Point _imageLocation = new Point(13, 5);

        private Point _imgHitArea = new Point(13, 2);

        Image CloseImage;


        Form frm = null;
        
        Type t = null;
        String codevalue="a";
        
        public void Serch()
        {   
            t.GetMethod("look").Invoke(frm, null);
        }
        public void Ins()
        {
            bool b1=(bool)t.GetMethod("insert").Invoke(frm, null);
            if(b1)
            {
                buttonfuncion();
            }
            else
            {
                canclefuncion();
            }
            codevalue = "I";
        }

        public void confirm()
        {

            string[] aa = { codevalue };
            t.GetMethod("okbtn_Click").Invoke(frm, aa);
            

        }
        public void recare()
        {
            bool b1 = (bool)t.GetMethod("rebtn_Click").Invoke(frm, null);
            if (b1)
            {
                buttonfuncion();
            }
            else
            {
                canclefuncion();
            }

        }
        public void delete()
        {
            
            bool b1 =(bool) t.GetMethod("deletebtn_Click").Invoke(frm, null);
            if(b1)
            {
                buttonfuncion();
            }
            else
            {            
                canclefuncion();
            }
            
        }
       
        // fields
        private IconButton currentbt;
        private Panel leftborderBtn;
        //Construtor
        public Form1()
        {
            InitializeComponent();
            leftborderBtn = new Panel();
            leftborderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftborderBtn);
        }
        private void ActiveteButton(object senderBtn, Color color)
        {

            if(senderBtn != null)
            {
                DisableButton();
                currentbt = (IconButton)senderBtn;
                currentbt.BackColor = Color.FromArgb(37, 36, 81);
                currentbt.ForeColor = color;
                currentbt.TextAlign = ContentAlignment.MiddleCenter;
                currentbt.IconColor = color;
                currentbt.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentbt.ImageAlign = ContentAlignment.MiddleRight;
                
                //left border button

                leftborderBtn.BackColor = color;
                leftborderBtn.Location = new Point(0,currentbt.Location.Y);
                leftborderBtn.Visible = true;
                leftborderBtn.BringToFront();
                return;
                
                
            }
        }
        private struct RGBcolors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        private void DisableButton()
        {
            if(currentbt != null)
            {
                currentbt.BackColor = Color.SteelBlue;
                currentbt.ForeColor = Color.White;
                currentbt.TextAlign = ContentAlignment.MiddleLeft;
                currentbt.IconColor = Color.White;
                currentbt.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentbt.ImageAlign = ContentAlignment.MiddleLeft;
                return;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            new Form2().ShowDialog(); // 폼 2 먼저 연결
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            tabControl1.DrawItem += tabControl1_DrawItem;
            tabControl1.MouseClick += tabControl1_MouseClick;
            CloseImage = Properties.Resources.close;
            this.tabControl1.Padding = new Point(10, 3);

        }
      private void tabControl1_DrawItem(object sender,System.Windows.Forms.DrawItemEventArgs e)
        {
            //tabpage 닫기 버튼
            try
            {
                Image img = new Bitmap(CloseImage);
                Rectangle r = e.Bounds;
                r = this.tabControl1.GetTabRect(e.Index);
                r.Offset(3, 3);
                string title = this.tabControl1.TabPages[e.Index].Text;
                Font f = this.Font;
                Brush titleBrush = new SolidBrush(Color.Black);
                e.Graphics.DrawString(title, f, titleBrush, new PointF(r.X, r.Y));
                if(tabControl1.SelectedIndex >=1)
                {
                    e.Graphics.DrawImage(img, new Point(r.X + (this.tabControl1.GetTabRect(e.Index).Width - _imageLocation.X), _imageLocation.Y));
                }

            }
            catch (Exception r)
            {

                MessageBox.Show(r.Message.ToString());
            }
        }
       
        

     

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActiveteButton(sender, RGBcolors.color1);
            canclefuncion();
            bool tpgChk = false;

            int tpg_idx = 0;
            foreach (TabPage chk in tabControl1.TabPages)
            {
                
                if (chk.Name.Equals("adminfrm"))
                {
                    tabControl1.SelectTab(tpg_idx);
                    
                    chk.Show();
                    tpgChk = true;
                    tpg_idx++;
                    return;
                }
                
            }

            if (!tpgChk)
            {
                TabPage tpg = new TabPage();
                t = Type.GetType("noex1.Form3");
                frm = Activator.CreateInstance(t) as Form;
                tpg.Tag = "iconbutton1";
                tpg.Name = "adminfrm";
                tpg.Text = "관리자 페이지";
                frm.TopLevel = false;
                frm.Height = 509;
                frm.Width = 911;
                //frm3.Size = tpg.Size;
                tpg.Controls.Add(frm);
                frm.Show();

                tabControl1.TabPages.Add(tpg);
                return;
            }


    //     new Form3().ShowDialog();
        }
        public void move(string title)
        {//버튼클릭시 탭페이지로 이동
            foreach (TabPage target in tabControl1.TabPages)
            {
                if(target.Text == title)
                {
                    tabControl1.SelectedTab = target;
                }
            }
        }
        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActiveteButton(sender, RGBcolors.color2);
            canclefuncion();
            bool tpgChk = false;

            int tpg_idx = 0;

            foreach (TabPage chk in tabControl1.TabPages)
                {
                    if (chk.Name.Equals("adminbitem"))
                    {
                        tabControl1.SelectTab(tpg_idx);
                        chk.Show();
                        tpgChk = true;
                        return;
                    }
                    tpg_idx++;
                }

            if (!tpgChk)
            {
                TabPage tpg = new TabPage();
                t = Type.GetType("noex1.Form4");
                frm = Activator.CreateInstance(t) as Form;

                tpg.Name = "adminbitem";
                tpg.Text = "물품정보";
                tpg.Tag = "iconbutton2";
                frm.TopLevel = false;
                frm.Height = 530;
                frm.Width = 925;
                //frm3.Size = tpg.Size;
                tpg.Controls.Add(frm);
                frm.Show();

                tabControl1.TabPages.Add(tpg);
                
            }
            //  new Form4().ShowDialog();
            
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActiveteButton(sender, RGBcolors.color3);
            canclefuncion();
            bool tpgChk = false;

            int tpg_idx = 0;
            foreach (TabPage chk in tabControl1.TabPages)
            {
                if (chk.Name.Equals("adminipgo"))
                {
                    tabControl1.SelectTab(tpg_idx);
                    chk.Show();
                    
                    tpgChk = true;
                    return;
                }
                tpg_idx++;
            }

            if (!tpgChk)
            {
                TabPage tpg = new TabPage();
                t = Type.GetType("noex1.Form5");
                frm = Activator.CreateInstance(t) as Form;

                tpg.Name = "adminipgo";
                tpg.Text = "입고관리";
                tpg.Tag = "iconbutton3";
                frm.TopLevel = false;
                frm.Height = 530;
                frm.Width = 925;
                //frm3.Size = tpg.Size;
                tpg.Controls.Add(frm);
                frm.Show();

                tabControl1.TabPages.Add(tpg);
                return;
            }
            new Form5().ShowDialog();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActiveteButton(sender, RGBcolors.color4);
            bool tpgChk = false;

            int tpg_idx = 0;
            foreach (TabPage chk in tabControl1.TabPages)
            {
                if (chk.Name.Equals("adminculgo"))
                {
                    tabControl1.SelectTab(tpg_idx);
                    chk.Show();
                    tpgChk = true;
                    return;
                }
                tpg_idx++;
            }

            if (!tpgChk)
            {
                TabPage tpg = new TabPage();
                t = Type.GetType("noex1.Form7");
                frm = Activator.CreateInstance(t) as Form;
                canclefuncion();
                tpg.Name = "adminculgo";
                tpg.Text = "출고관리";
                tpg.Tag = "iconbutton4";
                frm.TopLevel = false;
                frm.Height = 530;
                frm.Width = 925;
                //frm3.Size = tpg.Size;
                tpg.Controls.Add(frm);
                frm.Show();

                tabControl1.TabPages.Add(tpg);
            }
            //new Form7().ShowDialog(); // 폼 5 
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            ActiveteButton(sender, RGBcolors.color5);
         
            bool tpgChk = false;

            int tpg_idx = 0;
            foreach (TabPage chk in tabControl1.TabPages)
            {
                if (chk.Name.Equals("admin"))
                {
                    tabControl1.SelectTab(tpg_idx);
                    chk.Show();
                    tpgChk = true;
                    return;
                }
                tpg_idx++;
            }

            if (!tpgChk)
            {
                TabPage tpg = new TabPage();
                t = Type.GetType("noex1.Form8");
                frm = Activator.CreateInstance(t) as Form;

                tpg.Name = "admin";
                tpg.Text = "폐기관리";
                tpg.Tag = "iconbutton5";
                frm.TopLevel = false;
                frm.Height = 530;
                frm.Width = 925;
                //frm3.Size = tpg.Size;
                tpg.Controls.Add(frm);
                frm.Show();

                tabControl1.TabPages.Add(tpg);

            }
            boutton2();
            boutton3();

            //  new Form8().ShowDialog(); // 폼 5


        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            ActiveteButton(sender, RGBcolors.color6);
            canclefuncion();
            bool tpgChk = false;

            int tpg_idx = 0;
            foreach (TabPage chk in tabControl1.TabPages)
            {
                if (chk.Name.Equals("adminstock"))
                {
                    tabControl1.SelectTab(tpg_idx);
                    chk.Show();
                    tpgChk = true;
                    return;
                }
                tpg_idx++;
            }

            if (!tpgChk)
            {
                TabPage tpg = new TabPage();
                t = Type.GetType("noex1.Form9");
                frm = Activator.CreateInstance(t) as Form;

                tpg.Name = "adminstock";
                tpg.Text = "재고관리";
                tpg.Tag = "iconbutton6";
                frm.TopLevel = false;
                frm.Height = 530;
                frm.Width = 925;
                //frm3.Size = tpg.Size;
                tpg.Controls.Add(frm);
                frm.Show();

                tabControl1.TabPages.Add(tpg);
            }
            // new Form9().ShowDialog(); // 폼 5 
        }

        private void btnhome1_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void Reset()
        {

            DisableButton();
            leftborderBtn.Visible = false;
            CurrentForm.Text = "HOME";
        }


     void boutton2()
        {
            iconButton8.Enabled = true;
            iconButton7.Enabled = false;
            iconButton9.Enabled = false;
            iconButton10.Enabled = false;
            iconButton11.Enabled = true;
            iconButton12.Enabled = true;
        }
        void boutton3()
        {
            iconButton8.Enabled = true;
            iconButton7.Enabled = true;
            iconButton9.Enabled = false;
            iconButton10.Enabled = true;
            iconButton11.Enabled = false;
            iconButton12.Enabled = false;
        }


       

    
        void buttonfuncion()
        {
            iconButton8.Enabled = true;
            iconButton7.Enabled = false;
            iconButton9.Enabled = false;
            iconButton10.Enabled = false;
            iconButton11.Enabled = true;
            iconButton12.Enabled = true;
        }
        void canclefuncion()
        {
            iconButton8.Enabled = true;
            iconButton7.Enabled = true;
            iconButton9.Enabled = true;
            iconButton10.Enabled = true;
            iconButton11.Enabled = false;
            iconButton12.Enabled = false;
        }
        void exhaust()
        {
            iconButton9.Enabled = false;
        }
        private void canbtn_Click(object sender, EventArgs e)
        {
            canclefuncion();
        }

 

        private void tabControl1_Resize(object sender, EventArgs e)
        {
            // tapage 사이즈 크기 맞게 
            foreach(TabPage pages in tabControl1.TabPages)
            {
                foreach(Form target in pages.Controls)
                {
                    target.Size = tabControl1.Size;
                }
            }
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
           Serch();
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {  // insert 값 불러오기
            codevalue = "I";
            Ins();
            buttonfuncion();
        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            //update 값 불러옴
            codevalue = "u";
            recare();
            
        }

        private void iconButton10_Click(object sender, EventArgs e)
        {
            //delete 값 불러옴
            codevalue = "d";
            delete();
            
        }

        private void iconButton11_Click(object sender, EventArgs e)
        {
            // 확인버튼 클릭시 불러옴
            confirm();
            canclefuncion();
        }

        private void iconButton12_Click(object sender, EventArgs e)
        {
            canclefuncion();
            
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Tag != null)
            {
                // 선택한 탭의 태그 값 가져오기
                string tagNm = tabControl1.SelectedTab.Tag.ToString();

                // 선택된 탭의 태그 이름과 일치한 버튼 가져오기
                Button btn = (Button)this.Controls.Find(tagNm, true).FirstOrDefault();
                t = Type.GetType("noex1." + btn.Tag.ToString());

                // 선택된 탭의 인덱스
                int tidx = tabControl1.SelectedIndex;

                // 선택된 탭 중에 버튼의 태그와 같은 이름을 가진 폼 가져오기
                frm = (Form)tabControl1.TabPages[tidx].Controls.Find(btn.Tag.ToString(), true).FirstOrDefault();

                // 버튼 색 변경
                ActiveteButton(btn, RGBcolors.color1);
            }
            else
            {
                //MessageBox.Show(t.ToString());
            }

            Console.WriteLine(t);
        //텝콘트롤 닫기버튼
        
        }
        
        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            // 마우스 클릭시 tabpage닫기 
            TabControl rc = (TabControl)sender;
            Point p = e.Location;
            int _tabWidth = 0;
            _tabWidth = this.tabControl1.GetTabRect(rc.SelectedIndex).Width - (_imgHitArea.X);
            Rectangle r = this.tabControl1.GetTabRect(rc.SelectedIndex);
            r.Offset(_tabWidth, _imgHitArea.Y);
            r.Width = 10;
            r.Height = 10;
            if(tabControl1.SelectedIndex>=1)
            {
                if(r.Contains(p))
                {
                    TabPage tabp = (TabPage)rc.TabPages[rc.SelectedIndex];
                    rc.TabPages.Remove(tabp);
                }
            }
        }
        

      
    }
}
