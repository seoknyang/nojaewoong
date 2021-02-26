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
using System.Reflection;
namespace noex1
{

    public partial class Form2 : Form
    {
        OracleConnection con = null;
        OracleCommand cmd;
        bool closeMessage = false;
        bool msgOpen = true;
        public Form2()
        {
            InitializeComponent();
           
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    


      

        private void logout_Click(object sender, EventArgs e)
        {
            if (name.Text == "")
            {
                MessageBox.Show("아이디 입력해주세요");
                return;
            }
            if (pass.Text == "")
            {
                MessageBox.Show("비밀번호 입력해주세요");
                return;
            }
            // 아이디 있다고 판단
            String sql3 = "select admin_name, admin_pass from njwadmin where admin_id =:id";
            //sql 로 물어봄
            OracleDataReader dr;
            String dbpass = null;

            try
            {
                //여기까지 sql 전달
                cmd = con.CreateCommand();
                cmd.CommandText = sql3;
                cmd.Parameters.Add("id", OracleDbType.Varchar2).Value = name.Text; //문제가능성있음
                //sql 요청 - 실행결과 dr 받음
                dr = cmd.ExecuteReader();
                if (dr.Read())// dr 읽을떄 
                {

                    //sql로 찾아본아이디가 있으면 입력된 비밀번호와 등록된 비밀번호가 같은지 
                    //
                    dbpass = dr["admin_pass"].ToString();

                    if (dbpass.Equals(pass.Text))// 비밀번호 같은지판단
                    {
                        msgOpen = false;
                        this.Close(); // form2 로그인창을 닫음
                    }
                    else
                    {
                        MessageBox.Show("비밀번호가 다릅니다");
                    }


                }
                else
                {
                    //sql 아이디가 없음
                    MessageBox.Show("아이디가없습니다.");
                }

            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString());
                con.Close();
            }
            finally
            {


            }
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string connectString = "Data Source = 222.237.134.74:1522/ora7;User Id=edu;Password=edu1234";

            try
            {
                con = new OracleConnection(connectString);
                con.Open();

                if (con == null)
                {
                    MessageBox.Show("데이터베이스 연결 실패했습니다.");
                }

            }
            catch(Exception e1)
            {
                MessageBox.Show(e1.ToString()); // 어떤 에러인지 보여줌
                con.Close(); // db 연동 해제
            }
            finally
            {
               
            }

            //try catch 



        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!closeMessage && msgOpen)
            {
                DialogResult result = MessageBox.Show("종료하시겠습니까 ?", "종료확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    closeMessage = true;
                    e.Cancel = false;
                    Application.Exit();
                    return;
                }
                else
                {
                    e.Cancel = true;
                    closeMessage = false;
                    return;
                }
            }
        }

        private void pass_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                logout_Click(sender, e);
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
