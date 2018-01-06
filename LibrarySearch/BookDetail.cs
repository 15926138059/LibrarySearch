using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LibrarySearch
{
    public partial class BookDetail : Form
    {
        private BookSearchForm bookSearchForm;
        private string ISBN = "";
        public BookDetail()
        {
            InitializeComponent();
        }

        public BookDetail(string ISBN, BookSearchForm bookSearchForm)
        {
            InitializeComponent();
            this.ISBN = ISBN;
            this.bookSearchForm = bookSearchForm;
        }


        //窗体加载时，以url形式加载图片
        private void BookDetail_Load(object sender, EventArgs e)
        {

            LoadPicture();//加载图书封面
            LoadBookClassInfo();//加载图书类信息
            LoadBookInfo();//加载图书信息
            DouBan();
            setSubjects();
        }

        //加载图书信息
        private void LoadBookInfo()
        {
            string bookID = "";
            string bookLoc = "";
            string BookCount = "";
            string wordsCounts = "";
            string pageCount = "";
            string layOutSpecification = "";

            string sql = "selBookInfo";
            SqlConnection con = Util.SqlConnection();
            con.Open();
            using (SqlCommand cmd = con.CreateCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                //定义查询语句,其中@username和@passwd是参数变量  
                cmd.CommandText = sql;
                //将name的数据赋值给查询语句中的ISBNCode  
                cmd.Parameters.Add(new SqlParameter("ISBNCode", ISBN));
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    bookID = reader.GetString(0);
                    BookCount = reader.GetBoolean(1)?"是":"否";
                    bookLoc = reader.GetString(2);
                    wordsCounts = Convert.ToString(reader.GetInt64(3));
                    pageCount = Convert.ToString(reader.GetInt64(4));
                    layOutSpecification = reader.GetString(5);
                    dG_book.Rows.Add(bookID, bookLoc, BookCount, wordsCounts,pageCount,layOutSpecification);
                }
            }
            con.Close();
        }


        //加载图书类信息
        private void LoadBookClassInfo()
        {
            string bookName = "";//从数据库中获取书名
            string bookAuthor = "";//从数据库中获取作者       
            string pressName = "";//从数据库中获取出版社名称
            string cnCodeDescribe = "";//从数据库获取中图码描述
            string bookCount = "";

            string sql = "selBookClass";
            SqlConnection con = Util.SqlConnection();
            con.Open();
            using (SqlCommand cmd = con.CreateCommand())
            {

                cmd.CommandType = CommandType.StoredProcedure;
                //定义查询语句
                cmd.CommandText = sql;
                //将name的数据赋值给查询语句中的ISBNCode  
                cmd.Parameters.Add(new SqlParameter("ISBNCode", ISBN));
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                bookName = reader.GetString(0);
                bookAuthor = reader.GetString(1);
                pressName = reader.GetString(2);
                cnCodeDescribe = reader.GetString(3);
                bookCount = Convert.ToString(reader.GetInt32(4));
            }
            con.Close();
            lab_bookname.Text = bookName;
            lab_author.Text = bookAuthor;
            lab_cnType.Text = cnCodeDescribe;
            lab_pressname.Text = pressName;
            lab_count.Text = bookCount;
        }
        //加载图书封面
        private void LoadPicture()
        {
            string path = "";//从数据库中获取图片相对路径
            string url = "";//完整图片url
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
                cmd.Parameters.Add(new SqlParameter("ISBNCode", ISBN));
                path = (string)cmd.ExecuteScalar();
            }
            con.Close();
            if (path != "")
            {
                url = @"http://115.159.197.73/LibrarySearch/images/" + path;
            }
            else
            {
                url = null;
            }
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            using (WebResponse response = request.GetResponse())
            {
                Image img = Image.FromStream(response.GetResponseStream());
                pic_book.Image = img;
            }
        }   

        //豆瓣信息
        public void DouBan()
        {
            BookComments comments = new BookComments();
            string json = "";

            if (Util.getInfo(ISBN, out comments, out json))
            {
                lab_douban.Text = comments.starts + "星";
                lab_com.Text = lab_com.Text + "\n\n    " + comments.comment[0];
            }
        }

        private void tb_in_TextChanged(object sender, EventArgs e)
        {
            //string word = tb_in.Text;
            //string[] array = Util.knowledegGraph(word);
            //this.tb_in.AutoCompleteCustomSource.AddRange(array);
        }

        //显示主题词
        public void setSubjects()
        {
            string booksubJects = "";
            

            string sql = "selSubjects ";
            SqlConnection con = Util.SqlConnection();
            con.Open();
            using (SqlCommand cmd = con.CreateCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                //定义查询语句
                cmd.CommandText = sql;
                //将name的数据赋值给查询语句中的ISBNCode  
                cmd.Parameters.Add(new SqlParameter("ISBNCode", ISBN));
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    booksubJects = booksubJects+reader.GetString(0)+" ";
                }
            }
            con.Close();
            lab_sj.Text = booksubJects;
        }

        private void pic_book_Click(object sender, EventArgs e)
        {
            BookContentForm form = new BookContentForm(ISBN);
            form.Show();
        }
    }
}
