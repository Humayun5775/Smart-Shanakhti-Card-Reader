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
using System.IO;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Runtime.InteropServices;
using System.Drawing.Imaging; 
namespace CNIC_READER
{
    public partial class DataEnteryForm : Form
    {
        int i;
        public DataEnteryForm()
        {
            InitializeComponent();

            btncapture.Text = "Start Camera";
            button1.Enabled = false;
        }
        

        private void btnSave_Click(object sender, EventArgs e)
        {
            //ImageConverter _imageConverter = new ImageConverter();
            //byte[] xByte = (byte[])_imageConverter.ConvertTo(new Bitmap(pictureBox1.Image), typeof(byte[]));

            //    byte[] xByt = imageToByteArray(pictureBox1.Image);

            //@"D:\img\test.jpg"
            string sourceFile = @"D:\img\test.jpg";
            string destinationFile = @"D:\projectCNIC\"+tbnic.Text+".jpg";
            try
            {
                File.Copy(sourceFile, destinationFile, true);
            }
            catch (IOException iox)
            {
                MessageBox.Show(iox.Message);
            }
            logic_Class fc = logic_Class.get_Controller();
            MessageBox.Show(fc.Store_Card_Data(tbname.Text, tbfname.Text, tbnic.Text, tbgender.Text, tbphone.Text, tbreason.Text, destinationFile));
            reset();
        }
        
        

        private void btnrest_Click(object sender, EventArgs e)
        {
            reset();
        }
        private void reset()
        {
            tbfname.Text = "";
            tbname.Text = "";
            tbgender.Text = "";
            tbnic.Text = "";
            tbphone.Text = "";
            tbreason.Text = "";      
        }


        
        // -----------------------------------------  Camera Module ---------------------------

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        Bitmap check;
        bool temp = false;

        private void DataEnteryForm_Load(object sender, EventArgs e)
        {
            try
            {
                filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                foreach (FilterInfo Device in filterInfoCollection)
                    comboBox1.Items.Add(Device.Name);
                comboBox1.SelectedIndex = 0;
                videoCaptureDevice = new VideoCaptureDevice();
            }
            catch (Exception ex)
            {
               // MessageBox.Show("No Camera Found");
                MessageBox.Show("No Camera Detected.\nKindly attach camera to click image \n" +
              "OR\nBrowse Image of your ID card from the system\nAnd Try Again", "No Camera Found", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                //MessageBox.Show(ex.Message);
            }
        }
        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            check = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = check;
        }

        private void btncapture_Click(object sender, EventArgs e)
        {
            try
            {
                if (temp == false)
                {
                    videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[comboBox1.SelectedIndex].MonikerString);
                    videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
                    videoCaptureDevice.Start();
                    temp = true;
                    btncapture.Text = "Capture Image";
                }
                else if (temp == true)
                {
                    if (videoCaptureDevice.IsRunning == true)
                    {
                        videoCaptureDevice.Stop();
                        check.Save(@"D:\img\test.jpg");
                        i = 2;
                    }
                    temp = false;
                    btncapture.Text = "Start Camera";
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void DataEnteryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (videoCaptureDevice.IsRunning == true)
                    videoCaptureDevice.Stop();
            }
            catch(Exception ex)
            {
               // MessageBox.Show(ex.Message);
            }
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            if (videoCaptureDevice.IsRunning == true)
            {
                videoCaptureDevice.Stop();
                check.Save(@"D:\img\test.jpg");
            }
        }








        // -----------------------------------------  Filters ---------------------------



        private void btnconvert_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                Callscript();
                readmodel();
                button1.Enabled = false;
            }
            if (i == 2)
            {
                Call2script();
                logic_Class fc = logic_Class.get_Controller();
                //readdatafrommodel();
                string[] arr = fc.readdatafrommodel();
                tbname.Text = arr[1];
                tbfname.Text = arr[2];
                tbnic.Text = arr[0];
                tbgender.Text = arr[3];
                button1.Enabled = true;
            }

        }
        public void readmodel()
        {
            string[] arr = new string[4];
            string text = File.ReadAllText(@"D:\img\sample.txt");
            // MessageBox.Show(text);
            string authors = text;
            // Split authors separated by a comma followed by space  
            string[] authorsList = authors.Split('\n');
            int i = 0;
            foreach (string author in authorsList)
            {
               // MessageBox.Show(author);
                if (i == 0)
                    tbname.Text = author;
                else if (i == 1)
                    tbfname.Text = author;
                else if (i == 2)
                    tbgender.Text = author;
                else if (i == 3)
                    tbnic.Text = author;

                i++;
            }
        }

        private void readdatafrommodel()
        {
            string[] arr = new string[4];
            string text = File.ReadAllText(@"D:\img\sampl.txt");
           // MessageBox.Show(text);
        }

        private void Callscript()
        {
            System.Diagnostics.ProcessStartInfo start = new System.Diagnostics.ProcessStartInfo();
            //python interprater location
            start.FileName = @"C:\Users\humay\AppData\Local\Programs\Python\Python37\python.exe";
            //argument with file name and input parameters
            start.Arguments = string.Format("{0} {1} {2}", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"D:\fyp\send\CNIC_READER\modelcall.py"), 5, 5);
            start.UseShellExecute = false;// Do not use OS shell
            start.CreateNoWindow = true; // We don't need new window
            start.RedirectStandardOutput = true;// Any output, generated by application will be redirected back
            start.RedirectStandardError = true; // Any error in standard output will be redirected back (for example exceptions)
            start.LoadUserProfile = true;
            using (System.Diagnostics.Process process = System.Diagnostics.Process.Start(start))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    string stderr = process.StandardError.ReadToEnd(); // Here are the exceptions from our Python script
                    string result = reader.ReadToEnd(); // Here is the result of StdOut(for example: print "test")

                    MessageBox.Show("Converted ");
                    //MessageBox.Show("Converted " + stderr);

                    //MessageBox.Show("5 + 10 = {0}", result);
                }
            }

        }

        //private void Call2script()
        //{
        //    System.Diagnostics.ProcessStartInfo start = new System.Diagnostics.ProcessStartInfo();
        //    //python interprater location
        //    start.FileName = @"C:\Users\humay\AppData\Local\Programs\Python\Python37\python.exe";
        //    //argument with file name and input parameters
        //    start.Arguments = string.Format("{0} {1} {2}", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"D:\fyp\send\CNIC_READER\DataLayer\callingScriptfromCsharp.py"), 5, 5);
        //    start.UseShellExecute = false;// Do not use OS shell
        //    start.CreateNoWindow = true; // We don't need new window
        //    start.RedirectStandardOutput = true;// Any output, generated by application will be redirected back
        //    start.RedirectStandardError = true; // Any error in standard output will be redirected back (for example exceptions)
        //    start.LoadUserProfile = true;
        //    using (System.Diagnostics.Process process = System.Diagnostics.Process.Start(start))
        //    {
        //        using (StreamReader reader = process.StandardOutput)
        //        {
        //            string stderr = process.StandardError.ReadToEnd(); // Here are the exceptions from our Python script
        //            string result = reader.ReadToEnd(); // Here is the result of StdOut(for example: print "test")

        //            MessageBox.Show("Converted ");
        //            //MessageBox.Show("Converted " + stderr);

        //            //MessageBox.Show("5 + 10 = {0}", result);
        //        }
        //    }

        //}

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            Image file = null;
            string lb=null;
            // open file dialog   
            OpenFileDialog f = new OpenFileDialog();
            // image filters  
            f.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (f.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box
                file = Image.FromFile(f.FileName);

                pictureBox1.Image = file;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                lb = f.FileName;

                i = 1;
            }

            //@"D:\img\test.jpg"
            string sourceFile = lb;
            string destinationFile = @"D:\img\test.jpg";
            try
            {
                File.Copy(sourceFile, destinationFile, true);
            }
            catch (IOException iox)
            {
                MessageBox.Show(iox.Message);
            }
        }
        private void Call2script()
        {
            System.Diagnostics.ProcessStartInfo start = new System.Diagnostics.ProcessStartInfo();
            //python interprater location
            start.FileName = @"C:\Users\humay\AppData\Local\Programs\Python\Python37\python.exe";
            //argument with file name and input parameters
            start.Arguments = string.Format("{0} {1} {2}", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"D:\fyp\send\CNIC_READER\callingScriptfromCsharp.py"), 5, 5);
            start.UseShellExecute = false;// Do not use OS shell
            start.CreateNoWindow = true; // We don't need new window
            start.RedirectStandardOutput = true;// Any output, generated by application will be redirected back
            start.RedirectStandardError = true; // Any error in standard output will be redirected back (for example exceptions)
            start.LoadUserProfile = true;
            using (System.Diagnostics.Process process = System.Diagnostics.Process.Start(start))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    string stderr = process.StandardError.ReadToEnd(); // Here are the exceptions from our Python script
                    string result = reader.ReadToEnd(); // Here is the result of StdOut(for example: print "test")

                    MessageBox.Show("Converted ");
                    //MessageBox.Show("Converted " + stderr);

                    //MessageBox.Show("5 + 10 = {0}", result);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            formpre fopre = new formpre();
            fopre.Show ();
        }

        private void tbname_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Character Validation(only Character allowed)
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void tbfname_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Character Validation(only Character allowed)
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void tbnic_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Character Validation(only Character allowed)
            if (Char.IsControl(e.KeyChar) != true && Char.IsLetter(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void tbgender_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Character Validation(only Character allowed)
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void tbphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Character Validation(only Character allowed)
            if (Char.IsControl(e.KeyChar) != true && Char.IsLetter(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }
    }


}
