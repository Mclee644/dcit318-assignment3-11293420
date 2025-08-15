using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseInventoryManagementSystem
{
    internal class ElectronicItem: IInventoryItem
    {
        int Id;

        string Name;

        int Quantity;
        string Brand { get; set; }
        int WarrantyMonths { get; set; }
        ElectronicItem(int id, string name, int quantity, string brand, int warrantyMonths)
        { 
            Id = id;
            Name = name;
            Quantity = quantity;
            Brand = brand;
            WarrantyMonths = warrantyMonths;
        
        }
    }
}
