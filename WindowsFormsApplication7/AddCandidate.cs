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
    public partial class AddCandidate : Form
    {
        public AddCandidate()
        {
            InitializeComponent();
            fillcanCombo();            
        }
        string pix;
        byte[] imageByte = null;

        private void registerCandidate_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fstream = new FileStream(pix, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fstream);
                imageByte = br.ReadBytes((int)fstream.Length);
            }
            catch //(Exception ex)
            {
            }
            validate();      
        }

        private void canAddPix_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = " JPG Files(*.jpg)|*.jpg| PNG Files(*.png)|*.png| All Files(*.*)|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string picLoc = dlg.FileName.ToString();
                canPixBox.ImageLocation = picLoc;
                pix = picLoc;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        void fillcanCombo()
        {
            string myConnection = "Data Source=.\\sqlexpress;Initial Catalog=testdb;Integrated Security=True";
            //string myConnection = "server = sql5.freemysqlhosting.net; port = 3306; database = sql5126236; uid = sql5126236; password = KlnK29E6jB ";
            string query = "select * from elections ;";
            SqlConnection myConn = new SqlConnection(myConnection);
            SqlCommand cmd = new SqlCommand(query, myConn);
            SqlDataReader dbr;

            try
            {
                myConn.Open();
                dbr = cmd.ExecuteReader();

                while (dbr.Read())
                {
                   canPosition.Items.Add(dbr[1]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void validate()
        {
            //2011/123456
            Regex RXreg = new Regex("^[20]{2}[0-9]{2}/[0-9]{6}$");

            //080***
            Regex RXtel = new Regex("^[0]{1}[7-9]{1}[0-1]{1}[0-9]{8}$");

            string myConnection = "Data Source=.\\sqlexpress;Initial Catalog=testdb;Integrated Security=True";
            string check = "select * from candidates where regNo = '" + canRegNo.Text.ToString() + "'";
            string insert = "insert into candidates (surname, name, middleName, regNo, sex, phoneNo, office, image) values ('" + this.canSurname.Text + "', '" + this.canName.Text + "', '" + this.canMiddleName.Text + "', '" + this.canRegNo.Text + "', '" + this.canSex.Text + "', '" + this.canPhoneNo.Text + "', '" + this.canPosition.Text + "', @IMG ) ;";
            SqlConnection myConn = new SqlConnection(myConnection);

            SqlCommand cmd = new SqlCommand(check, myConn);
            SqlCommand cmd2 = new SqlCommand(insert, myConn);
            SqlDataReader dbr;
            
            try
            {
                if (canSurname.Text == string.Empty & canName.Text == string.Empty & canMiddleName.Text == string.Empty &
                    canRegNo.Text == string.Empty & canSex.Text == string.Empty & canPhoneNo.Text == string.Empty & 
                    canPosition.Text == string.Empty & imageByte == null)
                {
                    MessageBox.Show("All fields are Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (!(canSurname.Text == string.Empty))
                    {
                        if (!(canName.Text == string.Empty))
                        {
                            if (!(canMiddleName.Text == string.Empty))
                            {
                                if (!(canRegNo.Text == string.Empty) & RXreg.IsMatch(canRegNo.Text))
                                {
                                    if (!(canSex.Text == string.Empty))
                                    {
                                        if (!(canPhoneNo.Text == string.Empty) & RXtel.IsMatch(canPhoneNo.Text))
                                        {
                                            if (!(canPosition.Text == string.Empty))
                                            {
                                                if (!(imageByte == null))
                                                {
                                                    myConn.Open();
                                                    cmd2.Parameters.Add(new SqlParameter("@IMG", imageByte));

                                                    dbr = cmd.ExecuteReader();
                                                    int count = 0;
                                                    while (dbr.Read())
                                                    {
                                                        count = count + 1;
                                                    }
                                                    if (count == 1 || count > 1)
                                                    {
                                                        MessageBox.Show("Reg. No Already Exist!","Duplicate Reg. No",
                                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    }
                                                    else
                                                    {
                                                        myConn.Close();
                                                        myConn.Open();
                                                        dbr = cmd2.ExecuteReader();
                                                        while (dbr.Read())
                                                        {

                                                        }
                                                        MessageBox.Show("Registered Successfully", "Successful", 
                                                            MessageBoxButtons.OK, MessageBoxIcon.None);
                                                        this.Hide();
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Select an image", "Error");
                                                }

                                            }
                                            else
                                            {
                                                MessageBox.Show("Select a Positon", "Error");
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Enter a Valid Phone Number", "Error");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Select a Gender", "Error");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Enter a Valid Reg No", "Error");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Middle Name is Empty", "Error");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Name is Empty", "Error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Surname is Empty", "Error");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
