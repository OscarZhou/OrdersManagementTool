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

        }

        /// <summary>
        /// Import Orders
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImport_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fileSelector = new FolderBrowserDialog();
            if (fileSelector.ShowDialog() == DialogResult.OK)
            {
                lbFolder.Text = fileSelector.SelectedPath;                    
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
                
            }

            if (bkgWorkForImporting.IsBusy != true)
            {
                bkgWorkForImporting.RunWorkerAsync();
            }
            btnImportRecords.Enabled = false;
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
            lbProcessing.Text = "The current file: " + objOrder.OrderNo.ToString() + objOrder.Purchaser.ToString() +
                                ".txt";
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
            FolderBrowserDialog fileSelector = new FolderBrowserDialog();
            if (fileSelector.ShowDialog() == DialogResult.OK)
            {
                lbFolder.Text = fileSelector.SelectedPath;
                var files = Directory.GetFiles(fileSelector.SelectedPath).Where(name => name.EndsWith(".xlsx"));
                prbImport.Maximum = files.ToList().Count;
                prbImport.Step = 1;
                prbImport.Value = 0;

                string file = files.ToList()[1];
                objTransactions = FormatParsing.ParseContentIntoTransaction(file, objTransactions);
            }

            if (bkgWorkForTransaction.IsBusy != true)
            {
                bkgWorkForTransaction.RunWorkerAsync();
            }
            btnImportTransaction.Enabled = false;
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
            lbProcessing.Text = "Loading" + e.ProgressPercentage.ToString() + " transaction record";
            int counter = e.ProgressPercentage;
            int total = objTransactions.Count();
            string progressIndicate = string.Format("{0:P1}", counter * 1.0 / total);
            this.lbProgress.Text = progressIndicate;
            if (counter + 1 == total)
            {
                this.lbProgress.Text = "100%";
            }
        }




    }
}
