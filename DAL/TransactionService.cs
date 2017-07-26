
using DLL.Helper;
using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DLL
{
    public class TransactionService
    {
        /// <summary>
        /// insert a transaction record
        /// </summary>
        /// <param name="objTransaction"></param>
        /// <returns></returns>
        public int InsertTransactionRecord(Transaction objTransaction)
        {
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append(
                "insert into TransactionList (PurchasePrice, SellingPrice, Profit, OrderNo, Purchaser, OrderStatus, CreateTime)");
            sqlBuilder.Append(" values({0}, {1}, {2}, {3}, '{4}', {5}, '{6}')");

            string sql = string.Format(sqlBuilder.ToString(), objTransaction.PurchasePrice, objTransaction.SellingPrice,
                objTransaction.Profit, objTransaction.OrderNo, objTransaction.Purchaser, objTransaction.OrderStatus, DateTime.Now.Date );

            try
            {
                return SQLHelper.Update(sql);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        /// <summary>
        /// get all transaction
        /// </summary>
        /// <returns></returns>
        public List<Transaction> GetTransactionList()
        {
            List<Transaction> objTransactions = new List<Transaction>();
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("select * from TransactionList");

            SqlDataReader objReaders = SQLHelper.GetObjectCollection(sqlBuilder.ToString());
            while (objReaders.Read())
            {
                objTransactions.Add(new Transaction()
                {
                    OrderNo = Convert.ToInt32(objReaders["OrderNo"]),
                    Purchaser = objReaders["Purchaser"].ToString(),
                    PurchasePrice = Convert.ToDouble(objReaders["PurchasePrice"]),
                    SellingPrice = Convert.ToDouble(objReaders["SellingPrice"]),
                    Profit = Convert.ToDouble(objReaders["Profit"]),
                    CreateTime = Convert.ToDateTime(objReaders["CreateTime"])
                });
            }
            return objTransactions;
        }

        /// <summary>
        /// get undone transaction list
        /// </summary>
        /// <returns></returns>
        public List<Transaction> GetUndoneTransactionList()
        {
            List<Transaction> objTransactions = new List<Transaction>();
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("select * from TransactionList where OrderStatus <> 1");

            SqlDataReader objReaders = SQLHelper.GetObjectCollection(sqlBuilder.ToString());
            while (objReaders.Read())
            {
                objTransactions.Add(new Transaction()
                {
                    OrderNo = Convert.ToInt32(objReaders["OrderNo"]),
                    Purchaser = objReaders["Purchaser"].ToString(),
                    PurchasePrice = Convert.ToDouble(objReaders["PurchasePrice"]),
                    SellingPrice = Convert.ToDouble(objReaders["SellingPrice"]),
                    Profit = Convert.ToDouble(objReaders["Profit"]),
                    CreateTime = Convert.ToDateTime(objReaders["CreateTime"])
                });
            }
            return objTransactions;
        }

        /// <summary>
        /// get an transaction record by OrderNo
        /// </summary>
        /// <param name="orderNo"></param>
        /// <returns></returns>
        public Transaction GetTransactionRecordByOrderNo(int orderNo)
        {
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("select * from TransactionList where OrderNo = {0}");

            string sql = string.Format(sqlBuilder.ToString(), orderNo);

            try
            {
                SqlDataReader objReader = SQLHelper.GetObjectCollection(sql);
                Transaction objTransaction = null;
                while (objReader.Read())
                {
                    objTransaction = new Transaction()
                    {
                        OrderNo = Convert.ToInt32(objReader["OrderNo"]),
                        Purchaser = objReader["Purchaser"].ToString(),
                        SellingPrice = Convert.ToDouble(objReader["SellingPrice"]),
                        PurchasePrice = Convert.ToDouble(objReader["PurchasePrice"]),
                        Profit = Convert.ToDouble(objReader["Profit"]),
                        OrderStatus = Convert.ToByte(objReader["OrderStatus"]),
                        CreateTime = Convert.ToDateTime(objReader["CreateTime"])
                    };
                }
                objReader.Close();
                return objTransaction;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        /// <summary>
        /// update a transaction record
        /// </summary>
        /// <param name="objTransaction"></param>
        /// <returns></returns>
        public int UpdateTransactionRecord(Transaction objTransaction)
        {
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append(
                "update TransactionList set PurchasePrice = {0}, SellingPrice = {1}, Profit = {2}, OrderStatus = {3}");
            sqlBuilder.Append(" where OrderNo = {4}");

            string sql = string.Format(sqlBuilder.ToString(), objTransaction.PurchasePrice, objTransaction.SellingPrice,
                objTransaction.Profit, objTransaction.OrderStatus, objTransaction.OrderNo);

            try
            {
                return SQLHelper.Update(sql);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        /// <summary>
        /// get the transaction list by name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public List<Transaction> GetTransactionListByName(string name)
        {
            List<Transaction> objTransactions = new List<Transaction>();
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("select * from TransactionList where Purchaser like '%{0}%'");

            string sql = string.Format(sqlBuilder.ToString(), name);

            try
            {
                SqlDataReader objReaders = SQLHelper.GetObjectCollection(sql);
                while (objReaders.Read())
                {
                    objTransactions.Add(new Transaction()
                    {
                        OrderNo = Convert.ToInt32(objReaders["OrderNo"]),
                        Purchaser = objReaders["Purchaser"].ToString(),
                        PurchasePrice = Convert.ToDouble(objReaders["PurchasePrice"]),
                        SellingPrice = Convert.ToDouble(objReaders["SellingPrice"]),
                        Profit = Convert.ToDouble(objReaders["Profit"]),
                        CreateTime = Convert.ToDateTime(objReaders["CreateTime"])
                    });
                }
                return objTransactions;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        /// <summary>
        /// get transaction list by Purchaser and sorting type
        /// </summary>
        /// <param name="name"></param>
        /// <param name="sortingType"></param>
        /// <returns></returns>
        public List<Transaction> GetTransactionList(string name, int sortingType)
        {
            List<Transaction> objTransactions = new List<Transaction>();
            StringBuilder sqlBuilder = new StringBuilder();

            if (name == "Input Name" || name == "")
            {
                sqlBuilder.Append("select * from TransactionList ");
            }
            else
            {
                sqlBuilder.Append("select * from TransactionList where Purchaser like '%{0}%' ");
            }

            switch (sortingType)
            {
                case 0:
                    sqlBuilder.Append("order by OrderNo asc");
                    break;
                case 1:
                    sqlBuilder.Append("order by OrderNo desc");
                    break;
                case 2:
                    sqlBuilder.Append("order by Profit asc");
                    break;
                case 3:
                    sqlBuilder.Append("order by Profit desc");
                    break;
                default:
                    break;
            }

            string sql = null;
            if (name == "Input Name" || name == "")
            {
                sql = sqlBuilder.ToString();
            }
            else
            {
                sql = string.Format(sqlBuilder.ToString(), name);
            }

            SqlDataReader objReaders = SQLHelper.GetObjectCollection(sql);
            while (objReaders.Read())
            {
                objTransactions.Add(new Transaction()
                {
                    OrderNo = Convert.ToInt32(objReaders["OrderNo"]),
                    Purchaser = objReaders["Purchaser"].ToString(),
                    PurchasePrice = Convert.ToDouble(objReaders["PurchasePrice"]),
                    SellingPrice = Convert.ToDouble(objReaders["SellingPrice"]),
                    Profit = Convert.ToDouble(objReaders["Profit"]),
                    CreateTime = Convert.ToDateTime(objReaders["CreateTime"])
                });
            }
            return objTransactions;
        }

        public int DeleteTransactionRecordByOrderNo(string orderNo)
        {
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("delete from TransactionList where OrderNo = {0}");

            string sql = string.Format(sqlBuilder.ToString(), orderNo);

            try
            {
                return SQLHelper.Update(sql);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
