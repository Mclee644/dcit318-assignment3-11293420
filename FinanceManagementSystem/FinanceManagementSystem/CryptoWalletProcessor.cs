using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceManagementSystem
{
    internal class CryptoWalletProcessor:ITransactionProcessor
    {
        public void Process(Transaction transaction)
        {
            Console.WriteLine($" AMOUNT: Ghc {transaction.Amount}, CATEGORY: {transaction.Category}");
        }
    }
}
