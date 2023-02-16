using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicLayer;
using System.Windows.Forms;

namespace CNIC_READER
{
    public partial class NewUserForm
    {
        public NewUserForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            logic_Class fc = logic_Class.get_Controller();
            MessageBox.Show(fc.store_NewUserData(textBox1.Text, textBox2.Text));
        }

    }
}
