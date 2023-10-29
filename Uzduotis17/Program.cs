using System;

namespace Uzduotis17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Liepkite vartotojui įvesti teigiamą skaičių. 
             * Ciklo pagalba šį skaičių išvesti mažėjimo tvarka iki kol jis pasieks 0.
             * Kiekvieną kartą išvesti skirtingose eilutėse.
            */

            Console.Write("Please enter a positive number: ");
            int number4 = int.Parse(Console.ReadLine());

            if (number4 <= 0)
            {
                Console.WriteLine("Please enter a positive number.");
            }
            else
            {
                while (number4 > 0)
                {
                    Console.WriteLine(number4);
                    number4--;

                }

                /* Liepkite vartotojui įvesti neigiamą skaičių. 
                 * Ciklo pagalba šį skaičių išvesti didėjimo tvarka iki kol 
                 * jis pasieks 0, taip pat išvesti 0. 
                 * Kiekvieną kartą išvesti toje pačioje eilutėje, 
                 * skaičius atskiriant tarpais.
                */

                Console.Write("Please enter a negative number: ");
                int number = int.Parse(Console.ReadLine());

                if (number >= 0)
                {
                    Console.WriteLine("Please enter a negative number.");
                }
                else
                {
                    while (number < 0)
                    {
                        Console.Write(number + " ");
                        number++;

                    }
                }

                /* Padarykite skaičiuotuvą.
                 *  Kiekvieno ciklo iteracijos metu vartotojas turi suvesti du skaičius. 
                 * Iš šių skaičių turi būti grąžinami visi sudėties, 
                 * skirtumo, sandaugos ir dalmens atsakymai, 
                 * išvedant kartu ir atliekamus veiksmus.
                 * Programa vykdoma tol, kol vartotojas nori atlikinėti skaičiavimus.
                */

                bool continueCalculations = true;

                while (continueCalculations)
                {
                    Console.Write("Enter the first number: ");
                    double num1 = double.Parse(Console.ReadLine());

                    Console.Write("Enter the second number: ");
                    double num2 = double.Parse(Console.ReadLine());

                    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                    Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                    Console.WriteLine($"{num1} * {num2} = {num1 * num2}");

                    if (num2 != 0)
                    {
                        Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                    }
                    else
                    {
                        Console.WriteLine("Division by zero is not allowed.");
                    }

                    Console.Write("Do you want to perform more calculations? (y/n): ");
                    string response = Console.ReadLine();

                    if (response.ToLower() != "y")
                    {
                        continueCalculations = false;
                    }



                }
            }
        }
    }
}





