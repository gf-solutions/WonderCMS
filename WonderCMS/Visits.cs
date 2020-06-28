using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WonderCMS
{
    public partial class Visits : Form
    {
        int account_id, patient_id, reservation_id;

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-LJULP6P\SQLEXPRESS;Initial Catalog=WonderHerbalDB;
                                Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;
                                ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public Visits(int account_id, int patient_id, int reservation_id )
        {
            InitializeComponent();

            //initializing constructors 
            this.account_id = account_id;
            this.patient_id = patient_id;
            this.reservation_id = reservation_id;

            command = conn.CreateCommand();
            command.CommandText = "SELECT visit_id FROM visit WHERE visit_reservation_id = @reservation_id";
            command.Parameters.AddWithValue("@reservation_id", reservation_id);

            conn.Open();

            var result = command.ExecuteScalar();

            if (result == null)
                groupBox1.Enabled = true;
            else
                groupBox1.Enabled = false; 

            conn.Close();

            updateList(); 
        }

       

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0 || listBox1.SelectedIndex >= listBox1.Items.Count)
            {
                MessageBox.Show("Please select a visit!");
                return; 
            }

            //loading listbox selected item into textbox
            visit v = (visit)listBox1.SelectedItem;
            txtVisitID.Text = v.visit_id.ToString();
            txtPatient.Text = v.patient.ToString();
            txtNurse.Text = v.nurse.ToString();
            txtDoctor.Text = v.doctor.ToString();
            txtDate.Text = v.date.ToString();
            rchVDReasons.Text = v.reasons;
            rchVDDiagnosis.Text = v.diagnosis;
            rchVDNotes.Text = v.notes; 
        }

        private void btnAddVisit_Click(object sender, EventArgs e)
        {
            if(rchReasons.Text == "" || rchDiagnosis.Text == "")
            {
                MessageBox.Show("Please, enter reasons and diagnosis");
                return; 
            }

            command = conn.CreateCommand();
            conn.Open();

            command.CommandText = "INSERT INTO visit (visit_reservation_id, visit_reasons, visit_diagnosis, visit_notes, visit_doctor_id, visit_date) VALUES (@id, @reasons, @diagnosis, @notes, @doctor_id, @date)";
            command.Parameters.AddWithValue("@id", reservation_id);
            command.Parameters.AddWithValue("@reasons", rchReasons.Text);
            command.Parameters.AddWithValue("@diagnosis", rchDiagnosis.Text);
            command.Parameters.AddWithValue("@notes", rchNotes.Text);
            command.Parameters.AddWithValue("@doctor_id",account_id );
            command.Parameters.AddWithValue("@date", DateTime.Now);

            if (command.ExecuteNonQuery() > 0)
                MessageBox.Show("Visit was added!");
            else
                MessageBox.Show("Failed to add the visit!"); 

            conn.Close();

            updateList();

            groupBox1.Enabled = false; 
        }

        private void btnEditVisit_Click(object sender, EventArgs e)
        {
            if(rchVDReasons.Text == "" || rchVDDiagnosis.Text == "")
            {
                MessageBox.Show("Please, enter reasons and diagnosis");
            }

            command = conn.CreateCommand();
            command.CommandText = "UPDATE visit SET visit_reasons = @reasons, visit_diagnosis = @diagnosis, visit_notes =@notes WHERE visit_id = @id";
            command.Parameters.AddWithValue("@reasons", rchVDReasons.Text);
            command.Parameters.AddWithValue("@diagnosis", rchVDDiagnosis.Text);
            command.Parameters.AddWithValue("@notes", rchVDNotes.Text);
            command.Parameters.AddWithValue("@id", txtVisitID.Text);

            conn.Open();

            if (command.ExecuteNonQuery() > 0)
                MessageBox.Show("Visit was updated!");
            else
                MessageBox.Show("Failed to update the visit!");

            conn.Close();

            updateList();
        }

        SqlCommand command;


        private void updateList()
        {
            command = conn.CreateCommand();
            command.CommandText = "SELECT visit_id, patient.account_id, patient.account_name, nurse.account_id, nurse.account_name, doctor.account_id, doctor.account_name, visit_date, visit_reasons, visit_diagnosis, visit_notes FROM visit, reservation, user_account as patient, user_account as nurse, user_account as doctor WHERE visit_reservation_id = reservation_id AND reservation_patient_id = patient.account_id AND reservation_nurse_id = nurse.account_id AND visit_doctor_id = doctor.account_id AND patient.account_id = @patient_id";
            command.Parameters.AddWithValue("@patient_id", patient_id);

            conn.Open();

            SqlDataReader reader = command.ExecuteReader();
            listBox1.Items.Clear();

            while (reader.Read())
            {
                int visit_id = reader.GetInt32(0);
                int patient_id = reader.GetInt32(1);
                string patient_name = reader.GetString(2);
                int nurse_id = reader.GetInt32(3);
                string nurse_name = reader.GetString(4);
                int doctor_id = reader.GetInt32(5);
                string doctor_name = reader.GetString(6);
                DateTime date = new DateTime();
                DateTime.TryParse(reader.GetValue(7).ToString(), out date);
                string reasons = reader.GetString(8);
                string diagnosis = reader.GetString(9);
                string notes = reader.GetString(10);

                listBox1.Items.Add(new visit(visit_id, patient_id, patient_name, nurse_id, nurse_name, doctor_id, doctor_name, date, reasons, diagnosis, notes));

            }


            conn.Close();
        }
    }
}
