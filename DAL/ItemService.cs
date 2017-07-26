using DLL.Helper;
using Models;
using System;
using System.Collections.Generic;
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

            string sql = string.Format(sqlBuilder.ToString(), objItem.ItemDescription, objItem.Quantity, objItem.UnitPrice,
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


        public List<Item> GetItemListByOrderNo(string orderNo)
        {
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("select ItemDescription, Quantity, Price, Quantity*Price as TotalPrice from ItemList where OrderNo = {0}");

            string sql = string.Format(sqlBuilder.ToString(), Convert.ToInt32(orderNo));

            List<Item> objItems = new List<Item>();
            try
            {
                SqlDataReader objReaders = SQLHelper.GetObjectCollection(sql);
                while (objReaders.Read())
                {
                    objItems.Add(new Item()
                    {
                        ItemDescription = objReaders["ItemDescription"].ToString(),
                        Quantity = Convert.ToInt32(objReaders["Quantity"]),
                        UnitPrice = Convert.ToDouble(objReaders["Price"]),
                        TotalPrice = Convert.ToDouble(objReaders["TotalPrice"])
                    }); 
                }
                return objItems;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public int DeleteItemListByOrderNo(string orderNo)
        {
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("delete from ItemList where OrderNo = {0}");

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
