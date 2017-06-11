namespace Manager
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.specialtyMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.studentMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.courseMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.scoreMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.specialtyMenu,
            this.studentMenu,
            this.courseMenu,
            this.scoreMenu,
            this.aboutMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1182, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // specialtyMenu
            // 
            this.specialtyMenu.Name = "specialtyMenu";
            this.specialtyMenu.Size = new System.Drawing.Size(111, 24);
            this.specialtyMenu.Text = "专业信息管理";
            this.specialtyMenu.Click += new System.EventHandler(this.specialtyMenu_Click);
            // 
            // studentMenu
            // 
            this.studentMenu.Name = "studentMenu";
            this.studentMenu.Size = new System.Drawing.Size(111, 24);
            this.studentMenu.Text = "学生信息管理";
            this.studentMenu.Click += new System.EventHandler(this.studentMenu_Click);
            // 
            // courseMenu
            // 
            this.courseMenu.Name = "courseMenu";
            this.courseMenu.Size = new System.Drawing.Size(111, 24);
            this.courseMenu.Text = "课程信息管理";
            this.courseMenu.Click += new System.EventHandler(this.courseMenu_Click);
            // 
            // scoreMenu
            // 
            this.scoreMenu.Name = "scoreMenu";
            this.scoreMenu.Size = new System.Drawing.Size(111, 24);
            this.scoreMenu.Text = "成绩信息管理";
            this.scoreMenu.Click += new System.EventHandler(this.scoreMenu_Click);
            // 
            // aboutMenu
            // 
            this.aboutMenu.Name = "aboutMenu";
            this.aboutMenu.Size = new System.Drawing.Size(51, 24);
            this.aboutMenu.Text = "关于";
            this.aboutMenu.Click += new System.EventHandler(this.aboutMenu_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 755);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生学籍管理系统";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem specialtyMenu;
        private System.Windows.Forms.ToolStripMenuItem studentMenu;
        private System.Windows.Forms.ToolStripMenuItem courseMenu;
        private System.Windows.Forms.ToolStripMenuItem scoreMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutMenu;

    }
}