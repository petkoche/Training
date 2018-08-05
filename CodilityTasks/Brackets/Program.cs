using System;

namespace Nesting
{
    class Program
    {
        static void Main(string[] args)
        {
            string brackets = "(()(())())";
            Console.WriteLine(Solution(brackets));
        }

        public static int Solution(string brackets)
        {
            int openingCount = 0;
            int closingCount = 0;

            for (int i = 0; i < brackets.Length; i++)
            {
                if (brackets[i] == '(')
                {
                    openingCount++;
                }
                else
                {
                    closingCount++;
                }

                if(openingCount < closingCount)
                {
                    return 0;
                }
            }

            return (openingCount == closingCount) ? 1 : 0;
        }
    }
}
