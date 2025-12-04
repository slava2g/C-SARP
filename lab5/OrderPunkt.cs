using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class OrderPunkt
    {
        public MenuPunkt Punkt { get; set; }
        public int quantity; 

        public decimal Total => Punkt.Price * quantity; 
        public override string ToString() 
        {
            return $"{Punkt.Name} x {quantity} = {Total} грн";
        }
    }
}
