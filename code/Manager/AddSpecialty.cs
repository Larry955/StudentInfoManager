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
    public partial class AddSpecialty : Form
    {
        String connectionString = "server=.;database=db_manager;Integrated security=SSPI";
        public AddSpecialty()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 添加专业
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            if (spName.Text == "" || spDespRichBox.Text == "")
            {
                MessageBox.Show("请将专业信息补充完整！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                spName.Text = "";
                spDespRichBox.Text = "";
                spName.Focus();
                return;
            }

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            //判断该专业是否已存在
            String checkSp = "select* from db_specialty where name = '" + spName.Text + "'";
            SqlCommand cmd = new SqlCommand(checkSp, con);
            SqlDataReader sdr = cmd.ExecuteReader();
            sdr.Read();
            if (sdr.HasRows)    //如果该专业已存在
            {
                MessageBox.Show("该专业已存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                spName.Text = "";
                spDespRichBox.Text = "";
                spName.Focus();
                sdr.Close();
                return;
            }
            else
            {
                sdr.Close();
                //添加专业
                String insertSp = "insert into db_specialty values('" + spName.Text.Trim() + "')"; 

                cmd = new SqlCommand(insertSp, con);
                int result = cmd.ExecuteNonQuery();
                if (result == -1)
                {
                    MessageBox.Show("专业添加失败，请重试！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    spName.Text = "";
                    spDespRichBox.Text = "";
                    spName.Focus();
                    sdr.Close();
                    return;
                }
                else
                {
                    MessageBox.Show("专业添加成功，下次启动时刷新！", "提示", 
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Hide();
                }
            }
            cmd.Dispose();
            con.Close();
            con.Dispose();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
