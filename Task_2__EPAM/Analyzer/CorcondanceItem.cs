using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Task_2__EPAM.Analyzer.Interfaces;

namespace Task_2__EPAM.Analyzer
{
    class CorcondanceItem : ICorcondanceItem
    {
        public string Word { get; set; }
        public int Counter { get; private set; }
        List<int> numberLines = new List<int>();

        public CorcondanceItem(string word, int numberLine)
        {
            if (String.IsNullOrEmpty(word))
                throw new Exception("Word is null or empty");
            Word = word;
            Add(numberLine);
        }

        public void Add(int numberLine)
        {
            if (!numberLines.Contains(numberLine))
                numberLines.Add(numberLine);
            IncrementCounter();
        }
        public List<int> GetNumberLines() => numberLines.ToList();

        private void IncrementCounter() => Counter++;
    }
}
