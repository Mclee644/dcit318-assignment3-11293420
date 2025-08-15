using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    internal class InventoryLogger<T>
    {
        public List<T> _log;
        string _filePath;

        public void Add(T item)
        {
            _log.Add(item);
        }
        public List<T> GetAll() {
            return default;
        }

        public void SaveToFile(string filePath) { }
        public void LoadFromFile(string filePath) { }
    }
}
