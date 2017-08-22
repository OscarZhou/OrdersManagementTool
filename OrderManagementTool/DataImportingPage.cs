using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Utilities;

namespace OrderManagementTool
{
    public partial class DataImportingPage : Form
    {

        private List<Order> objOrders = new List<Order>();
        private List<Transaction> objTransactions = new List<Transaction>();

        public DataImportingPage()
        {
            InitializeComponent();
            // Add key down event
            this.KeyDown += DataImportingPage_KeyDown;
            foreach (Control control in this.Controls)
            {
                control.KeyDown += DataImportingPage_KeyDown;
            }
        }

        /// <summary>
        /// Import Orders
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImport_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fileSelector = new FolderBrowserDialog();
            string defaultPath = ExportFile.GetDefaultPath("dircPath");
            if (defaultPath != "")
            {
                fileSelector.SelectedPath = defaultPath;
            }
            if (fileSelector.ShowDialog() == DialogResult.OK)
            {
                ExportFile.SetFolderPath("dircPath", fileSelector.SelectedPath);
                lbFolder.Text = string.Format("     Selected Directory: {0}", fileSelector.SelectedPath);
                var files = Directory.GetFiles(fileSelector.SelectedPath).Where(name => name.EndsWith(".txt"));
                prbImport.Maximum = files.ToList().Count;
                prbImport.Step = 1;
                prbImport.Value = 0;


                foreach (var file in files.ToList())
                {
                    Order objOrder = FormatParsing.ParsePathToFileName((string)file);
                    objOrder = FormatParsing.ParseContentIntoOrder((string)file, objOrder);
                    objOrders.Add(objOrder);
                }
                objOrders.Sort();

                if (bkgWorkForImporting.IsBusy != true)
                {
                    bkgWorkForImporting.RunWorkerAsync();
                }
                btnImportRecords.Enabled = false;
                
            }
        }

        /// <summary>
        /// using background thread to do the operation of database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bkgWorkForImporting_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            var bkgWorker = sender as BackgroundWorker;

            int counter = 0;
            foreach (Order objOrder in objOrders)
            {
                UserInfo objUserInfo = objOrder.User;
                new UserInfoManage().InsertUser(objUserInfo); //fill the userinfo table
                objOrder.User.UserNo = new UserInfoManage().GetLatestUserNo();  //get the UserNo inserted lately

                new OrderManage().InsertOrder(objOrder);  // fill the order table

                List<Item> lstItems = objOrder.LstItems;
                foreach (Item objItem in lstItems)
                {
                    new ItemManage().InsertItem(objItem); // fill the itemlist table
                }

                try
                {
                    bkgWorker.ReportProgress(counter++);
                }
                catch (NullReferenceException exception)
                {
                    Console.WriteLine(exception);
                    throw;
                }
            }


        }

        /// <summary>
        /// change the interface
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bkgWorkForImporting_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {

            prbImport.PerformStep();
            Order objOrder = objOrders[e.ProgressPercentage];
            lbProcessing.Text = string.Format("     Current Processing: Loading {0}{1}.txt",
                objOrder.OrderNo.ToString(), objOrder.Purchaser.ToString());
            int counter = e.ProgressPercentage;
            int total = objOrders.Count();
            string progressIndicate = string.Format("{0:P1}", counter * 1.0 / total);
            this.lbProgress.Text = progressIndicate;
            if (counter+1 == total)
            {
                this.lbProgress.Text = "100%";
            }
        }

        private void bkgWorkForImporting_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        /// <summary>
        /// Import the transaction records
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImportTransaction_Click(object sender, EventArgs e)
        {
            FileDialog fileSelector = new OpenFileDialog();
            fileSelector.Filter = "Text files (*.xls)|*.xls";
            string defaultPath = ExportFile.GetDefaultPath("dircPath");
            if (defaultPath != "")
            {
                fileSelector.InitialDirectory = defaultPath;
            }
            if (fileSelector.ShowDialog() == DialogResult.OK)
            {
                int pos = fileSelector.FileName.LastIndexOf(@"\", StringComparison.Ordinal);
                string path = fileSelector.FileName.Substring(0, pos);
                ExportFile.SetFolderPath("dircPath", path);
                lbFolder.Text = string.Format("     Selected Directory: {0}", path);
                prbImport.Step = 1;
                prbImport.Value = 0;
                objTransactions = FormatParsing.ParseContentIntoTransaction(fileSelector.FileName, objTransactions);
                prbImport.Maximum = objTransactions.Count;
                if (bkgWorkForTransaction.IsBusy != true)
                {
                    bkgWorkForTransaction.RunWorkerAsync();
                }
                btnImportTransaction.Enabled = false;

            }
        }

        private void bkgWorkForTransaction_DoWork(object sender, DoWorkEventArgs e)
        {
            var bkgWorker = sender as BackgroundWorker;

            int counter = 0;
            foreach (Transaction objTransaction in objTransactions)
            {
                new TransactionManage().InsertTransactionRecord(objTransaction);
                try
                {
                    bkgWorker.ReportProgress(counter++);
                }
                catch (NullReferenceException exception)
                {
                    Console.WriteLine(exception);
                    throw;
                }
            }
        }

        private void bkgWorkForTransaction_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            prbImport.PerformStep();
            lbProcessing.Text = string.Format("     Current Processing: Loading {0} transaction record", e.ProgressPercentage.ToString());
            int counter = e.ProgressPercentage;
            int total = objTransactions.Count();
            string progressIndicate = string.Format("{0:P1}", counter * 1.0 / total);
            this.lbProgress.Text = progressIndicate;
            if (counter + 1 == total)
            {
                this.lbProgress.Text = "100%";
            }
        }

        private void btnExportTransaction_Click(object sender, EventArgs e)
        {
            #region Generate .xls file
            FolderBrowserDialog fileSelector = new FolderBrowserDialog();
            string defaultPath = ExportFile.GetDefaultPath("dircPath");
            if (defaultPath != "")
            {
                fileSelector.SelectedPath = defaultPath;
            }
            string timeStamp = DateTime.Now.Date.ToString("ddMMyyyy");
            if (fileSelector.ShowDialog() == DialogResult.OK)
            {
                ExportFile.SetFolderPath("dircPath", fileSelector.SelectedPath);
                string path = string.Format(fileSelector.SelectedPath + @"\销售记录{0}.xls", timeStamp);
                lbFolder.Text = string.Format("     Selected Directory: {0}", path);
                string[] parameters = new string[2];
                parameters[0] = timeStamp;
                parameters[1] = path;
                if (bkgWorkForExporting.IsBusy != true)
                {
                    bkgWorkForExporting.RunWorkerAsync(parameters);
                }
                btnExportTransaction.Enabled = false;

            }

            #endregion
        }

        private void bkgWorkForExporting_DoWork(object sender, DoWorkEventArgs e)
        {
            var bkgWorker = sender as BackgroundWorker;
            string timeStamp = ((string[]) (e.Argument))[0];
            string path = ((string[]) (e.Argument))[1];
            ExportFile.ExportToExcel(path, new TransactionManage().GetTransactionList());
            try
            {
                int counter = 0;
                bkgWorker.ReportProgress(counter++);
                
            }
            catch (NullReferenceException exception)
            {
                Console.WriteLine(exception);
                throw;
            }

            MessageBox.Show("Generating 销售记录" + timeStamp + ".xls Sucessfully!");
        }

        private void bkgWorkForExporting_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            prbImport.PerformStep();
            prbImport.Maximum = 1;
            //lbProcessing.Text = string.Format("     Current Processing: Exporting {0} transaction record", e.ProgressPercentage.ToString());
            int counter = e.ProgressPercentage;
            int total = e.ProgressPercentage;
            string progressIndicate = string.Format("{0:P1}", counter * 1.0 / total);
            this.lbProgress.Text = progressIndicate;
            if (counter == total)
            {
                this.lbProgress.Text = "100%";
            }
            
        }

        private void DataImportingPage_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:

                    break;
                case Keys.Escape:
                    this.Close();
                    break;

                default:
                    break;
            }
        }

     
    }
}
