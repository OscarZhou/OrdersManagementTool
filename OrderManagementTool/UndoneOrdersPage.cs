﻿using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OrderManagementTool
{
    public partial class UndoneOrdersPage : Form
    {
        private CompletedTransactionPage _frmCompletedTransactionPage;
        private OrderDetailsPage _frmOrderDetail;

        // define delegate
        public delegate void DlgGetObjTransaction(string orderNo);
        // create an event. that is delegate variables
        public event DlgGetObjTransaction EvtGetObjTransaction;


        // define delegate
        public delegate void DlgSendOperation(string operation, string orderNo);
        // create an event. that is delegate variables
        public event DlgSendOperation EvtSendOperation;

        
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
            List<Transaction> objLists = new TransactionManage().GetUndoneTransactionList();
            if (objLists.Count == 0)
            {
                this.Close();
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

        /// <summary>
        /// double click item to check the information of the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvUndoneOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string orderNo = dgvUndoneOrders.CurrentRow.Cells["OrderNo"].Value.ToString();
            _frmOrderDetail = new OrderDetailsPage();
            this.EvtSendOperation += _frmOrderDetail.Receiver;
            this.EvtSendOperation("View", orderNo);
            _frmOrderDetail.ShowDialog();
        }


    }
}
