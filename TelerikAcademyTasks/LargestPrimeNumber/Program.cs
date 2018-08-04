using System;

namespace LargestPrimeNumber
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            bool[] A = new bool[n + 1];

            //indexed by integers 2 to n, initially all set to true.
            for (int i = 2; i <= n; i++)
            {
                A[i] = true;
            }

            for (int i = 0; i < Math.Sqrt(n + 1); i++)
            {
                if (A[i])
                {
                    for (int j = 2; (j * i) <= n; j++)
                    { A[j * i] = false; }
                }
            }
            for (int j = n; j > 2; j--)
            {
                if (A[j])
                {
                    Console.Write(j + " ");
                    break;
                }
            }
            Console.WriteLine();
        }
    }
}
