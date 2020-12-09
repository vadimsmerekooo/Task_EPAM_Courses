using System;
using System.Collections.Generic;
using System.Text;
using Task_1_EPAM.Model.Interfaces;

namespace Task_1_EPAM.Model.Classes
{
    class Car : ICar
    {
        public string Brand { get; private set; }
        public double FuelConsumption { get; private set; }
        public double MaxSpeed { get; private set; }
        public double Price { get; private set; }
        public Car(string brand, double fuel, double maxSpeed, double price)
        {
            Brand = brand;
            FuelConsumption = fuel;
            MaxSpeed = maxSpeed;
            Price = price;
        }

        public bool IsMaxSpeedInRange(double a, double b) => MaxSpeed >= a && MaxSpeed <= b;
        public override string ToString() => $"Brand {Brand}, Fuel Consumption {FuelConsumption}, Max speed {MaxSpeed}, Price {Price}";
    }
}
