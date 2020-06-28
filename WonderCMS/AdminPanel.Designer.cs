namespace WonderCMS
{
    partial class AdminPanel
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.rchNotes = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lBoxFindAccount = new System.Windows.Forms.ListBox();
            this.txtNameOrPhone = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtVACreatedOn = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rchVANotes = new System.Windows.Forms.RichTextBox();
            this.txtVAType = new System.Windows.Forms.TextBox();
            this.txtVAPhone = new System.Windows.Forms.TextBox();
            this.txtVADOB = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtVAName = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtVAUsername = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtAccountId = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtVAGender = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbGender);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnCreateAccount);
            this.groupBox1.Controls.Add(this.rchNotes);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbType);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtpDOB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 584);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Account";
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(115, 518);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(265, 41);
            this.btnCreateAccount.TabIndex = 14;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // rchNotes
            // 
            this.rchNotes.Location = new System.Drawing.Point(115, 345);
            this.rchNotes.Name = "rchNotes";
            this.rchNotes.Size = new System.Drawing.Size(265, 154);
            this.rchNotes.TabIndex = 13;
            this.rchNotes.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Notes:";
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Nurse",
            "Doctor"});
            this.cmbType.Location = new System.Drawing.Point(115, 306);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(265, 30);
            this.cmbType.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Type:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(115, 272);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(265, 28);
            this.txtPhone.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Phone:";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(115, 238);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(265, 28);
            this.dtpDOB.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "DOB:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(115, 166);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(265, 28);
            this.txtName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(115, 91);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(265, 28);
            this.txtPassword.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(115, 57);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(265, 28);
            this.txtUsername.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lBoxFindAccount);
            this.groupBox2.Controls.Add(this.txtNameOrPhone);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Location = new System.Drawing.Point(405, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(422, 584);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Find Account";
            // 
            // lBoxFindAccount
            // 
            this.lBoxFindAccount.FormattingEnabled = true;
            this.lBoxFindAccount.ItemHeight = 22;
            this.lBoxFindAccount.Location = new System.Drawing.Point(11, 91);
            this.lBoxFindAccount.Name = "lBoxFindAccount";
            this.lBoxFindAccount.Size = new System.Drawing.Size(405, 466);
            this.lBoxFindAccount.TabIndex = 2;
            this.lBoxFindAccount.SelectedIndexChanged += new System.EventHandler(this.lBoxFindAccount_SelectedIndexChanged);
            // 
            // txtNameOrPhone
            // 
            this.txtNameOrPhone.Location = new System.Drawing.Point(145, 57);
            this.txtNameOrPhone.Name = "txtNameOrPhone";
            this.txtNameOrPhone.Size = new System.Drawing.Size(271, 28);
            this.txtNameOrPhone.TabIndex = 1;
            this.txtNameOrPhone.TextChanged += new System.EventHandler(this.txtNameOrPhone_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 57);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(137, 24);
            this.label14.TabIndex = 0;
            this.label14.Text = "Name / Phone:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtVAGender);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtVACreatedOn);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.rchVANotes);
            this.groupBox3.Controls.Add(this.txtVAType);
            this.groupBox3.Controls.Add(this.txtVAPhone);
            this.groupBox3.Controls.Add(this.txtVADOB);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.txtVAName);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.txtVAUsername);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.txtAccountId);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Location = new System.Drawing.Point(833, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(364, 584);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "View Account";
            // 
            // txtVACreatedOn
            // 
            this.txtVACreatedOn.Enabled = false;
            this.txtVACreatedOn.Location = new System.Drawing.Point(126, 467);
            this.txtVACreatedOn.Name = "txtVACreatedOn";
            this.txtVACreatedOn.Size = new System.Drawing.Size(232, 28);
            this.txtVACreatedOn.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 465);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 24);
            this.label8.TabIndex = 19;
            this.label8.Text = "Created On:";
            // 
            // rchVANotes
            // 
            this.rchVANotes.Enabled = false;
            this.rchVANotes.Location = new System.Drawing.Point(126, 316);
            this.rchVANotes.Name = "rchVANotes";
            this.rchVANotes.Size = new System.Drawing.Size(232, 145);
            this.rchVANotes.TabIndex = 18;
            this.rchVANotes.Text = "";
            // 
            // txtVAType
            // 
            this.txtVAType.Enabled = false;
            this.txtVAType.Location = new System.Drawing.Point(126, 276);
            this.txtVAType.Name = "txtVAType";
            this.txtVAType.Size = new System.Drawing.Size(232, 28);
            this.txtVAType.TabIndex = 17;
            // 
            // txtVAPhone
            // 
            this.txtVAPhone.Enabled = false;
            this.txtVAPhone.Location = new System.Drawing.Point(126, 240);
            this.txtVAPhone.Name = "txtVAPhone";
            this.txtVAPhone.Size = new System.Drawing.Size(232, 28);
            this.txtVAPhone.TabIndex = 16;
            // 
            // txtVADOB
            // 
            this.txtVADOB.Enabled = false;
            this.txtVADOB.Location = new System.Drawing.Point(126, 206);
            this.txtVADOB.Name = "txtVADOB";
            this.txtVADOB.Size = new System.Drawing.Size(232, 28);
            this.txtVADOB.TabIndex = 15;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(126, 519);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(232, 41);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete Account";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(14, 319);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 24);
            this.label15.TabIndex = 12;
            this.label15.Text = "Notes:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 274);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 24);
            this.label16.TabIndex = 10;
            this.label16.Text = "Type:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 240);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 24);
            this.label17.TabIndex = 8;
            this.label17.Text = "Phone:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(7, 206);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 24);
            this.label18.TabIndex = 6;
            this.label18.Text = "DOB:";
            // 
            // txtVAName
            // 
            this.txtVAName.Enabled = false;
            this.txtVAName.Location = new System.Drawing.Point(126, 132);
            this.txtVAName.Name = "txtVAName";
            this.txtVAName.Size = new System.Drawing.Size(232, 28);
            this.txtVAName.TabIndex = 5;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(7, 132);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(66, 24);
            this.label19.TabIndex = 4;
            this.label19.Text = "Name:";
            // 
            // txtVAUsername
            // 
            this.txtVAUsername.Enabled = false;
            this.txtVAUsername.Location = new System.Drawing.Point(126, 91);
            this.txtVAUsername.Name = "txtVAUsername";
            this.txtVAUsername.Size = new System.Drawing.Size(232, 28);
            this.txtVAUsername.TabIndex = 3;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(7, 91);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(102, 24);
            this.label20.TabIndex = 2;
            this.label20.Text = "Username:";
            // 
            // txtAccountId
            // 
            this.txtAccountId.Enabled = false;
            this.txtAccountId.Location = new System.Drawing.Point(126, 57);
            this.txtAccountId.Name = "txtAccountId";
            this.txtAccountId.Size = new System.Drawing.Size(232, 28);
            this.txtAccountId.TabIndex = 1;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(7, 57);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(107, 24);
            this.label21.TabIndex = 0;
            this.label21.Text = "Account ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 24);
            this.label9.TabIndex = 15;
            this.label9.Text = "Gender:";
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(115, 204);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(265, 30);
            this.cmbGender.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 24);
            this.label10.TabIndex = 21;
            this.label10.Text = "Gender:";
            // 
            // txtVAGender
            // 
            this.txtVAGender.Enabled = false;
            this.txtVAGender.Location = new System.Drawing.Point(126, 170);
            this.txtVAGender.Name = "txtVAGender";
            this.txtVAGender.Size = new System.Drawing.Size(232, 28);
            this.txtVAGender.TabIndex = 22;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 619);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNameOrPhone;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.RichTextBox rchNotes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lBoxFindAccount;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtVAName;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtVAUsername;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtAccountId;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.RichTextBox rchVANotes;
        private System.Windows.Forms.TextBox txtVAType;
        private System.Windows.Forms.TextBox txtVAPhone;
        private System.Windows.Forms.TextBox txtVADOB;
        private System.Windows.Forms.TextBox txtVACreatedOn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtVAGender;
        private System.Windows.Forms.Label label10;
    }
}