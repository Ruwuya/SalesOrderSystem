using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesOrderSystemOOP.Model
{
    public class Order
    {
        public int Id { get; private set; }
        public DateTime CreateDate { get; private set; }
        public OrderStatus Status { get; private set; }

        private List<OrderDetail> _orderDetails;

        private List<Payment> _payments;

        public IReadOnlyList<OrderDetail> OrderDetails => _orderDetails.AsReadOnly();
        public IReadOnlyList<Payment> Payments => _payments.AsReadOnly();

        public Order(int id)
        {
            Id = id;
            CreateDate = DateTime.Now;
            Status = OrderStatus.Created;
            _orderDetails = new List<OrderDetail>();
            _payments = new List<Payment>();
        }

        public void AddOrderDetail(Item item, int quantity)
        {
            _orderDetails.Add(new OrderDetail(item, quantity));
        }

        public void AddPayment(Payment payment)
        {
            _payments.Add(payment);
        }

        public decimal GetTotalAmount()
        {
            decimal total = 0;
            foreach (var detail in _orderDetails)
            {
                total += detail.CalculateSubTotal();
            }
            return total;
        }
    }
}
