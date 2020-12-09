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
            taksopark.AddCar(new Sedan("MB", 8.5, 280, 4800));
            taksopark.AddCar(new Coupe("MB", 8.5, 280, 4800));
            taksopark.AddCar(new Hatchback("MB", 8.5, 280, 4800));
            taksopark.AddCar(new Universal("MB", 8.5, 280, 4800));

            Console.WriteLine("List cars: \n");
            foreach (Car carItem in taksopark.GetCars())
            {
                carItem.ToString();
            }

            Console.WriteLine($"Sum cars taksopark: {taksopark.GetSumCars()}$\n");
            Console.WriteLine("Sorted list cars by fuel: \n");
            foreach (Car carItem in taksopark.SortedByFuel())
            {
                carItem.ToString();
            }

            Console.WriteLine("Enter minRangeValue and maxRangeValue, for find car by max-speed:\n");
            double a = double.Parse(Console.ReadLine());

            foreach (Car carItem in taksopark.FindByMaxSpeedInRange(a, double.Parse(Console.ReadLine())))
            {
                carItem.ToString();
            }

            Console.ReadKey();
        }
    }
}
