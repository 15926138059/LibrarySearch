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
            a = textBox1.Text;
            b = comboBox1.SelectedIndex;
            using (SqlCommand cmd = con.CreateCommand())
            {
                switch (b)
                {
                    case 0: cmd.CommandText = "select bookName,author,publishingDate,pressName from BookClassTable,press where BookClassTable.pressID=press.pressID and BookClassTable.bookName = @a_in;"; break; // 图书名
                    case 1: cmd.CommandText = "select bookName,author,publishingDate,pressName from BookClassTable,press where BookClassTable.pressID=press.pressID and BookClassTable.author = @a_in;"; break; //作者名
                    case 2: cmd.CommandText = "select bookName,author,publishingDate,pressName from BookClassTable,press where BookClassTable.pressID=press.pressID and BookClassTable.ISBN = @a_in;"; break; //ISBN
                    case 3: cmd.CommandText = "select bookName,author,publishingDate,pressName from BookClassTable,press,book_subjectsTable,subjectsTable where BookClassTable.pressID=press.pressID and BookClassTable.ISBN=book_subjectssTable.ISBN and book_subjectsTable.subjectID=subjectsTable.subjectID and subjectsTable.subjectWord = @a_in;"; break; //主题词
                    case 4: cmd.CommandText = "select bookName,author,publishingDate,pressName from BookClassTable,press where BookClassTable.pressID=press.pressID and press.pressName = @a_in;"; break; //出版社
                    case 5: cmd.CommandText = "select bookName,author,publishingDate,pressName from BookClassTable,press,bookTable where BookClassTable.pressID=press.pressID and BookClassTable.ISBN=bookTable.ISBN and bookTable.bookID = @a_in;"; break; //索书号
                }
                cmd.Parameters.Add(new SqlParameter("a_in", a));
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
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
