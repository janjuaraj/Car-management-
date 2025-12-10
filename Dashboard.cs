using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSapp
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            adminlogin_form adminlogin = new adminlogin_form();
            this.Hide();
            adminlogin.Show();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            userlogin_form userlogin = new userlogin_form();
            this.Hide();
            userlogin.Show();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
