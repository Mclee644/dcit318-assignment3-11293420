using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceManagementSystem
{
    sealed internal class SavingsAccount:Account
    {
        public SavingsAccount(string accountNumber, decimal initialBalance):base(accountNumber,initialBalance)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
        }
        public override void ApplyTransaction(Transaction transaction)
        {
            if (transaction.Amount > Balance)
            {
                Console.WriteLine($"insufficient funds {transaction}");
            }
            else
            {
                Balance -= transaction.Amount;
            }
            
        }
    }
}
