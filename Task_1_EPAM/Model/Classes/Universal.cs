﻿using System;
using System.Collections.Generic;
using System.Text;
using Task_1_EPAM.Model.Interfaces;

namespace Task_1_EPAM.Model.Classes
{
    class Universal : Car
    {
        public Universal(string brand, double fuel, double maxSpeed, double price) :base(brand, fuel, maxSpeed, price)
        {

        }
        public override string ToString()
        {
            return "Type car Universal";
        }
    }
}
