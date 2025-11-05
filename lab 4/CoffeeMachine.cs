using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouseSystem
{
    public class CoffeeMachine : Device, IEnergyConsumer
    {

        public string DeviceName => Name;

        public int PowerConsumption => 1000;
       

        public double GetEnergyUsage(int hours)
        {
            if (IsOn == false)
            {
                return 0;
            }
            return PowerConsumption * hours / 1000;
        }

        public override void TurnOff()
        {
            IsOn = false;
            Console.WriteLine($"{Name} завершила роботу.");
        }

        public override void TurnOn()
        {
            IsOn = true;
            Console.WriteLine($"{Name} почала готувати каву.");
        }
    }   
}
