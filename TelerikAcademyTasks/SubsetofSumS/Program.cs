using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubsetofSumS
{
    class Program
    {
        static void Main()
        {
            short s = short.Parse(Console.ReadLine());
            short[] numbers = Console.ReadLine().Split(' ').Select(short.Parse).ToArray();

            foreach (var num in numbers)
            {

            }


 //           for each i from 1 to N do
 //                   let T be a list consisting of xi + y, for all y in S
                 
 //                   let U be the union of T and S
                 
 //                   sort U
                 
 //                   make S empty
                 
 //                   let y be the smallest element of U
                 
 //                   add y to S
 //                   for each element z of U in increasing order do
 //                       //trim the list by eliminating numbers close to one another
 //                       //and throw out elements greater than s
 //                       if y + cs / N < z ≤ s, set y = z and add z to S
 //if S contains a number between (1 − c)s and s, output yes, otherwise no
        }
    }
}
