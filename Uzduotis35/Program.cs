using System;
using System.Linq;

namespace Uzduotis35
{
    internal class Program
    {
        // Sukurti void tipo metodą, kuriam paduosim masyvą.
        // Metodas turi išvesti masyvo sumą
        // (sumai skaičiuoti naudoti for ciklą ir .Sum()  funkciją.
        // Tuomet metodas išves į konsolę 2 tokias pačias sumas suskaičiuotas  skirtingais būdais)
        // Išsikviesti metodą.

        static void CalculateAndDisplaySum(int[] numbers)
        {
            int sumUsingForLoop = 0;
            int sumUsingLinqSum = numbers.Sum();

            foreach (int number in numbers)
            {
                sumUsingForLoop += number;
            }

            Console.WriteLine("Sum calculated using a for loop: " + sumUsingForLoop);
            Console.WriteLine("Sum calculated using LINQ .Sum() function: " + sumUsingLinqSum);
        }

        static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            CalculateAndDisplaySum(numbers);
        }



    }
}
