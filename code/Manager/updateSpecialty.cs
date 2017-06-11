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
    public partial class updateSpecialty : Form
    {
        /// <summary>
        /// 接收传递过来的消息
        /// </summary>
        /// <param name="id">专业编号</param>
        /// <param name="name">专业名称</param>
        /// <param name="description">专业描述</param>
        public updateSpecialty(string id,string name)
        {
            InitializeComponent();

            spID.Text = id;
            spName.Text = name;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (spName.Text == "")
                MessageBox.Show("请将信息输入完整！", "操作提示");
            else
            {
                String conString = "server=.;database=db_manager;Integrated security=SSPI";
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                String check = "select Name from db_specialty where Name = '" + 
                    spName.Text.Trim() + "'" + " and Id = " + spID.Text;
                SqlCommand cmd = new SqlCommand(check, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                if(sdr.HasRows)
                {
                    //MessageBox.Show("该专业已存在！","提示",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    spName.Text = "";
                    spDescription.Text = "";
                    return;
                }
                else
                {
                    sdr.Close();
                    String updateSQL = "update db_specialty set Name = '" + 
                        spName.Text.Trim() + "'" + "where ID = " + spID.Text ;
                    cmd = new SqlCommand(updateSQL, con);
                    int result = cmd.ExecuteNonQuery();
                    if (result == -1)
                        MessageBox.Show("更新失败，请重试！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    else
                    {
                        MessageBox.Show("更新成功，下次启动时刷新！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.Hide();
                    }
                }
                cmd.Dispose();
                con.Close();
                con.Dispose();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
