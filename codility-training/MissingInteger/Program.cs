using System;
using System.Linq;

namespace MissingInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            var A = new int[] { 1, 3, 6, 4, 1, 2};
            Console.WriteLine(Solution(A));
        }

        public static int Solution (int[] A)
        {
            int maxNumb = 1;
            Array.Sort(A);
            foreach (var number in A)
            {
                if (number == maxNumb)
                {
                    maxNumb = maxNumb + 1;
                }
            }
            return maxNumb;
        }
    }
}
