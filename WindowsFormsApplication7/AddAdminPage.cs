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
    public partial class AddAdminPage : Form
    {
        public AddAdminPage()
        {
            InitializeComponent();
            MaximizeBox = false;            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addAdminButton_Click(object sender, EventArgs e)
        {

            string myConnection = "Data Source=.\\sqlexpress;Initial Catalog=testdb;Integrated Security=True";
            //string myConnection = "server = sql5.freemysqlhosting.net; port = 3306; database = sql5126236; uid = sql5126236; password = KlnK29E6jB ";
            string check = "select * from admins where username = '" + adminUsername_txt.Text.ToString() + "'";
            string insert = "insert into admins (surname, name, username, password) values ('" + this.adminSurname_txt.Text + "', '" +
                this.adminName_txt.Text + "', '" + this.adminUsername_txt.Text + "', '" + this.adminPassword_txt.Text + "' ); ";

            SqlConnection myConn = new SqlConnection(myConnection);
            //MySqlConnection myConn = new MySqlConnection(myConnection);

            SqlCommand cmd = new SqlCommand(check, myConn);
            SqlCommand cmd2 = new SqlCommand(insert, myConn);
            SqlDataReader dbr;

            //MySqlCommand cmd = new MySqlCommand(check, myConn);
            //MySqlCommand cmd2 = new MySqlCommand(insert, myConn);
            //MySqlDataReader dbr;


            try
            {
                if (!(adminSurname_txt.Text == string.Empty))
                {
                    if (!(adminName_txt.Text == string.Empty))
                    {
                        if (!(adminUsername_txt.Text == string.Empty))
                        {
                            if (!(adminPassword_txt.Text == string.Empty))
                            {
                                myConn.Open();
                                dbr = cmd.ExecuteReader();
                                int count = 0;
                                while (dbr.Read())
                                {
                                    count = count + 1;
                                }
                                if (count == 1 || count >1)
                                {
                                MessageBox.Show("Username Already Exist!");
                                }
                                else
                                {
                                    myConn.Close();
                                    myConn.Open();
                                    dbr = cmd2.ExecuteReader();
                                    while (dbr.Read())
                                    {

                                    }
                                    MessageBox.Show("Saved Successfully");
                                    this.Close();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Password is Empty");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Username is Empty");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Name is Empty");
                    }
                }
                else
                {
                    MessageBox.Show("Surname is Empty");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
             
        }
        }
    }