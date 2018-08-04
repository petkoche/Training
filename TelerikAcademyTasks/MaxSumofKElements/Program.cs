using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxSumofKElements
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                numbers.Add(currentNumber);
            }

            int result = numbers.OrderByDescending(x => x).Take(k).Sum();
            Console.WriteLine(result);
        }
    }
}
