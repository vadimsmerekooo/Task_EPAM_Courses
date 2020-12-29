using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2__EPAM.Analyzer.Interfaces;

namespace Task_2__EPAM.Analyzer
{
    class Concordance : IConcordance
    {
        Dictionary<char, List<ConcordanceItem>> concordanceDictionary = new Dictionary<char, List<ConcordanceItem>>();

        public void Add(string word, int numberLine)
        {
            if (String.IsNullOrEmpty(word))
                throw new ArgumentNullException("Conrcondance item is null");

            if (concordanceDictionary.Keys.All(ch => ch != word.First()))
            {
                concordanceDictionary.Add(word.First(),
                                new List<ConcordanceItem>()
                                {
                                    new ConcordanceItem(word, numberLine)
                                });
            }
            else
            {
                if (concordanceDictionary[word.First()].Any(c => c.Word.Equals(word, StringComparison.OrdinalIgnoreCase)))
                {
                    concordanceDictionary[word.First()]
                        .FirstOrDefault(c => c.Word.Equals(word, StringComparison.OrdinalIgnoreCase))
                        .Add(numberLine);
                }
                else
                {
                    concordanceDictionary[word.First()]
                        .Add(new ConcordanceItem(word, numberLine));
                }
            }
        }

        public IEnumerable GetEnumerator()
        {
            foreach (var concordanceItem in concordanceDictionary.OrderBy(c => c.Key))
            {
                yield return concordanceItem;
            }
        }
    }
}
