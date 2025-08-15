using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareSystem
{
    internal class Repository<T>
    {
        public List<T> items = new List<T>();

       public void Add(T item)
        {
            items.Add(item);
        }
        public List<T> GetAll()
        {
            return items;
        }
        public T? GetById(Func<T,bool> predicate)
        {
            return default(T);
        }
        public bool Remove(Func<T, bool> predicate) {  return false; }

    }
}
