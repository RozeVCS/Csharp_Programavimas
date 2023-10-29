using System;

namespace Uzduotis31
{
    internal class Program
    {

        // Parašykite sumos funkciją su 3 parametrais,
        // kuris gražina int tipo atsakymą.
        //Parašykite dalmens funkciją su 2 parametrais,
        //kuris gražina double tipo  atsakymą.
        //Išsikvieskite abi funkcijas ir atsakymą išveskite į ekraną.

        // Sum function with three parameters that returns an int response
        static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }

        // Divide function with two parameters that returns a double response
        static double Divide(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                Console.WriteLine("Division by zero is not allowed.");
                return 0.0;
            }
            return (double)numerator / denominator;
        }

        static void Main()
        {
            int num1 = 10;
            int num2 = 5;
            int num3 = 3;

            int sumResult = Sum(num1, num2, num3);
            double divideResult = Divide(num1, num2);

            Console.WriteLine($"Sum of {num1}, {num2}, and {num3} is: {sumResult}");
            Console.WriteLine($"Division of {num1} by {num2} is: {divideResult}");
        }
    }

}

