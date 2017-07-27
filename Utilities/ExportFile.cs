
using Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;


namespace Utilities
{
    public class ExportFile
    {
        /// <summary>
        /// Create .txt file for storing every order
        /// </summary>
        /// <param name="path"></param>
        /// <param name="orderContent"></param>
        public static void CreateOrderFile(string path, string orderContent)
        {
            FileStream fs = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs, Encoding.Unicode);
            sw.Write(orderContent);
            sw.Close();
            fs.Close();

        }


        /// <summary>
        /// Export .csv file for storing every transaction record
        /// </summary>
        /// <param name="path"></param>
        /// <param name="objTransactions"></param>
        public static void CreateTransactionFile(string path, List<Transaction> objTransactions)
        {
            FileStream fs = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs, Encoding.Unicode);
            sw.WriteLine("订单号,下单人,收款,付款,利润");
            foreach (Transaction objTransaction in objTransactions)
            {
                string record = string.Format(@"{0},{1},{2},{3},{4}", objTransaction.OrderNo, objTransaction.Purchaser,
                    objTransaction.SellingPrice, objTransaction.PurchasePrice, objTransaction.Profit);
                sw.WriteLine(record);
            }
            sw.Close();
            fs.Close();
        }

        /// <summary>
        /// Export transaction record to Excel
        /// </summary>
        /// <param name="path"></param>
        /// <param name="objTransactions"></param>
        public static void ExportToExcel(string path, List<Transaction> objTransactions)
        {
            #region Initialize office components
            Excel.Application xlApp = new Excel.Application();
            object misValue = System.Reflection.Missing.Value;
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Add(misValue);
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            //Excel._Worksheet xlWorksheet = (Excel.Worksheet)xlWorkbook.Worksheets.get_Item(1);
            #endregion


            xlWorksheet.Cells[1, 1] = "订单号";
            xlWorksheet.Cells[1, 2] = "下单人";
            xlWorksheet.Cells[1, 3] = "收款";
            xlWorksheet.Cells[1, 4] = "付款";
            xlWorksheet.Cells[1, 5] = "利润";

            for (int i = 2; i <= objTransactions.Count+1; i++)
            {
                xlWorksheet.Cells[i, 1] = objTransactions[i - 2].OrderNo.ToString();
                xlWorksheet.Cells[i, 2] = objTransactions[i - 2].Purchaser.ToString();
                xlWorksheet.Cells[i, 3] = objTransactions[i - 2].SellingPrice.ToString();
                xlWorksheet.Cells[i, 4] = objTransactions[i - 2].PurchasePrice.ToString();
                xlWorksheet.Cells[i, 5] = objTransactions[i - 2].Profit.ToString();

            }

            xlWorkbook.SaveAs(path, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            

            #region Close office components
            //cleanup
            GC.Collect();
            GC.WaitForPendingFinalizers();
            // release com objects to fully kill excel process from running in the background
            //Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorksheet);
            //close and release
            xlWorkbook.Close(true, misValue, misValue);
            Marshal.ReleaseComObject(xlWorkbook);

            //quit and release
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);
            #endregion
            
        }
        /// <summary>
        /// Read the config file
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetDefaultPath(string key)
        {
            string _value = string.Empty;
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (config.AppSettings.Settings[key] != null)
            {
                _value = config.AppSettings.Settings[key].Value;
            }
            return _value;
        }
        /// <summary>
        /// Set the config file
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void SetFolderPath(string key, string value)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings[key].Value = value;
            config.Save(ConfigurationSaveMode.Modified);

        }
    }
}
