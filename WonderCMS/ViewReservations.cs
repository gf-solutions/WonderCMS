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
    public partial class ViewReservations : Form
    {
        int account_id, account_type; 
        public ViewReservations(int id)
        {
            InitializeComponent();
            account_id = id;
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-LJULP6P\SQLEXPRESS;Initial Catalog=WonderHerbalDB;
                                Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;
                                ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand command;

        private void updateList()
        {
            command = conn.CreateCommand();

            if (radioButton1.Checked)
                command.CommandText = "SELECT reservation_id, reservation_patient_id, patient.account_name, reservation_nurse_id, nurse.account_name, reservation_visit_date, reservation_visit_slot, reservation_date FROM reservation, user_account as patient, user_account as nurse WHERE reservation_patient_id = patient.account_id AND reservation_nurse_id = nurse.account_id AND reservation_visit_date = @date";
            else if (radioButton2.Checked)
                command.CommandText = "SELECT reservation_id, reservation_patient_id, patient.account_name, reservation_nurse_id, nurse.account_name, reservation_visit_date, reservation_visit_slot, reservation_date FROM reservation, user_account as patient, user_account as nurse WHERE reservation_patient_id = patient.account_id AND reservation_nurse_id = nurse.account_id AND (patient.account_name LIKE @query OR patient.account_phone LIKE @query OR reservation_id LIKE @query)";
            else
                command.CommandText = "SELECT reservation_id, reservation_patient_id, patient.account_name, reservation_nurse_id, nurse.account_name, reservation_visit_date, reservation_visit_slot, reservation_date FROM reservation, user_account as patient, user_account as nurse WHERE reservation_patient_id = patient.account_id AND reservation_nurse_id = nurse.account_id AND (patient.account_name LIKE @query OR patient.account_phone LIKE @query OR reservation_id LIKE @query) AND reservation_visit_date = @date";

            command.Parameters.AddWithValue("@date", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("@query",txtNamePhoneReservationID.Text + "%");

            conn.Open();

            SqlDataReader reader = command.ExecuteReader();
            listBox1.Items.Clear();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                int patient_id = reader.GetInt32(1);
                string patient_name = reader.GetString(2);
                int nurse_id = reader.GetInt32(3);
                string nurse_name = reader.GetString(4);

                DateTime visit_date = new DateTime();
                DateTime.TryParse(reader.GetValue(5).ToString(), out visit_date);

                int slot = reader.GetInt32(6);

                DateTime date = new DateTime();
                DateTime.TryParse(reader.GetValue(7).ToString(), out date);

                listBox1.Items.Add(new reservation(id, patient_id, patient_name, nurse_id, nurse_name, slot, visit_date, date));

            }

            conn.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            updateList();
        }

        private void ViewReservations_Load(object sender, EventArgs e)
        {
            updateList();

            command = conn.CreateCommand();
            command.CommandText = "SELECT account_type FROM user_account WHERE account_id = @id";
            command.Parameters.AddWithValue("@id", account_id);

            conn.Open();

            account_type = (int) command.ExecuteScalar();

            conn.Close();
        }

        private void txtNamePhoneReservationID_TextChanged(object sender, EventArgs e)
        {
            updateList();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            updateList();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            updateList();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            updateList();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0 || listBox1.SelectedIndex >= listBox1.Items.Count)
            {
                MessageBox.Show("Please, select a reservation");
                return;
            }

            reservation res = (reservation)listBox1.SelectedItem;
            txtReservationID.Text = res.id.ToString();
            txtPatient.Text = res.patient.ToString();
            txtNurse.Text = res.nurse.ToString();
            txtVisitDate.Text = res.visit_date.Date.ToString();
            txtVisitSlot.Text = Utilis.getSlots()[res.slot];
            txtDate.Text = res.date.ToString();

            if (account_type == 0 && res.visit_date >= DateTime.Today)
                btnEdit.Enabled = true;
            else
                btnEdit.Enabled = false;

        }
    }
}
