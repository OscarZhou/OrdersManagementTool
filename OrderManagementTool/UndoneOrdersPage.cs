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
            // Add key down event
            this.KeyDown += UndoneOrdersPage_KeyDown;
            foreach (Control control in this.Controls)
            {
                control.KeyDown += UndoneOrdersPage_KeyDown;
            }
        }

        public void ShowUndoneOrder()
        {
            dgvUndoneOrders.DataSource = new TransactionManage().GetUndoneTransactionList();
            dgvUndoneOrders.Show();

            if (dgvUndoneOrders.DataSource == null)
            {
                this.Close();
            }
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

        private void UndoneOrdersPage_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    break;
                case Keys.Escape:
                    this.Close();
                    break;

                default:
                    break;
            }
        }


    }
}
