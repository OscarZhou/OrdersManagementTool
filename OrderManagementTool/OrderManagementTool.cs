using BLL;
using System;
using System.Windows.Forms;
using Utilities;

namespace OrderManagementTool
{
    public partial class OrderManagementTool : Form
    {
        #region Variable declaration
        private DataImportingPage frmDataImporting;
        private OrderCreationPage frmOrderCreation;
        private UndoneOrdersPage frmUndoneOrders;
        private OrderDetailsPage frmOrderDetail;

        // define delegate
        public delegate void DlgSendOperation(string operation, string orderNo);
        // create an event. that is delegate variables
        public event DlgSendOperation EvtSendOperation;
        #endregion

        public OrderManagementTool()
        {
            InitializeComponent();
            this.dgvTransaction.AutoGenerateColumns = false;// prohibit useless column 
            ShowTransaction();
            InitializeSortingList();
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
            lbTotalProfit.Text = "The total profit: " + TotalProfit.ToString() + "RMB";

            #endregion
            dgvTransaction.Show();
        }

        /// <summary>
        /// create the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddOrder_Click(object sender, System.EventArgs e)
        {
            frmOrderCreation = new OrderCreationPage();
            frmOrderCreation.ShowDialog();
            ShowTransaction();
        }

        /// <summary>
        /// view undone orders
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUndoneOrders_Click(object sender, System.EventArgs e)
        {
            frmUndoneOrders = new UndoneOrdersPage();
            frmUndoneOrders.ShowDialog();
            ShowTransaction();
        }

        /// <summary>
        /// search purchaser
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            ShowTransaction(tbSearch.Text.Trim(), Convert.ToInt32(cmbSorting.SelectedIndex));
        }

        private void ShowTransaction(string name, int sortingtype)
        {
            dgvTransaction.DataSource = new TransactionManage().GetTransactionList(name, sortingtype);
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

        private void InitializeSortingList()
        {
            cmbSorting.Items.Add("OrderNo Asc");
            cmbSorting.Items.Add("OrderNo Desc");
            cmbSorting.Items.Add("Profit Asc");
            cmbSorting.Items.Add("Profit Desc");
            cmbSorting.SelectedIndex = 1;
        }

        private void cmbSorting_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowTransaction(tbSearch.Text.Trim(), Convert.ToInt32(cmbSorting.SelectedIndex));
        }

        /// <summary>
        /// view details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDetail_Click(object sender, EventArgs e)
        {
            frmOrderDetail = new OrderDetailsPage();
            this.EvtSendOperation += frmOrderDetail.Receiver;
            this.EvtSendOperation("View", dgvTransaction.CurrentRow.Cells["OrderNo"].Value.ToString());
            frmOrderDetail.ShowDialog();
            ShowTransaction(tbSearch.Text.Trim(), Convert.ToInt32(cmbSorting.SelectedIndex));
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            frmOrderDetail = new OrderDetailsPage();
            this.EvtSendOperation += frmOrderDetail.Receiver;
            this.EvtSendOperation("Edit", dgvTransaction.CurrentRow.Cells["OrderNo"].Value.ToString());
            frmOrderDetail.ShowDialog();
            ShowTransaction(tbSearch.Text.Trim(), Convert.ToInt32(cmbSorting.SelectedIndex));
        }

        private void btnExportTransaction_Click(object sender, EventArgs e)
        {
            #region Generate .csv file
            FolderBrowserDialog fileSelector = new FolderBrowserDialog();
            string timeStamp = DateTime.Now.Date.ToString("ddMMyyyy");
            if (fileSelector.ShowDialog() == DialogResult.OK)
            {
                //string path = string.Format(fileSelector.SelectedPath + @"\销售记录{0}.csv", timeStamp);
                //ExportFile.CreateTransactionFile(path, new TransactionManage().GetTransactionList());
                string path = string.Format(fileSelector.SelectedPath + @"\销售记录{0}.xls", timeStamp);
                ExportFile.ExportToExcel(path, new TransactionManage().GetTransactionList());
            }

            #endregion
            //MessageBox.Show("Generating 销售记录" + timeStamp + ".csv Sucessfully!");
            MessageBox.Show("Generating 销售记录" + timeStamp + ".xls Sucessfully!");
            
        }

    }
}
