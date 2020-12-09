using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Task_1_EPAM.Model.Interfaces;

namespace Task_1_EPAM.Model.Classes
{
    class Taksopark
    {
        ICollection<Car> cars = new List<Car>();

        public void AddCar(Car car) => cars.Add(car);

        public void DeleteCar(Car car) => cars.Remove(car);

        public ICollection<Car> GetCars() => cars;

        public Car GetCar(Car typeCar) => cars.FirstOrDefault(car => car == typeCar);

        public ICollection<Car> FindByMaxSpeedInRange(double a, double b)
        {
            return cars.Where(car => car.IsMaxSpeedInRange(a, b)).ToList();
        }




        public ICollection<Car> SortedByFuel() => cars.OrderBy(car => car.FuelConsumption).ToList();

        public double GetSumCars()
        {
            double sum = 0;
            foreach (Car carItem in cars)
            {
                sum += carItem.Price;
            }
            return sum;
        }

        public double GetTotalSumCars()
        {
            return cars.Sum(car => car.Price);
        }
    }
}
