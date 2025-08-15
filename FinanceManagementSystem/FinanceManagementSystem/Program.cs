using FinanceManagementSystem;
using System;

class Program
{

    static void Main(string[] args)
    {
        string title = """

            |       FINANCE MANAGEMENT SYSTEM       |

            """;
        Console.WriteLine(title);
        FinanceApp iclare = new FinanceApp();
        iclare.Run();


    }

}

public record Transaction(int Id,DateTime Date, decimal Amount, string Category);