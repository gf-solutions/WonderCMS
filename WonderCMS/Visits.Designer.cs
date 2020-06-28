namespace WonderCMS
{
    partial class Visits
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
            this.label1 = new System.Windows.Forms.Label();
            this.rchReasons = new System.Windows.Forms.RichTextBox();
            this.rchDiagnosis = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rchNotes = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddVisit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEditVisit = new System.Windows.Forms.Button();
            this.rchVDNotes = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rchVDDiagnosis = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rchVDReasons = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtVisitID = new System.Windows.Forms.TextBox();
            this.txtPatient = new System.Windows.Forms.TextBox();
            this.txtNurse = new System.Windows.Forms.TextBox();
            this.txtDoctor = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddVisit);
            this.groupBox1.Controls.Add(this.rchNotes);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rchDiagnosis);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rchReasons);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 595);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Visit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reasons:";
            // 
            // rchReasons
            // 
            this.rchReasons.Location = new System.Drawing.Point(106, 39);
            this.rchReasons.Name = "rchReasons";
            this.rchReasons.Size = new System.Drawing.Size(324, 171);
            this.rchReasons.TabIndex = 1;
            this.rchReasons.Text = "";
            // 
            // rchDiagnosis
            // 
            this.rchDiagnosis.Location = new System.Drawing.Point(106, 216);
            this.rchDiagnosis.Name = "rchDiagnosis";
            this.rchDiagnosis.Size = new System.Drawing.Size(324, 162);
            this.rchDiagnosis.TabIndex = 3;
            this.rchDiagnosis.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Diagnosis:";
            // 
            // rchNotes
            // 
            this.rchNotes.Location = new System.Drawing.Point(106, 384);
            this.rchNotes.Name = "rchNotes";
            this.rchNotes.Size = new System.Drawing.Size(324, 159);
            this.rchNotes.TabIndex = 5;
            this.rchNotes.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Notes:";
            // 
            // btnAddVisit
            // 
            this.btnAddVisit.Location = new System.Drawing.Point(305, 549);
            this.btnAddVisit.Name = "btnAddVisit";
            this.btnAddVisit.Size = new System.Drawing.Size(125, 36);
            this.btnAddVisit.TabIndex = 6;
            this.btnAddVisit.Text = "Add Visit";
            this.btnAddVisit.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(466, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(289, 595);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Previous Visits";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(6, 39);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(277, 532);
            this.listBox1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDate);
            this.groupBox3.Controls.Add(this.txtDoctor);
            this.groupBox3.Controls.Add(this.txtNurse);
            this.groupBox3.Controls.Add(this.txtPatient);
            this.groupBox3.Controls.Add(this.txtVisitID);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.btnEditVisit);
            this.groupBox3.Controls.Add(this.rchVDNotes);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.rchVDDiagnosis);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.rchVDReasons);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(761, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(448, 595);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Visit Details";
            // 
            // btnEditVisit
            // 
            this.btnEditVisit.Location = new System.Drawing.Point(305, 549);
            this.btnEditVisit.Name = "btnEditVisit";
            this.btnEditVisit.Size = new System.Drawing.Size(125, 36);
            this.btnEditVisit.TabIndex = 6;
            this.btnEditVisit.Text = "Add Visit";
            this.btnEditVisit.UseVisualStyleBackColor = true;
            // 
            // rchVDNotes
            // 
            this.rchVDNotes.Location = new System.Drawing.Point(106, 457);
            this.rchVDNotes.Name = "rchVDNotes";
            this.rchVDNotes.Size = new System.Drawing.Size(324, 86);
            this.rchVDNotes.TabIndex = 5;
            this.rchVDNotes.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 457);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Notes:";
            // 
            // rchVDDiagnosis
            // 
            this.rchVDDiagnosis.Location = new System.Drawing.Point(106, 343);
            this.rchVDDiagnosis.Name = "rchVDDiagnosis";
            this.rchVDDiagnosis.Size = new System.Drawing.Size(324, 108);
            this.rchVDDiagnosis.TabIndex = 3;
            this.rchVDDiagnosis.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Diagnosis:";
            // 
            // rchVDReasons
            // 
            this.rchVDReasons.Location = new System.Drawing.Point(106, 230);
            this.rchVDReasons.Name = "rchVDReasons";
            this.rchVDReasons.Size = new System.Drawing.Size(324, 107);
            this.rchVDReasons.TabIndex = 1;
            this.rchVDReasons.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Reasons:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "Visit ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 24);
            this.label8.TabIndex = 8;
            this.label8.Text = "Patient:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 24);
            this.label9.TabIndex = 9;
            this.label9.Text = "Nurse:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 24);
            this.label10.TabIndex = 10;
            this.label10.Text = "Doctor:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 196);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 24);
            this.label11.TabIndex = 11;
            this.label11.Text = "Date:";
            // 
            // txtVisitID
            // 
            this.txtVisitID.Enabled = false;
            this.txtVisitID.Location = new System.Drawing.Point(106, 39);
            this.txtVisitID.Name = "txtVisitID";
            this.txtVisitID.Size = new System.Drawing.Size(324, 28);
            this.txtVisitID.TabIndex = 12;
            // 
            // txtPatient
            // 
            this.txtPatient.Enabled = false;
            this.txtPatient.Location = new System.Drawing.Point(106, 78);
            this.txtPatient.Name = "txtPatient";
            this.txtPatient.Size = new System.Drawing.Size(324, 28);
            this.txtPatient.TabIndex = 13;
            // 
            // txtNurse
            // 
            this.txtNurse.Enabled = false;
            this.txtNurse.Location = new System.Drawing.Point(106, 117);
            this.txtNurse.Name = "txtNurse";
            this.txtNurse.Size = new System.Drawing.Size(324, 28);
            this.txtNurse.TabIndex = 14;
            // 
            // txtDoctor
            // 
            this.txtDoctor.Enabled = false;
            this.txtDoctor.Location = new System.Drawing.Point(106, 157);
            this.txtDoctor.Name = "txtDoctor";
            this.txtDoctor.Size = new System.Drawing.Size(324, 28);
            this.txtDoctor.TabIndex = 15;
            // 
            // txtDate
            // 
            this.txtDate.Enabled = false;
            this.txtDate.Location = new System.Drawing.Point(106, 196);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(324, 28);
            this.txtDate.TabIndex = 16;
            // 
            // Visits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 619);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Visits";
            this.Text = "Visits";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddVisit;
        private System.Windows.Forms.RichTextBox rchNotes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rchDiagnosis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rchReasons;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtDoctor;
        private System.Windows.Forms.TextBox txtNurse;
        private System.Windows.Forms.TextBox txtPatient;
        private System.Windows.Forms.TextBox txtVisitID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEditVisit;
        private System.Windows.Forms.RichTextBox rchVDNotes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rchVDDiagnosis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rchVDReasons;
        private System.Windows.Forms.Label label6;
    }
}