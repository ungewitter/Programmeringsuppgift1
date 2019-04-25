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
        List<String> listOfWords = new List<String>(); //Ordboken innehåller även en lista av orden i String-format där dupletter ej får förekomma.
        


        //Default kontruktor
        public Thesaurus()
        {
        }

        public List<Word> ThesaurusWords { get => thesaurusWords; set => thesaurusWords = value; }
        public List<string> ListOfWords { get => listOfWords; set => listOfWords = value; }


        public void AddSynonyms(IEnumerable<string> synonyms)
        {
            foreach (String s in synonyms)
            {
                Word word = new Word(s); //Skapar ett nytt ord-objekt.
                word.AddSynonyms(synonyms); //Ger ordet alla ens synonymer.
                ThesaurusWords.Add(word); //Lägger till ordet i listan med ord-objekt.

                if (!ListOfWords.Contains(s))
                {
                    ListOfWords.Add(s); //Lägger även till ordet i String-listan. Ser till att ordet inte redan finns i denna listan.
                }
            }
        }

        public IEnumerable<string> GetSynonyms(string word)
        {
            int count = 0; //Räknare som checkar ifall ett ord förekommer fler än en gång.
            foreach (Word w in ThesaurusWords)
            {
                
                if (w.WordName == word && count == 0) //Ifall ordet bara förekommer 1 gång.
                {
                    Console.WriteLine("\nOrdet " + word + " har synonymerna ");
                    foreach (String s in w.Synonyms)
                    {
                        if (s != w.Synonyms.Last()) //Skriver ut alla synonymer förutom den sista.
                        {
                            Console.Write("'" + s + "'" + ", ");
                        }
                        else //Här skrivs den sista synonymen ut.
                        {
                            Console.Write("och '" + s + "'. \n");
                            count++; //Lägger till 1 i räknaren.
                        }

                        
                    }
                }
                else if (w.WordName == word && count > 0)
                {
                    Console.WriteLine("Men även synonymerna ");
                    foreach (String s in w.Synonyms)
                    {
                        if (s != w.Synonyms.Last())
                        {
                            Console.Write("'" + s + "'" + ", "); //Skriver ut alla synonymer förutom den sista.
                        }
                        else
                        {
                            Console.Write("och '" + s + "'. \n"); //Här skrivs den sista synonymen ut.
                            count++; //Lägger till 1 i räknaren.
                        }


                    }
                }
            }
            return null;
        }
        public IEnumerable<String> GetWords()
        {
            Console.WriteLine("");
            if (ThesaurusWords != null)
            {
                ListOfWords.Sort(); //Sorterar listan i bosktavsordning.
                foreach (String s in listOfWords)
                {
                    Console.WriteLine(s);
                }
            }
            return null;


        }
    }
}
