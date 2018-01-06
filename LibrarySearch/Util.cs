using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace LibrarySearch
{
    public class Util
    {
        //连接数据库函数
        private static string _connectionString = ConfigurationManager.AppSettings["connectionstring"];
        public  static SqlConnection SqlConnection()
        {
            try
            {
                SqlConnection sqlConn = null;
                string connString = null;
                connString = _connectionString;
                sqlConn = new SqlConnection(connString);
                sqlConn.Open();
                sqlConn.Close();
                return sqlConn;
            }
            catch
            {
                throw new Exception("SQL Connection Error!");
            }
        }


        


        //HTTP的GET请求，获取书图书评论json
        private static string doGet(string url, string charset)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "text/html;charset=UTF-8";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            if (response != null)
            {
                Stream myResponseStream = response.GetResponseStream();
                StreamReader myStreamReader = new StreamReader(myResponseStream, System.Text.Encoding.GetEncoding(charset));
                string retString = myStreamReader.ReadToEnd();
                myStreamReader.Close();
                myResponseStream.Close();
                return retString;
            }
            throw new Exception();
        }


        //Json解析  
        private static BookComments toMap(string jsonString)
        {
            //实例化JavaScriptSerializer类的新实例  
            JavaScriptSerializer jss = new JavaScriptSerializer();
            try
            {
                //将指定的 JSON 字符串转换为 Dictionary<string, object> 类型的对象  
                return jss.Deserialize<BookComments>(jsonString);
            }
            catch
            {
                return null;
            }
        }

        //根据ISBN码从豆瓣API获取书籍详细信息  
        public static bool getInfo(string isbn, out BookComments bookInfo, out string jsonstr)
        {
            try
            {
                //豆瓣API  
                string uri = "https://api.douban.com/v2/book/isbn/" + isbn;
                //获取书籍详细信息，Json格式  
                jsonstr = doGet(uri, "utf-8");
                //将获取到的Json格式的文件转换为定义的类  
                bookInfo = toMap(jsonstr);
                uri = "https://api.douban.com/v2/book/"+bookInfo.id+ "/reviews";
                jsonstr = doGet(uri, "utf-8");

                bookInfo.comment = new string[3];
                JObject jo = (JObject)JsonConvert.DeserializeObject(jsonstr);
                JArray jlist = JArray.Parse(jo["reviews"].ToString());

                double startPoints = 0;
                for(int i=0;i<3;i++)
                {
                    string commentstr = ((JObject)JsonConvert.DeserializeObject(jlist[i].ToString()))["summary"].ToString();
                    string points = ((JObject)JsonConvert.DeserializeObject(jlist[i].ToString()))["rating"]["value"].ToString();
                    bookInfo.comment[i] = commentstr;
                    startPoints += (Convert.ToDouble(points));
                }
                startPoints = startPoints / 3.0;
                bookInfo.starts = Convert.ToString(startPoints);
                return true;
            }
            catch
            {
                //信息获取失败  
                bookInfo = null;
                jsonstr = "";
                return false;
            }
        }


        public static string[] knowledegGraph(string words)
        {
            
            //知识图谱API  
            string uri = "http://shuyantech.com/api/cndbpedia/ment2ent?q="+ words;
            //获取书籍详细信息，Json格式  
            string jsonstr = doGet(uri, "utf-8");
            JObject jo = (JObject)JsonConvert.DeserializeObject(jsonstr);
            JArray jlist = JArray.Parse(jo["ret"].ToString());
            string[] res = new string[jlist.Count];
            for(int i=0;i<jlist.Count;i++)
            {
                res[i] = jlist[i].ToString();
            }
            return res;
        }

    }
}
