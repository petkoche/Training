using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distinct
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 2, 1, 1, 2, 3, 1 };
            Console.WriteLine(Solution(a));
        }

        public static int Solution(int[] a)
        {
            var res = new HashSet<int>();
            for (int i = 0; i < a.Length; i++)
            {
                res.Add(a[i]);
            }

            return res.Count();
        }
    }
}
