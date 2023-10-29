using System;

namespace Uzduotis25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Liepti vartotojui įvesti 5 pažymius VIENOJE eilutėje atskiriant tarpu.
            // Rasti  didžiausią pažymį.

            Console.Write("Enter 5 grades separated by a space: ");
            string input = Console.ReadLine();

            string[] gradeStrings = input.Split(' ');

            if (gradeStrings.Length != 5)
            {
                Console.WriteLine("Please enter exactly 5 grades separated by a space.");
            }
            else
            {
                int[] grades = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    if (int.TryParse(gradeStrings[i], out grades[i]) == false)
                    {
                        Console.WriteLine("Invalid input. Please enter numeric grades.");
                        return;
                    }
                }

                int highestGrade = grades[0];
                for (int i = 1; i < 5; i++)
                {
                    if (grades[i] > highestGrade)
                    {
                        highestGrade = grades[i];
                    }
                }

                Console.WriteLine("The highest grade is: " + highestGrade);

                // Liepti vartotojui įvesti 5 pažymius VIENOJE eilutėje atskiriant kableliu.
                // Rasti mažiausią pažymį.

                Console.Write("Enter 5 grades separated by commas: ");
                string input1 = Console.ReadLine();

                string[] gradeStrings1 = input1.Split(',');

                if (gradeStrings1.Length != 5)
                {
                    Console.WriteLine("Please enter exactly 5 grades separated by commas.");
                }
                else
                {
                    int[] grades1 = new int[5];
                    for (int i = 0; i < 5; i++)
                    {
                        if (int.TryParse(gradeStrings1[i], out grades1[i]) == false)
                        {
                            Console.WriteLine("Invalid input. Please enter numeric grades.");
                            return;
                        }
                    }

                    int lowestGrade = grades[0];
                    for (int i = 1; i < 5; i++)
                    {
                        if (grades[i] < lowestGrade)
                        {
                            lowestGrade = grades[i];
                        }
                    }

                    Console.WriteLine("The lowest grade is: " + lowestGrade);
                }

            }
        }
    }
}
