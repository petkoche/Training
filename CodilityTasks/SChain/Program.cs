using System;

namespace SChain
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution("1-1,3-5,5-2,2-3,2-4")); // 3
            Console.WriteLine(Solution("1-1,2-4,3-1,5-2,1-3")); // 0
            Console.WriteLine(Solution("")); // 0
            Console.WriteLine(Solution("1-1")); // 0
            Console.WriteLine(Solution("1-2,1-2")); // 0
            Console.WriteLine(Solution("3-2,2-1,1-4,4-4,5-4,4-2,2-1")); // 4
            Console.WriteLine(Solution("5-5,5-5,4-4,5-5,5-5,5-5,5-5,5-5,5-5,5-5")); // 7
            Console.WriteLine(Solution("1-1,3-5,5-5,5-4,4-2,1-3")); // 4
            Console.WriteLine(Solution("1-2,2-2,3-3,3-4,4-5,1-1,1-2")); // 3
        }

        public static int Solution(string chain)
        {
            int currentCount = 1;
            int chainCount = 1;
            var elements = chain.Split(',');

            for (int i = 0; i < elements.Length - 1; i++)
            {
                if(elements[i][2] == elements[i + 1][0])
                {
                    currentCount++;
                }
                else
                {
                    currentCount = 1;
                }

                if (currentCount >= chainCount)
                {
                    chainCount = currentCount;
                }
            }

            return (chainCount == 1) ? 0 : chainCount;
        }
    }
}
