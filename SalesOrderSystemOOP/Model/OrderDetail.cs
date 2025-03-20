using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesOrderSystemOOP.Model
{
    public class OrderDetail
    {
        public int Quantity { get; set; }
        public string DeliveryStatus { get; private set; }
        public Item OrderedItem { get; private set; }

        public OrderDetail(Item item, int quantity, string status = "Pending")
        {
            OrderedItem = item;
            Quantity = quantity;
            DeliveryStatus = status;
        }

        public decimal CalculateSubTotal() => Quantity * OrderedItem.GetPrice();
        public float CalculateWeight() => Quantity * OrderedItem.Weight;
    }
}
