using DLL.Helper;
using Models;
using System;
using System.Data.SqlClient;
using System.Text;

namespace DLL
{
    public class ItemService
    {

        public int InsertItem(Item objItem)
        {
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("insert into ItemList (ItemDescription, Quantity, Price, OrderNo, CreateTime)");
            sqlBuilder.Append(" values('{0}', {1}, {2}, {3}, '{4}')");

            string sql = string.Format(sqlBuilder.ToString(), objItem.ItemDescription, objItem.Quantity, objItem.Price,
                objItem.OrderNo, DateTime.Now.Date);

            try
            {
                return SQLHelper.Update(sql);
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
