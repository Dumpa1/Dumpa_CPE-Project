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
    public partial class Admin_Homepage : Form
    {
 
        public Admin_Homepage()
        {
            InitializeComponent();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Accounts accountsForm = new Accounts();
            accountsForm.TopLevel = false;
            accountsForm.AutoScroll = true;
            panel4.Controls.Clear(); 
            panel4.Controls.Add(accountsForm);
            accountsForm.Show();
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

        private void btnFeedbacks_Click(object sender, EventArgs e)
        {
            FeedbackAdmin feedbackAdminForm = new FeedbackAdmin();
            feedbackAdminForm.TopLevel = false;
            feedbackAdminForm.AutoScroll = true;
            panel4.Controls.Clear(); 
            panel4.Controls.Add(feedbackAdminForm);
            feedbackAdminForm.Show();
        }

        private void btnUsersPlans_Click(object sender, EventArgs e)
        {
            UsersInfo usersInfoForm = new UsersInfo();
            usersInfoForm.TopLevel = false;
            usersInfoForm.AutoScroll = true;
            panel4.Controls.Clear();
            panel4.Controls.Add(usersInfoForm);
            usersInfoForm.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home homeForm = new Home();
            homeForm.TopLevel = false;
            homeForm.AutoScroll = true;
            panel4.Controls.Clear();
            panel4.Controls.Add(homeForm);
            homeForm.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
