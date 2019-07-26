namespace WindowsFormsApplication7
{
    partial class AddAdminPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAdminPage));
            this.adminSurname_txt = new System.Windows.Forms.TextBox();
            this.adminName_txt = new System.Windows.Forms.TextBox();
            this.adminUsername_txt = new System.Windows.Forms.TextBox();
            this.adminPassword_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addAdminButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminSurname_txt
            // 
            this.adminSurname_txt.Location = new System.Drawing.Point(103, 17);
            this.adminSurname_txt.Name = "adminSurname_txt";
            this.adminSurname_txt.Size = new System.Drawing.Size(166, 20);
            this.adminSurname_txt.TabIndex = 0;
            // 
            // adminName_txt
            // 
            this.adminName_txt.Location = new System.Drawing.Point(103, 59);
            this.adminName_txt.Name = "adminName_txt";
            this.adminName_txt.Size = new System.Drawing.Size(166, 20);
            this.adminName_txt.TabIndex = 1;
            // 
            // adminUsername_txt
            // 
            this.adminUsername_txt.Location = new System.Drawing.Point(103, 101);
            this.adminUsername_txt.Name = "adminUsername_txt";
            this.adminUsername_txt.Size = new System.Drawing.Size(166, 20);
            this.adminUsername_txt.TabIndex = 2;
            // 
            // adminPassword_txt
            // 
            this.adminPassword_txt.Location = new System.Drawing.Point(103, 146);
            this.adminPassword_txt.Name = "adminPassword_txt";
            this.adminPassword_txt.PasswordChar = '*';
            this.adminPassword_txt.Size = new System.Drawing.Size(166, 20);
            this.adminPassword_txt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Surname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password:";
            // 
            // addAdminButton
            // 
            this.addAdminButton.Location = new System.Drawing.Point(129, 202);
            this.addAdminButton.Name = "addAdminButton";
            this.addAdminButton.Size = new System.Drawing.Size(108, 23);
            this.addAdminButton.TabIndex = 9;
            this.addAdminButton.Text = "Save";
            this.addAdminButton.UseVisualStyleBackColor = true;
            this.addAdminButton.Click += new System.EventHandler(this.addAdminButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addAdminButton);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.adminPassword_txt);
            this.groupBox1.Controls.Add(this.adminUsername_txt);
            this.groupBox1.Controls.Add(this.adminName_txt);
            this.groupBox1.Controls.Add(this.adminSurname_txt);
            this.groupBox1.Location = new System.Drawing.Point(26, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 273);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Admin";
            // 
            // AddAdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 351);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddAdminPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox adminSurname_txt;
        private System.Windows.Forms.TextBox adminName_txt;
        private System.Windows.Forms.TextBox adminUsername_txt;
        private System.Windows.Forms.TextBox adminPassword_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addAdminButton;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}