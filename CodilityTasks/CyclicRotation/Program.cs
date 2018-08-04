using System;

namespace CyclicRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[] { 3, 8, 9, 7, 6 };
            var res = Solution(A, 3);

            foreach (var item in res)
            {
                Console.Write(item);
            }

            Console.WriteLine();
        }

        public static int[] Solution(int[] A, int K)
        {
            int oldValue = 0;
            for (int l = 0; l < K; l++)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    int newVal = A[i];

                    if (i == 0)
                    {
                        A[i] = A[A.Length - 1];
                        oldValue = newVal;
                        continue;
                    }
                    else
                    {
                        A[i] = oldValue;
                        oldValue = newVal;
                    }
                }
            }

            return A;
        }
    }
}
