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
    public partial class Users : Sample2
    {
        public Users()
        {
            InitializeComponent();
        }

        int edit;
        int UserID;
        BindingSource UsersBindingSource = new BindingSource();

        private void Fill_UsersGridView()
        {
            //Filling Users DataGridView function
            UserIDcolumn.DataPropertyName = "أيدي";
            Usernamecolumn.DataPropertyName = "الإسم";
            Passwordcolumn.DataPropertyName = "كلمة مرور";
            Positioncolumn.DataPropertyName = "رتبة";
            Activecolumn.DataPropertyName = "مفعل";
            DataTable dataTable = Selection.Get_UsersTable();
            UsersBindingSource.DataSource = dataTable;
            DataGridViewUsers.DataSource = UsersBindingSource;
            //Filling SNO
            MainClass.CountColumn(DataGridViewUsers, "Countcolumn");

        }

        private void Users_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(panel5);
            Fill_UsersGridView();
        }

      

        public override void AddButton_Click(object sender, EventArgs e)
        {
            MainClass.enable_reset(panel5);
            edit = 0;

            //set focus on 1st control
            this.ActiveControl = UsernameTextBox;
        }

        public override void EditButton_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.enable(panel5);
            //Locking password controls
            PasswordTextBox.Enabled = false;
            RePasswordTextBox.Enabled = false;
        }

        public override void DeleteButton_Click(object sender, EventArgs e)
        {
            if(edit == 1)
            {   if(UsernameTextBox.Text == "")
                {
                    MainClass.ShowMSG("الرجاء إختيار مستخدم للخذف", "...توقف", "Error");
                }
                else
                {
                    DialogResult dr = MessageBox.Show($" هل أنت متأكد من حذف المستخدم ({UsernameTextBox.Text}) ؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        Deletion.Delete_User(UserID.ToString());
                        MainClass.ShowMSG($"  لقد تم الحذف بنجاح", "نجحة العملية", "Success");
                        MainClass.disable_reset(panel5);
                        Fill_UsersGridView();
                    }
                }
            }
            else
            {
                MainClass.ShowMSG("الرجاء إختيار مستخدم للخذف", "...توقف", "Error");
            }
        }
        
        public override void SaveButton_Click(object sender, EventArgs e)
        {
            if(UsernameTextBox.Text == "" || PasswordTextBox.Text == "" || RePasswordTextBox.Text == "" || PositionComboBox.SelectedIndex == -1 || ActiveComboBox.SelectedIndex == -1)
            {
                MainClass.ShowMSG("الرجاء ملأ جميع الحفول", "...توقف", "Error");
            }
            else
            {
                if(RePasswordTextBox.Text != PasswordTextBox.Text)
                {
                    MainClass.ShowMSG("الرجاء التأكد من تطابق كلمة المرور", "...توقف", "Error");
                }
                else
                {
                    string User = UsernameTextBox.Text;
                    string Password = RePasswordTextBox.Text;
                    string Position = PositionComboBox.Text;
                    string Active = ActiveComboBox.Text;

                    if (edit == 0)//Code for Add operation
                    {
                        if(MainClass.User_Exists(User) == true)
                        {
                            MainClass.ShowMSG($"لقد تم إضافة مستخدم أخر بنفس الأسم مسبقا  ", "...توقف", "Error");
                        }
                        else
                        {
                            Insertion.Insert_User(User, Password, Position, Active);
                            MainClass.ShowMSG($"  لقد تم حفظ  المستخدم  ({User}) بنجاح", "نجحة العملية", "Success");                           
                            MainClass.disable_reset(panel5);
                            Fill_UsersGridView();
                        }                    
                    }
                   else if(edit == 1)//Code for Edit operation
                    {
                        Updation.Update_User(UserID.ToString(), User, Position, Active);
                        MainClass.ShowMSG($"  لقد تم تعديل  المستخدم  ({User}) بنجاح", "نجحة العملية", "Success");                     
                        MainClass.disable_reset(panel5);
                        Fill_UsersGridView();
                    }
                }
            }
        }

        public override void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            UsersBindingSource.Filter = "[الإسم] LIKE '%" + SearchTextBox.Text + "%' OR [مفعل] LIKE '%" + SearchTextBox.Text + "%' OR [رتبة] LIKE '%" + SearchTextBox.Text + "%' ";
            DataGridViewUsers.DataSource = UsersBindingSource;
        }
    

        private void DataGridViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                MainClass.disable(panel5);
                DataGridViewRow row = DataGridViewUsers.Rows[e.RowIndex];
                UserID = Convert.ToInt32(row.Cells["UserIDcolumn"].Value.ToString());
                UsernameTextBox.Text = row.Cells["Usernamecolumn"].Value.ToString(); 
                PasswordTextBox.Text = row.Cells["Passwordcolumn"].Value.ToString();
                RePasswordTextBox.Text = row.Cells["Passwordcolumn"].Value.ToString();
                PositionComboBox.SelectedItem = row.Cells["Positioncolumn"].Value.ToString(); 
                ActiveComboBox.SelectedItem = row.Cells["Activecolumn"].Value.ToString(); 
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
