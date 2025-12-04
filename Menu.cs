using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Menu
    {
        public static MenuPrinter MenuBuild() 
        {
            MenuPrinter menu = new MenuPrinter();

            menu.MenuPunkts.Add(new Drink("Кола", "Безалкогольний напій", 500, 40, null, true));
            menu.MenuPunkts.Add(new Drink("Вода", "Безалкогольний напій", 330, 20, null, false));
            menu.MenuPunkts.Add(new Drink("Сидр", "Алкогольний напій", 500, 60, 5, true));
            menu.MenuPunkts.Add(new Drink("Чай", "Безалкогольний напій", 1000, 50, null, false));
            menu.MenuPunkts.Add(new Food("Пельмені", "Гаряча страва", 300, 60, true));
            menu.MenuPunkts.Add(new Food("Стейк свинний", "Гаряча страва", 400, 150, false));
            menu.MenuPunkts.Add(new Food("Картопля смажена", "Гаряча страва", 300, 50, true));
            menu.MenuPunkts.Add(new Food("Сало", "Закуска", 100, 50, false));
            return menu;
        }
    }
}
