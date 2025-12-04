using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Drink : MenuPunkt 
    {
       
        public int? Alcohol { get; set; }
        public bool IsCarbonated { get; set; }
        public string CarbonatedLabel => IsCarbonated ? "З газом" : "Без газу";
        public Drink(string name, string type, int portion, decimal price, int? alcohol, bool isCarbonated) : base( name, type, portion, price) 
        {
            Alcohol = alcohol;
            IsCarbonated = isCarbonated;
        }
    }
}
