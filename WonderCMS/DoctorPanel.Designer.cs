namespace WonderCMS
{
    partial class DoctorPanel
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
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.btnViewReservations = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.Location = new System.Drawing.Point(32, 18);
            this.btnEditProfile.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(190, 39);
            this.btnEditProfile.TabIndex = 0;
            this.btnEditProfile.Text = "Edit Account";
            this.btnEditProfile.UseVisualStyleBackColor = true;
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);
            // 
            // btnViewReservations
            // 
            this.btnViewReservations.Location = new System.Drawing.Point(32, 80);
            this.btnViewReservations.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewReservations.Name = "btnViewReservations";
            this.btnViewReservations.Size = new System.Drawing.Size(190, 39);
            this.btnViewReservations.TabIndex = 4;
            this.btnViewReservations.Text = "View Reservations";
            this.btnViewReservations.UseVisualStyleBackColor = true;
            this.btnViewReservations.Click += new System.EventHandler(this.btnViewReservations_Click);
            // 
            // DoctorPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 147);
            this.Controls.Add(this.btnViewReservations);
            this.Controls.Add(this.btnEditProfile);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DoctorPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.Button btnViewReservations;
    }
}