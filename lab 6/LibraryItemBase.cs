using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР6
{  
     public abstract class LibraryItemBase : ILibraryItem
     {
            protected static int _nextId = 1;

            public int Id { get; }
            public string Title { get; set; }
            public int Year { get; set; }

            protected LibraryItemBase(string title, int year)
            {
                Id = _nextId++;
                Title = title;
                Year = year;
            }

            public abstract string GetItemType();

            public virtual string GetDisplayInfo()
            {
                return $"{GetItemType()} ID: {Id}, Title: \"{Title}\", Year: {Year}";
            }
     }

    
}
