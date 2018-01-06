namespace LibrarySearch
{
    partial class BookContentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookContentForm));
            this.textBox_Catalog = new System.Windows.Forms.TextBox();
            this.textBox_preRead = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_Catalog
            // 
            this.textBox_Catalog.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_Catalog.Font = new System.Drawing.Font("宋体", 13.5F);
            this.textBox_Catalog.Location = new System.Drawing.Point(8, 80);
            this.textBox_Catalog.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Catalog.Multiline = true;
            this.textBox_Catalog.Name = "textBox_Catalog";
            this.textBox_Catalog.ReadOnly = true;
            this.textBox_Catalog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Catalog.Size = new System.Drawing.Size(336, 385);
            this.textBox_Catalog.TabIndex = 0;
            // 
            // textBox_preRead
            // 
            this.textBox_preRead.Font = new System.Drawing.Font("宋体", 13.5F);
            this.textBox_preRead.Location = new System.Drawing.Point(370, 80);
            this.textBox_preRead.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_preRead.Multiline = true;
            this.textBox_preRead.Name = "textBox_preRead";
            this.textBox_preRead.ReadOnly = true;
            this.textBox_preRead.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_preRead.Size = new System.Drawing.Size(337, 385);
            this.textBox_preRead.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("宋体", 16F);
            this.textBox3.Location = new System.Drawing.Point(131, 23);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(72, 32);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "目录";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("宋体", 16F);
            this.textBox4.Location = new System.Drawing.Point(511, 23);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(68, 32);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "前言";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BookContentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibrarySearch.Properties.Resources.body_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(725, 482);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox_preRead);
            this.Controls.Add(this.textBox_Catalog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BookContentForm";
            this.Text = "图书预览";
            this.Load += new System.EventHandler(this.BookContentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Catalog;
        private System.Windows.Forms.TextBox textBox_preRead;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}