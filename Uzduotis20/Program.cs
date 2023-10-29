using System;

namespace Uzduotis20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Įveskite iš konsolės 2 skaičius (stataus trikampio statinių ilgius).
            Suraskite įžambinę ir ją išveskite į ekraną.
            */

            Console.Write("Enter the length of the first side: ");
            double side1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the length of the second side: ");
            double side2 = double.Parse(Console.ReadLine());

            double hypotenuse = Math.Sqrt(Math.Pow(side1, 2) + Math.Pow(side2, 2));

            Console.WriteLine($"The length of the hypotenuse (preamble) is: {hypotenuse:F2}");

        }
    }
}
