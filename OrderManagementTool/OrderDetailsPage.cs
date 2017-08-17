using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OrderManagementTool
{
    public partial class OrderDetailsPage : Form
    {
        #region Initialize variables
        private Order _objOrder = null;
        private List<Item> _objItems = null;
        private string _status = null;
        private string _orderNo = null;

        public delegate void DlgCreateNewOrder(Order objOrder);
        public DlgCreateNewOrder EvtCreateNewOrder;

        #endregion


        public OrderDetailsPage()
        {
            InitializeComponent();
            dgvItemList.AutoGenerateColumns = false;
            // Add key down event
            this.KeyDown += OrderDetailsPage_KeyDown;
            foreach (Control control in this.Controls)
            {
                control.KeyDown += OrderDetailsPage_KeyDown;
            }

            #region Add clear event to all TextBox control, 实现了对相同的控件的统一事件处理 part1

            foreach (Control ctrl in Controls)
            {
                if (ctrl is TextBox)
                {
                    if (!(ctrl.Name.Equals("tbPurchaser") || ctrl.Name.Equals("tbFrom") || ctrl.Name.Equals("tbFromPhone")))
                    {
                        ctrl.Click += new System.EventHandler(this.textBox_Click);
                    }     
                }
            }
            #endregion
        }

        #region 实现了对相同的控件的统一事件处理 part2
        /// <summary>
        /// TextBox click event is used for clearing the box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox textBox = (System.Windows.Forms.TextBox)sender;
            textBox.Text = "";
        }
        #endregion
    
        /// <summary>
        /// 从外部的数据列表中点击进入查看数据详细
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="orderNo"></param>
        public void Receiver(string operation, string orderNo)
        {
            lbError.Visible = false;
            if (operation.Equals("View"))
            {
                _status = "View";
                btnModify.Visible = false;
                btnEditItem.Visible = false;
                btnCreateOrder.Visible = true;
                foreach (Control control in this.Controls)
                {
                    if (control is TextBox)
                    {
                        control.Enabled = false;
                    }
                }
            }
            else if (operation.Equals("Edit"))
            {
                _status = "Edit";
                btnModify.Visible = true;
                btnEditItem.Visible = true;
                tbOrderNo.Enabled = false;
                btnCreateOrder.Visible = false;
            }
            this._orderNo = orderNo;
            ShowOrderDetail(orderNo);
        }

        private void ShowOrderDetail(string orderNo)
        {
            _objOrder = new OrderManage().GetOrderByOrderNo(orderNo);
            tbOrderNo.Text = _objOrder.OrderNo.ToString();
            tbPurchaser.Text = _objOrder.Purchaser;
            tbPurchaser.Enabled = false;
            tbFrom.Text = "Oscar";
            tbFrom.Enabled = false;
            tbFromPhone.Text = "0211376664";
            tbFromPhone.Enabled = false;

            tbTo.Text = _objOrder.User.UserName;
            tbToPhone.Text = _objOrder.User.PhoneNumber;
            tbCardNo.Text = _objOrder.User.CardNo;
            tbAddress.Text = _objOrder.User.Address;

            Transaction objTransaction = new TransactionManage().GetTransactionRecordByOrderNo(orderNo);
            tbPurchasePrice.Text = objTransaction.PurchasePrice.ToString();
            tbSellingPrice.Text = objTransaction.SellingPrice.ToString();
            tbProfit.Text = objTransaction.Profit.ToString();

            _objItems = new ItemManage().GetItemListByOrderNo(orderNo);
            dgvItemList.DataSource = _objItems;
            dgvItemList.Show();
            if (_status.Equals("Edit"))
            {
                string itemNo = dgvItemList.Rows[0].Cells["ItemNo"].Value.ToString(); //get the information in the first row
                Item objItem = new ItemManage().GetItemByItemNo(itemNo);
                tbProductName.Text = objItem.ItemDescription;
                tbQuantity.Text = objItem.Quantity.ToString();
                tbPrice.Text = objItem.UnitPrice.ToString();
            }

        }

        private void dgvItemList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_status.Equals("Edit"))
            {
                string itemNo = dgvItemList.CurrentRow.Cells["ItemNo"].Value.ToString();
                //Item objItem = new ItemManage().GetItemByItemNo(itemNo);
                Item objItem = _objItems.Find(t => t.ItemNo == Convert.ToInt32(itemNo));
                tbProductName.Text = objItem.ItemDescription;
                tbQuantity.Text = objItem.Quantity.ToString();
                tbPrice.Text = objItem.UnitPrice.ToString();
            }
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            //var item =
            //(from t in _objItems
            //    where t.ItemNo == Convert.ToInt32(dgvItemList.CurrentRow.Cells["ItemNo"].Value)
            //    select t).First();


            Item objItem = _objItems.Find(t => t.ItemNo == Convert.ToInt32(dgvItemList.CurrentRow.Cells["ItemNo"].Value));
            objItem.ItemDescription = tbProductName.Text.Trim();
            objItem.Quantity = Convert.ToInt32(tbQuantity.Text.Trim());
            objItem.UnitPrice = Convert.ToDouble(tbPrice.Text.Trim());
            objItem.TotalPrice = objItem.Quantity * objItem.UnitPrice;

            dgvItemList.DataSource = null;
            dgvItemList.DataSource = _objItems;
            dgvItemList.Show();

            //int result = new ItemManage().UpdateItem(objItem);
            //if (result > 0)
            //{
            //    dgvItemList.DataSource = new ItemManage().GetItemListByOrderNo(this.orderNo);
            //    dgvItemList.Show();
            //}
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            _objOrder = new OrderManage().GetOrderByOrderNo(tbOrderNo.Text.Trim());
            _objOrder.Purchaser = tbPurchaser.Text.Trim();
            _objOrder.User = new UserInfoManage().GetUserByOrderNo(tbOrderNo.Text.Trim());
            _objOrder.User.UserName = tbTo.Text.Trim();
            _objOrder.User.PhoneNumber = tbToPhone.Text.Trim();
            _objOrder.User.Address = tbAddress.Text.Trim();
            Transaction objTransaction = new TransactionManage().GetTransactionRecordByOrderNo(tbOrderNo.Text.Trim());
            objTransaction.SellingPrice = Convert.ToDouble(tbSellingPrice.Text.Trim());
            objTransaction.PurchasePrice = Convert.ToDouble(tbPurchasePrice.Text.Trim());
            objTransaction.Profit = objTransaction.SellingPrice - objTransaction.PurchasePrice;
            new TransactionManage().UpdateTransactionRecord(objTransaction);
            new UserInfoManage().UpdatetUser(_objOrder.User);
            foreach (Item objItem in _objItems)
            {
                new ItemManage().UpdateItem(objItem);
            }
            int result = new OrderManage().UpdateOrder(_objOrder);
            if (result > 0)
            {
                MessageBox.Show("Modifying Order Sucessfully!");
                this.Close();
            }
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            OrderCreationPage frmOrderCreation = new OrderCreationPage();
            EvtCreateNewOrder += frmOrderCreation.Receiver;
            EvtCreateNewOrder(_objOrder);
            frmOrderCreation.ShowDialog();
            this.Close();
        }

        private void OrderDetailsPage_KeyDown(object sender, KeyEventArgs e)
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
