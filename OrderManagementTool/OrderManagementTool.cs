using BLL;
using System;
using System.Windows.Forms;

namespace OrderManagementTool
{
    public partial class OrderManagementTool : Form
    {
        private DataImportingPage frmDataImporting;
        private OrderCreationPage frmOrderCreation;
        private UndoneOrdersPage frmUndoneOrders;


        public OrderManagementTool()
        {
            InitializeComponent();
            this.dgvTransaction.AutoGenerateColumns = false;// prohibit useless column 
            ShowTransaction();
        }





        /// <summary>
        /// Import the existed data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenDataImporter_Click(object sender, System.EventArgs e)
        {
            frmDataImporting = new DataImportingPage();
            frmDataImporting.ShowDialog();
            ShowTransaction();
        }


        private void ShowTransaction()
        {

            dgvTransaction.DataSource = new TransactionManage().GetTransactionList();

            #region Calculate total profit

            double TotalProfit = 0;
            foreach (DataGridViewRow dgvTransactionRow in dgvTransaction.Rows)
            {
                TotalProfit += Convert.ToDouble(dgvTransactionRow.Cells["Profit"].Value);
            }
            lbTotalProfit.Text = "The total profit: " + TotalProfit.ToString();

            #endregion
            dgvTransaction.Show();
        }

        private void btnAddOrder_Click(object sender, System.EventArgs e)
        {
            frmOrderCreation = new OrderCreationPage();
            frmOrderCreation.ShowDialog();
            ShowTransaction();
        }

        private void btnUndoneOrders_Click(object sender, System.EventArgs e)
        {
            frmUndoneOrders = new UndoneOrdersPage();
            frmUndoneOrders.ShowDialog();
            ShowTransaction();
        }

    }
}
