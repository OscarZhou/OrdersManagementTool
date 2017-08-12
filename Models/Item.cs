
using System;

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
}
