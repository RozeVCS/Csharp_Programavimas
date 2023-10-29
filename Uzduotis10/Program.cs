using System;

namespace Uzduotis10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Liepkite įvesti skaičių.
            /* Jei skaičius lyginis, tuomet išveskite šį skaičių bei jo penktą laipsnį.
             * Jei skaičius nesidalina iš 4, tuomet liepkite įvesti antrąjį skaičių. 
             * Išveskite abiejų skaičių sumą ir sandaugą.
            */

            Console.Write("Please enter a number: ");
            double number = double.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                double fifthPower = Math.Pow(number, 5);
                Console.WriteLine($"Number: {number}");
                Console.WriteLine($"Fifth Power: {fifthPower}");
            }
            else
            {
                if (number % 4 != 0)
                {
                    Console.Write("Enter a second number: ");
                    double secondNumber = double.Parse(Console.ReadLine());

                    double sum = number + secondNumber;
                    double multiplication = number * secondNumber;

                    Console.WriteLine($"Sum of both numbers: {sum}");
                    Console.WriteLine($"Multiplication of both numbers: {multiplication}");

                }
            }
        }
    }
}
