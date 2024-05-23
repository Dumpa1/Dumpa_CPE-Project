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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Dumpa_CPE_Project
{
    public partial class Calorie_Calculator : Form
    {
        private string username;

        public Calorie_Calculator(string username)
        {
            InitializeComponent();
            this.username = username;
            lblUsername.Text = username;
        }
        public System.Windows.Forms.TextBox TextBox1 // This should correctly expose textBox1
        {
            get { return textBox1; }
            set { textBox1 = value; }
        }

        private void Caolorie_Calculator_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Current Diet Type
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //Calorie Target: Lose weight
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //Calorie Target: Maintain
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //Calorie Target: Build Muscle
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            //Bodyfat: Low
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            //Bodyfat: Medium
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            //Bodyfat: High
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            //General Info: Male
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            //General Info: Female
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //General Info: Height
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //General Info: Weight
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //General Info: Age
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Activity Level Selection: Sedentary, Lightly Active, Moderately Active, Very Active, Extremely Active
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //Goal Weight
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.16.0;Data Source=C:\\Users\\zachari abriell\\OneDrive\\Documents\\2nd year shool sheyt\\Second Semester\\CPE262-H1\\Dumpa_CPE Project\\Dumpa_CPE Project\\Account.accdb";

            string username = lblUsername.Text;
            string currentDiet = textBox1.Text;
            string calorieTarget;
            if (radioButton1.Checked)
            {
                calorieTarget = "Lose Weight";
            }
            else if (radioButton2.Checked)
            {
                calorieTarget = "Maintain";
            }
            else if (radioButton3.Checked)
            {
                calorieTarget = "Build Muscle";
            }
            else
            {
                MessageBox.Show("Please select a Calorie Target.");
                return;
            }

            string bodyfat;
            if (radioButton4.Checked)
            {
                bodyfat = "Low";
            }
            else if (radioButton5.Checked)
            {
                bodyfat = "Medium";
            }
            else if (radioButton6.Checked)
            {
                bodyfat = "High";
            }
            else
            {
                MessageBox.Show("Please select your bodyfat type.");
                return;
            }

            string gender;
            if (radioButton7.Checked)
            {
                gender = "Male";
            }
            else if (radioButton8.Checked)
            {
                gender = "Female";
            }
            else
            {
                MessageBox.Show("Please select a gender.");
                return;
            }

            double height;
            if (!double.TryParse(textBox2.Text, out height))
            {
                MessageBox.Show("Please enter a valid height in centimeters.");
                return;
            }

            double weight;
            if (!double.TryParse(textBox3.Text, out weight))
            {
                MessageBox.Show("Please enter a valid weight.");
                return;
            }

            int age;
            if (!int.TryParse(textBox4.Text, out age))
            {
                MessageBox.Show("Please enter a valid age.");
                return;
            }

            string activityLevel = comboBox1.SelectedItem.ToString();

            string goalWeight = textBox5.Text;

            double caloriesNeeded = CalculateCalories(gender, height, weight, age, activityLevel, calorieTarget, bodyfat);
            int roundedCaloriesNeeded = (int)Math.Round(caloriesNeeded);

            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO CalorieInfo (Username, [Current Diet], [Calorie Target], Bodyfat, Gender, Height, Weight, Age, ActivityLevel, GoalWeight) " +
                                   "VALUES (@Username, @CurrentDiet, @CalorieTarget, @Bodyfat, @Gender, @Height, @Weight, @Age, @ActivityLevel, @GoalWeight)";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@CurrentDiet", currentDiet);
                        command.Parameters.AddWithValue("@CalorieTarget", calorieTarget);
                        command.Parameters.AddWithValue("@Bodyfat", bodyfat);
                        command.Parameters.AddWithValue("@Gender", gender);
                        command.Parameters.AddWithValue("@Height", height);
                        command.Parameters.AddWithValue("@Weight", weight);
                        command.Parameters.AddWithValue("@Age", age);
                        command.Parameters.AddWithValue("@ActivityLevel", activityLevel);
                        command.Parameters.AddWithValue("@GoalWeight", goalWeight);
                        command.ExecuteNonQuery();
                    }
                }

                Meals mealsForm = new Meals(username);
                mealsForm.Label3.Text = roundedCaloriesNeeded.ToString();

                // Set recommendations based on calorie range
                if (roundedCaloriesNeeded >= 500 && roundedCaloriesNeeded < 1000)
                {
                    mealsForm.Label4.Text = "Recommendation: Add more fruits and vegetables to your diet. \nConsider including apples, oranges, carrots, and spinach.";
                }
                else if (roundedCaloriesNeeded >= 1000 && roundedCaloriesNeeded < 2000)
                {
                    mealsForm.Label4.Text = "Recommendation: Ensure a balanced diet with proteins, carbs, \nand fats. Try including chicken breast, brown rice, quinoa, and avocados.";
                }
                else if (roundedCaloriesNeeded >= 2000)
                {
                    mealsForm.Label4.Text = "Recommendation: Include lean proteins, whole grains, and \nhealthy fats. Foods like salmon, sweet potatoes, lentils, \nand olive oil are great choices.";
                }
                else
                {
                    mealsForm.Label4.Text = "Recommendation: Please enter your details correctly.";
                }

                mealsForm.Show();
                Calorie_Calculator calorie_CalculatorForm = new Calorie_Calculator(username);
                calorie_CalculatorForm.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message);
            }

        }

        private double CalculateCalories(string gender, double height, double weight, int age, string activityLevel, string calorieTarget, string bodyfat)
        {
            double BMR;
            double caloriesNeeded;

            // Calculate Basal Metabolic Rate (BMR) based on gender
            if (gender == "Male")
            {
                BMR = 88.362 + (13.397 * weight) + (4.799 * height) - (5.677 * age);
            }
            else
            {
                BMR = 447.593 + (9.247 * weight) + (3.098 * height) - (4.330 * age);
            }

            // Adjust BMR based on bodyfat percentage
            double bodyfatMultiplier;
            switch (bodyfat)
            {
                case "Low":
                    bodyfatMultiplier = 0.95; // Low bodyfat (5-9%)
                    break;
                case "Medium":
                    bodyfatMultiplier = 1.0; // Medium bodyfat (10-19%)
                    break;
                case "High":
                    bodyfatMultiplier = 1.05; // High bodyfat (20% and above)
                    break;
                default:
                    bodyfatMultiplier = 1.0;
                    break;
            }
            BMR *= bodyfatMultiplier;

            // Adjust BMR based on activity level
            switch (activityLevel)
            {
                case "Sedentary":
                    BMR *= 1.2;
                    break;
                case "Lightly Active":
                    BMR *= 1.375;
                    break;
                case "Moderately Active":
                    BMR *= 1.55;
                    break;
                case "Very Active":
                    BMR *= 1.725;
                    break;
                case "Extremely Active":
                    BMR *= 1.9;
                    break;
                default:
                    break;
            }

            // Calculate calories needed based on goal (lose weight, maintain, build muscle)
            switch (calorieTarget)
            {
                case "Lose Weight":
                    caloriesNeeded = BMR - 500; // Subtract 500 calories per day for weight loss
                    break;
                case "Maintain":
                    caloriesNeeded = BMR; // Maintain current weight
                    break;
                case "Build Muscle":
                    caloriesNeeded = BMR + 500; // Add 500 calories per day for muscle gain
                    break;
                default:
                    caloriesNeeded = BMR;
                    break;
            }

            return caloriesNeeded;
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }


    }
}
