using System;
using System.Windows.Forms;
using BLL;

namespace OrderManagementTool
{
    public partial class UndoneOrdersPage : Form
    {
        // define delegate
        public delegate void DlgGetObjTransaction(string orderNo);


        // define delegate
        public delegate void DlgSendOperation(string operation, string orderNo);

        private CompletedTransactionPage _frmCompletedTransactionPage;
        private OrderDetailsPage _frmOrderDetail;


        public UndoneOrdersPage()
        {
            InitializeComponent();
            dgvUndoneOrders.AutoGenerateColumns = false;
            ShowUndoneOrder();
            // Add key down event
            KeyDown += UndoneOrdersPage_KeyDown;
            foreach (Control control in Controls)
                control.KeyDown += UndoneOrdersPage_KeyDown;
        }

        // create an event. that is delegate variables
        public event DlgGetObjTransaction EvtGetObjTransaction;
        // create an event. that is delegate variables
        public event DlgSendOperation EvtSendOperation;

        public void ShowUndoneOrder()
        {
            var objLists = new TransactionManage().GetUndoneTransactionList();
            if (objLists.Count == 0)
            {
                Close();
            }
            else
            {
                dgvUndoneOrders.DataSource = objLists;
                dgvUndoneOrders.Show();
            }
        }

        private void btnCompleteOrder_Click(object sender, EventArgs e)
        {
            _frmCompletedTransactionPage = new CompletedTransactionPage();
            // create an instance of the delegate
            EvtGetObjTransaction += _frmCompletedTransactionPage.Receiver;
            if (EvtGetObjTransaction != null)
                EvtGetObjTransaction(dgvUndoneOrders.CurrentRow.Cells["OrderNo"].Value.ToString());
            _frmCompletedTransactionPage.ShowDialog();

            ShowUndoneOrder();
        }

        private void UndoneOrdersPage_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    break;
                case Keys.Escape:
                    Close();
                    break;

                default:
                    break;
            }
        }

        /// <summary>
        ///     double click item to check the information of the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvUndoneOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var orderNo = dgvUndoneOrders.CurrentRow.Cells["OrderNo"].Value.ToString();
            _frmOrderDetail = new OrderDetailsPage();
            EvtSendOperation += _frmOrderDetail.Receiver;
            EvtSendOperation("View", orderNo);
            _frmOrderDetail.ShowDialog();
        }
    }
}