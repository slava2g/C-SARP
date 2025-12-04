using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    internal class MainOrganaizer
    {
        private MenuPrinter builtMenu; 
        private OrderManager orderManager; 

        public void Initialize() 
        {
            builtMenu = Menu.MenuBuild(); 
            orderManager = new OrderManager(builtMenu);
        }

        public void StartRestaurant() 
        {
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("--- Ласкаво просимо до ресторану 'Шалена бджілка' ---");
            Console.WriteLine("Введіть одну з цифер:");
            Console.WriteLine("1 - Вивести меню");
            Console.WriteLine("2 - Переглянути замовлення");
            Console.WriteLine("3 - Створити замовлення");
            Console.WriteLine("4 - Вийти");
        }

        public void CreateMenu()
        {
            builtMenu.PrintMenu(); 
        }

        public void OrdersMenu()
        {
            orderManager.PrintAllOrders(); 
        }

        public void CreateOrder()
        {
            orderManager.StartOrderDialog(); 
        }
    }

}
