namespace LibrarySearch
{
    partial class SignInForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tB_username = new System.Windows.Forms.TextBox();
            this.tB_password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.btn_signup = new System.Windows.Forms.Button();
            this.btn_signin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tB_username
            // 
            this.tB_username.Location = new System.Drawing.Point(179, 118);
            this.tB_username.Name = "tB_username";
            this.tB_username.Size = new System.Drawing.Size(144, 21);
            this.tB_username.TabIndex = 0;
            // 
            // tB_password
            // 
            this.tB_password.Location = new System.Drawing.Point(180, 170);
            this.tB_password.Multiline = true;
            this.tB_password.Name = "tB_password";
            this.tB_password.PasswordChar = '*';
            this.tB_password.Size = new System.Drawing.Size(143, 24);
            this.tB_password.TabIndex = 1;
            this.tB_password.UseSystemPasswordChar = true;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(90, 120);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(41, 12);
            this.username.TabIndex = 2;
            this.username.Text = "用户名";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(90, 173);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(41, 12);
            this.password.TabIndex = 3;
            this.password.Text = "密  码";
            // 
            // btn_signup
            // 
            this.btn_signup.Location = new System.Drawing.Point(107, 233);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(73, 23);
            this.btn_signup.TabIndex = 4;
            this.btn_signup.Text = "注册";
            this.btn_signup.UseVisualStyleBackColor = true;
            this.btn_signup.Click += new System.EventHandler(this.btn_signup_Click);
            // 
            // btn_signin
            // 
            this.btn_signin.Location = new System.Drawing.Point(216, 233);
            this.btn_signin.Name = "btn_signin";
            this.btn_signin.Size = new System.Drawing.Size(73, 23);
            this.btn_signin.TabIndex = 5;
            this.btn_signin.Text = "登录";
            this.btn_signin.UseVisualStyleBackColor = true;
            this.btn_signin.Click += new System.EventHandler(this.btn_signin_Click);
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 308);
            this.Controls.Add(this.btn_signin);
            this.Controls.Add(this.btn_signup);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.tB_password);
            this.Controls.Add(this.tB_username);
            this.Name = "SignInForm";
            this.Text = "登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tB_password;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Button btn_signup;
        private System.Windows.Forms.Button btn_signin;
        private System.Windows.Forms.TextBox tB_username;
    }
}

