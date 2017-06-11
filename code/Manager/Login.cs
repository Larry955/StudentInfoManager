using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Manager
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginReg_Click(object sender, EventArgs e)
        {
            Register form = new Register();
            form.Show();
            
        }

        /// <summary>
        /// 登录模块
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (loginName.Text == "")
            {
                MessageBox.Show("请输入名字！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                loginName.Focus();
                return;
            }
            if (loginPsw.Text == "")
            {
                MessageBox.Show("请输入密码！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                loginPsw.Focus();
                return;
            }
            //创建sql对象
            String connectionString = "server=.;database=db_manager;Integrated security=SSPI";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            //MessageBox.Show("ha");
            
            //数据库查询
            String sqlQuery = "select *from db_login where Name = '" + loginName.Text + "' ";
            SqlCommand logCommand = new SqlCommand(sqlQuery, con);
            SqlDataReader sdr = logCommand.ExecuteReader();
            sdr.Read();
            if (!sdr.HasRows)
            {
                MessageBox.Show("用户不存在，请点击按钮进行注册！","提示",
                    MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                sdr.Close();
                sqlQuery = "select Name from db_login where Psw = '" + loginPsw.Text.Trim() + "' ";
                logCommand = new SqlCommand(sqlQuery, con);
                sdr = logCommand.ExecuteReader();
                sdr.Read();
                if (!sdr.HasRows)
                {
                    MessageBox.Show("密码输入错误，请重新输入！", "提示",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    loginPsw.Text = "";
                }
                else
                {
                    this.Hide();
                    MainForm mf = new MainForm(); 
                    mf.Show();
                }
            }
            logCommand.Dispose();
            con.Close();
            con.Dispose();
        }
    }
}
