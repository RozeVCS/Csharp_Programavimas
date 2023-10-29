using System;
using System.Diagnostics;

namespace NamuDarbai22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Susikurkite savaitės temperatūrų rodmenų masyvą. Raskite:
            //žemiausią temperatūrą;
            //didžiausią temperatūrą;
            //vidurkį;
            //Temperatūrų, esančių žemiau už vidurkį, kiekį;
            //Temperatūrų, esančių aukščiau už vidurkį, kiekį.

            // Create an array of weekly temperature readings
            double[] weeklyTemperatures = { 10.5, 15.3, 20.1, 5.8, 8.6, 5.9, 10.4 };

            // Find the lowest temperature
            double minTemperature = weeklyTemperatures[0];
            foreach (double temp in weeklyTemperatures)
            {
                if (temp < minTemperature)
                {
                    minTemperature = temp;
                }
            }

            // Find the maximum temperature
            double maxTemperature = weeklyTemperatures[0];
            foreach (double temp in weeklyTemperatures)
            {
                if (temp > maxTemperature)
                {
                    maxTemperature = temp;
                }
            }

            // Calculate the average temperature
            double totalTemperature = 0;
            foreach (double temp in weeklyTemperatures)
            {
                totalTemperature += temp;
            }
            double averageTemperature = totalTemperature / weeklyTemperatures.Length;

            // Calculate the number of below-average and above-average temperatures
            int belowAverageCount = 0;
            int aboveAverageCount = 0;
            foreach (double temp in weeklyTemperatures)
            {
                if (temp < averageTemperature)
                {
                    belowAverageCount++;
                }
                else if (temp > averageTemperature)
                {
                    aboveAverageCount++;
                }
            }

            // Display the results
            Console.WriteLine("Weekly Temperature Readings:");
            Console.WriteLine("Lowest Temperature: " + minTemperature);
            Console.WriteLine("Maximum Temperature: " + maxTemperature);
            Console.WriteLine("Average Temperature: " + averageTemperature);
            Console.WriteLine("Number of Below-Average Temperatures: " + belowAverageCount);
            Console.WriteLine("Number of Above-Average Temperatures: " + aboveAverageCount);

            // Susikurkite studentų pažymių masyvą. Raskite:
            // geriausią pažymį;
            //kiek mokinių yra gavę dešimtukus;
            // kiek mokinių yra gavę neigiamą pažymį(žemiau nei 4);
            // pažymių vidurkį.

            // Create an array of student grades
            int[] studentGrades = { 9, 7, 10, 8, 5, 10, 6, 3, 9, 7 };

            // Find the best grade
            int bestGrade = studentGrades[0];
            foreach (int grade in studentGrades)
            {
                if (grade > bestGrade)
                {
                    bestGrade = grade;
                }
            }

            // Count how many students received a grade of ten
            int countTens = 0;
            foreach (int grade in studentGrades)
            {
                if (grade == 10)
                {
                    countTens++;
                }
            }

            // Count how many students received a negative grade (below 4)
            int countNegativeGrades = 0;
            foreach (int grade in studentGrades)
            {
                if (grade < 4)
                {
                    countNegativeGrades++;
                }
            }

            // Calculate the grade point average
            double totalGrades = 0;
            foreach (int grade in studentGrades)
            {
                totalGrades += grade;
            }
            double averageGrade = totalGrades / studentGrades.Length;

            // Display the results
            Console.WriteLine("Student Grades:");
            Console.WriteLine("Best Grade: " + bestGrade);
            Console.WriteLine("Number of Students with a Grade of Ten: " + countTens);
            Console.WriteLine("Number of Students with a Negative Grade: " + countNegativeGrades);
            Console.WriteLine("Grade Point Average: " + averageGrade);
        }
    }
  
}
    

