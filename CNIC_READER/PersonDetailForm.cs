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
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace CNIC_READER
{
    public partial class PersonDetailForm : Form
    {
        public PersonDetailForm()
        {
            InitializeComponent();
        }
        public PersonDetailForm( string id)
        {
            InitializeComponent();
            load_data(id);

        }
        string piclocation = null;
        private void load_data(string id)
        {
            logic_Class fc = logic_Class.get_Controller();


            string[] arr = fc.Person_Data(id);
             
            
            if (!(String.IsNullOrEmpty(arr[3])))
            {
                id = arr[0];
                lbnam.Text = arr[1];
                lbFname.Text = arr[2];
                lbcnic.Text = arr[3];
                lbgender.Text = arr[4];
                lbphone.Text = arr[5];
               // lbreson.Text = arr[6];
                lbtime.Text = arr[7];
                lbtimeout.Text = arr[8];

                // Image x = (Bitmap)((new ImageConverter()).ConvertFrom(image));
                //Again convert byteArray to image and displayed in a picturebox
                try
                {
                    pictureBox1.Image = System.Drawing.Image.FromFile(arr[9].ToString());
                    piclocation = arr[9].ToString();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show("No Entery Data found");
        }

        //convert bytearray to image
        System.Drawing.Image byteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream mStream = new MemoryStream(byteArrayIn))
            {
                return System.Drawing.Image.FromStream(mStream);
            }
        }

        private void btnmoredetails_Click(object sender, EventArgs e)
        {
            logic_Class fc = logic_Class.get_Controller();
            dataGridView.DataSource = fc.Call_In_Out(lbcnic.Text);
           exportdetail();
        }


        private void exportdetail()
        {
            if (dataGridView.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Output.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {

                        try
                        {
                            Paragraph para = new Paragraph("\nName : " + lbnam.Text + "\nFather Name : " + lbFname.Text + "\nCNIC : " + lbcnic.Text + "\nGender : " + lbgender.Text + "\nPhone : " + lbphone.Text + "\n\n", FontFactory.GetFont("Arial", 16, iTextSharp.text.Font.BOLD, BaseColor.BLACK));
                            para.Alignment = Element.ALIGN_LEFT;

                            PdfPTable pdfTable = new PdfPTable(dataGridView.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;
                           
                            iTextSharp.text.Image png = iTextSharp.text.Image.GetInstance(piclocation);
                            png.ScaleToFit(300f, 300f);
                            png.Alignment = Element.DIV;

                            foreach (DataGridViewColumn column in dataGridView.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, FontFactory.GetFont("Arial", 14, iTextSharp.text.Font.BOLD, BaseColor.BLACK)));
                                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                                pdfTable.AddCell(cell);
                            }
                            int lenght = dataGridView.RowCount;
                            int a = 0;
                            foreach (DataGridViewRow row in dataGridView.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {

                                    PdfPCell cells = new PdfPCell(new Phrase(cell.Value.ToString()));
                                    cells.HorizontalAlignment = Element.ALIGN_CENTER;
                                    pdfTable.AddCell(cells);
                                    //  pdfTable.AddCell(cell.Value.ToString());
                                }

                                a++;
                                if (a >= (lenght))
                                {
                                    break;
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4.Rotate());

                                PdfWriter.GetInstance(pdfDoc, stream);
                                //pdfTable.SpacingBefore = 15f;
                                pdfDoc.Open();
                                pdfDoc.Add(png);
                                pdfDoc.Add(para);
                                pdfDoc.Add(pdfTable);
                                //pdfDoc.Add(endparag);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {

        }
    }
}
