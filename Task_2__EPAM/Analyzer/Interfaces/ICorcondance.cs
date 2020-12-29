using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Task_2__EPAM.Analyzer.Interfaces
{
    interface IConcordance
    {
        void Add(string word, int numberLine);
        IEnumerable GetEnumerator();
    }
}
