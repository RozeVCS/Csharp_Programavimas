using System;

namespace Uzduotis15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Parašyti for, kuris išvestų kiekvieną skaičių pradedant
            // nuo 0 ir baigiant 10. Kiekvieną skaičių išvesti skirtingoje eilutėje.

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            // Parašyti for, kuris išvestų kas antrą skaičių pradedant
            /* 0 ir baigiant 15.
            Kiekvieną skaičių išvesti toje pačioje eilutėje, 
            po kiekvieno skaičiaus dedant tarpą.
            */

            for (int i = 0; i <= 15; i += 2)
            {
                Console.Write(i);

                if (i < 15)
                {
                    Console.Write(" ");
                }

                /*  Parašyti for, kuris išvestų kas trečią skaičių,
                // pradedant 1 ir baigiant 20.
                Kiekvieną skaičių išvesti toje pačioje eilutėje, 
                tačiau parašant skaičių laužtiniuose skliaustuose.
                */

                for (int a = 1; a <= 20; a += 3)
                {
                    Console.Write("[" + a + "]");

                    if (a < 19)
                    {
                        Console.Write(" ");
                    }

                    /* Parašyti for, kuris eitų pro kiekvieną skaičių nuo 1 iki 10. 
                     * Jame apsirašyti if sąlygą, 
                     * kuri patikrintų, ar dabartinis skaičius yra lyginis, 
                     * jei taip – tai šį skaičių išvesti.
                   */

                    for (int b = 1; b <= 10; b++)
                    {
                        if (b % 2 == 0)
                        {
                            Console.WriteLine(b);
                        }


                    }
                }
            }
        }
    }
}