using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace AlaaSchool_TimeTable
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
       
     
       //SQLite codes
       #region Comment
            //string databaseFile = Application.StartupPath + "\\School_TimeTable_DB.db";
            //if(File.Exists(databaseFile) == false)
            //{
            //    SQLiteConnection sqlite_conn;
            //    SQLiteCommand sqlite_cmd;

            //    sqlite_conn = new SQLiteConnection("Data Source=database.db;Version=3;New=True;Compress=True;");

            //    // open the connection:
            //    sqlite_conn.Open();

            //    // create a new SQL command:
            //    sqlite_cmd = sqlite_conn.CreateCommand();

            //    // Let the SQLiteCommand object know our SQL-Query:
            //    sqlite_cmd.CommandText = "CREATE TABLE Users (id integer primary key, text varchar(100));";

            //    // Now lets execute the SQL ;D
            //    sqlite_cmd.ExecuteNonQuery();

            //    sqlite_conn.Close();
            //}
            #endregion

        private void LoginButton_Click_1(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text == "" || PasswordTextBox.Text == "")
            {
                MessageBox.Show("الرجاء كتابة الإسم و كلمة المرور", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            else
            {
                #region comment
                //SQLiteConnection sqlite_conn;
                //SQLiteCommand sqlite_cmd;
                //SQLiteDataReader sqlite_datareader;

                //// create a new database connection:
                //sqlite_conn = new SQLiteConnection("Data Source=database.db;Version=3;New=False;Compress=True;");

                //// open the connection:
                //sqlite_conn.Open();

                //// create a new SQL command:
                //sqlite_cmd = sqlite_conn.CreateCommand();

                ////sqlite_cmd.CommandText = "INSERT INTO Users (id, text) VALUES (1, 'Test Text 1');";

                ////// And execute this again ;D
                ////sqlite_cmd.ExecuteNonQuery();

                //sqlite_cmd.CommandText = "SELECT * FROM Users";

                //// Now the SQLiteCommand object can give us a DataReader-Object:
                //sqlite_datareader = sqlite_cmd.ExecuteReader();

                //// The SQLiteDataReader allows us to run through the result lines:
                //while (sqlite_datareader.Read()) // Read() returns true if there is still a result line to read
                //{

                //    string myReader = sqlite_datareader.GetString(1);
                //    MessageBox.Show(myReader);
                //}


                //sqlite_conn.Close();

                //sqlite_cmd.CommandText = "CREATE TABLE Users(   UserID    INTEGER NOT NULL PRIMARY KEY  UNIQUE,	Username  TEXT NOT NULL,	Password  TEXT NOT NULL,	Userposition  TEXT NOT NULL)";

                #endregion


                SQLiteCommand sqlite_cmd;
                SQLiteDataReader sqlite_datareader;



                bool Username_isValid = false;

                MainClass.sqlite_conn.Open();
                string Query1 = "SELECT Password FROM Users WHERE Username = '" + UsernameTextBox.Text + "' AND Password = '" + PasswordTextBox.Text + "' AND Active = 'نعم'";
                sqlite_cmd = MainClass.sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = Query1;
                sqlite_datareader = sqlite_cmd.ExecuteReader();

                while (sqlite_datareader.Read())
                {

                    Username_isValid = true;
                }

                sqlite_datareader.Close();
                MainClass.sqlite_conn.Close();

                if (Username_isValid == true)
                {
                    MainClass.USERNAME = UsernameTextBox.Text;
                    MainClass.USERPOSITION = MainClass.Get_UserPosition_ByUsername(MainClass.USERNAME, MainClass.sqlite_conn);
                    MessageBox.Show("لقد تم التسجيل بنجاح", "نجح", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    
                    if(MainClass.USERPOSITION == "إداري")
                    {
                        HomePage home = new HomePage();
                        MainClass.ShowWindow(home, this, MDI.ActiveForm);
                    }

                    if(MainClass.USERPOSITION == "موظف")
                    {
                        HomePage_Demo home_demo = new HomePage_Demo();
                        MainClass.ShowWindow(home_demo, this, MDI.ActiveForm);
                    }
                  
                }
                else
                {
                    MessageBox.Show("الرجاء التحفف من صحة الاسم أو كلمة المرور", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    PasswordTextBox.Text = "";
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.ActiveControl = LoginButton;
            UsernameTextBox.Text = "Admin";
            PasswordTextBox.Text = "123";
           
        }
    }
}
