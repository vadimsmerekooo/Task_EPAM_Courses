using System;
using System.Text.RegularExpressions;
using Task_2__EPAM.Analyzer.Interfaces;

namespace Task_2__EPAM.Analyzer
{
    class Analyzer : IAnalyzer
    {
        string regex = "[^a-zA-Zа-яА-Я]+";
        
        public IConcordance Analyze(string[] readLines)
        {
            if (readLines is null)
                throw new ArgumentNullException("Read lines is null");


            IConcordance concordances = new Concordance();
            string[] words;
            try
            {
                for (int i = 0; i < readLines.Length; i++)
                {
                    words = Regex.Replace(readLines[i], regex, " ").Trim().ToLower().Split(" ");
                    foreach (string wordItem in words)
                    {
                        if (!String.IsNullOrWhiteSpace(wordItem))
                            concordances.Add(wordItem, i + 1);
                    }
                }
                return concordances;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
