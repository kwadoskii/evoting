using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class AdminPortal : Form
    {
        public AdminPortal()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           // this.Hide();
            AddCandidate addCandidate= new AddCandidate();
            addCandidate.ShowDialog();           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddAdminPage addAdmin = new AddAdminPage();
            addAdmin.ShowDialog();
        }

        private void adminLogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminLoginPage WelcomePage = new adminLoginPage();
            WelcomePage.ShowDialog();         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            voterRegistrationForm VoterRegPage = new voterRegistrationForm();            
            VoterRegPage.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddCandidatePortfolio OfficeAddPage = new AddCandidatePortfolio();
            OfficeAddPage.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ResultPage Results = new ResultPage();
            Results.Show();
        }        
    }
}
