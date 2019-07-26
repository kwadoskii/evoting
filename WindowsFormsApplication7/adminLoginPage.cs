using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;

namespace WindowsFormsApplication7
{
    public partial class adminLoginPage : Form
    {
        public adminLoginPage()
        {
            InitializeComponent();
            this.MaximizeBox = false;           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //string connectionString = new GlobalClass().GetConnectionString();
                string myConnection = "Data Source=.\\sqlexpress;Initial Catalog=testdb;Integrated Security=True";
                //string connectionString = "server = sql5.freemysqlhosting.net; port = 3306; database = sql5126236; uid = sql5126236; password = KlnK29E6jB ";
                string querry = "SELECT * FROM admins WHERE username = '" + this.username_txt.Text + "' AND password ='" 
                    + this.password_txt.Text + "'";
                SqlConnection myConn = new SqlConnection(myConnection);
                //MySqlConnection myConn = new MySqlConnection(connectionString);

                SqlCommand cmd = new SqlCommand(querry, myConn);
                //MySqlCommand cmd = new MySqlCommand(querry, myConn);
                SqlDataReader dbr;
                //MySqlDataReader dbr;
                myConn.Open();
                dbr = cmd.ExecuteReader();
                int count = 0;
                while (dbr.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {
                    //MessageBox.Show("Username and password is correct");
                    this.Hide();
                    AdminPortal adminPortal = new AdminPortal();
                    adminPortal.ShowDialog();
                }
                else{
                    MessageBox.Show("Invalid Login details");
                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainLoginPage mainloginpage = new MainLoginPage();
            mainloginpage.ShowDialog();            
        }

        private void txtbutton_Click(object sender, EventArgs e)
        {
            //this.Close();
        }
               
    }
}
