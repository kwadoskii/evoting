namespace WindowsFormsApplication7
{
    partial class ResultPage
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultPage));
            this.resultdatasett = new WindowsFormsApplication7.resultdatasett();
            this.result2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.result2TableAdapter = new WindowsFormsApplication7.resultdatasettTableAdapters.result2TableAdapter();
            this.resultdatasett1 = new WindowsFormsApplication7.resultdatasett();
            this.resultdatasett1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.result2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.electionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.candidateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.resultdatasett)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.result2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultdatasett1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultdatasett1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.result2BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // resultdatasett
            // 
            this.resultdatasett.DataSetName = "resultdatasett";
            this.resultdatasett.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // result2BindingSource
            // 
            this.result2BindingSource.DataMember = "result2";
            this.result2BindingSource.DataSource = this.resultdatasett;
            // 
            // result2TableAdapter
            // 
            this.result2TableAdapter.ClearBeforeFill = true;
            // 
            // resultdatasett1
            // 
            this.resultdatasett1.DataSetName = "resultdatasett";
            this.resultdatasett1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // resultdatasett1BindingSource
            // 
            this.resultdatasett1BindingSource.DataSource = this.resultdatasett1;
            this.resultdatasett1BindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.electionDataGridViewTextBoxColumn,
            this.candidateDataGridViewTextBoxColumn,
            this.resultCountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.result2BindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(520, 401);
            this.dataGridView1.TabIndex = 0;
            // 
            // result2BindingSource1
            // 
            this.result2BindingSource1.DataMember = "result2";
            this.result2BindingSource1.DataSource = this.resultdatasett1BindingSource;
            // 
            // electionDataGridViewTextBoxColumn
            // 
            this.electionDataGridViewTextBoxColumn.DataPropertyName = "Election";
            this.electionDataGridViewTextBoxColumn.HeaderText = "Election";
            this.electionDataGridViewTextBoxColumn.Name = "electionDataGridViewTextBoxColumn";
            this.electionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // candidateDataGridViewTextBoxColumn
            // 
            this.candidateDataGridViewTextBoxColumn.DataPropertyName = "Candidate";
            this.candidateDataGridViewTextBoxColumn.HeaderText = "Candidate";
            this.candidateDataGridViewTextBoxColumn.Name = "candidateDataGridViewTextBoxColumn";
            this.candidateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // resultCountDataGridViewTextBoxColumn
            // 
            this.resultCountDataGridViewTextBoxColumn.DataPropertyName = "Result Count";
            this.resultCountDataGridViewTextBoxColumn.HeaderText = "Result Count";
            this.resultCountDataGridViewTextBoxColumn.Name = "resultCountDataGridViewTextBoxColumn";
            this.resultCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ResultPage
            // 
            this.ClientSize = new System.Drawing.Size(520, 401);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResultPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Result";
            this.Load += new System.EventHandler(this.ResultPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultdatasett)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.result2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultdatasett1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultdatasett1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.result2BindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private resultdatasett resultdatasett;
        private System.Windows.Forms.BindingSource result2BindingSource;
        private resultdatasettTableAdapters.result2TableAdapter result2TableAdapter;
        private System.Windows.Forms.BindingSource resultdatasett1BindingSource;
        private resultdatasett resultdatasett1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource result2BindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn electionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn candidateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultCountDataGridViewTextBoxColumn;

    }
}