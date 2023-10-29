using System;

namespace Uzduotis11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Liepkite vartotojui įvesti tris skaičius,
            /* parašyti šią patikrinimo sąlygą, naudojant else if dalis:
             * ar pirmas skaičius didesnis už antrą;
             ar antras skaičius didesnis už trečią;
             ar trečias skaičius didesnis už pirmą;
             ar pirmi du skaičiai lygūs;
            */

            Console.Write("Please enter the first number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Please enter the second number: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.Write("Please enter the third number: ");
            double num3 = double.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("The first number is greater than the second.");
            }
            else if (num2 > num3)
            {
                Console.WriteLine("The second number is greater than the third.");
            }
            else if (num3 > num1)
            {
                Console.WriteLine("The third number is greater than the first.");
            }
            else if (num1 % 2 == 0 && num2 % 2 == 0)
            {
                Console.WriteLine("The first and second numbers are even.");
            }

            /* Liepkite vartotojui įvesti šios dienos oro temperatūrą, 
             * atlikite šiuos patikrinimus:
             * ar temperatūra < 0 - išvesti “žiauriai šalta”;
               ar temperatūra < 10 - išvesti “labai šalta”;
               ar temperatūra < 20 - išvesti “šalta”;
               ar temperatūra < 30 - išvesti “normali temperatūra”;
               ar temperatūra < 40 - išvesti “karšta”;
               ar temperatūra >= 40 - išvesti “visiškai degina”;
           */

            Console.Write("Please enter today's air temperature: ");
            double temperature = double.Parse(Console.ReadLine());

            if (temperature < 0)
            {
                Console.WriteLine("It's brutally cold.");
            }
            else if (temperature < 10)
            {
                Console.WriteLine("It's very cold.");
            }
            else if (temperature < 20)
            {
                Console.WriteLine("It's cold.");
            }
            else if (temperature < 30)
            {
                Console.WriteLine("It's a normal temperature.");
            }
            else if (temperature < 40)
            {
                Console.WriteLine("It's hot.");
            }
            else
            {
                Console.WriteLine("It's scorching hot!");
            }

        }
    }
}
