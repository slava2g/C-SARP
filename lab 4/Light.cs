using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouseSystem
{
    public class Light : Device, IEnergyConsumer
    {
        public string DeviceName => Name;
       
        public int PowerConsumption => 60;


        public double GetEnergyUsage(int hours)
        {
            if (IsOn == false)
            {
                return 0;
            }
            return  PowerConsumption * hours / 1000.0;
        }

        public override void TurnOff()
        {
            IsOn = false;
            Console.WriteLine($"{Name} вимкнена.");
        }

        public override void TurnOn()
        {
            IsOn = true;
            Console.WriteLine($"{Name} засвітилася.");
        }
        public void PrintStatus()
        {
            if (IsOn)
                Console.WriteLine($"{Name}: увімкнено");
            else
                Console.WriteLine($"{Name}: вимкнено");
        }
    }
}
