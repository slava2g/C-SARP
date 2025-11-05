using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouseSystem
{
    public class SmartHomeController
    {
        private List<ISwitchable> switchableDevices = new();
        private List<IEnergyConsumer> energyDevices = new();

        public void AddDevice(ISwitchable device)
        {
            switchableDevices.Add(device);
        }

        public void AddEnergyDevice(IEnergyConsumer device)
        {
            energyDevices.Add(device);
        }

        public void TurnAllOn()
        {
            foreach (var device in switchableDevices)
                device.TurnOn();
        }

        public void TurnAllOff()
        {
            foreach (var device in switchableDevices)
                device.TurnOff();
        }

        public void ShowEnergyReport(int hours)
        {
            Console.WriteLine($"\nЗвіт про споживання енергії за {hours} год:");
            double totalEnergy = 0;

            foreach (var device in energyDevices)
            {
                double usage = device.GetEnergyUsage(hours);
                totalEnergy += usage;
                Console.WriteLine($"{device.DeviceName}: {usage:F2} кВт·год (потужність: {device.PowerConsumption} Вт)");
            }

            Console.WriteLine($"Загальне споживання: {totalEnergy:F2} кВт·год");
            Console.WriteLine($"Вартість (~4 грн/кВт·год): {totalEnergy * 4:F2} грн\n");
        }
    }
}
