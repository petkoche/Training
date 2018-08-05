using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] couples = new string[] { "I>F", "W>I", "S>W", "F>T" };   
            Console.WriteLine(PrintWord(couples));// SWIFT
            couples = new string[] { "P>E", "E>R", "R>U" };
            Console.WriteLine(PrintWord(couples));// SWIFT
            couples = new string[] { "I>N", "A>I", "P>A", "S>P" };
            Console.WriteLine(PrintWord(couples));// SWIFT
        }

        public static string PrintWord(string[] couples)
        {
            var pairs = new List<string>();
            foreach (var item in couples)
            {
                pairs.Add(item[0].ToString() + item[2].ToString());
            }

            string res = pairs[0];

            for (int i = 1; i < couples.Length; i++)
            {
                if (res.Contains(pairs[i][0]))
                {
                    var disposable = res.Split(pairs[i][0]);
                    if (disposable.Length == 1)
                    {
                        res = disposable[0] + pairs[i];
                    }
                    else
                    {
                        res = disposable[0] + pairs[i] + disposable[1];
                    }
                }
                else if (res.Contains(pairs[i][1]))
                {
                    var disposable = res.Split(pairs[i][1]);
                    if (disposable.Length == 1)
                    {
                        res = disposable[0] + pairs[i];
                    }
                    else
                    {
                        res = disposable[0] + pairs[i] + disposable[1];
                    }
                    
                }
            }

            return res;
        }
    }
}
