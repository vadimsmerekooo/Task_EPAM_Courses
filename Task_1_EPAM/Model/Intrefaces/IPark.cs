using System;
using System.Collections.Generic;
using System.Text;
using Task_1_EPAM.Model.Classes;

namespace Task_1_EPAM.Model.Intrefaces
{
    interface IPark
    {
        double TotalPriceOfCars { get; }
        void Add(Car car);

        void DeleteCar(Car car);

        ICollection<Car> GetCars();

        Car GetCarByBrand(string carBrand);

        ICollection<Car> FindByMaxSpeedInRange(double minRangeValue, double maxRangeValue);

        ICollection<Car> SortCars(Func<Car, bool> func);
    }
}
