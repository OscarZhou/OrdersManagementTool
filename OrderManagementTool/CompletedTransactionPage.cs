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
            if (objTransaction.SellingPrice != 0.0)
            {
                tbSellingPrice.Text = objTransaction.SellingPrice.ToString();
                tbPurchasingPrice.Focus();
            }
            
            if (objTransaction.PurchasePrice != 0.0)
            {
                tbPurchasingPrice.Text = objTransaction.PurchasePrice.ToString();
                tbProfit.Focus();
            }
            
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
            //if (tbSellingPrice.Text == "" && tbPurchasingPrice.Text == "")
            //{
            //    lbError.Text = "Please fill the blanks!";
            //    lbError.Visible = true;
            //    tbSellingPrice.BackColor = System.Drawing.Color.LightCoral;
            //    tbPurchasingPrice.BackColor = System.Drawing.Color.LightCoral;
            //    return;
            //}
            //else if (tbSellingPrice.Text == "")
            //{
            //    lbError.Text = "Please input Selling Price";
            //    lbError.Visible = true;
            //    tbSellingPrice.BackColor = System.Drawing.Color.LightCoral;
            //}
            //else if (tbPurchasingPrice.Text == "")
            //{
            //    lbError.Text = "Please input Purchasing Price";
            //    lbError.Visible = true;
            //    tbPurchasingPrice.BackColor = System.Drawing.Color.LightCoral;
            //}

            #endregion

            #region Update price

            if (lbError.Visible == false)
            {
                if (tbSellingPrice.Text.Length != 0)
                {
                    objTransaction.SellingPrice = Convert.ToDouble(tbSellingPrice.Text.Trim());
                }
                if (tbPurchasingPrice.Text.Length != 0 )
                {
                    objTransaction.PurchasePrice = Convert.ToDouble(tbPurchasingPrice.Text.Trim());
                }
                objTransaction.Profit = objTransaction.SellingPrice - objTransaction.PurchasePrice;
                if (tbSellingPrice.Text.Length != 0 && tbPurchasingPrice.Text.Length != 0)
                {
                    objTransaction.OrderStatus = Convert.ToByte(true);
                }

                int result = new TransactionManage().UpdateTransactionRecord(objTransaction);
                if (result > 0)
                {
                    MessageBox.Show("Updating Sucessfully!");
                }
            }
            else
            {
                lbError.Text = "You can't submit before solving the error!";
                return;
            }

            #endregion

            this.Close();
        }

        private void tbSellingPrice_Leave(object sender, EventArgs e)
        {
            int result;
            if (int.TryParse(tbSellingPrice.Text.Trim(), out result) == false)
            {
                lbError.Text = "Please input numbers";
                lbError.Visible = true;
                tbSellingPrice.BackColor = System.Drawing.Color.LightCoral;
                return;
            }
            else
            {
                lbError.Visible = false;
                tbSellingPrice.BackColor = System.Drawing.Color.White;
            }

            if (int.TryParse(tbPurchasingPrice.Text.Trim(), out result) == false)
            {
                lbError.Text = "Please input numbers";
                lbError.Visible = true;
                tbPurchasingPrice.BackColor = System.Drawing.Color.LightCoral;
                return;
            }
            else
            {
                lbError.Visible = false;
                tbPurchasingPrice.BackColor = System.Drawing.Color.White;
            }


            if (tbSellingPrice.Text.Trim().Length == 0 || tbPurchasingPrice.Text.Trim().Length == 0)
            {
                return;
            }
            else if (tbSellingPrice.Text.Length != 0 && tbPurchasingPrice.Text.Length != 0)
            {
                tbProfit.Text = (Convert.ToDouble(tbSellingPrice.Text.Trim()) -
                                Convert.ToDouble(tbPurchasingPrice.Text.Trim())).ToString();                
            }
        }

        private void tbPurchasingPrice_Leave(object sender, EventArgs e)
        {
            int result;
            if (int.TryParse(tbSellingPrice.Text.Trim(), out result) == false)
            {
                lbError.Text = "Please input numbers";
                lbError.Visible = true;
                tbSellingPrice.BackColor = System.Drawing.Color.LightCoral;
                return;
            }
            else
            {
                lbError.Visible = false;
                tbSellingPrice.BackColor = System.Drawing.Color.White;
            }

            if (int.TryParse(tbPurchasingPrice.Text.Trim(), out result) == false)
            {
                lbError.Text = "Please input numbers";
                lbError.Visible = true;
                tbPurchasingPrice.BackColor = System.Drawing.Color.LightCoral;
                return;
            }
            else
            {
                lbError.Visible = false;
                tbPurchasingPrice.BackColor = System.Drawing.Color.White;
            }

            if (tbSellingPrice.Text.Trim().Length == 0 || tbPurchasingPrice.Text.Trim().Length == 0)
            {
                return;
            }
            else if (tbSellingPrice.Text.Length != 0 && tbPurchasingPrice.Text.Length != 0)
            {
                tbProfit.Text = (Convert.ToDouble(tbSellingPrice.Text.Trim()) -
                                Convert.ToDouble(tbPurchasingPrice.Text.Trim())).ToString();
            }
        }

    }
}
