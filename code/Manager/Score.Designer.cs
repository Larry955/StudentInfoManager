namespace Manager
{
    partial class Score
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addScore = new System.Windows.Forms.Button();
            this.updateScore = new System.Windows.Forms.Button();
            this.deleteScore = new System.Windows.Forms.Button();
            this.exitScore = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(651, 442);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "成绩信息";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(614, 383);
            this.dataGridView1.TabIndex = 6;
            // 
            // addScore
            // 
            this.addScore.Location = new System.Drawing.Point(105, 473);
            this.addScore.Name = "addScore";
            this.addScore.Size = new System.Drawing.Size(75, 23);
            this.addScore.TabIndex = 7;
            this.addScore.Text = "添加成绩";
            this.addScore.UseVisualStyleBackColor = true;
            this.addScore.Click += new System.EventHandler(this.addScore_Click);
            // 
            // updateScore
            // 
            this.updateScore.Location = new System.Drawing.Point(221, 473);
            this.updateScore.Name = "updateScore";
            this.updateScore.Size = new System.Drawing.Size(75, 23);
            this.updateScore.TabIndex = 8;
            this.updateScore.Text = "修改成绩";
            this.updateScore.UseVisualStyleBackColor = true;
            this.updateScore.Click += new System.EventHandler(this.updateScore_Click);
            // 
            // deleteScore
            // 
            this.deleteScore.Location = new System.Drawing.Point(335, 473);
            this.deleteScore.Name = "deleteScore";
            this.deleteScore.Size = new System.Drawing.Size(75, 23);
            this.deleteScore.TabIndex = 9;
            this.deleteScore.Text = "删除成绩";
            this.deleteScore.UseVisualStyleBackColor = true;
            this.deleteScore.Click += new System.EventHandler(this.deleteScore_Click);
            // 
            // exitScore
            // 
            this.exitScore.Location = new System.Drawing.Point(451, 473);
            this.exitScore.Name = "exitScore";
            this.exitScore.Size = new System.Drawing.Size(75, 23);
            this.exitScore.TabIndex = 10;
            this.exitScore.Text = "退 出";
            this.exitScore.UseVisualStyleBackColor = true;
            this.exitScore.Click += new System.EventHandler(this.exitScore_Click);
            // 
            // Score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 530);
            this.Controls.Add(this.exitScore);
            this.Controls.Add(this.deleteScore);
            this.Controls.Add(this.updateScore);
            this.Controls.Add(this.addScore);
            this.Controls.Add(this.groupBox1);
            this.Name = "Score";
            this.Text = "成绩信息浏览";
            this.Load += new System.EventHandler(this.Score_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addScore;
        private System.Windows.Forms.Button updateScore;
        private System.Windows.Forms.Button deleteScore;
        private System.Windows.Forms.Button exitScore;
    }
}