using System;
using System.Collections.Generic;
using System.Linq;

namespace TapeEquilibrium
{
    class Program
    {
        static void Main(string[] args)
        {
            var A = new int[] { 3, 1, 2, 4, 3 };
            Console.WriteLine(Solution(A));
        }

        public static int Solution(int[] A)
        {
            int totalSum = 0;

            var results = new HashSet<int>();

            foreach (var item in A)
            {
                totalSum += item;
            }

            int prev = A[0];
            int next = totalSum - prev;

            for (int i = 1; i < A.Length; i++)
            {
                results.Add(ReturnModulus(prev, next));
                prev += A[i];
                next = totalSum - prev;
            }

            return results.Min();
        }

        public static int ReturnModulus(int start, int end)
        {
            return Math.Abs(start - end);
        }
    }
}
