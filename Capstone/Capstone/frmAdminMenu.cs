using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LoginTesting_with_MySql_Dbase
{
    public partial class frmAdminMenu : Form
    {
        public frmAdminMenu()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            var frmLogin = new frmAdminLogin();
            frmLogin.Show();
            this.Hide();
            
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            var attendance = new frmAttendance();
            attendance.Show();
            this.Hide();
        }
    }
}
