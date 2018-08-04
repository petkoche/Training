using System;

namespace PermCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new int[] { 4, 1, 3 };
            Console.WriteLine(Solution(a));

            a = new int[] { 4, 1, 3, 2 };
            Console.WriteLine(Solution(a));

            a = new int[] { 4, 1, 2, 2 };
            Console.WriteLine(Solution(a));

            a = new int[] { 2 };
            Console.WriteLine(Solution(a));
        }

        static int Solution(int[] a)
        {
            int num = 1;
            Array.Sort(a);
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i] == num)
                {
                    num++;
                }
            }

            return (num <= a.Length) ? 0 : 1;
        }
    }
}
