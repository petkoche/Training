using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[] { 2, 3, 1, 5 };
            Console.WriteLine(Solution(A));
        }

        public static int Solution(int[] A)
        {
            if(A.Length == 0)
            {
                return 1;
            }

            Array.Sort(A);
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] != i + 1)
                {
                    return i + 1;
                }
            }
            return (A[A.Length - 1] + 1);
        }
    }
}
