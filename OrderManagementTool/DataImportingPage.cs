﻿using BLL;
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
        private readonly List<Order> objOrders = new List<Order>();
        private List<Transaction> objTransactions = new List<Transaction>();

        public DataImportingPage()
        {
            InitializeComponent();
            // Add key down event
            KeyDown += DataImportingPage_KeyDown;
            foreach (Control control in Controls)
                control.KeyDown += DataImportingPage_KeyDown;
        }

        private void DataImportingPage_KeyDown(object sender, KeyEventArgs e)
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

        #region Import .txt files

        /// <summary>
        ///     Import Orders
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImport_Click(object sender, EventArgs e)
        {
            var fileSelector = new FolderBrowserDialog();
            var defaultPath = ExportFile.GetDefaultPath("dircPath");
            if (defaultPath != "")
                fileSelector.SelectedPath = defaultPath;
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
                    var objOrder = FormatParsing.ParsePathToFileName(file);
                    objOrder = FormatParsing.ParseContentIntoOrder(file, objOrder);
                    objOrders.Add(objOrder);
                }
                objOrders.Sort();

                if (bkgWorkForImporting.IsBusy != true)
                    bkgWorkForImporting.RunWorkerAsync();
                btnImportRecords.Enabled = false;
            }
        }

        /// <summary>
        ///     using background thread to do the operation of database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bkgWorkForImporting_DoWork(object sender, DoWorkEventArgs e)
        {
            var bkgWorker = sender as BackgroundWorker;

            var counter = 0;
            foreach (var objOrder in objOrders)
            {
                var objUserInfo = objOrder.User;
                new UserInfoManage().InsertUser(objUserInfo); //fill the userinfo table
                objOrder.User.UserNo = new UserInfoManage().GetLatestUserNo(); //get the UserNo inserted lately

                new OrderManage().InsertOrder(objOrder); // fill the order table

                var lstItems = objOrder.LstItems;
                foreach (var objItem in lstItems)
                    new ItemManage().InsertItem(objItem); // fill the itemlist table

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
        ///     change the interface
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bkgWorkForImporting_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            prbImport.PerformStep();
            var objOrder = objOrders[e.ProgressPercentage];
            lbProcessing.Text = string.Format("     Current Processing: Loading {0}{1}.txt",
                objOrder.OrderNo, objOrder.Purchaser);
            var counter = e.ProgressPercentage;
            var total = objOrders.Count();
            var progressIndicate = string.Format("{0:P1}", counter * 1.0 / total);
            lbProgress.Text = progressIndicate;
            if (counter + 1 == total)
                lbProgress.Text = "100%";
        }

        #endregion

        #region Import transaction

        /// <summary>
        ///     Import the transaction records
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImportTransaction_Click(object sender, EventArgs e)
        {
            FileDialog fileSelector = new OpenFileDialog();
            fileSelector.Filter = "Text files (*.xls)|*.xls";
            var defaultPath = ExportFile.GetDefaultPath("dircPath");
            if (defaultPath != "")
                fileSelector.InitialDirectory = defaultPath;
            if (fileSelector.ShowDialog() == DialogResult.OK)
            {
                var pos = fileSelector.FileName.LastIndexOf(@"\", StringComparison.Ordinal);
                var path = fileSelector.FileName.Substring(0, pos);
                ExportFile.SetFolderPath("dircPath", path);
                lbFolder.Text = string.Format("     Selected Directory: {0}", path);
                prbImport.Step = 1;
                prbImport.Value = 0;
                objTransactions = FormatParsing.ParseContentIntoTransaction(fileSelector.FileName, objTransactions);
                prbImport.Maximum = objTransactions.Count;
                if (bkgWorkForTransaction.IsBusy != true)
                    bkgWorkForTransaction.RunWorkerAsync();
                btnImportTransaction.Enabled = false;
            }
        }

        private void bkgWorkForTransaction_DoWork(object sender, DoWorkEventArgs e)
        {
            var bkgWorker = sender as BackgroundWorker;

            var counter = 0;
            foreach (var objTransaction in objTransactions)
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
            lbProcessing.Text = string.Format("     Current Processing: Loading {0} transaction record",
                e.ProgressPercentage);
            var counter = e.ProgressPercentage;
            var total = objTransactions.Count();
            var progressIndicate = string.Format("{0:P1}", counter * 1.0 / total);
            lbProgress.Text = progressIndicate;
            if (counter + 1 == total)
                lbProgress.Text = "100%";
        }

        #endregion

        #region Export .txt files

        private void btnExportRecords_Click(object sender, EventArgs e)
        {
            #region Batch generate .txt file

            var fileSelector = new FolderBrowserDialog();
            var defaultPath = ExportFile.GetDefaultPath("dircPath");
            if (defaultPath != "")
                fileSelector.SelectedPath = defaultPath;
            var timeStamp = DateTime.Now.Date.ToString("ddMMyyyy");
            if (fileSelector.ShowDialog() == DialogResult.OK)
            {
                ExportFile.SetFolderPath("dircPath", fileSelector.SelectedPath);
                lbFolder.Text = string.Format("     Selected Directory: {0}", fileSelector.SelectedPath);

                prbImport.Maximum = new OrderManage().GetMaxOrderNo() - 1;
                prbImport.Step = 1;
                prbImport.Value = 0;

                if (bkgWorkForExportingRecords.IsBusy != true)
                    bkgWorkForExportingRecords.RunWorkerAsync(fileSelector.SelectedPath);
                btnExportRecords.Enabled = false;
            }

            #endregion
        }

        private void bkgWorkForExportingRecords_DoWork(object sender, DoWorkEventArgs e)
        {
            var bkgWorker = sender as BackgroundWorker;

            var counter = 0;
            var lstOrderNo = new OrderManage().GetAllOrderNoAndPurchaser();


            foreach (var orderInfo in lstOrderNo)
            {
                var objItems = new ItemManage().GetItemListByOrderNo(orderInfo.Key);
                var objUserInfo = new UserInfoManage().GetUserByOrderNo(orderInfo.Key);
                var orderContent = ExportFile.GenerateOrderContent(objItems, objUserInfo, true);
                var path = string.Format((string) e.Argument + @"\{0}{1}.txt", orderInfo.Key, orderInfo.Value);
                ExportFile.CreateOrderFile(path, orderContent);

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


            MessageBox.Show("Exporting all .txt files sucessfully!");
        }

        private void bkgWorkForExportingRecords_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            prbImport.PerformStep();

            lbProcessing.Text = string.Format("     Current Processing: Exporting {0}{1}.txt", e.ProgressPercentage,
                new OrderManage().GetPurchaserName(e.ProgressPercentage.ToString()));
            var counter = e.ProgressPercentage;
            var total = prbImport.Maximum;
            var progressIndicate = string.Format("{0:P1}", counter * 1.0 / total);
            lbProgress.Text = progressIndicate;
            if (counter + 2 > total)
                lbProgress.Text = "100%";
        }

        #endregion

        #region Export Transaction

        private void btnExportTransaction_Click(object sender, EventArgs e)
        {
            #region Generate .xls file

            var fileSelector = new FolderBrowserDialog();
            var defaultPath = ExportFile.GetDefaultPath("dircPath");
            if (defaultPath != "")
                fileSelector.SelectedPath = defaultPath;
            var timeStamp = DateTime.Now.Date.ToString("ddMMyyyy");
            if (fileSelector.ShowDialog() == DialogResult.OK)
            {
                ExportFile.SetFolderPath("dircPath", fileSelector.SelectedPath);
                var path = string.Format(fileSelector.SelectedPath + @"\销售记录{0}.xls", timeStamp);
                lbFolder.Text = string.Format("     Selected Directory: {0}", path);
                var parameters = new string[2];
                parameters[0] = timeStamp;
                parameters[1] = path;
                if (bkgWorkForExporting.IsBusy != true)
                    bkgWorkForExporting.RunWorkerAsync(parameters);
                btnExportTransaction.Enabled = false;
            }

            #endregion
        }

        private void bkgWorkForExporting_DoWork(object sender, DoWorkEventArgs e)
        {
            var bkgWorker = sender as BackgroundWorker;
            var timeStamp = ((string[]) e.Argument)[0];
            var path = ((string[]) e.Argument)[1];
            ExportFile.ExportToExcel(path, new TransactionManage().GetTransactionList());
            try
            {
                var counter = 0;
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
            var counter = e.ProgressPercentage;
            var total = e.ProgressPercentage;
            var progressIndicate = string.Format("{0:P1}", counter * 1.0 / total);
            lbProgress.Text = progressIndicate;
            if (counter == total)
                lbProgress.Text = "100%";
        }

        #endregion
    }
}