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
    public partial class Form8 : Form
    {
        String codevalue = "A";
        OracleConnection con = null;
        OracleCommand cmd;
        OracleCommand cmd1;
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            string connectString = "Data Source = 222.237.134.74:1522/ora7;User id=edu;Password=edu1234";
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
                txtdate.Value = new DateTime(int.Parse(DateTime.Now.ToString("yyyy")),
                                        int.Parse(DateTime.Now.ToString("MM")),
                                        1);
            }
        }
        public void look()
        {
            
            // 연동확인
            if (con == null)
            {
                MessageBox.Show("연동안됨");
                return;
            }
            //문장 만들기
            String sql1 = "select ITEM_CODE,ITEM_NAME,ITEM_DATE,ITEM_AMT,ITEM_COMP,ITEM_SAMT,item_yn"
                + " from njwBITEM" + " where ITEM_CODE like :CODE";
            String sql2 = "select *from njwbitem where item_code=:code and item_yn='N'";

            OracleDataReader dr;
            //여기까지 sql 전달
            OracleCommand cmd = con.CreateCommand();
            OracleCommand cmd1 = con.CreateCommand();
            cmd.CommandText = sql1;
            cmd1.CommandText = sql2;
            cmd.Parameters.Add("CODE", OracleDbType.Varchar2).Value = "%" + txtcode.Text + "%";
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
                row.Cells["column3"].Value = dr["ITEM_DATE"].ToString();
                row.Cells["column4"].Value = dr["ITEM_AMT"].ToString();
                row.Cells["column5"].Value = dr["ITEM_COMP"].ToString();
                row.Cells["column6"].Value = dr["ITEM_samt"].ToString();
                row.Cells["column7"].Value = dr["item_yn"].ToString();
                clear(); 
            }

        }
      

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtcode.Text = (string)dataGridView1.Rows[e.RowIndex].Cells["Column1"].Value;
            txtname.Text = (string)dataGridView1.Rows[e.RowIndex].Cells["Column2"].Value;
            txtdate.Text = (string)dataGridView1.Rows[e.RowIndex].Cells["Column3"].Value;
            txtcnt.Text = (string)dataGridView1.Rows[e.RowIndex].Cells["Column4"].Value;
            txtcomp.Text = (string)dataGridView1.Rows[e.RowIndex].Cells["Column5"].Value;
            txtamt.Text = (string)dataGridView1.Rows[e.RowIndex].Cells["Column6"].Value;
            txtyn.Text = (string)dataGridView1.Rows[e.RowIndex].Cells["Column7"].Value;

        }
        void clear()
        {
            txtcode.Text = "";
            txtname.Text = "";
            txtamt.Text = "";
            txtdate.Text = "";
            txtcomp.Text = "";
            txtdate.Text = "";
            txtcnt.Text = "";
            txtyn.Text = "";
        }
        void grid_display()
        {
            // 연동확인
            if (con == null)
            {
                MessageBox.Show("연동안됨");
                return;
            }
            //문장 만들기
            String sql1 = "select ITEM_CODE,ITEM_NAME,ITEM_DATE,ITEM_AMT,ITEM_COMP,ITEM_SAMT,item_yn"
                + " from njwBITEM" + " where ITEM_CODE like :CODE";
          //  String sql2 = "select *from njwbitem where item_code=:code and item_yn='N'";

            OracleDataReader dr;
            //여기까지 sql 전달
            OracleCommand cmd = con.CreateCommand();
            OracleCommand cmd1 = con.CreateCommand();
            cmd.CommandText = sql1;
       //     cmd1.CommandText = sql2;
            cmd.Parameters.Add("CODE", OracleDbType.Varchar2).Value = "%" + txtcode.Text + "%";
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
                row.Cells["column3"].Value = dr["ITEM_DATE"].ToString();
                row.Cells["column4"].Value = dr["ITEM_AMT"].ToString();
                row.Cells["column5"].Value = dr["ITEM_COMP"].ToString();
                row.Cells["column6"].Value = dr["ITEM_samt"].ToString();
                row.Cells["column7"].Value = dr["item_yn"].ToString();
                clear(); 
            }
        }

        private void btncan_Click(object sender, EventArgs e)
        {
           

        }
        
        public void okbtn_Click(string codevalue)
        {

            OracleDataReader dr;
            //여기까지 sql 전달
            OracleCommand cmd = con.CreateCommand();
            OracleCommand cmd1 = con.CreateCommand();
            if (codevalue == "I")
            {
               
             
                String sql4 = "select item_samt from njwbitem where item_code=:code";
          
                cmd.CommandText = sql4;

                cmd.Parameters.Add("code", OracleDbType.Varchar2).Value = txtcode.Text;
                //sql 요청 - 실행결과 dr 받음
                dr = cmd.ExecuteReader();
                bool pass = true;

                if (dr.Read())
                {
                   
                    if (Convert.ToInt32(dr["item_samt"].ToString()) > 0)
                    {
                        DialogResult result = MessageBox.Show("재고가 남아있습니다\n그래도 폐기하시겠습니까", "폐기완료", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.No)
                        {
                            pass = false;
                            return;
                        }
                    }

                    if (pass)
                    {

                        String insertsql = "update njwbitem set item_yn = 'Y' where item_code=:code1";
                        cmd = con.CreateCommand();
                        cmd.CommandText = insertsql;
                        cmd.BindByName = true;
                        cmd.Parameters.Add("code1", OracleDbType.Varchar2).Value = txtcode.Text;
                        cmd.ExecuteNonQuery();// insert update delete만 nonQuery  
                        MessageBox.Show("폐기되었습니다");
                        
                        //clear();
                    }
                   
                 
                }
                grid_display();

            }
            if (codevalue == "d")
            {

                String insertsql = "update njwbitem set item_yn = 'N' where item_code=:code2";
                cmd1 = con.CreateCommand();
                cmd1.CommandText = insertsql;
                cmd1.BindByName = true;

                cmd1.Parameters.Add("code2", OracleDbType.Varchar2).Value = txtcode.Text;
                cmd1.ExecuteNonQuery();// insert update delete만 nonQuery  
                MessageBox.Show("취소되었습니다");
                
            }

            
        }
        public bool deletebtn_Click()
        {
            try
            {
                if (con == null)
                {
                    MessageBox.Show("연동안됨");
                    return false;
                }
                //문장 만들기
                String sql1 = "select ITEM_CODE,ITEM_NAME,ITEM_DATE,ITEM_AMT,ITEM_COMP,ITEM_SAMT,item_yn from njwBITEM where item_yn='Y'";

                OracleDataReader dr;
                //여기까지 sql 전달
                OracleCommand cmd = con.CreateCommand();
                OracleCommand cmd1 = con.CreateCommand();
                cmd.CommandText = sql1;
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
                    row.Cells["column3"].Value = dr["ITEM_DATE"].ToString();
                    row.Cells["column4"].Value = dr["ITEM_AMT"].ToString();
                    row.Cells["column5"].Value = dr["ITEM_COMP"].ToString();
                    row.Cells["column6"].Value = dr["ITEM_samt"].ToString();
                    row.Cells["column7"].Value = dr["item_yn"].ToString();
                }
            }
            catch (Exception e )
            {

                MessageBox.Show(e.Message.ToString());
            }
       
            return true;
            
        }
        public bool insert()
        {
            try
            {
                if (con == null)
                {
                    MessageBox.Show("연동안됨");
                    return false;
                }
                //문장 만들기
                String sql1 = "select ITEM_CODE,ITEM_NAME,ITEM_DATE,ITEM_AMT,ITEM_COMP,ITEM_SAMT,item_yn from njwBITEM where item_yn='Y'";


                OracleDataReader dr;
                //여기까지 sql 전달
                OracleCommand cmd = con.CreateCommand();
                OracleCommand cmd1 = con.CreateCommand();
                cmd.CommandText = sql1;
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
                    row.Cells["column3"].Value = dr["ITEM_DATE"].ToString();
                    row.Cells["column4"].Value = dr["ITEM_AMT"].ToString();
                    row.Cells["column5"].Value = dr["ITEM_COMP"].ToString();
                    row.Cells["column6"].Value = dr["ITEM_samt"].ToString();
                    row.Cells["column7"].Value = dr["item_yn"].ToString();

                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message.ToString());
            }
            return true;
            
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dataGridView1.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        
            

    }
}
