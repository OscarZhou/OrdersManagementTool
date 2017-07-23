
using DLL;
using Models;

namespace BLL
{
    public class ItemManage
    {
        public int InsertItem(Item objItem)
        {
            return new ItemService().InsertItem(objItem);
        }
    }
}
