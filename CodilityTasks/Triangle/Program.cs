using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new int[] { 10, 2, 5, 1, 8, 20};
            Console.WriteLine(Solution(a));
        }

        public static int Solution(int[] a)
        {
            Array.Sort(a);
            for (int i = 0; i < a.Length - 2; i++)
            {
                if (a[i] + a[i + 1] > a[i + 2])                    
                {
                    return 1;
                }

                if (a[i] == a[i + 2] && a[i + 2] == a[i + 1] && a[i] == Int32.MaxValue)
                {
                    return 1;
                }
            }

            return 0;
        }
    }
}
