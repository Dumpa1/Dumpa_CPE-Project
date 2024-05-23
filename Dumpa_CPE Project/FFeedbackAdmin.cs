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
    public partial class FeedbackAdmin : Form
    {
        public FeedbackAdmin()
        {
            InitializeComponent();
            ConfigureDataGridView();
            LoadFeedback();
        }

        private void ConfigureDataGridView()
        {
            dataGridView1.ScrollBars = ScrollBars.Horizontal;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridView1.AllowUserToResizeColumns = true;
        }

        private void LoadFeedback()
        {
            try
            {
                string connectionString = @"Provider=Microsoft.ACE.OLEDB.16.0;Data Source=C:\\Users\\zachari abriell\\OneDrive\\Documents\\2nd year shool sheyt\\Second Semester\\CPE262-H1\\Dumpa_CPE Project\\Dumpa_CPE Project\\Account.accdb";
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT ID, Username, Question, Answer FROM Feedback";
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading feedback: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int feedbackID = (int)dataGridView1.CurrentRow.Cells["ID"].Value;
                string answer = textBox1.Text;

                if (string.IsNullOrWhiteSpace(answer))
                {
                    MessageBox.Show("Please enter an answer.");
                    return;
                }

                try
                {
                    string connectionString = @"Provider=Microsoft.ACE.OLEDB.16.0;Data Source=C:\\Users\\zachari abriell\\OneDrive\\Documents\\2nd year shool sheyt\\Second Semester\\CPE262-H1\\Dumpa_CPE Project\\Dumpa_CPE Project\\Account.accdb";
                    using (OleDbConnection connection = new OleDbConnection(connectionString))
                    {
                        connection.Open();
                        string query = "UPDATE Feedback SET Answer = @Answer WHERE ID = @ID";
                        using (OleDbCommand command = new OleDbCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Answer", answer);
                            command.Parameters.AddWithValue("@ID", feedbackID);
                            command.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Answer submitted successfully.");
                    LoadFeedback(); // Refresh feedback list
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error submitting answer: " + ex.Message);
                }
            }
        }
    }
}
