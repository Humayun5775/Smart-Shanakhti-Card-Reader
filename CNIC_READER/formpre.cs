using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNIC_READER
{
    public partial class formpre : Form
    {
        public formpre()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(@"D:\img\test.jpg");
            pictureBox3.Image = Image.FromFile(@"D:\savedImage.jpg");
            pictureBox4.Image = Image.FromFile(@"D:\opening.jpg");
            pictureBox2.Image = Image.FromFile(@"D:\gray.jpg");

        }

        private void formpre_Load(object sender, EventArgs e)
        {

        }
    }
}
