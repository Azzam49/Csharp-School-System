using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlaaSchool_TimeTable
{
    public partial class AssignmentsForm : Sample2
    {
        public AssignmentsForm()
        {
            InitializeComponent();
        }

        int edit;
        int AssignmentID;
        string Section;
        string SectionID;
        BindingSource AssignmentBindingSource = new BindingSource();

        private void Fill_AssignmentsGridView()
        {
            //Filling Assignments DataGridView function
            AssignmentIDcolumn.DataPropertyName = "الأيدي";
            Daycolumn.DataPropertyName = "اليوم";
            ClassIDcolumn.DataPropertyName = "أيدي الفصل";
            Classcolumn.DataPropertyName = "الفصل";
            SubjectIDcolumn.DataPropertyName = "أيدي المادة";
            Subjectcolumn.DataPropertyName = "المادة";
            PeriodIDcolumn.DataPropertyName = "أيدي الحصه";
            Periodcolumn.DataPropertyName = "الحصه";
            TeacherIDcolumn.DataPropertyName = "أيدي المعلم";
            Teachercolumn.DataPropertyName = "المعلمين";
            Sectioncolumn.DataPropertyName = "أيدي القسم";
            TimingIDcolumn.DataPropertyName = "أيدي التوقيت";
            DataTable dataTable = Selection.Get_AssignmentsNewTable(SectionID);
            AssignmentBindingSource.DataSource = dataTable;
            DataGridViewAssignments.DataSource = AssignmentBindingSource;
            //Filling SNO
            MainClass.CountColumn(DataGridViewAssignments, "Countcolumn");
        }

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
          
            //Subjects
            DataTable dataTable3 = Selection.Get_DataTable("Select SubjectID,SubjectName from Subjects");
            DataRow dr3 = dataTable3.NewRow();
            dr3["SubjectName"] = "إختار";
            dr3["SubjectID"] = 0;
            dataTable3.Rows.InsertAt(dr3, 0);
            SubjectComboBox.DataSource = dataTable3;
            SubjectComboBox.DisplayMember = "SubjectName"; // Column Name
            SubjectComboBox.ValueMember = "SubjectID";  // Column Name

            //Periods
            DataTable dataTable4 = Selection.Get_Period_By_Timing();
            PeriodComboBox.DataSource = dataTable4;
            PeriodComboBox.DisplayMember = "Periods"; // Column Name
            PeriodComboBox.ValueMember = "TimingID";  // Column Name
        }

        private void Fill_ClassComboBox()
        {
            ClassComboBox.DataSource = null;

            //Classes
            DataTable dataTable2 = Selection.Get_DataTable("Select ClassID,ClassName from Classes WHERE Section_ID = '" + SectionID +"' ");
            DataRow dr2 = dataTable2.NewRow();
            dr2["ClassName"] = "إختار";
            dr2["ClassID"] = 0;
            dataTable2.Rows.InsertAt(dr2, 0);
            ClassComboBox.DataSource = dataTable2;
            ClassComboBox.DisplayMember = "ClassName"; // Column Name
            ClassComboBox.ValueMember = "ClassID";  // Column Name

        }

        private void AssignmentsForm_Load(object sender, EventArgs e)
        {
            //Default Radio
            BoysRadio.Checked = true;

            Fill_ComboBoxes();
            //DayComboBox.SelectedIndex = 0;
            MainClass.disable_reset(panel5);
            Fill_AssignmentsGridView();           
        }

        public override void AddButton_Click(object sender, EventArgs e)
        {
            MainClass.enable_reset(panel5);
            edit = 0;
        }

        public override void EditButton_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.enable(panel5);
        }

        public override void DeleteButton_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                if (PeriodComboBox.Text == "")
                {
                    MainClass.ShowMSG("الرجاء إختيار تعين للخذف", "...توقف", "Error");
                }
                else
                {
                   
                    DialogResult dr = MessageBox.Show($" هل أنت متأكد من حذف التعين ؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        Deletion.Delete_AssignmentNew(AssignmentID.ToString());
                        MainClass.ShowMSG($" لقد تم الحذف  بنجاح", "نجحة العملية", "Success");
                        MainClass.disable_reset(panel5);
                        Fill_AssignmentsGridView();
                        DataGridViewAssignments.ClearSelection();
                    }
                }
            }
            else
            {
                MainClass.ShowMSG("الرجاء إختيار تعين للخذف", "...توقف", "Error");
            }
        }

        public override void SaveButton_Click(object sender, EventArgs e)
        {
            if (ClassComboBox.SelectedIndex == 0 || ClassComboBox.SelectedIndex == -1 || PeriodComboBox.SelectedIndex == -1 || TeacherComboBox.SelectedIndex == 0 || TeacherComboBox.SelectedIndex == -1 || SubjectComboBox.SelectedIndex == 0 || SubjectComboBox.SelectedIndex == -1)
            {
                MainClass.ShowMSG("الرجاء ملأ جميع الحقول", "...توقف", "Error");
            }
            else
            {
                if (edit == 0)//Code for Add operation
                {

                    try
                    {
                        //string teacher = (TeacherComboBox.SelectedValue.ToString() == "3") ? "" : TeacherComboBox.SelectedValue.ToString();
                       
                        //Period represents the TimingID
                        //Insertion.Insert_AssignmentNew(ClassComboBox.SelectedValue.ToString(), SubjectComboBox.SelectedValue.ToString(), TeacherComboBox.SelectedValue.ToString(), SectionID, PeriodComboBox.SelectedValue.ToString());
                        Insertion.Insert_AssignmentNew(ClassComboBox.SelectedValue.ToString(), SubjectComboBox.SelectedValue.ToString(), TeacherComboBox.SelectedValue.ToString(), SectionID, PeriodComboBox.SelectedValue.ToString());            
                        MainClass.ShowMSG($"  لقد تم حفظ التعين بنجاح ", "نجحة العملية", "Success");
                        MainClass.disable_reset(panel5);
                        Fill_AssignmentsGridView();
                        DataGridViewAssignments.ClearSelection();
                    }
                    catch (Exception ex)
                    {
                       
                        MainClass.sqlite_conn.Close();
                       
                        if (ex.ToString().Contains("Assignments3.Teacher_ID, Assignments3.Timing_ID"))
                        {
                            
                            DataTable PreviousAssignmentTable = Selection.Get_Teacher_and_Timing_for_UniqueIndexError(teacherid:"0", timingid : PeriodComboBox.SelectedValue.ToString());
                            string periodtxt = PreviousAssignmentTable.Rows[0][1].ToString();
                            string classtxt = PreviousAssignmentTable.Rows[0][2].ToString();
                            string teachertxt = PreviousAssignmentTable.Rows[0][3].ToString();
                            string sectiontxt = PreviousAssignmentTable.Rows[0][4].ToString();

                            string CurrentAssignment = "معلم/معلمة " + TeacherComboBox.Text + " - " + PeriodComboBox.Text.Replace('(','-').Replace(')', ' ') + " - " + ClassComboBox.Text + " - " + Section;
                            string PreviousAssignment = "معلم/معلمة " + teachertxt + " - " + periodtxt.Replace('(', '-').Replace(')', ' ') + " - " + classtxt + " - " + sectiontxt;

                            MainClass.ShowMSG($"لقد تم تعين المعلم/المعلمة {TeacherComboBox.Text} لفصل أخر في نفس اليوم و الحصه" + "\n\n" + "التعين السابق" + " : " + PreviousAssignment + "\n" + "التعين الحالي" + " : " + CurrentAssignment, "...توقف", "Error");
                        }
                        else if (ex.ToString().Contains("Assignments3.Class_ID, Assignments3.Timing_ID"))
                        {
                            MainClass.ShowMSG($"لقد تم تعين حصه في ( {PeriodComboBox.Text} - {ClassComboBox.Text} ) مسبقا", "...توقف", "Error");
                        }
                        else
                        {
                            MainClass.ShowMSG($"لقد حصل خطأ {ex.ToString()}", "...توقف", "Error");
                        }
                    }


                }
                else if (edit == 1)//Code for Edit operation
                {
                    try
                    {
                        Updation.Update_AssignmentNew(AssignmentID.ToString(), ClassComboBox.SelectedValue.ToString(), SubjectComboBox.SelectedValue.ToString(), TeacherComboBox.SelectedValue.ToString(), PeriodComboBox.SelectedValue.ToString());
                        MainClass.ShowMSG($"  لقد تم تعديل التعين  بنجاح", "نجحة العملية", "Success");
                        MainClass.disable_reset(panel5);
                        Fill_AssignmentsGridView();
                        DataGridViewAssignments.ClearSelection();
                    }
                    catch (Exception ex)
                    {

                        MainClass.sqlite_conn.Close();

                        if (ex.ToString().Contains("Assignments3.Teacher_ID, Assignments3.Timing_ID"))
                        {

                            DataTable PreviousAssignmentTable = Selection.Get_Teacher_and_Timing_for_UniqueIndexError(teacherid: "0", timingid: PeriodComboBox.SelectedValue.ToString());
                            string periodtxt = PreviousAssignmentTable.Rows[0][1].ToString();
                            string classtxt = PreviousAssignmentTable.Rows[0][2].ToString();
                            string teachertxt = PreviousAssignmentTable.Rows[0][3].ToString();
                            string sectiontxt = PreviousAssignmentTable.Rows[0][4].ToString();

                            string CurrentAssignment = "معلم/معلمة " + TeacherComboBox.Text + " - " + PeriodComboBox.Text.Replace('(', '-').Replace(')', ' ') + " - " + ClassComboBox.Text + " - " + Section;
                            string PreviousAssignment = "معلم/معلمة " + teachertxt + " - " + periodtxt.Replace('(', '-').Replace(')', ' ') + " - " + classtxt + " - " + sectiontxt;

                            MainClass.ShowMSG($"لقد تم تعين المعلم/المعلمة {TeacherComboBox.Text} لفصل أخر في نفس اليوم و الحصه" + "\n\n" + "التعين السابق" + " : " + PreviousAssignment + "\n" + "التعين الحالي" + " : " + CurrentAssignment, "...توقف", "Error");
                        }
                        else if (ex.ToString().Contains("Assignments3.Class_ID, Assignments3.Timing_ID"))
                        {
                            MainClass.ShowMSG($"لقد تم تعين حصه في ( {PeriodComboBox.Text} - {ClassComboBox.Text} ) مسبقا", "...توقف", "Error");
                        }
                        else
                        {
                            MainClass.ShowMSG($"لقد حصل خطأ {ex.ToString()}", "...توقف", "Error");
                        }
                    }

                }
            }
        }

        public override void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            AssignmentBindingSource.Filter = "[المعلمين] LIKE '%" + SearchTextBox.Text + "%' OR [اليوم] LIKE '%" + SearchTextBox.Text + "%' OR [المادة] LIKE '%" + SearchTextBox.Text + "%' OR [الفصل] LIKE '%" + SearchTextBox.Text + "%' OR [الحصه] LIKE '%" + SearchTextBox.Text + "%'";
            DataGridViewAssignments.DataSource = AssignmentBindingSource;
        }

        private void DataGridViewAssignments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                MainClass.disable(panel5);
                DataGridViewRow row = DataGridViewAssignments.Rows[e.RowIndex];

                AssignmentID = Convert.ToInt32(row.Cells["AssignmentIDcolumn"].Value.ToString());
                TeacherComboBox.SelectedValue = row.Cells["TeacherIDcolumn"].Value;
                SubjectComboBox.SelectedValue = row.Cells["SubjectIDcolumn"].Value;
                ClassComboBox.SelectedValue = row.Cells["ClassIDcolumn"].Value;
                PeriodComboBox.SelectedValue = row.Cells["TimingIDcolumn"].Value;
                
            }
        }

        private void BoysRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (BoysRadio.Checked == true)
            {
                Section = "بنبن";
                SectionID = "1";
                Fill_ClassComboBox();

                MainClass.disable_reset(panel5);
                Fill_AssignmentsGridView();
            }
                
        }

        private void GirlsRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (GirlsRadio.Checked == true)
            {
                Section = "بنات";
                SectionID = "2";
                Fill_ClassComboBox();

                MainClass.disable_reset(panel5);
                Fill_AssignmentsGridView();
            }
        }

        private void PeriodComboBox_TextChanged(object sender, EventArgs e)
        {
            if(PeriodComboBox.Text.Contains("الطابور") == true)
            {
                SubjectComboBox.Text = "الطابور";
                TeacherComboBox.Text = "-";
            }
            else if (PeriodComboBox.Text.Contains("الفطور") == true)
            {
                SubjectComboBox.Text = "الفطور";
                TeacherComboBox.Text = "-";
            }
            else if (PeriodComboBox.Text.Contains("الفسحه") == true)
            {
                SubjectComboBox.Text = "الفسحه";
                TeacherComboBox.Text = "-";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable test1 = Selection.Get_Teacher_and_Timing_for_UniqueIndexError("0", "0");
            //string teachername = test1.Rows[0][0].ToString();
            string periodtxt = test1.Rows[0][1].ToString();
            string classtxt = test1.Rows[0][2].ToString();
            string teachertxt = test1.Rows[0][3].ToString();

            MessageBox.Show("period : " + periodtxt + "\n class : " + classtxt + "\n teacher : " + teachertxt);

        }
    }
}
