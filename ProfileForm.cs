using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace POSapp
{
    public partial class ProfileForm : Form
    {
        private int userId;

        public ProfileForm(int loggedInUserId)
        {
            InitializeComponent();
            userId = loggedInUserId;
            LoadUserProfile();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
        }

        private void LoadUserProfile()
        {
            try
            {
            Users user = Database.GetUserById(userId);
            if (user != null)
            {
                txt_userid.Text = user.UserId.ToString();
                txt_username.Text = user.UserName;
                txt_email.Text = user.Email;
                txt_phno.Text = user.PhoneNumber;
                txt_pswd.Text = user.Password;
                txt_cpswd.Text = user.Password;
            }
            else
            {
                MessageBox.Show("User not found.");
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }

        private void btn_updateProfile_Click_1(object sender, EventArgs e)
        {
            if (txt_pswd.Text != txt_cpswd.Text)
            {
                MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Users user = new Users();
                user.UserId = userId;
                user.UserName = txt_username.Text;
                user.Email = txt_email.Text;
                user.PhoneNumber = txt_phno.Text;
                user.Password = txt_pswd.Text;   

                bool updated = Database.UpdateUserProfile(user);
                if (updated)
                    MessageBox.Show("Profile updated successfully!");
                else
                    MessageBox.Show("Update failed. Check if User ID exists.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating profile: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserForm home = new UserForm(userId);
            home.Show();
            this.Hide();
        }


        private void txt_userid_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_cpswd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_pswd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_phno_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
