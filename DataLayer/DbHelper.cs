using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataLayer
{
    public class DbHelper
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\fyp\send\DB\CNIC_DB.mdf;Integrated Security=True;Connect Timeout=30");
        public string Store_NewUserData(string name, string password)
        {
            con.Open();
            //int bb = int.Parse(age);
            string q = "insert into jun(Name)values (N'" + name + "')";
            SqlCommand comm = new SqlCommand(q, con);
            comm.ExecuteNonQuery();
            con.Close();
            return "Data Saved";
        }

        public string Store_CardDetials(String name, String Fathername, String nic, String gender, String PhoneNumber, String Reason, string img)
        {
            try
            {
                DateTime date_Enter = DateTime.Now;

                con.Close();
                con.Open();
                string query = "Insert into NIC ( Name,Father_Name,CNIC,Gender,Phone_Number,Reason,Date_Time_Enter,ID_Card) values (N'" + name + "',N'" + Fathername + "','" + nic + "',N'" + gender + "','" + PhoneNumber + "','" + Reason + "','" + date_Enter + "','" + img + "')";
                SqlCommand insert = new SqlCommand(query, con);
                insert.ExecuteNonQuery();
                con.Close();
                return "Record Inserted";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public void Store_Visiting(string id, string number)
        {
            con.Close();
            con.Open();
            string query = "Insert into visiting (id, number) values ('" + id + "','" + number + "')";
            SqlCommand insert = new SqlCommand(query, con);
            insert.ExecuteNonQuery();
            con.Close();
        }
        public string return_id()
        {
            string id = "";
            con.Close();
            con.Open();
            SqlDataReader myReader = null;
            string query = "SELECT TOP 1 Id FROM NIC ORDER BY Id DESC";
            SqlCommand myCommand = new SqlCommand(query, con);
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                id = (myReader["Id"].ToString());
            }
            con.Close();
            return id;
        }

        public string CardCheck(string cnic)
        {
            string id = "";
            con.Open();
            SqlDataReader myReader = null;
            string query = "SELECT id FROM visiting WHERE number = '" + cnic + "'";
            SqlCommand myCommand = new SqlCommand(query, con);
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                id = (myReader["Id"].ToString());
            }
            con.Close();

            return id;
        }
        public string[] returndetail(string id)
        {
            string[] arr = new string[9];
            con.Open();
            SqlDataReader myReader = null;
            string query = "SELECT * FROM NIC WHERE Id = '" + id + "'";
            SqlCommand myCommand = new SqlCommand(query, con);
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                arr[0] = (myReader["Id"].ToString());
                arr[1] = (myReader["Name"].ToString());
                arr[2] = (myReader["Father_Name"].ToString());
                arr[3] = (myReader["CNIC"].ToString());
                arr[4] = (myReader["Gender"].ToString());
                arr[5] = (myReader["Phone_Number"].ToString());
                arr[6] = (myReader["Reason"].ToString());
                arr[7] = (myReader["Date_Time_Enter"].ToString());
                arr[8] = (myReader["Date_Time_Out"].ToString());
                //arr[9] = (myReader["ID_Card"].ToString());
            }
            con.Close();


            return (arr);
        }

        public string[] returndetailwithpic(string id)
        {
            string[] arr = new string[10];
            con.Open();
            SqlDataReader myReader = null;
            string query = "SELECT * FROM NIC WHERE Id = '" + id + "'";
            SqlCommand myCommand = new SqlCommand(query, con);
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                arr[0] = (myReader["Id"].ToString());
                arr[1] = (myReader["Name"].ToString());
                arr[2] = (myReader["Father_Name"].ToString());
                arr[3] = (myReader["CNIC"].ToString());
                arr[4] = (myReader["Gender"].ToString());
                arr[5] = (myReader["Phone_Number"].ToString());
                arr[6] = (myReader["Reason"].ToString());
                arr[7] = (myReader["Date_Time_Enter"].ToString());
                arr[8] = (myReader["Date_Time_Out"].ToString());
                arr[9] = (myReader["ID_Card"].ToString());
            }
            con.Close();


            return arr;
        }
        public void deletevisiting(string id)
        {
            con.Close();
            con.Open();
            string Query = "delete from visiting where id='" + id + "';";
            SqlCommand MyCommand2 = new SqlCommand(Query, con);
            SqlDataReader Reader2;
            Reader2 = MyCommand2.ExecuteReader();
            con.Close();
        }

        public void returntime(string id)
        {
            DateTime dateTime = DateTime.Now;

            con.Close();
            con.Open();
            string Query = "update NIC set Date_Time_Out = '" + dateTime + "' where Id= '" + id + "'";
            //This is  MySqlConnection here i have created the object and pass my connection string.  
            SqlCommand MyCommand2 = new SqlCommand(Query, con);
            SqlDataReader MyReader2;
            MyReader2 = MyCommand2.ExecuteReader();
            con.Close();

        }

        public DataTable load_IN_Out(string cnic)
        {
            con.Close();
            con.Open();
            string query = "Select Date_Time_Enter,Date_Time_Out,Reason from NIC where CNIC like '" + cnic + "%' ORDER BY Date_Time_Enter DESC";
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.Fill(dt);
            con.Close();
            return dt;
        }




        public DataTable loadalldata()
        {
            con.Close();
            con.Open();
            string query = "Select Id,Name,Father_Name,CNIC,Gender,Phone_Number,Reason,Date_Time_Enter,Date_Time_Out from NIC";
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable loaddatafromname(string name)
        {
            con.Close();
            con.Open();
            string query = "Select Name,Father_Name,CNIC,Gender,Phone_Number,Reason,Date_Time_Enter,Date_Time_Out from NIC where name like '" + name + "%' ORDER BY Date_Time_Enter DESC";
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable loaddatafromcnic(string cnic)
        {
            con.Close();
            con.Open();
            string query = "Select Name,Father_Name,CNIC,Gender,Phone_Number,Reason,Date_Time_Enter,Date_Time_Out from NIC where CNIC like '" + cnic + "%' ORDER BY Date_Time_Enter DESC";
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable loaddatafromdate(DateTime dateTime)
        {
            con.Close();
            con.Open();
            string query = "Select Name,Father_Name,CNIC,Gender,Phone_Number,Reason,Date_Time_Enter,Date_Time_Out from NIC where Date_Time_Enter like '" + dateTime.Date.ToString("MM/dd/yyyy") + "%'";
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable loaddatafromall(string name, string cnic, DateTime dateTimein, DateTime dateTimeout)
        {
            con.Close();
            con.Open();
            string query = "Select Name,Father_Name,CNIC,Gender,Phone_Number,Reason,Date_Time_Enter,Date_Time_Out from NIC where Name like '" + name + "%' and NIC like'" + cnic + "%'";
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.Fill(dt);
            con.Close();
            return dt;
        }


        public string addblocklist(string name, string cnic)
        {
            con.Open();
            //int bb = int.Parse(age);
            string q = "insert into blacklist(Name,CNIC)values ('" + name + "','" + cnic + "')";
            SqlCommand comm = new SqlCommand(q, con);
            comm.ExecuteNonQuery();
            con.Close();
            return "Data Saved";
        }

        public Tuple<string, string> checkblocklist(string name, string cnic)
        {
            string name1="", cnic1 ="";
            con.Close();
            con.Open();
            string query = "select * from blacklist where Name like '" + name + "%' or CNIC like '" + cnic + "%'";
            SqlCommand check = new SqlCommand(query, con);
            SqlDataReader reader = check.ExecuteReader();
            
            if (reader.HasRows)
            {
                //User Exists
                
                if (reader.Read())
                {
                    name1 = reader.GetValue(0).ToString();
                    cnic1 = reader.GetValue(1).ToString();
                }
                con.Close();
                return new Tuple<string, string>(name1, cnic1);
            }
            else
            {
                //User NOT Exists

                con.Close();
                return new Tuple<string, string>("","");
            }
        }


        public DataTable loaddatafromblacklist()
        {
            con.Close();
            con.Open();
            string query = "Select * from blacklist";
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.Fill(dt);
            con.Close();
            return dt;
        }

    }
}
