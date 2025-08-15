using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceManagementSystem
{
    internal class MobileMoneyProcessor:ITransactionProcessor
    {
        public void Process(Transaction transaction)
        {
            Console.WriteLine($" AMOUNT: GHc {transaction.Amount}, CATEGORY: {transaction.Category}");
        }
    }
}
