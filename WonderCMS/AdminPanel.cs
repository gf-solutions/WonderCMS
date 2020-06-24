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
    public partial class AdminPanel : Form
    {
        string connString = @"Data Source=DESKTOP-LJULP6P\SQLEXPRESS;Initial Catalog=WonderHerbalDB;
                                Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;
                                ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public AdminPanel()
        {
            InitializeComponent();
        }

        private void updateList(string query)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand command = conn.CreateCommand();
            conn.Open();
            command.CommandText = "Select account_id, account_name, account_type From user_account Where account_type in (0,1) " +
                                      "AND (account_name LIKE @query OR account_phone LIKE @query) ORDER BY account_type ";

            command.Parameters.AddWithValue("@query", query + "%");

            SqlDataReader reader = command.ExecuteReader();

            lBoxFindAccount.Items.Clear();

            while (reader.Read())
                lBoxFindAccount.Items.Add(new account(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2)));

            conn.Close();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            updateList("");
        }

        public bool IsPresent(TextBox textBox, string name)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(name + " is a required field. ", "Entry Error");
                textBox.Focus();
                return false;
            }

            return true;
        }

        public bool IsValidData()
        {
            if (!IsPresent(txtUsername, "Username"))
                return false;
            if (!IsPresent(txtPassword, "Password"))
                return false;
            if (!IsPresent(txtName, "Name"))
                return false;

            if (cmbType.SelectedIndex < 0)
            {
                MessageBox.Show("You must select an acount type", "Entry Error");
                cmbType.Focus();
                return false;
            }

            if (dtpDOB.Value.Date > DateTime.Now)
            {
                MessageBox.Show("Check your date of birth", "Entry Error");
                dtpDOB.Focus();
                return false;
            }

            return true;
        }


        private void txtNameOrPhone_TextChanged(object sender, EventArgs e)
        {
            updateList(txtNameOrPhone.Text);
        }

        private void lBoxFindAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            //getting the stored account_id
            int account_id;

            try
            {

                account_id = ((account)lBoxFindAccount.SelectedItem).getID();

            }
            catch (Exception)
            {

                return;
            }

            //sql connection 
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "Select username, account_name, account_dob, account_type, account_notes, " +
                "account_creation_date, account_phone FROM [user], user_account WHERE [user].user_id = [user_account].account_user_id " +
                "AND account_id = @id ";
            command.Parameters.AddWithValue("@id", account_id);

            conn.Open();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                //reader.IsDBNull(genreIDIndex) ? null : reader.GetInt32(genreIDIndex)
                txtAccountId.Text = account_id.ToString();
                txtVAUsername.Text = reader.GetValue(0).ToString();
                txtVAName.Text = reader.GetValue(1).ToString();
                txtVADOB.Text = reader.GetValue(2).ToString();
                txtVAPhone.Text = reader.GetValue(6).ToString();

                if (reader.GetInt32(3) == 0)
                    txtVAType.Text = "Nurse";
                else
                    txtVAType.Text = "Doctor";

                rchVANotes.Text = reader.GetValue(4).ToString();
                txtVACreatedOn.Text = reader.GetValue(5).ToString();

            }

            conn.Close();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                try
                {
                    //sql connection 
                    SqlConnection conn = new SqlConnection(connString);
                    SqlCommand command = conn.CreateCommand();
                    command.CommandText = "INSERT INTO [user] (username, password) VALUES (@username, @password) ";
                    command.Parameters.AddWithValue("@username", txtUsername.Text);
                    command.Parameters.AddWithValue("@password", Utilis.hashPassword(txtPassword.Text));

                    conn.Open();

                    if (command.ExecuteNonQuery() > 0)
                    {
                        // we created the user record
                        command.CommandText = "SELECT user_id FROM [user] WHERE username = @username ";

                        int user_id = (int)command.ExecuteScalar();

                        command.CommandText = "INSERT INTO user_account (account_user_id, account_name, account_dob, " +
                            " account_phone,   account_type, account_notes, account_creation_date  )" +
                            "VALUES (@user_id, @name, @dob, @phone, @type, @notes, @date)";

                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@user_id", user_id);
                        command.Parameters.AddWithValue("@name", txtName.Text);
                        command.Parameters.AddWithValue("@dob", dtpDOB.Value.ToString());
                        command.Parameters.AddWithValue("@phone", txtPhone.Text);
                        command.Parameters.AddWithValue("@type", cmbType.SelectedIndex);
                        command.Parameters.AddWithValue("@notes", rchNotes.Text);
                        command.Parameters.AddWithValue("@date", DateTime.Now);

                        if (command.ExecuteNonQuery() > 0)
                        {
                            //All good, account created 
                            MessageBox.Show("Account was successfully created");

                            txtUsername.Clear();
                            txtPassword.Clear();
                            txtName.Clear();
                            txtPhone.Clear();
                            rchNotes.Clear();
                            cmbType.Items.Clear();

                        }
                        else
                            MessageBox.Show("Error while creating account");
                    }
                    else
                        MessageBox.Show("Error while creating account");

                    conn.Close();

                    updateList("");


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtVAUsername.Text == "")
                return;

            SqlConnection conn = new SqlConnection(connString);
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "DELETE FROM [user] WHERE username = @username";
            command.Parameters.AddWithValue("@username", txtVAUsername.Text);

            conn.Open();

            if (command.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Account Deleted Successfully");
            }
            else
            {
                MessageBox.Show("Account was not deleted");
            }

            conn.Close();

            updateList("");

            txtAccountId.Clear();
            txtVAUsername.Clear();
            txtVAName.Clear();
            txtVADOB.Clear();
            txtVAPhone.Clear();
            txtVAType.Clear();
            rchVANotes.Clear();
            txtVACreatedOn.Clear();

        }
    }
}
