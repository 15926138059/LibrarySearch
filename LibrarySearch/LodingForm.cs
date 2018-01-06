using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySearch
{
    public partial class LodingForm : Form
    {
        public LodingForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value != 100)
            {
                progressBar1.Value+=10;
            }
            else
            {
                SignInForm signform = new SignInForm();
                signform.Show();
                this.Hide();
                timer1.Enabled = false;
            }
        }
    }
}
