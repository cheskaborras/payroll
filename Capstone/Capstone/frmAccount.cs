using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LoginTesting_with_MySql_Dbase
{
    public partial class frmAccount : Form
    {
        public frmAccount()
        {
            InitializeComponent();
        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
            var AdminLogin = new frmAdminLogin();
            AdminLogin.Show();
            this.Hide();
        }

        private void empBtn_Click(object sender, EventArgs e)
        {
            var EmployeeLogin = new frmEmployeeLogin();
            EmployeeLogin.Show();
            this.Hide();
        }
    }
}
