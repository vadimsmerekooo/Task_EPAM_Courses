﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2__EPAM.Analyzer.Interfaces
{
    interface ICorcondanceItem
    {
        void Add(int numberLine);
        List<int> GetNumberLines();
    }
}
