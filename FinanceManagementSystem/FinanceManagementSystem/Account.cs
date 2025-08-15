using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceManagementSystem
{
     internal class Account
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }

        public Account(string accountNumber, decimal initialBalance) { 
            AccountNumber = accountNumber;
            Balance = initialBalance;
        }

       public virtual void ApplyTransaction(Transaction transaction) { 
            Balance -= transaction.Amount;
        }

    }
}
