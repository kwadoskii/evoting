using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using GriauleFingerprintLibrary;
using GriauleFingerprintLibrary.Exceptions;
using GriauleFingerprintLibrary.DataTypes;
using GriauleFingerprintLibrary.Events;

namespace WindowsFormsApplication7
{
    public partial class voterInterface : Form
    {
        GriauleFingerprintLibrary.FingerprintCore core;
        GriauleFingerprintLibrary.DataTypes.FingerprintRawImage huella;
        GriauleFingerprintLibrary.DataTypes.FingerprintTemplate template;
        public voterInterface()
        {
            InitializeComponent();
            fillOfficeCombo();
        }

        public static string myConnection = "Data Source=.\\sqlexpress;Initial Catalog=testdb;Integrated Security=True";
        public string election_office;
        List<string> officeLists = new List<string>();
        public bool Voted;
        //public bool notVoted = false;
        public string id;

        int count = 0;
        RadioButton[] rbutton = new RadioButton[10];

        public Point _RadiobuttonPos = new Point(36, 70);
        private void voterInterface_Load(object sender, EventArgs e)
        {
            core = new GriauleFingerprintLibrary.FingerprintCore();
            core.onStatus += new GriauleFingerprintLibrary.StatusEventHandler(core_onStatus);
            core.onImage += new GriauleFingerprintLibrary.ImageEventHandler(core_onImage);

            id = MainLoginPage.id.ToString(); 
            checkifuserhasvoted();
            if (Voted == false) 
            { 
                loadCandidateInfo();
            } 
            else 
            {
                votedGUI();
            }            
        }

        private void loadCandidateInfo()
        {
            //inhrited from mainloginPage
            //label1.Text = id.ToString();
            string myConnection = "Data Source=.\\sqlexpress;Initial Catalog=testdb;Integrated Security=True";
            string query = "SELECT * FROM voters WHERE id = '" + id +"' ;";
            //string query = "SELECT * FROM voters WHERE id = '30' ;";

            SqlConnection myConn = new SqlConnection(myConnection);
            SqlCommand cmd = new SqlCommand(query, myConn);
            SqlDataReader dbr;

            try
            {
                myConn.Open();
                dbr = cmd.ExecuteReader();
                while (dbr.Read())
                {
                    string vName = dbr.GetString(2);
                    string vSurname = dbr.GetString(1);
                    string vDept = dbr.GetString(6);
                    string vMiddlename = dbr.GetString(3);
                    string vRegN = dbr.GetString(7);
                    string space = " ";

                    label1.Text = vSurname + space + vName + space + vMiddlename;
                    label2.Text = vDept;

                    byte[] imgg = (byte[])dbr["image"];
                    if (imgg == null)
                        voterPassport.Image = null;
                    else
                    {
                        MemoryStream mstream = new MemoryStream(imgg);
                        voterPassport.Image = System.Drawing.Image.FromStream(mstream);
                    }
                }

            }
            catch
            {

            }
        }

        void fillOfficeCombo()
        {
            //string myConnection = "Data Source=.\\sqlexpress;Initial Catalog=testdb;Integrated Security=True";
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
                    comboBox1.Items.Add(dbr[1]);
                    election_office = dbr.GetString(1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            string voted = "UPDATE voters SET voted = 1 WHERE id = '" + id + "' ;";
            //string voted = "UPDATE voters SET voted = 1 WHERE id = '30' ;";
            SqlConnection myConn = new SqlConnection(myConnection);
            SqlCommand cmd = new SqlCommand(voted, myConn);
            SqlDataReader dbr;

            try
            {
                myConn.Open();
                dbr = cmd.ExecuteReader();
                core.CaptureFinalize();
                core.Finalizer();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Hide();

            MainLoginPage mainLogin = new MainLoginPage();
            mainLogin.ShowDialog();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //{
                string Office_querry = "SELECT * FROM candidates WHERE office = '" + comboBox1.Text + "';";
                //comboBox2.SelectedIndex = -1;
                DeleteRadioButton();
                SqlConnection myConn = new SqlConnection(myConnection);
                SqlCommand cmd = new SqlCommand(Office_querry, myConn);
                SqlDataReader dbr;

                try
                {
                    myConn.Open();
                    dbr = cmd.ExecuteReader();              

                    while (dbr.Read())
                    {
                        string candidate_surname = dbr.GetString(1);
                        string canditate_name = dbr.GetString(2);
                        byte[] immg = (byte[])dbr["image"];

                        officeLists.Add(candidate_surname + " " + canditate_name);                        
                        count++;
                    }
                    label3.Text = comboBox1.Text;
                    createRadioButton();
                    comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
                  
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            //}
            //else { MessageBox.Show("U have voted"); }
        }

        private void createRadioButton()
        {
            officeLists.ToArray();
            for (int i = 0; i < officeLists.Count; i++)
            {
                rbutton[i] = new RadioButton();
                rbutton[i].Name = "rbutton" + i;
                rbutton[i].Font = new Font("Microsoft Sans Serif", 15);
                rbutton[i].Text = officeLists[i];
                rbutton[i].Left = _RadiobuttonPos.X;
                rbutton[i].Top = _RadiobuttonPos.Y;
                rbutton[i].Size = new Size(186, 35);
                //rbutton[i].Dock = DockStyle.Fill;

                this.Controls.Add(rbutton[i]);
                flowLayoutPanel1.Controls.Add(rbutton[i]);
                _RadiobuttonPos.Y += 25;
                rbutton[i].CheckedChanged += RadioButtonCheckedChanged;
            }
            //officeLists.Clear();_RadiobuttonPos.Y = new Point(36, 70);
        }

        private void DeleteRadioButton()
        {
            officeLists.ToArray();
            for (int i = 0; i < officeLists.Count; i++)
            {
                if (flowLayoutPanel1.Controls.Contains(rbutton[i]))
                {
                    rbutton[i].CheckedChanged -= RadioButtonCheckedChanged;
                    flowLayoutPanel1.Controls.Remove(rbutton[i]);
                    rbutton[i].Dispose();
                }
                _RadiobuttonPos.Y -= 25;
            }
            officeLists.Clear();
        }

        private void RadioButtonCheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                string name = ((RadioButton)sender).Text.ToString();

                string vote = "INSERT INTO result2 (election, candidate, voterId) VALUES ( '" + label3.Text + "', '" + 
                    name + "','" + id + "');";
                
                SqlConnection myConn = new SqlConnection(myConnection);
                SqlCommand cmd = new SqlCommand(vote, myConn);
                SqlDataReader dbr;

                try
                {
                    myConn.Open();
                    dbr = cmd.ExecuteReader();
                }
                catch
                {}

                MessageBox.Show("You Voted "+ name +" as "+ label3.Text +" ", "Successfully Voted",
                    MessageBoxButtons.OK,MessageBoxIcon.Information);

                for (int i = 0; i < officeLists.Count; i++)
                {
                    rbutton[i].Enabled = false;
                }
            }
        }

        private bool checkifuserhasvoted()
        {
            //string ifvoted = "SELECT * FROM voters WHERE id = '30' ;";
            string ifvoted = "SELECT * FROM voters WHERE id = '" + id + "' ;";
            SqlConnection myConn = new SqlConnection(myConnection);
            SqlCommand cmd = new SqlCommand(ifvoted, myConn);
            SqlDataReader dbr;

            try
            {
                myConn.Open();
                dbr = cmd.ExecuteReader();

                while (dbr.Read())
                {
                    Voted = dbr.GetBoolean(12);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);         
           }
            return Voted;             
        }

        private void votedGUI()
        {
            loadCandidateInfo();
            comboBox1.Enabled = false;            
            label3.Text = "You have Already Voted!";
        }

        void core_onImage(object source, GriauleFingerprintLibrary.Events.ImageEventArgs ie)
        {
            try
            {
                huella = ie.RawImage;

                core.Extract(huella, ref template);

            }
            catch (Exception)
            { }
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
    }
}
