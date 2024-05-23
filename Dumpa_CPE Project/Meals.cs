using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Dumpa_CPE_Project
{
    public partial class Meals : Form
    {
        private string username;

        public Meals(string username)
        {
            InitializeComponent();
            this.username = username;
            lblUsername.Text = username;
        }
        public System.Windows.Forms.Label Label3
        {
            get { return label3; }
            set { label3 = value; }
        }

        public System.Windows.Forms.Label Label4
        {
            get { return label4; }
            set { label4 = value; }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
