using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Manager
{
    public partial class Specialty : Form
    {
        
        public Specialty()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddSpecialty addSp = new AddSpecialty();
            addSp.Show();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr;
            if (this.dataGridView1.CurrentRow != null)
            {
                dr = this.dataGridView1.CurrentRow;
                string id = dr.Cells["专业编号"].Value.ToString();
                string name = dr.Cells["专业名称"].Value.ToString();
              //  string desc = dr.Cells["专业描述"].Value.ToString();

                updateSpecialty usp = new updateSpecialty(id,name);
                usp.MdiParent = this.MdiParent;
                usp.Show();
            }
        }

        private void Specialty_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("666");
            String conStr = "server=.;database=db_manager;Integrated security = SSPI";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            String query = "select ID as 专业编号,Name as 专业名称 from db_specialty";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            //MessageBox.Show("888");
            dataGridView1.DataSource = ds.Tables[0];

            dataGridView1.Columns["专业编号"].Width = 200;
            dataGridView1.Columns["专业名称"].Width = dataGridView1.Width - dataGridView1.Columns["专业编号"].Width;

            con.Close();
            con.Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("警告！删除专业可能导致完整性冲突，是否继续？", "操作提示",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                this.Hide();
            else
            {
                DataGridViewRow dr;
                String conString = "server=.;database=db_manager;Integrated security=SSPI";
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                if (this.dataGridView1.CurrentRow != null)
                {
                    dr = this.dataGridView1.CurrentRow;
                    String deleteSQL = "delete from db_specialty where ID = " + 
                        dr.Cells["专业编号"].Value.ToString();
                    SqlCommand cmd = new SqlCommand(deleteSQL, con);
                    int result = cmd.ExecuteNonQuery();
                    if (result == -1)
                    {
                        MessageBox.Show("删除失败！", "提示");

                    }
                    else
                    {
                        MessageBox.Show("删除成功！下次启动时刷新！", "提示",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    cmd.Dispose();
                }
                con.Dispose();
                con.Close();
            }               
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
