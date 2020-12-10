using System;
using Task_1_EPAM.Model.Classes;
using Task_1_EPAM.Model.Interfaces;
using Task_1_EPAM.Model.Intrefaces;

namespace Task_1_EPAM
{
    class Program
    {
        static void Main(string[] args)
        {
            Taksopark taksopark = new Taksopark();
            taksopark.AddCar(new Sedan("MB", 8.5, 280, 4800));
            taksopark.AddCar(new Coupe("MB", 8.5, 280, 4800));
            taksopark.AddCar(new Hatchback("MB", 8.5, 280, 4800));
            taksopark.AddCar(new Universal("MB", 8.5, 280, 4800));

            Console.WriteLine("List cars: \n");
            foreach (Car carItem in taksopark.GetCars())
            {
                Console.WriteLine(carItem.ToString()); 
            }

            Console.WriteLine($"Sum cars taksopark: {taksopark.GetTotalSumCars()}$\n");
            Console.WriteLine("Sorted list cars by fuel: \n");
            foreach (Car carItem in taksopark.SortedCarByFuel())
            {
                Console.WriteLine(carItem.ToString());
            }

            Console.WriteLine("Enter minRangeValue and maxRangeValue, for find car by max-speed:\n");
            double a = double.Parse(Console.ReadLine());

            foreach (Car carItem in taksopark.FindByMaxSpeedInRange(a, double.Parse(Console.ReadLine())))
            {
                Console.WriteLine(carItem.ToString());
            }

            Console.ReadKey();
        }
    }
}
