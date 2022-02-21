using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Перемешивание_карт
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Перемешивание карт");
            Console.ReadKey();
            var startingDeck = from s in Suits()
                               from r in Ranks()
                               select new { Suit = s, Rank = r };

            // Display each card that we've generated and placed in startingDeck in the console
            foreach (var card in startingDeck)
            {
                Console.WriteLine(card);
            }
            Console.ReadKey();
        }
        static IEnumerable<string> Suits()
        {
            yield return "бубн";
            yield return "трефы";
            yield return "червы";
            yield return "пики";
        }

        static IEnumerable<string> Ranks()
        {
            yield return "два";
            yield return "три";
            yield return "четыре";
            yield return "пять";
            yield return "шесть";
            yield return "семь";
            yield return "восемь";
            yield return "девять";
            yield return "десять";
            yield return "валет";
            yield return "дама";
            yield return "король";
            yield return "туз";
        }
    }
}
