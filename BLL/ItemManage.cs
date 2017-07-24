
using DLL;
using Models;
using System.Collections.Generic;

namespace BLL
{
    public class ItemManage
    {
        public int InsertItem(Item objItem)
        {
            return new ItemService().InsertItem(objItem);
        }

        public List<Item> GetItemListByOrderNo(string orderNo)
        {
            return new ItemService().GetItemListByOrderNo(orderNo);
        }
    }
}
