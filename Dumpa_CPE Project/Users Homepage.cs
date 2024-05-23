using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WinFormsApplication = System.Windows.Forms.Application;

namespace Dumpa_CPE_Project
{
    public partial class Users_Homepage : Form
    {
        private string username;
        private string password;

        public Users_Homepage(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
            lblUsername.Text = username;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            WinFormsApplication.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MealPlan mealPlanForm = new MealPlan(username);
            mealPlanForm.TopLevel = false;
            mealPlanForm.AutoScroll = true;
            panel4.Controls.Clear();
            panel4.Controls.Add(mealPlanForm);
            mealPlanForm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                SignInForm signInForm = new SignInForm();
                signInForm.Show();
                this.Hide();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Feedback feedbackForm = new Feedback(username);
            feedbackForm.TopLevel = false;
            feedbackForm.AutoScroll = true;
            panel4.Controls.Clear();
            panel4.Controls.Add(feedbackForm);
            feedbackForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home homeForm = new Home();
            homeForm.TopLevel = false;
            homeForm.AutoScroll = true;
            panel4.Controls.Clear();
            panel4.Controls.Add(homeForm);
            homeForm.Show();
        }
    }
}
