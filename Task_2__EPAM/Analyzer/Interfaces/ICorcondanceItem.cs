using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2__EPAM.Analyzer.Interfaces
{
    interface IConcordanceItem
    {
        string Word { get; }
        int Counter { get; }
        void Add(int numberLine);
        List<int> GetNumberLines();
    }
}
