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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Dumpa_CPE_Project
{
    public partial class Feedback : Form
    {
        private string username;
        public Feedback(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string question = textBox1.Text;

            if (string.IsNullOrWhiteSpace(question))
            {
                MessageBox.Show("Please enter your question.");
                return;
            }

            try
            {
                string connectionString = @"Provider=Microsoft.ACE.OLEDB.16.0;Data Source=C:\\Users\\zachari abriell\\OneDrive\\Documents\\2nd year shool sheyt\\Second Semester\\CPE262-H1\\Dumpa_CPE Project\\Dumpa_CPE Project\\Account.accdb";
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Feedback (Username, Question) VALUES (@Username, @Question)";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Question", question);
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Your question has been submitted.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error submitting question: " + ex.Message);
            }
        }
    }
}
