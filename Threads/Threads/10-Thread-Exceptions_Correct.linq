<Query Kind="Expression" />

/*
You need an exception handler on all thread entry methods in production applications — just as you do (usually at a higher level, in the execution stack) on your main thread. 
An unhandled exception causes the whole application to shut down. With an ugly dialog!
*/
public static void Main()
{
   new Thread (Go).Start();
}
 
static void Go()
{
  try
  {
    // ...
    throw null;    // The NullReferenceException will get caught below
    // ...
  }
  catch (Exception ex)
  {
    // Typically log the exception, and/or signal another thread
    // that we've come unstuck
    // ...
  }
}