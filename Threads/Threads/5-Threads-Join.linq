<Query Kind="Program" />

public class Program
{
	public static void Main()
	{
		//initialize a thread class object 
        //And pass your custom method name to the constructor parameter
        Thread t = new Thread(Speak);
        //start running your thread
        //dont forget to pass your parameter for the Speak method in 
        //Thread's Start method below
        t.Start("Hello World!");
        //wait until Thread "t" is done with its execution.You can wait for another thread to end by calling its Join method. 
        t.Join();
		
        Console.WriteLine("Press Enter to terminate!");
		
	}
		
		
		private static void Speak(object s)
	    {
	        //your code here that you want to run parallel
	        //most of the time it will be a CPU bound operation
	        string say = s as string;
	        Console.WriteLine(say);
			for (int i = 0; i < 1000; i++) Console.Write ("y");
	    } // <-- this line is where thread exit and shutdown
		
	
}