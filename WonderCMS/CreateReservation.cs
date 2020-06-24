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
    public partial class CreateReservation : Form
    {
        int nurse_id;
        public CreateReservation(int id)
        {
            InitializeComponent();
            nurse_id = id;
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-LJULP6P\SQLEXPRESS;Initial Catalog=WonderHerbalDB;
                                Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;
                                ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand command;

        private void updateList(string query)
        {
            command = conn.CreateCommand();
            command.CommandText = "SELECT account_id, account_name, account_type FROM user_account WHERE account_type=2 AND (account_name LIKE @query OR account_phone LIKE @query)";
            command.Parameters.AddWithValue("@query", query + "%");
            conn.Open();

            SqlDataReader reader = command.ExecuteReader();
            lBoxFindAccount.Items.Clear();

            while (reader.Read())
            {
                lBoxFindAccount.Items.Add(new account(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2)));

            }

            conn.Close();
        }

        private void CreateReservation_Load(object sender, EventArgs e)
        {
            updateList("");
            updateSlots();

            //setting date range thus from today upwards
            dateTimePicker1.MinDate = DateTime.Today;
        }

        private void txtNameOrPhone_TextChanged(object sender, EventArgs e)
        {
            updateList(txtNameOrPhone.Text);
        }

        private void updateSlots()
        {
            command = conn.CreateCommand();
            command.CommandText = "SELECT reservation_visit_slot FROM reservation WHERE reservation_visit_date=@date ";
            command.Parameters.AddWithValue("@date", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            
            conn.Open();

            SqlDataReader reader = command.ExecuteReader();
            Dictionary<int, string> slots = Utilis.getSlots();

            while (reader.Read())
            {
                slots.Remove(reader.GetInt32(0));

            }

            comboBox1.Items.Clear();
            foreach (object slot in slots.ToArray())
                comboBox1.Items.Add(slot);

            if (comboBox1.Items.Count > 0)
                comboBox1.SelectedIndex = 0;

            conn.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            updateSlots();
        }

        private void btnReserveSlot_Click(object sender, EventArgs e)
        {
            //inputs validation 
            if (lBoxFindAccount.SelectedIndex < 0 || lBoxFindAccount.SelectedIndex >= lBoxFindAccount.Items.Count)
            {
                MessageBox.Show("Please, select a patient");
                return;
            }
            if (comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Please, select a slot");
                return;
            }

            //perform the reservation 
            int patient_id = ((account)lBoxFindAccount.SelectedItem).getID();
            int slot = ((KeyValuePair<int, string>)comboBox1.SelectedItem).Key;

            command = conn.CreateCommand();
            command.CommandText = "INSERT INTO reservation (reservation_nurse_id, reservation_patient_id, reservation_visit_date, reservation_visit_slot, reservation_date) VALUES (@nurse_id, @patient_id, @visit_date, @visit_slot, @date)  ";

            command.Parameters.AddWithValue("@nurse_id", nurse_id);
            command.Parameters.AddWithValue("@patient_id", patient_id);
            command.Parameters.AddWithValue("@visit_date", dateTimePicker1.Value.ToString());
            command.Parameters.AddWithValue("@visit_slot", slot);
            command.Parameters.AddWithValue("@date", DateTime.Now);

            conn.Open();

            if (command.ExecuteNonQuery() > 0)
            {
                //We successfully performed the reservation 
                command.CommandText = "SELECT reservation_id FROM reservation WHERE reservation_visit_date=@visit_date AND reservation_visit_slot=@visit_slot ";
                int reservation_id = (int)command.ExecuteScalar();

                MessageBox.Show("Reservation was made!");
                MessageBox.Show("Reservation ID: " + reservation_id.ToString());
            }
            else
                MessageBox.Show("Failed to perform reservation");

            conn.Close();

            updateSlots();
        }
    }
}
