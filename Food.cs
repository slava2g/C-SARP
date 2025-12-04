using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Food : MenuPunkt 
    {
        public bool IsHalyal { get; set; }
        public string HalyalLabel => IsHalyal ? "Халяльна" : "Не халяльна";
        public Food(string name, string type, int portion, decimal price, bool halyal) : base(name, type, portion, price) 
        {
            IsHalyal = halyal;
        }

    }
}
