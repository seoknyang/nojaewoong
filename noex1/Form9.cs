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
    public partial class Form9 : Form
    {
        OracleConnection con = null;
        OracleCommand cmd;

        public Form9()
        {
            InitializeComponent();
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
            String sql1 = "select ITEM_CODE,ITEM_NAME,ITEM_STAND,ITEM_DATE,ITEM_AMT,ITEM_COMP,ITEM_SAMT,ITEM_POSI,ITEM_ETC,USER_SYS,USER_SYSID"
                + " from njwBITEM where ITEM_name like :name and item_yn='N'";


            OracleDataReader dr;
            //여기까지 sql 전달
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = sql1;
            cmd.Parameters.Add("name", OracleDbType.Varchar2).Value = "%" + txtcode.Text + "%";
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
                row.Cells["column10"].Value = dr["USER_SYS"].ToString();
                row.Cells["column11"].Value = dr["USER_SYSID"].ToString();

            }
        }
     

        private void Form9_Load(object sender, EventArgs e)
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
                dateTimePicker1.Value = new DateTime(int.Parse(DateTime.Now.ToString("yyyy")),
                                        int.Parse(DateTime.Now.ToString("MM")),
                                        1);
                
                dateTimePicker3.Value = new DateTime(int.Parse(DateTime.Now.ToString("yyyy")),
                                        int.Parse(DateTime.Now.ToString("MM")),
                                        1);

            }
        }

       

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            String code = (string)dataGridView1.Rows[e.RowIndex].Cells["Column1"].Value;
            

            String sql = "select * from njw_ipgo where ip_code = :code2 and ip_date >= :date1 and ip_date <= :date2";

            OracleDataReader dr;
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = sql;

            cmd.Parameters.Add("code2", OracleDbType.Varchar2).Value = code;
            cmd.Parameters.Add("date1", OracleDbType.Varchar2).Value = dateTimePicker1.Text;
            cmd.Parameters.Add("date2", OracleDbType.Varchar2).Value = dateTimePicker2.Text;
     
            //sql 요청 - 실행결과 dr 받음
            dr = cmd.ExecuteReader();
            int rowidx = 0;
            DataGridViewRow row;
            dataGridView2.Rows.Clear();

            while (dr.Read())
            {
                rowidx = dataGridView2.Rows.Add();
                row = dataGridView2.Rows[rowidx];
                row.Cells["Column12"].Value = dr["ip_code"].ToString();
                row.Cells["Column13"].Value = dr["ip_date"].ToString();
                row.Cells["Column14"].Value = dr["ip_amt"].ToString();
                row.Cells["Column15"].Value = dr["ip_comp"].ToString();
            }

            String sql2 = "select * from njwculgo where cul_code = :code3 and cul_date >= :date3 and cul_date <= :date4";
            OracleDataReader dr2;
            OracleCommand cmd1 = con.CreateCommand();
            cmd1.CommandText = sql2;

            cmd1.Parameters.Add("code3", OracleDbType.Varchar2).Value = code;
            cmd1.Parameters.Add("date3", OracleDbType.Varchar2).Value = dateTimePicker3.Text;
            cmd1.Parameters.Add("date4", OracleDbType.Varchar2).Value = dateTimePicker4.Text;

            dr2 = cmd1.ExecuteReader();
            int rowidx2 = 0;
            DataGridViewRow row2;
            dataGridView3.Rows.Clear();
            while (dr2.Read())
            {
                rowidx2 = dataGridView3.Rows.Add();
                Console.WriteLine(rowidx2);
                row2 = dataGridView3.Rows[rowidx2];
                row2.Cells["Column16"].Value = dr2["cul_code"].ToString();
                row2.Cells["Column17"].Value = dr2["cul_date"].ToString();
                row2.Cells["Column18"].Value = dr2["cul_amt"].ToString();
                row2.Cells["Column19"].Value = dr2["cul_sau"].ToString();
                

            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dataGridView1.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void dataGridView2_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dataGridView2.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void dataGridView3_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dataGridView3.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

   
}
