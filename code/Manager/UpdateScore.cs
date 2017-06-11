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
    public partial class UpdateScore : Form
    {
        public UpdateScore(string id, string n, string c, string s)
        {
            InitializeComponent();
            
            scoreID.Text = id;
            name.Text = n;
            course.Text = c;
            score.Text = s;
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (scoreID.Text == "" || name.Text == ""
                || course.Text == "" || score.Text == "")
            {
                MessageBox.Show("请将分数信息填写完整！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                name.Text = "";
                course.Text = "";
                score.Text = "";
                name.Focus();
                return;
            }
            else
            {
                //更新数据库
                String conStr = "server=.;database=db_manager;Integrated security = SSPI";
                SqlConnection con = new SqlConnection(conStr);
                con.Open();

                String updateSQL = "update db_score set studentName = '" + name.Text.Trim()
                                                        + "',courseName = '" + course.Text.Trim()
                                                        + "' where ID = " + scoreID.Text.Trim();
                SqlCommand cmd = new SqlCommand(updateSQL, con);
                int result = cmd.ExecuteNonQuery();
                if (result == -1)
                {
                    MessageBox.Show("分数更新失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    name.Text = "";
                    course.Text = "";
                    score.Text = "";
                    name.Focus();
                    return;
                }
                else
                {
                    MessageBox.Show("分数更新成功！下次启动时刷新", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                }

            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
