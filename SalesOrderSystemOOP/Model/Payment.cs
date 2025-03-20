using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesOrderSystemOOP.Model
{
    public abstract class Payment
    {
        public int Id { get; private set; }
        public decimal Amount { get; private set; }

        protected Payment(int id, decimal amount)
        {
            Id = id;
            Amount = amount;
        }
    }
}
