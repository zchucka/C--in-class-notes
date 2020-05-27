<Query Kind="Program" />

public class Program
{
	public static void Main()		
	{
		Thread[] arrT = new Thread[2];
		arrT[0] = new Thread(new ThreadStart(new Program().TestThread1));
		arrT[1] = new Thread(new ThreadStart(new Program().TestThread2));
		foreach(Thread th in arrT) {
			th.Start();
		}
		
		Console.ReadLine();
	}
	
	private void TestThread1()
	{
		int count=0;
		while(count++<50)
		{
			Console.WriteLine("Thread 1 executed {0} times.",count);
			Thread.Sleep(1);
		}
	}
	private void TestThread2()
	{
		int count=0;
		while(count++<50)
		{
			Console.WriteLine("Thread 2 executed {0} times.",count);
			Thread.Sleep(1);
		}
	}
}