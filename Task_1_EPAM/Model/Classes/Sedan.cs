using System;
using System.Collections.Generic;
using System.Text;
using Task_1_EPAM.Model.Interfaces;

namespace Task_1_EPAM.Model.Classes
{
    class Sedan : Car, ICar
    {
        TypeCar TypeCar { get; } = TypeCar.Sedan;
        public void WriteCar()
        {
            Console.WriteLine($"Brand {Brand}, Fuel Consumption {FuelConsumption}, Max speed {MaxSpeed}, Price {Price}, Type car {TypeCar}");
        }
    }
}
