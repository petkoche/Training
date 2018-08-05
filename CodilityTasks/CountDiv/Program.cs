using System;

namespace CountDiv
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution(6, 11, 2));
            Console.WriteLine(Solution(0, 0, 2));
            Console.WriteLine(Solution(0, int.MaxValue, 2));
        }

        public static int Solution(int a, int b, int k)
        {
            int bRes = b / k;
            int aRes = a / k;

            int res = (a % k == 0) ? bRes - aRes + 1 : bRes - aRes;

            return res;
        }
    }
}
