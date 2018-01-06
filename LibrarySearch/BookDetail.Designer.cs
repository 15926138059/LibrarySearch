namespace LibrarySearch
{
    partial class BookDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookDetail));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pic_book = new CCWin.SkinControl.SkinPictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lab_sj = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lab_com = new System.Windows.Forms.Label();
            this.lab_count = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lab_cnType = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lab_douban = new System.Windows.Forms.Label();
            this.lab_pressname = new System.Windows.Forms.Label();
            this.lab_author = new System.Windows.Forms.Label();
            this.lab_bookname = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dG_book = new System.Windows.Forms.DataGridView();
            this.bookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookLoaction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookFlag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wordsCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pageCounts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.layOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_book)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dG_book)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.91327F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.08673F));
            this.tableLayoutPanel1.Controls.Add(this.pic_book, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 94);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.67202F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.32798F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 561);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pic_book
            // 
            this.pic_book.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_book.BackColor = System.Drawing.Color.Transparent;
            this.pic_book.Location = new System.Drawing.Point(3, 3);
            this.pic_book.Name = "pic_book";
            this.pic_book.Size = new System.Drawing.Size(205, 239);
            this.pic_book.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_book.TabIndex = 0;
            this.pic_book.TabStop = false;
            this.pic_book.Click += new System.EventHandler(this.pic_book_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lab_sj);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.lab_count);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lab_cnType);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lab_douban);
            this.groupBox1.Controls.Add(this.lab_pressname);
            this.groupBox1.Controls.Add(this.lab_author);
            this.groupBox1.Controls.Add(this.lab_bookname);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(214, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 239);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // lab_sj
            // 
            this.lab_sj.AutoSize = true;
            this.lab_sj.Location = new System.Drawing.Point(147, 214);
            this.lab_sj.Name = "lab_sj";
            this.lab_sj.Size = new System.Drawing.Size(41, 12);
            this.lab_sj.TabIndex = 18;
            this.lab_sj.Text = "主题词";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 15F);
            this.label6.Location = new System.Drawing.Point(21, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "主题词";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lab_com);
            this.panel2.Location = new System.Drawing.Point(335, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(184, 100);
            this.panel2.TabIndex = 15;
            // 
            // lab_com
            // 
            this.lab_com.Location = new System.Drawing.Point(3, 0);
            this.lab_com.Name = "lab_com";
            this.lab_com.Size = new System.Drawing.Size(178, 100);
            this.lab_com.TabIndex = 14;
            this.lab_com.Text = "评论";
            // 
            // lab_count
            // 
            this.lab_count.AutoSize = true;
            this.lab_count.Location = new System.Drawing.Point(147, 137);
            this.lab_count.Name = "lab_count";
            this.lab_count.Size = new System.Drawing.Size(41, 12);
            this.lab_count.TabIndex = 13;
            this.lab_count.Text = "馆藏书";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15F);
            this.label3.Location = new System.Drawing.Point(21, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "馆藏书";
            // 
            // lab_cnType
            // 
            this.lab_cnType.AutoSize = true;
            this.lab_cnType.Location = new System.Drawing.Point(147, 107);
            this.lab_cnType.Name = "lab_cnType";
            this.lab_cnType.Size = new System.Drawing.Size(29, 12);
            this.lab_cnType.TabIndex = 11;
            this.lab_cnType.Text = "类型";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 15F);
            this.label8.Location = new System.Drawing.Point(21, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "类型";
            // 
            // lab_douban
            // 
            this.lab_douban.AutoSize = true;
            this.lab_douban.Location = new System.Drawing.Point(454, 38);
            this.lab_douban.Name = "lab_douban";
            this.lab_douban.Size = new System.Drawing.Size(53, 12);
            this.lab_douban.TabIndex = 9;
            this.lab_douban.Text = "豆瓣评分";
            // 
            // lab_pressname
            // 
            this.lab_pressname.AutoSize = true;
            this.lab_pressname.Location = new System.Drawing.Point(147, 178);
            this.lab_pressname.Name = "lab_pressname";
            this.lab_pressname.Size = new System.Drawing.Size(41, 12);
            this.lab_pressname.TabIndex = 8;
            this.lab_pressname.Text = "出版社";
            // 
            // lab_author
            // 
            this.lab_author.AutoSize = true;
            this.lab_author.Location = new System.Drawing.Point(147, 73);
            this.lab_author.Name = "lab_author";
            this.lab_author.Size = new System.Drawing.Size(29, 12);
            this.lab_author.TabIndex = 6;
            this.lab_author.Text = "作者";
            // 
            // lab_bookname
            // 
            this.lab_bookname.AutoSize = true;
            this.lab_bookname.Location = new System.Drawing.Point(147, 37);
            this.lab_bookname.Name = "lab_bookname";
            this.lab_bookname.Size = new System.Drawing.Size(29, 12);
            this.lab_bookname.TabIndex = 5;
            this.lab_bookname.Text = "书名";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 15F);
            this.label5.Location = new System.Drawing.Point(21, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "出版社";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 15F);
            this.label4.Location = new System.Drawing.Point(331, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "豆瓣评分";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F);
            this.label2.Location = new System.Drawing.Point(21, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "作者";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F);
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "书名";
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.dG_book);
            this.panel1.Location = new System.Drawing.Point(3, 248);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 231);
            this.panel1.TabIndex = 2;
            // 
            // dG_book
            // 
            this.dG_book.AllowUserToAddRows = false;
            this.dG_book.AllowUserToDeleteRows = false;
            this.dG_book.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dG_book.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dG_book.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookID,
            this.bookLoaction,
            this.bookFlag,
            this.wordsCount,
            this.pageCounts,
            this.layOut});
            this.dG_book.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dG_book.Location = new System.Drawing.Point(0, 0);
            this.dG_book.Name = "dG_book";
            this.dG_book.ReadOnly = true;
            this.dG_book.RowTemplate.Height = 23;
            this.dG_book.Size = new System.Drawing.Size(778, 231);
            this.dG_book.TabIndex = 0;
            // 
            // bookID
            // 
            this.bookID.HeaderText = "图书类";
            this.bookID.Name = "bookID";
            this.bookID.ReadOnly = true;
            // 
            // bookLoaction
            // 
            this.bookLoaction.HeaderText = "馆藏地点";
            this.bookLoaction.Name = "bookLoaction";
            this.bookLoaction.ReadOnly = true;
            // 
            // bookFlag
            // 
            this.bookFlag.HeaderText = "是否流通";
            this.bookFlag.Name = "bookFlag";
            this.bookFlag.ReadOnly = true;
            // 
            // wordsCount
            // 
            this.wordsCount.HeaderText = "字数";
            this.wordsCount.Name = "wordsCount";
            this.wordsCount.ReadOnly = true;
            // 
            // pageCounts
            // 
            this.pageCounts.HeaderText = "页数";
            this.pageCounts.Name = "pageCounts";
            this.pageCounts.ReadOnly = true;
            // 
            // layOut
            // 
            this.layOut.HeaderText = "开本";
            this.layOut.Name = "layOut";
            this.layOut.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(784, 100);
            this.panel3.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::LibrarySearch.Properties.Resources.head;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1346, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BookDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibrarySearch.Properties.Resources.body_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 527);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BookDetail";
            this.Text = "图书详细信息";
            this.Load += new System.EventHandler(this.BookDetail_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_book)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dG_book)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CCWin.SkinControl.SkinPictureBox pic_book;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lab_bookname;
        private System.Windows.Forms.Label lab_author;
        private System.Windows.Forms.Label lab_douban;
        private System.Windows.Forms.Label lab_pressname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lab_cnType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dG_book;
        private System.Windows.Forms.Label lab_count;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lab_com;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookLoaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookFlag;
        private System.Windows.Forms.DataGridViewTextBoxColumn wordsCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn pageCounts;
        private System.Windows.Forms.DataGridViewTextBoxColumn layOut;
        private System.Windows.Forms.Label lab_sj;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}