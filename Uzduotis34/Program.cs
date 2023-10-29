using System;

namespace Uzduotis34
{
    internal class Program
    {
        // Įvesti du skaičius iš konsolės
        // Paklausti vartotojo kokį veiksmą su tais skaičiais nori atlikti: Daugybą ar  dalybą
        // Parašyti po atskirą metodą kiekvienam veiksmui (daugybai naudoti int tipą, o  dalybai double)
        // Su if patikrinti kokį veiksmą atlikti ir išsikviesti atitinkamą metodą, jei tokio  veiksmo nėra – informuoti vartotoją, jog tokio veiksmo nėra.

        // Method to perform multiplication
        static int Multiply(int a, int b)
        {
            return a * b;
        }

        // Method to perform division
        static double Divide(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Division by zero is not allowed.");
                return 0.0;
            }
            return (double)a / b;
        }

        static void Main()
        {
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Select an action to perform:");
            Console.WriteLine("1. Multiplication");
            Console.WriteLine("2. Division");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                int resultMultiply = Multiply(num1, num2);
                Console.WriteLine($"Multiplication result: {resultMultiply}");
            }
            else if (choice == 2)
            {
                double resultDivide = Divide(num1, num2);
                Console.WriteLine($"Division result: {resultDivide}");
            }
            else
            {
                Console.WriteLine("Invalid action. Please select a valid action.");



            }
        }
    }
}
