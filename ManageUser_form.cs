using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSapp
{
    public partial class ManageUser_form : Form
    {
        public ManageUser_form()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void ManageUser_form_Load(object sender, EventArgs e)
        {

        }

        public void LoadUsers()
        {
            usersGrid.Rows.Clear();
            usersGrid.Columns.Clear();
            usersGrid.Columns.Add("UserId", "User ID");
            usersGrid.Columns.Add("UserName", "User Name");
            usersGrid.Columns.Add("Password", "Password");
            usersGrid.Columns.Add("UserType", "User Type");
            usersGrid.Columns.Add("Email", "Email");
            usersGrid.Columns.Add("PhoneNumber", "Phone Number");
            List<Users> users = Database.GetUsers();
            
            for (int i = 0; i < users.Count; i++)
            {
                usersGrid.Rows.Add(users[i].UserId, users[i].UserName, users[i].Password, users[i].UserType, users[i].Email, users[i].PhoneNumber);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Users U = new Users();
            U.SetUserId(Convert.ToInt32(txtUserId.Text));
            U.SetUserName(txtUName.Text);
            U.SetPassword(txtP.Text);
            U.SetUserType(cmbUserType.SelectedItem.ToString());
            U.SetEmail(txtEmail.Text);
            U.SetPhoneNumber(txtPNumber.Text);

            if (string.IsNullOrEmpty(U.UserName) || string.IsNullOrEmpty(U.Password) || string.IsNullOrEmpty(U.UserType) || string.IsNullOrEmpty(U.Email) || string.IsNullOrEmpty(U.PhoneNumber))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }
            if (Database.AddUser(U))
            {
                MessageBox.Show("User added successfully!");
                LoadUsers();
            }
            else
            {
                MessageBox.Show("Failed to add user. Please try again.");

            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(txtUserId.Text);
            Users U = Database.GetUserById(userId);

            if (U == null)
            {
                MessageBox.Show("User not found.");
                return;
            }

            U.SetUserName(txtUName.Text);
            U.SetPassword(txtP.Text);
            U.SetUserType(cmbUserType.SelectedItem.ToString());
            U.SetEmail(txtEmail.Text);
            U.SetPhoneNumber(txtPNumber.Text);

            if (string.IsNullOrEmpty(U.UserName) || string.IsNullOrEmpty(U.Password) ||
                string.IsNullOrEmpty(U.UserType) || string.IsNullOrEmpty(U.Email) ||
                string.IsNullOrEmpty(U.PhoneNumber))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            if (Database.UpdateUser(U))
            {
                MessageBox.Show("User updated successfully!");
                LoadUsers();
            }
            else
            {
                MessageBox.Show("Failed to update user. Please check the details and try again.");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            usersGrid.Columns.Clear();
            DataTable dt = Database.SearchByUsername(txtSearch.Text);
            usersGrid.DataSource = dt;
            
        }

        private void usersGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = usersGrid.Rows[e.RowIndex];

                txtUserId.Text = row.Cells["USERID"].Value.ToString();
                txtUName.Text = row.Cells["USERNAME"].Value.ToString();
                txtP.Text = row.Cells["PASSWORD"].Value.ToString();
                cmbUserType.Text = row.Cells["USERTYPE"].Value.ToString();
                txtEmail.Text = row.Cells["EMAIL"].Value.ToString();
                txtPNumber.Text = row.Cells["PHONENUMBER"].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUserId.Clear();
            txtUName.Clear();
            txtP.Clear();
            cmbUserType.SelectedIndex = -1;
            txtEmail.Clear();
            txtPNumber.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_Dashboard d = new Admin_Dashboard();
            d.Show();
            this.Hide();
        }
    }
}
