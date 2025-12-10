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
    public partial class GenerateInvoiceForm : Form
    {
        
        private int carId;
        private string modelName;
        private string color;
        private string year;
        private decimal price;
        private int userId;
        public GenerateInvoiceForm(int carid,string model ,string color, string year, decimal price, int id )
        {
            InitializeComponent();
            this.carId = carid;
            this.modelName = model;
            this.color = color;
            this.year = year;
            this.price = price;
            this.userId = id;

            textBox1.Text = model;
            textBox2.Text = color;
            textBox6.Text = year;
            textBox5.Text = DateTime.Now.ToString("yyyy-MM-dd");
            lbltotal.Text = "Rs. " + price.ToString("N2");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox6.Text) || string.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }
            if(Database.DecreaseStock(carId, userId))
            {
                MessageBox.Show("Purchase completed!\n\nThank you for your purchase!\nWe appreciate your trust in Tesla Car.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnConfirmPurchase.Enabled = false;
            }


        }
        private void button5_Click(object sender, EventArgs e)
        {
            BuyCar_Form b = new BuyCar_Form(userId);
            b.Show();
            this.Hide();

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }

        private void BuyCar_Form_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }


        private void lbltotal_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
