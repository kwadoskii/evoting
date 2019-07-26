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
using GriauleFingerprintLibrary;
using GriauleFingerprintLibrary.Exceptions;
using GriauleFingerprintLibrary.DataTypes;
using GriauleFingerprintLibrary.Events;



namespace WindowsFormsApplication7
{
    public partial class voterRegistrationForm : Form
    {
        GriauleFingerprintLibrary.FingerprintCore core;
        GriauleFingerprintLibrary.DataTypes.FingerprintRawImage huella;
        GriauleFingerprintLibrary.DataTypes.FingerprintTemplate template;

        string pix;
        byte[] imageByte = null;
        public voterRegistrationForm()
        {
            InitializeComponent();
            MaximizeBox = false;
        }
               
        private void voterRegistrationForm_Load(object sender, EventArgs e)
        {
            //GriauleFingerprintLibrary.FingerprintCore core = new GriauleFingerprintLibrary.FingerprintCore();
            core = new GriauleFingerprintLibrary.FingerprintCore();
            
            core.onStatus += new GriauleFingerprintLibrary.StatusEventHandler(core_onStatus);
            core.onImage += new GriauleFingerprintLibrary.ImageEventHandler(core_onImage);


            try
            {
                core.Initialize();
                core.CaptureInitialize();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        delegate void SetTextCallback(string text);
        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.FPquality.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.FPquality.Text = text;
            }
        }
        void core_onImage(object source, GriauleFingerprintLibrary.Events.ImageEventArgs ie)
        {
            // button1.Enabled = false;
            try
            {
                huella = ie.RawImage;
                //template = null;

                core.Extract(huella, ref template); //try to use getbiometric data...

                pictureBox1.Image = huella.Image;
                
                switch (template.Quality)
                {
                    case 0:
                        SetText("Bad Quality");
                        //MessageBox.Show("Huella de mala calidad favor de volver a poner el dedo", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;

                    case 1:
                        SetText("Medium Quality");
                        // MessageBox.Show("Fingerprint has a medium quality, proceed anyway?", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;

                    case 2:
                        SetText("Good Quality");
                        //MessageBox.Show("Fingerprint has a medium quality, proceed anyway?", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                }
                                
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        void core_onStatus(object source, GriauleFingerprintLibrary.Events.StatusEventArgs se)
        {

            if (se.StatusEventType == GriauleFingerprintLibrary.Events.StatusEventType.SENSOR_PLUG)
            {
                core.StartCapture(source);
            }
            //else
            //{

            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fstream = new FileStream(pix, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fstream);
                imageByte = br.ReadBytes((int)fstream.Length);
            }

            catch (Exception)
            {}

            //2011/123456 Reg. No.
            Regex RXreg = new Regex("^[20]{2}[0-9]{2}/[0-9]{6}$");
            //08**** Telephone No.            
            Regex RXtel = new Regex("^[0]{1}[7-9]{1}[0-1]{1}[0-9]{8}$");

            string myConnection = "Data Source=.\\sqlexpress;Initial Catalog=testdb;Integrated Security=True";
            string check = "SELECT * FROM voters WHERE regNo = '" + voterRegNo.Text.ToString() + "'";

                        
            string insert = "INSERT INTO voters (surname, name, middleName, regNo, phoneNo, password, department, sex, image, fingerprint, fpquality, voted) VALUES ('" +
                this.voterSurname.Text + "', '" + this.voterName.Text + "', '" + this.voterMiddleName.Text + "', '" + this.voterRegNo.Text + "', '" + 
                this.voterPhoneNo.Text + "', '" + this.voterPassword.Text + "', '" + this.voterDept.Text + "', '" + 
                this.voterSex.Text + "', @IMG , @fingerprint , @FPquality, '0' ) ; ";
            SqlConnection myConn = new SqlConnection(myConnection);

            SqlCommand cmd = new SqlCommand(check, myConn);
            SqlCommand cmd2 = new SqlCommand(insert, myConn);
            SqlDataReader dbr;

            try
            {

                if (voterSurname.Text == string.Empty & voterName.Text == string.Empty & voterMiddleName.Text == string.Empty & voterRegNo.Text == string.Empty & 
                    voterPhoneNo.Text == string.Empty & voterPassword.Text == string.Empty & voterDept.Text == string.Empty & voterSex.Text == string.Empty &
                    imageByte == null & template == null)
                {
                    MessageBox.Show("All Fields are Empty");
                    return;
                }
                else
                {
                    if (!(voterSurname.Text == string.Empty))
                    {
                        if (!(voterName.Text == string.Empty))
                        {
                            if (!(voterMiddleName.Text == string.Empty))
                            {
                                if (!(voterRegNo.Text == string.Empty) & RXreg.IsMatch(voterRegNo.Text))
                                {
                                    if (!(voterPhoneNo.Text == string.Empty) & RXtel.IsMatch(voterPhoneNo.Text))
                                    {
                                        if (!(voterPassword.Text == string.Empty))
                                        {
                                            if (!(voterDept.Text == string.Empty))
                                            {
                                                if (!(voterSex.Text == string.Empty))
                                                {
                                                    if (!(imageByte == null))
                                                    {
                                                    GTCheckpass: if (!(template == null))
                                                        {
                                                            myConn.Open();                              // checks if reg no. already exits

                                                            cmd2.Parameters.Add(new SqlParameter("@IMG", imageByte));  // adding of image
                                                            cmd2.Parameters.Add(new SqlParameter("@Fingerprint", (object)template.Buffer));
                                                            cmd2.Parameters.Add(new SqlParameter("@FPquality", template.Quality.ToString()));

                                                            dbr = cmd.ExecuteReader();                  // in the dataBase
                                                            int count = 0;
                                                            while (dbr.Read())
                                                            {
                                                                count = count + 1;
                                                            }
                                                            if (count == 1 || count > 1)
                                                            {
                                                                MessageBox.Show("Reg. No Already Exist!");
                                                            }
                                                            else
                                                            {
                                                                if (voterPassword.Text != voterRPassword.Text) //check for consistensy in password entered
                                                                {
                                                                    MessageBox.Show("Check Password");
                                                                    goto GTCheckpass;
                                                                }
                                                                else
                                                                {
                                                                    myConn.Close();
                                                                    myConn.Open();
                                                                    dbr = cmd2.ExecuteReader();
                                                                    while (dbr.Read())
                                                                    {

                                                                    }
                                                                    MessageBox.Show("Registered Successfully");

                                                                }
                                                                //this.Close();
                                                                clearFields();
                                                            }                                                            

                                                            //voterRegistrationForm VoterRegPage = new voterRegistrationForm();
                                                            //VoterRegPage.ShowDialog();
                                                        }

                                                        else
                                                        {
                                                            MessageBox.Show("No FingerPrint Detected.");
                                                            return;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Select an Image");
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Select a Gender");
                                                }
                                            }

                                            else
                                            {
                                                MessageBox.Show("Select a Department");
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Password is Empty");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Enter a Valid Phone Number");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Enter a Valid Reg. No");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Middle Name is Empty");
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
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = " JPG Files(*.jpg)|*.jpg| PNG Files(*.png)|*.png| All Files(*.*)|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string picLocation = dlg.FileName.ToString();
                voterPictureBox.ImageLocation = picLocation;
                pix = picLocation;
            }
        }

       private void voterRegistrationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            core.Finalizer();
            core.CaptureFinalize();
        }

       private void clearFields()
       {
           this.voterSurname.Text = "";
           this.voterName.Text = "";
           this.voterMiddleName.Text = "";
           this.voterPassword.Text = "";
           this.voterRPassword.Text = "";
           this.voterRegNo.Text = "";
           this.voterPhoneNo.Text = "";
           this.voterDept.Text = "";
           template = null;
           imageByte = null;
           voterSex.Text = "";
           this.voterPictureBox.Image = null;
           this.pictureBox1.Image = null;
           this.FPquality.Text = "";
           this.voterDept.SelectedIndex = -1;
           this.voterSex.SelectedIndex = -1;
       }
                
}
}
