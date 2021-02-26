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
    public partial class Form6 : Form
    {
        public int openfrom = 0;
        OracleConnection con = null;
        OracleCommand cmd;
      
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (con == null)
            {
                MessageBox.Show("연동안됨");
                return;
            }
            //문장 만들기
            String sql1 = "select ITEM_CODE,ITEM_NAME,ITEM_Samt"
                + " from njwBITEM" + " where ITEM_name like :name and item_yn ='N'";


            OracleDataReader dr;
            //여기까지 sql 전달
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = sql1;
            cmd.Parameters.Add("name", OracleDbType.Varchar2).Value = "%" + textBox1.Text + "%";
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
                row.Cells["column3"].Value = dr["ITEM_Samt"].ToString();
                

            }
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //폼 데이터 전달 
            if(openfrom == 5)
            {
                Form5 frm = (Form5)this.Owner;
                frm.txtcode.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                frm.txtname1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                frm.txtsamt.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                
            }
            else
            {
                Form7 frm1 = (Form7)this.Owner;
                frm1.txtcode.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                frm1.txtname1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                frm1.txtsamt.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
          
          
            

        }

        private void Form6_Load(object sender, EventArgs e)
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
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
