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
    public partial class frmEmployeeLogin : Form
    {
        public frmEmployeeLogin()
        {
            InitializeComponent();
        }

        private void frmEmployeeLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var Accounts = new frmAccount();
            Accounts.Show();
            this.Hide();
        }
    }
}
