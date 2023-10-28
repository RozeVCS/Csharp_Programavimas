using System;

namespace Uzduotis05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Išveskite į ekraną dviejų skaičių sumą, skirtumą, sandaugą ir dalmenį, 
            /* kiekvieną kartą nurodant atliekamą veiksmą ir šių skaičių reikšmes.
            */
            
            double num1 = 20.5;
            double num2 = 5.2;

            double sum = num1 + num2;
            double difference = num1 - num2;
            double multiplication = num1 * num2;
            double division = num1 / num2;

            Console.WriteLine($"Addition: {num1} + {num2} = {sum}");
            Console.WriteLine($"Subtraction: {num1} - {num2} = {difference}");
            Console.WriteLine($"Multiplication: {num1} * {num2} = {multiplication}");
            Console.WriteLine($"Division: {num1} / {num2} = {division}");

            // Išveskite į ekraną pasirinktą skaičių, jo kvadratą ir jį pakeltą trečiuoju laipsniu. 
            
            double number = 20; 

            double square = Math.Pow(number, 2);
            double cube = Math.Pow(number, 3);

            Console.WriteLine($"Number: {number}");
            Console.WriteLine($"Square: {square}");
            Console.WriteLine($"Third Power: {cube}");

            // Išveskite į ekraną trijų skaičių sandaugą.

            double number1 = 8.4;
            double number2 = 1.2;
            double number3 = 3.5;

            double result = number1 * number2 * number3;

            Console.WriteLine($"Multiplication of {number1}, {number2}, and {number3} is {result}");

        }
    }
}
