using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDemo
{
    class Program
    {
        public static object QueueDemo { get; private set; }

        static void Main(string[] args)
        {
            //  GenericStack.GenericStackMain();
            //ReverseString.ReverseStringMain();
            //MatchingBrackets.MatchingBracketsMain();
			stackAndqueue();

			Console.ReadKey();
        }

        public static void stackAndqueue()
        {
			Stack<int> stack = new Stack<int>();
			Queue<string> que = new Queue<string>();

			//Add item to Stack & Queue
			stack.Push(1);
			stack.Push(2);

			que.Enqueue("Ganesh");
			que.Enqueue("Matt");

			Console.WriteLine("Contains:{0}", stack.Contains(1));

			//Copy to Array

			int[] intArr = stack.ToArray();

			Console.Write("Stack to Array:");
			foreach (var i in intArr)
			{
				Console.Write("{0} ", i);
			}

			//Stack Print
			Console.WriteLine();
			Console.WriteLine("Stack:");
			while (stack.Count > 0)
			{
				Console.WriteLine(stack.Pop());
			}




			//Queue Print
			Console.WriteLine("Queue Count before Dequeue:" + que.Count);
			while (que.Count > 0)
			{
				Console.WriteLine(que.Dequeue());
			}
			Console.WriteLine("Queue Count:" + que.Count);
			//Reset the collection
			que.Enqueue("Mercury");
			que.Enqueue("Venus");
			que.Enqueue("Earth");
			Console.WriteLine("Queue Count:" + que.Count);
			//Required namespace : using System.Linq;
			while (que.Any())
				Console.WriteLine(que.Dequeue());
			Console.WriteLine("Queue Count:" + que.Count);
		}
	}
}
