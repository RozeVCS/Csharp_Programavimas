using System;

namespace Isvedimas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var currentConsoleOutputEncoding = Console.OutputEncoding;
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Labas pasauli!");
            Console.WriteLine("Ačiū!");
            Console.WriteLine(); // tuscia eilute

            // Kintamųjų išvedimas
            int amzius = 35;
            float ugis = 1.91f;

            Console.Write("Mano amžius: ");
            Console.Write(amzius);
            Console.Write(", o mano ūgis: ");
            Console.Write(ugis);
            Console.WriteLine(".");

            Console.WriteLine("Amžius: " + amzius + ", o mano ūgis: " + ugis + ".");

            Console.WriteLine("Mano amžius: {0} , o mano ūgis: {1}.", amzius, ugis);

            Console.WriteLine($"Mano amžius: {amzius} , o mano ūgis: {ugis}.");



        }
    }
}
