using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;
using BLL;
using Utilities;

namespace OrderManagementTool
{
    public partial class OrderManagementTool : Form
    {
        public OrderManagementTool()
        {
            InitializeComponent();
            dgvTransaction.AutoGenerateColumns = false; // prohibit useless column 
            ShowTransaction(tbSearch.Text.Trim(), Convert.ToInt32(cmbSorting.SelectedIndex));
            InitializeSortingList();
            lbVersion.Text = string.Format("Version:{0}\r\nAuthor:{1}",
                Assembly.GetExecutingAssembly().GetName().Version,
                FileVersionInfo.GetVersionInfo(Assembly.GetEntryAssembly().Location).CompanyName);
            tbSearch.Focus();
            // Add key down event
            KeyDown += OrderManagementTool_KeyDown;
            foreach (Control control in Controls)
                control.KeyDown += OrderManagementTool_KeyDown;
        }

        private void InitializeSortingList()
        {
            cmbSorting.Items.Add("OrderNo Asc");
            cmbSorting.Items.Add("OrderNo Desc");
            cmbSorting.Items.Add("Profit Asc");
            cmbSorting.Items.Add("Profit Desc");
            cmbSorting.SelectedIndex = 1;
        }

        /// <summary>
        ///     Import the existed data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenDataImporter_Click(object sender, EventArgs e)
        {
            _frmDataImporting = new DataImportingPage();
            _frmDataImporting.ShowDialog();
            ShowTransaction(tbSearch.Text.Trim(), Convert.ToInt32(cmbSorting.SelectedIndex));
        }

        /// <summary>
        ///     create the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            _frmOrderCreation = new OrderCreationPage();
            _frmOrderCreation.ShowDialog();
            ShowTransaction(tbSearch.Text.Trim(), Convert.ToInt32(cmbSorting.SelectedIndex));
        }

        /// <summary>
        ///     view undone orders
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUndoneOrders_Click(object sender, EventArgs e)
        {
            // 添加检查是否存在未完成的订单
            var objLists = new TransactionManage().GetUndoneTransactionList();
            if (objLists.Count == 0)
            {
                MessageBox.Show("No undone orders!", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _frmUndoneOrders = new UndoneOrdersPage();
                _frmUndoneOrders.ShowDialog();
                ShowTransaction(tbSearch.Text.Trim(), Convert.ToInt32(cmbSorting.SelectedIndex));
            }
        }

        /// <summary>
        ///     search purchaser
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
                TotalProfit += Convert.ToDouble(dgvTransactionRow.Cells["Profit"].Value);
            lbTotalProfit.Text = "The total profit: " + TotalProfit;

            #endregion

            dgvTransaction.Show();
        }

        private void cmbSorting_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowTransaction(tbSearch.Text.Trim(), Convert.ToInt32(cmbSorting.SelectedIndex));
        }

        /// <summary>
        ///     view details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDetail_Click(object sender, EventArgs e)
        {
            _frmOrderDetail = new OrderDetailsPage();
            EvtSendOperation += _frmOrderDetail.Receiver;
            EvtSendOperation("View", dgvTransaction.CurrentRow.Cells["OrderNo"].Value.ToString());
            _frmOrderDetail.ShowDialog();
            //ShowTransaction(tbSearch.Text.Trim(), Convert.ToInt32(cmbSorting.SelectedIndex));
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            _frmOrderDetail = new OrderDetailsPage();
            EvtSendOperation += _frmOrderDetail.Receiver;
            EvtSendOperation("Edit", dgvTransaction.CurrentRow.Cells["OrderNo"].Value.ToString());
            _frmOrderDetail.ShowDialog();
            //ShowTransaction(tbSearch.Text.Trim(), Convert.ToInt32(cmbSorting.SelectedIndex));
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Delete?", "Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.Yes)
            {
                var orderNo = dgvTransaction.CurrentRow.Cells["OrderNo"].Value.ToString();

                var objOrder = new OrderManage().GetOrderByOrderNo(orderNo);
                objOrder.User = new UserInfoManage().GetUserByOrderNo(orderNo);
                new TransactionManage().DeleteTransactionRecord(orderNo);
                new ItemManage().DeleteItemListByOrderNo(orderNo);
                new OrderManage().DeleteOrder(objOrder);
                var result = new UserInfoManage().DeleteUser(objOrder.User);
                if (result > 0)
                    MessageBox.Show("Delete data sucessfully!");

                ShowTransaction(tbSearch.Text.Trim(), Convert.ToInt32(cmbSorting.SelectedIndex));
            }
        }

        private void btnPriceKit_Click(object sender, EventArgs e)
        {
            _frmPriceKit = new CalculatePriceKitPage();
            _frmPriceKit.Show();
            //btnPriceKit.Enabled = false;
        }

        private void dgvTransaction_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _frmOrderDetail = new OrderDetailsPage();
            EvtSendOperation += _frmOrderDetail.Receiver;
            EvtSendOperation("View", dgvTransaction.CurrentRow.Cells["OrderNo"].Value.ToString());
            _frmOrderDetail.ShowDialog();
        }

        private void OrderManagementTool_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    ShowTransaction(tbSearch.Text.Trim(), Convert.ToInt32(cmbSorting.SelectedIndex));
                    break;
                case Keys.Escape:
                    Close();
                    break;

                default:
                    break;
            }
        }

        private void btnOrderText_Click(object sender, EventArgs e)
        {
            var fileSelector = new FolderBrowserDialog();
            fileSelector.Description = @"Please choose the folder that stores order text:";
            var defaultPath = ExportFile.GetDefaultPath("dircPath");
            if (defaultPath != "")
                fileSelector.SelectedPath = defaultPath;
            if (fileSelector.ShowDialog() == DialogResult.OK)
            {
                var filename = string.Format(fileSelector.SelectedPath + @"\{0}{1}.txt",
                    dgvTransaction.CurrentRow.Cells["OrderNo"].Value,
                    dgvTransaction.CurrentRow.Cells["Purchaser"].Value); // Get the file name
                _frmOrderText = new FrmOrderText();
                EvtSetOrderText += _frmOrderText.Receiver;
                EvtSetOrderText(ExportFile.ReadOrderFile(filename));
                _frmOrderText.ShowDialog();
            }
        }

        private void tbSearch_Click(object sender, EventArgs e)
        {
            if (tbSearch.Text != "")
                tbSearch.Text = "";
        }

        #region Variable declaration

        private DataImportingPage _frmDataImporting;
        private OrderCreationPage _frmOrderCreation;
        private UndoneOrdersPage _frmUndoneOrders;
        private OrderDetailsPage _frmOrderDetail;
        private CalculatePriceKitPage _frmPriceKit;
        private FrmOrderText _frmOrderText;

        #region Delegate for opening the edit order and the view order

        // define delegate
        public delegate void DlgSendOperation(string operation, string orderNo);

        // create an event. that is delegate variables
        public event DlgSendOperation EvtSendOperation;

        #endregion

        #region Delegate for view the order text

        public delegate void DlgSetOrderText(string content);

        public event DlgSetOrderText EvtSetOrderText;

        #endregion

        #endregion
    }
}