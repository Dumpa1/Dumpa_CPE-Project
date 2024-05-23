using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dumpa_CPE_Project
{
    public partial class createAccountForm : Form
    {
        private OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.16.0;Data Source=C:\Users\zachari abriell\OneDrive\Documents\2nd year shool sheyt\Second Semester\CPE262-H1\Dumpa_CPE Project\Dumpa_CPE Project\Account.accdb");

        public createAccountForm()
        {
            InitializeComponent();
        }

        private void createAccountForm_Load(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignInForm signInForm = new SignInForm();
            signInForm.Show();
            this.Hide();

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            string userType = "";

            if (radiobtnAdmin.Checked)
            {
                userType = "Admin";
            }
            else if (radiobtnCustomer.Checked)
            {
                userType = "Customer";
            }

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }
            try
            {
                connection.Open();

                string insertQuery = "INSERT INTO [User] (Username, [Password], UserType) VALUES (?, ?, ?)";

                OleDbCommand insertCommand = new OleDbCommand(insertQuery, connection);
                insertCommand.Parameters.AddWithValue("?", username);
                insertCommand.Parameters.AddWithValue("?", password);
                insertCommand.Parameters.AddWithValue("?", userType);

                int rowsAffected = insertCommand.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Registration successful!");
                    SignInForm signInForm = new SignInForm();
                    signInForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Registration failed.");
                }


            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = checkBox1.Checked ? '\0' : '*';
            txtConfirmPassword.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
