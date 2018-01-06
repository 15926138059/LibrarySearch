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
    public partial class BookContentForm : Form
    {
        string ISBN = "";

        public BookContentForm()
        {
            InitializeComponent();

        }

        public BookContentForm(string ISBN)
        {
            InitializeComponent();
            this.ISBN = ISBN;
        }




        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void BookContentForm_Load(object sender, EventArgs e)
        {
            string catalog;  //目录
            string preRead;  //简介
            

            SqlConnection con = Util.SqlConnection();
            con.Open();
            using (SqlCommand cmd = con.CreateCommand())
            {
                cmd.CommandText = "select catalogContent,preContent from dbo.BookPreConentView where ISBN=@ISBN;";
                cmd.Parameters.Add(new SqlParameter("@ISBN", ISBN));
                SqlDataReader readercatalog = cmd.ExecuteReader();
                while (readercatalog.Read())
                {
                    //设置目录表
                    catalog = readercatalog.GetString(0);
                    textBox_Catalog.Text = catalog;
                    textBox_Catalog.ReadOnly = true;
                    textBox_Catalog.Select(0, 0);

                    //设置图书简介
                    preRead = readercatalog.GetString(1);
                    textBox_preRead.Text = preRead;
                    textBox_preRead.ReadOnly = true;
                    textBox_preRead.Select(0, 0);

                }

            }

            con.Close();
        }
    }
    
}
