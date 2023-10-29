using System;
using System.Collections.Generic;

namespace Uzduotis36
{
    class Pupil
    {

        // Sukurti klasę Mokinys su kintamaisiais:
        // vardas, pavardė, amžius, klasė ir  pažymių sąrašą,
        // kur saugosime 5 pažymius.
        // Sukurti konstruktorių, kad priskirtų reikšmes.
        // Klasės viduje sukurti metodą, kad išvestų visą informaciją apie mokinį.
        // Susikurti 3 objektus, jiems priskirti reikšmes ir naudojant sukurtą metodą  išvesti kiekvieno mokinio informaciją.
         
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
        }
    }

    class Program
    {
        static void Main()
        {
            // Create 3 Pupil objects and assign values
            Pupil pupil1 = new Pupil("Stacey", "Jim", 16, "Grade 10", new List<int> { 90, 85, 78, 92, 88 });
            Pupil pupil2 = new Pupil("John", "Smith", 15, "Grade 9", new List<int> { 87, 92, 95, 88, 90 });
            Pupil pupil3 = new Pupil("Tim", "Johnson", 17, "Grade 11", new List<int> { 75, 80, 82, 79, 88 });

            // Output information for each student
            pupil1.DisplayStudentInfo();
            pupil2.DisplayStudentInfo();
            pupil3.DisplayStudentInfo();
        }
    }
}









