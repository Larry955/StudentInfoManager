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
    public partial class Score : Form
    {
        public Score()
        {
            InitializeComponent();
        }

        private void exitScore_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Score_Load(object sender, EventArgs e)
        {
            //创建sql对象
            String conStr = "server=.;database=db_manager;Integrated security=SSPI";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();

            String selectSQL = "select ID as 课程编号,studentName as 学生姓名,courseName as 课程名,"
                            + "score as 分数 from db_score";

            SqlDataAdapter sda = new SqlDataAdapter(selectSQL, con);
            DataSet ds = new DataSet();
            //MessageBox.Show("xiix");
            sda.Fill(ds);
            //MessageBox.Show("xisdsewqix");
            if (ds.Tables[0].Rows.Count != 0)
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            else
                dataGridView1.DataSource = null;
            con.Close();

        }

        private void addScore_Click(object sender, EventArgs e)
        {
            AddScore ads = new AddScore();
            ads.Show();
        }

        private void updateScore_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr;
            if (this.dataGridView1.CurrentRow != null)
            {
                dr = this.dataGridView1.CurrentRow;
                string id = dr.Cells["课程编号"].Value.ToString();
                string name = dr.Cells["学生姓名"].Value.ToString();
                string course = dr.Cells["课程名"].Value.ToString();
                string score = dr.Cells["分数"].Value.ToString();

                UpdateScore us = new UpdateScore(id, name, course, score);
                us.MdiParent = this.MdiParent;
                us.Show();
            }
        }

        private void deleteScore_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr;
            String conString = "server=.;database=db_manager;Integrated security=SSPI";
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (this.dataGridView1.CurrentRow != null)
            {
                dr = this.dataGridView1.CurrentRow;
                String deleteSQL = "delete from db_score where ID = '" +
                    dr.Cells["课程编号"].Value.ToString() + "'";
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
}
