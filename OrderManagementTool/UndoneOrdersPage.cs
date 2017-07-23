using BLL;
using System;
using System.Windows.Forms;

namespace OrderManagementTool
{
    public partial class UndoneOrdersPage : Form
    {
        private CompletedTransactionPage _frmCompletedTransactionPage;

        // define delegate
        public delegate void DlgGetObjTransaction(string orderNo);
        // create an event. that is delegate variables
        public event DlgGetObjTransaction EvtGetObjTransaction;



        
        public UndoneOrdersPage()
        {
            InitializeComponent();
            this.dgvUndoneOrders.AutoGenerateColumns = false;
            ShowUndoneOrder();
        }

        public void ShowUndoneOrder()
        {
            dgvUndoneOrders.DataSource = new TransactionManage().GetUndoneTransactionList();
            dgvUndoneOrders.Show();
        }

        private void btnCompleteOrder_Click(object sender, EventArgs e)
        {
            _frmCompletedTransactionPage = new CompletedTransactionPage();
            // create an instance of the delegate
            this.EvtGetObjTransaction += _frmCompletedTransactionPage.Receiver;
            if (this.EvtGetObjTransaction != null)
            {
                this.EvtGetObjTransaction(dgvUndoneOrders.CurrentRow.Cells["OrderNo"].Value.ToString());
            }
            _frmCompletedTransactionPage.ShowDialog();

            ShowUndoneOrder();
        }

    }
}
