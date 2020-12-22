using System;
using Task_1_EPAM.Model.Classes;
using Task_1_EPAM.Model.Enum;
using Task_1_EPAM.Model.Interfaces;
using Task_1_EPAM.Model.Intrefaces;

namespace Task_1_EPAM
{
    class Program
    {
        static void Main(string[] args)
        {
            Taksopark taksopark = new Taksopark();
            taksopark.Add(new Sedan("MB", 8.5, 350, 6400));
            taksopark.Add(new Coupe("Opel", 8.3, 280, 4800));
            taksopark.Add(new Hatchback("BMW", 9.7, 320, 2500));
            taksopark.Add(new Universal("Audi", 5.9, 260, 3500));

            Console.WriteLine("List cars: \n");
            
            foreach (Car carItem in taksopark)
            {
                Console.WriteLine(carItem.ToString()); 
            }

            Console.WriteLine($"Sum cars taksopark: {taksopark.TotalPriceOfCars}$\n");
            Console.WriteLine("Sorted list cars by fuel: \n");
            CarProperty carPropertyBrand = CarProperty.Brand;

            foreach (Car carItem in taksopark.SortCars(item => item.Brand))
            {
                Console.WriteLine(carItem.ToString());
            }

            Console.WriteLine("Enter minRangeValue and maxRangeValue, for find car by max-speed:\n");
            Console.Write("minRangeValue: ");
            double minRangeValue = double.Parse(Console.ReadLine());
            Console.Write("maxRangeValue: ");
            double maxRangeValue = double.Parse(Console.ReadLine());

            foreach (Car carItem in taksopark.FindByMaxSpeedInRange(minRangeValue, maxRangeValue))
            {
                Console.WriteLine(carItem.ToString());
            }

            Console.ReadKey();
        }
    }
}
