using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace capstone
{
    public partial class frmregister : Form
    {
        public frmregister()
        {
            InitializeComponent();
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=root";
                string query = "INSERT INTO frmregister.emprecords(Firstname,Middlename) VALUES ( '" + this.txtFirstname.Text + "', '" + txtMiddlename.Text + "');";

                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlCommand myCmd = new MySqlCommand(query, myConn);
                MySqlDataReader myreader;
                myConn.Open();
                myreader = myCmd.ExecuteReader();
                MessageBox.Show("save data");
                while (myreader.Read())
                {
                }
                myConn.Close();
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

    }
}