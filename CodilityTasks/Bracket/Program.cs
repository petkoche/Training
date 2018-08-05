using System;
using System.Collections;
using System.Collections.Generic;

namespace Bracket
{
    class Program
    {
        static void Main(string[] args)
        {
            string nesting = "{[()()]}";
            Console.WriteLine(Solution(nesting));
            nesting = "([)()]";
            Console.WriteLine(Solution(nesting));
            nesting = "{{{";
            Console.WriteLine(Solution(nesting));
            nesting = "({{({}[]{})}}[]{})";
            Console.WriteLine(Solution(nesting));
        }

        public static int Solution(string S)
        {
            Dictionary<string, string> matched = new Dictionary<string, string>();
            matched.Add("]", "[");
            matched.Add("}", "{");
            matched.Add(")", "(");

            List<string> pushElement = new List<string>();
            pushElement.Add("[");
            pushElement.Add("{");
            pushElement.Add("(");

            Stack stack = new Stack();

            foreach (char c in S)
            {
                if (pushElement.Contains(c.ToString()))
                {
                    stack.Push(c.ToString());
                }                    
                else if (stack.Count == 0)
                {
                    return 0;
                }                    
                else if (!stack.Pop().Equals(matched[c.ToString()]))
                {
                    return 0;
                }
            }

            if (stack.Count == 0)
            {
                return 1;
            }               

            return 0;
        }
    }
}
