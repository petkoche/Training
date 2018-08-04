using System;

namespace Krachkomer
{
    class Program
    {
        const uint metersPerMile = 1609;

        static void Main()
        {
            uint distanceMiles = uint.Parse(Console.ReadLine());
            uint result = convertMilesToMeters(distanceMiles);
            Console.WriteLine(result);
        }        

        private static uint convertMilesToMeters(uint miles)
        {
            uint result = miles * metersPerMile;
            return result;
        }
    }
}
