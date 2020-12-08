using System;
using System.Collections.Generic;
using System.Text;
using Task_1_EPAM.Model.Classes;

namespace Task_1_EPAM.Model.Interfaces
{
    interface ICar
    {
        string Brand { get; set; }
        double FuelConsumption { get; set; }
        double MaxSpeed { get; set; }
        double Price { get; set; }
        bool CarMaxSpeed(double a, double b) => MaxSpeed >= a && MaxSpeed <= b;
        void WriteCar();
    }
}
