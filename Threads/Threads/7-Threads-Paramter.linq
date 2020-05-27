<Query Kind="Program" />

static void Main()
{
  Thread t = new Thread (Print);
  t.Start ("Hello from t!");
}
 
static void Print (object messageObj)
{
  string message = (string) messageObj;   // We need to cast here
  Console.WriteLine (message);
}

/*
This works because Thread’s constructor is overloaded to accept either of two delegates:

public delegate void ThreadStart();
public delegate void ParameterizedThreadStart (object obj);
The limitation of ParameterizedThreadStart is that it accepts only one argument. And because it’s of type object, it usually needs to be cast.
*/