using SalesOrderSystemOOP.Model;
namespace SalesOrderSystemOOP.UnitTest;

[TestClass]
public class OrderTest
{
    [TestMethod]
    public void OrderShouldHaveValidCreate()
    {
        var order = new Order(101);

        DateTime orderDate = order.CreateDate;

        Assert.IsTrue(orderDate <= DateTime.Now, $"Order creation date ({orderDate}) should not be in the future.");
    }
}
