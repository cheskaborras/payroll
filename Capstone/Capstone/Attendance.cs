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
    public partial class frmAttendance : Form
    {
        public frmAttendance()
        {
            InitializeComponent();
        }

        private void btnTimeIn_Click(object sender, EventArgs e)
        {
            txtTimeIn.Text = DateTime.Now.ToString("HH:mm:ss tt");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtTimeOut.Text = DateTime.Now.ToString("HH:mm:ss tt");
        }
    }
}
