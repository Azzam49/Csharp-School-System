using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace AlaaSchool_TimeTable
{
    public partial class TestingDataGridView_three : Form
    {
        public TestingDataGridView_three()
        {
            InitializeComponent();
        }

        private void TestingDataGridView_three_Load(object sender, EventArgs e)
        {

            UserID.DataPropertyName = "أيدي";
            Username.DataPropertyName = "الإسم";
            Password.DataPropertyName = "كلمة مرور";
            Position.DataPropertyName = "رتبة";

            string sql = "SELECT UserID AS 'أيدي',Username AS 'الإسم',Password AS 'كلمة مرور',Position AS 'رتبة' FROM Users";
            MainClass.sqlite_conn.Open();
            DataTable dataTable = new DataTable();
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(sql, MainClass.sqlite_conn);
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            MainClass.sqlite_conn.Close();
        }
    }
}
