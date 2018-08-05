using System;
using System.Linq;

namespace PassingCars
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 0, 1, 0, 1, 1};
            Console.WriteLine(Solution(a));
            a = new int[] { 0, 0, 0, 0, 0 };
            Console.WriteLine(Solution(a));
        }

        public static int Solution(int[] a)
        {
            int result = 0;
            int returningCars = a.Where(x => x == 1).ToList().Count();

            for (int i = 0; i < a.Length; i++)
            {
                if(a[i] == 0)
                {
                    result += returningCars;
                }
                else
                {
                    returningCars--;
                }
            }

            // int will overflow
            return (result > 1000000000 || result < 0) ? -1 : result;
        }
    }
}
