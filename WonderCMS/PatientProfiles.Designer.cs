namespace WonderCMS
{
    partial class PatientProfiles
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lBoxFindAccount = new System.Windows.Forms.ListBox();
            this.txtNameOrPhone = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.rchNotes = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEACreatedOn = new System.Windows.Forms.TextBox();
            this.btnEditAccount = new System.Windows.Forms.Button();
            this.rchEANotes = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEAPhone = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpEADOB = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEAName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtAccountId = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOPD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEAOpd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEAGender = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lBoxFindAccount);
            this.groupBox2.Controls.Add(this.txtNameOrPhone);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Location = new System.Drawing.Point(411, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(422, 462);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Find Account";
            // 
            // lBoxFindAccount
            // 
            this.lBoxFindAccount.FormattingEnabled = true;
            this.lBoxFindAccount.ItemHeight = 22;
            this.lBoxFindAccount.Location = new System.Drawing.Point(6, 78);
            this.lBoxFindAccount.Name = "lBoxFindAccount";
            this.lBoxFindAccount.Size = new System.Drawing.Size(405, 378);
            this.lBoxFindAccount.TabIndex = 2;
            this.lBoxFindAccount.SelectedIndexChanged += new System.EventHandler(this.lBoxFindAccount_SelectedIndexChanged);
            // 
            // txtNameOrPhone
            // 
            this.txtNameOrPhone.Location = new System.Drawing.Point(140, 44);
            this.txtNameOrPhone.Name = "txtNameOrPhone";
            this.txtNameOrPhone.Size = new System.Drawing.Size(271, 28);
            this.txtNameOrPhone.TabIndex = 1;
            this.txtNameOrPhone.TextChanged += new System.EventHandler(this.txtNameOrPhone_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(2, 44);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(137, 24);
            this.label14.TabIndex = 0;
            this.label14.Text = "Name / Phone:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtOPD);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbGender);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCreateAccount);
            this.groupBox1.Controls.Add(this.rchNotes);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtpDOB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 462);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Account";
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(115, 413);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(265, 41);
            this.btnCreateAccount.TabIndex = 14;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // rchNotes
            // 
            this.rchNotes.Location = new System.Drawing.Point(115, 215);
            this.rchNotes.Name = "rchNotes";
            this.rchNotes.Size = new System.Drawing.Size(265, 191);
            this.rchNotes.TabIndex = 13;
            this.rchNotes.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Notes:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(115, 181);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(265, 28);
            this.txtPhone.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Phone:";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(115, 147);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(265, 28);
            this.dtpDOB.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "DOB:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(115, 44);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(265, 28);
            this.txtName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtEAGender);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtEAOpd);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtEACreatedOn);
            this.groupBox3.Controls.Add(this.btnEditAccount);
            this.groupBox3.Controls.Add(this.rchEANotes);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtEAPhone);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.dtpEADOB);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtEAName);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtAccountId);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Location = new System.Drawing.Point(832, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(411, 462);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Edit Account";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 382);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 24);
            this.label8.TabIndex = 17;
            this.label8.Text = "Created On:";
            // 
            // txtEACreatedOn
            // 
            this.txtEACreatedOn.Enabled = false;
            this.txtEACreatedOn.Location = new System.Drawing.Point(132, 379);
            this.txtEACreatedOn.Name = "txtEACreatedOn";
            this.txtEACreatedOn.Size = new System.Drawing.Size(248, 28);
            this.txtEACreatedOn.TabIndex = 16;
            // 
            // btnEditAccount
            // 
            this.btnEditAccount.Location = new System.Drawing.Point(132, 413);
            this.btnEditAccount.Name = "btnEditAccount";
            this.btnEditAccount.Size = new System.Drawing.Size(248, 41);
            this.btnEditAccount.TabIndex = 14;
            this.btnEditAccount.Text = "Edit Account";
            this.btnEditAccount.UseVisualStyleBackColor = true;
            this.btnEditAccount.Click += new System.EventHandler(this.btnEditAccount_Click);
            // 
            // rchEANotes
            // 
            this.rchEANotes.Location = new System.Drawing.Point(115, 245);
            this.rchEANotes.Name = "rchEANotes";
            this.rchEANotes.Size = new System.Drawing.Size(265, 128);
            this.rchEANotes.TabIndex = 13;
            this.rchEANotes.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 247);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 24);
            this.label9.TabIndex = 12;
            this.label9.Text = "Notes:";
            // 
            // txtEAPhone
            // 
            this.txtEAPhone.Location = new System.Drawing.Point(115, 211);
            this.txtEAPhone.Name = "txtEAPhone";
            this.txtEAPhone.Size = new System.Drawing.Size(265, 28);
            this.txtEAPhone.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 211);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 24);
            this.label11.TabIndex = 8;
            this.label11.Text = "Phone:";
            // 
            // dtpEADOB
            // 
            this.dtpEADOB.Location = new System.Drawing.Point(115, 176);
            this.dtpEADOB.Name = "dtpEADOB";
            this.dtpEADOB.Size = new System.Drawing.Size(265, 28);
            this.dtpEADOB.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 176);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 24);
            this.label12.TabIndex = 6;
            this.label12.Text = "DOB:";
            // 
            // txtEAName
            // 
            this.txtEAName.Location = new System.Drawing.Point(115, 77);
            this.txtEAName.Name = "txtEAName";
            this.txtEAName.Size = new System.Drawing.Size(265, 28);
            this.txtEAName.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 24);
            this.label13.TabIndex = 4;
            this.label13.Text = "Name:";
            // 
            // txtAccountId
            // 
            this.txtAccountId.Enabled = false;
            this.txtAccountId.Location = new System.Drawing.Point(115, 45);
            this.txtAccountId.Name = "txtAccountId";
            this.txtAccountId.Size = new System.Drawing.Size(265, 28);
            this.txtAccountId.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 45);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(107, 24);
            this.label15.TabIndex = 2;
            this.label15.Text = "Account ID:";
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(115, 111);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(265, 30);
            this.cmbGender.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Gender:";
            // 
            // txtOPD
            // 
            this.txtOPD.Location = new System.Drawing.Point(115, 78);
            this.txtOPD.Name = "txtOPD";
            this.txtOPD.Size = new System.Drawing.Size(265, 28);
            this.txtOPD.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "OPD No.:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 24);
            this.label6.TabIndex = 18;
            this.label6.Text = "OPD No.:";
            // 
            // txtEAOpd
            // 
            this.txtEAOpd.Enabled = false;
            this.txtEAOpd.Location = new System.Drawing.Point(115, 108);
            this.txtEAOpd.Name = "txtEAOpd";
            this.txtEAOpd.Size = new System.Drawing.Size(265, 28);
            this.txtEAOpd.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 24);
            this.label10.TabIndex = 20;
            this.label10.Text = "Gender:";
            // 
            // txtEAGender
            // 
            this.txtEAGender.Enabled = false;
            this.txtEAGender.Location = new System.Drawing.Point(115, 143);
            this.txtEAGender.Name = "txtEAGender";
            this.txtEAGender.Size = new System.Drawing.Size(265, 28);
            this.txtEAGender.TabIndex = 21;
            // 
            // PatientProfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 484);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PatientProfiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PatientProfiles";
            this.Load += new System.EventHandler(this.PatientProfiles_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lBoxFindAccount;
        private System.Windows.Forms.TextBox txtNameOrPhone;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.RichTextBox rchNotes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEACreatedOn;
        private System.Windows.Forms.Button btnEditAccount;
        private System.Windows.Forms.RichTextBox rchEANotes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEAPhone;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpEADOB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtEAName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtAccountId;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtOPD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEAGender;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEAOpd;
        private System.Windows.Forms.Label label6;
    }
}