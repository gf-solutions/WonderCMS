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
    public partial class EditProfile : Form
    {
        int account_id;

        string connString = @"Data Source=DESKTOP-LJULP6P\SQLEXPRESS;Initial Catalog=WonderHerbalDB;
                                Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;
                                ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public EditProfile(int account_id)
        {
            InitializeComponent();
            this.account_id = account_id;
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if(txtName.Text == "")
            {
                MessageBox.Show("Please, enter a name!");
                return;
            }
            if(dtpDOB.Value > DateTime.Now)
            {
                MessageBox.Show("Please, enter a valid date of birth");
                return;
            }

            SqlConnection conn = new SqlConnection(connString);
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "UPDATE user_account SET account_name=@name, account_dob=@dob, account_phone=@phone, account_notes=@notes WHERE account_id=@account_id ";

            command.Parameters.AddWithValue("@name", txtName.Text);
            command.Parameters.AddWithValue("@dob", dtpDOB.Value.ToString());
            command.Parameters.AddWithValue("@phone", txtPhone.Text);
            command.Parameters.AddWithValue("@notes", rchNotes.Text);
            command.Parameters.AddWithValue("account_id", account_id);

            conn.Open();

            if (command.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Account was updated!");
            }
            else
            {
                MessageBox.Show("Account was not updated!");
            }

            conn.Close();
        }

       

        private void EditProfile_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT username, account_name, account_dob, account_phone, account_type, account_notes, account_creation_date FROM [user], user_account WHERE account_user_id = user_id AND account_id = @account_id ";
            command.Parameters.AddWithValue("@account_id", account_id);

            conn.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                txtAccountId.Text = account_id.ToString();
                txtUsername.Text = reader.GetValue(0).ToString();
                txtName.Text = reader.GetValue(1).ToString();

                try
                {
                    dtpDOB.Value = DateTime.Parse(reader.GetValue(2).ToString());
                }
                catch (Exception)
                {

                }
                txtPhone.Text = reader.GetValue(3).ToString();

                if (reader.GetInt32(4) == 0)
                    txtType.Text = "Nurse";
                else if (reader.GetInt32(4) == 1)
                    txtType.Text = "Doctor";
                else if (reader.GetInt32(4) == 2)
                    txtType.Text = "Patient";

                    rchNotes.Text = reader.GetValue(5).ToString();
                txtCreatedOn.Text = reader.GetValue(6).ToString();
            }



            conn.Close();
        }
    }
}
