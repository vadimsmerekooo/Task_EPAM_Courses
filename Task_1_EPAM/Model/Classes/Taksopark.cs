using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Task_1_EPAM.Model.Interfaces;

namespace Task_1_EPAM.Model.Classes
{
    class Taksopark
    {
        ICollection<ICar> cars = new List<ICar>();

        public void AddCar(ICar car) => cars.Add(car);

        public void DeleteCar(ICar car) => cars.Remove(car);

        public ICollection<ICar> GetCars() => cars;

        public ICar GetCar(ICar typeCar) => cars.FirstOrDefault(car => car is ICar);

        public ICollection<ICar> FindByMaxSpeed(double a, double b)
        {
            ICollection<ICar> foundCars = new List<ICar>();
            foreach (ICar carItem in cars)
            {
                if (carItem.CarMaxSpeed(a, b))
                    foundCars.Add(carItem);
            }
            return foundCars;
        }
        public ICollection<ICar> SortedByFuel() => cars.OrderBy(car => car.FuelConsumption).ToList();

        public double GetSumCars()
        {
            double sum = 0;
            foreach (ICar carItem in cars)
            {
                sum += carItem.Price;
            }
            return sum;
        }
    }
}
