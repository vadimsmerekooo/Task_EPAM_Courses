using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Task_2__EPAM.Analyzer.Interfaces;

namespace Task_2__EPAM.Analyzer
{
    class Analyzer : IAnalyzer
    {
        string regex = "[^0-9a-zA-Zа-яА-Я]+";
        
        public Corcondance Analyze(string[] readLines)
        {
            Corcondance corcondances = new Corcondance();
            if (readLines is null)
                throw new ArgumentNullException("Read lines is null");
            string[] words;
            try
            {
                for (int i = 0; i < readLines.Length; i++)
                {
                    words = Regex.Replace(readLines[i], regex, " ").Trim().ToLower().Split(" ");
                    foreach (string wordItem in words)
                    {
                        if (!String.IsNullOrWhiteSpace(wordItem))
                            corcondances.Add(wordItem, i + 1);
                    }
                }
                return corcondances;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
