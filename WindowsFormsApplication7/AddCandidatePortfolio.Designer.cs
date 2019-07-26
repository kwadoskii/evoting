namespace WindowsFormsApplication7
{
    partial class AddCandidatePortfolio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCandidatePortfolio));
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.electionStartDate = new System.Windows.Forms.DateTimePicker();
            this.electionEndDate = new System.Windows.Forms.DateTimePicker();
            this.testdbDataSet = new WindowsFormsApplication7.testdbDataSet();
            this.election_txt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.testdbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(244, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 29);
            this.button2.TabIndex = 0;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Portfolio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "End Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Start Date:";
            // 
            // electionStartDate
            // 
            this.electionStartDate.CustomFormat = "yyyy-MM-dd";
            this.electionStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.electionStartDate.Location = new System.Drawing.Point(173, 91);
            this.electionStartDate.Name = "electionStartDate";
            this.electionStartDate.Size = new System.Drawing.Size(98, 20);
            this.electionStartDate.TabIndex = 7;
            // 
            // electionEndDate
            // 
            this.electionEndDate.CustomFormat = "yyyy-MM-dd";
            this.electionEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.electionEndDate.Location = new System.Drawing.Point(173, 129);
            this.electionEndDate.Name = "electionEndDate";
            this.electionEndDate.Size = new System.Drawing.Size(98, 20);
            this.electionEndDate.TabIndex = 8;
            // 
            // testdbDataSet
            // 
            this.testdbDataSet.DataSetName = "testdbDataSet";
            this.testdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // election_txt
            // 
            this.election_txt.Location = new System.Drawing.Point(173, 48);
            this.election_txt.Name = "election_txt";
            this.election_txt.Size = new System.Drawing.Size(281, 20);
            this.election_txt.TabIndex = 2;
            // 
            // AddCandidatePortfolio
            // 
            this.ClientSize = new System.Drawing.Size(485, 253);
            this.Controls.Add(this.electionEndDate);
            this.Controls.Add(this.electionStartDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.election_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddCandidatePortfolio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Portfolio";
            ((System.ComponentModel.ISupportInitialize)(this.testdbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker electionStartDate;
        private System.Windows.Forms.DateTimePicker electionEndDate;
        private testdbDataSet testdbDataSet;
        private System.Windows.Forms.TextBox election_txt;
    }
}