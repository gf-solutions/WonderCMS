using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WonderCMS
{
    public partial class NursePanel : Form
    {
        int account_id;
        public NursePanel(int id)
        {
            InitializeComponent();
            account_id = id;
        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            Hide();
            EditProfile editProfile = new EditProfile(account_id);
            editProfile.ShowDialog();
            Show();
        }

        private void btnPatientProfiles_Click(object sender, EventArgs e)
        {
            Hide();
            PatientProfiles patientProfiles = new PatientProfiles();
            patientProfiles.ShowDialog();
            Show();
        }

        private void btnCreateReservation_Click(object sender, EventArgs e)
        {
            Hide();
            CreateReservation createReservation = new CreateReservation(account_id);
            createReservation.ShowDialog();
            Show();
        }

        private void btnViewReservations_Click(object sender, EventArgs e)
        {
            Hide();
            ViewReservations viewReservations = new ViewReservations(account_id);
            viewReservations.ShowDialog();
            Show();
        }
    }
}
