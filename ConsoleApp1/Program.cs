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

            IThesaurus the = new Thesaurus();
            the.AddSynonyms(new String[] { "Hej", "Yo", "Tjabba", "Tjena" });

            the.GetSynonyms("Hej");
            the.GetSynonyms("Yo");

            the.GetWords();

            the.AddSynonyms(new String[] { "Kärlek", "Amour", "Betuttning", "Svärmeri" });

            the.GetSynonyms("Svärmeri");

            the.GetWords();

            the.AddSynonyms(new String[] { "Hej", "Tja", "Tjoflöjt" });
            the.GetSynonyms("Hej");

            the.GetWords();

            Console.Read();
        }
    }
}
