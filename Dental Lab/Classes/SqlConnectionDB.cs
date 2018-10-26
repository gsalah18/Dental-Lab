using Dental_Lab.PrintForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows;
using System.Windows.Forms;

namespace Dental_Lab
{
    class SqlConnectionDB
    {
        private static MySqlCommand command = null;
        public static MySqlConnection connection = null;
        ////private static new SqlDataAdapter adapter;
        public String myCurrent_Conn;
        public SqlConnectionDB()
        {
            try
            {
                //string strconn = "Server = 160.153.162.158;Port=3306; Database = faddental; Uid = fadeldental; Password = Moderndentallab479;charset=utf8;";
                string strconn = "Server = localhost;Port=3306; Database = dental; Uid = root; Password =;charset=utf8;";
                connection = new MySqlConnection(strconn);
                myCurrent_Conn = connection.ConnectionString;
            }
            catch (MySqlException)
            {
                MessageBox.Show("تاكد من الاتصال بالانترنت");
            }
            catch (TimeoutException)
            {
                MessageBox.Show("سوء اتصال بالانترنت حاول مره اخرى");
            }
        }
        public bool ExeQuery(string query)
        {
            try
            {
                connection.Open();
                command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("");
                return false;
            }
        }

        public bool BackUp(string path)
        {
            try
            {
                command = new MySqlCommand();
                MySqlBackup back = new MySqlBackup(command);
                command.Connection = connection;
                connection.Open();
                back.ExportToFile(path+"//dental.sql");
                connection.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("لم يتم عمل النسخه الاحطياطيه\nتاكد من الاتصال بالانترنت");
                connection.Close();
                return false;
            }
        }
        public bool Restore(string path)
        {
            try
            {
                command = new MySqlCommand();
                MySqlBackup back = new MySqlBackup(command);
                command.Connection = connection;
                connection.Open();
                back.ImportFromFile(path);
                connection.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("لم تتم استعاد البيانات\nتاكد من الاتصال بالانترنت");
                connection.Close();
                return false;
            }
        }
   

        

        public void selectDB(ref System.Data.DataSet dataset, String SelectStatement)
        {
            try
            {
                command = new MySqlCommand();
                command.Connection = SqlConnectionDB.connection;
                command.CommandText = SelectStatement;
                connection.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(dataset);
                //MessageBox.Show("Correct Selection");
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("لم يتم جلب البيانات\nتاكد من الاتصال بالانترنت"+e);
                connection.Close();
            }
        }// end of selectDB method

        public void selectDBprint(ref CustBillDataSet dataset, String SelectStatement)
        {
            try
            {
                command = new MySqlCommand();
                command.Connection = SqlConnectionDB.connection;
                command.CommandText = SelectStatement;
                connection.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(dataset.DataTable1);
                //MessageBox.Show("Correct Selection");
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("لم يتم جلب البيانات\nتاكد من الاتصال بالانترنت" + e);
                connection.Close();
            }
        }
        public Boolean insertDB(String InsertStatement)
        {
            try
            {
                command = new MySqlCommand();
                command.Connection = SqlConnectionDB.connection;
                connection.Open();
                command.CommandText = InsertStatement;
                command.ExecuteNonQuery();
                connection.Close();
                //MessageBox.Show("Correct Insertion");
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("لم يتم ادخال البيانات\nتاكد من الاتصال بالانترنت"+e);
                connection.Close();
                return false;
            }
        } // end of insertDB
        
        public bool insertImg(string imgquery,Image img)
        {

            try
            {
                MemoryStream ms = new MemoryStream();
                img.Save(ms, img.RawFormat);
                byte[] arr = ms.GetBuffer();
                ms.Close();
                connection.Open();
                command = new MySqlCommand(imgquery, connection);
                command.Parameters.AddWithValue("@picture", arr);
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch(Exception e)
            {
                connection.Close();
                MessageBox.Show("لم يتم ادخال الشك\nتاكد من الاتصال من الانترنت"+"\n"+"او حجم الصوره كبير جدا"+"\n"+e);
                return false;
            }
        }
        public Boolean updateDB(String UpdateStatement)
        {
            try
            {
                command = new MySqlCommand();
                command.Connection = SqlConnectionDB.connection;
                connection.Open();
                command.CommandText = UpdateStatement;
                command.ExecuteNonQuery();
                connection.Close();
                //MessageBox.Show("Correct Updation");
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("لم يتم تحديث البنانات\nتاكد من الاتصال من الانترنت");
                connection.Close();
                return false;
            }
        } // end of updateDB

        public Boolean deleteDB(String DeleteStatement)
        {
            try
            {
                command = new MySqlCommand();
                command.Connection = SqlConnectionDB.connection;
                connection.Open();
                command.CommandText = DeleteStatement;
                command.ExecuteNonQuery();
                connection.Close();
                //MessageBox.Show("Correct Deletion");
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("لم يتم الحذف\nتاكد من الاتصال من الانترنت");
                connection.Close();
                return false;
            }
        } // end of deleteDB
        
        public LinkedList<string>ListOF(string query)
        {
           
            LinkedList<string> data = new LinkedList<string>();
            try
            {
                connection.Open();
                command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                    data.AddLast(reader.GetString(0));
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("لم يتم جلب الببانات\nتاكد من الاتصال بالانترنت");
                connection.Close();
            }
            return data;
        }
        public string SelectStr(string query)
        {

            string str = "";
            try
            {
                connection.Open();
                command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                    str = reader.GetString(0);
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("حدث خطا\nتاكد من الاتصال بالانترنت");
                connection.Close();
            }
            return str;
        }
        public Image SelectIMG(string query)
        {
            try
            {
                DataSet data = new DataSet();
                this.selectDB(ref data, query);
                if (data.Tables[0].Rows.Count > 0)
                {
                    byte[] a = (byte[])data.Tables[0].Rows[0][0];
                    MemoryStream ms = new MemoryStream(a);
                    Image img = Image.FromStream(ms);
                    return img;
                }
                else return null;
            }
            catch(Exception e)
            {
                MessageBox.Show("حدث مشكله اثناء جلب الصوره\nتاكد من الاتصال بالانترنت");
                return null;
            }

        }
        public int SelectID(string query)
        {
            try {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                int id = 0;
                if (reader.Read())
                    id = reader.GetInt32(0);
                connection.Close();
                return id;
            }
            catch (Exception e)
            {
                MessageBox.Show("حدث خطا اثناء العمليه\nتاكد من الاتصال بالانترنت");
                connection.Close();
                return -1;
            }
        }
        public bool DoseExists(string query)
        {
            try {
                connection.Open();
                command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                bool test = reader.HasRows;
                connection.Close();
                return test;
            }catch(Exception e)
            {
                MessageBox.Show("حدث خطا اثناء العمليه\nتاكد من الاتصال بالانترنت");
                connection.Close();
                return false;
            }
        }
        public DateTime SelectDate(string query)
        {
            DateTime date = new DateTime();
            try {
                connection.Open();
                command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                    date = reader.GetDateTime(0);
                connection.Close();
                return date;
            }
            catch (Exception e)
            {
                MessageBox.Show("لم يتم اختيار التاريخ \nتاكد من الاتصال بالانترنت");
                connection.Close();
                return new DateTime();
            }
        }
    }

    
}
