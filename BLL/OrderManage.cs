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
    }
}
