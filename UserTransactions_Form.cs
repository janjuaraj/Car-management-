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
    public partial class UserTransactions_Form : Form
    {

        private int userId;

        
        public UserTransactions_Form(int uid)
        {
            InitializeComponent();
            userId = uid;
        }

        private void UserTransactions_Form_Load(object sender, EventArgs e)
        {
            LoadTransactions();
        }

        private void LoadTransactions()
        {
            transactionsGrid.Rows.Clear();
            transactionsGrid.Columns.Clear();

            transactionsGrid.Columns.Add("SaleId", "Sale ID");
            transactionsGrid.Columns.Add("CarId", "Car ID");
            transactionsGrid.Columns.Add("UserId", "User ID");
            transactionsGrid.Columns.Add("DateSold", "Date Sold");

            List<Car_Sales> transactionList = Database.GetTransactionsByUser(userId);

            for (int i = 0; i < transactionList.Count; i++)
            {
                transactionsGrid.Rows.Add(
                    transactionList[i].SaleId,
                    transactionList[i].Car,
                    transactionList[i].User,
                    transactionList[i].DateSold
                );
            }
        }

        private void abc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            UserForm uf = new UserForm(userId);
            uf.Show();
            this.Close();
        }
    }
}
