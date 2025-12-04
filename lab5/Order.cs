using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Order
    {
        public List<OrderPunkt> Punkts { get; private set; } = new();   

        public DateTime CreatedAt { get; private set; } = DateTime.Now; 
        public string Status 
        {
            get
            {
                var diff = DateTime.Now - CreatedAt; 

                if (diff.TotalMinutes < 2) 
                    return "Готується";

                if (diff.TotalMinutes < 10) 
                    return "Очікує оплату";

                return "Виконано"; 
            }
        }

        public decimal Total => Punkts.Sum(i => i.Total); 

        public void AddItem(MenuPunkt punkt, int quantity = 1)
        {
            if (quantity <= 0)
                throw new ArgumentException("Quantity must be greater than 0");

            
            var existing = Punkts.FirstOrDefault(i => i.Punkt.Name == punkt.Name);
            if (existing != null)
            {
                existing.quantity += quantity;
                return;
            }

            Punkts.Add(new OrderPunkt
            {
                Punkt = punkt,
                quantity = quantity
            });
        }

        public void PrintOrder() 
        {
            Console.WriteLine($"Замовлення від {CreatedAt}");
            Console.WriteLine("--------------------------------");

            foreach (var orderPunkt in Punkts)
            {
                Console.WriteLine(orderPunkt);
            }

            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Всього до сплати: {Total} грн");
            Console.WriteLine($"Статус: {Status}");
        }
    }
}
