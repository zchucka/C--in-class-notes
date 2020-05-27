<Query Kind="Program" />



public class Program
{
	public static void Main()
	{
		Console.WriteLine("Hello World");
		Thread T=new Thread(TestThread); 
		T.Start();
		Thread T2=new Thread(TestThread2); 
		T2.Start();
		Console.WriteLine("End");
	}
	private static void TestThread()
	{
		Console.WriteLine("Test Thread 1");
	}
	private static void TestThread2()
	{
		Console.WriteLine("Test Thread 2");
	}
}