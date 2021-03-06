<Query Kind="Program" />

/*
When two threads simultaneously contend a lock (in this case, locker), one thread waits, or blocks, until the lock becomes available. 
In this case, it ensures only one thread can enter the critical section of code at a time,
and “Done” will be printed just once. Code that's protected in such a manner — from indeterminacy in a multithreading context — is called thread-safe.*/
class ThreadSafe 
{
  static bool done;
  static readonly object locker = new object();
 
  static void Main()
  {
    new Thread (Go).Start();
    Go();
  }
 
  static void Go()
  {
    lock (locker)
    {
      if (!done) { Console.WriteLine ("Done"); done = true; }
    }
  }
}