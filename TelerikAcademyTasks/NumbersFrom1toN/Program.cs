using System;

namespace NumbersFrom1toN
{
    class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            for (int i = 0; i < input; i++)
            {
                if(i==0)
                {
                    Console.Write(i+1);
                }
                else
                {
                    Console.Write(" ");
                    Console.Write(i+1);
                }                
            }
            Console.WriteLine();
        }
    }
}
