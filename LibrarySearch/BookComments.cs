using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySearch
{
    public class BookComments
    {
        //标题  
        public string title { get; set; }
        //作者  
        public string[] author { get; set; }
        //出版社  
        public string publisher { get; set; }
        //封面图片的url  
        public string image { get; set; }
        //isbn10  
        public string isbn10 { get; set; }
        //isbn13  
        public string isbn13 { get; set; }
        //出版日期  
        public string pubdate { get; set; }
        //概述  
        public string summary { get; set; }
        //页数  
        public string pages { get; set; }
        //价格  
        public string price { get; set; }
        //获取失败的返回信息  
        public string msg { get; set; }
        public string code { get; set; }

        //评论
        public string[] comment { get; set; }

        public string id { get; set; }

        public string starts { get; set; }




    }
}
