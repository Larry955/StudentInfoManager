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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            //创建sql对象
            String conStr = "server=.;database=db_manager;Integrated security=SSPI";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();

            if (IDText.Text == "")
                MessageBox.Show("学号为必填项！", "提示");
            else
            {
                String check = "select* from db_student where ID = '" + IDText.Text + "'";
                SqlCommand cmd = new SqlCommand(check, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                if (sdr.HasRows)
                {
                    MessageBox.Show("该学生已存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    IDText.Text = "";
                    IDText.Focus();
                }
                else
                {
                    sdr.Close();
                    String test = "insert into db_student values('2123','larry','男',21,2014,'1300000','CS',2)";
                    String insertSQL = "insert into db_student values('" + IDText.Text + "','"
                                    + nameText.Text + "','"
                                    + sexComboBox.Text + "',"
                                    + ageText.Text + "," + entryText.Text + ",'"
                                    + contactText.Text + "','"
                                    + spText.Text + "'," + classText.Text
                                    + ")";

                    cmd = new SqlCommand(insertSQL, con);
                    int result = cmd.ExecuteNonQuery();
                    if (result == -1)
                        MessageBox.Show("添加失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    else
                    {
                        MessageBox.Show("添加成功，下次启动时刷新！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.Hide();
                    }
                }
                cmd.Dispose();
            }
            
            con.Dispose();
            con.Close();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
