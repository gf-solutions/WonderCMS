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
    public partial class Login : Form
    {
        string connString = @"Data Source=DESKTOP-LJULP6P\SQLEXPRESS;Initial Catalog=WonderHerbalDB;
                                Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;
                                ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        //SqlDataAdapter dataAdapter;

        //DataTable table;
        private SqlConnection conn;

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           
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


            return true;
        }

        //private void btnClear_Click(object sender, EventArgs e)
        //{
        //    Clear();
        //}

        private void Clear()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

       
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (IsValidData())
            {


                using (conn = new SqlConnection(connString))
                {
                    try
                    {
                        ////dataAdapter = new SqlDataAdapter(@"SELECT account_role, account_id FROM [user_account] JOIN [user]
                        ////                                    ON [user_account].user_id = [user].user_id
                        ////                                 WHERE username='" + txtUsername.Text + "' and password='" + txtPassword.Text
                        ////                                    + "' ", conn);

                        SqlCommand command = conn.CreateCommand();
                        //command.CommandText = @"SELECT account_type, account_id FROM [user_account] JOIN [user]
                        //                                    ON [user_account].account_user_id = [user].user_id
                        //                                 WHERE username=@username and password=@password";

                        command.CommandText = @"SELECT user_id FROM [user] WHERE username=@username and password=@password";

                        command.Parameters.AddWithValue("@username", txtUsername.Text);
                        command.Parameters.AddWithValue("@password", Utilis.hashPassword(txtPassword.Text));
                        //command.Parameters.AddWithValue("@password", txtPassword.Text);

                        //table = new System.Data.DataTable();
                        //dataAdapter.Fill(table);

                        conn.Open();
                        var result = command.ExecuteScalar();
                        conn.Close();



                        if (result != null)
                        {


                            //Authenticate

                            if (txtUsername.Text == "admin")
                            {
                                //Admin Panel 
                                Hide();
                                AdminPanel adminPanel = new AdminPanel();
                                adminPanel.ShowDialog();
                                Show();

                            }
                            else
                            {
                                conn.Open();
                                command.CommandText = "Select account_id, account_type From user_account Where account_user_id = @user_id ";
                                command.Parameters.AddWithValue("@user_id", result.ToString());
                                SqlDataReader reader = command.ExecuteReader();


                                if (reader.Read())
                                {
                                    int account_id = reader.GetInt32(0);
                                    int account_type = reader.GetInt32(1);


                                    conn.Close();

                                    if (account_type == 0)
                                    {
                                        //Nurse Panel 
                                        Hide();
                                        NursePanel nursePanel = new NursePanel(account_id);
                                        nursePanel.ShowDialog();
                                        Show();
                                        Clear();
                                    }
                                    else if (account_type == 1)
                                    {
                                        //Doctor Panel
                                        Hide();

                                        DoctorPanel doctorPanel = new DoctorPanel(account_id);
                                        doctorPanel.ShowDialog();
                                        Show();
                                        Clear();
                                    }
                                }


                            }
                        }
                        else
                        {
                            //Authentication failure 
                            MessageBox.Show("Invalid Username and Password");
                            Clear();
                            txtUsername.Focus();
                        }


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
