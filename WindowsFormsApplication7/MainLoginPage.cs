using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using GriauleFingerprintLibrary.DataTypes;
using GriauleFingerprintLibrary.Events;
using GriauleFingerprintLibrary.Exceptions;
using GriauleFingerprintLibrary;



namespace WindowsFormsApplication7
{
    public partial class MainLoginPage : Form
    {
        GriauleFingerprintLibrary.FingerprintCore core;
        GriauleFingerprintLibrary.DataTypes.FingerprintRawImage huella;
        GriauleFingerprintLibrary.DataTypes.FingerprintTemplate template;
        public MainLoginPage()
        {
            InitializeComponent();
            MaximizeBox = false;
        }
        
        public string regno, password;

        private void MainLoginPage_Load(object sender, EventArgs e)
        {
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

        void core_onImage(object source, GriauleFingerprintLibrary.Events.ImageEventArgs ie)
        {
            try
            {
                huella = ie.RawImage;

                core.Extract(huella, ref template);
                mainLoginPgFPImageBox.Image = huella.Image;

            }
            catch(Exception)
            {}
        }

        void core_onStatus(object source, GriauleFingerprintLibrary.Events.StatusEventArgs se)
        {

            if (se.StatusEventType == GriauleFingerprintLibrary.Events.StatusEventType.SENSOR_PLUG)
            {
                core.StartCapture(source);
            }
            else
            {
                core.StopCapture(source);
            }
        }

        public static int id;
        private void button1_Click(object sender, EventArgs e)
        {            
            byte[] dataTemp;
            GriauleFingerprintLibrary.DataTypes.FingerprintTemplate templateTemp;

            int precision;
            try
            {
                string myConnection = "Data Source=.\\sqlexpress;Initial Catalog=testdb;Integrated Security=True";
                string querry = "SELECT * FROM voters WHERE 1=1 AND regno = '" + this.voterRegNo_txt.Text + "' AND password='" +
                    this.voterPass_txt.Text + "'";
                SqlConnection myConn = new SqlConnection(myConnection);

                SqlCommand cmd = new SqlCommand(querry, myConn);
                SqlDataReader dbr;
                if (template != null)
                {
                    core.IdentifyPrepare(template);
                }

                myConn.Open();
                dbr = cmd.ExecuteReader();

                if (voterRegNo_txt.Text == string.Empty & voterPass_txt.Text == string.Empty & template == null)
                {
                    MessageBox.Show("Enter your Reg. No and Password,\nThen Place Your Finger on the Sensor", "Invalid Login");
                    return;
                }
                else
                {
                    if ((voterRegNo_txt.Text == string.Empty))
                    {
                        MessageBox.Show("Enter your Reg. No");
                    }
                    else
                    {
                        if ((voterPass_txt.Text == string.Empty))
                        {
                            MessageBox.Show("Enter Your Password");
                        }
                        else
                        {
                            if ((template == null))
                            {
                                MessageBox.Show("Place Your Finger on the Fingerprint Device");
                            }
                            else
                            {
                                while (dbr.Read())
                                {
                                    dataTemp = (byte[])dbr["fingerprint"];
                                    templateTemp = new GriauleFingerprintLibrary.DataTypes.FingerprintTemplate();
                                    templateTemp.Buffer = dataTemp;
                                    templateTemp.Size = dataTemp.Length;

                                    id = dbr.GetInt32(0);
                                    regno = dbr.GetString(7);
                                    password = dbr.GetString(8);

                                    if ((core.Identify(templateTemp, out precision)) == 1)
                                    {
                                        this.Hide();
                                        voterInterface voterInterface = new voterInterface();
                                        voterInterface.ShowDialog();
                                        return;
                                    }
                                 }

                                if (voterRegNo_txt.Text == regno && voterPass_txt.Text == password)
                                {
                                    MessageBox.Show("The FingerPrint Does not Match that of: " + this.voterRegNo_txt.Text +
                                         "\nPlease Try Again.", "Failed to Verify");
                                }
                                else
                                {
                                    MessageBox.Show("Invalid Details Entered!");
                                }
                                this.voterRegNo_txt.Text = null;
                                this.voterPass_txt.Text = null;
                                mainLoginPgFPImageBox.Image = null;
                                template = null;
                                templateTemp = null;
                            }
                        }
                    }           
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }        
        }       

        private void adminLoginLink_Click(object sender, EventArgs e)
        {
            core.CaptureFinalize();
            core.Finalizer();
            this.Hide();

            adminLoginPage adminLogin = new adminLoginPage();
            adminLogin.ShowDialog();
        }

        private void MainLoginPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                //core.CaptureFinalize();
                //core.Finalizer();
            }
            catch{}
        }        
    }
}
