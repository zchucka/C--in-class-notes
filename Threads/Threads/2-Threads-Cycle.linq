<Query Kind="Program" />

//A separate copy of the cycles variable is created on each thread's memory stack, and so the output is, predictably, ten question marks.
static void Main() 
{
  new Thread (Go).Start();      // Call Go() on a new thread
  Go();                         // Call Go() on the main thread
}
 
static void Go()
{
  // Declare and use a local variable - 'cycles'
  for (int cycles = 0; cycles < 5; cycles++) Console.Write ('?');
}