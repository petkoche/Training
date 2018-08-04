using System;
using System.Collections.Generic;

namespace MostFrequent
{
    class Program
    {
        static void Main()
        {
            short n = short.Parse(Console.ReadLine());
            List<short> numbers = new List<short>();

            for (int i = 0; i < n; i++)
            {
                numbers.Add(short.Parse(Console.ReadLine()));
            }

            numbers.Sort();
            byte currentSequence = 1;
            byte largestRepeatingSequence = 1;
            short repeatingNumber = 0;

            for (short i = 1; i < n; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentSequence++;
                    if (currentSequence > largestRepeatingSequence)
                    {
                        largestRepeatingSequence = currentSequence;
                        repeatingNumber = numbers[i];
                    }
                }
                else
                {
                    currentSequence = 1;
                }
            }
            Console.WriteLine("{0} ({1} times)", repeatingNumber, largestRepeatingSequence);
        }
    }
}
