
using DAL.Helper;
using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DAL
{
    public class OrderService
    {
        /// <summary>
        /// insert order into database
        /// </summary>
        /// <param name="objOrder"></param>
        /// <returns></returns>
        public int InsertOrder(Order objOrder)
        {
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("insert into Orders (OrderNo, UserNo, ShipmentFee, ProductPrice, Purchaser, ReceivedStatus, CreateTime)");
            sqlBuilder.Append(" values({0},{1},{2},{3},'{4}', {5},'{6}')");

            string sql = string.Format(sqlBuilder.ToString(), objOrder.OrderNo, objOrder.User.UserNo,
                objOrder.ShipmentFee, objOrder.ProductPrice, objOrder.Purchaser, objOrder.ReceivedStatus, DateTime.Now.Date);

            try
            {
                return SQLHelper.Update(sql);
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            return 0;

        }

        /// <summary>
        /// get current order no
        /// </summary>
        /// <returns></returns>
        public int GetMaxOrderNo()
        {
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("select max(OrderNo) from Orders");

            try
            {
                return Convert.ToInt32(SQLHelper.GetSingleObject(sqlBuilder.ToString())) + 1;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public Order GetOrderByOrderNo(string orderNo)
        {
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("select UserInfo.UserName, UserInfo.PhoneNumber, UserInfo.UserAddress, UserInfo.CardNo, Orders.ShipmentFee, Orders.ProductPrice, Orders.Purchaser");
            sqlBuilder.Append(" from Orders inner join UserInfo on Orders.UserNo = UserInfo.UserNo where OrderNo = {0}");
            string sql = string.Format(sqlBuilder.ToString(), orderNo);
            Order objOrder = new Order();
            try
            {
                SqlDataReader objReaders = SQLHelper.GetObjectCollection(sql);
                while (objReaders.Read())
                {
                    objOrder.User.UserName = objReaders["UserName"].ToString();
                    objOrder.User.PhoneNumber = objReaders["PhoneNumber"].ToString();
                    objOrder.User.Address = objReaders["UserAddress"].ToString();
                    objOrder.User.CardNo = objReaders["CardNo"].ToString();

                    objOrder.OrderNo = Convert.ToInt32(orderNo);
                    objOrder.ShipmentFee = Convert.ToDouble(objReaders["ShipmentFee"]);
                    objOrder.ProductPrice = Convert.ToDouble(objReaders["ProductPrice"]);
                    objOrder.Purchaser = objReaders["Purchaser"].ToString();
                }
                objReaders.Close();
                return objOrder;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public int DeleteOrder(Order objOrder)
        {
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("delete from Orders where OrderNo = {0}");

            string sql = string.Format(sqlBuilder.ToString(), objOrder.OrderNo);

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

        public int UpdateOrder(Order objOrder)
        {
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("update Orders set Purchaser='{0}' where OrderNo={1}");

            string sql = string.Format(sqlBuilder.ToString(), objOrder.Purchaser, objOrder.OrderNo );
            try
            {
                return SQLHelper.Update(sql);
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            return 0;

        }

        public string GetPurchaserName(string orderNo)
        {
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("select Purchaser from Orders where OrderNo = {0}");
            string sql = string.Format(sqlBuilder.ToString(), orderNo);

            try
            {
                return (string) SQLHelper.GetSingleObject(sql);
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                throw;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public Dictionary<string, string> GetAllOrderNoAndPurchaser()
        {
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("select OrderNo, Purchaser from Orders");

            try
            {
                SqlDataReader objReaders = SQLHelper.GetObjectCollection(sqlBuilder.ToString());
                Dictionary<string, string> lstOrderNo = new Dictionary<string, string>();
                while (objReaders.Read())
                {
                    lstOrderNo.Add(objReaders["OrderNo"].ToString(), objReaders["Purchaser"].ToString());

                }
                objReaders.Close();
                return lstOrderNo;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                throw;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
