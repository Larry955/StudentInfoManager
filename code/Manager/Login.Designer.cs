namespace Manager
{
    partial class Login
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
            this.label2 = new System.Windows.Forms.Label();
            this.loginPsw = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loginName = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.loginReg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "密码:";
            // 
            // loginPsw
            // 
            this.loginPsw.Location = new System.Drawing.Point(115, 88);
            this.loginPsw.Name = "loginPsw";
            this.loginPsw.PasswordChar = '*';
            this.loginPsw.Size = new System.Drawing.Size(100, 25);
            this.loginPsw.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "昵称:";
            // 
            // loginName
            // 
            this.loginName.Location = new System.Drawing.Point(116, 35);
            this.loginName.Name = "loginName";
            this.loginName.Size = new System.Drawing.Size(100, 25);
            this.loginName.TabIndex = 4;
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(53, 172);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 8;
            this.loginBtn.Text = "登陆";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // loginReg
            // 
            this.loginReg.Location = new System.Drawing.Point(153, 172);
            this.loginReg.Name = "loginReg";
            this.loginReg.Size = new System.Drawing.Size(75, 23);
            this.loginReg.TabIndex = 9;
            this.loginReg.Text = "注册";
            this.loginReg.UseVisualStyleBackColor = true;
            this.loginReg.Click += new System.EventHandler(this.loginReg_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 255);
            this.Controls.Add(this.loginReg);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loginPsw);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginName);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox loginPsw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox loginName;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button loginReg;
    }
}