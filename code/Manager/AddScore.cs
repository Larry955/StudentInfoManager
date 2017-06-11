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
    public partial class AddScore : Form
    {
        public AddScore()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (scoreID.Text == "" || name.Text == " " || course.Text == "" || score.Text == "")
            {
                MessageBox.Show("请将信息补充完整！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Convert.ToInt32(score.Text) > 100 || Convert.ToInt32(score.Text) < 0)
            {
                MessageBox.Show("分数错误（0-100）！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                score.Text = "";
                return;
            }
            String checkID = "select* from db_score where ID = " + scoreID.Text;
            String checkName = "select* from db_score where studentName = '" + name.Text + "'";
            String checkCourse = "select* from db_score where courseName = '" + course.Text + "'";

            String conStr = "server=.;database=db_manager;Integrated security=SSPI";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();

            SqlCommand cmd = new SqlCommand(checkID, con);
            SqlDataReader sdr = cmd.ExecuteReader();
            sdr.Read();
            if (sdr.HasRows)
            {
                MessageBox.Show("该成绩编号已存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            sdr.Close();
            cmd = new SqlCommand(checkName, con);
            sdr = cmd.ExecuteReader();
            sdr.Read();
            if(sdr.HasRows)
            {
                sdr.Close();
                String checkStuName = "select* from db_student where Name = '" + name.Text + "'";
                cmd = new SqlCommand(checkStuName, con);
                sdr = cmd.ExecuteReader();
                sdr.Read();
                if (!sdr.HasRows)
                {
                    MessageBox.Show("未找到该学生信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    name.Text = "";
                    name.Focus();
                    sdr.Close();
                    return;
                }
                else
                {
                    MessageBox.Show("该学生姓名已存在 ！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    name.Text = "";
                    name.Focus();
                    sdr.Close();
                    return;
                }

            }
            sdr.Close();
            cmd = new SqlCommand(checkCourse, con);
            sdr = cmd.ExecuteReader();
            sdr.Read();
            if(sdr.HasRows)
            {
                sdr.Close();
                String checkCouName = "select* from db_course where Name = '" + course.Text + "'";
                cmd = new SqlCommand(checkCouName, con);
                sdr = cmd.ExecuteReader();
                sdr.Read();
                if (!sdr.HasRows)
                {
                    MessageBox.Show("未找到该课程信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    name.Text = "";
                    name.Focus();
                    sdr.Close();
                    return;
                }
            }
            sdr.Close();
            cmd.Dispose();

           // String t = "insert into db_score values('larry','hehe',31)";
            String insertSQL = "insert into db_score values('" + name.Text
                            + "','" + course.Text + "'," + score.Text + ")";
            SqlCommand cmd1 = new SqlCommand(insertSQL, con);
            int result = cmd1.ExecuteNonQuery();
            if(result == -1)
                MessageBox.Show("添加分数失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                MessageBox.Show("添加分数成功！下次启动时刷新！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
            cmd1.Dispose();
            con.Dispose();
            con.Close();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
