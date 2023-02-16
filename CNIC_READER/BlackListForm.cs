using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicLayer;
namespace CNIC_READER
{
    public partial class BlackListForm : Form
    {
        public BlackListForm()
        {
            InitializeComponent();
            data_load();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            logic_Class fc = logic_Class.get_Controller();
            //fc.return_Card_Data(textBox1.Text);
            MessageBox.Show( fc.insertblockdata(tbname.Text, tbnic.Text));
        }

        private void data_load()
        {
            logic_Class fc = logic_Class.get_Controller();
            dataGridViewNIC.DataSource = fc.calldatafromblacklist();

        }

    }
}
