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
using System.IO;
using System.Text.RegularExpressions;


namespace WindowsFormsApplication7
{
    public partial class AddCandidatePortfolio : Form
    {
        public AddCandidatePortfolio()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string myConnection = "Data Source=.\\sqlexpress;Initial Catalog=testdb;Integrated Security=True";
            string check = "SELECT * FROM elections WHERE office = '" + this.election_txt.Text.ToString() +"' ";
            string insert = "INSERT INTO elections (office, startdate, enddate) VALUES ('" + this.election_txt.Text + "', '" + this.electionStartDate.Text+ "' , '" + this.electionEndDate.Text + "') ; ";
            SqlConnection myConn = new SqlConnection(myConnection);

            SqlCommand cmd = new SqlCommand(check, myConn);
            SqlCommand cmd2 = new SqlCommand(insert, myConn);
            SqlDataReader dbr;

            try
            {
                if (!(election_txt.Text == string.Empty))
                {
                    myConn.Open();
                    dbr = cmd.ExecuteReader();

                    int count = 0;
                    while (dbr.Read())
                    {
                        count = count + 1;
                    }

                    if (count == 1 || count > 1)
                    {
                        MessageBox.Show("Portofolio already exist!");
                    }
                    else
                    {
                        myConn.Close();
                        myConn.Open();
                        dbr = cmd2.ExecuteReader();
                        while (dbr.Read())
                        {

                        }
                        MessageBox.Show("Office Added Successfully");
                        this.Hide();
                        //this.election_txt.Text = string.Empty;


                       }

                }
                else
                {
                    MessageBox.Show("Please Enter a Portfolio");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                }
    }
}
