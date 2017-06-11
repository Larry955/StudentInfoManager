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
    public partial class UpdateCourse : Form
    {
        public UpdateCourse(string id, string name, string dept, string specialty)
        {
            InitializeComponent();

            textBox1.Text = id;
            textBox2.Text = name;
            textBox3.Text = dept;
            textBox4.Text = specialty;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" 
                || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("请将课程信息填写完整！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox2.Text = "";
                textBox3.Text = "";
                textBox2.Focus();
                return;
            }
            else
            {
                //更新数据库
                String conStr = "server=.;database=db_manager;Integrated security = SSPI";
                SqlConnection con = new SqlConnection(conStr);
                con.Open();

                String updateSQL = "update db_course set Name = '" + textBox2.Text.Trim() 
                                                        + "',Dept = '" + textBox3.Text.Trim() 
                                                        + "',Specialty = '" + textBox4.Text.Trim() 
                                                        + "' where ID = " + textBox1.Text.Trim();
                SqlCommand cmd = new SqlCommand(updateSQL, con);
                int result = cmd.ExecuteNonQuery();
                if (result == -1)
                {
                    MessageBox.Show("课程更新失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox2.Focus();
                    return;
                }
                else
                {
                    MessageBox.Show("课程更新成功！下次启动时刷新", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                }

            }
        }
    }
}
