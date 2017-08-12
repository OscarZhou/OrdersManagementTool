using DAL.Helper;
using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DAL
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
            sqlBuilder.Append("select ItemNo, ItemDescription, Quantity, Price, Quantity*Price as TotalPrice from ItemList where OrderNo = {0}");

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
                        TotalPrice = Convert.ToDouble(objReaders["TotalPrice"]),
                        ItemNo = Convert.ToInt32(objReaders["ItemNo"])
                    }); 
                }
                objReaders.Close();
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

        public Item GetItemByItemNo(string itemNo)
        {
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("select * from ItemList where ItemNo = {0}");

            string sql = string.Format(sqlBuilder.ToString(), itemNo);
            try
            {
                SqlDataReader objReaders = SQLHelper.GetObjectCollection(sql);
                Item objItem = new Item();
                if (objReaders.Read())
                {
                    objItem.ItemNo = Convert.ToInt32(objReaders["ItemNo"]);
                    objItem.ItemDescription = objReaders["ItemDescription"].ToString();
                    objItem.Quantity = Convert.ToInt32(objReaders["Quantity"]);
                    objItem.UnitPrice = Convert.ToDouble(objReaders["Price"]);
                    
                }
                objReaders.Close();
                return objItem;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public int UpdateItem(Item objItem)
        {
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("update ItemList set ItemDescription='{0}', Quantity={1}, Price={2} where ItemNo = {3}");

            string sql = string.Format(sqlBuilder.ToString(), objItem.ItemDescription, objItem.Quantity, objItem.UnitPrice,
                objItem.ItemNo);

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

        public List<Item> GetItemPriceHistory()
        {
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append(
                "select ItemDescription, Price, CreateTime from [dbo].[ItemList] where Price<>0 order by CreateTime desc");
            try
            {
                List<Item> objItems = new List<Item>();
                SqlDataReader objReader = SQLHelper.GetObjectCollection(sqlBuilder.ToString());
                while (objReader.Read())
                {
                    objItems.Add(new Item()
                    {
                        ItemDescription = objReader["ItemDescription"].ToString(),
                        UnitPrice = Convert.ToDouble(objReader["Price"]),
                        CreateTime = Convert.ToDateTime(objReader["CreateTime"])
                    });
                }
                objReader.Close();
                return objItems;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
