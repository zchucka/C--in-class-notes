using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDemo
{
    class MatchingBrackets
    {
        public static void MatchingBracketsMain()
        {
            string input = Console.ReadLine();
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    stack.Push(i);
                }
                if (input[i] == ')')
                {
                    int startIndex = stack.Pop();
                    string expression = input.Substring(startIndex, i - startIndex + 1);
                    Console.WriteLine(expression);
                }
            }
        }
    }
}
