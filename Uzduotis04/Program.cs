using System;

namespace Uzduotis04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Susikurkite reikiamus kintamuosius užduočiai atlikti. 
            /*Į ekraną išveskite: Automobilio {markė} 
             * {modelis}
             * ({metai} m.) 
             * rida - {rida} km.
            Tarp {} nurodyti reikiami kintamieji,
            šiose vietose jų reikšmės turi būti įstatytos.
            */
            string markė = "Toyota";
            string modelis = "Camry";
            int metai = 2015;
            double rida = 41000.5;

            Console.WriteLine($"Automobilio markė: {"Toyota"}, modelis {"Camry"}, metai ({2015} m.), rida {41000.5} km");

        }
    }
}
