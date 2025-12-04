using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public abstract class MenuPunkt 
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Portion { get; set; }
        public decimal Price { get; set; }

        public MenuPunkt(string name, string type, int portion, decimal price) 
        {
            Name = name;
            Type = type;
            Portion = portion;
            Price = price;
        }
    }
}
