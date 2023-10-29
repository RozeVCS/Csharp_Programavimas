using System;

namespace Uzduotis12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Liepkite įvesti tris skirtingus skaičius.
            /*Suraskite, kuris iš šių skaičių yra didžiausias.
             */

            Console.Write("Please enter the first number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Please enter the second number: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.Write("Please enter the third number: ");
            double num3 = double.Parse(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine($"The largest number is: {num1}");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine($"The largest number is: {num2}");
            }
            else if (num3 > num1 && num3 > num2)
            {
                Console.WriteLine($"The largest number is: {num3}");
            }
            else
            {
                Console.WriteLine("The numbers are not distinct, or there is no largest number.");
            }

            /* Liepkite įvesti egzamino rezultatą. Atlikite šiuos patikrinimus:
             * ar gautas rezultatas yra [8-10];
               ar gautas rezultatas yra [5-8);
               ar gautas rezultatas yra < 5.
            */

            Console.Write("Please enter the exam result: ");
            double result = double.Parse(Console.ReadLine());

            if (result >= 8 && result <= 10)
            {
                Console.WriteLine("The obtained result is in the range [8-10].");
            }
            else if (result >= 5 && result < 8)
            {
                Console.WriteLine("The obtained result is in the range [5-8).");
            }
            else if (result < 5)
            {
                Console.WriteLine("The obtained result is less than 5.");
            }
            else
            {
                Console.WriteLine("The obtained result is not within the specified ranges.");
            }

            /* Liepkite įvesti du skaičius. Patikrinkite (naudojant 4 atskirus if’us):
             * ar pirmas skaičius yra didesnis už antrąjį, arba yra lygus 0;
               ar antras skaičius yra didesnis už pirmąjį, arba yra lygus 5;
               ar pirmas skaičius yra didesnis už antrąjį ir yra lygus 20;
               ar antras skaičius yra didesnis už pirmąjį ir yra mažesnis už 100.
            */

            Console.Write("Please enter the first number: ");
            double number1 = double.Parse(Console.ReadLine());

            Console.Write("Please enter the second number: ");
            double number2 = double.Parse(Console.ReadLine());

            if (number1 > number2 || number1 == 0)
            {
                Console.WriteLine("The first number is greater than the second or equal to 0.");
            }

            if (number2 > number1 || number2 == 5)
            {
                Console.WriteLine("The second number is greater than the first or equal to 5.");
            }

            if (number1 > number2 && number1 == 20)
            {
                Console.WriteLine("The first number is greater than the second and equal to 20.");
            }

            if (number2 > number1 && number2 < 100)
            {
                Console.WriteLine("The second number is greater than the first and less than 100.");
            }
        }
    }
}
