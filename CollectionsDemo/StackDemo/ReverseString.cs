using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDemo
{
    class ReverseString
    {
        public static void ReverseStringMain()
        {
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            foreach (char symbol in input)
            {
                stack.Push(symbol);
            }

            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
            Console.WriteLine();
        }
    }
}
