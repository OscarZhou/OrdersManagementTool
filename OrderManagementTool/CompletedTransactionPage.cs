using BLL;
using Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace OrderManagementTool
{
    public partial class CompletedTransactionPage : Form
    {
        private string _orderNo;
        private Transaction objTransaction;
    
        public CompletedTransactionPage()
        {
            InitializeComponent();
            lbError.Visible = false;
            lbError.ForeColor = System.Drawing.Color.Red;
            // Add key down event
            this.KeyDown += CompletedTransactionPage_KeyDown;
            foreach (Control control in this.Controls)
            {
                control.KeyDown += CompletedTransactionPage_KeyDown;
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

        private void ShowTransaction()
        {
            objTransaction = new TransactionManage().GetTransactionRecordByOrderNo(this._orderNo);
            tbOrderNo.Text = objTransaction.OrderNo.ToString();
            tbPurchaser.Text = objTransaction.Purchaser;

            #region 从数据库读取价钱值，如果值不为0，显示其值，如果为0，则使其为空

            if (!objTransaction.SellingPrice.ToString().Equals("0"))
            {
                tbSellingPrice.Text = objTransaction.SellingPrice.ToString();
                tbPurchasingPrice.Focus();                
            }
            if (!objTransaction.PurchasePrice.ToString().Equals("0"))
            {
                tbPurchasingPrice.Text = objTransaction.PurchasePrice.ToString();
                tbProfit.Focus();
            }

            #endregion

            //tbProfit.Text = objTransaction.Profit.ToString();

        }

        #region The validation of inputing text

        private void ShowError(string tips, TextBox tbBox, Label lbError)
        {
            lbError.Text = tips;
            lbError.Visible = true;
            tbBox.Text = "";
            tbBox.BackColor = System.Drawing.Color.LightCoral;
            tbBox.Focus();
        }

        private void HideError(TextBox tbBox, Label lbError)
        {
            lbError.Visible = false;
            tbBox.BackColor = System.Drawing.Color.White;
        }

        #endregion

        #region Receiver operation
        /// <summary>
        /// delegate method
        /// </summary>
        /// <param name="OrderNo"></param>
        public void Receiver(string OrderNo)
        {
            this._orderNo = OrderNo;
            ShowTransaction();
        }

        #endregion

        private void btnOkay_Click(object sender, EventArgs e)
        {
            #region Validation for Transaction

            if (tbSellingPrice.Text.Trim().Length == 0)
            {
                this.ShowError("Please fill the blank before submitting", tbSellingPrice, lbError);
                return;
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(tbSellingPrice.Text, "[^0-9]"))
            {
                this.ShowError("Please input only number", tbSellingPrice, lbError);
                return;
            }
            else
            {
                this.HideError(tbSellingPrice, lbError);
            }

            if (tbPurchasingPrice.Text.Trim().Length == 0)
            {
                this.ShowError("Please fill the blank before submitting", tbPurchasingPrice, lbError);
                return;
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(tbPurchasingPrice.Text, "[^0-9]"))
            {
                this.ShowError("Please input only number", tbPurchasingPrice, lbError);
                return;
            }
            else
            {
                this.HideError(tbPurchasingPrice, lbError);
            }

            #endregion

            #region Update price

            tbProfit.Text = (Convert.ToDouble(tbSellingPrice.Text.Trim()) - Convert.ToDouble(tbPurchasingPrice.Text.Trim())).ToString();
            objTransaction.SellingPrice = Convert.ToDouble(tbSellingPrice.Text.Trim());
            objTransaction.PurchasePrice = Convert.ToDouble(tbPurchasingPrice.Text.Trim());
            objTransaction.Profit = Convert.ToDouble(tbProfit.Text);
            if (tbSellingPrice.Text.Length != 0 && tbPurchasingPrice.Text.Length != 0)
            {
                objTransaction.OrderStatus = Convert.ToByte(true);
            }
            int result = new TransactionManage().UpdateTransactionRecord(objTransaction);
            if (result > 0)
            {
                MessageBox.Show("Updating Sucessfully!");
            }

            #endregion

            this.Close();
        }


        #region Leave event is used for calculating the profit

        private void tbSellingPrice_Leave(object sender, EventArgs e)
        {
            // When the blank is filled with numbers, the profit will be calculated. Otherwise, nothing will be done.
            if (System.Text.RegularExpressions.Regex.IsMatch(tbSellingPrice.Text, "[^0-9]") && System.Text.RegularExpressions.Regex.IsMatch(tbPurchasingPrice.Text, "[^0-9]"))
            {
                tbProfit.Text = (Convert.ToDouble(tbSellingPrice.Text.Trim()) - Convert.ToDouble(tbPurchasingPrice.Text.Trim())).ToString();
            }

        }

        private void tbPurchasingPrice_Leave(object sender, EventArgs e)
        {
            // When the blank is filled with numbers, the profit will be calculated. Otherwise, nothing will be done.
            if (System.Text.RegularExpressions.Regex.IsMatch(tbSellingPrice.Text, "[^0-9]") && System.Text.RegularExpressions.Regex.IsMatch(tbPurchasingPrice.Text, "[^0-9]"))
            {
                tbProfit.Text = (Convert.ToDouble(tbSellingPrice.Text.Trim()) - Convert.ToDouble(tbPurchasingPrice.Text.Trim())).ToString();
            }

        }
        #endregion


        private void CompletedTransactionPage_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    #region Update price

                    if (lbError.Visible == false)
                    {
                        if (tbSellingPrice.Text.Length != 0)
                        {
                            objTransaction.SellingPrice = Convert.ToDouble(tbSellingPrice.Text.Trim());
                        }
                        if (tbPurchasingPrice.Text.Length != 0)
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
                    break;
                case Keys.Escape:
                    this.Close();
                    break;

                default:
                    break;
            }
        }

        #region Drag and close window

        private Point mouseOff; //The moving position variables of the mouse
        private bool leftFlag; // Determine if the label is left button
        private void lbLogo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y);  // Get the values of the variable
                leftFlag = true;
            }
        }

        private void lbLogo_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mousetSet = Control.MousePosition;
                mousetSet.Offset(mouseOff.X, mouseOff.Y);   // Set the position after moving
                Location = mousetSet;
            }
        }

        private void lbLogo_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false; // Set false after releasing mouse
            }
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y);  // Get the values of the variable
                leftFlag = true;
            }
        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mousetSet = Control.MousePosition;
                mousetSet.Offset(mouseOff.X, mouseOff.Y);   // Set the position after moving
                Location = mousetSet;
            }
        }

        private void panelTop_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false; // Set false after releasing mouse
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
