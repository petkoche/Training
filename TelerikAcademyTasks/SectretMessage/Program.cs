using System;
using System.Text.RegularExpressions;

namespace SectretMessage
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            input = Regex.Replace(input, @"[\d-]", string.Empty);
            Console.WriteLine(Reverse(input));
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
