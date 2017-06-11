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
    public partial class UpdateStudent : Form
    {
        public UpdateStudent(string id,string name,string sex,string age,string entry,string contact,string sp,string classNo)
        {
            InitializeComponent();

            IDText.Text = id;
            nameText.Text = name;
            sexBox.Text = sex;
            ageText.Text = age;
            entryText.Text = entry;
            contactText.Text = contact;
            spText.Text = sp;
            classText.Text = classNo;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (IDText.Text == "")
                MessageBox.Show("学号不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                String conStr = "server=.;database=db_manager;Integrated security = SSPI";
                SqlConnection con = new SqlConnection(conStr);
                con.Open();

                String updateSQL = "update db_student set Name = '" + nameText.Text 
                                + "',Sex = '" + sexBox.Text 
                                + "',Age = " + ageText.Text 
                                + ",entryYear = " + entryText.Text 
                                + ",Contact = '" + contactText.Text 
                                + "',class = " + classText.Text 
                                + " where ID = '" + IDText.Text + "'";

                SqlCommand cmd = new SqlCommand(updateSQL, con);
                int result = cmd.ExecuteNonQuery();
                if (result == -1)
                    MessageBox.Show("更新失败！", "提示");
                else
                {
                    MessageBox.Show("更新成功！下次启动时刷新！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Hide();
                }
                cmd.Dispose();
                con.Close();
                con.Dispose();
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
