<Query Kind="Program" />

//Threads share data if they have a common reference to the same object instance. For example:
// If, however, we swap the order of statements in the Go method, the odds of “Done” being printed twice go up dramatically:
class ThreadTest
{
  bool done;
 static bool done1;    // Static fields are shared between all threads
  static void Main()
  {
//    ThreadTest tt = new ThreadTest();   // Create a common instance
//    new Thread (tt.Go).Start();
//    tt.Go();
	
	new Thread (Go1).Start();
    Go1();
  }
 
  // Note that Go is now an instance method
  void Go() 
  {
     if (!done) { done = true; Console.WriteLine ("Done"); }
  }
  static void Go1()
  {
    if (!done1) { Console.WriteLine ("Done1"); done1 = true;  }
  }
}