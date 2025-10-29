using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem
{
    public class Car : Vehicle
    {
        protected int doors;         // protected — чтобы Van мог обращаться
        protected double fuelLevel;  // protected — чтобы Van мог обращаться

        // Обычный публичный конструктор для Car (по умолчанию maxSpeed = 180)
        public Car(string brand, int year, double mileage, int doors)
            : base(brand, year, mileage, 180.0)
        {
            this.doors = doors;
            this.fuelLevel = 50;
        }

        // Защищённый перегруженный конструктор, который позволяет задать maxSpeed (используется Van)
        protected Car(string brand, int year, double mileage, int doors, double maxSpeed)
            : base(brand, year, mileage, maxSpeed)
        {
            this.doors = doors;
            this.fuelLevel = 50;
        }

        public override string GetInfo()
        {
            return $"Car: {brand} ({year}), Doors: {doors}, Fuel: {fuelLevel}L";
        }

        public override void Move(double distance)
        {
            base.Move(distance);
            fuelLevel -= distance * 0.1;
            if (fuelLevel < 0) fuelLevel = 0;
        }

        public void Refuel(double liters)
        {
            fuelLevel += liters;
            if (fuelLevel > 50) fuelLevel = 50;
        }
    }
}
