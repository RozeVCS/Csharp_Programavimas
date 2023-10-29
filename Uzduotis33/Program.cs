using System;

namespace Uzduotis33
{
    internal class Program
    {

        // Įvesti du skaičius iš konsolės
        // Paklausti vartotojo kokį veiksmą su tais skaičiais nori atlikti: sudėtis, atimtis,  kėlimas 4 laipsniu sudėjus abu skaičius, kvadratinė šaknis sudėjus abu
        //skaičius.
        // Parašyti po atskirą metodą kiekvienam veiksmui (sudėčiai ir atimčiai naudoti  int tipą, o visiems kitiems double).
        // Su switch() patikrinti kokį veiksmą atlikti ir kiekviename case‘e išsikviesti  atitinkamą metodą, jei tokio case‘o nėra – informuoti vartotoją, jog tokio  veiksmo nėra.

        // Method to perform addition
        static int Add(int a, int b)
        {
            return a + b;
        }

        // Method to perform subtraction
        static int Subtract(int a, int b)
        {
            return a - b;
        }

        // Method to raise the sum to the power of 4
        static double PowerOfFour(int a, int b)
        {
            int sum = a + b;
            return Math.Pow(sum, 4);
        }

        // Method to calculate the square root of the sum
        static double SquareRootAfterAddition(int a, int b)
        {
            int sum = a + b;
            return Math.Sqrt(sum);
        }

        static void Main()
        {
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Select an action to perform:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Raise to the power of 4 after addition");
            Console.WriteLine("4. Square root after addition");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    int resultAddition = Add(num1, num2);
                    Console.WriteLine($"Addition result: {resultAddition}");
                    break;
                case 2:
                    int resultSubtraction = Subtract(num1, num2);
                    Console.WriteLine($"Subtraction result: {resultSubtraction}");
                    break;
                case 3:
                    double resultPowerOfFour = PowerOfFour(num1, num2);
                    Console.WriteLine($"Result after raising to the power of 4: {resultPowerOfFour}");
                    break;
                case 4:
                    double resultSquareRoot = SquareRootAfterAddition(num1, num2);
                    Console.WriteLine($"Result after taking the square root: {resultSquareRoot}");
                    break;
                default:
                    Console.WriteLine("Invalid action. Please select a valid action.");
                    break;

            }
        }
    }
}

