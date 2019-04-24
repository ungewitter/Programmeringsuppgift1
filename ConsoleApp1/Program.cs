using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {

            Word w1 = new Word("Hej"); //Skapar ett "Word"-objekt.
            List<string> synonyms = new List<string>(new string[] { "Tjena", "Tjabba", "Yo" }); //Skapar lista med synonymer
            w1.AddSynonyms(synonyms); //Ord får lista med synonymer.

            Word w2 = new Word("Kärlek"); //Skapar nytt "Word"-objekt.
            synonyms = new List<string>(new string[] { "Förälskelse", "Amour", "Romans", "Svärmeri" }); //Ersätter listan med synonymer
            w2.AddSynonyms(synonyms);  //Ord 2 får lista med synonymer.

            List<Word> wordsInThesaurus = new List<Word>(); //Skapar en tom lista som kan hålla "Word"-objekt.
            wordsInThesaurus.Add(w1); //Lägger in ord i ordlista.
            wordsInThesaurus.Add(w2); //Lägger in ord 2 i ordlista.
            IThesaurus the = new Thesaurus(wordsInThesaurus); //Skapar ordboken som innehåller ordlistan.



            foreach (string s in the.GetWords()) //Skriver ut ordet för varje String i listan med "wordName"
            {
                Console.WriteLine("The word is: " + s);
                Console.WriteLine("And it's synonyms are: ");

                foreach (string a in the.GetSynonyms(s.ToString())) //Skriver ut varje synonym som tillhör ordet.
                {
                    Console.WriteLine(a.ToString());
                }
                Console.WriteLine("");
            }

            Console.Read();
        }
    }
}
