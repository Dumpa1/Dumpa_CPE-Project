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
    public partial class UsersInfo : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.16.0;Data Source=C:\\Users\\zachari abriell\\OneDrive\\Documents\\2nd year shool sheyt\\Second Semester\\CPE262-H1\\Dumpa_CPE Project\\Dumpa_CPE Project\\Account.accdb";
        public UsersInfo()
        {
            InitializeComponent();
        }

        private void UsersInfo_Load(object sender, EventArgs e)
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
                    string query = "SELECT ID, Username, [Current Diet], [Calorie Target], Bodyfat, Gender, Height, Weight, Age, ActivityLevel, GoalWeight FROM CalorieInfo";
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

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO CalorieInfo (Username, [Current Diet], [Calorie Target], Bodyfat, Gender, Height, Weight, Age, ActivityLevel, GoalWeight) VALUES (@Username, @CurrentDiet, @CalorieTarget, @Bodyfat, @Gender, @Height, @Weight, @Age, @ActivityLevel, @GoalWeight)";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                        command.Parameters.AddWithValue("@CurrentDiet", txtCurrentDiet.Text.Trim());
                        command.Parameters.AddWithValue("@CalorieTarget", txtCalorieTarget.Text.Trim());
                        command.Parameters.AddWithValue("@Bodyfat", txtBodyFat.Text.Trim());
                        command.Parameters.AddWithValue("@Gender", txtGender.Text.Trim());
                        command.Parameters.AddWithValue("@Height", txtHeight.Text.Trim());
                        command.Parameters.AddWithValue("@Weight", txtWeight.Text.Trim());
                        command.Parameters.AddWithValue("@Age", txtAge.Text.Trim());
                        command.Parameters.AddWithValue("@ActivityLevel", txtActivityLevel.Text.Trim());
                        command.Parameters.AddWithValue("@GoalWeight", txtGoalWeight.Text.Trim());
                        command.ExecuteNonQuery();
                    }
                }
                LoadData();
                MessageBox.Show("Record inserted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting record: " + ex.Message);
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
                        string query = "DELETE FROM CalorieInfo WHERE ID = @ID";
                        using (OleDbCommand command = new OleDbCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@ID", id);
                            command.ExecuteNonQuery();
                        }
                    }
                    LoadData();
                    MessageBox.Show("Record deleted successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting record: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a record to delete.");
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
                        string query = "UPDATE CalorieInfo SET Username = @Username, [Current Diet] = @CurrentDiet, [Calorie Target] = @CalorieTarget, Bodyfat = @Bodyfat, Gender = @Gender, Height = @Height, Weight = @Weight, Age = @Age, ActivityLevel = @ActivityLevel, GoalWeight = @GoalWeight WHERE ID = @ID";
                        using (OleDbCommand command = new OleDbCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                            command.Parameters.AddWithValue("@CurrentDiet", txtCurrentDiet.Text.Trim());
                            command.Parameters.AddWithValue("@CalorieTarget", txtCalorieTarget.Text.Trim());
                            command.Parameters.AddWithValue("@Bodyfat", txtBodyFat.Text.Trim());
                            command.Parameters.AddWithValue("@Gender", txtGender.Text.Trim());
                            command.Parameters.AddWithValue("@Height", txtHeight.Text.Trim());
                            command.Parameters.AddWithValue("@Weight", txtWeight.Text.Trim());
                            command.Parameters.AddWithValue("@Age", txtAge.Text.Trim());
                            command.Parameters.AddWithValue("@ActivityLevel", txtActivityLevel.Text.Trim());
                            command.Parameters.AddWithValue("@GoalWeight", txtGoalWeight.Text.Trim());
                            command.Parameters.AddWithValue("@ID", id);
                            command.ExecuteNonQuery();
                        }
                    }
                    LoadData();
                    MessageBox.Show("Record updated successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating record: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a record to update.");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtID.Text = row.Cells["ID"].Value.ToString();
                txtUsername.Text = row.Cells["Username"].Value.ToString();
                txtCurrentDiet.Text = row.Cells["Current Diet"].Value.ToString();
                txtCalorieTarget.Text = row.Cells["Calorie Target"].Value.ToString();
                txtBodyFat.Text = row.Cells["Bodyfat"].Value.ToString();
                txtGender.Text = row.Cells["Gender"].Value.ToString();
                txtHeight.Text = row.Cells["Height"].Value.ToString();
                txtWeight.Text = row.Cells["Weight"].Value.ToString();
                txtAge.Text = row.Cells["Age"].Value.ToString();
                txtActivityLevel.Text = row.Cells["ActivityLevel"].Value.ToString();
                txtGoalWeight.Text = row.Cells["GoalWeight"].Value.ToString();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string username = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter a username to search.");
                return;
            }

            string query = "SELECT ID, Username, [Current Diet], [Calorie Target], Bodyfat, Gender, Height, Weight, Age, ActivityLevel, GoalWeight FROM CalorieInfo WHERE Username = @Username";

            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        connection.Open();

                        OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching records: " + ex.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGoalWeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtActivityLevel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGender_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBodyFat_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCalorieTarget_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCurrentDiet_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
