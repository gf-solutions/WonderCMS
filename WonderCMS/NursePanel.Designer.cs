namespace WonderCMS
{
    partial class NursePanel
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
            this.btnEditAccount = new System.Windows.Forms.Button();
            this.btnPatientProfiles = new System.Windows.Forms.Button();
            this.btnCreateReservation = new System.Windows.Forms.Button();
            this.btnViewReservations = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEditAccount
            // 
            this.btnEditAccount.Location = new System.Drawing.Point(50, 35);
            this.btnEditAccount.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditAccount.Name = "btnEditAccount";
            this.btnEditAccount.Size = new System.Drawing.Size(190, 39);
            this.btnEditAccount.TabIndex = 0;
            this.btnEditAccount.Text = "Edit Account";
            this.btnEditAccount.UseVisualStyleBackColor = true;
            this.btnEditAccount.Click += new System.EventHandler(this.btnEditAccount_Click);
            // 
            // btnPatientProfiles
            // 
            this.btnPatientProfiles.Location = new System.Drawing.Point(50, 99);
            this.btnPatientProfiles.Margin = new System.Windows.Forms.Padding(4);
            this.btnPatientProfiles.Name = "btnPatientProfiles";
            this.btnPatientProfiles.Size = new System.Drawing.Size(190, 39);
            this.btnPatientProfiles.TabIndex = 1;
            this.btnPatientProfiles.Text = "Patient Profiles";
            this.btnPatientProfiles.UseVisualStyleBackColor = true;
            this.btnPatientProfiles.Click += new System.EventHandler(this.btnPatientProfiles_Click);
            // 
            // btnCreateReservation
            // 
            this.btnCreateReservation.Location = new System.Drawing.Point(50, 162);
            this.btnCreateReservation.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateReservation.Name = "btnCreateReservation";
            this.btnCreateReservation.Size = new System.Drawing.Size(190, 39);
            this.btnCreateReservation.TabIndex = 2;
            this.btnCreateReservation.Text = "Create Reservation";
            this.btnCreateReservation.UseVisualStyleBackColor = true;
            this.btnCreateReservation.Click += new System.EventHandler(this.btnCreateReservation_Click);
            // 
            // btnViewReservations
            // 
            this.btnViewReservations.Location = new System.Drawing.Point(50, 223);
            this.btnViewReservations.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewReservations.Name = "btnViewReservations";
            this.btnViewReservations.Size = new System.Drawing.Size(190, 39);
            this.btnViewReservations.TabIndex = 3;
            this.btnViewReservations.Text = "View Reservations";
            this.btnViewReservations.UseVisualStyleBackColor = true;
            this.btnViewReservations.Click += new System.EventHandler(this.btnViewReservations_Click);
            // 
            // NursePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 619);
            this.Controls.Add(this.btnViewReservations);
            this.Controls.Add(this.btnCreateReservation);
            this.Controls.Add(this.btnPatientProfiles);
            this.Controls.Add(this.btnEditAccount);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NursePanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NursePanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEditAccount;
        private System.Windows.Forms.Button btnPatientProfiles;
        private System.Windows.Forms.Button btnCreateReservation;
        private System.Windows.Forms.Button btnViewReservations;
    }
}