using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Word
    {
        private string wordName;
        List<String> synonyms = new List<string>();

        //Default konstruktor
        public Word()
        {
        }

        //Konstruktor med namnet på ordet i parametern.
        public Word(string wordName)
        {
            WordName = wordName;

        }

        public string WordName { get => wordName; set => wordName = value; }
        public List<String> Synonyms { get => synonyms; set => synonyms = value; }

        public void AddSynonyms(IEnumerable<string> synonyms)
        {
            foreach (string s in synonyms)
            {
                if (s != wordName)
                {
                    Synonyms.Add(s); //Lägger till synonymer i synonym-listan. Ser till att själva ordet inte är en del av dess synonymer.
                }
            }
        }
    }
}
