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
    class Analyzer : IAnalyzer, IEnumerable
    {
        List<Corcondance> corcondances = new List<Corcondance>();
        public void ReadFile(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException("File not found");
            Analyze(File.ReadAllLines(path));
        }
        void WriteFile()
        {
            File.WriteAllText("createcorcondance.txt", "");
            using (StreamWriter fs = new StreamWriter("createcorcondance.txt", true, Encoding.Default))
            {
                foreach (Corcondance corcondance in this)
                    fs.Write(corcondance.ToString());
            }
        }
        void Analyze(string[] readLines)
        {
            string regex = "[^0-9a-zA-Zа-яА-Я]+";
            string[] words;
            try
            {
                for (int i = 0; i < readLines.Length; i++)
                {
                    words = Regex.Replace(readLines[i], regex, " ").Trim().ToLower().Split(" ");
                    foreach (string wordItem in words)
                        if (!String.IsNullOrWhiteSpace(wordItem))
                            Add(new CorcondanceItem(wordItem, i + 1));
                }
                corcondances = corcondances.OrderBy(param => param.Name).ToList();
                WriteFile();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        void Add(CorcondanceItem corcondanceItem)
        {
            if (corcondances.FirstOrDefault(c => c.Name == corcondanceItem.Word.ToUpper().First()) == null)
                corcondances.Add(
                    new Corcondance(corcondanceItem.Word.ToUpper().First(), corcondanceItem));
            else
                corcondances.FirstOrDefault(c => c.Name == corcondanceItem.Word.ToUpper().First()).Add(corcondanceItem);
        }
        public IEnumerator GetEnumerator() => corcondances.GetEnumerator();


    }
}
