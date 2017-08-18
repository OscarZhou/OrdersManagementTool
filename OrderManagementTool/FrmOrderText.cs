using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Utilities;

namespace OrderManagementTool
{
    public partial class FrmOrderText : Form
    {
        private string _orderNo;
        private string _purchaserName;
        public FrmOrderText()
        {
            InitializeComponent();

            // Add key down event
            KeyDown += FrmOrderText_KeyDown;
            foreach (Control control in Controls)
                control.KeyDown += FrmOrderText_KeyDown;
        }

        public void Receiver(string content, string orderNo)
        {
            tbOrderContent.Text = content;
            this._orderNo = orderNo;
        }

        private void btnCopyToClipboard_Click(object sender, EventArgs e)
        {
            if (tbOrderContent.Text != "")
            {
                Clipboard.SetDataObject(tbOrderContent.Text);
                tbOrderContent.Focus();
                MessageBox.Show("Copy to clipboard!");
            }
        }

        private void FrmOrderText_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Close();
                    break;

                default:
                    break;
            }
        }

        private void btnRegenerate_Click(object sender, EventArgs e)
        {

            #region Generate the Order text
            // From part
            string orderContent = "发件人：Oscar\r\n电话：0211376664\r\n\r\n";
            tbOrderContent.Text = orderContent;

            // Item part

            StringBuilder orderBuilder = new StringBuilder();
            List<Item> objItems = new ItemManage().GetItemListByOrderNo(this._orderNo);
            int counter = 0;
            foreach (Item objItem in objItems)
            {
                counter++;
                orderBuilder.Append(counter + "、{0}，数量{1}\r\n");
                orderContent = string.Format(orderBuilder.ToString(), objItem.ItemDescription, objItem.Quantity);
                tbOrderContent.Text += orderContent;
                orderBuilder.Clear();
            }

            // To part
            UserInfo objUserInfo = new UserInfoManage().GetUserByOrderNo(this._orderNo);
            orderBuilder.Append("\r\n收件人：{0}\r\n电话：{1}\r\n地址：{2}\r\n");
            orderContent = string.Format(orderBuilder.ToString(), objUserInfo.UserName, objUserInfo.PhoneNumber,
                objUserInfo.Address);
            tbOrderContent.Text += orderContent;

            #endregion

            #region Generate .txt file

            this._purchaserName = new OrderManage().GetPurchaserName(this._orderNo);
            FolderBrowserDialog fileSelector = new FolderBrowserDialog();
            string defaultPath = ExportFile.GetDefaultPath("dircPath");
            if (defaultPath != "")
            {
                fileSelector.SelectedPath = defaultPath;
            }
            if (fileSelector.ShowDialog() == DialogResult.OK)
            {
                ExportFile.SetFolderPath("dircPath", fileSelector.SelectedPath);
                string path = string.Format(fileSelector.SelectedPath + @"\{0}{1}.txt", this._orderNo,
                    this._purchaserName);

                ExportFile.CreateOrderFile(path, tbOrderContent.Text.Trim());
                if (DialogResult.OK ==
                    MessageBox.Show("Generating " + this._orderNo + this._purchaserName + ".txt Sucessfully!"))
                {
                    this.Close();
                }

            }

            #endregion
        }
    }
}