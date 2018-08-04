using System;
using System.Collections.Generic;

namespace Game
{
    class Program
    {
        static void Main()
        {
            string num = Console.ReadLine();
            int a = (int)Char.GetNumericValue(num[0]);
            int b = (int)Char.GetNumericValue(num[1]);
            int c = (int)Char.GetNumericValue(num[2]);
            List<int> calc = new List<int>();
            calc.Add(a + b + c);
            calc.Add(a * b + c);
            calc.Add(a + b * c);
            calc.Add(a * b * c);
            calc.Sort();

            Console.WriteLine(calc[3]);
        }
    }
}
