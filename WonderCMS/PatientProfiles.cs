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
    public partial class PatientProfiles : Form
    {
        public PatientProfiles()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-LJULP6P\SQLEXPRESS;Initial Catalog=WonderHerbalDB;
                                Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;
                                ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand command;
        private void updateList (string query)
        {
            command = conn.CreateCommand();
            command.CommandText = "SELECT account_id, account_name, account_type FROM user_account WHERE account_type=2 AND (account_name LIKE @query OR account_phone LIKE @query OR account_opd_number LIKE @query)";
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

        private void txtNameOrPhone_TextChanged(object sender, EventArgs e)
        {
            updateList(txtNameOrPhone.Text);
        }

        private void PatientProfiles_Load(object sender, EventArgs e)
        {
            updateList("");
        }

        //private void validateInputs()
        //{
           

           
        //}

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            //input validation 
            if (txtName.Text == "" || txtPhone.Text == "" || txtOPD.Text=="" || cmbGender.SelectedItem == null)
            {
                MessageBox.Show("Please, check your input", "Entry Error");
                return;
            }
            if (dtpDOB.Value == null || dtpDOB.Value > DateTime.Now)
            {
                MessageBox.Show("Input correct date of birth", "Entry Error");
                return;
            }

            ///account creation 
            command = conn.CreateCommand();
            command.CommandText = "INSERT INTO user_account (account_name, account_opd_number, account_gender, account_dob, account_phone, account_notes, account_type, account_creation_date) " +
                "VALUES (@name, @account_opd_number, @account_gender, @dob, @phone, @notes, 2, @date)";

            command.Parameters.AddWithValue("@name", txtName.Text);
            command.Parameters.AddWithValue("@account_opd_number", txtOPD.Text);
            command.Parameters.AddWithValue("@account_gender", cmbGender.SelectedItem.ToString());
            command.Parameters.AddWithValue("@dob", dtpDOB.Value.ToString());
            command.Parameters.AddWithValue("@phone", txtPhone.Text);
            command.Parameters.AddWithValue("@notes", rchNotes.Text);
            command.Parameters.AddWithValue("@date", DateTime.Now);

            conn.Open();

            if (command.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Account was created! ");
            } else
                MessageBox.Show("Failed to create account!");

            conn.Close();

            updateList("");
        }

        private void lBoxFindAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lBoxFindAccount.SelectedIndex < 0 || lBoxFindAccount.SelectedIndex >= lBoxFindAccount.Items.Count)
            {
                return;
            }
            int account_id = ((account)lBoxFindAccount.SelectedItem).getID();

            command = conn.CreateCommand();
            command.CommandText = "SELECT account_name, account_opd_number, account_gender, account_dob, account_phone, account_notes, account_creation_date FROM user_account WHERE account_id=@id";
            command.Parameters.AddWithValue("@id", account_id);
            
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                txtAccountId.Text = account_id.ToString();
                txtEAName.Text = reader.GetString(0);
                txtEAOpd.Text = reader.GetString(1);
                txtEAGender.Text = reader.GetString(2);

                DateTime dob = new DateTime();
                if (DateTime.TryParse(reader.GetValue(3).ToString(), out dob))
                    dtpDOB.Value = dob;

                txtEAPhone.Text = reader.GetString(4);
                rchEANotes.Text = reader.GetString(5);
                txtEACreatedOn.Text = reader.GetValue(6).ToString();
            }

            conn.Close();

        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            //validation 
            if (txtEAName.Text == "" || txtEAPhone.Text == "")
            {
                MessageBox.Show("Please, check your input", "Entry Error");
                return;
            }

            //Editing account
            command = conn.CreateCommand();
            command.CommandText = "UPDATE user_account SET account_name=@name, account_phone=@phone, account_dob=@dob, account_notes=@notes WHERE account_id=@id";
            command.Parameters.AddWithValue("@name", txtEAName.Text);
            command.Parameters.AddWithValue("@dob", dtpEADOB.Value.ToString());
            command.Parameters.AddWithValue("@phone", txtEAPhone.Text);
            command.Parameters.AddWithValue("@notes", rchEANotes.Text);
            command.Parameters.AddWithValue("@id", txtAccountId.Text);

            conn.Open();

            if (command.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Account was updated! ");
            }
            else
                MessageBox.Show("Failed to create the account!");

            conn.Close();

        }
    }
}
