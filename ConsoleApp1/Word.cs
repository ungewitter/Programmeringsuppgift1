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
        List<string> synonyms = new List<string>(); //Ett ord kan ha flera synonymer som har typen String. Funderade på att göra utveckla synonymer till att vara objektet Word, eftersom synonymer också är ord så bör finnas i en ordbok. Valde att göra det enklare.

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
        public List<string> Synonyms { get => synonyms; set => synonyms = value; }

        //Metoden AddSynonyms ligger i Word-klassen. Detta leder till att metoden i interfacet aldrig används. Kan förbättras.
        public void AddSynonyms(IEnumerable<string> synonyms)
        {
            foreach (string s in synonyms)
            {
                Synonyms.Add(s);
            }
        }
    }
}
