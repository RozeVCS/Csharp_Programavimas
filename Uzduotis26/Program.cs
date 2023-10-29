using System;
using System.Collections.Generic;
using System.Linq;

namespace Uzduotis26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sugeneruokite atsitiktinio dydžio sąrašą,
            //kurį užpildykite atsitiktiniais  skaičiais nuo 1 iki 100. Raskite:
            //mažiausią skaičių;
            //didžiausią skaičių;
            //vidurkį;
            //kiek skaičių yra žemesni už vidurkį;
            //lyginių skaičių sumą;

            // Generate a random size for the list (between 5 and 15)
            Random rand = new Random();
            int listSize = rand.Next(5, 15);

            // Create a list and fill it with random numbers
            List<int> randomNumbers = new List<int>();
            for (int i = 0; i < listSize; i++)
            {
                randomNumbers.Add(rand.Next(1, 101)); // Generates random numbers between 1 and 100
            }

            // Find the smallest and maximum number
            int smallestNumber = randomNumbers.Min();
            int maximumNumber = randomNumbers.Max();

            // Calculate the average
            double average = randomNumbers.Average();

            // Count how many numbers are below average
            int belowAverageCount = randomNumbers.Count(num => num < average);

            // Calculate the sum of even numbers
            int sumOfEvenNumbers = randomNumbers.Where(num => num % 2 == 0).Sum();

            // Display the results
            Console.WriteLine("Random List of Numbers:");
            Console.WriteLine(string.Join(", ", randomNumbers));
            Console.WriteLine("Smallest Number: " + smallestNumber);
            Console.WriteLine("Maximum Number: " + maximumNumber);
            Console.WriteLine("Average: " + average);
            Console.WriteLine("Number of Numbers Below Average: " + belowAverageCount);
            Console.WriteLine("Sum of Even Numbers: " + sumOfEvenNumbers);

            // Liepkite vartotojui pasirinkti kiek studentų pažymių nori suvesti į sąrašą.
            // Tegul jis užpildo šį sąrašą duomenimis, įvedant juos per konsolę. Raskite:
            // didžiausią pažymį;
            //mažiausią pažymį;
            //vidurkį;

            Console.Write("Enter the number of student grades you want to list: ");
            int numGrades = int.Parse(Console.ReadLine());

            if (numGrades <= 0)
            {
                Console.WriteLine("Please enter a valid number of grades.");
                return;
            }

            List<int> studentGrades = new List<int>();

            for (int i = 0; i < numGrades; i++)
            {
                Console.Write($"Enter grade {i + 1}: ");
                int grade = int.Parse(Console.ReadLine());
                studentGrades.Add(grade);
            }

            if (studentGrades.Count == 0)
            {
                Console.WriteLine("No grades entered.");
                return;
            }

            int highestGrade = studentGrades[0];
            int lowestGrade = studentGrades[0];
            int totalGrades = 0;

            foreach (int grade in studentGrades)
            {
                if (grade > highestGrade)
                {
                    highestGrade = grade;
                }
                if (grade < lowestGrade)
                {
                    lowestGrade = grade;
                }
                totalGrades += grade;
            }

            double averageGrade = (double)totalGrades / numGrades;

            Console.WriteLine("Student Grades:");
            foreach (int grade in studentGrades)
            {
                Console.Write(grade + " ");
            }

            Console.WriteLine("\nHighest Grade: " + highestGrade);
            Console.WriteLine("Lowest Grade: " + lowestGrade);
            Console.WriteLine("Average Grade: " + averageGrade);


        }
    }
}
