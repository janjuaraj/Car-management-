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
    public partial class ManageSupplier_Form : Form
    {

        public ManageSupplier_Form()
        {
            InitializeComponent();
            LoadSuppliers();
        }
        private void ManageSupplier_Form_Load(object sender, EventArgs e)
        {

        }

        private void LoadSuppliers()
        {
            suppliersGrid.Rows.Clear();
            suppliersGrid.Columns.Clear();
            suppliersGrid.Columns.Add("SupplierId", "Supplier ID");
            suppliersGrid.Columns.Add("SupplierName", "Supplier Name");
            suppliersGrid.Columns.Add("PhoneNumber", "Phone Number");
            suppliersGrid.Columns.Add("Address", "Address");
            suppliersGrid.Columns.Add("Email", "Email");

            List<Suppliers> suppliers = Database.GetSuppliers();
            for (int i = 0; i < suppliers.Count; i++)
            {
                suppliersGrid.Rows.Add(
                    suppliers[i].SupplierId,
                    suppliers[i].SupplierName,
                    suppliers[i].PhoneNumber,
                    suppliers[i].Address,
                    suppliers[i].Email
                );
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Suppliers s = new Suppliers();

            s.SupplierId = Convert.ToInt32(txtSId.Text);
            s.SupplierName = txtSName.Text;
            s.PhoneNumber = txtPNumber.Text;
            s.Address = txtAddress.Text;
            s.Email = txtEmail.Text;
            

            if (Database.AddSupplier(s))
            {
                MessageBox.Show("Supplier added successfully!");
                LoadSuppliers();
            }
            else
            {
                MessageBox.Show("Failed to add supplier.");
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Suppliers s = new Suppliers();

            s.SupplierId = Convert.ToInt32(txtSId.Text);
            s.SupplierName = txtSName.Text;
            s.PhoneNumber = txtPNumber.Text;
            s.Address = txtAddress.Text;
            s.Email = txtEmail.Text;

            if (Database.UpdateSupplier(s))
            {
                MessageBox.Show("Supplier updated successfully!");
                LoadSuppliers();
            }
            else
            {
                MessageBox.Show("Failed to update supplier.");
            }
        
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            suppliersGrid.Rows.Clear();
            List<Suppliers> suppliers = Database.SearchSuppliersByName(txtSearch.Text);
            for (int i = 0; i < suppliers.Count; i++)
            {
                suppliersGrid.Rows.Add(
                    suppliers[i].SupplierId,
                    suppliers[i].SupplierName,
                    suppliers[i].PhoneNumber,
                    suppliers[i].Address,
                    suppliers[i].Email
                );
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtSId.Clear();
            txtSName.Clear();
            txtPNumber.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
        }

        private void suppliersGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = suppliersGrid.Rows[e.RowIndex];

                txtSId.Text = row.Cells["SupplierId"].Value.ToString();
                txtSName.Text = row.Cells["SupplierName"].Value.ToString();
                txtPNumber.Text = row.Cells["PhoneNumber"].Value.ToString();
                txtAddress.Text = row.Cells["Address"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_Dashboard d = new Admin_Dashboard();
            d.Show();
            this.Hide();

        }
    }
}
