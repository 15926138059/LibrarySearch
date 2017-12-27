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
        private string ISBN= "";
        public BookDetail(string ISBN)
        {
            InitializeComponent();
            this.ISBN = ISBN;
        }

        public BookDetail(string ISBN,BookSearchForm bookSearchForm)
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





        }

        //加载图书信息
        private void LoadBookInfo()
        {
            string bookID = "";
            string bookLoc = "";
            string BookCount = "";
            string pressYear = "";

            string sql = "select bookTable.bookID,printDate,circulationFlag,libarayName " +
                "from bookTable, bookKeep,location " +
                "where bookTable.ISBN = @ISBNCode " +
                "and bookTable.bookID = bookKeep.bookID " +
                "and bookKeep.libraryID = location.libraryID";
            SqlConnection con = Util.SqlConnection();
            con.Open();
            using (SqlCommand cmd = con.CreateCommand())
            {

                //定义查询语句,其中@username和@passwd是参数变量  
                cmd.CommandText = sql;
                //将name的数据赋值给查询语句中的ISBNCode  
                cmd.Parameters.Add(new SqlParameter("ISBNCode", ISBN));
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    bookID = reader.GetString(0);
                    pressYear = reader.GetDateTime(1).Year.ToString();
                    BookCount = reader.GetBoolean(2)?"是":"否";
                    bookLoc = reader.GetString(3);
                    dG_book.Rows.Add(bookID, bookLoc, BookCount, pressYear);
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

            string sql = "select bookName,author,pressName,cnBookDescribe,collectionNumber " +
                "from BookClassTable, press,cnBookClassifyTable " +
                "where BookClassTable.ISBN = @ISBNCode" +
                " and BookClassTable.pressID = press.pressID" +
                " and BookClassTable.cnBookClass = cnBookClassifyTable.cnBookClass; ";
            SqlConnection con = Util.SqlConnection();
            con.Open();
            using (SqlCommand cmd = con.CreateCommand())
            {

                //定义查询语句,其中@username和@passwd是参数变量  
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
            param[0] = new SqlParameter("@userName", ISBN);
            string sql = "select coverImage from coverTable where ISBN = @ISBNCode;";
            SqlConnection con = Util.SqlConnection();
            con.Open();
            using (SqlCommand cmd = con.CreateCommand())
            {

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
                try
                {
                    Image img = Image.FromStream(response.GetResponseStream());
                    pic_book.Image = img;
                }
               catch(Exception e )
                {
                    e.ToString();
                    pic_book.Image = null;
                }
            }
        }

        private void BookDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.bookSearchForm.Show();
            
        }
    }
}
