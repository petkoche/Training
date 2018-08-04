using System;
using System.Linq;

namespace Chains
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxCount = ChainCount("1-1,3-5,5-2,2-3,2-4");
            Console.WriteLine(maxCount);

            maxCount = ChainCount("1-1,2-4,3-1,5-2,1-3");
            Console.WriteLine(maxCount);

            maxCount = ChainCount("");
            Console.WriteLine(maxCount);

            maxCount = ChainCount("1-1");
            Console.WriteLine(maxCount);

            maxCount = ChainCount("1-2,1-2");
            Console.WriteLine(maxCount);

            maxCount = ChainCount("3-2,2-1,1-4,4-4,5-4,4-2,2-1");
            Console.WriteLine(maxCount);

            maxCount = ChainCount("5-5,5-5,4-4,5-5,5-5,5-5,5-5,5-5,5-5,5-5");
            Console.WriteLine(maxCount);

            maxCount = ChainCount("1-1,3-5,5-5,5-4,4-2,1-3");
            Console.WriteLine(maxCount);

            maxCount = ChainCount("1-2,2-2,3-3,3-4,4-5,1-1,1-2");
            Console.WriteLine(maxCount);
        }

        private static int ChainCount(string chain)
        {
            var elements = chain.Split(',');
            int maxCount = 1;
            int counter = 1;

            for (int i = 0; i < elements.Count() - 1; i++)
            {            
                if (elements[i][2] == elements[i + 1][0])
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }

                if (counter > maxCount)
                {
                    maxCount = counter;
                }
            }

            return (maxCount == 1) ? 0 : maxCount;
        }

    }
}
