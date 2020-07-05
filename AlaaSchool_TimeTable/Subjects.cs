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
    public partial class Subjects : Sample2
    {
        public Subjects()
        {
            InitializeComponent();
        }

        int edit;
        int SubjectID;
        BindingSource SubjectsBindingSource = new BindingSource();

        private void Fill_SubjectsGridView()
        {
            //Filling Subjects DataGridView function
            SubjectIDcolumn.DataPropertyName = "أيدي المادة";
            SubjectColumn.DataPropertyName = "المادة";         
            DataTable dataTable = Selection.Get_SubjectsTable();
            SubjectsBindingSource.DataSource = dataTable;
            DataGridViewSubjects.DataSource = SubjectsBindingSource;
            //Filling SNO
            MainClass.CountColumn(DataGridViewSubjects, "Countcolumn");
        }

      
        private void Subjects_Load(object sender, EventArgs e)
        {           
            MainClass.disable_reset(panel5);
            Fill_SubjectsGridView();
        }

        public override void AddButton_Click(object sender, EventArgs e)
        {
            MainClass.enable_reset(panel5);
            edit = 0;

            //set focus on 1st control
            this.ActiveControl = SubjectTextBox;

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
                if (SubjectTextBox.Text == "")
                {
                    MainClass.ShowMSG("الرجاء إختيار مادة للخذف", "...توقف", "Error");
                }
                else
                {
                    string Subject = DataGridViewSubjects.CurrentRow.Cells["SubjectColumn"].Value.ToString();
                    DialogResult dr = MessageBox.Show($"  هل أنت متأكد من حذف المادة ({Subject})  ؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        Deletion.Delete_Subject(SubjectID.ToString());
                        MainClass.ShowMSG($" لقد تم الحذف  بنجاح", "نجحة العملية", "Success");
                        MainClass.disable_reset(panel5);
                        Fill_SubjectsGridView();
                    }
                }
            }
            else
            {
                MainClass.ShowMSG("الرجاء إختيار مادة للخذف", "...توقف", "Error");
            }
        }

        public override void SaveButton_Click(object sender, EventArgs e)
        {
            if ( SubjectTextBox.Text == "" )
            {
                MainClass.ShowMSG("الرجاء ملأ جميع الحفول", "...توقف", "Error");
            }
            else
            {
                string Subject = SubjectTextBox.Text;
               
                if (edit == 0)//Code for Add operation
                {

                    try
                    {
                        Insertion.Insert_Subject(Subject);
                        MainClass.ShowMSG($"  لقد تم حفظ المادة ({Subject})  بنجاح ", "نجحة العملية", "Success");
                        MainClass.disable_reset(panel5);
                        Fill_SubjectsGridView();
                    }
                    catch (Exception)
                    {
                        MainClass.ShowMSG($"لقد تم إضافت المادة ({Subject})  مسبقا", "...توقف", "Error");
                    }                

                }
                else if (edit == 1)//Code for Edit operation
                {

                    Updation.Update_Subject(Subject, SubjectID.ToString());
                    MainClass.ShowMSG($"  لقد تم تعديل المادة ({Subject}) بنجاح", "نجحة العملية", "Success");
                    MainClass.disable_reset(panel5);
                    Fill_SubjectsGridView();
                }
            }
        }

        public override void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            SubjectsBindingSource.Filter = "[المادة] LIKE '%" + SearchTextBox.Text + "%'";
            DataGridViewSubjects.DataSource = SubjectsBindingSource;
        }

     
        private void DataGridViewSubjects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                MainClass.disable(panel5);
                DataGridViewRow row = DataGridViewSubjects.Rows[e.RowIndex];
                
                SubjectID = Convert.ToInt32(row.Cells["SubjectIDcolumn"].Value.ToString());                
                SubjectTextBox.Text = row.Cells["SubjectColumn"].Value.ToString();                        
            }
        }

       
    }
}
