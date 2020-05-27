<Query Kind="Program" />

public class Program
{
	private static int WorkCount = 10;
	public static void Main()
	{
		  var threads = new List<Thread>();
            for (int p = 0; p < 50; p++)
            {              
                threads.Add(new Thread(Parse));
            }
            // Start them all
            var inc = 0;
            foreach (var thread in threads)
            {
                thread.Start(inc);
                inc++;
            }
            // Wait for completion
            foreach (var thread in threads)
            {
                thread.Join();
            }
	}
private static void Parse(object arg)
        {
	 
	  Console.WriteLine();
	  Console.WriteLine(arg);
            var FromPage = (int)arg * WorkCount;
            var ToPage = FromPage + WorkCount;
            for (var i = FromPage; i < ToPage; i++)
            {
				Console.Write(i + " ");
            }
	
        }
}