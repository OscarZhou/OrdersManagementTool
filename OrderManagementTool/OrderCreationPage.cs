using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Utilities;

namespace OrderManagementTool
{
    public partial class OrderCreationPage : Form
    {
        private readonly List<Item> _objItems = new List<Item>();
        private CalculatePriceKitPage _frmPriceKit;
        private string crtOrderNo;
        private string purchaserName;

        public OrderCreationPage()
        {
            InitializeComponent();
            SetControls();
            // Add key down event
            KeyDown += OrderCreationPage_KeyDown;
            foreach (Control control in Controls)
                control.KeyDown += OrderCreationPage_KeyDown;
        }

        private void SetControls()
        {
            lbItemError.Visible = false;
            lbUserError.Visible = false;
            dgvItemList.AutoGenerateColumns = false;
            chkLock.Checked = true;
            tbFrom.Enabled = false;
            tbFromPhone.Enabled = false;
            lbUserError.ForeColor = Color.Red;
            lbItemError.ForeColor = Color.Red;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            #region Validation for items

            if (tbItemDescription.Text.Length == 0 && tbQuantity.Text.Length == 0 && tbPrice.Text.Length == 0)
            {
                ShowError("Please fill blank!", tbItemDescription, lbItemError);
                ShowError("Please fill blank!", tbQuantity, lbItemError);
                ShowError("Please fill blank!", tbPrice, lbItemError);
                return;
            }

            if (tbItemDescription.Text.Length == 0)
            {
                ShowError("Please input the Product Name!", tbItemDescription, lbItemError);
                return;
            }
            HideError(tbItemDescription, lbItemError);


            if (tbQuantity.Text.Length == 0)
            {
                ShowError("Please input the Quantity!", tbQuantity, lbItemError);
                return;
            }
            if (Regex.IsMatch(tbQuantity.Text, "[^0-9]"))
            {
                ShowError("Please input only numbers", tbQuantity, lbItemError);
                return;
            }
            HideError(tbQuantity, lbItemError);


            if (tbPrice.Text.Length == 0)
            {
                ShowError("Please input the Price!", tbPrice, lbItemError);
                return;
            }
            if (Regex.IsMatch(tbPrice.Text, "[^0-9]"))
            {
                ShowError("Please input only numbers", tbPrice, lbItemError);
                return;
            }
            HideError(tbPrice, lbItemError);

            #endregion

            #region Bind Item datagridview

            _objItems.Add(new Item
            {
                ItemDescription = tbItemDescription.Text,
                Quantity = Convert.ToInt32(tbQuantity.Text),
                UnitPrice = Convert.ToDouble(tbPrice.Text),
                CreateTime = DateTime.Now
            });

            dgvItemList.DataSource = null;
            dgvItemList.DataSource = _objItems;
            dgvItemList.Show();

            #endregion

            #region Calculate product price

            double productPrice = 0;
            foreach (var objItem in _objItems)
                productPrice += objItem.Quantity * objItem.UnitPrice;
            tbTotalPrice.Text = productPrice.ToString();

            #endregion

            #region Clear all Item control information

            tbItemDescription.Text = "";
            tbItemDescription.BackColor = Color.White;
            tbQuantity.Text = "";
            tbQuantity.BackColor = Color.White;
            tbPrice.Text = "";
            tbPrice.BackColor = Color.White;
            lbItemError.Visible = false;

            #endregion
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            #region Validation for userinfo and purchaser name

            if (tbTo.Text == "" && tbToPhone.Text == "" && tbAddress.Text == "" && tbPurchaser.Text == "")
            {
                lbUserError.Text = "Please input blank!";
                lbUserError.Visible = true;
                tbTo.BackColor = Color.LightCoral;
                tbToPhone.BackColor = Color.LightCoral;
                tbAddress.BackColor = Color.LightCoral;
                tbPurchaser.BackColor = Color.LightCoral;
                tbTo.Focus();
                return;
            }
            if (tbTo.Text == "")
            {
                lbUserError.Text = "Please input the To!";
                lbUserError.Visible = true;
                tbTo.BackColor = Color.LightCoral;
                tbTo.Focus();
                return;
            }
            if (tbToPhone.Text == "")
            {
                lbUserError.Text = "Please input the Phone!";
                lbUserError.Visible = true;
                tbToPhone.BackColor = Color.LightCoral;
                tbToPhone.Focus();
                return;
            }
            if (tbAddress.Text == "")
            {
                lbUserError.Text = "Please input the Address!";
                lbUserError.Visible = true;
                tbAddress.BackColor = Color.LightCoral;
                tbAddress.Focus();
                return;
            }
            if (tbPurchaser.Text == "")
            {
                lbUserError.Text = "Please input the Purchaser Name!";
                lbUserError.Visible = true;
                tbPurchaser.BackColor = Color.LightCoral;
                tbPurchaser.Focus();
                return;
            }
            if (dgvItemList.DataSource == null)
            {
                lbUserError.Text = "There is not items to be added!";
                lbUserError.Visible = true;
                return;
            }

            #endregion

            #region Insert Order data

            // insert UserInfo data
            var objUserInfo = new UserInfo
            {
                UserName = tbTo.Text.Trim(),
                PhoneNumber = tbToPhone.Text.Trim(),
                Address = tbAddress.Text.Trim(),
                CardNo = tbIdentityCard.Text.Trim(),
                CreateTime = DateTime.Now.Date
            };
            new UserInfoManage().InsertUser(objUserInfo);
            objUserInfo.UserNo = new UserInfoManage().GetLatestUserNo(); //return UserNo (foreign key for table Orders)
            purchaserName = tbPurchaser.Text.Trim();

            // insert Orders data
            crtOrderNo = new OrderManage().GetMaxOrderNo().ToString();
                //return OrderNo (foreign key for table ItemList )
            var objOrder = new Order
            {
                OrderNo = Convert.ToInt32(crtOrderNo),
                User = objUserInfo,
                Purchaser = tbPurchaser.Text.Trim(),
                ProductPrice = Convert.ToDouble(tbTotalPrice.Text.Trim()),
                LstItems = _objItems,
                CreateTime = DateTime.Now.Date
            };
            new OrderManage().InsertOrder(objOrder);

            // insert Item data
            foreach (var objItem in _objItems)
            {
                objItem.OrderNo = Convert.ToInt32(crtOrderNo);
                new ItemManage().InsertItem(objItem);
            }

            // insert Transaction data
            var objTransaction = new Transaction
            {
                OrderNo = Convert.ToInt32(crtOrderNo),
                Purchaser = purchaserName,
                OrderStatus = Convert.ToByte(false),
                CreateTime = DateTime.Now.Date
            };
            new TransactionManage().InsertTransactionRecord(objTransaction);

            #endregion

            #region Generate the Order text

            tbOrderContent.Text = GenerateOrderContent(objUserInfo, false);

            #endregion

            #region Clear all control information

            dgvItemList.DataSource = null;
            tbTo.Text = "";
            tbTo.BackColor = Color.White;
            tbToPhone.Text = "";
            tbToPhone.BackColor = Color.White;
            tbAddress.Text = "";
            tbAddress.BackColor = Color.White;
            tbPurchaser.Text = "";
            tbPurchaser.BackColor = Color.White;
            lbUserError.Visible = false;
            _objItems.Clear();

            #endregion

            MessageBox.Show("Adding Order Sucessfully!");
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (tbOrderContent.Text != "")
            {
                Clipboard.SetDataObject(tbOrderContent.Text);
                tbOrderContent.Focus();
                MessageBox.Show("Copy to clipboard!");
            }
        }

        private void chkLock_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLock.Checked)
                chkLock.Text = "Unlock";
            else
                chkLock.Text = "Lock";
            tbFrom.Enabled = !chkLock.Checked;
            tbFromPhone.Enabled = !chkLock.Checked;
        }

        private void btnTxtFile_Click(object sender, EventArgs e)
        {
            #region Generate .txt file

            var fileSelector = new FolderBrowserDialog();
            var defaultPath = ExportFile.GetDefaultPath("dircPath");
            if (defaultPath != "")
                fileSelector.SelectedPath = defaultPath;
            if (fileSelector.ShowDialog() == DialogResult.OK)
            {
                ExportFile.SetFolderPath("dircPath", fileSelector.SelectedPath);
                var path = string.Format(fileSelector.SelectedPath + @"\{0}{1}.txt", crtOrderNo,
                    purchaserName);


                var objItems = new ItemManage().GetItemListByOrderNo(crtOrderNo);

                var objUserInfo = new UserInfo
                {
                    UserName = tbTo.Text.Trim(),
                    PhoneNumber = tbToPhone.Text.Trim(),
                    Address = tbAddress.Text.Trim(),
                    CardNo = tbIdentityCard.Text.Trim()
                };
                var orderContent = ExportFile.GenerateOrderContent(objItems, objUserInfo, true);

                ExportFile.CreateOrderFile(path, tbOrderContent.Text.Trim());
                MessageBox.Show("Generating " + crtOrderNo + purchaserName + ".txt Sucessfully!");
            }

            #endregion
        }

        public void Receiver(Order objOrder)
        {
            tbPurchaser.Text = objOrder.Purchaser;
            tbTo.Text = objOrder.User.UserName;
            tbToPhone.Text = objOrder.User.PhoneNumber;
            tbIdentityCard.Text = objOrder.User.CardNo;
            tbAddress.Text = objOrder.User.Address;
        }

        private void btnPriceKit_Click(object sender, EventArgs e)
        {
            _frmPriceKit = new CalculatePriceKitPage();
            _frmPriceKit.EvtMoveItem += Receiver;

            #region 使打开的窗口依附在原窗口的边上

            var x = (SystemInformation.WorkingArea.Width - _frmPriceKit.Size.Width) / 2 + _frmPriceKit.Size.Width;
            var y = (SystemInformation.WorkingArea.Height - _frmPriceKit.Size.Height) / 2;
            _frmPriceKit.StartPosition = FormStartPosition.Manual; //窗体的位置由Location属性决定
            _frmPriceKit.Location = (Point) new Size(x, y);

            #endregion

            _frmPriceKit.Show();
            //btnPriceKit.Enabled = false;
        }

        public void Receiver(Item objItem)
        {
            tbItemDescription.Text = objItem.ItemDescription;
            tbPrice.Text = objItem.UnitPrice.ToString();
        }

        private void OrderCreationPage_KeyDown(object sender, KeyEventArgs e)
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

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (
                MessageBox.Show(this, "Are you sure to delete?", "Prompt", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                #region Delete Item

                var itemDescription = dgvItemList.CurrentRow.Cells["ItemDescription"].Value.ToString();
                var objDeleteItem = (from t in _objItems where t.ItemDescription == itemDescription select t).First();
                    //Re-organize the data in DataGridView
                _objItems.Remove(objDeleteItem);
                dgvItemList.DataSource = null;
                dgvItemList.DataSource = _objItems;
                dgvItemList.Show();

                #endregion

                #region Calculate product price

                double productPrice = 0;
                foreach (var objItem in _objItems)
                    productPrice += objItem.Quantity * objItem.UnitPrice;
                tbTotalPrice.Text = productPrice.ToString();

                #endregion
            }
        }

        private void OrderCreationPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_frmPriceKit != null)
                _frmPriceKit.Close();
        }

        #region Generate Order content

        private string GenerateOrderContent(UserInfo objUserInfo, bool withUnitPrice)
        {
            var orderBuilder = new StringBuilder();
            // From part
            orderBuilder.Append(string.Format("发件人：{0}\r\n电话：{1}\r\n\r\n", tbFrom.Text, tbFromPhone.Text));
            // Item part
            var counter = 0;
            foreach (var objItem in _objItems)
            {
                counter++;
                if (withUnitPrice)
                    orderBuilder.Append(string.Format(counter + "、{0}，数量{1}，{2}\r\n", objItem.ItemDescription,
                        objItem.Quantity, objItem.UnitPrice));
                else
                    orderBuilder.Append(string.Format(counter + "、{0}，数量{1}\r\n", objItem.ItemDescription,
                        objItem.Quantity));
            }
            // To part
            orderBuilder.Append(string.Format("\r\n收件人：{0}\r\n电话：{1}\r\n地址：{2}\r\n", objUserInfo.UserName,
                objUserInfo.PhoneNumber,
                objUserInfo.Address));
            return orderBuilder.ToString();
        }

        #endregion

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
    }
}