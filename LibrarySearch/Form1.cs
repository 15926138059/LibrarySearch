using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibrarySearch
{
    public partial class Form1 : Form
    {
        string a = null;
        int  b;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bookname, author, pressdate, press;
            SqlConnection con = Util.SqlConnection();
            con.Open();
            dataGridView1.Rows.Clear();
            a = textBox1.Text;
            b = comboBox1.SelectedIndex;
            using (SqlCommand cmd = con.CreateCommand())
            {
                switch (b)
                {
                    case 0: cmd.CommandText = "select bookName,author,publishingDate,pressName from BookNameSearchView where bookName like @a_in;"; break; // 图书名
                    case 1: cmd.CommandText = "select bookName,author,publishingDate,pressName from BookNameSearchView where author like @a_in;"; break; //作者名
                    case 2: cmd.CommandText = "select bookName,author,publishingDate,pressName from BookNameSearchView where ISBN like @a_in;"; break; //ISBN
                    case 3: cmd.CommandText = "select bookName,author,publishingDate,pressName from BookSubjectsView where subjectWord like @a_in;"; break; //主题词
                    case 4: cmd.CommandText = "select bookName,author,publishingDate,pressName from BookSubjectsView where pressName like @a_in;"; break; //出版社
                    case 5: cmd.CommandText = "select bookName,author,publishingDate,pressName from BookIDView where bookID like @a_in;"; break; //索书号
                }
                cmd.Parameters.Add(new SqlParameter("a_in", "%"+a+"%"));
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    bookname = reader.GetString(0);
                    author = reader.GetString(1);
                    pressdate = reader.GetDateTime(2).Year.ToString();
                    press = reader.GetString(3);
                    dataGridView1.Rows.Add(bookname, author,pressdate,press);
                    dataGridView1.Visible = true;
                }

            }
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            this.BackgroundImage = Image.FromFile(@"C:\Users\Admin\Desktop\images\body_bg.JPG");
            this.dataGridView1.BackgroundColor = this.dataGridView1.Parent.BackColor;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
