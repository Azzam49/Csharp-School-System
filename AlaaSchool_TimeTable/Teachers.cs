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
    public partial class Teachers : Sample2
    {
        public Teachers()
        {
            InitializeComponent();
        }

        int edit;
        int TeacherID;
        BindingSource TeachersBindingSource = new BindingSource();

        private void Fill_TeachersGridView()
        {
            //Filling Teachers DataGridView function
            TeacherIDcolumn.DataPropertyName = "أيدي";
            TeacherColumn.DataPropertyName = "الإسم";
            Gendercolumn.DataPropertyName = "جنس";
            Phonecolumn.DataPropertyName = "الهاتف";
            Activecolumn.DataPropertyName = "مفعل";
            DataTable dataTable = Selection.Get_TeachersTable();
            TeachersBindingSource.DataSource = dataTable;
            DataGridViewTeachers.DataSource = TeachersBindingSource;
            //Filling SNO
            MainClass.CountColumn(DataGridViewTeachers, "Countcolumn");
        }

        private void Teachers_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(panel5);
            Fill_TeachersGridView();
        }

        public override void AddButton_Click(object sender, EventArgs e)
        {
            MainClass.enable_reset(panel5);
            edit = 0;

            //set focus on 1st control
            this.ActiveControl = GenderComboBox;
        }

        public override void EditButton_Click(object sender, EventArgs e)
        {
            if( DataGridViewTeachers.CurrentRow.Cells["TeacherColumn"].Value.ToString() != "-")
            {
                edit = 1;
                MainClass.enable(panel5);
            }          
        }

        public override void DeleteButton_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                if (TeacherTextBox.Text == "" || TeacherTextBox.Text == "-")
                {
                    MainClass.ShowMSG("الرجاء إختيار معلم أو معلمة للخذف", "...توقف", "Error");
                }
                else
                {
                    string Teacher = TeacherTextBox.Text;
                    DialogResult dr = MessageBox.Show($"  هل أنت متأكد من حذف ({Teacher}) ؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        Deletion.Delete_Teacher(TeacherID.ToString());
                        MainClass.ShowMSG($" لقد تم الحذف  بنجاح", "نجحة العملية", "Success");
                        MainClass.disable_reset(panel5);
                        Fill_TeachersGridView();
                    }
                }
            }
            else
            {
                MainClass.ShowMSG("الرجاء إختيار معلم أو معلمة للخذف", "...توقف", "Error");
            }
        }

        public override void SaveButton_Click(object sender, EventArgs e)
        {
            if (GenderComboBox.SelectedIndex == -1 || TeacherTextBox.Text == ""  || ActiveComboBox.SelectedIndex == -1)
            {
                MainClass.ShowMSG("الرجاء ملأ جميع الحفول", "...توقف", "Error");
            }
            else
            {
                string Gender = GenderComboBox.Text;
                string Teacher = TeacherTextBox.Text;
                string Phone = PhoneTextBox.Text;
                string Active = ActiveComboBox.Text;
                if (Phone == "")
                    Phone = "-";

                if (edit == 0)//Code for Add operation
                {

                    Insertion.Insert_Teacher(Teacher, Gender, Phone, Active);
                    MainClass.ShowMSG($"  لقد تم حفظ  ({Teacher}) بنجاح", "نجحة العملية", "Success");
                    MainClass.disable_reset(panel5);
                    Fill_TeachersGridView();

                }
                else if (edit == 1)//Code for Edit operation
                {

                    Updation.Update_Teacher(TeacherID.ToString(), Teacher, Gender, Phone, Active);
                    MainClass.ShowMSG($"  لقد تم تعديل  ({Teacher}) بنجاح", "نجحة العملية", "Success");
                    MainClass.disable_reset(panel5);
                    Fill_TeachersGridView();
                }
            }        
        }

        public override void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            TeachersBindingSource.Filter = "[الإسم] LIKE '%" + SearchTextBox.Text + "%' OR [مفعل] LIKE '%" + SearchTextBox.Text + "%' OR [جنس] LIKE '%" + SearchTextBox.Text + "%' OR [الهاتف] LIKE '%" + SearchTextBox.Text + "%'";
            DataGridViewTeachers.DataSource = TeachersBindingSource;
        }

        private void DataGridViewTeachers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            { 
                edit = 1;
                MainClass.disable(panel5);
                DataGridViewRow row = DataGridViewTeachers.Rows[e.RowIndex];
                TeacherID = Convert.ToInt32(row.Cells["TeacherIDcolumn"].Value.ToString());
                GenderComboBox.SelectedItem = row.Cells["Gendercolumn"].Value.ToString();
                TeacherTextBox.Text = row.Cells["TeacherColumn"].Value.ToString();
                PhoneTextBox.Text = row.Cells["Phonecolumn"].Value.ToString();              
                ActiveComboBox.SelectedItem = row.Cells["Activecolumn"].Value.ToString();
            }
        }
    }
}
