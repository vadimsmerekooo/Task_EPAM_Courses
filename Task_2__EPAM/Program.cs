using System;
using System.Collections.Generic;
using System.Linq;
using Task_2__EPAM.Analyzer;

namespace Task_2__EPAM
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Analyzer.Analyzer analyzer = new Analyzer.Analyzer();
                Corcondance corcondance = new Corcondance();
                FileWork fileWork = new FileWork();

                corcondance = analyzer.Analyze(fileWork.ReadFile("text.txt"));
                foreach (var corcondanceItem in corcondance.GetCorcondance())
                {
                    Console.WriteLine("{0,18}", corcondanceItem.Key);
                    foreach (var valueItem in corcondanceItem.Value)
                    {
                        Console.WriteLine(" {0,15} " + valueItem.Counter +": " + String.Join(" ", valueItem.GetNumberLines()), valueItem.Word);
                    }
                    Console.WriteLine();
                }
                fileWork.WriteFile("createcorcondance.txt", corcondance);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
