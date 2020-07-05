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
    public partial class Sample2 : Form
    {
        public Sample2()
        {
            InitializeComponent();
        }

        private void Sample2_Load(object sender, EventArgs e)
        {
            UsernameLabel.Text = MainClass.USERNAME;
        }

        public virtual void AddButton_Click(object sender, EventArgs e)
        {

        }

        public virtual void EditButton_Click(object sender, EventArgs e)
        {

        }

        public virtual void DeleteButton_Click(object sender, EventArgs e)
        {

        }

        public virtual void SaveButton_Click(object sender, EventArgs e)
        {

        }

        public virtual void SearchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            HomePage hm = new HomePage();
            MainClass.ShowWindow(hm, this, MDI.ActiveForm);
        }

        private void Sample2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                BackButton.PerformClick();
            }
        }
    }
}
