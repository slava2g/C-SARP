using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class MenuPrinter
    {
        private List<MenuPunkt> menuPunkts = new List<MenuPunkt>(); 

        public List<MenuPunkt> MenuPunkts => menuPunkts;

        public void PrintMenu() 
        {
            foreach (var punkt in menuPunkts)
            {
                if (punkt is Food food)
                {
                    Console.WriteLine($"Їжа: {food.Name}, Тип: {food.Type}, Порція: {food.Portion}г, Ціна: {food.Price} грн, {food.HalyalLabel}");
                }
                else if (punkt is Drink drink)
                {
                    string alcoholInfo = drink.Alcohol.HasValue ? $", Алкоголь: {drink.Alcohol}%" : "";
                    Console.WriteLine($"Напій: {drink.Name}, Тип: {drink.Type}, Порція: {drink.Portion}мл, Ціна: {drink.Price} грн{alcoholInfo}, {drink.CarbonatedLabel}");
                }
            }
        }
    }
}
