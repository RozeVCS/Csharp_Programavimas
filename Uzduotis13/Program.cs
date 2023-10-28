using System;

namespace Uzduotis13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Liepkite vartotojui įvesti tris skaičius. 
             * Su switch patikrinkite pirmąjį skaičių:
             * ar jis lygus 1: išveskite visų trijų skaičių sumą;
               ar jis lygus 2: išveskite pirmo ir trečio skaičių skirtumą;
               ar jis lygus 3: išveskite antro ir trečio skaičių sandaugą.
            */

            Console.Write("Please enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Please enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Please enter the third number: ");
            int num3 = int.Parse(Console.ReadLine());

            int result = 0;

            switch (num1)
            {
                case 1:
                    result = num1 + num2 + num3;
                    Console.WriteLine($"Sum of all three numbers: {result}");
                    break;

                case 2:
                    result = num1 - num3;
                    Console.WriteLine($"Difference between the first and third numbers: {result}");
                    break;

                case 3:
                    result = num2 * num3;
                    Console.WriteLine($"Multiplication of the second and third numbers: {result}");
                    break;

                default:
                    Console.WriteLine("The first number does not match any case.");
                    break;
            }

            // Liepkite vartotojui įvesti gyvūno rūšį. Su switch patikrinkite:
            /* ar įvestas gyvūnas yra šuo;
               ar įvestas gyvūnas yra katė;
               ar įvestas gyvūnas yra žiurkėnas.
             */

            Console.Write("Please enter the type of animal: ");
            string animal = Console.ReadLine();

            switch (animal.ToLower())
            {
                case "dog":
                    Console.WriteLine("The introduced animal is a dog.");
                    break;

                case "cat":
                    Console.WriteLine("The introduced animal is a cat.");
                    break;

                case "hamster":
                    Console.WriteLine("The introduced animal is a hamster.");
                    break;

                default:
                    Console.WriteLine("The introduced animal is not recognized.");
                    break;


            }
        }
    }
}
