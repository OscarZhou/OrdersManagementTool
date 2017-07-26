using DLL;
using Models;

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
    }
}
