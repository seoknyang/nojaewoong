using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace noex1
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        Form3 adminForm = new Form3();
        Form4 bitem = new Form4();
        private void button1_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Add("관리자페이지");
            treeView1.Nodes.Add("입고관리");
            treeView1.Nodes.Add("출고관리");

            treeView1.Nodes[0].Nodes.Add("관리자페이지1");
            treeView1.Nodes[0].Nodes.Add("관리자페이지2");
            treeView1.Nodes[0].Nodes.Add("관리자페이지3");

            treeView1.Nodes[1].Nodes.Add("입고관리1");
            treeView1.Nodes[1].Nodes.Add("입고관리2");
            treeView1.Nodes[1].Nodes.Add("입고관리3");

        }
        private Form formIsExist(Type tp)
        {
            foreach (Form form in Application.OpenForms)
            {
                if(form.GetType()==tp)
                {
                    return form;
                }
                else
                {

                }
            }
            return null;
        }
        
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        { //노드를 클릭시 노드실행
            String node = e.Node.Name;
            switch(node)
            {
                case "관리자페이지":
                    if(formIsExist(typeof(Form3)) == null)
                    {
                        TabPage mypage = new TabPage("관리자설정");//tab 컨트롤에서 제목 설정
                        adminForm.TopLevel = false; // 페이지 만듬
                        adminForm.Size = tabControl1.Size;

                        mypage.Controls.Add(adminForm);
                        tabControl1.TabPages.Add(mypage);
                        tabControl1.SelectedTab = mypage;
                        adminForm.Show();

                    }
                    else
                    {
                        MessageBox.Show("폼이 열려있습니다.");
                    }
                    break;
            }
            switch(node)
            {
                case "물품정보":
                    if (formIsExist(typeof(Form4)) == null)
                    {
                        TabPage mypage = new TabPage("물품정보");
                        bitem.TopLevel = false;
                        bitem.Size = tabControl1.Size;

                        mypage.Controls.Add(bitem);
                        tabControl1.TabPages.Add(mypage);
                        tabControl1.SelectedTab = mypage;
                        bitem.Show();
                    }
                    else
                    {
                        MessageBox.Show("폼이 열려있습니다.");
                    }
                    break;
            }
           
            
        }

    

        private void tabControl1_Resize(object sender, EventArgs e)
        {
            adminForm.Size = tabControl1.Size;
        }
    }
}
