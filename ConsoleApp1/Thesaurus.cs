using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Thesaurus : IThesaurus
    {
        List<Word> thesaurusWords = new List<Word>(); //Ordboken kan innehålla flera ord.

        //Default kontruktor
        public Thesaurus()
        {
        }

        //Konstruktor med ordlistan i parametern
        public Thesaurus(List<Word> words)
        {
            Words = words;
        }

        public List<Word> Words { get => thesaurusWords; set => thesaurusWords = value; }


        //AddSynonyms används inte i denna klassen, utan i Word-klassen.
        public void AddSynonyms(IEnumerable<string> synonyms)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetSynonyms(string word)
        {
            foreach (Word w in thesaurusWords)
            {
                if (w.WordName == word)
                {
                    return w.Synonyms; //returnerar listan med synonmer
                }
            }
            return null;
        }
        public IEnumerable<String> GetWords()
        {
            List<String> listOfWordNames = new List<string>(); //Skapar en temporär lista där alla 'wordName' kan läggas i.
            if (thesaurusWords != null)
            {
                foreach (Word w in thesaurusWords)
                {
                    listOfWordNames.Add(w.WordName);
                }
                return listOfWordNames; //Returnerar listan med namnet på ord.
            }
            return null;


        }
    }
}
