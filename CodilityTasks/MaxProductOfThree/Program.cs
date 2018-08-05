using System;

namespace MaxProductOfThree
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new int[] { -3, 1, 2, -2, 5, 6};
            Console.WriteLine(Solution(a));
        }

        public static int Solution(int[] a)
        {
            Array.Sort(a);

            int firstCase = a[0] * a[1] * a[a.Length - 1];
            int secondCase = a[a.Length - 1] * a[a.Length - 2] * a[a.Length - 3];

            return (firstCase > secondCase) ? firstCase : secondCase;
        }
    }
}
