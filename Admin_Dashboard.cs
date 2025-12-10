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
    public partial class Admin_Dashboard : Form
    {
        public Admin_Dashboard()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminlogin_form a = new adminlogin_form();
            this.Hide();
            a.Show();
        }

        private void btncars_Click(object sender, EventArgs e)
        {
            ManageCars_Form c = new ManageCars_Form();
            c.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageSupplier_Form s = new ManageSupplier_Form();
            s.Show();
            this.Hide();
        }

        private void btnuser_Click(object sender, EventArgs e)
        {
            ManageUser_form u = new ManageUser_form();
            u.Show();
            this.Hide();
        }

        private void btncarsales_Click(object sender, EventArgs e)
        {
            CarSales_Form c = new CarSales_Form();
            c.Show();
            this.Hide();
        }
    }
}
