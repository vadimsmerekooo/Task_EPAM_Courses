using System;
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
                analyzer.ReadFile("text.txt");
                foreach (Corcondance corcondance in analyzer)
                    Console.WriteLine(corcondance.ToString());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
