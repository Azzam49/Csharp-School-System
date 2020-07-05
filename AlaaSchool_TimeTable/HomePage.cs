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
    public partial class HomePage : Sample
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void usersFormButton_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            MainClass.ShowWindow(users, this, MDI.ActiveForm);
        }

        private void TeachersFormButton_Click(object sender, EventArgs e)
        {
            Teachers teachers = new Teachers();
            MainClass.ShowWindow(teachers, this, MDI.ActiveForm);
        }

        private void SubjectsFormButton_Click(object sender, EventArgs e)
        {
            Subjects subjects = new Subjects();
            MainClass.ShowWindow(subjects, this, MDI.ActiveForm);
        }

        private void AssignmentsFormButton_Click(object sender, EventArgs e)
        {
            AssignmentsForm assignments = new AssignmentsForm();
            MainClass.ShowWindow(assignments, this, MDI.ActiveForm);
        }

        private void TimeTableFormButton_Click(object sender, EventArgs e)
        {
            TimeTable timeTable = new TimeTable();
            MainClass.ShowWindow(timeTable, this, MDI.ActiveForm);
        }
    }
}
