using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР6
{
    public interface ILibraryItem
    {
        int Id { get; }
        string Title { get; set; }
        int Year { get; set; }

        string GetDisplayInfo();
    }
}
