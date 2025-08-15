using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceManagementSystem
{
    public interface ITransactionProcessor
    {
      public  void Process(Transaction transaction);
    }
}
