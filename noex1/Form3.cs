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
    public partial class Form3 : Form
    {
        OracleConnection con = null;
        OracleCommand cmd;
        OracleCommand cmd1;
        OracleCommand cmd2;
        Image img;
        byte[] b;
        Bitmap bitmap;
        OracleTransaction STrans = null;
        bool dbimg = false;

        String codevalue = "a";


        public Form3()
        {
            InitializeComponent();
        }
        public void look()
        {
            if (txtid.Text == " ")
            {
                MessageBox.Show("관리자id를 입력하세요");
                return;
            }
            try
            {
                String sql1 = "SELECT admin_id,admin_pass,admin_name FROM njwadmin" +
                         " WHERE admin_name like : name";
                OracleDataReader dr;
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = sql1;
                cmd.Parameters.Add("name", OracleDbType.Varchar2).Value = "%" + txtname.Text + "%";
                dr = cmd.ExecuteReader();

                int rowidx = 0;
                DataGridViewRow row;
                dataGridView1.Rows.Clear();
                while (dr.Read())
                {
                    rowidx = dataGridView1.Rows.Add();
                    row = dataGridView1.Rows[rowidx];
                    row.Cells["Column1"].Value = dr["admin_id"].ToString();
                    row.Cells["Column2"].Value = dr["admin_pass"].ToString();
                    row.Cells["Column3"].Value = dr["admin_name"].ToString();

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());

            }

        }
        public bool insert()
        {
            codevalue = "I";
            return true;

        }

        private void Form3_Load(object sender, EventArgs e)
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

        }

        void clear()
        {
            pictureBox1.Image = null;
            txtid.Text = "";
            txtpass.Text = "";
            txtname.Text = "";
        }

        public void okbtn_Click(string codeValue)
        {
            //확인버튼 클릭시 
            //코드값이 i면 인서트
            //코드값이 u면 업데이트
            //코드값이 d면 델리트

            if (txtid.Text == "")
            {
                MessageBox.Show("관리자 아이디를 입력하세요");
                return;
            }
            if (txtpass.Text == "")
            {
                MessageBox.Show("비밀번호를 입력하세요");
                return;
            }
            if (txtname.Text == "")
            {
                MessageBox.Show("관리자 이름을 입력하세요");
                return;
            }
            //트렌젝션 시작
            STrans = con.BeginTransaction(IsolationLevel.ReadCommitted);
            try
            {
                if (codeValue == "I")
                {
                  //  String sqlfind = null;
                    //관리자 아이디가 있는지판단하고 있으면 경고문띄워주기 없으면 인서트실행
                    cmd2 = con.CreateCommand();
                    cmd2.CommandText = "SELECT * FROM njwadmin, njwadmin_img WHERE admin_id = :id and imgkey(+) = admin_id";
                    OracleDataReader dr;
                    cmd2.Parameters.Add("id", OracleDbType.Varchar2).Value = txtid.Text;
                    dr = cmd2.ExecuteReader();

                    if (dr.Read())
                    {
                        MessageBox.Show("등록된 아이디가 있습니다.");
                        return;
                    }
                    else
                    {
                        cmd = con.CreateCommand();
                        cmd.Transaction = STrans;

                        String sql2 = "INSERT INTO njwadmin(admin_id,admin_pass,admin_name) VALUES(:id2, :pass2, :name2)";
                        cmd.CommandText = sql2;
                        cmd.Parameters.Add("id2", OracleDbType.Varchar2).Value = txtid.Text;
                        cmd.Parameters.Add("pass2", OracleDbType.Varchar2).Value = txtpass.Text;
                        cmd.Parameters.Add("name2", OracleDbType.Varchar2).Value = txtname.Text;
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();

                        string sqlimg = "insert into njwadmin_img(imgkey,img1) values(:imgkey2,:img2)";
                        cmd.CommandText = sqlimg;
                        cmd.BindByName = true; //이름으로 참조 할수있음
                        cmd.Parameters.Add("imgkey2", OracleDbType.Varchar2).Value = txtid.Text;
                        cmd.Parameters.Add("img2", OracleDbType.Blob, b.Length, b, ParameterDirection.Input);
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();

                        MessageBox.Show("입력되었습니다.");
                    }
                   
                    txtid.Focus();
                }
                grid_display();
                STrans.Commit();
            }
            catch (Exception e)
            {
                STrans.Rollback();
                MessageBox.Show(e.Message+"관리자에게 전화해주세요 000-0000-0000");
            }
        

            if (codeValue == "u")
                {
                    //꼭 수정할껀지 물어봐야함
                    DialogResult result = MessageBox.Show("수정하시게습니까 ?", "수정확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No) return;

                    String updatesql = "update njwadmin set admin_name = :name ,admin_pass =:pass where admin_id = :id";

                    cmd = con.CreateCommand();
                    cmd.CommandText = updatesql;
                    cmd.Parameters.Add("name", OracleDbType.Varchar2).Value = txtname.Text;
                    cmd.Parameters.Add("pass", OracleDbType.Varchar2).Value = txtpass.Text;
                    cmd.Parameters.Add("id", OracleDbType.Varchar2).Value = txtid.Text;
                    cmd.ExecuteNonQuery();// insert update delete만 nonQuery  

                    string sqlimg;
                    if (b != null)
                    {
                        if (dbimg)
                        {
                            sqlimg = "update njwadmin_img set img1= :img2 where imgkey = :key2";

                        }
                        else
                        {
                            sqlimg = "insert into njwadmin_img values (:key2, :img2)";
                        }
                        cmd2 = con.CreateCommand();
                        cmd2.CommandText = sqlimg;
                        cmd2.BindByName = true; //이름으로 참조 할수있음
                        cmd2.Parameters.Add("img2", OracleDbType.Blob, b.Length, b, ParameterDirection.Input);
                        cmd2.Parameters.Add("key2", OracleDbType.Char).Value = txtid.Text;
                        cmd2.ExecuteNonQuery();
                    }

                    MessageBox.Show("수정되었습니다");
                }


                if (codeValue == "d")
                {
                    String deletesql = "delete from njwadmin where admin_id = :id";

                    OracleDataReader dr;
                    //여기까지 sql 전달
                    cmd = con.CreateCommand();
                    cmd.CommandText = deletesql;
                    cmd.Parameters.Add("id", OracleDbType.Varchar2).Value = txtid.Text;
                    //sql 요청 - 실행결과 dr 받음
                    dr = cmd.ExecuteReader();

                    String delsql2 = "delete from njwadmin_img where imgkey = :key2";

                    OracleDataReader dr2;
                    //여기까지 sql 전달
                    cmd1 = con.CreateCommand();
                    cmd1.CommandText = delsql2;
                    cmd1.Parameters.Add("id", OracleDbType.Varchar2).Value = txtid.Text;
                    //sql 요청 - 실행결과 dr 받음
                    dr2 = cmd.ExecuteReader();

                    DialogResult result = MessageBox.Show("삭제하시겠습니까 ?", "삭제확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No) return;
                    MessageBox.Show("삭제되었습니다.");
                }

                clear();
                //grid_display();

        }
        void grid_display()
        {
            //조회되는 내용 
            if (txtid.Text == " ")
            {
                MessageBox.Show("관리자id를 입력하세요");
                return;
            }
            String sql1 = "SELECT admin_id,admin_pass,admin_name FROM njwadmin" +
                         " WHERE admin_name like : name";
            OracleDataReader dr;
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = sql1;
            cmd.Parameters.Add("name", OracleDbType.Varchar2).Value = "%" + txtid.Text + "%";
            dr = cmd.ExecuteReader();
            int rowidx = 0;
            DataGridViewRow row;
            dataGridView1.Rows.Clear();
            while (dr.Read())
            {
                rowidx = dataGridView1.Rows.Add();
                row = dataGridView1.Rows[rowidx];
                row.Cells["Column1"].Value = dr["admin_id"].ToString();
                row.Cells["Column2"].Value = dr["admin_pass"].ToString();
                row.Cells["Column3"].Value = dr["admin_name"].ToString();

            }
        }

        public bool rebtn_Click()
        {
            if (txtid.Text == "")
            {
                MessageBox.Show("아이디 입력해주세요");
                return false;
            }
            try
            {

                // 아이디 있다고 판단
                String sql3 = "select admin_id admin_name,admin_pass,img1  from njwadmin, njwadmin_img where admin_id =:id and admin_id = imgkey(+)";
                //sql 로 물어봄
                OracleDataReader dr;
                //여기까지 sql 전달
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = sql3;
                cmd.Parameters.Add("id", OracleDbType.Varchar2).Value = txtid.Text;
                //sql 요청 - 실행결과 dr 받음
                dr = cmd.ExecuteReader();
                if (dr.Read())// dr 읽을떄 
                {
                    //sql로 찾아본 아이디가 있으면 텍스트 박스에 뿌려줌
                    txtpass.Text = dr["admin_pass"].ToString();
                    txtname.Text = dr["admin_name"].ToString();
                    dbimg = (DBNull.Value.Equals(dr["img1"])) ? false : true;
                }
                else
                {
                    //sql 아이디가 없음
                    MessageBox.Show("아이디가없습니다.");
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }

            codevalue = "u";
            return true;

        }

        public bool deletebtn_Click()
        {
            try
            {
                if (txtid.Text == "")
                {
                    MessageBox.Show("아이디 입력해주세요");
                    return false;
                }
                // 아이디 있다고 판단
                String sql6 = "select admin_id admin_name,admin_pass" + " from njwadmin" + " where admin_id =:id";
                //sql 로 물어봄
                OracleDataReader dr;
                //여기까지 sql 전달
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = sql6;
                cmd.Parameters.Add("id", OracleDbType.Varchar2).Value = txtid.Text;
                //sql 요청 - 실행결과 dr 받음
                dr = cmd.ExecuteReader();
                if (dr.Read())// dr 읽을떄 
                {
                    //sql로 찾아본 아이디가 있으면 텍스트 박스에 뿌려줌
                    txtpass.Text = dr["admin_pass"].ToString();
                    txtname.Text = dr["admin_name"].ToString();
                }
                else
                {
                    //sql 아이디가 없음
                    MessageBox.Show("아이디가없어요");
                    return false;
                }

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message.ToString());
            }
            MessageBox.Show("삭제버튼을 클릭하셨습니다.");
            codevalue = "d";
            return true;
        }

        private void canbtn1_Click(object sender, EventArgs e)
        {
            clear();

            codevalue = "a";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //그리드르 아무데서나 클릭하면 동작함
            //MessageBox.Show(e.RowIndex.ToString()); // 몇번쨰 줄에서 이벤트가 발생했는지 알수있다
            // 더블클릭하면 텍스트 박스에 데이터 들어감
            txtid.Text = (string)dataGridView1.Rows[e.RowIndex].Cells["Column1"].Value;
            txtpass.Text = (string)dataGridView1.Rows[e.RowIndex].Cells["Column2"].Value;
            txtname.Text = (string)dataGridView1.Rows[e.RowIndex].Cells["Column3"].Value;
            String imgsql = " select img1 from njwadmin_img where imgkey = :imgkey";
            OracleCommand cmd = con.CreateCommand();
            OracleDataReader dr;

            cmd.CommandText = imgsql;
            cmd.Parameters.Add("imgkey", OracleDbType.Varchar2).Value = txtid.Text;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                pictureBox1.Image = new Bitmap(new MemoryStream((byte[])dr["img1"]));
            }
            else
            {
                pictureBox1.Image = null;
            }

        }


        private void imgbtn_Click(object sender, EventArgs e)
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

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dataGridView1.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }


    }
}
