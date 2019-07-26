namespace WindowsFormsApplication7
{
    partial class AddCandidate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCandidate));
            this.canSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.canName = new System.Windows.Forms.TextBox();
            this.canMiddleName = new System.Windows.Forms.TextBox();
            this.canRegNo = new System.Windows.Forms.TextBox();
            this.canPhoneNo = new System.Windows.Forms.TextBox();
            this.canSex = new System.Windows.Forms.ComboBox();
            this.canPosition = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.canAddPix = new System.Windows.Forms.Button();
            this.registerCandidate = new System.Windows.Forms.Button();
            this.canPixBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.canPixBox)).BeginInit();
            this.SuspendLayout();
            // 
            // canSurname
            // 
            this.canSurname.Location = new System.Drawing.Point(115, 34);
            this.canSurname.Name = "canSurname";
            this.canSurname.Size = new System.Drawing.Size(178, 20);
            this.canSurname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Surname:";
            // 
            // canName
            // 
            this.canName.Location = new System.Drawing.Point(115, 74);
            this.canName.Name = "canName";
            this.canName.Size = new System.Drawing.Size(178, 20);
            this.canName.TabIndex = 2;
            // 
            // canMiddleName
            // 
            this.canMiddleName.Location = new System.Drawing.Point(115, 113);
            this.canMiddleName.Name = "canMiddleName";
            this.canMiddleName.Size = new System.Drawing.Size(178, 20);
            this.canMiddleName.TabIndex = 3;
            // 
            // canRegNo
            // 
            this.canRegNo.Location = new System.Drawing.Point(115, 152);
            this.canRegNo.Name = "canRegNo";
            this.canRegNo.Size = new System.Drawing.Size(178, 20);
            this.canRegNo.TabIndex = 4;
            // 
            // canPhoneNo
            // 
            this.canPhoneNo.Location = new System.Drawing.Point(115, 233);
            this.canPhoneNo.Name = "canPhoneNo";
            this.canPhoneNo.Size = new System.Drawing.Size(178, 20);
            this.canPhoneNo.TabIndex = 6;
            // 
            // canSex
            // 
            this.canSex.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.canSex.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.canSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.canSex.FormattingEnabled = true;
            this.canSex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.canSex.Location = new System.Drawing.Point(115, 191);
            this.canSex.Name = "canSex";
            this.canSex.Size = new System.Drawing.Size(178, 21);
            this.canSex.TabIndex = 5;
            // 
            // canPosition
            // 
            this.canPosition.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.canPosition.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.canPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.canPosition.FormattingEnabled = true;
            this.canPosition.Location = new System.Drawing.Point(115, 278);
            this.canPosition.Name = "canPosition";
            this.canPosition.Size = new System.Drawing.Size(178, 21);
            this.canPosition.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Middle Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Reg No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(75, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Sex:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Phone No:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(50, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Position:";
            // 
            // canAddPix
            // 
            this.canAddPix.Location = new System.Drawing.Point(310, 230);
            this.canAddPix.Name = "canAddPix";
            this.canAddPix.Size = new System.Drawing.Size(84, 23);
            this.canAddPix.TabIndex = 28;
            this.canAddPix.Text = "Add Picture";
            this.canAddPix.UseVisualStyleBackColor = true;
            this.canAddPix.Click += new System.EventHandler(this.canAddPix_Click);
            // 
            // registerCandidate
            // 
            this.registerCandidate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.registerCandidate.Location = new System.Drawing.Point(151, 334);
            this.registerCandidate.Name = "registerCandidate";
            this.registerCandidate.Size = new System.Drawing.Size(118, 33);
            this.registerCandidate.TabIndex = 29;
            this.registerCandidate.Text = "Register";
            this.registerCandidate.UseVisualStyleBackColor = true;
            this.registerCandidate.Click += new System.EventHandler(this.registerCandidate_Click);
            // 
            // canPixBox
            // 
            this.canPixBox.Image = global::WindowsFormsApplication7.Properties.Resources._1467445406_profile_filled;
            this.canPixBox.Location = new System.Drawing.Point(310, 34);
            this.canPixBox.Name = "canPixBox";
            this.canPixBox.Size = new System.Drawing.Size(120, 160);
            this.canPixBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.canPixBox.TabIndex = 0;
            this.canPixBox.TabStop = false;
            // 
            // AddCandidate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 394);
            this.Controls.Add(this.registerCandidate);
            this.Controls.Add(this.canAddPix);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.canPosition);
            this.Controls.Add(this.canSex);
            this.Controls.Add(this.canPhoneNo);
            this.Controls.Add(this.canRegNo);
            this.Controls.Add(this.canMiddleName);
            this.Controls.Add(this.canName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.canSurname);
            this.Controls.Add(this.canPixBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddCandidate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCandidate";
            ((System.ComponentModel.ISupportInitialize)(this.canPixBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox canPixBox;
        private System.Windows.Forms.TextBox canSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox canName;
        private System.Windows.Forms.TextBox canMiddleName;
        private System.Windows.Forms.TextBox canRegNo;
        private System.Windows.Forms.TextBox canPhoneNo;
        private System.Windows.Forms.ComboBox canSex;
        private System.Windows.Forms.ComboBox canPosition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button canAddPix;
        private System.Windows.Forms.Button registerCandidate;
    }
}