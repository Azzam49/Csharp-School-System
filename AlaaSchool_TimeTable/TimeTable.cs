using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace AlaaSchool_TimeTable
{
    public partial class TimeTable : Sample
    {
        public TimeTable()
        {
            InitializeComponent();
        }

        string SectionID;
        ReportDocument rd;

        //manual cross tab report (mock cross tab)creation:
        //https://blogs.sap.com/2012/10/09/manual-cross-tab-reports-using-sap-crystal-reports-for-enterprise/

        private void Fill_ComboBoxes()
        {

            //Teachers
            DataTable dataTable = Selection.Get_DataTable("SELECT TeacherID,TeacherName FROM Teachers WHERE Active = 'نعم' ");
            DataRow dr = dataTable.NewRow();
            dr["TeacherName"] = "إختار";
            dr["TeacherID"] = 0;
            dataTable.Rows.InsertAt(dr, 0);
            TeacherComboBox.DataSource = dataTable;
            TeacherComboBox.DisplayMember = "TeacherName"; // Column Name
            TeacherComboBox.ValueMember = "TeacherID";  // Column Name
           
        }

        private void Fill_ClassComboBox()
        {
            ClassComboBox.DataSource = null;

            //Classes
            DataTable dataTable2 = Selection.Get_DataTable("Select ClassID,ClassName from Classes WHERE Section_ID = '" + SectionID + "' ");
            DataRow dr2 = dataTable2.NewRow();
            dr2["ClassName"] = "إختار";
            dr2["ClassID"] = 0;
            dataTable2.Rows.InsertAt(dr2, 0);
            ClassComboBox.DataSource = dataTable2;
            ClassComboBox.DisplayMember = "ClassName"; // Column Name
            ClassComboBox.ValueMember = "ClassID";  // Column Name

        }

        private void ShowReport()
        {

            //try
            //{
                //rd = new ReportDocument();
                //DataTable dataTable = Selection.Get_TimetTableReport();
            //string s = Application.StartupPath.ToString() + "\\AlaaSchool_TimeTable\\ttreport.rpt";
            //MessageBox.Show(s);
            //DataReport.LocalReport.ReportEmbeddedResource = "Lenzo_App_2.CompletedOrders.rdlc";
            //rd.Load(Application.StartupPath + "\\AlaaSchool_TimeTable\\ttreport.rpt");
            //rd.Load("C:\\Users\\fffff\\source\\repos\\AlaaSchool_TimeTable\\AlaaSchool_TimeTable\\ttreport.rpt");
            //rd.SetDataSource(dataTable);
            //    crystalReportViewer1.ReportSource = rd;
            //    crystalReportViewer1.RefreshReport();
            //}
            //catch (Exception ex)
            //{
            //    MainClass.ShowMSG(ex.Message, "خطأ", "Error");
            //}

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            HomePage hm = new HomePage();
            MainClass.ShowWindow(hm, this, MDI.ActiveForm);
        }

        private void TimeTable_Load(object sender, EventArgs e)
        {
            //Default Radio
            BoysRadio.Checked = true;

            Fill_ComboBoxes();
        }

        private void BoysRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (BoysRadio.Checked == true)
            {
                SectionID = "1";
                Fill_ClassComboBox();

                
                crystalReportViewer1.ReportSource = null;
                crystalReportViewer1.Refresh();
            }
        }

        private void GirlsRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (GirlsRadio.Checked == true)
            {
                SectionID = "2";
                Fill_ClassComboBox();

                crystalReportViewer1.ReportSource = null;
                crystalReportViewer1.Refresh();
            }
        }

       

        private void ClassComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ClassComboBox.SelectedIndex != 0)
            {
                TeacherComboBox.SelectedIndex = 0;
            }
        }

        private void TeacherComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TeacherComboBox.SelectedIndex != 0)
            {
                ClassComboBox.SelectedIndex = 0;
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            if (ClassComboBox.SelectedIndex == 0 && TeacherComboBox.SelectedIndex == 0)
            {
                MainClass.ShowMSG("الرجاء إختيار فصل أو معلم لعرض التقرير", "...توقف", "Error");
            }
            else
            {
                //case searching by class
                if (ClassComboBox.SelectedIndex != 0)
                {
                    rd = new ReportDocument();
                    DataTable dataTable = Selection.Get_TimetTableReport(Case: "ByClass", Value: ClassComboBox.SelectedValue.ToString(), Section: (SectionID == "1") ? "بنين" : "بنات");

                    rd.Load("C:\\Users\\fffff\\source\\repos\\AlaaSchool_TimeTable\\AlaaSchool_TimeTable\\ttreport.rpt");
                    rd.SetDataSource(dataTable);
                    crystalReportViewer1.ReportSource = rd;
                    crystalReportViewer1.RefreshReport();
                }

                //case searching by teacher
                if (TeacherComboBox.SelectedIndex != 0)
                {
                    rd = new ReportDocument();
                    DataTable dataTable = Selection.Get_TimetTableReport(Case: "ByTeacher", Value: TeacherComboBox.Text, Section: (SectionID == "2") ? "بنات" : "بنين");

                    // need to have the source dynamiclly
                    rd.Load("C:\\Users\\fffff\\source\\repos\\AlaaSchool_TimeTable\\AlaaSchool_TimeTable\\ttreport2.rpt");
                    rd.SetDataSource(dataTable);
                    crystalReportViewer1.ReportSource = rd;
                    crystalReportViewer1.RefreshReport();
                }

            }

        }

        private void TimeTable_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Back)
            {
                BackButton.PerformClick();
            }
        }
    }
}
