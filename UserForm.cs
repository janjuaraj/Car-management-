using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSapp
{
    public partial class UserForm: Form
    {
        int loggedInUserId;

        public UserForm(int userId)
        {
            InitializeComponent();
            loggedInUserId = userId;
        }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProfileForm profileform = new ProfileForm(loggedInUserId);
            profileform.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            userlogin_form userLform = new userlogin_form();
            userLform.Show();
            this.Hide();
        }

       

        private void button4_Click_1(object sender, EventArgs e)
        {
            BuyCar_Form buy = new BuyCar_Form(loggedInUserId);
            buy.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BuyCar_Form s = new BuyCar_Form(loggedInUserId);
            s.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserTransactions_Form t = new UserTransactions_Form(loggedInUserId);
            t.Show();
            this.Hide();
        }
    }
}
