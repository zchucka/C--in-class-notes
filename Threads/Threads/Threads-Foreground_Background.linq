<Query Kind="Program" />

class PriorityTest
{
  static void Main ()
  {
  	string[] args = new string[] {"Hello World!","Hi"};
    Thread worker = new Thread ( () => Console.WriteLine("Completed") );
    if (args.Length > 0) worker.IsBackground = true; //else thread is foreground
    worker.Start();
	worker.Join();
  }
}