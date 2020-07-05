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
    public partial class TestingDataGridView : Form
    {
        public TestingDataGridView()
        {
            InitializeComponent();
        }

        private void TestingDataGridView_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Users";
            MainClass.sqlite_conn.Open();
            DataTable dataTable = new DataTable();
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(sql, MainClass.sqlite_conn);
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            MainClass.sqlite_conn.Close();
        }
    }
}
