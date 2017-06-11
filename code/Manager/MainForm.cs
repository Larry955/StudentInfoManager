using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 专业信息管理模块
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void specialtyMenu_Click(object sender, EventArgs e)
        {
            Specialty sp = new Specialty();
            sp.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Close();
        }

        private void studentMenu_Click(object sender, EventArgs e)
        {
            Student stu = new Student();
            stu.Show();
        }

        private void aboutMenu_Click(object sender, EventArgs e)
        {
            AboutForm af = new AboutForm();
            af.Show();
        }

        private void courseMenu_Click(object sender, EventArgs e)
        {
            Course c = new Course();
            c.Show();
        }

        private void scoreMenu_Click(object sender, EventArgs e)
        {
            Score sc = new Score();
            sc.Show();
        }

        private void sysManagerMenu_Click(object sender, EventArgs e)
        {

        }
    }
}
