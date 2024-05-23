using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dumpa_CPE_Project
{
    public partial class MealPlan : Form
    {
        private string selectedDiet;
        private string username;

        public MealPlan(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectedDiet = "Anything";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectedDiet = "Low-Carb Diet";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selectedDiet = "Vegetarian";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            selectedDiet = "Low-Cal Diet";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            selectedDiet = "Ketogenic";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            selectedDiet = "Paleo";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (string.IsNullOrEmpty(selectedDiet))
            {
                MessageBox.Show("Please choose a diet before proceeding.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Instantiate the Calorie_Calculator form with the username
            Calorie_Calculator form = new Calorie_Calculator(username);

            // Set the text to the selected diet and disable the textbox
            form.TextBox1.Text = selectedDiet;
            form.TextBox1.Enabled = false;

            // Show the Calorie_Calculator form
            form.Show();

            // Hide the current form
            this.Hide();

            // Ensure Users_Homepage is hidden
            Form usersHomepage = Application.OpenForms.OfType<Users_Homepage>().FirstOrDefault();
            if (usersHomepage != null)
            {
                usersHomepage.Hide();
            }
        }

    }
}
