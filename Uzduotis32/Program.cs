using System;

namespace Uzduotis32
{
    internal class Program
    {

        //Paprašyti įvesti vartotojo vardą.
        // Sukurti string tipo metodą, kuris gražina frazę pvz „Sveiki, Mantas“
        // Išvesti šią frazę į konsolę.

        // Method that takes a username and returns a greeting
        static string GetGreeting(string username)
        {
            return "Hello " + username;
        }

        static void Main()
        {
            Console.Write("Enter your username: ");
            string username = Console.ReadLine();

            string greeting = GetGreeting(username);

            Console.WriteLine(greeting);
        }

    }
}
