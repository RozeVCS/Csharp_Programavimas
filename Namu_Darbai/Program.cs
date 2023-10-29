using System;


namespace Namu_Darbai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Susikurti 2 masyvus su duomenimis, išbandant abu kūrimo būdus (iškart su  duomenimis, arba pirma nusirodant dydį ir tada priskiriant reikšmes),
            //pasibandymui išsivesti norimus duomenis iš visų šių masyvų:
            //skirtą studentų pažymiams saugoti;
            //skirtą mašinų markėms saugoti.

            // Create arrays immediately with data:
            int[] studentGrades = { 85, 90, 78, 92, 88, 76, 85, 89, 94, 82 };

            string[] machineBrands = { "Toyota", "Honda", "Ford", "Chevrolet", "Volkswagen", "Nissan" };

            //  Specify size first and then assign values:

            int[] studentGrades2 = new int[10];
            studentGrades2[0] = 85;
            studentGrades2[1] = 90;
            studentGrades2[2] = 78;
            studentGrades2[3] = 92;
            studentGrades2[4] = 88;
            studentGrades2[5] = 76;
            studentGrades2[6] = 85;
            studentGrades2[7] = 89;
            studentGrades2[8] = 94;
            studentGrades2[9] = 82;

            string[] carBrands2 = new string[6];
            carBrands2[0] = "Toyota";
            carBrands2[1] = "Honda";
            carBrands2[2] = "Ford";
            carBrands2[3] = "Chevrolet";
            carBrands2[4] = "Volkswagen";
            carBrands2[5] = "Nissan";

            // Papildyti praeitos užduoties kodą.
            // Išvesti narių skaičių, pirmą narį ir paskutinį  narį bent iš vieno pasirinkto masyvo.

            // Array for student grades
            int[] studentGrades1 = { 85, 90, 78, 92, 88, 76, 85, 89, 94, 82 };

            // Array for car brands
            string[] carBrands = { "Toyota", "Honda", "Ford", "Chevrolet", "Volkswagen", "Nissan" };

            // Output information about the student grades array
            Console.WriteLine("Student Grades Array:");
            Console.WriteLine("Number of Members: " + studentGrades1.Length); // Get the number of members
            Console.WriteLine("First Member: " + studentGrades1[0]); // Get the first member
            Console.WriteLine("Last Member: " + studentGrades1[studentGrades1.Length - 1]); // Get the last member

            // Output information about the car brands array
            Console.WriteLine("\nCar Brands Array:");
            Console.WriteLine("Number of Members: " + carBrands.Length); // Get the number of members
            Console.WriteLine("First Member: " + carBrands[0]); // Get the first member
            Console.WriteLine("Last Member: " + carBrands[carBrands.Length - 1]); // Get the last member

        }
    }
}
