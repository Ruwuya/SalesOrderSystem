using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesOrderSystemOOP;
using SalesOrderSystemOOP.Model;
using Xunit;

namespace SalesOrderSystemOOP.Test
{
    public class OrderTest
    {
        [Fact]
        public void OrderShouldHaveValidCreateDate()
        {
            // Initialisere objekter og sætter værdier i dataen
            // Arrange
            var order = new Order(1);

            // Kalder metoder under testen med parametere
            // Act
            DateTime orderDate = order.CreateDate;

            // Verificere metoden opfører sig som den skal
            // Assert
            Assert.True(orderDate <= DateTime.Now, $"Order creation date ({orderDate}) cannot be in the future");
        }
    }
}
