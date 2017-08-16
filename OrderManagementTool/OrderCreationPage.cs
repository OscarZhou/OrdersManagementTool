using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using Models;
using Utilities;

namespace OrderManagementTool
{
    public partial class OrderCreationPage : Form
    {
        private int crtOrderNo;
        private CalculatePriceKitPage frmPriceKit;
        private readonly List<Item> objItems = new List<Item>();
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

            if (tbItemDescription.Text == "" && tbQuantity.Text == "" && tbPrice.Text == "")
            {
                lbItemError.Text = "Please input blank!";
                lbItemError.Visible = true;
                tbItemDescription.BackColor = Color.LightCoral;
                tbQuantity.BackColor = Color.LightCoral;
                tbPrice.BackColor = Color.LightCoral;
                tbItemDescription.Focus();
                return;
            }
            if (tbItemDescription.Text == "")
            {
                lbItemError.Text = "Please input the Product Name!";
                lbItemError.Visible = true;
                tbItemDescription.BackColor = Color.LightCoral;
                tbItemDescription.Focus();
                return;
            }
            if (tbQuantity.Text == "")
            {
                lbItemError.Text = "Please input the Quantity!";
                lbItemError.Visible = true;
                tbQuantity.BackColor = Color.LightCoral;
                tbQuantity.Focus();
                return;
            }
            if (tbPrice.Text == "")
            {
                lbItemError.Text = "Please input the Price!";
                lbItemError.Visible = true;
                tbPrice.BackColor = Color.LightCoral;
                tbPrice.Focus();
                return;
            }

            #endregion

            #region Bind Item datagridview

            objItems.Add(new Item
            {
                ItemDescription = tbItemDescription.Text,
                Quantity = Convert.ToInt32(tbQuantity.Text),
                UnitPrice = Convert.ToDouble(tbPrice.Text),
                CreateTime = DateTime.Now
            });

            dgvItemList.DataSource = null;
            dgvItemList.DataSource = objItems;
            dgvItemList.Show();

            #endregion

            #region Calculate product price

            double productPrice = 0;
            foreach (var objItem in objItems)
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
            crtOrderNo = new OrderManage().GetMaxOrderNo(); //return OrderNo (foreign key for table ItemList )
            var objOrder = new Order
            {
                OrderNo = crtOrderNo,
                User = objUserInfo,
                Purchaser = tbPurchaser.Text.Trim(),
                ProductPrice = Convert.ToDouble(tbTotalPrice.Text.Trim()),
                LstItems = objItems,
                CreateTime = DateTime.Now.Date
            };
            new OrderManage().InsertOrder(objOrder);

            // insert Item data
            foreach (var objItem in objItems)
            {
                objItem.OrderNo = crtOrderNo;
                new ItemManage().InsertItem(objItem);
            }

            // insert Transaction data
            var objTransaction = new Transaction
            {
                OrderNo = crtOrderNo,
                Purchaser = purchaserName,
                OrderStatus = Convert.ToByte(false),
                CreateTime = DateTime.Now.Date
            };
            new TransactionManage().InsertTransactionRecord(objTransaction);

            #endregion

            #region Generate the Order text

            var orderBuilder = new StringBuilder();
            // From part
            orderBuilder.Append("发件人：{0}\r\n电话：{1}\r\n\r\n");
            var orderContent = string.Format(orderBuilder.ToString(), tbFrom.Text, tbFromPhone.Text);
            tbOrderContent.Text = orderContent;

            // Item part
            orderBuilder.Clear();
            var counter = 0;
            foreach (var objItem in objItems)
            {
                counter++;
                orderBuilder.Append(counter + "、{0}，数量{1}\r\n");
                orderContent = string.Format(orderBuilder.ToString(), objItem.ItemDescription, objItem.Quantity);
                tbOrderContent.Text += orderContent;
                orderBuilder.Clear();
            }

            // To part
            orderBuilder.Append("\r\n收件人：{0}\r\n电话：{1}\r\n地址：{2}\r\n");
            orderContent = string.Format(orderBuilder.ToString(), objUserInfo.UserName, objUserInfo.PhoneNumber,
                objUserInfo.Address);
            tbOrderContent.Text += orderContent;

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
            tbTotalPrice.Text = "";
            lbUserError.Visible = false;
            objItems.Clear();

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
            frmPriceKit = new CalculatePriceKitPage();
            frmPriceKit.EvtMoveItem += Receiver;
            frmPriceKit.Show();
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
                var objDeleteItem = (from t in objItems where t.ItemDescription == itemDescription select t).First();
                    //Re-organize the data in DataGridView
                objItems.Remove(objDeleteItem);
                dgvItemList.DataSource = null;
                dgvItemList.DataSource = objItems;
                dgvItemList.Show();

                #endregion

                #region Calculate product price

                double productPrice = 0;
                foreach (var objItem in objItems)
                    productPrice += objItem.Quantity * objItem.UnitPrice;
                tbTotalPrice.Text = productPrice.ToString();

                #endregion
            }
        }
    }
}