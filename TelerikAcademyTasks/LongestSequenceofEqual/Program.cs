using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestSequenceofEqual
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                numbers.Add(currentNumber);
            }
            
            int currentSequence = 1;
            int largestRepeatingSequence = 1;

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentSequence++;
                    if (currentSequence > largestRepeatingSequence)
                    {
                        largestRepeatingSequence = currentSequence;
                    }
                }
                else
                {
                    currentSequence = 1;
                }
            }
            Console.WriteLine(largestRepeatingSequence);
        }
    }
}
