using System;
using System.Linq;

namespace SubsetofSumS_2_BottomUpDP
{
    class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            var numbers = Console.ReadLine().Split(' ').Select(Int32.Parse).ToArray();

            if (isSubsetSum(numbers, numbers.Length, input))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }

        static bool isSubsetSum(int[] set, int n, int sum)
        {
            bool[,] subset = new bool[sum + 1, n + 1];

            for (int i = 0; i <= n; i++)
            {
                subset[0, i] = true;
            }

            for (int i = 1; i <= sum; i++)
            {
                subset[i, 0] = false;
            }

            for (int i = 1; i <= sum; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    subset[i, j] = subset[i, j - 1];
                    if (i >= set[j - 1])
                    {
                        subset[i, j] = subset[i, j] || subset[i - set[j - 1], j - 1];
                    }
                }
            }

            return subset[sum, n];
        }
    }
}
