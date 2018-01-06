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
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        //初始化picbox
        private void ImageForm_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = null;
            List<string> booklist = FindTop3Book();
            List<string> urlList = LoadTop3Picture(booklist);
            if (pictureBox1.ImageLocation == null)
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlList[0]);
                using (WebResponse response = request.GetResponse())
                {
                    Image img = Image.FromStream(response.GetResponseStream());
                    pictureBox1.Image = img;
                    pictureBox1.ImageLocation = urlList[0];
                }
            }
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
                for(int i = 0; i < 3; i++)
                {
                    reader.Read();
                    booklist.Add(reader.GetString(0));
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
                for(int i=0;i<3;i++)
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add(new SqlParameter("ISBNCode", booklist[i]));
                    pathList.Add((string)cmd.ExecuteScalar());
                }
                
            }
            con.Close();
            if (pathList.Count !=0)
            {
                for(int i=0;i<3;i++)
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

        //定时轮流显示图片
        private void timer1_Tick(object sender, EventArgs e)
        {
            List<string> booklist = FindTop3Book();
            List<string>  urlList = LoadTop3Picture(booklist); 
            if(pictureBox1.ImageLocation==null)
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlList[0]);
                using (WebResponse response = request.GetResponse())
                {
                    Image img = Image.FromStream(response.GetResponseStream());
                    pictureBox1.Image = img;
                    pictureBox1.ImageLocation = urlList[0];
                }
            }
            else if (pictureBox1.ImageLocation==urlList[0])
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlList[1]);
                using (WebResponse response = request.GetResponse())
                {
                    Image img = Image.FromStream(response.GetResponseStream());
                    pictureBox1.Image = img;
                    pictureBox1.ImageLocation = urlList[1];
                }
            }
            else if (pictureBox1.ImageLocation == urlList[1])
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlList[2]);
                using (WebResponse response = request.GetResponse())
                {
                    Image img = Image.FromStream(response.GetResponseStream());
                    pictureBox1.Image = img;
                    pictureBox1.ImageLocation = urlList[2];
                }
            }
            else if (pictureBox1.ImageLocation == urlList[2])
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlList[0]);
                using (WebResponse response = request.GetResponse())
                {
                    Image img = Image.FromStream(response.GetResponseStream());
                    pictureBox1.Image = img;
                    pictureBox1.ImageLocation = urlList[0];
                }
            }


        }


    }
}
