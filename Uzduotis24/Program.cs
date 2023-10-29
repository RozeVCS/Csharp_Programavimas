using System;


namespace Uzduotis24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Paklausti vartotojo, kiek duomenų nori įvesti į masyvą
            // Pagal tai sukursime tokio dydžio masyvą
            //Iš konsolės įvesti duomenis į masyvą
            //Surasti 2 sumas:
            // Suma1 – kai masyvo elementas yra lyginis skaičius
            // Suma2 – kai masyvo indeksas nėra lyginis skaičius


            // Ask the user for the array size
            Console.Write("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());

            // Create an array of the specified size
            int[] dataArray = new int[size];

            // Prompt the user to enter data into the array
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter data for element {i + 1}: ");
                dataArray[i] = int.Parse(Console.ReadLine());
            }

            // Calculate the sum of even-numbered elements and elements at odd indices
            int sum1 = 0; // Sum of even-numbered elements
            int sum2 = 0; // Sum of elements at odd indices

            for (int i = 0; i < size; i++)
            {
                if (i % 2 == 0)
                {
                    // Even-numbered elements
                    sum1 += dataArray[i];
                }
                else
                {
                    // Elements at odd indices
                    sum2 += dataArray[i];
                }
            }

            // Display the results
            Console.WriteLine("Array data:");
            foreach (int element in dataArray)
            {
                Console.Write(element + " ");
            }

            Console.WriteLine("\nSum of even-numbered elements: " + sum1);
            Console.WriteLine("Sum of elements at odd indices: " + sum2);


        }
    }
}
