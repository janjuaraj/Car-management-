using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace POSapp
{
     partial class userlogin_form : Form
    {
        public string ConnectionString = "Data Source=(DESCRIPTION=" + "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))" + "(CONNECT_DATA=(SERVICE_NAME=XE)));" + "User id=TESLA CAR INVENTORY MANAGEMENT;Password=shayan;";
        public userlogin_form()
        {
            InitializeComponent();
            txt_usertype.Text = "user";

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signup_form signupform = new signup_form();
            this.Hide();
            signupform.Show();
        }

        private void userlogin_form_Load(object sender, EventArgs e)
        {

        }
        int userId;
        private void btn_login_Click(object sender, EventArgs e)
        {
            string email = txt_email.Text;
            string password = txt_pswd.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter email and password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (OracleConnection conn = new OracleConnection(ConnectionString))
                {
                    conn.Open();
                    string query = "SELECT UserID FROM Users WHERE Email = :email AND Password = :password AND UserType = 'user'";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("email", email));
                        cmd.Parameters.Add(new OracleParameter("password", password));

                        int result = Convert.ToInt32(cmd.ExecuteScalar());

                        if (result > 0)
                        {
                            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                          //  userId = (result);
                            UserForm userform = new UserForm(result);
                            userform.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.Show();
        }

        private void txt_usertype_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
