using BLL;
using Models;
using System;
using System.Windows.Forms;

namespace OrderManagementTool
{
    public partial class CompletedTransactionPage : Form
    {
        private int _orderNo;
        private Transaction objTransaction;
    
        public CompletedTransactionPage()
        {
            InitializeComponent();
            lbError.Visible = false;
            lbError.ForeColor = System.Drawing.Color.Red;
        }

        private void ShowTransaction()
        {
            objTransaction = new TransactionManage().GetTransactionRecordByOrderNo(this._orderNo);
            tbOrderNo.Text = objTransaction.OrderNo.ToString();
            tbPurchaser.Text = objTransaction.Purchaser;
            //tbSellingPrice.Text = objTransaction.SellingPrice.ToString();
            //tbPurchasingPrice.Text = objTransaction.PurchasePrice.ToString();
            //tbProfit.Text = objTransaction.Profit.ToString();

        }

        /// <summary>
        /// delegate method
        /// </summary>
        /// <param name="OrderNo"></param>
        public void Receiver(string OrderNo)
        {
            this._orderNo = Convert.ToInt32(OrderNo);
            ShowTransaction();
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            #region Validation for Transaction
            if (tbSellingPrice.Text == "" && tbPurchasingPrice.Text == "")
            {
                lbError.Text = "Please fill the blanks!";
                lbError.Visible = true;
                tbSellingPrice.BackColor = System.Drawing.Color.LightCoral;
                tbPurchasingPrice.BackColor = System.Drawing.Color.LightCoral;
                return;
            }
            else if (tbSellingPrice.Text == "")
            {
                lbError.Text = "Please input Selling Price";
                lbError.Visible = true;
                tbSellingPrice.BackColor = System.Drawing.Color.LightCoral;
            }
            else if (tbPurchasingPrice.Text == "")
            {
                lbError.Text = "Please input Purchasing Price";
                lbError.Visible = true;
                tbPurchasingPrice.BackColor = System.Drawing.Color.LightCoral;
            } 
            #endregion

            #region Update price

            objTransaction.SellingPrice = Convert.ToDouble(tbSellingPrice.Text.Trim());
            objTransaction.PurchasePrice = Convert.ToDouble(tbPurchasingPrice.Text.Trim());
            objTransaction.Profit = objTransaction.SellingPrice - objTransaction.PurchasePrice;
            objTransaction.OrderStatus = Convert.ToByte(true);

            int result = new TransactionManage().UpdateTransactionRecord(objTransaction);
            if (result > 0)
            {
                MessageBox.Show("Updating Sucessfully!");
            }

            #endregion

            this.Close();
        }

        private void tbSellingPrice_Leave(object sender, EventArgs e)
        {
            if (tbPurchasingPrice.Text == "")
            {
                //tbProfit.Text = (Convert.ToDouble(tbSellingPrice.Text.Trim()) - 0).ToString();
                return;
            }
            else if (tbSellingPrice.Text == "")
            {
                return;
            }
            else
            {
                tbProfit.Text = (Convert.ToDouble(tbSellingPrice.Text.Trim()) -
                                Convert.ToDouble(tbPurchasingPrice.Text.Trim())).ToString();                
            }
        }

        private void tbPurchasingPrice_Leave(object sender, EventArgs e)
        {
            if (tbSellingPrice.Text == "")
            {
                //tbProfit.Text = (0 - Convert.ToDouble(tbPurchasingPrice.Text.Trim())).ToString();
                return;
            }
            else if (tbPurchasingPrice.Text == "")
            {
                return;
            }
            else
            {
                tbProfit.Text = (Convert.ToDouble(tbSellingPrice.Text.Trim()) -
                                Convert.ToDouble(tbPurchasingPrice.Text.Trim())).ToString();
            }
        }



    }
}
