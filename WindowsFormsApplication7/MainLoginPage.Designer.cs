namespace WindowsFormsApplication7
{
    partial class MainLoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainLoginPage));
            this.voterRegNo_txt = new System.Windows.Forms.TextBox();
            this.voterPass_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.voterLoginButton = new System.Windows.Forms.Button();
            this.adminLoginLink = new System.Windows.Forms.Label();
            this.mainLoginPgFPImageBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainLoginPgFPImageBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // voterRegNo_txt
            // 
            this.voterRegNo_txt.Location = new System.Drawing.Point(237, 44);
            this.voterRegNo_txt.Name = "voterRegNo_txt";
            this.voterRegNo_txt.Size = new System.Drawing.Size(154, 20);
            this.voterRegNo_txt.TabIndex = 0;
            // 
            // voterPass_txt
            // 
            this.voterPass_txt.Location = new System.Drawing.Point(237, 83);
            this.voterPass_txt.Name = "voterPass_txt";
            this.voterPass_txt.PasswordChar = '*';
            this.voterPass_txt.Size = new System.Drawing.Size(154, 20);
            this.voterPass_txt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reg. No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // voterLoginButton
            // 
            this.voterLoginButton.Location = new System.Drawing.Point(237, 120);
            this.voterLoginButton.Name = "voterLoginButton";
            this.voterLoginButton.Size = new System.Drawing.Size(154, 30);
            this.voterLoginButton.TabIndex = 4;
            this.voterLoginButton.Text = "Login";
            this.voterLoginButton.UseVisualStyleBackColor = true;
            this.voterLoginButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // adminLoginLink
            // 
            this.adminLoginLink.AutoSize = true;
            this.adminLoginLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminLoginLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLoginLink.ForeColor = System.Drawing.SystemColors.Highlight;
            this.adminLoginLink.Location = new System.Drawing.Point(361, 228);
            this.adminLoginLink.Name = "adminLoginLink";
            this.adminLoginLink.Size = new System.Drawing.Size(87, 15);
            this.adminLoginLink.TabIndex = 5;
            this.adminLoginLink.Text = "Admin Login";
            this.adminLoginLink.Click += new System.EventHandler(this.adminLoginLink_Click);
            // 
            // mainLoginPgFPImageBox
            // 
            this.mainLoginPgFPImageBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainLoginPgFPImageBox.Location = new System.Drawing.Point(19, 19);
            this.mainLoginPgFPImageBox.Name = "mainLoginPgFPImageBox";
            this.mainLoginPgFPImageBox.Size = new System.Drawing.Size(140, 153);
            this.mainLoginPgFPImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainLoginPgFPImageBox.TabIndex = 6;
            this.mainLoginPgFPImageBox.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.voterLoginButton);
            this.groupBox1.Controls.Add(this.mainLoginPgFPImageBox);
            this.groupBox1.Controls.Add(this.voterRegNo_txt);
            this.groupBox1.Controls.Add(this.voterPass_txt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(35, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 187);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // MainLoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 252);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.adminLoginLink);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainLoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainLoginPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainLoginPage_FormClosing);
            this.Load += new System.EventHandler(this.MainLoginPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainLoginPgFPImageBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox voterRegNo_txt;
        private System.Windows.Forms.TextBox voterPass_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button voterLoginButton;
        private System.Windows.Forms.Label adminLoginLink;
        private System.Windows.Forms.PictureBox mainLoginPgFPImageBox;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}