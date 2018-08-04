using System;

namespace MaxCounters
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 3, 4, 4, 6, 1, 4, 4};
            int n = 5;
            var res = Solution(n, a);

            foreach (var item in res)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            a = new int[] { 3, 4, 4, 6, 1, 4, 4, 6, 6, 6, 6 };
            n = 5;
            res = Solution(n, a);

            foreach (var item in res)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            a = new int[] { 1, 1, 0, 0, 0, 0, 0, 6, 6, 6, 6 };
            n = 5;
            res = Solution(n, a);

            foreach (var item in res)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }

        public static int[] Solution(int n, int[] a)
        {
            int currentMax = 0;
            int lastMax = 0;
            int[] counters = new int[n];

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] >= 1 && a[i] <= n)
                {
                    counters[a[i] - 1] = Math.Max(counters[a[i] - 1], lastMax);
                    counters[a[i] - 1] += 1;
                    currentMax = Math.Max(currentMax, counters[a[i] - 1]);
                }
                else if (a[i] == n + 1)
                {
                    lastMax = currentMax;
                }
            }

            for (int i = 0; i < counters.Length; i++)
            {
                counters[i] = Math.Max(counters[i], lastMax);
            }

            return counters;
        }
    }
}
