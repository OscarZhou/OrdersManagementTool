﻿using BLL;
using System;
using System.Windows.Forms;

namespace OrderManagementTool
{
    public partial class UndoneOrdersPage : Form
    {
        // define delegate
        public delegate void DlgGetObjTransaction(string orderNo);


        // define delegate
        public delegate void DlgOpenInnerView(string orderNo, Control parentControl);

        private CompletedTransactionPage _frmCompletedTransactionPage;
        private OrderDetailsPage _frmOrderDetail;
        private Control _parentContainer;


        public UndoneOrdersPage()
        {
            InitializeComponent();
            dgvUndoneOrders.AutoGenerateColumns = false;

            // Add key down event
            KeyDown += UndoneOrdersPage_KeyDown;
            foreach (Control control in Controls)
                control.KeyDown += UndoneOrdersPage_KeyDown;
        }

        // create an event. that is delegate variables
        public event DlgGetObjTransaction EvtGetObjTransaction;
        // create an event. that is delegate variables
        public event DlgOpenInnerView EvtSendOperation;

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
            EvtSendOperation += _frmOrderDetail.ViewReceiver;
            EvtSendOperation(orderNo, _parentContainer);
            OpenNewForm(_frmOrderDetail);
        }

        #region Receiver operation corresponding from the main interface

        public void Receiver(Control parentControl)
        {
            ShowUndoneOrder();
            _parentContainer = parentControl;
        }

        #endregion

        #region Window operation

        private void OpenNewForm(Form newFrm)
        {
            // Close other embeded windows
            foreach (Control item in _parentContainer.Controls)
                if (item is Form)
                    ((Form) item).Close();

            // Open and attach the new window
            newFrm.TopLevel = false;
            newFrm.Parent = _parentContainer;
            newFrm.Dock = DockStyle.Fill;
            newFrm.Show();
        }

        /// <summary>
        ///     Open or Close the elements in main window
        /// </summary>
        /// <param name="mainFrmState"></param>
        private void DisplayMainFrm(bool mainFrmState)
        {
            //MessageBox.Show("width:" + this.splitContainer.Panel1.Size.Width + ",height:" +
            //                this.splitContainer.Panel1.Size.Height);

            // Close other embeded windows
            foreach (Control item in _parentContainer.Controls)
            {
                if (item is Form)
                    ((Form) item).Close();
                item.Visible = mainFrmState;
            }
        }

        #endregion
    }
}