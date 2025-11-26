using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР6
{
    public class LibraryManager
    {
        public LibraryCatalog<Book> _bookCatalog { get; }
        public LibraryCatalog<Magazine> _magazineCatalog { get; }

        public LibraryManager()
        {
            _bookCatalog = new LibraryCatalog<Book>();
            _magazineCatalog = new LibraryCatalog<Magazine>();
        }

        public void AddItem(ILibraryItem item)
        {
            if (item is Book b)
                _bookCatalog.AddItem(b);
            else if (item is Magazine m)
                _magazineCatalog.AddItem(m);
        }

        public List<ILibraryItem> GetAllItems()
        {
            var result = new List<ILibraryItem>();

            result.AddRange(_bookCatalog.GetAllItems());
            result.AddRange(_magazineCatalog.GetAllItems());

            return result;
        }

        public ILibraryItem? GetItemById(int id)
        {
            var book = _bookCatalog.GetItemById(id);
            if (book != null) return book;

            var mag = _magazineCatalog.GetItemById(id);
            if (mag != null) return mag;

            return null;
        }
    }
}
