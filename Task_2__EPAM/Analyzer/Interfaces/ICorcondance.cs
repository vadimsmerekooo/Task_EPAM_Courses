using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2__EPAM.Analyzer.Interfaces
{
    interface ICorcondance
    {
        void Add(CorcondanceItem corcondanceItem);
        T GetCorcondanceItemByWord<T>(string word) where T : CorcondanceItem;
    }
}
