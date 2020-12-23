using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2__EPAM.Analyzer.Interfaces;

namespace Task_2__EPAM.Analyzer
{
    class Corcondance : ICorcondance
    {
        Dictionary<char, List<CorcondanceItem>> corcondance = new Dictionary<char, List<CorcondanceItem>>();

        public void Add(string word, int numberLine)
        {
            if (String.IsNullOrEmpty(word))
                throw new ArgumentNullException("Corcandance item is null");
            try
            {
                if (!corcondance.Keys.Any(ch => ch == word.ToUpper().First()))
                {
                    corcondance.Add(word.ToUpper().First(),
                        new List<CorcondanceItem>()
                        {
                        new CorcondanceItem(word, numberLine)
                        });
                }
                else
                {
                    if (corcondance[word.ToUpper().First()].Any(c => c.Word.Equals(word, StringComparison.OrdinalIgnoreCase)))
                    {
                        corcondance[word.ToUpper().First()]
                            .FirstOrDefault(
                            c => c.Word.Equals(word, StringComparison.OrdinalIgnoreCase)).Add(numberLine);
                    }
                    else
                    {
                        corcondance[word.ToUpper().First()].
                            Add(new CorcondanceItem(word, numberLine));
                    }
                }
            }
            catch
            {

            }
        }

        public T GetCorcondanceItemByWord<T>(string word) where T : CorcondanceItem
        {
            if (!corcondance.Values.Any(c => c.Any(w => w.Word.Equals(word, StringComparison.OrdinalIgnoreCase)))) ////////////////////////Почитать про Ignore case////
                return (T)corcondance
                    .Values
                    .Select(
                    c => c.Where(
                        w => w.Word.Equals(word, StringComparison.OrdinalIgnoreCase)));
            return default(T);
        }

        public Dictionary<char, List<CorcondanceItem>> GetCorcondance() => corcondance;

        public void Sort()
        {
            Dictionary<char, List<CorcondanceItem>> corcondanceSorted = new Dictionary<char, List<CorcondanceItem>>();
            foreach (char keyItem in corcondance.Keys.OrderBy(ch => ch))
            {
                corcondanceSorted.Add(keyItem, corcondance[keyItem].OrderBy(ci => ci.Word).ToList());
            }
            corcondance = corcondanceSorted;
        }
    }
}
