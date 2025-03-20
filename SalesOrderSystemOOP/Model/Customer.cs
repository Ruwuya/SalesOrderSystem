using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesOrderSystemOOP.Model
{
    public class Customer
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string DeliveryAddress { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Email { get; private set; }
        public bool Active { get; private set; }
        public List<Order> Orders { get; private set; }

        public Customer(int id, string name, string deliveryAddress, string phonenumber, string email, bool active)
        {
            Id = id;
            Name = name;
            DeliveryAddress = deliveryAddress;
            PhoneNumber = phonenumber;
            Email = email;
            Active = active;
            Orders = new List<Order>();
        }

        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }
    }
}
