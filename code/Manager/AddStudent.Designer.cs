namespace Manager
{
    partial class AddStudent
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.IDText = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.sexComboBox = new System.Windows.Forms.ComboBox();
            this.classText = new System.Windows.Forms.TextBox();
            this.entryText = new System.Windows.Forms.TextBox();
            this.contactText = new System.Windows.Forms.TextBox();
            this.spText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ageText = new System.Windows.Forms.TextBox();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.otherBox = new System.Windows.Forms.RichTextBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.exitBtn);
            this.groupBox1.Controls.Add(this.otherBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.confirmBtn);
            this.groupBox1.Controls.Add(this.ageText);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.spText);
            this.groupBox1.Controls.Add(this.contactText);
            this.groupBox1.Controls.Add(this.entryText);
            this.groupBox1.Controls.Add(this.classText);
            this.groupBox1.Controls.Add(this.sexComboBox);
            this.groupBox1.Controls.Add(this.nameText);
            this.groupBox1.Controls.Add(this.IDText);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(638, 412);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本信息";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "学    号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "姓    名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "性    别";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(337, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "专    业";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "班    级";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(337, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "入学年份";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(337, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "联系方式";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // IDText
            // 
            this.IDText.Location = new System.Drawing.Point(118, 29);
            this.IDText.Name = "IDText";
            this.IDText.Size = new System.Drawing.Size(177, 25);
            this.IDText.TabIndex = 7;
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(118, 74);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(177, 25);
            this.nameText.TabIndex = 12;
            // 
            // sexComboBox
            // 
            this.sexComboBox.FormattingEnabled = true;
            this.sexComboBox.Items.AddRange(new object[] {
            "男",
            "女"});
            this.sexComboBox.Location = new System.Drawing.Point(118, 111);
            this.sexComboBox.Name = "sexComboBox";
            this.sexComboBox.Size = new System.Drawing.Size(121, 23);
            this.sexComboBox.TabIndex = 13;
            // 
            // classText
            // 
            this.classText.Location = new System.Drawing.Point(417, 73);
            this.classText.Name = "classText";
            this.classText.Size = new System.Drawing.Size(177, 25);
            this.classText.TabIndex = 15;
            // 
            // entryText
            // 
            this.entryText.Location = new System.Drawing.Point(417, 111);
            this.entryText.Name = "entryText";
            this.entryText.Size = new System.Drawing.Size(177, 25);
            this.entryText.TabIndex = 16;
            // 
            // contactText
            // 
            this.contactText.Location = new System.Drawing.Point(417, 151);
            this.contactText.Name = "contactText";
            this.contactText.Size = new System.Drawing.Size(177, 25);
            this.contactText.TabIndex = 17;
            // 
            // spText
            // 
            this.spText.Location = new System.Drawing.Point(417, 30);
            this.spText.Name = "spText";
            this.spText.Size = new System.Drawing.Size(177, 25);
            this.spText.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "年    龄";
            // 
            // ageText
            // 
            this.ageText.Location = new System.Drawing.Point(118, 149);
            this.ageText.Name = "ageText";
            this.ageText.Size = new System.Drawing.Size(177, 25);
            this.ageText.TabIndex = 20;
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(189, 349);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(75, 23);
            this.confirmBtn.TabIndex = 21;
            this.confirmBtn.Text = "确 认";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "备    注";
            // 
            // otherBox
            // 
            this.otherBox.Location = new System.Drawing.Point(118, 189);
            this.otherBox.Name = "otherBox";
            this.otherBox.Size = new System.Drawing.Size(476, 119);
            this.otherBox.TabIndex = 23;
            this.otherBox.Text = "";
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(331, 349);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 24;
            this.exitBtn.Text = "退 出";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 456);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddStudent";
            this.Text = "添加学生信息";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox IDText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.RichTextBox otherBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.TextBox ageText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox spText;
        private System.Windows.Forms.TextBox contactText;
        private System.Windows.Forms.TextBox entryText;
        private System.Windows.Forms.TextBox classText;
        private System.Windows.Forms.ComboBox sexComboBox;
    }
}