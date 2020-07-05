using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace AlaaSchool_TimeTable
{
    class MainClass
    {
        private static string Username;
        private static string UserPosition;

        public static string USERNAME
        {
            get
            {
                return Username;
            }
            //private set
            set
            {
                Username = value;
            }
        }

        public static string USERPOSITION
        {
            get
            {
                return UserPosition;
            }
            //private set
            set
            {
                UserPosition = value;
            }
        }

        public static SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source=database.db;Version=3;New=False;Compress=True;");

        public static void ShowWindow(Form openForm, Form closeForm, Form MDIform)
        {
            closeForm.Close();
            openForm.MdiParent = MDIform;
            openForm.WindowState = FormWindowState.Maximized;
            openForm.Show();
        }

        public static string Get_UserPosition_ByUsername(string User, SQLiteConnection sqlite_conn)
        {
            string UserPosition;
            sqlite_conn.Open();
            string SelectQuery = "SELECT Position FROM users WHERE Username = '" + User + "' ";
            SQLiteCommand cmd = new SQLiteCommand(SelectQuery, sqlite_conn);
            UserPosition = cmd.ExecuteScalar().ToString();
            sqlite_conn.Close();
            return UserPosition;
        }

        public static DialogResult ShowMSG(string msg, string heading, string type)
        {

            if(type == "Success")
            {
                return MessageBox.Show(msg,heading,MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                return MessageBox.Show(msg, heading, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public static void disable_reset(Panel p)
        {
            foreach(Control c in p.Controls)
            {
                if(c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Enabled = false;
                    t.Text = "";
                }
                if(c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = false;
                    cb.SelectedIndex = -1;
                }
                if(c is RadioButton)
                {
                    RadioButton rd = (RadioButton)c;
                    rd.Enabled = false;
                    rd.Checked = false;
                }
                if(c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Enabled = false;
                    cb.Checked = false;
                }
                if(c is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)c;
                    dtp.Enabled = false;
                    dtp.Value = DateTime.Now;
                }
                if(c is Button)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
        }

        public static void disable(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Enabled = false;
                    
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = false;
                    
                }
                if (c is RadioButton)
                {
                    RadioButton rd = (RadioButton)c;
                    rd.Enabled = false;
                  
                }
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Enabled = false;
                  
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)c;
                    dtp.Enabled = false;
               
                }
                if (c is Button)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
        }

        public static void enable_reset(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Enabled = true;
                    t.Text = "";
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = true;
                    cb.SelectedIndex = -1;
                }
                if (c is RadioButton)
                {
                    RadioButton rd = (RadioButton)c;
                    rd.Enabled = true;
                    rd.Checked = false;
                }
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Enabled = true;
                    cb.Checked = false;
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)c;
                    dtp.Enabled = true;
                    dtp.Value = DateTime.Now;
                }
                if (c is Button)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                }
            }
        }

        public static void enable_reset(GroupBox gb)
        {
            foreach (Control c in gb.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Enabled = true;
                    t.Text = "";
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = true;
                    cb.SelectedIndex = -1;
                }
                if (c is RadioButton)
                {
                    RadioButton rd = (RadioButton)c;
                    rd.Enabled = true;
                    rd.Checked = false;
                }
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Enabled = true;
                    cb.Checked = false;
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)c;
                    dtp.Enabled = true;
                    dtp.Value = DateTime.Now;
                }
                if (c is Button)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                }
            }
        }

        public static void enable(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Enabled = true;

                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = true;

                }
                if (c is RadioButton)
                {
                    RadioButton rd = (RadioButton)c;
                    rd.Enabled = true;

                }
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Enabled = true;

                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)c;
                    dtp.Enabled = true;

                }
                if (c is Button)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                }
            }
        }

        public static void CountColumn(DataGridView dgv,string colname)
        {
            int count = 0;
            foreach(DataGridViewRow row in dgv.Rows)
            {
                count++;
                row.Cells[colname].Value = count.ToString();
            }
        }

        public static bool User_Exists(string username)
        {
            MainClass.sqlite_conn.Open();
            string query = "SELECT Username FROM Users WHERE Username = '"+username+"' ";
            SQLiteCommand command = new SQLiteCommand(query, MainClass.sqlite_conn);
            SQLiteDataReader dataReader = command.ExecuteReader();
            int i = 0;
            while (dataReader.Read())
            {
                i++;
            }
            MainClass.sqlite_conn.Close();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }           
        }

    }
}
