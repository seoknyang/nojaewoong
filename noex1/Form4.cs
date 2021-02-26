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
using System.IO;

namespace noex1
{
    public partial class Form4 : Form
    {

        Image img;
        byte[] b;
        Bitmap bitmap;
        OracleConnection con;
        OracleCommand cmd;
        OracleCommand cmd1;
        OracleCommand cmd2;
        bool dbimg = false;
        OracleTransaction STrans = null;
        String codevalue = "A";
        public Form4()
        {
            InitializeComponent();
        }

        private void btn4_Click(object sender, EventArgs e)
        {




            txt3.Text = "";
            txt4.Text = "";
            txt5.Text = "";
            txt3.Focus();
          
            codevalue = "I";
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            string connectString = "Data Source = 222.237.134.74:1522/ora7;User id=edu;Password=edu1234;";
            try
            {
                con = new OracleConnection(connectString);
                con.Open();

                if (con == null)
                {
                    MessageBox.Show("시스템에 문제가 생겼습니다. 담당자에게 연락하세요.");
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString());
                con.Close();
            }
            finally
            {
                txt6.Value = new DateTime(int.Parse(DateTime.Now.ToString("yyyy")),
                                        int.Parse(DateTime.Now.ToString("MM")),
                                        1);
            }
        }
        public bool insert()
        {
            codevalue = "I";
            return true;
        }

        public void look()
        {
            try
            {
                // 연동확인
                if (con == null)
                {
                    MessageBox.Show("연동안됨");
                    return;
                }
                //문장 만들기
                String sql1 = "select ITEM_CODE,ITEM_NAME,ITEM_STAND,ITEM_DATE,ITEM_AMT,ITEM_COMP,ITEM_SAMT,ITEM_POSI,ITEM_ETC,USER_SYSID"
                    + " from njwBITEM" + " where ITEM_CODE like :CODE and item_yn='N'";


                OracleDataReader dr;
                //여기까지 sql 전달
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = sql1;
                cmd.Parameters.Add("CODE", OracleDbType.Varchar2).Value = "%" + txt3.Text + "%";
                //sql 요청 - 실행결과 dr 받음
                dr = cmd.ExecuteReader();

                int rowldx = 0;
                DataGridViewRow row;
                dataGridView1.Rows.Clear(); // 중복안되게
                while (dr.Read()) // 데이터 여려개 읽을떄
                {
                    rowldx = dataGridView1.Rows.Add();
                    row = dataGridView1.Rows[rowldx];
                    row.Cells["column1"].Value = dr["ITEM_CODE"].ToString();
                    row.Cells["column2"].Value = dr["ITEM_NAME"].ToString();
                    row.Cells["column3"].Value = dr["ITEM_STAND"].ToString();
                    row.Cells["column4"].Value = dr["ITEM_DATE"].ToString();
                    row.Cells["column5"].Value = dr["ITEM_AMT"].ToString();
                    row.Cells["column6"].Value = dr["ITEM_COMP"].ToString();
                    row.Cells["column7"].Value = dr["ITEM_SAMT"].ToString();
                    row.Cells["column8"].Value = dr["ITEM_POSI"].ToString();
                    row.Cells["column9"].Value = dr["ITEM_ETC"].ToString();
                    row.Cells["column11"].Value = dr["USER_SYSID"].ToString();

                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message.ToString());
            }
            
        }


       
        public void okbtn_Click(string codeValue)
        {
         
            if (txt3.Text == "")
            {
                MessageBox.Show("물품코드를 입력해주세요");
            }
            STrans = con.BeginTransaction(IsolationLevel.ReadCommitted);
            try
            {
                if (codevalue == "I")
                {
                    String sql2 = "insert into njwBITEM(ITEM_code,ITEM_name,ITEM_stand,ITEM_date,ITEM_amt,ITEM_comp,ITEM_samt,ITEM_posi,ITEM_etc,USER_sysid)" +
                 " values(:code2,:name2,:stand2,:date2,:amt2,:comp2,:samt2,:posi2,:etc2,:sysid2)";
                    cmd1 = con.CreateCommand();
                    cmd1.CommandText = sql2;
                    cmd1.Parameters.Add("code2", OracleDbType.Varchar2).Value = txt3.Text;
                    cmd1.Parameters.Add("name2", OracleDbType.Varchar2).Value = txt4.Text;
                    cmd1.Parameters.Add("stand2", OracleDbType.Varchar2).Value = txt5.Text;
                    cmd1.Parameters.Add("date2", OracleDbType.Varchar2).Value = txt6.Text;
                    cmd1.Parameters.Add("amt2", OracleDbType.Varchar2).Value = txt7.Text;
                    cmd1.Parameters.Add("comp2", OracleDbType.Varchar2).Value = txt8.Text;
                    cmd1.Parameters.Add("samt2", OracleDbType.Varchar2).Value = txt9.Text;
                    cmd1.Parameters.Add("posi2", OracleDbType.Varchar2).Value = txt10.Text;
                    cmd1.Parameters.Add("etc2", OracleDbType.Varchar2).Value = txt11.Text;
                    cmd1.Parameters.Add("sysid2", OracleDbType.Varchar2).Value = txt13.Text;
                    cmd1.ExecuteNonQuery();// insert update delete만 nonQuery
                    MessageBox.Show("입력되었습니다.");

                    //이미지 삽입
                    cmd2 = con.CreateCommand();
                    string sqlimg = "insert into njwitem_img(item_code, item_img) values(:imgkey2,:img2)";
                    cmd2.CommandText = sqlimg;
                    cmd2.BindByName = true; //이름으로 참조 할수있음
                    cmd2.Parameters.Add("imgkey2", OracleDbType.Char).Value = txt3.Text;
                    cmd2.Parameters.Add("img2", OracleDbType.Blob, b.Length, b, ParameterDirection.Input);
                    cmd2.ExecuteNonQuery();
                    texte();
                }
                else
                {
                    string sqlimg;
                    if (codevalue == "u")
                    {
                        if (txt3.Text == "")
                        {
                            MessageBox.Show("품목코드 입력해주세요");
                            return;
                        }
                        if (txt4.Text == "")
                        {
                            MessageBox.Show("품목명 입력해주세요");
                            return;
                        }

                        String sql4 = "update njwBITEM set ITEM_name = :name2 ,ITEM_stand =:stand, ITEM_date=:date2,ITEM_amt=:amt,ITEM_comp=:comp,ITEM_samt=:samt,ITEM_posi=:posi,ITEM_etc=:etc" +
                            " where ITEM_code= :code";
                        cmd = con.CreateCommand();
                        cmd.CommandText = sql4;
                        DialogResult result1 = MessageBox.Show("수정하시겠습니까 ?", "수정확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result1 == DialogResult.No) return;
                        cmd.Parameters.Add("name2", OracleDbType.Varchar2).Value = txt4.Text;
                        cmd.Parameters.Add("stand", OracleDbType.Varchar2).Value = txt5.Text;
                        cmd.Parameters.Add("date2", OracleDbType.Varchar2).Value = txt6.Text;
                        cmd.Parameters.Add("amt", OracleDbType.Varchar2).Value = txt7.Text;
                        cmd.Parameters.Add("comp", OracleDbType.Varchar2).Value = txt8.Text;
                        cmd.Parameters.Add("smat", OracleDbType.Varchar2).Value = txt9.Text;
                        cmd.Parameters.Add("posi", OracleDbType.Varchar2).Value = txt10.Text;
                        cmd.Parameters.Add("etc", OracleDbType.Varchar2).Value = txt11.Text;
                        cmd.Parameters.Add("code", OracleDbType.Varchar2).Value = txt3.Text;
                        cmd.ExecuteNonQuery();// insert update delete만 nonQuery
                        grid_display();

                        if (b == null)
                        {


                        }
                        else
                        {
                            if (dbimg)
                            {
                                sqlimg = "update njwitem_img set item_img= :img2 where item_code = :key2";


                            }
                            else
                            {
                                sqlimg = "insert into njwitem_img values (:key2, :img2)";
                            }

                            cmd2 = con.CreateCommand();
                            cmd2.CommandText = sqlimg;
                            cmd2.BindByName = true; //이름으로 참조 할수있음
                            cmd2.Parameters.Add("img2", OracleDbType.Blob, b.Length, b, ParameterDirection.Input);
                            cmd2.Parameters.Add("key2", OracleDbType.Char).Value = txt3.Text;
                            cmd2.ExecuteNonQuery();
                        }
                        MessageBox.Show("수정되었습니다");
                        grid_display();
                        texte();
                        return;
                    }
                    else
                    {
                        if (codevalue == "d")
                        {

                            String delsql = "delete from njwBITEM where ITEM_code= :code2";


                            //여기까지 sql 전달

                            cmd1 = con.CreateCommand();
                            cmd1.CommandText = delsql;
                            cmd1.Parameters.Add("code2", OracleDbType.Varchar2).Value = txt3.Text;
                            //sql 요청 - 실행결과 dr 받음

                            DialogResult result = MessageBox.Show("삭제하시겠습니까 ?", "삭제확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.No) return;
                            MessageBox.Show("삭제되었습니다");
                            cmd1.ExecuteNonQuery();
                            grid_display();
                            texte();

                        }
                    }

                }
                STrans.Commit();
            }

            catch (Exception e)
            {
                STrans.Rollback();
                MessageBox.Show(e.Message.ToString());
            }
          
          

        }
        void grid_display()
        {
            if (con == null)
            {
                MessageBox.Show("연동안됨");
                return;
            }
            //문장 만들기
            String sql1 = "select ITEM_CODE,ITEM_NAME,ITEM_STAND,ITEM_DATE,ITEM_AMT,ITEM_COMP,ITEM_SAMT,ITEM_POSI,ITEM_ETC,USER_SYSID"
                + " from njwBITEM" + " where ITEM_CODE like :CODE";

            OracleDataReader dr;
            //OracleDataReader dr;
            //여기까지 sql 전달
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = sql1;
            cmd.Parameters.Add("CODE", OracleDbType.Varchar2).Value = "%" + txt3.Text + "%";
            //sql 요청 - 실행결과 dr 받음
            dr = cmd.ExecuteReader();

            int rowldx = 0;
            DataGridViewRow row;
            dataGridView1.Rows.Clear(); // 중복안되게
            while (dr.Read()) // 데이터 여려개 읽을떄
            {
                rowldx = dataGridView1.Rows.Add();
                row = dataGridView1.Rows[rowldx];
                row.Cells["column1"].Value = dr["ITEM_CODE"].ToString();
                row.Cells["column2"].Value = dr["ITEM_NAME"].ToString();
                row.Cells["column3"].Value = dr["ITEM_STAND"].ToString();
                row.Cells["column4"].Value = dr["ITEM_DATE"].ToString();
                row.Cells["column5"].Value = dr["ITEM_AMT"].ToString();
                row.Cells["column6"].Value = dr["ITEM_COMP"].ToString();
                row.Cells["column7"].Value = dr["ITEM_SAMT"].ToString();
                row.Cells["column8"].Value = dr["ITEM_POSI"].ToString();
                row.Cells["column9"].Value = dr["ITEM_ETC"].ToString();

                row.Cells["column11"].Value = dr["USER_SYSID"].ToString();

            }

        }

        void texte()
        {
            txt3.Text = "";
            txt4.Text = "";
            txt5.Text = "";
            txt6.Text = "";
            txt7.Text = "";
            txt8.Text = "";
            txt9.Text = "";
            txt10.Text = "";
            txt11.Text = "";
            
            txt13.Text = "";
            pictureBox1.Image = null;
        }
        public bool rebtn_Click()
        {
            try
            {
                if (txt3.Text == "")
                {
                    MessageBox.Show("품목코드 입력해주세요");
                    return false;
                }
                // 아이디 있다고 판단
                String sql3 = "select a.ITEM_code,ITEM_name,ITEM_stand,ITEM_date,ITEM_amt,ITEM_comp,ITEM_samt,ITEM_posi,ITEM_etc,User_sysid, b.item_img from njwBITEM a, njwitem_img b where a.ITEM_code =:code and a.item_code = b.item_code(+)";
                //sql 로 물어봄
                OracleDataReader dr;
                //여기까지 sql 전달
                cmd = con.CreateCommand();
                cmd.CommandText = sql3;
                cmd.Parameters.Add("code", OracleDbType.Varchar2).Value = txt3.Text;
                //sql 요청 - 실행결과 dr 받음
                dr = cmd.ExecuteReader();
                if (dr.Read())// dr 읽을떄 
                {
                    //sql로 찾아본 아이디가 있으면 텍스트 박스에 뿌려줌
                    txt4.Text = dr["ITEM_name"].ToString();
                    txt5.Text = dr["ITEM_stand"].ToString();
                    txt6.Text = dr["ITEM_date"].ToString();
                    txt7.Text = dr["ITEM_amt"].ToString();
                    txt8.Text = dr["ITEM_comp"].ToString();
                    txt9.Text = dr["ITEM_samt"].ToString();
                    txt10.Text = dr["ITEM_posi"].ToString();
                    txt11.Text = dr["ITEM_etc"].ToString();
                  
                    txt13.Text = dr["user_sysid"].ToString();
                    dbimg = (DBNull.Value.Equals(dr["item_img"])) ? false : true;

                }
                else
                {
                    //sql 아이디가 없음
                    MessageBox.Show("품목코드가없습니다.");
                }
                MessageBox.Show("수정을 클릭했습니다");
                codevalue = "u";
              

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message.ToString());
            }
            return true;


        }

        private void canbtn_Click(object sender, EventArgs e)
        {
          
            codevalue = "a";

        }

        public bool deletebtn_Click()
        {
            try
            {
                if (txt3.Text == "")
                {
                    MessageBox.Show("품목코드 입력해주세요");
                    return false;

                }
                // 아이디 있다고 판단
                String sql5 = "select ITEM_code,ITEM_name,ITEM_stand,ITEM_date,ITEM_amt,ITEM_comp,ITEM_samt,ITEM_posi,ITEM_etc,User_sysid from njwBITEM where ITEM_code =:code";
                //sql 로 물어봄
                OracleDataReader dr;
                //여기까지 sql 전달
                cmd = con.CreateCommand();
                cmd.CommandText = sql5;
                cmd.Parameters.Add("code", OracleDbType.Varchar2).Value = txt3.Text;
                //sql 요청 - 실행결과 dr 받음
                dr = cmd.ExecuteReader();
                if (dr.Read())// dr 읽을떄 
                {
                    //sql로 찾아본 아이디가 있으면 텍스트 박스에 뿌려줌
                    txt4.Text = dr["ITEM_name"].ToString();
                    txt5.Text = dr["ITEM_stand"].ToString();
                    txt6.Text = dr["ITEM_date"].ToString();
                    txt7.Text = dr["ITEM_amt"].ToString();
                    txt8.Text = dr["ITEM_comp"].ToString();
                    txt9.Text = dr["ITEM_samt"].ToString();
                    txt10.Text = dr["ITEM_posi"].ToString();
                    txt11.Text = dr["ITEM_etc"].ToString();
                    txt13.Text = dr["user_sysid"].ToString();
                }

                else
                {
                    //sql 아이디가 없음
                    MessageBox.Show("품목코드가없어요");
                    return false;

                }



                codevalue = "d";
               
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());

            }
            return true;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //쓰면 안됨
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string image_file = "";
            OpenFileDialog dialog = new OpenFileDialog(); // 이미지 선택하기위해 다이얼로그 생성
            dialog.InitialDirectory = @"C|"; // C드라이브로 세팅
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //선택된 파일이름으로 저장
                image_file = dialog.FileName;
                //선택한 파일을 image로 변환
                img = Bitmap.FromFile(image_file);
                ImageConverter converter = new ImageConverter();
                b = (byte[])converter.ConvertTo(img, typeof(byte[]));
                if (b.Length >= Math.Pow(2, 10) * 30)
                {
                    MessageBox.Show("사진등록안됨 ");
                    return;
                }
                pictureBox1.Image = Bitmap.FromFile(image_file);//picturebox 컨트롤에 선택한 이미지 넣기

            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt3.Text = (string)dataGridView1.Rows[e.RowIndex].Cells["Column1"].Value;
            txt4.Text = (string)dataGridView1.Rows[e.RowIndex].Cells["Column2"].Value;
            txt5.Text = (string)dataGridView1.Rows[e.RowIndex].Cells["Column3"].Value;
            txt6.Text = (string)dataGridView1.Rows[e.RowIndex].Cells["Column4"].Value;
            txt7.Text = (string)dataGridView1.Rows[e.RowIndex].Cells["Column5"].Value;
            txt8.Text = (string)dataGridView1.Rows[e.RowIndex].Cells["Column6"].Value;
            txt9.Text = (string)dataGridView1.Rows[e.RowIndex].Cells["Column7"].Value;
            txt10.Text = (string)dataGridView1.Rows[e.RowIndex].Cells["Column8"].Value;
            txt11.Text = (string)dataGridView1.Rows[e.RowIndex].Cells["Column9"].Value;
            txt13.Text = (string)dataGridView1.Rows[e.RowIndex].Cells["Column11"].Value;

            String imgsql = " select item_img from njwitem_img where item_code = :imgkey";
            OracleCommand cmd = con.CreateCommand();
            OracleDataReader dr;

            cmd.CommandText = imgsql;
            cmd.Parameters.Add("imgkey", OracleDbType.Varchar2).Value = txt3.Text;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                pictureBox1.Image = new Bitmap(new MemoryStream((byte[])dr["item_img"]));
            }
            else
            {
                pictureBox1.Image = null;
            }

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

  }
