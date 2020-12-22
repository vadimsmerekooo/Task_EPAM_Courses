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
        public char Name { get; private set; }
        List<CorcondanceItem> corcondance = new List<CorcondanceItem>();

        public Corcondance(char name, CorcondanceItem corcondanceItem)
        {
            Name = name;
            Add(corcondanceItem);
        }

        public void Add(CorcondanceItem corcondanceItem)
        {
            if (corcondance.FirstOrDefault(c => c.Word == corcondanceItem.Word) == null)
                corcondance.Add(corcondanceItem);
            else
                corcondance.FirstOrDefault(c => c.Word == corcondanceItem.Word).Add(corcondanceItem.GetNumberLines().First());
        }
        public T GetCorcondanceItemByWord<T>(string word) where T : CorcondanceItem
        {
            if (corcondance.FirstOrDefault(w => w.Word == word) != null)
                return (T)corcondance.FirstOrDefault(w => w.Word == word);
            return default(T);
        }
        public IEnumerator GetEnumerator() => corcondance.GetEnumerator();

        public override string ToString()
        {
            string returnTex = Name + "\n";
            foreach (CorcondanceItem corcondanceItem in this)
                returnTex += $"{corcondanceItem.Word} ----------> {corcondanceItem.Counter}  :  {corcondanceItem.NumberLinesToString()}\n";
            return returnTex;
        }
    }
}
