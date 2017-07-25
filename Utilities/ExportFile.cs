﻿
using Models;
using System;
using System.Collections.Generic;
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

        public static void ExportToExcel(string path, List<Transaction> objTransactions)
        {
            #region Initialize office components
            Excel.Application xlApp = new Excel.Application();
            object misValue = System.Reflection.Missing.Value;
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Add(misValue);
            //Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel._Worksheet xlWorksheet = (Excel.Worksheet)xlWorkbook.Worksheets.get_Item(1);
            //Excel.Range xlRange = xlWorksheet.UsedRange;
            #endregion


            xlWorksheet.Cells[1, 1].Value2 = "订单号";
            xlWorksheet.Cells[1, 2].Value2 = "下单人";
            xlWorksheet.Cells[1, 3].Value2 = "收款";
            xlWorksheet.Cells[1, 4].Value2 = "付款";
            xlWorksheet.Cells[1, 5].Value2 = "利润";

            for (int i = 2; i <= objTransactions.Count; i++)
            {
                xlWorksheet.Cells[i, 1] = objTransactions[i - 2].OrderNo.ToString();
                xlWorksheet.Cells[i, 2] = objTransactions[i - 2].Purchaser.ToString();
                xlWorksheet.Cells[i, 3] = objTransactions[i - 2].SellingPrice.ToString();
                xlWorksheet.Cells[i, 4] = objTransactions[i - 2].PurchasePrice.ToString();
                xlWorksheet.Cells[i, 5] = objTransactions[i - 2].Profit.ToString();

            }
            xlWorkbook.SaveAs(path, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkbook.Close(true, misValue, misValue);

            #region Close office components
            //cleanup
            GC.Collect();
            GC.WaitForPendingFinalizers();
            // release com objects to fully kill excel process from running in the background
            //Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorksheet);
            //close and release
            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);

            //quit and release
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);
            #endregion
            
        }
    }
}
