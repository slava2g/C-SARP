using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР6
{
    public class LibraryCatalog<T> where T : ILibraryItem
    {
        private List<T> _items = new List<T>();

        public void AddItem(T item)
        {
            if (item != null)
            {
                _items.Add(item);
            }
        }

        public List<T> GetAllItems()
        {
            return new List<T>(_items);
        }

        public T GetItemById(int id)
        {
            return _items.FirstOrDefault(i => i.Id == id);
        }
    }
}
