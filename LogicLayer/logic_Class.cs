  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace LogicLayer
{
    public class logic_Class
    {
        string message = "";
        private logic_Class() { }
        public static logic_Class instance = null;
        public static logic_Class get_Controller()
        {
            if (instance == null)
            {
                instance = new logic_Class();
            }
            return instance;
        }
        public string store_NewUserData(string name, string password)
        {
            DbHelper db = new DbHelper();
            message = db.Store_NewUserData(name, password);
            return message;
        }

        public string Store_Card_Data(String name, String Fathername, String nic, String gender, String PhoneNumber, String Reason, string img)
        {
            string id = "";
            DbHelper db = new DbHelper();
            var tuple = db.checkblocklist(name, nic);
            string check_cnic = tuple.Item2;
            string check_name = tuple.Item1;

            if (check_cnic == nic && check_name == name) // if both matched
            {
                return "Cnic And Name Matched with Black-Listed Person...!!\nUser/Person Not Allowed To Enter";
            }
            else if (check_name == name) // if only name matched
            {
                return "Name Matched with Black-Listed Person...!!\nCheck Person Before Enter";
            }

            else if (check_cnic == nic) // if only cnic matched
            {
                return "Cnic Matched with Black-Listed Person...!!\nUser/Person Not Allowed To Enter";
            }
            else // if nothnig matched
            {
                message = db.Store_CardDetials(name, Fathername, nic, gender, PhoneNumber, Reason, img);
                id = db.return_id();
                db.Store_Visiting(id, nic);
                return message;
            }
        }

        public string[] return_Card_Data(String nic)
        {
            string id = "";
            DbHelper db = new DbHelper();

            id = db.CardCheck(nic);
            return db.returndetail(id);
            
        }

        public string[] Person_Data(String id)
        {
            
            DbHelper db = new DbHelper();
            return db.returndetailwithpic(id);
        }

        public void Return_Card(string id)
        {
            DbHelper db = new DbHelper();
            db.deletevisiting(id);
            db.returntime(id);

        }

        public DataTable calldata()
        {
            DbHelper db = new DbHelper();

            return db.loadalldata();
        }

        public DataTable callfromname(string name)
        {
            DbHelper db = new DbHelper();

            return db.loaddatafromname(name);

        }

        public DataTable callfromcnic(string cnic)
        {
            DbHelper db = new DbHelper();

            return db.loaddatafromcnic(cnic);

        }

        public DataTable Call_In_Out(string cnic)
        {
            DbHelper db = new DbHelper();

            return db.load_IN_Out(cnic);

        }

        public DataTable callfromdate(DateTime dateTime)
        {
            DbHelper db = new DbHelper();

            return db.loaddatafromdate(dateTime);

        }

        public DataTable calldatafromall(string name, string cnic, DateTime dateTimein, DateTime dateTimeout)
        {
            DbHelper db = new DbHelper();
            return db.loaddatafromall(name, cnic, dateTimein, dateTimeout);
        }

        public DataTable calldatafromblacklist()
        {
            DbHelper db = new DbHelper();
            return db.loaddatafromblacklist();
        }

        public string insertblockdata(string name,string cnic)
        {
            DbHelper db = new DbHelper();
            return db.addblocklist(name, cnic);
        }





        // ---------------------------English OCR ------------------------------------


        public string[] readdatafrommodel()
        {
            string[] arr = new string[4];
            string text = File.ReadAllText(@"D:\img\sampl.txt");
            // MessageBox.Show(text);
            string authors = text;
            // Split authors separated by a comma followed by space  
            string[] authorsList = authors.Split(',');
            foreach (string author in authorsList)
            {
                
                    //MessageBox.Show(author);
            }

            string name = "", nic = "", gender = "", fname = "";

            for (int i = 0; i < 8; i++)
            {
                if (authorsList[i] == "NIC")
                    nic = authorsList[i + 1];
                else if (authorsList[i] == "Name")
                    name = authorsList[i + 1];
                else if (authorsList[i] == "Gender")
                    gender = authorsList[i + 1];
                else if (authorsList[i] == "FatherName")
                    fname = authorsList[i + 1];
            }

            arr[0] = nic;
            arr[1] = name;
            arr[2] = fname;
            arr[3] = gender;

            return arr;
        }
    }
}