
using System;
using System.Collections.Generic;

namespace Models
{
    public class Order: IComparable<Order>
    {
        public int Id { get; set; }

        public int OrderNo { get; set; }

        public double ProductPrice { get; set; }

        public double ShipmentFee { get; set; }

        public string Purchaser { get; set; }

        public byte ReceivedStatus { get; set; }

        public DateTime CreateTime { get; set; }

        public UserInfo User = new UserInfo();

        public List<Item> LstItems = new List<Item>();



        public int CompareTo(Order other)
        {

            return this.OrderNo.CompareTo(other.OrderNo);
        }

    }
}
