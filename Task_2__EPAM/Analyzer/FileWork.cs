using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Task_2__EPAM.Analyzer
{
    class FileWork
    {
        public string[] ReadFile(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException("File not found");
            return File.ReadAllLines(path);
        }

        public void WriteFile(string path, Corcondance corcondance)
        {
            File.WriteAllText(path, "");
            using (StreamWriter fs = new StreamWriter("createcorcondance.txt", true, Encoding.Default))
            {
                foreach (var corcondanceItem in corcondance.GetCorcondance())
                {
                    fs.WriteLine("{0,18}", corcondanceItem.Key);
                    foreach (var valueItem in corcondanceItem.Value)
                    {
                        fs.WriteLine(" {0,15} " + valueItem.Counter + ": " + String.Join(" ", valueItem.GetNumberLines()), valueItem.Word);
                    }
                    fs.WriteLine();
                }
            }
        }
    }
}
