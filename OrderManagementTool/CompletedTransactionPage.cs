using BLL;
using Models;
using System;
using System.Drawing;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace OrderManagementTool
{
    public partial class CompletedTransactionPage : Form
    {
        private string _orderNo;
        private Transaction objTransaction;
        private bool zh;

        public CompletedTransactionPage()
        {
            InitializeComponent();
            CultureInfo ci = Thread.CurrentThread.CurrentUICulture;
            zh = ci.Name.Equals("zh-CHS") ? true : false;

            lbError.Visible = false;
            lbError.ForeColor = Color.Red;
            // Add key down event
            KeyDown += CompletedTransactionPage_KeyDown;
            foreach (Control control in Controls)
                control.KeyDown += CompletedTransactionPage_KeyDown;

            #region Add clear event to all TextBox control, 实现了对相同的控件的统一事件处理 part1

            foreach (Control ctrl in Controls)
                if (ctrl is TextBox)
                    if (
                        !(ctrl.Name.Equals("tbPurchaser") || ctrl.Name.Equals("tbFrom") ||
                          ctrl.Name.Equals("tbFromPhone")))
                        ctrl.Click += textBox_Click;

            #endregion
        }

        #region 实现了对相同的控件的统一事件处理 part2

        /// <summary>
        ///     TextBox click event is used for clearing the box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_Click(object sender, EventArgs e)
        {
            var textBox = (TextBox) sender;
            textBox.Text = "";
        }

        #endregion

        private void ShowTransaction()
        {
            objTransaction = new TransactionManage().GetTransactionRecordByOrderNo(_orderNo);
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

        #region Receiver operation

        /// <summary>
        ///     delegate method
        /// </summary>
        /// <param name="OrderNo"></param>
        public void Receiver(string OrderNo)
        {
            _orderNo = OrderNo;
            ShowTransaction();
        }

        #endregion

        private void btnOkay_Click(object sender, EventArgs e)
        {
            #region Validation for Transaction

            if (tbSellingPrice.Text.Trim().Length == 0)
            {
                ShowError(zh?"在关闭订单前，请输入售价":"Please fill the selling price before submitting", tbSellingPrice, lbError);
                return;
            }
            if (Regex.IsMatch(tbSellingPrice.Text, "[^0-9]")) //区分不是字母，而是数字
                if (!Regex.IsMatch(tbSellingPrice.Text, @"^(-?\d+)(\.\d+)?$"))
                {
                    //不是小数
                    ShowError(zh?"只允许输入数字":"Please input only number", tbSellingPrice, lbError);
                    return;
                }
                else
                {
                    HideError(tbSellingPrice, lbError);
                    lbError.Text = tbSellingPrice.Text.Trim();
                }
            else
                HideError(tbSellingPrice, lbError);


            if (tbPurchasingPrice.Text.Trim().Length == 0)
            {
                ShowError(zh?"在关闭订单前，请输入进价":"Please fill the purchasing price before submitting", tbPurchasingPrice, lbError);
                return;
            }
            if (Regex.IsMatch(tbPurchasingPrice.Text, "[^0-9]")) //区分不是字母，而是数字
                if (!Regex.IsMatch(tbPurchasingPrice.Text, @"^(-?\d+)(\.\d+)?$"))
                {
                    //不是小数
                    ShowError(zh?"只允许输入数字":"Please input only number", tbPurchasingPrice, lbError);
                    return;
                }
                else
                {
                    HideError(tbPurchasingPrice, lbError);
                    lbError.Text = tbPurchasingPrice.Text.Trim();
                }
            else
                HideError(tbPurchasingPrice, lbError);

            #endregion

            #region Update price

            tbProfit.Text =
                (Convert.ToDouble(tbSellingPrice.Text.Trim()) - Convert.ToDouble(tbPurchasingPrice.Text.Trim()))
                .ToString();
            objTransaction.SellingPrice = Convert.ToDouble(tbSellingPrice.Text.Trim());
            objTransaction.PurchasePrice = Convert.ToDouble(tbPurchasingPrice.Text.Trim());
            objTransaction.Profit = Convert.ToDouble(tbProfit.Text);
            if (tbSellingPrice.Text.Length != 0 && tbPurchasingPrice.Text.Length != 0)
                objTransaction.OrderStatus = Convert.ToByte(true);
            var result = new TransactionManage().UpdateTransactionRecord(objTransaction);
            if (result > 0)
                MessageBox.Show(zh?"更新成功！":"Updating Sucessfully!");

            #endregion

            Close();
        }


        private void CompletedTransactionPage_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:

                    #region Update price

                    if (lbError.Visible == false)
                    {
                        if (tbSellingPrice.Text.Length != 0)
                            objTransaction.SellingPrice = Convert.ToDouble(tbSellingPrice.Text.Trim());
                        if (tbPurchasingPrice.Text.Length != 0)
                            objTransaction.PurchasePrice = Convert.ToDouble(tbPurchasingPrice.Text.Trim());
                        objTransaction.Profit = objTransaction.SellingPrice - objTransaction.PurchasePrice;
                        if (tbSellingPrice.Text.Length != 0 && tbPurchasingPrice.Text.Length != 0)
                            objTransaction.OrderStatus = Convert.ToByte(true);

                        var result = new TransactionManage().UpdateTransactionRecord(objTransaction);
                        if (result > 0)
                            MessageBox.Show(zh?"更新成功！":"Updating Sucessfully!");
                    }
                    else
                    {
                        lbError.Text = zh?"在解决问题前，不能关闭订单":"You can't submit before solving the error!";
                        return;
                    }

                    #endregion

                    Close();
                    break;
                case Keys.Escape:
                    Close();
                    break;

                default:
                    break;
            }
        }

        #region The validation of inputing text

        private void ShowError(string tips, TextBox tbBox, Label lbError)
        {
            lbError.Text = tips;
            lbError.Visible = true;
            tbBox.Text = "";
            tbBox.BackColor = Color.LightCoral;
            tbBox.Focus();
        }

        private void HideError(TextBox tbBox, Label lbError)
        {
            lbError.Visible = false;
            tbBox.BackColor = Color.White;
        }

        #endregion

        #region Leave event is used for calculating the profit

        private void tbSellingPrice_Leave(object sender, EventArgs e)
        {
            // When the blank is filled with numbers, the profit will be calculated. Otherwise, nothing will be done.
            if (Regex.IsMatch(tbSellingPrice.Text, "[^0-9]") && Regex.IsMatch(tbPurchasingPrice.Text, "[^0-9]"))
                tbProfit.Text =
                    (Convert.ToDouble(tbSellingPrice.Text.Trim()) - Convert.ToDouble(tbPurchasingPrice.Text.Trim()))
                    .ToString();
        }

        private void tbPurchasingPrice_Leave(object sender, EventArgs e)
        {
            // When the blank is filled with numbers, the profit will be calculated. Otherwise, nothing will be done.
            if (Regex.IsMatch(tbSellingPrice.Text, "[^0-9]") && Regex.IsMatch(tbPurchasingPrice.Text, "[^0-9]"))
                tbProfit.Text =
                    (Convert.ToDouble(tbSellingPrice.Text.Trim()) - Convert.ToDouble(tbPurchasingPrice.Text.Trim()))
                    .ToString();
        }

        #endregion

        #region Drag and close window

        private Point mouseOff; //The moving position variables of the mouse
        private bool leftFlag; // Determine if the label is left button

        private void lbLogo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); // Get the values of the variable
                leftFlag = true;
            }
        }

        private void lbLogo_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                var mousetSet = MousePosition;
                mousetSet.Offset(mouseOff.X, mouseOff.Y); // Set the position after moving
                Location = mousetSet;
            }
        }

        private void lbLogo_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
                leftFlag = false; // Set false after releasing mouse
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); // Get the values of the variable
                leftFlag = true;
            }
        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                var mousetSet = MousePosition;
                mousetSet.Offset(mouseOff.X, mouseOff.Y); // Set the position after moving
                Location = mousetSet;
            }
        }

        private void panelTop_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
                leftFlag = false; // Set false after releasing mouse
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion
    }
}