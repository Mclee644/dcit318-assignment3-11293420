using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceManagementSystem
{
    public class BankTransferProcessor: ITransactionProcessor
    {
        public void Process(Transaction transaction)
        {
            Console.WriteLine($" AMOUNT :GHc {transaction.Amount}, CATEGORY: {transaction.Category}");
        }
    }
}
