using System;

namespace FrogRiverOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            var pond = new int[] { 1, 3, 1, 4, 2, 3500, 5, 4 };
            Console.WriteLine(Solution(x, pond));
        }

        static int Solution(int x, int[] pond)
        {
            int steps = x;
            bool[] bitmap = new bool[steps + 1];
            for (int i = 0; i < pond.Length; i++)
            {
                if (!bitmap[pond[i]])
                {
                    bitmap[pond[i]] = true;
                    steps--;
                }
                if (steps == 0) return i;
            }

            return -1;
        }
    }
}
