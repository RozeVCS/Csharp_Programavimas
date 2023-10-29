using System;
using System.Collections.Generic;

namespace Uzduotis27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Susikurti žodžių sąrašą. Rasti trumpiausią ir ilgiausią žodžius,
            // juos išvesti į  ekraną,
            // prie kiekvieno pasakant iš kiek raidžių jis yra sudarytas.
            //Tip: string kintamasis iš tiesų yra char masyvas, todėl galite naudoti
            //zodis.Length

            List<string> words = new List<string>
        {
            "milk",
            "juice",
            "vodka",
            "wine",
            "gin tonic",
            "whiskey",
        };

            string shortestWord = words[0];
            string longestWord = words[0];

            foreach (string word in words)
            {
                if (word.Length < shortestWord.Length)
                {
                    shortestWord = word;
                }

                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
            }

            Console.WriteLine("List of Words:");
            foreach (string word in words)
            {
                Console.WriteLine($"{word} ({word.Length} letters)");
            }

            Console.WriteLine("Shortest Word: " + shortestWord + " (" + shortestWord.Length + " letters)");
            Console.WriteLine("Longest Word: " + longestWord + " (" + longestWord.Length + " letters)");



        }
    }
}
