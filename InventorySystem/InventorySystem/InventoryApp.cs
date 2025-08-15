using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    internal class InventoryApp
    {

        InventoryLogger<InventoryItem> _logger = new InventoryLogger<InventoryItem>();
        public void SeedSampleData()
        {

        }
        public void SaveDate()
        {
            // SaveToFile();
            _logger.SaveToFile("save.txt");
        }

        public void LoadData()
        {
           _logger.LoadFromFile("save.txt");
        }

    }

     
}
