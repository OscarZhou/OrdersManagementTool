using System;

namespace Models
{
    public class Transaction
    {
        public double PurchasePrice { get; set; }

        public double SellingPrice { get; set; }

        public double Profit { get; set; }

        public string Purchaser { get; set; }

        public int OrderNo { get; set; }

        public byte OrderStatus { get; set; }

        public DateTime CreateTime { get; set; }

    }
}
