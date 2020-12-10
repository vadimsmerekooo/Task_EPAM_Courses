using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Task_1_EPAM.Model.Interfaces;
using Task_1_EPAM.Model.Intrefaces;

namespace Task_1_EPAM.Model.Classes
{
    class Taksopark : IPark
    {
        ICollection<Car> cars = new List<Car>();

        public void AddCar(Car car) => cars.Add(car);

        public void DeleteCar(Car car) => cars.Remove(car);

        public ICollection<Car> GetCars() => cars.ToList();

        public Car GetCarByBrand(string carBrand) => cars.FirstOrDefault(car => car.Brand.Contains(carBrand, StringComparison.OrdinalIgnoreCase));

        public ICollection<Car> FindByMaxSpeedInRange(double a, double b) => cars.Where(car => car.IsMaxSpeedInRange(a, b)).ToList();

        public ICollection<Car> SortedCarByFuel() => cars.OrderBy(car => car.FuelConsumption).ToList();

        public double GetTotalSumCars() => cars.Sum(car => car.Price);
    }
}
