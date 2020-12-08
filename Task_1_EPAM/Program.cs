using System;
using Task_1_EPAM.Model.Classes;
using Task_1_EPAM.Model.Interfaces;

namespace Task_1_EPAM
{
    class Program
    {
        static void Main(string[] args)
        {
            Taksopark taksopark = new Taksopark();
            taksopark.AddCar(new Coupe()
            {
                Brand = "BMW",
                FuelConsumption = 7.3,
                MaxSpeed = 240,
                Price = 2500
            });
            taksopark.AddCar(new Hatchback()
            {
                Brand = "Geely",
                FuelConsumption = 9,
                MaxSpeed = 190,
                Price = 5200
            });
            taksopark.AddCar(new Sedan()
            {
                Brand = "Opel",
                FuelConsumption = 4.7,
                MaxSpeed = 160,
                Price = 2100
            });
            taksopark.AddCar(new Universal()
            {
                Brand = "MB",
                FuelConsumption = 8.5,
                MaxSpeed = 280,
                Price = 4800
            });

            Console.WriteLine("List cars: \n");
            foreach (ICar carItem in taksopark.GetCars())
            {
                carItem.WriteCar();
            }

            Console.WriteLine($"Sum cars taksopark: {taksopark.GetSumCars()}$\n");
            Console.WriteLine("Sorted list cars by fuel: \n");
            foreach (ICar carItem in taksopark.SortedByFuel())
            {
                carItem.WriteCar();
            }

            Console.WriteLine("Enter a and b, for find car by speed:\n");

            foreach (ICar carItem in taksopark.FindByMaxSpeed(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine())))
            {
                carItem.WriteCar();
            }

            Console.ReadKey();
        }
    }
}
