
using DLL.Helper;
using Models;
using System;
using System.Data.SqlClient;
using System.Text;

namespace DLL
{
    public class OrderService
    {

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

    }
}
