<Query Kind="Program" />

/* As we saw in the introduction, threads are created using the Thread class’s constructor, passing in a ThreadStart delegate which indicates where execution should begin. 
Here’s how the ThreadStart delegate is defined:

public delegate void ThreadStart();

Calling Start on the thread then sets it running.
The thread continues until its method returns, at which point the thread ends. Here’s an example, using the expanded C# syntax for creating a TheadStart delegate:*/
class ThreadTest
{
  static void Main() 
  {
    Thread t = new Thread (new ThreadStart (Go));
 
    t.Start();   // Run Go() on the new thread.
    Go();        // Simultaneously run Go() in the main thread.
  }
 
  static void Go()
  {
    Console.WriteLine ("hello!");
  }
}