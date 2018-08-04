using System;
using System.Linq;

namespace Numerology
{
    class Program
    {
        public static int[] cifri = new int[10];

        static void Main(string[] args)
        {
            var number = Console.ReadLine();

            Calc(number);

            Console.Write(String.Join(" ", cifri.ToArray()));
            Console.WriteLine();
        }

        public static void Calc(string number)
        {
            if (number.Length == 1)
            {
                cifri[int.Parse(number)] += 1;
            }

            for (int i = 0; i < number.Length - 1; i++)
            {
                int a = int.Parse(number[i].ToString());
                int b = int.Parse(number[i + 1].ToString());

                var d = (a + b) * (a ^ b) % 10;

                Calc(number.Substring(0, i) + d + number.Substring(i + 2));
            }
        }
    }
}
