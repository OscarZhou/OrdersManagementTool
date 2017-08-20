using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using Utilities;

namespace OrderManagementTool
{
    public partial class OrderManagementTool : Form
    {
        #region Variable declaration
        private DataImportingPage _frmDataImporting;
        private OrderCreationPage _frmOrderCreation;
        private UndoneOrdersPage _frmUndoneOrders;
        private OrderDetailsPage _frmOrderDetail;
        private CalculatePriceKitPage _frmPriceKit;
        private FrmOrderText _frmOrderText;

        #region Delegate for opening the edit order and the view order
        // define delegate
        public delegate void DlgSendOperation(string operation, string orderNo);
        // create an event. that is delegate variables
        public event DlgSendOperation EvtSendOperation;
        #endregion

        #region Delegate for view the order text

        public delegate void DlgSetOrderText(string content, string orderNo);

        public event DlgSetOrderText EvtSetOrderText;
        
        #endregion

        #endregion

        public OrderManagementTool()
        {
            InitializeComponent();
            this.dgvTransaction.AutoGenerateColumns = false;// prohibit useless column 
            ShowTransaction(tbSearch.Text.Trim(), Convert.ToInt32(cmbSorting.SelectedIndex));
            InitializeSortingList();
            lbAuthor.Text = FileVersionInfo.GetVersionInfo(Assembly.GetEntryAssembly().Location).CompanyName;
            lbVersion.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            
            tbSearch.Focus();
            // Add key down event
            this.KeyDown += OrderManagementTool_KeyDown;
            foreach (Control control in this.Controls)
            {
                control.KeyDown += OrderManagementTool_KeyDown;
            }
        }

        private void InitializeSortingList()
        {
            cmbSorting.Items.Add("OrderNo Asc");
            cmbSorting.Items.Add("OrderNo Desc");
            cmbSorting.Items.Add("Profit Asc");
            cmbSorting.Items.Add("Profit Desc");
            cmbSorting.SelectedIndex = 1;
        }
        /// <summary>
        /// Import the existed data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenDataImporter_Click(object sender, System.EventArgs e)
        {
            _frmDataImporting = new DataImportingPage();
            _frmDataImporting.ShowDialog();
            ShowTransaction(tbSearch.Text.Trim(), Convert.ToInt32(cmbSorting.SelectedIndex));
        }
        /// <summary>
        /// create the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddOrder_Click(object sender, System.EventArgs e)
        {
            _frmOrderCreation = new OrderCreationPage();
            _frmOrderCreation.ShowDialog();
            ShowTransaction(tbSearch.Text.Trim(), Convert.ToInt32(cmbSorting.SelectedIndex));
        }
        /// <summary>
        /// view undone orders
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUndoneOrders_Click(object sender, System.EventArgs e)
        {
            // 添加检查是否存在未完成的订单
            List<Transaction> objLists = new TransactionManage().GetUndoneTransactionList();
            if (objLists.Count == 0)
            {
                MessageBox.Show("No undone orders!", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _frmUndoneOrders = new UndoneOrdersPage();
                _frmUndoneOrders.ShowDialog();
                ShowTransaction(tbSearch.Text.Trim(), Convert.ToInt32(cmbSorting.SelectedIndex));                
            }


        }
        /// <summary>
        /// search purchaser
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
            {
                TotalProfit += Convert.ToDouble(dgvTransactionRow.Cells["Profit"].Value);
            }
            lbTotalProfit.Text = "￥"+TotalProfit.ToString();

            #endregion
            dgvTransaction.Show();
        }

        private void ShowTransaction(string name, int sortingtype, int orderNo)
        {
            dgvTransaction.DataSource = new TransactionManage().GetTransactionList(name, sortingtype);
            if (sortingtype == 0)
            {
                dgvTransaction.FirstDisplayedCell = this.dgvTransaction.Rows[orderNo].Cells[0]; // Display the selected row in datagridview    
                dgvTransaction.Rows[orderNo].DefaultCellStyle.BackColor = Color.DeepSkyBlue;
            }
            else if (sortingtype==1)
            {
                int totalRows = dgvTransaction.RowCount;
                dgvTransaction.FirstDisplayedCell = this.dgvTransaction.Rows[totalRows-orderNo].Cells[0]; // Display the selected row in datagridview    
                dgvTransaction.Rows[totalRows-orderNo].DefaultCellStyle.BackColor = Color.DeepSkyBlue;
            }
            #region Calculate total profit
            double TotalProfit = 0;
            foreach (DataGridViewRow dgvTransactionRow in dgvTransaction.Rows)
            {
                TotalProfit += Convert.ToDouble(dgvTransactionRow.Cells["Profit"].Value);
            }
            lbTotalProfit.Text = "The total profit: " + TotalProfit.ToString();

            #endregion
            dgvTransaction.Show();
        }

        private void cmbSorting_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowTransaction(tbSearch.Text.Trim(), Convert.ToInt32(cmbSorting.SelectedIndex));
        }

        /// <summary>
        /// view details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDetail_Click(object sender, EventArgs e)
        {
            _frmOrderDetail = new OrderDetailsPage();
            this.EvtSendOperation += _frmOrderDetail.Receiver;// 关联子窗体，传递订单号信息
            this.EvtSendOperation("View", dgvTransaction.CurrentRow.Cells["OrderNo"].Value.ToString());

            _frmOrderDetail.EvtSendMsg += this.Receiver;//关联子窗体，添加发送消息方法，用于刷新交易列表
            _frmOrderDetail.ShowDialog();
            //ShowTransaction(tbSearch.Text.Trim(), Convert.ToInt32(cmbSorting.SelectedIndex));
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            _frmOrderDetail = new OrderDetailsPage();
            this.EvtSendOperation += _frmOrderDetail.Receiver;
            this.EvtSendOperation("Edit", dgvTransaction.CurrentRow.Cells["OrderNo"].Value.ToString());
            _frmOrderDetail.ShowDialog();
            int orderNo = Convert.ToInt32(dgvTransaction.CurrentRow.Cells["OrderNo"].Value.ToString());
            ShowTransaction(tbSearch.Text.Trim(), Convert.ToInt32(cmbSorting.SelectedIndex), orderNo);
        }

        private void btnExportTransaction_Click(object sender, EventArgs e)
        {
            #region Generate .csv file
            FolderBrowserDialog fileSelector = new FolderBrowserDialog();
            string timeStamp = DateTime.Now.Date.ToString("ddMMyyyy");
            if (fileSelector.ShowDialog() == DialogResult.OK)
            {
                string path = string.Format(fileSelector.SelectedPath + @"\销售记录{0}.xls", timeStamp);
                ExportFile.ExportToExcel(path, new TransactionManage().GetTransactionList());
                MessageBox.Show("Generating 销售记录" + timeStamp + ".xls Sucessfully!");
            }

            #endregion
            
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show(this, "Delete?", "Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string orderNo = dgvTransaction.CurrentRow.Cells["OrderNo"].Value.ToString();

                Order objOrder = new OrderManage().GetOrderByOrderNo(orderNo);
                objOrder.User = new UserInfoManage().GetUserByOrderNo(orderNo);
                new TransactionManage().DeleteTransactionRecord(orderNo);
                new ItemManage().DeleteItemListByOrderNo(orderNo);
                new OrderManage().DeleteOrder(objOrder);
                int result = new UserInfoManage().DeleteUser(objOrder.User);
                if (result > 0)
                {
                    MessageBox.Show("Delete data sucessfully!");
                }

                ShowTransaction(tbSearch.Text.Trim(), Convert.ToInt32(cmbSorting.SelectedIndex));                
            }
        }

        private void btnPriceKit_Click(object sender, EventArgs e)
        {
            _frmPriceKit = new CalculatePriceKitPage();
            int x = (System.Windows.Forms.SystemInformation.WorkingArea.Width - _frmPriceKit.Size.Width) / 2 + _frmPriceKit.Size.Width;
            int y = (System.Windows.Forms.SystemInformation.WorkingArea.Height - _frmPriceKit.Size.Height) / 2;
            _frmPriceKit.StartPosition = FormStartPosition.Manual; //窗体的位置由Location属性决定
            _frmPriceKit.Location = (Point)new Size(x, y);         //窗体的起始位置为(x,y)

            //this.DisplayMainFrm(false);
            //this.OpenNewForm(_frmPriceKit);
            _frmPriceKit.Show();
            //btnPriceKit.Enabled = false;
        }

        private void dgvTransaction_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _frmOrderDetail = new OrderDetailsPage();
            this.EvtSendOperation += _frmOrderDetail.Receiver;
            this.EvtSendOperation("View", dgvTransaction.CurrentRow.Cells["OrderNo"].Value.ToString());
            _frmOrderDetail.ShowDialog();
        }

        private void OrderManagementTool_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    ShowTransaction(tbSearch.Text.Trim(), Convert.ToInt32(cmbSorting.SelectedIndex));
                    break;
                case Keys.Escape:
                    this.Close();
                    break;

                default:
                    break;
            }
        }

        private void btnOrderText_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fileSelector = new FolderBrowserDialog();
            fileSelector.Description = @"Please choose the folder that stores order text:";
            string defaultPath = ExportFile.GetDefaultPath("dircPath");
            if (defaultPath != "")
            {
                fileSelector.SelectedPath = defaultPath;
            }
            if (fileSelector.ShowDialog() == DialogResult.OK)
            {
                string filename = string.Format(fileSelector.SelectedPath+@"\{0}{1}.txt", dgvTransaction.CurrentRow.Cells["OrderNo"].Value.ToString(),
                dgvTransaction.CurrentRow.Cells["Purchaser"].Value.ToString()); // Get the file name
                _frmOrderText = new FrmOrderText();
                this.EvtSetOrderText += _frmOrderText.Receiver;
                this.EvtSetOrderText(ExportFile.ReadOrderFile(filename), dgvTransaction.CurrentRow.Cells["OrderNo"].Value.ToString());
                _frmOrderText.ShowDialog();

            }
        }

        private void tbSearch_Click(object sender, EventArgs e)
        {
            if (tbSearch.Text != "")
            {
                tbSearch.Text = "";
            }

        }

        public void Receiver(string msgName)
        {
            if (msgName.Equals("refresh"))
            {
                ShowTransaction(tbSearch.Text.Trim(), Convert.ToInt32(cmbSorting.SelectedIndex));    
            }
            
        }


        private void OpenNewForm(Form newFrm)
        {
            // Close other embeded windows
            foreach (Control item in this.splitContainer.Panel1.Controls)
            {
                if (item is Form)
                {
                    ((Form)item).Close();
                }
            }

            // Open and attach the new window
            newFrm.TopLevel = false;
            newFrm.Parent = this.splitContainer.Panel1;
            newFrm.Dock = DockStyle.Fill;
            newFrm.Show();
        }
        /// <summary>
        /// Open or Close the elements in main window
        /// </summary>
        /// <param name="mainFrmState"></param>
        private void DisplayMainFrm(bool mainFrmState)
        {
            // Close other embeded windows
            foreach (Control item in this.splitContainer.Panel1.Controls)
            {
                if (item is Form)
                {
                    ((Form)item).Close();
                }
                else
                {
                    item.Visible = mainFrmState;
                }
            }

        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            this.DisplayMainFrm(true);
        }

        #region Drag and close window

        private Point mouseOff; //The moving position variables of the mouse
        private bool leftFlag; // Determine if the label is left button

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
        #endregion

    }
}
