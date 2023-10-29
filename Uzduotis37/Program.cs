using System;
using System.Collections.Generic;
using System.Linq;

namespace Uzduotis37
{
    class Pupil
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string ClassName { get; set; }
        public List<int> Grades { get; set; }

        // Constructor to assign values
        public Pupil(string firstName, string lastName, int age, string className, List<int> grades)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            ClassName = className;
            Grades = grades;
        }

        // Method to output all information about the student
        public void DisplayStudentInfo()
        {
            Console.WriteLine("Student Information:");
            Console.WriteLine("First Name: " + FirstName);
            Console.WriteLine("Last Name: " + LastName);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Class: " + ClassName);
            Console.Write("Grades: ");
            foreach (int grade in Grades)
            {
                Console.Write(grade + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Graduation Year: " + CalculateGraduationYear());
        }

        // Method to calculate the year the student will graduate
        public int CalculateGraduationYear()
        {
            int currentYear = DateTime.Now.Year;
            int graduationYear = currentYear + (12 - Age); // Assuming 12 years of school
            if (graduationYear == currentYear)
            {
                return 0; // The student will graduate this year
            }
            return graduationYear;
        }
    }

    class Program
    {
        static void Main()
        {
            Pupil pupil1 = new Pupil("Jim", "Luke", 16, "Grade 10", new List<int> { 90, 85, 78, 92, 88 });
            Pupil pupil2 = new Pupil("Alice", "Smith", 15, "Grade 9", new List<int> { 87, 92, 95, 88, 90 });
            Pupil pupil3 = new Pupil("Bob", "Johnson", 17, "Grade 11", new List<int> { 75, 80, 82, 79, 88 });

            List<Pupil> pupils = new List<Pupil> { pupil1, pupil2, pupil3 };

            // Output graduation year for each student
            Console.WriteLine("Graduation Years:");
            foreach (Pupil pupil in pupils)
            {
                int graduationYear = pupil.CalculateGraduationYear();
                if (graduationYear == 0)
                {
                    Console.WriteLine($"{pupil.FirstName} {pupil.LastName}: The student will graduate from school this year.");
                }
                else
                {
                    Console.WriteLine($"{pupil.FirstName} {pupil.LastName}: {graduationYear}");
                }
            }

            // Output best and worst grades for each student
            Console.WriteLine("Best and Worst Grades:");
            foreach (Pupil pupil in pupils)
            {
                int bestGrade = pupil.Grades.Max();
                int worstGrade = pupil.Grades.Min();
                Console.WriteLine($"{pupil.FirstName} {pupil.LastName}: Best Grade: {bestGrade}, Worst Grade: {worstGrade}");
            }

            // Method to count grades greater than 4
            int CountGradesGreaterThan4(Pupil student)
            {
                return student.Grades.Count(grade => grade > 4);
            }

            Console.WriteLine("Grades Greater Than 4:");
            foreach (Pupil pupil in pupils)
            {
                int count = CountGradesGreaterThan4(pupil);
                Console.WriteLine($"{pupil.FirstName} {pupil.LastName}: Grades > 4: {count}");
            }
        }
    }
}
