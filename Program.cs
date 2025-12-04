using Restaurant;

namespace Лр5;
class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8; 
        Console.InputEncoding = System.Text.Encoding.UTF8;

        MainOrganaizer org = new MainOrganaizer(); 
        org.Initialize(); 

        while (true) 
        {
            org.StartRestaurant();

            Console.Write("\nВаш вибір: ");
            string input = Console.ReadLine();
            Console.Clear();

            switch (input)
            {
                case "1":
                    org.CreateMenu(); 
                    break;

                case "2":
                    org.OrdersMenu(); 
                    break;

                case "3":
                    org.CreateOrder(); 
                    break;

                case "4": 
                    return;

                default:
                    Console.WriteLine("Невірна команда!"); 
                    break;

            }
        }
    }
}


