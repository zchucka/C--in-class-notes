<Query Kind="Statements" />

for (int i = 0; i < 10; i++)
  new Thread (() => Console.Write (i)).Start();
  

for (int i = 0; i < 10; i++)
{
  int temp = i;
  new Thread (() => Console.Write (temp)).Start();
}

//Because both lambda expressions capture the same text variable, t2 is printed twice:

string text = "t1";
Thread t1 = new Thread ( () => Console.WriteLine (text) );
 
text = "t2";
Thread t2 = new Thread ( () => Console.WriteLine (text) );
 
t1.Start();
t2.Start();