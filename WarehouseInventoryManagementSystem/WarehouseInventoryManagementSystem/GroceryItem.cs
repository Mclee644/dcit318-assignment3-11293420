using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseInventoryManagementSystem
{
    internal class GroceryItem:IInventoryItem
    {
        int Id;
        string Name;
        int Quantity;
        DateTime ExpiryDate {  get; set; }

        public GroceryItem(int id, string name, int quantity, DateTime expiryDate) 
        {
            Id = id;
            Name = name;
            Quantity = quantity;
            ExpiryDate = expiryDate;
        
        
        }
    }
}
