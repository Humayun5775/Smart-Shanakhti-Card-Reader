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
    public partial class DetailFrom : Form
    {
        public DetailFrom()
        {
            InitializeComponent();
            data_load();
        }

        private void data_load()
        {
            logic_Class fc = logic_Class.get_Controller();
            dataGridViewNIC.DataSource = fc.calldata();
            
        }
        

        private void tbcnic_TextChanged(object sender, EventArgs e)
        {
            logic_Class fc = logic_Class.get_Controller();
            dataGridViewNIC.DataSource = fc.callfromcnic(tbcnic.Text);
        }

        private void tbname_TextChanged(object sender, EventArgs e)
        {
            logic_Class fc = logic_Class.get_Controller();
            dataGridViewNIC.DataSource = fc.callfromname(tbname.Text);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            logic_Class fc = logic_Class.get_Controller();
            dataGridViewNIC.DataSource = fc.callfromdate(dateTimePicker1.Value);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //DateTime dateTime = DateTime.Now;

            //MessageBox.Show(dateTime.Date.ToString("MM/dd/yyyy"));
            logic_Class fc = logic_Class.get_Controller();
            dataGridViewNIC.DataSource = fc.calldatafromall(tbname.Text,tbcnic.Text,dateTimePicker1.Value,dateTimePicker2.Value);
        }
        
        private void dataGridViewNIC_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show((e.RowIndex).ToString());
           
            DataGridViewRow row = dataGridViewNIC.Rows[e.RowIndex];
            string b = row.Cells[0].Value.ToString();

            PersonDetailForm personDetailForm = new PersonDetailForm(b);
            personDetailForm.Show();
        }
    }
}
