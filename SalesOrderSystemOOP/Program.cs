using SalesOrderSystemOOP.Model;

namespace SalesOrderSystemOOP
{
    class Program
    {
        static void Main()
        {
            // See https://aka.ms/new-console-template for more information
            Console.WriteLine("Hello, World!");

            // Creating customer
            Customer customer = new Customer(1, "John Doe", "123 Main St", "555-1234", "john@example.com", true);

            // Creating order
            Order order = new Order(101);

            // Creating items
            Item laptop = new Item(201, "Laptop", 2.5f, 1000m);
            Item mouse = new Item(202, "Wireless Mouse", 0.2f, 50m);

            // Adding order details
            order.AddOrderDetail(laptop, 1);
            order.AddOrderDetail(mouse, 2);

            // Adding payment
            Payment cardPayment = new Card(301, 1100m, "1234-5678-9876-5432", DateTime.Now.AddYears(2));
            order.AddPayment(cardPayment);

            // Assign order to customer
            customer.AddOrder(order);

            // Output order details
            Console.WriteLine($"Customer: {customer.Name}");
            Console.WriteLine($"Order ID: {order.Id}, Date: {order.CreateDate}, Status: {order.Status}");
            Console.WriteLine($"Total Amount: {order.GetTotalAmount():C}");

            foreach (var detail in order.OrderDetails)
            {
                Console.WriteLine($"- {detail.Quantity} x {detail.OrderedItem.Description} @ {detail.OrderedItem.GetPrice():C}");
            }
        }
    }

}
