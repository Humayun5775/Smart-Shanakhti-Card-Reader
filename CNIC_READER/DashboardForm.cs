using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;


namespace CNIC_READER
{
    public partial class DashboardForm : Form
    {
        //--------------------------- Form Round----------------------------

        //[DllImport("Gdi32.DLL", EntryPoint = "CreateRoundRectRgn")]
        //private extern static IntPtr CreateRoundRectRgn
        //    (
        //        int nLeftRect,
        //        int nTopRect,
        //        int nRightRect,
        //        int nBottomRect,
        //        int nWidthEllipse,
        //        int nHeightEllipse
        //    );

        //--------------------------- Constractor----------------------------

        static SqlConnection con;
        public DashboardForm()
        {
            InitializeComponent();
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\humay\Desktop\fyp\send\DB\CNIC_DB.mdf;Integrated Security=True;Connect Timeout=30");

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        
        private void btnMinimaiz_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //--------------------------- Drag Fom----------------------------

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd,int wMsg, int wParam, int lParam);
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
           
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //------------------------------------ Form In Panal-------------------------------------------------


        

        private void btnDataEntery_Click(object sender, EventArgs e)
        {
            lbtitleofchildForm.Text = "Enter Data";
            icondashboard.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;

            panelWindow.Controls.Clear();
            DataEnteryForm dataEnteryForm = new DataEnteryForm() { TopLevel = false, TopMost = true };
            this.panelWindow.Controls.Add(dataEnteryForm);
            dataEnteryForm.Show();
        }

        private void btnReturnCard_Click(object sender, EventArgs e)
        {
            lbtitleofchildForm.Text = "Returning Card";
            icondashboard.IconChar = FontAwesome.Sharp.IconChar.DoorClosed;
            CardReturnForm cardReturnForm = new CardReturnForm() { TopLevel = false, TopMost = true };
            panelWindow.Controls.Clear();
            this.panelWindow.Controls.Add(cardReturnForm);
            cardReturnForm.Show();
        }


        private void btnCheckDetails_Click(object sender, EventArgs e)
        {
            lbtitleofchildForm.Text = "Check Details";
            icondashboard.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            DetailFrom detailFrom = new DetailFrom() { TopLevel = false, TopMost = true };
            panelWindow.Controls.Clear();
            this.panelWindow.Controls.Add(detailFrom);
            detailFrom.Show();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            lbtitleofchildForm.Text = "Black Listed";
            icondashboard.IconChar = FontAwesome.Sharp.IconChar.UsersSlash;
            BlackListForm blackList = new BlackListForm() { TopLevel = false, TopMost = true };
            panelWindow.Controls.Clear();
            this.panelWindow.Controls.Add(blackList);
            blackList.Show();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            lbtitleofchildForm.Text = "About Us";
            icondashboard.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            frmaboutus frmaboutu = new frmaboutus() { TopLevel = false, TopMost = true };
            panelWindow.Controls.Clear();
            this.panelWindow.Controls.Add(frmaboutu);
            frmaboutu.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            lbtitleofchildForm.Text = "Home";
            icondashboard.IconChar = FontAwesome.Sharp.IconChar.Home;
            formHome frmabout = new formHome() { TopLevel = false, TopMost = true };
            panelWindow.Controls.Clear();
            this.panelWindow.Controls.Add(frmabout);
            frmabout.Show();
        }
    }
}
