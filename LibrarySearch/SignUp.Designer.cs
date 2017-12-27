namespace LibrarySearch
{
    partial class SignUp
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
            this.tB_username = new System.Windows.Forms.TextBox();
            this.tB_password = new System.Windows.Forms.TextBox();
            this.tB_confirm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_check = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tB_username
            // 
            this.tB_username.Location = new System.Drawing.Point(143, 117);
            this.tB_username.Multiline = true;
            this.tB_username.Name = "tB_username";
            this.tB_username.Size = new System.Drawing.Size(162, 26);
            this.tB_username.TabIndex = 0;
            this.tB_username.TextChanged += new System.EventHandler(this.tB_username_TextChanged);
            // 
            // tB_password
            // 
            this.tB_password.Location = new System.Drawing.Point(143, 184);
            this.tB_password.Multiline = true;
            this.tB_password.Name = "tB_password";
            this.tB_password.PasswordChar = '*';
            this.tB_password.Size = new System.Drawing.Size(162, 26);
            this.tB_password.TabIndex = 1;
            // 
            // tB_confirm
            // 
            this.tB_confirm.Location = new System.Drawing.Point(143, 247);
            this.tB_confirm.Multiline = true;
            this.tB_confirm.Name = "tB_confirm";
            this.tB_confirm.Size = new System.Drawing.Size(162, 26);
            this.tB_confirm.TabIndex = 2;
            this.tB_confirm.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "确认密码";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(141, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "*字母开头，8-12位字母和数字";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(141, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "*6-8位字母和数字";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(141, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "*请再次输入密码";
            // 
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(123, 336);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(76, 28);
            this.btn_check.TabIndex = 9;
            this.btn_check.Text = "确认";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(232, 336);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(76, 28);
            this.btn_reset.TabIndex = 10;
            this.btn_reset.Text = "重置";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 435);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tB_confirm);
            this.Controls.Add(this.tB_password);
            this.Controls.Add(this.tB_username);
            this.Name = "SignUp";
            this.Text = "注册";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SignUp_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tB_username;
        private System.Windows.Forms.TextBox tB_password;
        private System.Windows.Forms.TextBox tB_confirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.Button btn_reset;
    }
}