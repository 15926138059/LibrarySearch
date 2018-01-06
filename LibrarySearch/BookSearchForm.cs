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
using System.Net;

namespace LibrarySearch
{
    public partial class BookSearchForm : Form
    {
        string a = null;
        int  b;
        List<string> ISBNList = new List<string>();
        SignInForm signInform;

        public BookSearchForm()
        {
            InitializeComponent();
            pictureBox2.ImageLocation = null;
            List<string> booklist = FindTop3Book();
            List<string> urlList = LoadTop3Picture(booklist);
            if (pictureBox2.ImageLocation == null)
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlList[0]);
                using (WebResponse response = request.GetResponse())
                {
                    Image img = Image.FromStream(response.GetResponseStream());
                    pictureBox2.Image = img;
                    pictureBox2.ImageLocation = urlList[0];
                }
            }
        }

        public BookSearchForm(SignInForm signInform)
        {
            InitializeComponent();
            this.signInform = signInform;
            pictureBox2.ImageLocation = null;
            List<string> booklist = FindTop3Book();
            List<string> urlList = LoadTop3Picture(booklist);
            if (pictureBox2.ImageLocation == null)
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlList[0]);
                using (WebResponse response = request.GetResponse())
                {
                    Image img = Image.FromStream(response.GetResponseStream());
                    pictureBox2.Image = img;
                    pictureBox2.ImageLocation = urlList[0];
                }
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            dataGridView1.Rows.Clear();
            ISBNList.Clear();
            string bookname, author, pressdate, press;
            SqlConnection con = Util.SqlConnection();
            con.Open();
            dataGridView1.Rows.Clear();
            a = textBox1.Text;
            b = comboBox1.SelectedIndex;
            pictureBox2.Visible = false;
            label1.Visible = false;
            dataGridView1.Visible = true;

            lab_book1.Visible = false;
            lab_book2.Visible = false;
            lab_book3.Visible = false;

            showKonwledge();

            using (SqlCommand cmd = con.CreateCommand())
            {
                switch (b)
                {
                    case 0: cmd.CommandText = "select bookName,author,publishingDate,pressName,ISBN from BookNameSearchView where bookName like @a_in;"; break; //图书名
                    case 1: cmd.CommandText = "select bookName,author,publishingDate,pressName,ISBN from BookNameSearchView where author like @a_in;"; break; //作者名
                    case 2: cmd.CommandText = "select bookName,author,publishingDate,pressName,ISBN from BookNameSearchView where ISBN like @a_in;"; break; //ISBN
                    case 3: cmd.CommandText = "select bookName,author,publishingDate,pressName,ISBN from BookSubjectsView where subjectWord like @a_in;"; break; //主题词
                    case 4: cmd.CommandText = "select bookName,author,publishingDate,pressName,ISBN from BookSubjectsView where pressName like @a_in;"; break; //出版社
                    case 5: cmd.CommandText = "select bookName,author,publishingDate,pressName,ISBN from BookIDView where bookID like @a_in;"; break; //索书号
                }
                cmd.Parameters.Add(new SqlParameter("a_in", "%"+a+"%"));
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    bookname = reader.GetString(0);
                    author = reader.GetString(1);
                    pressdate = reader.GetDateTime(2).Year.ToString();
                    press = reader.GetString(3);
                    ISBNList.Add(reader.GetString(4));
                    dataGridView1.Rows.Add(bookname, author,pressdate,press);
                    dataGridView1.Visible = true;
                }

            }
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            this.dataGridView1.BackgroundColor = this.dataGridView1.Parent.BackColor;
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                string ISBN = ISBNList[e.RowIndex];
                BookDetail bookDetail = new BookDetail(ISBN, this);
                bookDetail.Show();


                SqlConnection con = Util.SqlConnection();
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {

                    cmd.Parameters.Add(new SqlParameter("@ISBNCode",ISBN));
                    cmd.CommandText = "update searchCount set Scount = Scount+1 where ISBN = @ISBNCode";
                    cmd.ExecuteNonQuery();
                }

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



       




        //找到前三本热门书
        private List<string> FindTop3Book()
        {
            List<string> booklist = new List<string>();
            string sql = "selTop3Book";
            SqlConnection con = Util.SqlConnection();
            con.Open();
            using (SqlCommand cmd = con.CreateCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                //定义查询语句
                cmd.CommandText = sql;
                SqlDataReader reader = cmd.ExecuteReader();
                for (int i = 0; i < 3; i++)
                {
                    reader.Read();
                    booklist.Add(reader.GetString(0));
                    if(i==0)
                    {
                        lab_book1.Text = reader.GetString(1) + "\n  " + reader.GetString(2);
                    }
                    else if (i == 1)
                    {
                        lab_book2.Text = reader.GetString(1) + "\n  " + reader.GetString(2);
                    }
                    else if (i == 2)
                    {
                        lab_book3.Text = reader.GetString(1) + "\n  " + reader.GetString(2);
                    }
                }

            }
            con.Close();
            return booklist;

        }


        //找到图片路径
        private List<string> LoadTop3Picture(List<string> booklist)
        {
            List<string> pathList = new List<string>();
            List<string> urlList = new List<string>();//完整图片url
            SqlParameter[] param = new SqlParameter[1];
            string sql = "selPic";
            SqlConnection con = Util.SqlConnection();
            con.Open();
            using (SqlCommand cmd = con.CreateCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                //定义查询语句,其中@username和@passwd是参数变量  
                cmd.CommandText = sql;
                //将name的数据赋值给查询语句中的ISBNCode
                for (int i = 0; i < 3; i++)
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add(new SqlParameter("ISBNCode", booklist[i]));
                    pathList.Add((string)cmd.ExecuteScalar());
                }

            }
            con.Close();
            if (pathList.Count != 0)
            {
                for (int i = 0; i < 3; i++)
                {
                    urlList.Add(@"http://115.159.197.73/LibrarySearch/images/" + pathList[i]);
                }

            }
            else
            {
                urlList = null;
            }
            return urlList;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            List<string> booklist = FindTop3Book();
            List<string> urlList = LoadTop3Picture(booklist);
            if (pictureBox2.ImageLocation == null)
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlList[0]);
                using (WebResponse response = request.GetResponse())
                {
                    Image img = Image.FromStream(response.GetResponseStream());
                    pictureBox2.Image = img;
                    pictureBox2.ImageLocation = urlList[0];
                }
            }
            else if (pictureBox2.ImageLocation == urlList[0])
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlList[1]);
                using (WebResponse response = request.GetResponse())
                {
                    Image img = Image.FromStream(response.GetResponseStream());
                    pictureBox2.Image = img;
                    pictureBox2.ImageLocation = urlList[1];
                }
            }
            else if (pictureBox2.ImageLocation == urlList[1])
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlList[2]);
                using (WebResponse response = request.GetResponse())
                {
                    Image img = Image.FromStream(response.GetResponseStream());
                    pictureBox2.Image = img;
                    pictureBox2.ImageLocation = urlList[2];
                }
            }
            else if (pictureBox2.ImageLocation == urlList[2])
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlList[0]);
                using (WebResponse response = request.GetResponse())
                {
                    Image img = Image.FromStream(response.GetResponseStream());
                    pictureBox2.Image = img;
                    pictureBox2.ImageLocation = urlList[0];
                }
            }
        }

        public void showKonwledge()
        {
            string word = textBox1.Text;
            string[] resArray = Util.knowledegGraph(word);
            lab_book1.Text = "";
            label1.Visible = true;
            lab_book1.Visible = true;
            label1.Text = "相关知识";
            for(int i=0;i<resArray.Length;i++)
            {
                lab_book1.Text = lab_book1.Text + resArray[i] + "\n";
            }
                
        }

    }
}
