using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Utilities;

namespace OrderManagementTool
{
    public partial class FrmOrderText : Form
    {
        private string _orderNo;
        private string _purchaserName;
        private bool zh;

        public FrmOrderText()
        {
            InitializeComponent();
            CultureInfo ci = Thread.CurrentThread.CurrentUICulture;
            zh = ci.Name.Equals("zh-CHS") ? true : false;
            // Add key down event
            KeyDown += FrmOrderText_KeyDown;
            foreach (Control control in Controls)
                control.KeyDown += FrmOrderText_KeyDown;
        }

        public void Receiver(string content, string orderNo)
        {
            tbOrderContent.Text = content;
            _orderNo = orderNo;
        }

        private void btnCopyToClipboard_Click(object sender, EventArgs e)
        {
            if (tbOrderContent.Text != "")
            {
                Clipboard.SetDataObject(tbOrderContent.Text);
                tbOrderContent.Focus();
                MessageBox.Show(zh?"复制到粘贴板":"Copy to clipboard!");
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

            var objItems = new ItemManage().GetItemListByOrderNo(_orderNo);
            var objUserInfo = new UserInfoManage().GetUserByOrderNo(_orderNo);
            tbOrderContent.Text = GenerateOrderContent(objItems, objUserInfo, false);

            #endregion

            #region Generate .txt file

            _purchaserName = new OrderManage().GetPurchaserName(_orderNo);
            var fileSelector = new FolderBrowserDialog();
            var defaultPath = ExportFile.GetDefaultPath("dircPath");
            if (defaultPath != "")
                fileSelector.SelectedPath = defaultPath;
            if (fileSelector.ShowDialog() == DialogResult.OK)
            {
                ExportFile.SetFolderPath("dircPath", fileSelector.SelectedPath);
                var path = string.Format(fileSelector.SelectedPath + @"\{0}{1}.txt", _orderNo,
                    _purchaserName);

                ExportFile.CreateOrderFile(path, tbOrderContent.Text.Trim());
                if (DialogResult.OK ==
                    MessageBox.Show((zh?"生成":"Generating ") + _orderNo + _purchaserName + (zh?".txt 成功！":".txt Sucessfully!")))
                {
                    //this.Close();
                }
            }

            #endregion

            if (tbOrderContent.Text != "")
            {
                Clipboard.SetDataObject(tbOrderContent.Text);
                tbOrderContent.Focus();
                MessageBox.Show(zh ? "复制到粘贴板" : "Copy to clipboard!");
            }
        }

        #region Generate Order content

        private string GenerateOrderContent(List<Item> objItems, UserInfo objUserInfo, bool withUnitPrice)
        {
            var orderBuilder = new StringBuilder();
            // From part
            orderBuilder.Append("发件人：Oscar\r\n电话：0211376664\r\n\r\n");
            // Item part
            var counter = 0;
            foreach (var objItem in objItems)
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
    }
}