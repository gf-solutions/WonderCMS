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
    public partial class EditReservation : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-LJULP6P\SQLEXPRESS;Initial Catalog=WonderHerbalDB;
                                Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;
                                ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand command;

        public EditReservation(reservation res)
        {
            InitializeComponent();

          

            dateTimePicker1.Value = res.visit_date;

            txtReservationID.Text = res.id.ToString();
            txtPatient.Text = res.patient.ToString();
            txtNurse.Text = res.nurse.ToString();
            txtDate.Text = res.date.ToString();

            dateTimePicker1.MinDate = DateTime.Today;
            updateCombo(res.slot);


        }
        private void updateCombo(int visit_slot)
        {
            Dictionary<int, string> slots = Utilis.getSlots();

            command = conn.CreateCommand();
            command.CommandText = "SELECT reservation_visit_slot FROM reservation WHERE reservation_visit_date = @date AND reservation_id <> @id";
            command.Parameters.AddWithValue("@date", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("@id", txtReservationID.Text);
            conn.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                slots.Remove(reader.GetInt32(0)); ;
            }

            comboBox1.Items.Clear();

            foreach (KeyValuePair<int, string> slot in slots)
            {
                comboBox1.Items.Add(slot);
                if (slot.Key == visit_slot)
                    comboBox1.SelectedItem = slot;
            }

            conn.Close();


        }
        private void btnEditReservation_Click(object sender, EventArgs e)
        {
            command = conn.CreateCommand();
            command.CommandText = "UPDATE reservation SET reservation_visit_date = @visit_date, reservation_visit_slot = @visit_slot WHERE reservation_id = @id";
            command.Parameters.AddWithValue("@id", txtReservationID.Text);
            command.Parameters.AddWithValue("@visit_date", dateTimePicker1.Value.ToString("yyyy-MMM-dd"));
            command.Parameters.AddWithValue("@visit_slot", ((KeyValuePair<int, string>)comboBox1.SelectedItem).Key);

            conn.Open();

            if (command.ExecuteNonQuery() > 0)
                MessageBox.Show("Reservation was updated");
            else
                MessageBox.Show("Failed to update the reservation");

            conn.Close();
        }

        private void btnDeleteReservation_Click(object sender, EventArgs e)
        {
            command = conn.CreateCommand();
            command.CommandText = "DELETE FROM reservation WHERE reservation_id = @id";
            command.Parameters.AddWithValue("@id",txtReservationID.Text );

            conn.Open();

            if (command.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Reservation was Deleted!");
                //this.Close();
                //clearTxt();
                
            }
            else
                MessageBox.Show("Failed to delete reservation");

            conn.Close();
        }

        private void clearTxt()
        {
            txtReservationID.Clear();
            txtDate.Clear();
            txtNurse.Clear();
            txtPatient.Clear();
            comboBox1.SelectedItem = null;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            updateCombo(1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
