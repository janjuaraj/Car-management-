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
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;
using System.Diagnostics;

namespace POSapp
{
    public partial class ManageCars_Form : Form
    {
        byte[] carImageBytes = null;
        public ManageCars_Form()
        {
            InitializeComponent();
            LoadCars();
        }

        private void LoadCars()
        {
            carsGrid.Rows.Clear();
            carsGrid.Columns.Clear();

            carsGrid.Columns.Add("CarId", "Car ID");
            carsGrid.Columns.Add("ModelName", "Model Name");
            carsGrid.Columns.Add("EngineNumber", "Engine Number");
            carsGrid.Columns.Add("YearManufactured", "Year Manufactured");
            carsGrid.Columns.Add("BatteryCapacity", "Battery Capacity");
            carsGrid.Columns.Add("Price", "Price");
            carsGrid.Columns.Add("Status", "Status");
            carsGrid.Columns.Add("Stock", "Stock");
            carsGrid.Columns.Add("Color", "Color");
            carsGrid.Columns.Add("SupplierId", "Supplier ID");
            
            

            List<Cars> carsList = Database.GetCars();

            for (int i = 0; i < carsList.Count; i++)
            {
                carsGrid.Rows.Add(
                    carsList[i].CarId,
                    carsList[i].ModelName,
                    carsList[i].EngineNumber,
                    carsList[i].YearManufactured,
                    carsList[i].BatteryCapacity,
                    carsList[i].Price,
                    carsList[i].Status,
                    carsList[i].Stock,
                    carsList[i].Color,
                    carsList[i].SupplierId
                    
                );
            }

        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCarId.Text) || string.IsNullOrEmpty(txtModel.Text) || string.IsNullOrEmpty(txtEngineNumber.Text) || string.IsNullOrEmpty(txtcolor.Text) || string.IsNullOrEmpty(txtYear.Text) || string.IsNullOrEmpty(txtBattery.Text) || string.IsNullOrEmpty(txtPrice.Text) || string.IsNullOrEmpty(cmbStatus.Text) || string.IsNullOrEmpty(txtSupplierId.Text) || carImageBytes == null || string.IsNullOrEmpty(txtStock.Text))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }
            Cars cars = new Cars();
            cars.CarId = Convert.ToInt32(txtCarId.Text);
            cars.ModelName = txtModel.Text;
            cars.EngineNumber = txtEngineNumber.Text;
            cars.Color = txtcolor.Text;
            cars.YearManufactured = Convert.ToInt32(txtYear.Text);
            cars.BatteryCapacity = txtBattery.Text;
            cars.Price = Convert.ToDecimal(txtPrice.Text);
            cars.Status = cmbStatus.SelectedItem.ToString();
            cars.SupplierId = Convert.ToInt32(txtSupplierId.Text);
            cars.Stock = Convert.ToInt32(txtStock.Text);
            cars.CarImage = carImageBytes;

            if(Database.AddCar(cars))
            {
                MessageBox.Show("Car added successfully!");
                LoadCars();
            }
            else
            {
                MessageBox.Show("Failed to add car. Please check your input.");
            }

        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            Cars cars = new Cars();
            cars.CarId = Convert.ToInt32(txtCarId.Text);
            cars.ModelName = txtModel.Text;
            cars.EngineNumber = txtEngineNumber.Text;
            cars.Color = txtcolor.Text;
            cars.YearManufactured = Convert.ToInt32(txtYear.Text);
            cars.BatteryCapacity = txtBattery.Text;
            cars.Price = Convert.ToDecimal(txtPrice.Text);
            cars.Status = cmbStatus.SelectedItem.ToString();
            cars.SupplierId = Convert.ToInt32(txtSupplierId.Text);
            cars.Stock = Convert.ToInt32(txtStock.Text);
            cars.CarImage = carImageBytes;
            if (Database.UpdateCar(cars))
            {
                MessageBox.Show("Car updated successfully!");
                LoadCars();
            }
            else
            {
                MessageBox.Show("Failed to update car. Please check your input.");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Cars car = new Cars();
            car.CarId = Convert.ToInt32(txtCarId.Text);
            DialogResult result = MessageBox.Show("Are you sure to delete this car?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (Database.DeleteCar(car.CarId))
                {
                    MessageBox.Show("Car deleted!");
                    LoadCars();
                }
                else
                {
                    MessageBox.Show("Failed to delete car.");
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            carsGrid.Columns.Clear();
            DataTable dt = Database.SearchCarBymodel(txtSearch.Text);
            carsGrid.DataSource = dt;
        }

        private void btnLoadImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files (*.jpg;*.png)|*.jpg;*.png";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pictureBoxCar.Image = Image.FromFile(dlg.FileName);
                carImageBytes = File.ReadAllBytes(dlg.FileName);
            }
        }
        private void carsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = carsGrid.Rows[e.RowIndex];
            txtCarId.Text = selectedRow.Cells["CarId"].Value.ToString();
            txtModel.Text = selectedRow.Cells["ModelName"].Value.ToString();
            txtEngineNumber.Text = selectedRow.Cells["EngineNumber"].Value.ToString();
            txtcolor.Text = selectedRow.Cells["Color"].Value.ToString();
            txtYear.Text = selectedRow.Cells["YearManufactured"].Value.ToString();
            txtBattery.Text = selectedRow.Cells["BatteryCapacity"].Value.ToString();
            txtPrice.Text = selectedRow.Cells["Price"].Value.ToString();
            cmbStatus.Text = selectedRow.Cells["Status"].Value.ToString();
            txtSupplierId.Text = selectedRow.Cells["SupplierId"].Value.ToString();
            txtStock.Text = selectedRow.Cells["Stock"].Value.ToString();

            int carId = Convert.ToInt32(selectedRow.Cells["CarId"].Value);
            byte[] imageBytes = Database.GetCarImage(carId);

            if (imageBytes != null)
            {
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        pictureBoxCar.Image = Image.FromStream(ms);
                        carImageBytes = imageBytes;
                    }
            }
                else
                {
                    pictureBoxCar.Image = null;
                    carImageBytes = null;
                }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtCarId.Clear();
            txtModel.Clear();
            txtEngineNumber.Clear();
            txtcolor.Clear();
            txtYear.Clear();
            txtBattery.Clear();
            txtPrice.Clear();
            txtSupplierId.Clear();
            txtStock.Clear();
            cmbStatus.SelectedIndex = -1;
            pictureBoxCar.Image = null;
            carImageBytes = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_Dashboard a = new Admin_Dashboard();
            a.Show();
            this.Hide();
        }

        private void ManageCars_Form_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
}

