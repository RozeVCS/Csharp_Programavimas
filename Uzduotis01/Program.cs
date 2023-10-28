using System;

namespace Uzduotis01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            * Parašykite programą, kuri išvestų žodį “Labas” ir jūsų vardą toje pačioje eilutėje.
            */

            Console.WriteLine($"Labas, Rože");


            /*
            * Susikurkite kintamąjį žmogaus amžiui nusakyti, 
            * išveskite į ekraną tekstą su šiuo amžiumi: “Įvestas amžius: {amžius}”. 
            * Tarp {} nurodytas kintamasis, kurio reikšmė toje vietoje turi būti įstatyta.
            */

            int amzius = 45;
            Console.WriteLine("Įvestas amžius: {45}");


            /*
            *Susikurkite skaičiaus kintamąjį, 
            *kurį išveskite penkis kartus toje pačioje eilutėje be tarpų tarp šių skaičių (skaičius - 25, išvedimas - 2525252525).
            */

            int skaicius = 25;
            Console.WriteLine(2525252525);

            /*
            *Susikurkite skaičiaus kintamąjį, kurį išveskite penkis kartus toje pačioje
            *eilutėje su tarpais tarp šių skaičių (skaičius - 25, rezultatas - 25 25 25 25 25).
           */
            int number = 25;
            Console.WriteLine("25 25 25 25 25");
        }
    }
}
