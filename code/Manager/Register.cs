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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 注册模块
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e) 
        {
            if (setupName.Text == "")
            {
                MessageBox.Show("请输入名字！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                setupName.Focus();
                return;
            }
            if (registerPsw.Text == "")
            {
                MessageBox.Show("请输入密码！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                registerPsw.Focus();
                return;
            }
            if (registerPsw.Text != registerPsw2.Text)
            {
                MessageBox.Show("两次密码输入不一致，请重新输入！", "提示", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                registerPsw.Text = "";
                registerPsw2.Text = "";
                registerPsw.Focus();
                return;
            }

            String connectionString = "server=.;database=db_manager;Integrated security=SSPI";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            String check = "select* from db_login where Name = " + "'" + setupName.Text + "'";
            SqlCommand cmd = new SqlCommand(check, con);
            SqlDataReader sdr = cmd.ExecuteReader();
            sdr.Read();
            if (!sdr.HasRows)
            {
                sdr.Close();
                MessageBox.Show("can register");
                String insertSQL = "insert into db_login values('" + setupName.Text + "','"
                    + registerPsw.Text.Trim() + "')";
                cmd = new SqlCommand(insertSQL, con);
                int j = cmd.ExecuteNonQuery();
                if (j == -1)
                {
                    MessageBox.Show("注册失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    setupName.Text = "";
                    registerPsw.Text = "";
                    registerPsw2.Text = "";
                    setupName.Focus();
                    return;
                }
                else
                {
                    MessageBox.Show("注册成功，请关闭该窗口，重新登录！",
                    "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("该用户已存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                setupName.Text = "";
                registerPsw.Text = "";
                registerPsw2.Text = "";
                setupName.Focus();
                return;
            }
            
            cmd.Dispose();
            con.Close();
            con.Dispose();
            //MessageBox.Show("xixi");
        }
    }
}
