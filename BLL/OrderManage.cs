using DAL;
using Models;
using System.Collections.Generic;

namespace BLL
{
    public class OrderManage
    {

        public int InsertOrder(Order objOrder)
        {
            return new OrderService().InsertOrder(objOrder);
        }

        public int GetMaxOrderNo()
        {
            return new OrderService().GetMaxOrderNo();
        }

        
        public Order GetOrderByOrderNo(string orderNo)
        {
            return new OrderService().GetOrderByOrderNo(orderNo);
        }

        public int DeleteOrder(Order objOrder)
        {
            return new OrderService().DeleteOrder(objOrder);
        }

        public int UpdateOrder(Order objOrder)
        {
            return new OrderService().UpdateOrder(objOrder);
        }

        public string GetPurchaserName(string orderNo)
        {
            return new OrderService().GetPurchaserName(orderNo);
        }

        public Dictionary<string, string> GetAllOrderNoAndPurchaser()
        {
            return new OrderService().GetAllOrderNoAndPurchaser();
        }
    }
}
