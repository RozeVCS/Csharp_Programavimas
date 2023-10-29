using System;

namespace Uzduotis23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Susikurkite kintamąjį, kuris pasakytų kiek automobilis vidutiniškai sunaudoja  degalų 100 – ui km. Susikurkite masyvą, kuriame saugotumėte skirtingose
            //kelionėse nuvažiuotų kilometrų rodmenis. Raskite:
            //trumpiausią kelionę;
            //ilgiausią kelionę;
            //kiek kuro sąnaudų sunaudojo automobilis
            //(skaičiavimui reikės rasti visus  nuvažiuotus km).

            // Car's average fuel consumption per 100 km (e.g., liters)
            double fuelConsumptionPer100Km = 8.5;

            // Array to store different readings of kilometers traveled on trips
            double[] kilometersReadings = { 100, 85, 200, 50, 90, 120, 210 };

            // Find the shortest and longest journey
            double shortestJourney = double.MaxValue;
            double longestJourney = 0;
            foreach (double km in kilometersReadings)
            {
                if (km < shortestJourney)
                {
                    shortestJourney = km;
                }
                if (km > longestJourney)
                {
                    longestJourney = km;
                }
            }

            // Calculate how much fuel the car used for all the kilometers driven
            double totalKilometersDriven = 0;
            foreach (double km in kilometersReadings)
            {
                totalKilometersDriven += km;
            }
            double totalFuelUsed = (totalKilometersDriven / 100) * fuelConsumptionPer100Km;

            // Display the results
            Console.WriteLine("Car's Average Fuel Consumption per 100 km: " + fuelConsumptionPer100Km + " liters");
            Console.WriteLine("Shortest Journey: " + shortestJourney + " km");
            Console.WriteLine("Longest Journey: " + longestJourney + " km");
            Console.WriteLine("Total Fuel Used for All Kilometers Driven: " + totalFuelUsed + " liters");

        }
    }
}
