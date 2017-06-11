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
    public partial class Course : Form
    {
        public Course()
        {
            InitializeComponent();
        }

        private void Course_Load(object sender, EventArgs e)
        {
           // String conStr = "server=.;database=db_manager;Integrated security = SSPI";
           // SqlConnection con = new SqlConnection(conStr);
           // con.Open();

           // String selectSQL = "select ID as 课程编号,Name as 课程名称,Dept as 学院,Specialty as 专业 from db_course";

           // SqlDataAdapter sda = new SqlDataAdapter(selectSQL, con);
           // DataSet ds = new DataSet();
           //// MessageBox.Show("xiix");
           // sda.Fill(ds);
           //// MessageBox.Show("xisdsewqix");
           // if (ds.Tables[0].Rows.Count != 0)
           //     dataGridView1.DataSource = ds.Tables[0].DefaultView;
           // else
           //     dataGridView1.DataSource = null;
           // con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCourse ac = new AddCourse();
            ac.Show();
        }

        private void updateCourse_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr;
            if(this.dataGridView1.CurrentRow != null)
            {
                dr = this.dataGridView1.CurrentRow;
                string id = dr.Cells["课程编号"].Value.ToString();
                string name = dr.Cells["课程名称"].Value.ToString();
                string dept = dr.Cells["学院"].Value.ToString();
                string specialty = dr.Cells["专业"].Value.ToString();

                UpdateCourse uc = new UpdateCourse(id,name, dept, specialty);
                uc.MdiParent = this.MdiParent;
                uc.Show();
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteCourse_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("警告！删除专业可能导致完整性冲突，是否继续？", "操作提示",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                this.Hide();
            else
            {
                DataGridViewRow dr;
                if (this.dataGridView1.CurrentRow != null)
                {
                    dr = this.dataGridView1.CurrentRow;
                    string id = dr.Cells["课程编号"].Value.ToString();
                    string name = dr.Cells["课程名称"].Value.ToString();
                    string dept = dr.Cells["学院"].Value.ToString();
                    string specialty = dr.Cells["专业"].Value.ToString();

                    String conStr = "server=.;database=db_manager;Integrated security = SSPI";
                    SqlConnection con = new SqlConnection(conStr);
                    con.Open();

                    String deleteSQL = "delete from db_course where id = '" + id + "'";
                    SqlCommand cmd = new SqlCommand(deleteSQL, con);
                    int result = cmd.ExecuteNonQuery();
                    if (result == -1)
                        MessageBox.Show("课程删除失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    else
                    {
                        MessageBox.Show("课程删除成功！下次启动时刷新！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    cmd.Dispose();
                    con.Dispose();
                    con.Close();
                }
            }
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (listBox1.Name != null)
            {
                string sp = listBox1.SelectedItem.ToString();
                //MessageBox.Show(sp);
                String conStr = "server=.;database=db_manager;Integrated security = SSPI";
                SqlConnection con = new SqlConnection(conStr);
                con.Open();

                String select = "select ID as 课程编号,Name as 课程名称,Dept as 学院,Specialty as 专业 from db_course where Specialty = '" + sp + "'";
                //SqlCommand cmd = new SqlCommand(select, con);
                //SqlDataAdaptor sdr = cmd.ExecuteReader();
                SqlDataAdapter sda = new SqlDataAdapter(select, con);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                //MessageBox.Show("xixi");
                if (ds.Tables[0].Rows.Count != 0)
                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                else
                    dataGridView1.DataSource = null;
                con.Close();
            }
        }
    }
}
