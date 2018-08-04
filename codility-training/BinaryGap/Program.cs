using System;

namespace BinaryGap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution(32));
            Console.WriteLine(Solution(1041));
            Console.WriteLine(Solution(529));
            Console.WriteLine(Solution(561892));
            Console.WriteLine(Solution(9));
        }

        public static int Solution(int N)
        {
            var binary = Convert.ToString(N, 2);
            var res = binary.Trim('0');
            int maxGap = 0;
            int gapCounter = 0;

            for (int i = 0; i < binary.Length; i++)
            {                
                if(binary[i] == '0')
                {
                    gapCounter++;
                }
                else
                {
                    if(gapCounter > maxGap)
                    {
                        maxGap = gapCounter;                        
                    }
                    gapCounter = 0;
                }
            }
            return maxGap;
        }
        
    }
}
