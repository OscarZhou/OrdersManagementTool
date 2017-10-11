
using System;
using System.Collections.Generic;

namespace Models
{
    public class Item
    {
        public int ItemNo { get; set; }

        public string ItemDescription { get; set; }

        public int Quantity { get; set; }

        public double UnitPrice { get; set; }

        public int OrderNo { get; set; }

        public double TotalPrice { get; set; }

        public DateTime CreateTime { get; set; }

    }

    #region Construct the comparer to clear up the browsing history
    /// <summary>
    /// The comparer used for removing the repeated record
    /// </summary>
    public class ItemNoComparer : IEqualityComparer<Item>
    {
        public bool Equals(Item item1, Item item2)
        {
            if (item1.ItemDescription.Equals(item2.ItemDescription) && item1.UnitPrice.Equals(item2.UnitPrice))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetHashCode(Item item)
        {
            if (item == null)
            {
                return 0;
            }
            return item.ItemDescription.GetHashCode();
        }
    }
    #endregion

    
}
