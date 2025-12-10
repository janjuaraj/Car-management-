using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSapp
{
    public partial class BuyCar_Form : Form
    {
        public string connectionString = "Data Source=(DESCRIPTION=" + "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))" + "(CONNECT_DATA=(SERVICE_NAME=XE)));" + "User id=TESLA CAR INVENTORY MANAGEMENT;Password=shayan;";

        int id;
        public BuyCar_Form(int uid)
        {
            InitializeComponent();
            id = uid;
        }


        private void BuyCars_form_Load(object sender, EventArgs e)
        {
            LoadCars();
        }
        private void LoadCars(string model = "")
        {
            try
            {
                gridCars.Rows.Clear();
                gridCars.Columns.Clear();

                string query = "SELECT CARID, MODELNAME, PRICE, YEARMANUFACTURED,BATTERYCAPACITY,COLOR, STOCK, STATUS FROM CARS WHERE STATUS = 'Available'";

                if (!string.IsNullOrWhiteSpace(model))
                {
                    query += " AND LOWER(MODELNAME) LIKE :model";
                }

                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    conn.Open();
                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        if (!string.IsNullOrWhiteSpace(model))
                        {
                            cmd.Parameters.Add(":model", txtSearch.Text).Value = "%" + model.ToLower() + "%";
                        }

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            gridCars.Columns.Add("CARID", "Car ID");
                            gridCars.Columns.Add("MODELNAME", "Model Name");
                            gridCars.Columns.Add("PRICE", "Price");
                            gridCars.Columns.Add("YEARMANUFACTURED", "Year");
                            gridCars.Columns.Add("BATTERYCAPACITY", "batterycapacity");
                            gridCars.Columns.Add("COLOR", "color");
                            gridCars.Columns.Add("STOCK", "Stock");
                            gridCars.Columns.Add("STATUS", "Status");
                            while (reader.Read())
                            {
                                gridCars.Rows.Add(
                                    reader["CARID"].ToString(),
                                    reader["MODELNAME"].ToString(),
                                    reader["PRICE"].ToString(),
                                    reader["YEARMANUFACTURED"].ToString(),
                                    reader["BATTERYCAPACITY"].ToString(),
                                    reader["COLOR"].ToString(),
                                    reader["STOCK"].ToString(),
                                    reader["STATUS"].ToString()
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string model = txtSearch.Text;
            LoadCars(model);
        }

        private byte[] GetCarImage(int carId)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                string query = "SELECT CARIMAGE FROM CARS WHERE CARID = :id";
                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(":id", carId);
                conn.Open();
                OracleDataReader reader = cmd.ExecuteReader();
                if (reader.Read() && !reader.IsDBNull(0))
                {
                    return (byte[])reader["CARIMAGE"];
                }
            }
            return null;
        }
        public int selectedCarId = -1;
        private void gridCars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow selectedRow = gridCars.Rows[e.RowIndex];

                selectedCarId = Convert.ToInt32(selectedRow.Cells["CARID"].Value);
                byte[] imageBytes = GetCarImage(Convert.ToInt32(selectedRow.Cells["CARID"].Value));
                if (imageBytes != null)
                {
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pictureBox1.Image = null;
                    imageBytes = null;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (gridCars.CurrentRow == null)
            {
                MessageBox.Show("Please select a car to purchase.", "No Car Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow selectedCarRow = gridCars.SelectedRows[0];

            int carId = Convert.ToInt32(selectedCarRow.Cells["CARID"].Value);
            string modelName = selectedCarRow.Cells["MODELNAME"].Value.ToString();
            string color = selectedCarRow.Cells["COLOR"].Value.ToString();
            string year = selectedCarRow.Cells["YEARMANUFACTURED"].Value.ToString();
            decimal price = Convert.ToDecimal(selectedCarRow.Cells["PRICE"].Value);

            MessageBox.Show("Congrats for selecting the car!\nConfirm your transaction to buy the car > ", "Operation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);


            GenerateInvoiceForm invoiceForm = new GenerateInvoiceForm(carId, modelName, color, year, price, id);
            invoiceForm.Show();
            this.Hide();
            LoadCars();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            UserForm uf = new UserForm(id);
            uf.Show();
            this.Hide();
        }
    }
}
