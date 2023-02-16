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
using LogicLayer;
namespace CNIC_READER
{
    public partial class CardReturnForm : Form
    {
        string id="";
        public CardReturnForm()
        {
            InitializeComponent();
            panel1.Hide();
        }

        public CardReturnForm(SqlConnection connection)
        {
            InitializeComponent();
        }
            private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            string[] arr = new string[8];
            logic_Class fc = logic_Class.get_Controller();
            arr = fc.return_Card_Data(textBox1.Text);
            if (!(String.IsNullOrEmpty(arr[3])))
            {
                panel1.Show();
                id = arr[0];
                lbnam.Text = arr[1];
                lbFname.Text = arr[2];
                lbcnic.Text = arr[3];
                lbgender.Text = arr[4];
                lbphone.Text = arr[5];
                lbreson.Text = arr[6];
                lbtime.Text = arr[7];
            }
            else
                MessageBox.Show("No Entery Data found");
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            logic_Class fc = logic_Class.get_Controller();
             fc.Return_Card(id);
            panel1.Hide();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            panel1.Hide();
        }
    }
}
