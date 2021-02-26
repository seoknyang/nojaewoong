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
    public partial class Form7 : Form
    {
        OracleConnection con = null;
        OracleCommand cmd;
        OracleCommand cmd1;
        OracleCommand cmd2;
        String codevalue = "a";
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
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
                txtday1.Value = new DateTime(int.Parse(DateTime.Now.ToString("yyyy")),
                                        int.Parse(DateTime.Now.ToString("MM")),
                                        1);
                txtdate.Value = new DateTime(int.Parse(DateTime.Now.ToString("yyyy")),
                                        int.Parse(DateTime.Now.ToString("MM")),
                                        1);
            }
        }
        public void look()
        {
            try
            {
                string culgosql = "select a.cul_code,b.item_name, b.item_samt, a.cul_amt, a.cul_cnt, a.cul_date, a.cul_sau, a.user_sys,a.user_sysid from njwculgo a,njwBITEM b" +
              " where a.cul_code = b.item_code(+)" +
              " and b.item_name like :name" +
              " and a.cul_sau like :sau" +
              " and a.cul_date >= :d1" +
              " and a.cul_date <= :d2 and b.item_yn='N'";


                OracleDataReader dr;
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = culgosql;


                cmd.Parameters.Add("name", OracleDbType.Varchar2).Value = "%" + txtname.Text + "%";
                cmd.Parameters.Add("sau", OracleDbType.Varchar2).Value = "%" + txtcomp.Text + "%";
                cmd.Parameters.Add("d1", OracleDbType.Varchar2).Value = txtday1.Text;
                cmd.Parameters.Add("d2", OracleDbType.Varchar2).Value = txtday2.Text;

                dr = cmd.ExecuteReader();
                int rowidx = 0;
                DataGridViewRow row;
                dataGridView1.Rows.Clear();
                while (dr.Read())
                {

                    rowidx = dataGridView1.Rows.Add();
                    row = dataGridView1.Rows[rowidx];
                    row.Cells["Column1"].Value = dr["cul_code"].ToString();
                    row.Cells["Column2"].Value = dr["item_name"].ToString();
                    row.Cells["Column3"].Value = dr["item_samt"].ToString();
                    row.Cells["Column6"].Value = dr["cul_date"].ToString();
                    row.Cells["Column5"].Value = dr["cul_cnt"].ToString();
                    row.Cells["Column4"].Value = dr["cul_amt"].ToString();
                    row.Cells["Column7"].Value = dr["cul_sau"].ToString();
                    row.Cells["Column9"].Value = dr["user_sys"].ToString();
                    row.Cells["Column8"].Value = dr["user_sysid"].ToString();

                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message.ToString());
            }
          
        }
    
     
        private void button1_Click(object sender, EventArgs e)
        {
            Form6 frm = new Form6();
            frm.Owner = this;
            frm.ShowDialog();
            
        }
        public void insert()
        {
            codevalue = "I";
        }
      
        public void okbtn_Click(string codeValue)
        {
            try
            {
                String sqlfind = null;
                //확인버튼 클릭시 
                //코드값이 i면 인서트
                //코드값이 u면 업데이트
                //코드값이 d면 델리트
                //관리자 아이디가 있는지판단하고 있으면 경고문띄워주기 없으면 인서트실행
                sqlfind = "SELECT * FROM njwculgo WHERE cul_code = :code and cul_date=:date2";
                OracleDataReader dr;
                cmd = con.CreateCommand();
                cmd.CommandText = sqlfind;
                cmd.Parameters.Add("code", OracleDbType.Varchar2).Value = txtcode.Text;
                cmd.Parameters.Add("date2", OracleDbType.Varchar2).Value = txtdate.Text;
                dr = cmd.ExecuteReader();

                if (codevalue == "I")
                {
                    if (!dr.Read())
                    {
                        String sql2 = "INSERT INTO njwculgo(cul_code,cul_date,cul_amt,cul_sau,cul_cnt) VALUES(:code2, :date2, :amt2,:sau2,:cnt2)";
                        cmd1 = con.CreateCommand();
                        cmd1.CommandText = sql2;
                        cmd1.Parameters.Add("code2", OracleDbType.Varchar2).Value = txtcode.Text;
                        cmd1.Parameters.Add("date2", OracleDbType.Varchar2).Value = txtdate.Text;
                        cmd1.Parameters.Add("amt2", OracleDbType.Varchar2).Value = txtamt.Text;
                        cmd1.Parameters.Add("sau2", OracleDbType.Varchar2).Value = txtsau1.Text;
                        cmd1.Parameters.Add("cnt2", OracleDbType.Varchar2).Value = txtcnt.Text;

                        cmd1.ExecuteNonQuery();

                        cmd = null;

                        String sql3 = "update njwBITEM set item_samt = item_samt - :samt2 where item_code = :code2";
                        cmd = con.CreateCommand();
                        cmd.CommandText = sql3;
                        cmd.BindByName = true;
                        cmd.Parameters.Add("code2", OracleDbType.Varchar2).Value = txtcode.Text;
                        cmd.Parameters.Add("samt2", OracleDbType.Varchar2).Value = txtamt.Text;
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("입력되었습니다.");
                    }
                    else
                    {
                        MessageBox.Show("입력된 물품정보가없습니다.");
                        return;
                    }
                    clear();
                    grid_display();

                }

                if (codevalue == "u")
                {


                    String sql5 = "update njwBITEM set ITEM_samt = item_samt + :samt - :samt2 where item_code = :code2";

                    cmd = con.CreateCommand();
                    cmd.CommandText = sql5;
                    cmd.BindByName = true;
                    cmd.Parameters.Add("samt", OracleDbType.Varchar2).Value = textBox1.Text;
                    cmd.Parameters.Add("samt2", OracleDbType.Varchar2).Value = txtamt.Text;
                    cmd.Parameters.Add("code2", OracleDbType.Varchar2).Value = txtcode.Text;
                    cmd.ExecuteNonQuery();// insert update delete만 nonQuery  

                    String sql6 = "update njwculgo set cul_amt=:amt2,cul_sau=:sau2,cul_cnt=:cnt2 where cul_code=:code2 and cul_date=:date2";
                    cmd1 = con.CreateCommand();
                    cmd1.CommandText = sql6;
                    cmd1.BindByName = true;
                    cmd1.Parameters.Add("code2", OracleDbType.Varchar2).Value = txtcode.Text;
                    cmd1.Parameters.Add("date2", OracleDbType.Varchar2).Value = txtdate.Text;
                    cmd1.Parameters.Add("amt2", OracleDbType.Varchar2).Value = txtamt.Text;
                    cmd1.Parameters.Add("cnt2", OracleDbType.Varchar2).Value = txtcnt.Text;
                    cmd1.Parameters.Add("sau2", OracleDbType.Varchar2).Value = txtsau1.Text;
                    cmd1.ExecuteNonQuery();// insert update delete만 nonQuery  
                    DialogResult result = MessageBox.Show("수정하시겠습니까 ?", "수정확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No) return;
                    MessageBox.Show("수정되었습니다");


                    clear();
                    grid_display();
                }

                if (codevalue == "d")
                {


                    DialogResult result = MessageBox.Show("삭제하시겠습니까 ?", "삭제확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No) return;




                    String deletesql = "delete from njwculgo where cul_code = :code and cul_date =:date2";

                    OracleDataReader dr1;
                    //여기까지 sql 전달
                    cmd = con.CreateCommand();
                    cmd.CommandText = deletesql;
                    cmd.Parameters.Add("code", OracleDbType.Varchar2).Value = txtcode.Text;
                    cmd.Parameters.Add("date2", OracleDbType.Varchar2).Value = txtdate.Text;


                    //sql 요청 - 실행결과 dr 받음
                    dr1 = cmd.ExecuteReader();

                    String delsql2 = "update njwBITEM set ITEM_samt = item_samt + :samt2 where item_code = :code2";

                    OracleDataReader dr2;
                    //여기까지 sql 전달
                    cmd1 = con.CreateCommand();
                    cmd1.BindByName = true;
                    cmd1.CommandText = delsql2;
                    cmd1.Parameters.Add("code2", OracleDbType.Varchar2).Value = txtcode.Text;
                    cmd1.Parameters.Add("samt2", OracleDbType.Varchar2).Value = txtamt.Text;
                    //sql 요청 - 실행결과 dr 받음
                    cmd1.ExecuteNonQuery();

                    MessageBox.Show("삭제되었습니다.");

                    clear();
                    grid_display();



                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message.ToString());
            }
           


        }
        void clear()
        {
            txtcode.Text = "";
            txtname1.Text = "";
            txtamt.Text = "";
            txtdate.Text = "";

            textBox1.Text = "";
            txtsamt.Text = "";
            txtsau1.Text = "";
            txtcnt.Text = "";
        }
      

        public bool rebtn_Click()
        {
            codevalue = "u";
            return true;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcode.Text = (string)dataGridView1.Rows[e.RowIndex].Cells["Column1"].Value;
            txtname1.Text = (string)dataGridView1.Rows[e.RowIndex].Cells["Column2"].Value;
            txtsamt.Text = (string)dataGridView1.Rows[e.RowIndex].Cells["Column3"].Value;
            txtamt.Text = (string)dataGridView1.Rows[e.RowIndex].Cells["Column4"].Value;
            textBox1.Text = (string)dataGridView1.Rows[e.RowIndex].Cells["Column4"].Value;
           
            txtcnt.Text = (string)dataGridView1.Rows[e.RowIndex].Cells["Column5"].Value;
            txtdate.Text = (string)dataGridView1.Rows[e.RowIndex].Cells["Column6"].Value;
            txtsau1.Text = (string)dataGridView1.Rows[e.RowIndex].Cells["Column7"].Value;

        }
        void grid_display()
        {
            string culgosql = "select a.cul_code,b.item_name, b.item_samt, a.cul_amt, a.cul_cnt, a.cul_date, a.cul_sau, a.user_sys,a.user_sysid from njwculgo a,njwBITEM b" +
                " where a.cul_code = b.item_code(+)" +
                " and b.item_name like :name" +
                " and a.cul_sau like :sau" +
                " and a.cul_date >= :d1" +
                " and a.cul_date <= :d2 and b.item_yn='N'";


            OracleDataReader dr;
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = culgosql;


            cmd.Parameters.Add("name", OracleDbType.Varchar2).Value = "%" + txtname.Text + "%";
            cmd.Parameters.Add("sau", OracleDbType.Varchar2).Value = "%" + txtcomp.Text + "%";
            cmd.Parameters.Add("d1", OracleDbType.Varchar2).Value = txtday1;
            cmd.Parameters.Add("d2", OracleDbType.Varchar2).Value = txtday2;

            dr = cmd.ExecuteReader();
            int rowidx = 0;
            DataGridViewRow row;
            dataGridView1.Rows.Clear();
            while (dr.Read())
            {
                rowidx = dataGridView1.Rows.Add();
                row = dataGridView1.Rows[rowidx];
                row.Cells["Column1"].Value = dr["cul_code"].ToString();
                row.Cells["Column2"].Value = dr["item_name"].ToString();
                row.Cells["Column3"].Value = dr["item_samt"].ToString();
                row.Cells["Column6"].Value = dr["cul_date"].ToString();
                row.Cells["Column5"].Value = dr["cul_cnt"].ToString();
                row.Cells["Column4"].Value = dr["cul_amt"].ToString();
                row.Cells["Column7"].Value = dr["cul_sau"].ToString();
                row.Cells["Column9"].Value = dr["user_sys"].ToString();
                row.Cells["Column8"].Value = dr["user_sysid"].ToString();

            }
        }
      
     

        public bool deletebtn_Click()
        {
            codevalue = "d";
            return true;
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
