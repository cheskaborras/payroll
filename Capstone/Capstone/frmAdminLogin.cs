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
    public partial class frmAdminLogin : Form
    {
        public frmAdminLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {

                string myConnection = "datasource=localhost;port=3306;username=root;password=root";
                MySqlConnection myConn = new MySqlConnection(myConnection);

                MySqlCommand SelectCommand = new MySqlCommand(" select * from database.employeinfo where user_name='" + this.txtUsername.Text + "' and password='" + this.txtPassword.Text + "' ;", myConn);

                MySqlDataReader myReader;
                myConn.Open();
                myReader = SelectCommand.ExecuteReader();
                int count = 0;
                while (myReader.Read()) 
                {
                    count = count + 1;
                }

                if (count == 1)
                {
                    MessageBox.Show("Username and Password is Correct!");
                    var AdminMenu = new frmAdminMenu();
                    AdminMenu.Show();
                    this.Hide();

                }

                else if (count > 1)
                {
                    MessageBox.Show("Duplicate Username and password, Access Denied!");
                }

                else
                    MessageBox.Show("Username or Password is not correct, Please try again!");
                myConn.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
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
