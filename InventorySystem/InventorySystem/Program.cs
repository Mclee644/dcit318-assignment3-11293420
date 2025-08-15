using InventorySystem;
using System;
class Program
{
   
    static void Main(string[] args)
    {
        string title = """

            |           INVENTORY SYSTEM            |


            """;
        Console.WriteLine(title);
        InventoryApp iclare = new InventoryApp();
        iclare.SaveDate();

        iclare.LoadData();  

        

    }
}