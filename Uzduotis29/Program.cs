using System;

namespace Uzduotis29
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        private static void GreetUser(string name, int age, string hobby)
        {
            Console.WriteLine("Hello, " + name + "!");
            Console.WriteLine("You are " + age + " years old.");
            Console.WriteLine("Your hobby is " + hobby + ".");
        }
        private static void Main1()
        {
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();

            Console.Write("Enter your age: ");
            int userAge = int.Parse(Console.ReadLine());

            Console.Write("Enter your hobby: ");
            string userHobby = Console.ReadLine();

            // Call the GreetUser method with user information
            GreetUser(userName, userAge, userHobby);

        }

        
    }   




}
