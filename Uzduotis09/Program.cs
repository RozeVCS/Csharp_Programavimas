using System;

namespace Uzduotis09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Liepkite vartotojui įvesti savo amžių. Jei amžius yra 18 arba daugiau,
            //tuomet į ekraną išveskite, kad “jūs galite balsuoti”.

            Console.Write("Please enter your age: ");
            int age = int.Parse(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("You can vote.");
            }
            else
            {
                Console.WriteLine("You cannot vote.");
            }

            // Liepkite vartotojui įvesti bet kokį skaičių. 
            /* Parašykite šias atskiras if sąlygas:
               Patikrinti, ar skaičius neigiamas, jei taip -aprėkti vartotoją:)
              Patikrinti, ar skaičius teigiamas, jei taip -pasveikinti vartotoją;
              Patikrinti, ar skaičius lyginis, jei taip -išvesti “taip, skaičius yra lyginis”;
              Patikrinti, ar skaičius dalinasi iš 4, jei taip -išvesti “taip, dalinasi iš 4”;
              Patikrinti, ar skaičius yra didesnis nei 10, jei taip -išvesti “taip, skaičius yra didesnis už 10”.
            */

            Console.Write("Please enter a number: ");
            int number = int.Parse(Console.ReadLine());

            if (number < 0)
            {
                Console.WriteLine("You stupid, it is wrong!");
            }
            else if (number > 0)
            {
                Console.WriteLine("Correct, good job!");
            }

            if (number % 2 == 0)
            {
                Console.WriteLine("Yes, the number is even.");
            }

            if (number % 4 == 0)
            {
                Console.WriteLine("Yes, divisible by 4.");
            }

            if (number > 10)
            {
                Console.WriteLine("Yes, the number is greater than 10.");
            }

            // Liepkite vartotojui įvesti penkis  du savo pažymius,
            // raskite šių pažymių vidurkį, patikrinkite,
            // ar vidurkis yra lygus arba didesnis už 5,
            // jei taip, išveskite “Valio!!!”.

            int numberOfGrades = 5;
            double sum = 0;

            for (int i = 1; i <= numberOfGrades; i++)
            {
                Console.Write($"Enter grade {i}: ");
                double grade = double.Parse(Console.ReadLine());
                sum += grade;
            }

            double average = sum / numberOfGrades;

            Console.WriteLine($"Average grade: {average}");

            if (average >= 5)
            {
                Console.WriteLine("Valio!!!");
            }
        }
    }
}
