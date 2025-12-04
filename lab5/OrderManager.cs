using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    internal class OrderManager
    {
        public List<Order> Orders { get; private set; } = new(); 

        private MenuPrinter menu; 

        public OrderManager(MenuPrinter menu)
        {
            this.menu = menu; 
        }

        public Order CreateOrder() 
        {
            var order = new Order();
            Orders.Add(order);
            return order;
        }

        public void PrintAllOrders() 
        {
            if (Orders.Count == 0) 
            {
                Console.WriteLine("Немає жодного замовлення.");
                return;
            }

            int num = 1; 
            foreach (var order in Orders) 
            {
                Console.WriteLine($"\n===== ЗАМОВЛЕННЯ №{num} ====="); 
                order.PrintOrder();
                num++; 
            }
        }
        public void StartOrderDialog() 
        {
            var order = CreateOrder();

            Console.WriteLine("Створення нового замовлення!");

            while (true) 
            {
                for (int i = 0; i < menu.MenuPunkts.Count; i++)
                {
                    var p = menu.MenuPunkts[i];
                    Console.WriteLine($"{i + 1}. {p.Name} - {p.Price} грн");
                }

                Console.Write("\nВведіть номер позиції (0 - завершити замовлення): ");
                if (!int.TryParse(Console.ReadLine(), out int choice) ||
                    choice < 0 || choice > menu.MenuPunkts.Count)
                {
                    Console.WriteLine("Невірний вибір!");
                    continue;
                }

                if (choice == 0)
                    break;

                Console.Write("Кількість: ");
                int qty = int.Parse(Console.ReadLine());

                order.AddItem(menu.MenuPunkts[choice - 1], qty);
                Console.WriteLine("Додано!");
            }

            Console.WriteLine("\nЗамовлення створено!");
        }
    }

}
