using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2__EPAM.Analyzer.Interfaces;

namespace Task_2__EPAM.Analyzer
{
    class Corcondance : ICorcondance, IEnumerable
    {
        Dictionary<char, List<CorcondanceItem>> corcondance = new Dictionary<char, List<CorcondanceItem>>();

        public void Add(string word, int numberLine)
        {
            if (String.IsNullOrEmpty(word))
                throw new ArgumentNullException("Conrcondance item is null");
            if (!corcondance.Keys.Any(ch => ch == word.First()))
            {
                corcondance.Add(word.First(),
                                new List<CorcondanceItem>()
                                {
                                    new CorcondanceItem(word, numberLine)
                                });
            }
            else
            {
                if (corcondance[word.First()].Any(c => c.Word.Equals(word, StringComparison.OrdinalIgnoreCase)))
                {
                    corcondance[word.First()]
                        .FirstOrDefault(c => c.Word.Equals(word, StringComparison.OrdinalIgnoreCase))
                        .Add(numberLine);
                }
                else
                {
                    corcondance[word.First()]
                        .Add(new CorcondanceItem(word, numberLine));
                }
            }
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var corcondanceItem in corcondance.OrderBy(c => c.Key))
            {
                yield return corcondanceItem;
            }
        }
    }
}
