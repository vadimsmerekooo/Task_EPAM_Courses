using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Task_1_EPAM.Model.Enum;
using Task_1_EPAM.Model.Interfaces;
using Task_1_EPAM.Model.Intrefaces;

namespace Task_1_EPAM.Model.Classes
{
    class Taksopark : IPark, IEnumerable
    {
        ICollection<Car> cars = new List<Car>();
        public double TotalPriceOfCars { get => cars.Sum(car => car.Price); }

        public void Add(Car car) => cars.Add(car);

        public void DeleteCar(Car car) => cars.Remove(car);

        public ICollection<Car> GetCars() => cars.ToList();

        public Car GetCarByBrand(string carBrand) => cars.FirstOrDefault(car => car.Brand.Contains(carBrand, StringComparison.OrdinalIgnoreCase));

        public ICollection<Car> FindByMaxSpeedInRange(double minRangeValue, double maxRangeValue) => cars.Where(car => car.IsMaxSpeedInRange(minRangeValue, maxRangeValue)).ToList();

        public ICollection<Car> SortCars(Func<Car, object> func) => cars.OrderBy(func).ToList();

        public IEnumerator GetEnumerator() => cars.GetEnumerator();

        public ICollection<Car> SortCars(Func<Car, bool> func)
        {
            throw new NotImplementedException();
        }
    }
}
