namespace Manager
{
    partial class Student
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.addStuBtn = new System.Windows.Forms.Button();
            this.updateStuBtn = new System.Windows.Forms.Button();
            this.deleteStuBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(927, 456);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "学生信息";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(891, 432);
            this.dataGridView1.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // addStuBtn
            // 
            this.addStuBtn.Location = new System.Drawing.Point(147, 497);
            this.addStuBtn.Name = "addStuBtn";
            this.addStuBtn.Size = new System.Drawing.Size(115, 23);
            this.addStuBtn.TabIndex = 1;
            this.addStuBtn.Text = "添加学生信息";
            this.addStuBtn.UseVisualStyleBackColor = true;
            this.addStuBtn.Click += new System.EventHandler(this.addStuBtn_Click);
            // 
            // updateStuBtn
            // 
            this.updateStuBtn.Location = new System.Drawing.Point(325, 497);
            this.updateStuBtn.Name = "updateStuBtn";
            this.updateStuBtn.Size = new System.Drawing.Size(117, 23);
            this.updateStuBtn.TabIndex = 2;
            this.updateStuBtn.Text = "修改学生信息";
            this.updateStuBtn.UseVisualStyleBackColor = true;
            this.updateStuBtn.Click += new System.EventHandler(this.updateStuBtn_Click);
            // 
            // deleteStuBtn
            // 
            this.deleteStuBtn.Location = new System.Drawing.Point(499, 497);
            this.deleteStuBtn.Name = "deleteStuBtn";
            this.deleteStuBtn.Size = new System.Drawing.Size(115, 23);
            this.deleteStuBtn.TabIndex = 3;
            this.deleteStuBtn.Text = "删除学生信息";
            this.deleteStuBtn.UseVisualStyleBackColor = true;
            this.deleteStuBtn.Click += new System.EventHandler(this.deleteStuBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(678, 497);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(107, 23);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "退  出";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 555);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.deleteStuBtn);
            this.Controls.Add(this.updateStuBtn);
            this.Controls.Add(this.addStuBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "Student";
            this.Text = "学生信息管理";
            this.Load += new System.EventHandler(this.Student_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button addStuBtn;
        private System.Windows.Forms.Button updateStuBtn;
        private System.Windows.Forms.Button deleteStuBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}