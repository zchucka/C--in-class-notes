using System;
using System.Collections.Generic;
using System.Text;

namespace LamdaDemo
{
	//Action delegate is similar to Func delegate except that it does not return any value.
	//It is used when the return type is void Action<int,int>
	public class ActionLambdaProgram
	{
		static void TestLambda(Action act)
		{
			act();
			Console.WriteLine("Test Lambda method");
			act();
		}
		public static void Main()
		{
			TestLambda(() => Console.WriteLine("Inside Lambda"));


			var input = Console.ReadLine().Split();

			// Both variations are EQUAL
			Action<string[]> action = Print;
			action(input);

			Console.WriteLine();

			// Both variations are EQUAL
			Action<string[]> lambdaAction = arr => Console.WriteLine(string.Join(Environment.NewLine, arr));
			lambdaAction(input);

		}

		public static void Print(string[] array)
		{
			Console.WriteLine(string.Join(Environment.NewLine, array));
		}
	}
}
