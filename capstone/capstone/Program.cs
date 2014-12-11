using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LoginTesting_with_MySql_Dbase
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmAccount());
        }
    }
}
