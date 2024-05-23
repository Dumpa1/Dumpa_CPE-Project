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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dumpa_CPE_Project
{
    public partial class SignInForm : Form
    {

        public SignInForm()
        {
            InitializeComponent();
        }

        private void SignInForm_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            createAccountForm createAccountForm = new createAccountForm();
            createAccountForm.Show();
            this.Hide();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Perform validation to ensure username and password are not empty
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            try
            {
                using (OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.16.0;Data Source=C:\Users\zachari abriell\OneDrive\Documents\2nd year shool sheyt\Second Semester\CPE262-H1\Dumpa_CPE Project\Dumpa_CPE Project\Account.accdb"))
                {
                    connection.Open();
                    string query = "SELECT UserType FROM [User] WHERE Username = ? AND [Password] = ?";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);

                        object userTypeObj = command.ExecuteScalar();

                        if (userTypeObj != null)
                        {
                            string userType = userTypeObj.ToString();
                            MessageBox.Show("Login successful!");

                            if (userType == "Admin")
                            {
                                Admin_Homepage admin_Homepage = new Admin_Homepage();
                                admin_Homepage.Show();
                            }
                            else if (userType == "Customer")
                            {
                                Users_Homepage users_Homepage = new Users_Homepage(username, password);
                                users_Homepage.Show();
                            }

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect username or password. Please try again.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
