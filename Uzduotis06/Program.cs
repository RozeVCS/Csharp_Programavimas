using System;

namespace Uzduotis06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Išveskite pasirinkto skaičiaus daugybos lentelę.

            int selectedNumber = 3; 
            int tableSize = 10; 

            Console.WriteLine($"Multiplication Table for {selectedNumber}:");

            for (int i = 0; i <= tableSize; i++)
            {
                int product = selectedNumber * i;
                Console.WriteLine($"{selectedNumber} * {i} = {product}");

            }

        }
    }
}




