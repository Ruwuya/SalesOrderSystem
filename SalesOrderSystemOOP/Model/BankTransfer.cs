using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesOrderSystemOOP.Model
{
    public class BankTransfer : Payment
    {
        public string BankId { get; private set; }
        public string BankName { get; private set; }

        public BankTransfer(int id, decimal amount, string bankId, string bankName) : base(id, amount)
        {
            BankId = bankId;
            BankName = bankName;
        }
    }
}
