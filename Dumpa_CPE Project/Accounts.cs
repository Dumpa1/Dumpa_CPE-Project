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
    public partial class Accounts : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.16.0;Data Source=C:\\Users\\zachari abriell\\OneDrive\\Documents\\2nd year shool sheyt\\Second Semester\\CPE262-H1\\Dumpa_CPE Project\\Dumpa_CPE Project\\Account.accdb";
      
        public Accounts()
        {
            InitializeComponent();
        }
        private void Accounts_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT ID, Username, Password, UserType FROM [User]";
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserType_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtID.Text = row.Cells["ID"].Value.ToString();
                txtUsername.Text = row.Cells["Username"].Value.ToString();
                txtPassword.Text = row.Cells["Password"].Value.ToString();
                txtUserType.Text = row.Cells["UserType"].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);

                try
                {
                    using (OleDbConnection connection = new OleDbConnection(connectionString))
                    {
                        connection.Open();
                        string query = "DELETE FROM [User] WHERE ID = @ID";
                        using (OleDbCommand command = new OleDbCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@ID", id);
                            command.ExecuteNonQuery();
                        }
                    }
                    LoadData();
                    MessageBox.Show("User deleted successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting user: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a user to delete.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);

                try
                {
                    using (OleDbConnection connection = new OleDbConnection(connectionString))
                    {
                        connection.Open();
                        string query = "UPDATE [User] SET Username = @Username, [Password] = @Password, UserType = @UserType WHERE ID = @ID";
                        using (OleDbCommand command = new OleDbCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                            command.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());
                            command.Parameters.AddWithValue("@UserType", txtUserType.Text.Trim());
                            command.Parameters.AddWithValue("@ID", id);
                            command.ExecuteNonQuery();
                        }
                    }
                    LoadData();
                    MessageBox.Show("User updated successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating user: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a user to update.");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT ID, Username, Password, UserType FROM [User] WHERE Username LIKE @Search OR UserType LIKE @Search";
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@Search", "%" + txtSearch.Text + "%");
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching users: " + ex.Message);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO [User] (Username, [Password], UserType) VALUES (@Username, @Password, @UserType)";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                        command.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());
                        command.Parameters.AddWithValue("@UserType", txtUserType.Text.Trim());
                        command.ExecuteNonQuery();
                    }
                }
                LoadData();
                MessageBox.Show("User inserted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting user: " + ex.Message);
            }
        }
    }
}
