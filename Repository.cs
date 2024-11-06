using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneriskaKlasser2
{
    public class Repository<T> where T : class, IIdentifable, new()
    {
        private readonly List<T> _items = new List<T>();

        // Create
        public void Add(T item)
        {
            _items.Add(item);
        }

        // Read
        public T GetById(int id)
        {
            return _items.FirstOrDefault(item => item.Id == id)!;
        }
        public IEnumerable<T> GetAll()
        {
            return _items;
        }

        // Update
        public void Update(T item)
        {
            var index = _items.FindIndex(existingItem => existingItem.Id == item.Id);
            if (index != -1)
            {
                _items[index] = item;
            }
        }
        // Delete
        public void Delete(int id)
        {
            var item = GetById(id);
            if (item != null)
            {
                _items.Remove(item);
            }
        }
    }
}
