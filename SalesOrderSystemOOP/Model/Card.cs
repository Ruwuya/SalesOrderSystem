using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesOrderSystemOOP.Model
{
    public class Card : Payment
    {
        public string Number { get; private set; }
        public DateTime ExpirationDate { get; private set; }


        public Card(int id, decimal amount, string number, DateTime expiration) : base (id, amount)
        {
            Number = number;
            ExpirationDate = expiration;
        }
    }
}
