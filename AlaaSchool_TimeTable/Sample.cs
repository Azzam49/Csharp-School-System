using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finisar.SQLite;

namespace AlaaSchool_TimeTable
{
    public partial class Sample : Form
    {
        public Sample()
        {
            InitializeComponent();
           
        }

        private void Sample_Load(object sender, EventArgs e)
        {
            UsernameLabel.Text = MainClass.USERNAME;
        }

     
    }
}
