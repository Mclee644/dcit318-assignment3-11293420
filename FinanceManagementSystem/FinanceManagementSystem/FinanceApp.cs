using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceManagementSystem
{
    internal class FinanceApp
    {
        List<Transaction> _transactions = new() { };
        public void Run()
        {
            SavingsAccount susu = new SavingsAccount("11293420",50000);
       
            Transaction transaction1 = new Transaction(1,DateTime.Now, 5000, "Groceries");
            Transaction transaction2 = new Transaction(2, DateTime.Now, 9000, "Utilities");
            Transaction transaction3 = new Transaction(3, new DateTime(2025,08,15), 15000,"Entertainment");

            MobileMoneyProcessor mtnMomo = new MobileMoneyProcessor();
            mtnMomo.Process(transaction1);

            BankTransferProcessor bankTransferProcessor = new BankTransferProcessor();
            bankTransferProcessor.Process(transaction2);

            CryptoWalletProcessor cryptoWalletProcessor = new CryptoWalletProcessor();
            cryptoWalletProcessor.Process(transaction3);

            susu.ApplyTransaction(transaction1);
            susu.ApplyTransaction(transaction2);
            susu.ApplyTransaction(transaction3);

            _transactions.Add(transaction1);
            _transactions.Add(transaction2);
            _transactions.Add(transaction3);

      //      foreach(Transaction transaction in _transactions)
      //      {
      //          Console.WriteLine(transaction);
      //      }

        }
    }
}
