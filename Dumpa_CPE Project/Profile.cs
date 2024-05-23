using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Dumpa_CPE_Project
{
    public partial class Profile : Form
    {
        private string username;


        public void LoadProfileData()
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.16.0;Data Source=C:\\Users\\zachari abriell\\OneDrive\\Documents\\2nd year shool sheyt\\Second Semester\\CPE262-H1\\Dumpa_CPE Project\\Dumpa_CPE Project\\Account.accdb";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                string query = "SELECT * FROM ProfileInfo WHERE Username = ?";
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);

                    connection.Open();
                    OleDbDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        txtLastName.Text = reader["Last Name"].ToString();
                        txtFirstName.Text = reader["First Name"].ToString();
                        txtMiddleName.Text = reader["Middle Name"].ToString();
                        txtPhoneNumber.Text = reader["Phone Number"].ToString();
                        txtAge.Text = reader["Age"].ToString();
                        txtDateOfBirth.Text = reader["Date of Birth"].ToString();
                        cBoxGender.Text = reader["Gender"].ToString();
                        cBoxEducationLevel.Text = reader["Education Level"].ToString();
                        txtHeight.Text = reader["Height"].ToString();
                        txtWeight.Text = reader["Weight"].ToString();
                        cBoxDietry.Text = reader["Dietry Preferences"].ToString();
                        cBoxFitnessGoal.Text = reader["Fitness Goals"].ToString();
                        cBoxMedical.Text = reader["Medical Conditions"].ToString();
                        txtAddress.Text = reader["Home Address"].ToString();
                        txtAddress1.Text = reader["City Address"].ToString();
                        txtEmail.Text = reader["Email Address"].ToString();
                    }
                    reader.Close();
                }
            }
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
