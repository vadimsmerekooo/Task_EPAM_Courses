using System;
using System.Collections.Generic;
using System.Configuration;
using Task_2__EPAM.Analyzer;
using Task_2__EPAM.Analyzer.Interfaces;

namespace Task_2__EPAM
{
    class Program
    {
        static void Main()
        {
            try
            {
                Analyzer.Analyzer analyzer = new Analyzer.Analyzer();
                IConcordance concordance;
                FileWork fileWork = new FileWork();


                concordance = analyzer.Analyze(fileWork.ReadFile(ConfigurationManager.ConnectionStrings["InputFile"].ConnectionString));

                foreach (KeyValuePair<char, List<ConcordanceItem>> concordanceItem in concordance.GetEnumerator())
                {
                    Console.WriteLine("{0,18}", char.ToUpper(concordanceItem.Key));
                    foreach (var valueItem in concordanceItem.Value)
                    {
                        Console.WriteLine(" {0,15} " + valueItem.Counter + ": " + String.Join(" ", valueItem.GetNumberLines()), valueItem.Word);
                    }
                    Console.WriteLine();
                }

                fileWork.WriteFile(ConfigurationManager.ConnectionStrings["OutputFile"].ConnectionString, concordance);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
