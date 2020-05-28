<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

public class Program
{
	public static void Main(string[] args)
	{
		List<int> list = new List<int>();
		list.AddRange(new int[] {1034, 1200, 1300, 1400, 1201}); //1034, 1200, 1300, 1400, 1201
		
		// create a bunch of threads
		List<Thread> threads = new List<Thread>();
        list.ForEach(x => threads.Add(new Thread(() => ThreadMethod(x))));
		
		// start them
		// function causes them to be printed in numeric order
		threads.ForEach(x => x.Start());
		
		// wait for them to finish
		threads.ForEach(x => x.Join());
		
		// this will not print untill all threads have completed
		Console.WriteLine("End");
	}

	private static void ThreadMethod(int i)
	{
		Thread.Sleep(i);
		Console.WriteLine("Thread: " + i);
	}
}