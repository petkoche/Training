using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOccurancesinAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var A = new int[] { 9, 3, 9, 3, 9, 7, 7 };

            Console.WriteLine(Solution(A));
        }

        public static int Solution(int[] A)
        {
            Array.Sort(A);

            for (int i = 0; i < A.Length - 1; i += 2)
            {
                if (A[i + 1] != A[i])
                {
                    return A[i];
                }
            }

            return A[A.Length-1];
        }
    }
}
