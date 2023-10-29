using System;

namespace Uzduotis19
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Parašyti For ciklą, kuris suskaičiuotų, kiek skaičių intervale [0 – 1000) dalinasi iš 16.

            int count = 0;

            for (int i = 0; i < 1000; i++)
            {
                if (i % 16 == 0)
                {
                    count++;
                }
            }

            Console.WriteLine($"The number of numbers divisible by 16 in the interval [0 - 1000) is: {count}");

            /* Liepkite vartotojui įvesti teigiamą skaičių. 
             * While ciklo viduje skaičių kelkite vis
             didesniu laipsniu ir jį išveskite į ekraną, 
            kol skaičius netaps didesnis už 1500.
           */

            Console.Write("Please enter a positive number: ");
            double number = double.Parse(Console.ReadLine());

            if (number <= 0)
            {
                Console.WriteLine("Please enter a positive number.");
            }
            else
            {
                while (number <= 1500)
                {
                    Console.WriteLine($"{number} ^ 2 = {Math.Pow(number, 2)}");
                    number = Math.Pow(number, 2);
                }


            }
        }
    }
}
