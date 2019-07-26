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
    public partial class ResultPage : Form
    {
        public ResultPage()
        {
            InitializeComponent();
        }

        private void ResultPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'resultdatasett1.result2' table. You can move, or remove it, as needed.
            this.result2TableAdapter.Fill(this.resultdatasett1.result2);
            // TODO: This line of code loads data into the 'resultdatasett.result2' table. You can move, or remove it, as needed.
            this.result2TableAdapter.Fill(this.resultdatasett.result2);

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.result2TableAdapter.Fill(this.resultdatasett.result2);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {

        

        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.result2TableAdapter.Fill(this.resultdatasett.result2);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.result2TableAdapter.FillBy(this.resultdatasett.result2);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }      
    }
}
