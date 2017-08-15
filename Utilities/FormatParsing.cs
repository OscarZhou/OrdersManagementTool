
using Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using Excel = Microsoft.Office.Interop.Excel;


namespace Utilities
{
    public class FormatParsing
    {

        #region ImportOrders

        /// <summary>
        /// 解析订单的文件名
        /// parse the file name of the orders
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static Order ParsePathToFileName(string path)
        {
            int pos = path.LastIndexOf(@"\", StringComparison.Ordinal);
            string fileName = path.Substring(pos + 1);
            string pattern = @"[^\x00-\xff]";
            string[] substrings = Regex.Split(fileName, pattern);
            Console.WriteLine(substrings[1]);
            Order objOrder = new Order();
            objOrder.OrderNo = Convert.ToInt32(substrings[0]);
            string tmpName = Regex.Replace(fileName, @"\d", "");
            objOrder.Purchaser = Regex.Replace(tmpName, @".txt", "");
            objOrder.ReceivedStatus = Convert.ToByte(true);
            return objOrder;
        }

        /// <summary>
        /// 解析订单文件的内容
        /// parse the contents of the orders
        /// </summary>
        /// <param name="path"></param>
        /// <param name="objOrder"></param>
        /// <returns></returns>
        public static Order ParseContentIntoOrder(string path, Order objOrder)
        {
            StreamReader orderFile = new StreamReader(path, UnicodeEncoding.GetEncoding("GB2312"));
            string fileRow = null;
            Regex regNum = new Regex("^[0-9]");
            while ((fileRow = orderFile.ReadLine()) != null)
            {
                if (fileRow.Equals(""))
                {
                    continue;
                }
                string[] substrings;
                if (fileRow.StartsWith("收件人"))
                {
                    substrings = fileRow.Split('：');
                    objOrder.User.UserName = substrings[1].Trim();
                }
                else if (fileRow.StartsWith("电话"))
                {
                    substrings = fileRow.Split('：');
                    if (substrings[1].StartsWith("0211376664"))
                    {
                        continue;
                    }
                    objOrder.User.PhoneNumber = substrings[1].Trim();
                }
                else if (fileRow.StartsWith("地址"))
                {
                    substrings = fileRow.Split('：');
                    objOrder.User.Address = substrings[1].Trim();
                }
                else if (fileRow.StartsWith("身份证号")||fileRow.StartsWith("身份证号"))
                {
                    substrings = fileRow.Split('：');
                    objOrder.User.CardNo = substrings[1].Trim();
                }
                else if (regNum.IsMatch(fileRow))
                {
                    string pattern = @"[^0-9]";
                    string tmpRow = fileRow.Substring(2);
                    substrings = tmpRow.Split('，');
                    if (substrings.Length == 1)
                    {
                        continue;
                    }
                    Item item = new Item();
                    item.ItemDescription = substrings[0].Trim().Replace("'","");//get the item name

                    string[] quantitStrings = Regex.Split(substrings[1].Trim(), pattern);
                    item.Quantity = Convert.ToInt32(quantitStrings[quantitStrings.Length - 1].Trim());//get the item quantity
                    if (substrings.Length > 2)
                    {
                        if (substrings[2].Trim() != "")
                        {
                            item.UnitPrice = Convert.ToDouble(substrings[2].Trim());//get the item price   
                        }
                    }
                    item.OrderNo = objOrder.OrderNo;
                    objOrder.LstItems.Add(item);
                }
            }
            orderFile.Close();
            return objOrder;
        }

        #endregion

        #region ImportTransactionRecords
        public static List<Transaction> ParseContentIntoTransaction(string path, List<Transaction> objTransactions)
        {
            #region Initialize office components
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(path);
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;
            #endregion
            

            int rowCount = 300;
            // excel is not zero based
            for (int i = 2; i <= rowCount; i++)
            {
                if (xlRange.Cells[i, 1].Value2 == null)
                {
                    break;
                }
                string strDate = DateTime.FromOADate(Convert.ToInt32(xlRange.Cells[i, 6].Value2)).ToString("d");
                objTransactions.Add(new Transaction()
                {
                    OrderNo = Convert.ToInt32(xlRange.Cells[i, 1].Value2),
                    Purchaser = xlRange.Cells[i, 2].Value2.ToString(),
                    SellingPrice = Convert.ToDouble(xlRange.Cells[i, 3].Value2),
                    PurchasePrice = Convert.ToDouble(xlRange.Cells[i, 4].Value2),
                    Profit = Convert.ToDouble(xlRange.Cells[i, 5].Value2),
                    CreateTime = DateTime.Parse(strDate),
                    OrderStatus = Convert.ToByte(true)
                });

            }

            #region Close office components
            //cleanup
            GC.Collect();
            GC.WaitForPendingFinalizers();
            // release com objects to fully kill excel process from running in the background
            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorksheet);
            //close and release
            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);

            //quit and release
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);
            #endregion

            return objTransactions;
        }
        #endregion
    }
}
