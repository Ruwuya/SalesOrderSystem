using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesOrderSystemOOP.Model
{
    public class Item
    {
        public int Id { get; private set; }
        public string Description { get; private set; }
        public float Weight { get; private set; }
        public decimal Price { get; set; }

        public Item(int id, string description, float weight, decimal price)
        {
            Id = id;
            Description = description;
            Weight = weight;
            Price = price;
        }
        public decimal GetPrice() => Price;
    }
}
