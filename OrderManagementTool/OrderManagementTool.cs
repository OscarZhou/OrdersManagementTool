using BLL;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using Utilities;

namespace OrderManagementTool
{
    public partial class OrderManagementTool : Form
    {
        private bool zh;
        public OrderManagementTool()
        {
            InitializeComponent();
            CultureInfo ci = Thread.CurrentThread.CurrentUICulture;
            zh = ci.Name.Equals("zh-CHS") ? true : false;

            //#region Adjust window size

            //int height = Screen.PrimaryScreen.Bounds.Height;
            //MessageBox.Show("Bounds height:" + height);

            //height = this.splitContainer.Panel1.Height;
            //MessageBox.Show("panel1 height:" + height);
            //#endregion

            dgvTransaction.AutoGenerateColumns = false; // prohibit useless column 
            ShowTransaction(tbSearch.Text.Trim(), Convert.ToInt32(cmbSorting.SelectedIndex));
            InitializeSortingList();
            lbAuthor.Text = FileVersionInfo.GetVersionInfo(Assembly.GetEntryAssembly().Location).CompanyName;
            lbVersion.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            tbSearch.Focus();
            // Add key down event
            KeyDown += OrderManagementTool_KeyDown;
            foreach (Control control in Controls)
                control.KeyDown += OrderManagementTool_KeyDown;
        }


        private void InitializeSortingList()
        {
            cmbSorting.Items.Add(zh ? "订单号升序" : "OrderNo Asc");
            cmbSorting.Items.Add(zh ? "订单号降序" : "OrderNo Desc");
            cmbSorting.Items.Add(zh ? "利润升序" : "Profit Asc");
            cmbSorting.Items.Add(zh ? "利润降序" : "Profit Desc");
            cmbSorting.SelectedIndex = 1;
            _orderNo = dgvTransaction.RowCount.ToString();
        }

        /// <summary>
        ///     Import the existed data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenDataImporter_Click(object sender, EventArgs e)
        {
            DisplayMainFrm(false);
            _frmDataImporting = new DataImportingPage();
            OpenNewForm(_frmDataImporting);
        }

        /// <summary>
        ///     create the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            _frmOrderCreation = new OrderCreationPage();
            DisplayMainFrm(false);
            OpenNewForm(_frmOrderCreation);
        }

        /// <summary>
        ///     view undone orders
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUndoneOrders_Click(object sender, EventArgs e)
        {
            // 添加检查是否存在未完成的订单
            var objLists = new TransactionManage().GetUndoneTransactionList();
            if (objLists.Count == 0)
            {
                MessageBox.Show("No undone orders!", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DisplayMainFrm(false);
                _frmUndoneOrders = new UndoneOrdersPage();
                EvtPassParentPanel += _frmUndoneOrders.Receiver; // 关联子窗体，传递订单号信息
                EvtPassParentPanel(splitContainer.Panel1);
                OpenNewForm(_frmUndoneOrders);
            }
        }

        /// <summary>
        ///     search purchaser
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            ShowTransaction(tbSearch.Text.Trim(), Convert.ToInt32(cmbSorting.SelectedIndex));
        }

        private void ShowTransaction(string name, int sortingtype)
        {
            dgvTransaction.DataSource = new TransactionManage().GetTransactionList(name, sortingtype);

            #region Calculate total profit

            double TotalProfit = 0;
            foreach (DataGridViewRow dgvTransactionRow in dgvTransaction.Rows)
                TotalProfit += Convert.ToDouble(dgvTransactionRow.Cells["Profit"].Value);
            lbTotalProfit.Text = "￥" + TotalProfit;

            #endregion

            dgvTransaction.Show();
            //dgvTransaction.Columns["Purchaser"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;


            //if (dgvTransaction.RowCount != 0)
            //{
            //    this._orderNo = dgvTransaction.Rows[0].Cells["OrderNo"].Value.ToString();    
            //}
        }

        private void ShowTransaction(string name, int sortingtype, int orderNo)
        {
            dgvTransaction.DataSource = new TransactionManage().GetTransactionList(name, sortingtype);
            if (sortingtype == 0)
            {
                dgvTransaction.FirstDisplayedCell = dgvTransaction.Rows[orderNo].Cells[0];
                    // Display the selected row in datagridview    
                dgvTransaction.Rows[orderNo].DefaultCellStyle.BackColor = Color.DeepSkyBlue;
            }
            else if (sortingtype == 1)
            {
                var totalRows = dgvTransaction.RowCount;
                dgvTransaction.FirstDisplayedCell = dgvTransaction.Rows[totalRows - orderNo].Cells[0];
                    // Display the selected row in datagridview    
                dgvTransaction.Rows[totalRows - orderNo].DefaultCellStyle.BackColor = Color.DeepSkyBlue;
            }

            #region Calculate total profit

            double TotalProfit = 0;
            foreach (DataGridViewRow dgvTransactionRow in dgvTransaction.Rows)
                TotalProfit += Convert.ToDouble(dgvTransactionRow.Cells["Profit"].Value);
            lbTotalProfit.Text = "The total profit: " + TotalProfit;

            #endregion

            dgvTransaction.Show();
        }

        private void cmbSorting_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowTransaction(tbSearch.Text.Trim(), Convert.ToInt32(cmbSorting.SelectedIndex));
        }

        /// <summary>
        ///     view details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDetail_Click(object sender, EventArgs e)
        {
            if (dgvTransaction.RowCount == 0)
                return;

            _orderNo = dgvTransaction.CurrentRow.Cells["OrderNo"].Value.ToString();
            _frmOrderDetail = new OrderDetailsPage();
            EvtOpenView += _frmOrderDetail.ViewReceiver; // 关联子窗体，传递订单号信息
            EvtOpenView(_orderNo, splitContainer.Panel1);

            #region 回传消息给主窗体，让其刷新交易列表

            //_frmOrderDetail.EvtSendMsg += this.Receiver;//关联子窗体，添加发送消息方法，用于刷新交易列表

            #endregion

            DisplayMainFrm(false);
            OpenNewForm(_frmOrderDetail);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            //#region 不能连续两次点击 OrderDetails Form


            //foreach (Control item in this.splitContainer.Panel1.Controls)
            //{
            //    if (item is OrderDetailsPage)
            //    {
            //        if (MessageBox.Show(this, "You should choose one transaction firstly?", "Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //        {
            //            ((Form)item).Close();
            //            this.DisplayMainFrm(true);
            //            return;
            //        }
            //    }
            //}

            //#endregion

            if (dgvTransaction.RowCount == 0)
                return;
            _orderNo = dgvTransaction.CurrentRow.Cells["OrderNo"].Value.ToString();
            _frmOrderDetail = new OrderDetailsPage();
            EvtOpenEdit += _frmOrderDetail.EditReceiver;
            EvtOpenEdit(_orderNo);
            _frmOrderDetail.EvtSendMsg += Receiver;
            DisplayMainFrm(false);
            OpenNewForm(_frmOrderDetail);
        }

        private void btnExportTransaction_Click(object sender, EventArgs e)
        {
            #region Generate .csv file

            var fileSelector = new FolderBrowserDialog();
            var timeStamp = DateTime.Now.Date.ToString("ddMMyyyy");
            if (fileSelector.ShowDialog() == DialogResult.OK)
            {
                var path = string.Format(fileSelector.SelectedPath + @"\销售记录{0}.xls", timeStamp);
                ExportFile.ExportToExcel(path, new TransactionManage().GetTransactionList());
                MessageBox.Show("Generating 销售记录" + timeStamp + ".xls Sucessfully!");
            }

            #endregion
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            // Display the selected row in datagridview    
            //this.dgvTransaction.FirstDisplayedCell = this.dgvTransaction.Rows[Convert.ToInt32(this.orderNo)].Cells[0]; 
            if (dgvTransaction.RowCount == 0)
                return;

            if (MessageBox.Show(this, "Delete?", "Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.Yes)
            {
                var objOrder = new OrderManage().GetOrderByOrderNo(_orderNo);
                objOrder.User = new UserInfoManage().GetUserByOrderNo(_orderNo);

                #region Delete the .txt File

                var defaultPath = ExportFile.GetDefaultPath("dircPath");
                if (defaultPath != "")
                {
                    var filename = string.Format(@"{0}\{1}{2}.txt", defaultPath, objOrder.OrderNo, objOrder.Purchaser);
                    if (File.Exists(filename))
                        File.Delete(filename);
                }

                #endregion

                new TransactionManage().DeleteTransactionRecord(_orderNo);
                new ItemManage().DeleteItemListByOrderNo(_orderNo);
                new OrderManage().DeleteOrder(objOrder);
                var result = new UserInfoManage().DeleteUser(objOrder.User);
                if (result > 0)
                    MessageBox.Show("Delete data sucessfully!");
                DisplayMainFrm(true);
            }
        }

        private void btnPriceKit_Click(object sender, EventArgs e)
        {
            _frmPriceKit = new CalculatePriceKitPage();

            #region Setting the start position of the new window

            var x = (SystemInformation.WorkingArea.Width - _frmPriceKit.Size.Width) / 2 + _frmPriceKit.Size.Width;
            var y = (SystemInformation.WorkingArea.Height - _frmPriceKit.Size.Height) / 2;
            _frmPriceKit.StartPosition = FormStartPosition.Manual; //窗体的位置由Location属性决定
            _frmPriceKit.Location = (Point) new Size(x, y); //窗体的起始位置为(x,y)

            #endregion

            EvtOpenPriceKit += _frmPriceKit.Receiver;
            EvtOpenPriceKit("Outer");
            _frmPriceKit.Show();
        }

        private void dgvTransaction_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _orderNo = dgvTransaction.CurrentRow.Cells["OrderNo"].Value.ToString();
            _frmOrderDetail = new OrderDetailsPage();
            EvtOpenView += _frmOrderDetail.ViewReceiver; // 关联子窗体，传递订单号信息
            EvtOpenView(_orderNo, splitContainer.Panel1);
            DisplayMainFrm(false);
            OpenNewForm(_frmOrderDetail);
        }

        private void OrderManagementTool_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    ShowTransaction(tbSearch.Text.Trim(), Convert.ToInt32(cmbSorting.SelectedIndex));
                    break;
                case Keys.Escape:
                    Close();
                    break;

                default:
                    break;
            }
        }

        private void btnOrderText_Click(object sender, EventArgs e)
        {
            if (dgvTransaction.RowCount == 0)
                return;
            var fileSelector = new FolderBrowserDialog();
            fileSelector.Description = @"Please choose the folder that stores order text:";
            var defaultPath = ExportFile.GetDefaultPath("dircPath");
            if (defaultPath != "")
                fileSelector.SelectedPath = defaultPath;
            if (fileSelector.ShowDialog() == DialogResult.OK)
            {
                var filename = string.Format(fileSelector.SelectedPath + @"\{0}{1}.txt",
                    dgvTransaction.CurrentRow.Cells["OrderNo"].Value,
                    dgvTransaction.CurrentRow.Cells["Purchaser"].Value); // Get the file name

                _frmOrderText = new FrmOrderText();
                EvtSetOrderText += _frmOrderText.Receiver;
                EvtSetOrderText(ExportFile.ReadOrderFile(filename),
                    dgvTransaction.CurrentRow.Cells["OrderNo"].Value.ToString());
                DisplayMainFrm(false);
                OpenNewForm(_frmOrderText);
            }
        }

        private void tbSearch_Click(object sender, EventArgs e)
        {
            if (tbSearch.Text != "")
                tbSearch.Text = "";
        }

        #region Receiver function collection

        /// <summary>
        ///     This receiver is used for receiving all the messages from other windows
        ///     refresh: refreshing the Transaction DataGridView
        ///     open: opening the default view
        /// </summary>
        /// <param name="msgName"></param>
        public void Receiver(string msgName)
        {
            if (msgName.Equals("refresh"))
                ShowTransaction(tbSearch.Text.Trim(), Convert.ToInt32(cmbSorting.SelectedIndex));
            else if (msgName.Equals("open"))
                DisplayMainFrm(true);
        }

        #endregion

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            DisplayMainFrm(true);
            var selectedRowNo = GetCurrentRowNo(_orderNo);
            var locatedRowNo = selectedRowNo > 5 ? selectedRowNo - 5 : selectedRowNo;
            if (dgvTransaction.RowCount != 0)
            {
                dgvTransaction.FirstDisplayedCell = dgvTransaction.Rows[locatedRowNo - 1].Cells[0];
                dgvTransaction.Rows[selectedRowNo - 1].Cells[0].Selected = true;
            }

            //ShowTransaction(tbSearch.Text.Trim(), Convert.ToInt32(cmbSorting.SelectedIndex));
        }

        private void dgvTransaction_Click(object sender, EventArgs e)
        {
            _orderNo = dgvTransaction.CurrentRow.Cells["OrderNo"].Value.ToString();
        }

        #region Get the row No that is can be selected after switching the form

        private int GetCurrentRowNo(string orderNo)
        {
            var selectedRowNo = 0;
            foreach (DataGridViewRow row in dgvTransaction.Rows)
            {
                selectedRowNo++;
                if (row.Cells["OrderNo"].Value.ToString().Equals(orderNo))
                    return selectedRowNo;
            }

            return selectedRowNo;
        }

        #endregion

        #region Variable declaration

        private DataImportingPage _frmDataImporting;
        private OrderCreationPage _frmOrderCreation;
        private UndoneOrdersPage _frmUndoneOrders;
        private OrderDetailsPage _frmOrderDetail;
        private CalculatePriceKitPage _frmPriceKit;
        private FrmOrderText _frmOrderText;
        private string _orderNo;

        #region Delegate for opening the edit order and the view order

        public delegate void DlgOpenEdit(string order);

        public event DlgOpenEdit EvtOpenEdit;


        public delegate void DlgOpenView(string orderNo, Control parentControl);

        public event DlgOpenView EvtOpenView;

        #endregion

        #region Delegate for view the OrderText

        public delegate void DlgSetOrderText(string content, string orderNo);

        public event DlgSetOrderText EvtSetOrderText;

        #endregion

        #region Delegate for opening the PriceKit

        public delegate void DlgOpenPriceKit(string whereFromOpen);

        public event DlgOpenPriceKit EvtOpenPriceKit;

        #endregion

        #region Delegate for sending back the Form Handler to Main Interface

        public delegate void DlgSendHandler(CalculatePriceKitPage priceKitForm);

        public DlgSendHandler EvtSendHandler;

        #endregion

        #region Delegate for passing the parent control when UndoneOrders Form is opened

        public delegate void DlgPassParentPanel(Control parentControl);

        public DlgPassParentPanel EvtPassParentPanel;

        #endregion

        #endregion

        #region Window operation

        private void OpenNewForm(Form newFrm)
        {
            // Close other embeded windows
            foreach (Control item in splitContainer.Panel1.Controls)
                if (item is Form)
                    ((Form) item).Close();

            // Open and attach the new window
            newFrm.TopLevel = false;
            newFrm.Parent = splitContainer.Panel1;
            newFrm.Dock = DockStyle.Fill;
            newFrm.Show();
        }

        /// <summary>
        ///     Open or Close the elements in main window
        /// </summary>
        /// <param name="mainFrmState"></param>
        private void DisplayMainFrm(bool mainFrmState)
        {
            // Refresh the Transaction DataGridView
            ShowTransaction(tbSearch.Text.Trim(), cmbSorting.SelectedIndex);

            // Close other embeded windows
            foreach (Control item in splitContainer.Panel1.Controls)
            {
                if (item is Form)
                    ((Form) item).Close();
                item.Visible = mainFrmState;
            }
        }

        #endregion

        #region Drag and close window

        private Point mouseOff; //The moving position variables of the mouse
        private bool leftFlag; // Determine if the label is left button

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
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

        #endregion

     
    }
}