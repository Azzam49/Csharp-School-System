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
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.MdiParent = this;
            loginForm.WindowState = FormWindowState.Maximized;
            loginForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل أنت متأكد من الغادرة؟", "خروج", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                Application.Exit();
        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["Login"];
            if (fc == null)
            {
                if (MessageBox.Show("هل أنت متأكد من تسجيل خروج؟", "خروج", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Login loginForm = new Login();
                    loginForm.MdiParent = this;
                    loginForm.WindowState = FormWindowState.Maximized;
                    loginForm.Show();
                }               
            }                   
                      
        }
    }
}
