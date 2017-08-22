
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

        #region Export Excel File

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

            #region Format parsing


            xlWorksheet.Cells[1, 1] = "Order No";
            xlWorksheet.Cells[1, 2] = "Purchaser";
            xlWorksheet.Cells[1, 3] = "Selling Price";
            xlWorksheet.Cells[1, 4] = "Purchase Price";
            xlWorksheet.Cells[1, 5] = "Profit";
            xlWorksheet.Cells[1, 6] = "Date";

            for (int i = 2; i <= objTransactions.Count + 1; i++)
            {
                xlWorksheet.Cells[i, 1] = objTransactions[i - 2].OrderNo.ToString();
                xlWorksheet.Cells[i, 2] = objTransactions[i - 2].Purchaser.ToString();
                xlWorksheet.Cells[i, 3] = objTransactions[i - 2].SellingPrice.ToString();
                xlWorksheet.Cells[i, 4] = objTransactions[i - 2].PurchasePrice.ToString();
                xlWorksheet.Cells[i, 5] = objTransactions[i - 2].Profit.ToString();
                xlWorksheet.Cells[i, 6] = objTransactions[i - 2].CreateTime.ToString("yy-MM-dd");
            }

            xlWorkbook.SaveAs(path, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);


            #endregion

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

        #endregion

        #region The operation for reading or writing order file

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
        /// View the order file
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string ReadOrderFile(string path)
        {
            StringBuilder contentBuilder = new StringBuilder();
            FileStream fs = null;
            if (!File.Exists(path))
            {
                fs = new FileStream(path, FileMode.Create);
            }
            else
            {
                fs = new FileStream(path, FileMode.Open);    
            }
            
            StreamReader sr = new StreamReader(fs, Encoding.Unicode);
            string content = "";
            while ((content = sr.ReadLine()) != null)
            {
                contentBuilder.Append(content + "\r\n");
            }
            sr.Close();
            fs.Close();
            return contentBuilder.ToString();
        }
        #endregion

        #region Default path

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
        #endregion

        #region The operation for browsing history file
        /// <summary>
        /// Create and update local file to store the browsing history of items
        /// </summary>
        /// <param name="path"></param>
        /// <param name="objItem"></param>
        public static void CreateOrUpdateBrowseHistoryFile(string path, Item objItem)
        {
            FileStream fs;
            if (!File.Exists(path))
            {
                fs = new FileStream(path, FileMode.Create);
            }
            else
            {
                fs = new FileStream(path, FileMode.Append);
            }
            StreamWriter sw = new StreamWriter(fs, Encoding.Unicode);
            sw.WriteLine(string.Format("{0},{1},{2}", objItem.UnitPrice, objItem.ItemDescription, objItem.CreateTime));
            sw.Close();
            fs.Close();
        }

        public static List<Item> ReadItemsFromBrowseHistoryFile(string path)
        {
            List<Item> objItems = new List<Item>();

            if (File.Exists(path))
            {
                FileStream fs = new FileStream(path, FileMode.Open);
                StreamReader sr = new StreamReader(fs, Encoding.Unicode);
                string infos = "";
                while ((infos = sr.ReadLine()) != null)
                {
                    string[] items = infos.Split(',');
                    objItems.Add(new Item()
                    {
                        UnitPrice = Convert.ToDouble(items[0]),
                        ItemDescription = items[1],
                        CreateTime = Convert.ToDateTime(items[2])
                    });
                }

                sr.Close();
                fs.Close();
            }
            return objItems;
        }

        #endregion


    }
}
