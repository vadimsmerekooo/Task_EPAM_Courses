using System;
using System.Collections.Generic;
using System.Text;
using Task_1_EPAM.Model.Interfaces;

namespace Task_1_EPAM.Model.Classes
{
    class Hatchback:ICar
    {
        public string Brand { get; set; }
        public double FuelConsumption { get; set; }
        public double MaxSpeed { get; set; }
        public double Price { get; set; }
        public TypeCar TypeCar { get; } = TypeCar.Hatchback;
    }
}
