using System;
using System.Collections.Generic;

namespace MaxSumofSubsequence
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                numbers.Add(currentNumber);
            }

            int maxSumSoFar = 0;
            int maxISoFar = 0;
            int maxJSoFar = -1;
            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                for (int j = i; j < n; j++)
                {
                    sum += numbers[j];
                    if (sum > maxSumSoFar)
                    {
                        maxSumSoFar = sum;
                        maxISoFar = i;
                        maxJSoFar = j;
                    }
                }
            }

            Console.WriteLine(maxSumSoFar);
        }
    }
}
