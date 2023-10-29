using System;

namespace Uzduotis30
{
    internal class Program
    {

        // Leiskite vartotojui įvesti du sveikuosius skaičius į programą.
        // Sukurkite ir panaudokite šiuos metodus:
        //Suma;
        //Skirtumas;
        //Sandauga;
        //Dalmuo;
        // Method to calculate the sum of two numbers


        static int Sum(int a, int b)
        {
            return a + b;
        }

        // Method to calculate the difference of two numbers
        static int Difference(int a, int b)
        {
            return a - b;
        }

        // Method to calculate the multiplication of two numbers
        static int Multiply(int a, int b)
        {
            return a * b;
        }

        // Method to calculate the division of two numbers
        static double Divide(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Division by zero is not allowed.");
                return 0;
            }
            return (double)a / b;
        }

        static void Main()
        {
            Console.Write("Enter the first integer: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second integer: ");
            int num2 = int.Parse(Console.ReadLine());

            int sumResult = Sum(num1, num2);
            int differenceResult = Difference(num1, num2);
            int multiplicationResult = Multiply(num1, num2);
            double divisionResult = Divide(num1, num2);

            Console.WriteLine($"Sum: {sumResult}");
            Console.WriteLine($"Difference: {differenceResult}");
            Console.WriteLine($"Multiplication: {multiplicationResult}");
            Console.WriteLine($"Division: {divisionResult}");
                        
        }
    }
}
