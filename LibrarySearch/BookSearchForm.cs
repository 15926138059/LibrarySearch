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
    public partial class BookSearchForm : Form
    {
        SignInForm signInform;

        string userInput = null;
        List<string> ISBNList= new List<string>();
        int  userSelect;
        public BookSearchForm()
        {
            InitializeComponent();
        }


        public BookSearchForm(SignInForm signInform)
        {
            InitializeComponent();
            this.signInform = signInform;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SearchBook();
        }


        //按类型查找图书
        private void SearchBook()
        {
            dataGridView1.Rows.Clear();
            ISBNList.Clear();
            string bookname, author, pressdate, press;
            SqlConnection con = Util.SqlConnection();
            con.Open();
            userInput = textBox1.Text;
            userSelect = comboBox1.SelectedIndex;
            using (SqlCommand cmd = con.CreateCommand())
            {
                switch (userSelect)
                {
                    case 0: cmd.CommandText = "select bookName,author,publishingDate,pressName,BookClassTable.ISBN from BookClassTable,press where BookClassTable.pressID=press.pressID and BookClassTable.bookName = @a_in;"; break; // 图书名
                    case 1: cmd.CommandText = "select bookName,author,publishingDate,pressName,BookClassTable.ISBN from BookClassTable,press where BookClassTable.pressID=press.pressID and BookClassTable.author = @a_in;"; break; //作者名
                    case 2: cmd.CommandText = "select bookName,author,publishingDate,pressName,BookClassTable.ISBN from BookClassTable,press where BookClassTable.pressID=press.pressID and BookClassTable.ISBN = @a_in;"; break; //ISBN
                    case 3: cmd.CommandText = "select bookName,author,publishingDate,pressName,BookClassTable.ISBN from BookClassTable,press,book_subjectsTable,subjectsTable where BookClassTable.pressID=press.pressID and BookClassTable.ISBN=book_subjectssTable.ISBN and book_subjectsTable.subjectID=subjectsTable.subjectID and subjectsTable.subjectWord = @a_in;"; break; //主题词
                    case 4: cmd.CommandText = "select bookName,author,publishingDate,pressName,BookClassTable.ISBN from BookClassTable,press where BookClassTable.pressID=press.pressID and press.pressName = @a_in;"; break; //出版社
                    case 5: cmd.CommandText = "select bookName,author,publishingDate,pressName,BookClassTable.ISBN from BookClassTable,press,bookTable where BookClassTable.pressID=press.pressID and BookClassTable.ISBN=bookTable.ISBN and bookTable.bookID = @a_in;"; break; //索书号
                }
                cmd.Parameters.Add(new SqlParameter("a_in", userInput));
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    bookname = reader.GetString(0);
                    author = reader.GetString(1);
                    pressdate = reader.GetDateTime(2).Year.ToString();
                    press = reader.GetString(3);
                    ISBNList.Add(reader.GetString(4));
                    dataGridView1.Rows.Add(bookname, author, pressdate, press);
                    dataGridView1.Visible = true;
                }

            }
            con.Close();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        //单元第一列单元格事件
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                string ISBN = ISBNList[e.RowIndex];
                BookDetail bookDetail = new BookDetail(ISBN,this);
                bookDetail.Show();
            }
            else
            {
                return;
            }

        }

        private void dataGridView1_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void BookSearchForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.signInform.Show();
        }
    }
}
