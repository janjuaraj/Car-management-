using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace POSapp
{
    public partial class signup_form : Form
    {
        public signup_form()
        {
            InitializeComponent();
            loaduid();
        }
        private void loaduid()
        {
            txtuserid.Text = Database.GetUniqueID("users").ToString();
            
        }
       
        private void btn_signup_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_username.Text) ||
                string.IsNullOrWhiteSpace(txt_email.Text) ||
                string.IsNullOrWhiteSpace(txt_phno.Text) ||
                string.IsNullOrWhiteSpace(txt_pswd.Text) ||
                string.IsNullOrWhiteSpace(txt_cpswd.Text) ||
                string.IsNullOrWhiteSpace(txt_usertype.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Users user = new Users();
            string userName = txt_username.Text;
            string email = txt_email.Text;
            string phoneNo = txt_phno.Text;
            string password = txt_pswd.Text;
            string confirmPassword = txt_cpswd.Text;
            string usertype = txt_usertype.Text;

            user.SetUserId(Convert.ToInt32(txtuserid.Text));
            user.SetUserName(userName);
            user.SetEmail(email);
            user.SetPhoneNumber(phoneNo);
            user.SetPassword(password);
            user.SetUserType(usertype);

            if (Database.AddUser(user))
            {
                MessageBox.Show("User Signup successful. ");
                userlogin_form  u = new userlogin_form();
                u.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
