using System;

namespace Uzduotis14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Į ekraną išveskite kelis sunumeruotus pasirinkimus 
             1 - stacionarus kompiuteris
             2 - nešiojamas kompiuteris
             3 - planšetė 
            */

            Console.WriteLine("Choose your device:");
            Console.WriteLine("1 - stationary computer");
            Console.WriteLine("2 - laptop");
            Console.WriteLine("3 - tablet");

            // Liepkite vartotojui įvesti pasirinkimo numerį. 
            Console.Write("Enter the option number: ");
            int option = int.Parse(Console.ReadLine());

            /* Pagal įvestą numerį išveskite atitinkamą tekstą. Pvz:
             * nešiojamuoju kompiuteriu galite naudotis visur
              stacionariu kompiuteriu galite naudotis tik namuose arba darbo vietoje
             planšete galite naudotis visur
            */ // Neradus tinkamo varianto išvesti, kad tokio pasirinkimo nėra.

            switch (option)
            {
                case 1:
                    Console.WriteLine("You selected a stationary computer.");
                    break;
                case 2:
                    Console.WriteLine("You selected a laptop.");
                    break;
                case 3:
                    Console.WriteLine("You selected a tablet.");
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }

        }
    }
}

