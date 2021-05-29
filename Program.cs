using System;

namespace Arithmetic1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Your Age
            int userAge = 35;

            // Length of years on Jupiter (in Earth years)
            double jupiterYears = 11.86;

            // Age on Jupiter
            double jupiterAge = userAge / jupiterYears;

            // Time to Jupiter
            double journeyToJupiter = 6.142466;

            // New Age on Earth
            double newEarthAge = userAge + journeyToJupiter;

            // New Age on Jupiter
            double newJupiterAge = newEarthAge / jupiterYears;

            // Log calculations to console
            Console.WriteLine("my earth age, before settting off for Jupiter: "
            + userAge);
            Console.WriteLine("Length of time to get to Jupiter: "
            + journeyToJupiter);
            Console.WriteLine("my earth age, when arriving on Jupiter: "
            + newEarthAge);
            Console.WriteLine("my age in Jupiter years, after arriving on Jupiter: "
            + newJupiterAge);
        }
    }
}
