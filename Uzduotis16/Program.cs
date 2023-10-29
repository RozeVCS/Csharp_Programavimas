using System;

namespace Uzduotis16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Raskite visų skaičių nuo 1 iki 100 sumą.

            int n = 100;
            int sum = (n * (n + 1)) / 2;

            Console.WriteLine("The sum of all numbers from 1 to 100 is: " + sum);

            // Raskite visų lyginių skaičių nuo 20 iki 40 sumą.

            int start = 20;
            int end = 40;
            int sum1 = 0;

            for (int i = start; i <= end; i += 2)
            {
                sum1 += i;
            }

            Console.WriteLine("The sum of even numbers between 20 and 40 is: " + sum1);

            // Raskite visų nelyginių skaičių nuo 30 iki 60 sumą.

            int start2 = 31; 
            int end2 = 59;   
            int sum2 = 0;

            for (int i = start2; i <= end2; i += 2)
            {
                sum2 += i;
            }

            Console.WriteLine("The sum of odd numbers between 30 and 60 is: " + sum2);

            // Rasti visų skaičių, žemesnių už 1000
            // ir didesnių už 0 bei kurie dalinasi iš 3 arba 5, sumą.

            int sum3 = 0;

            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum3 += i;
                }
            }

            Console.WriteLine("The sum of numbers less than 1000 and greater than 0 that are divisible by 3 or 5 is: " + sum);



        }
    }
}
