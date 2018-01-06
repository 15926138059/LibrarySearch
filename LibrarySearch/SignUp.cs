using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySearch
{
    public partial class SignUp : Form
    {
        bool flag;
        public bool Userflag;
        public SignUp()
        {
            InitializeComponent();
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            Regex re1 = new Regex("^[a-zA-Z]{1}[a-zA-Z0-9]{7,11}$", RegexOptions.None);
            Regex re2 = new Regex("^[A-Za-z0-9]{6,8}$", RegexOptions.None);
            if (re1.IsMatch(tB_username.Text) && re2.IsMatch(tB_password.Text) && tB_password.Text== tB_confirm.Text)
                flag = true;
            else
            {
                if (!re1.IsMatch(tB_username.Text))
                {
                    MessageBox.Show("用户名不符合要求", "提示");
                    return;
                }
                if (!re2.IsMatch(tB_password.Text))
                {
                    MessageBox.Show("密码不符合要求", "提示");
                    return;
                }
                if (tB_password.Text!= tB_confirm.Text)
                {
                    MessageBox.Show("两次密码不一致", "提示");
                    return;
                }
            }
            if(Userflag)
            {
                MessageBox.Show("用户已经存在，请重新输入！");
                return;
            }
            if(flag)
            {
                SqlConnection con = Util.SqlConnection();
                con.Open();
                string cmd = "insert into UserTable(username,userpasword) values (@username,@password) ";
                SqlCommand com = new SqlCommand(cmd, con);
                byte[] result = Encoding.Default.GetBytes(this.tB_password.Text.Trim());   
                MD5 md5 = new MD5CryptoServiceProvider();
                byte[] output = md5.ComputeHash(result);
                string pwd = BitConverter.ToString(output).Replace("-", "");  
                com.Parameters.Add(new SqlParameter("username", tB_username.Text.Trim()));
                com.Parameters.Add(new SqlParameter("password", pwd));
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("注册成功！", "提示");
                this.Close();
                SignInForm form = new SignInForm();
                form.Show();
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            tB_username.Text = "";
            tB_password.Text = "";
            tB_confirm.Text = "";
            tB_username.Focus();
        }

        private void tB_username_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = Util.SqlConnection();
            con.Open();
            string cmd = "select username from UserTable";
            SqlCommand com = new SqlCommand(cmd, con);
            SqlDataReader readerUser = com.ExecuteReader();
            while (readerUser.Read())
            {
                if (tB_username.Text == readerUser["username"].ToString().Trim())
                {
                    label4.ForeColor = Color.Red;
                    label4.Text = "用户已存在，请重新输入！";
                    Userflag = true;                     
                    tB_username.Text = "";
                    tB_username.Focus();
                    return;
                }
                else if (tB_username.Text != readerUser["username"].ToString().Trim())
                {
                    label4.Text = "恭喜你，该用户名可以使用。";
                    Userflag = false;
                }
            }

        }
    }
}
