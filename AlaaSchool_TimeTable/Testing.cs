using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Reporting.WinForms;
using System.Data.SQLite;

namespace AlaaSchool_TimeTable
{
    public partial class Testing : Form
    {
        public Testing()
        {
            InitializeComponent();
        }
        //NEED TO KNOW EASIEST WAY TO VIEW (REPORTVIEWER/GET PDF FROM DATAGRIDVIEW)
        
        private DataTable GetDataTable(string query)
        {
            DataTable dataTable = new DataTable();
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter();

            MainClass.sqlite_conn.Open();
            string SelectQuery = query;
            SQLiteCommand command = new SQLiteCommand(SelectQuery, MainClass.sqlite_conn);
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dataTable);
            MainClass.sqlite_conn.Close();

            return dataTable;
        }
        private void Testing_Load(object sender, EventArgs e)
        {

            LocalReport report = new LocalReport();


            //Trying by Hide/Show
            //this.reportViewer1.RefreshReport();
            //reportViewer1.Hide();


            //FILL COMBOBOX
            DataTable dataTable = GetDataTable("Select TeacherID,TeacherName from Teachers"); // You have to implement the ways to retrieve data from the database.
            comboBox1.DataSource = dataTable;
            comboBox1.DisplayMember = "TeacherName"; // Column Name
            comboBox1.ValueMember = "TeacherID";  // Column Name
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //reportViewer1.Show();

            Testing2 testing2 = new Testing2();
            testing2.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TestingDataGridView testing = new TestingDataGridView();
            testing.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TestingDataGridView_three testing3 = new TestingDataGridView_three();
            testing3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Filling ComboBox with DataSource
            /*
            DataTable dataTable = GetDataTable("Select TeacherID,TeacherName from Teachers");
            comboBox1.DataSource = dataTable;
            comboBox1.DisplayMember = "TeacherName"; // Column Name
            comboBox1.ValueMember = "TeacherID";  // Column Name
             */

            //Getting Data from ComboBox
            textBox1.Text = comboBox1.SelectedValue.ToString(); //ID: 1
            textBox2.Text = comboBox1.Text;//Teacher: Ali
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
