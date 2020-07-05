using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlaaSchool_TimeTable
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Editing MessageBox default options
            MessageBoxManager.Yes = "نعم";
            MessageBoxManager.No = "لا";
            MessageBoxManager.OK = "موافق";
            MessageBoxManager.Register();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MDI());
        }
    }
}
