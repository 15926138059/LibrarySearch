using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LibrarySearch
{
    public partial class SignInForm : Form
    {
        bool judge = false;

        public SignInForm()
        {
            InitializeComponent();
        }


        //点击事件
        private void btn_signin_Click(object sender, EventArgs e)
        {
            //登录
            signInFunction();
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            
            SignUp signUpForm = new SignUp(this);
            signUpForm.Show();
            this.Hide();
        }

        //登录函数
        private void signInFunction()
        {
            SqlConnection con = Util.SqlConnection();
            con.Open();
            string cmd = "select username,userpasword from UserTable where username=@uid";
            SqlCommand com = new SqlCommand(cmd, con);
            byte[] result = Encoding.Default.GetBytes(this.tB_password.Text.Trim());
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] output = md5.ComputeHash(result);
            string pwd = BitConverter.ToString(output).Replace("-", "");
            com.Parameters.Add(new SqlParameter("uid", tB_username.Text.Trim()));
            SqlDataReader reader = com.ExecuteReader();
            reader.Read();
            try
            {
                if (pwd == reader["userpasword"].ToString())
                {
                    judge = true;
                }
            }
            catch(Exception e)
            {
                e.ToString();
                MessageBox.Show("登录失败");
                return;
            }
            
            reader.Close();
            con.Close();
            if (judge == true)
            {
                BookSearchForm bookSearchForm = new BookSearchForm(this);
                bookSearchForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("用户名不存在或密码错误！");
                tB_username.Text = "";
                tB_password.Text = "";
                tB_username.Focus();
            }
        }

    }
}
