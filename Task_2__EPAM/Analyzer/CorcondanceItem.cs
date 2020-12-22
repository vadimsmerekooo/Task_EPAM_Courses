using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Task_2__EPAM.Analyzer.Interfaces;

namespace Task_2__EPAM.Analyzer
{
    class CorcondanceItem : ICorcondanceItem
    {
        List<int> numberLines = new List<int>();
        public string Word { get; set; }
        public int Counter { get; private set; }
        public CorcondanceItem(string word, int numberLine)
        {
            Word = word;
            Add(numberLine);
        }
        public void Add(int numberLine)
        {
            if (!numberLines.Contains(numberLine))
                numberLines.Add(numberLine);
            IncrementCounter();
        }
        public List<int> GetNumberLines() => numberLines; 
        void IncrementCounter() => Counter++;
        public string NumberLinesToString()
        {
            string returnText = string.Empty;
            foreach (int numberItem in numberLines)
                returnText += numberItem + ",";
            return returnText;
        }
    }
}
