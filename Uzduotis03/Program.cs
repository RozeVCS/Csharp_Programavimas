using System;


namespace Uzduotis03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Išveskite į ekraną norimo dydžio tuščiavidurį kvadratą iš žvaigždučių.
            int size = 5; // Change the size to your desired value

            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= size; j++)
                {
                    if (i == 1 || i == size || j == 1 || j == size)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();

            }
    }
    }

}

