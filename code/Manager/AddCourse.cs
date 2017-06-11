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
    public partial class AddCourse : Form
    {
        public AddCourse()
        {
            InitializeComponent();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("请将课程信息补充完整！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox1.Focus();
                return;
            }
            //创建sql对象
            String conStr = "server=.;database=db_manager;Integrated security=SSPI";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();

            //判断该课程是否已存在
            String checkSp = "select* from db_course where Specialty = '" + textBox3.Text + "'";
            SqlCommand cmd = new SqlCommand(checkSp, con);
            SqlDataReader sdr = cmd.ExecuteReader();
            sdr.Read();
            if (sdr.HasRows)    //如果该课程已存在
            {
                MessageBox.Show("该课程已存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox1.Focus();
                sdr.Close();
                return;
            }
            else
            {
                sdr.Close();
                //添加课程
                String insertSp = "insert into db_course values('" + textBox3.Text.Trim() + "','" 
                                + textBox1.Text.Trim() + "','" + textBox2.Text.Trim() + "')";

                cmd = new SqlCommand(insertSp, con);
                int result = cmd.ExecuteNonQuery();
                if (result == -1)
                {
                    MessageBox.Show("课程添加失败，请重试！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox1.Focus();
                    sdr.Close();
                    return;
                }
                else
                {
                    MessageBox.Show("课程添加成功，下次启动时刷新！", "提示",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Hide();
                }
            }
            cmd.Dispose();
            con.Close();
            con.Dispose();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
