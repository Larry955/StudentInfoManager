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
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Student_Load(object sender, EventArgs e)
        {
            //创建sql对象
            String conStr = "server=.;database=db_manager;Integrated security=SSPI";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();

            String selectSQL = "select ID as 学号,Name as 姓名,Sex as 性别,Age as 年龄,EntryYear as 入学年份,Contact as 联系方式,Specialty as 专业,Class as 班级 from db_student";

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

        private void updateStuBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr;
            if(this.dataGridView1.CurrentRow != null)
            {
                dr = this.dataGridView1.CurrentRow;
                string id = dr.Cells["学号"].Value.ToString();
                string name = dr.Cells["姓名"].Value.ToString();
                string sex = dr.Cells["性别"].Value.ToString();
                string age = dr.Cells["年龄"].Value.ToString();
                string entry = dr.Cells["入学年份"].Value.ToString();
                string contact = dr.Cells["联系方式"].Value.ToString();
                string sp = dr.Cells["专业"].Value.ToString();
                string classNo = dr.Cells["班级"].Value.ToString();
                UpdateStudent us = new UpdateStudent(id,name,sex,age,entry,contact,sp,classNo);
                us.MdiParent = this.MdiParent;
                us.Show();
            }
        }

        private void addStuBtn_Click(object sender, EventArgs e)
        {
            AddStudent addStu = new AddStudent();
            addStu.Show();
        }

        private void deleteStuBtn_Click(object sender, EventArgs e)
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
                    String deleteSQL = "delete from db_student where ID = '" +
                        dr.Cells["学号"].Value.ToString() + "'";
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
}
