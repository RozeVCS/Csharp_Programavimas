using System;

namespace Uzduotis18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Tikslas:
             Suskaičiuoti, kiek duonos kepalų kepykla sugebės iškepti per dieną.
             Patikrinti, ar kepykla spės iškepti visus tos dienos užsakymus, 
             jei ne, suskaičiuoti, kiek kepalų nespės iškepti.
             Suskaičiuoti, kiek kepykla uždirbs pelno iš visų tą dieną iškeptų duonos kepalų.
            Iš anksto žinoma informacija:
            Darbo valandų per dieną - 8 val.
            Vartotojo įvedama informacija:
            Kiek darbuotojas gali iškepti kepalų per valandą.
            Kiek darbuotojų turi kepykla.
            Vieno kepalo savikaina.
            Vieno kepalo pardavimo kaina.
            Kiek kepykla turi tą dieną iškepti kepalų (užsakymai).
            */

            int workingHoursPerDay = 8;

            
            Console.Write("How many loaves can an employee bake in an hour: ");
            int loavesPerHour = int.Parse(Console.ReadLine());

            Console.Write("How many employees does the bakery have: ");
            int numEmployees = int.Parse(Console.ReadLine());

            Console.Write("Cost per loaf: $");
            double costPerLoaf = double.Parse(Console.ReadLine());

            Console.Write("Selling price of one loaf: $");
            double sellingPricePerLoaf = double.Parse(Console.ReadLine());

            Console.Write("How many loaves the bakery has to bake that day (orders): ");
            int totalOrders = int.Parse(Console.ReadLine());

            
            int loavesBakedPerDay = workingHoursPerDay * loavesPerHour * numEmployees;

           
            int loavesToFulfillOrders = Math.Min(totalOrders, loavesBakedPerDay);
            double totalCost = loavesToFulfillOrders * costPerLoaf;
            double totalRevenue = loavesToFulfillOrders * sellingPricePerLoaf;
            double profit = totalRevenue - totalCost;

            
            Console.WriteLine($"The bakery can bake {loavesBakedPerDay} loaves in a day.");
            Console.WriteLine($"The bakery can fulfill {loavesToFulfillOrders} out of {totalOrders} orders.");
            Console.WriteLine($"The bakery will make a profit of ${profit:F2} from the fulfilled orders.");

        }
    }
}
