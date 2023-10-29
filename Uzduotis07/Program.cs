using System;

namespace Uzduotis07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Liepkite vartotojui įvesti savo vardą ir amžių.
            // Į ekraną išveskite: “Jūsų vardas {vardas}, o amžius {amžius}.”

            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Please enter your age: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine($"Your name is {name} and your age is {age}.");

            // Liepkite vartotojui įvesti bet kokį simbolį.
            // Atspausdinkite 3x3 kvadratą iš to simbolio.

            Console.Write("Please enter a character: ");
            char symbol = Console.ReadKey().KeyChar;

            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine(); 

            }

            //Liepkite vartotojui įvesti bet kokį skaičių.
            //Išveskite į ekraną šio skaičiaus kvadratą.

            Console.Write("Please enter a number: ");
            double number = double.Parse(Console.ReadLine());

            double square = number * number;

            Console.WriteLine($"The square of {number} is {square}");

            //Liepkite vartotojui įvesti tris skaičius.
            // Išveskite visų šių skaičių sumą, skirtumą, sandaugą ir dalmenį,
            // nurodant atliekamus veiksmus ir šių skaičių reikšmes ekrane.

            Console.Write("Please enter the first number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Please enter the second number: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.Write("Please enter the third number: ");
            double num3 = double.Parse(Console.ReadLine());

            double sum = num1 + num2 + num3;
            double difference = num1 - num2 - num3;
            double multiplication = num1 * num2 * num3;
            double division = num1 / num2 / num3;

            Console.WriteLine($"Sum: {num1} + {num2} + {num3} = {sum}");
            Console.WriteLine($"Difference: {num1} - {num2} - {num3} = {difference}");
            Console.WriteLine($"Multiplication: {num1} * {num2} * {num3} = {multiplication}");
            Console.WriteLine($"Division: {num1} / {num2} / {num3} = {division}");
        }
    }
}
