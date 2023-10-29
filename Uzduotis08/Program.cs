using System;

namespace Uzduotis08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Liepkite vartotojui įvesti bet kokį sveikąjį skaičių.
            // Išveskite šio skaičiaus daugybos lentelę nuo 1 iki 5.

            Console.Write("Please enter an integer: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine($"Multiplication Table for {number} (1 to 5):");

            for (int i = 1; i <= 5; i++)
            {
                int product = number * i;
                Console.WriteLine($"{number} * {i} = {product}");


            }

            // Liepkite vartotojui įvesti tris skaičius.
            // Į ekraną išveskite šiuos skaičius ir jų vidurkį. 

            Console.Write("Please enter the first number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Please enter the second number: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.Write("Please enter the third number: ");
            double num3 = double.Parse(Console.ReadLine());

            double average = (num1 + num2 + num3) / 3;

            Console.WriteLine($"Entered numbers: {num1}, {num2}, {num3}");
            Console.WriteLine($"Average: {average}");

            // Liepkite įvesti tris skaičius. 
            // Išveskite įvestus skaičius, jų kvadratus,
            // juos pakeltus trečiuoju laipsniu, taip pat tuos skaičius,
            // padalintus iš dviejų.

            Console.Write("Please enter the first number: ");
            _ = double.Parse(Console.ReadLine());

            Console.Write("Please enter the second number: ");
            _ = double.Parse(Console.ReadLine());

            Console.Write("Please enter the third number: ");
            _ = double.Parse(Console.ReadLine());

            double square1 = num1 * num1;
            double square2 = num2 * num2;
            double square3 = num3 * num3;
            double cube1 = num1 * num1 * num1;
            double cube2 = num2 * num2 * num2;
            double cube3 = num3 * num3 * num3;
            double divisionBy2_1 = num1 / 2;
            double divisionBy2_2 = num2 / 2;
            double divisionBy2_3 = num3 / 2;

           
            Console.WriteLine($"Entered numbers: {num1}, {num2}, {num3}");
            Console.WriteLine($"Squares: {square1}, {square2}, {square3}");
            Console.WriteLine($"Cubes: {cube1}, {cube2}, {cube3}");
            Console.WriteLine($"Divisions by 2: {divisionBy2_1}, {divisionBy2_2}, {divisionBy2_3}");
        }

    }
    }


