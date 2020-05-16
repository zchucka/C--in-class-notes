//1. Declaration
using System;
//A single cast delegate holds the reference of only single method
public delegate int MyDelagate(int a, int b); //delegates having same signature as method 

public class Example
{
    // methods to be assigned and called by delegate
    public int Sum(int a, int b)
    {
        return a + b;
    }

    public int Difference(int a, int b)
    {
        return a - b;
    }
}
class SingleCast
{
   public static void ExecuteMain()
    {
        Example obj = new Example();

        // 2. Instantiation : As a single cast delegate
        MyDelagate sum = new MyDelagate(obj.Sum);
        MyDelagate diff = new MyDelagate(obj.Difference);

        // 3.Invocation
        Console.WriteLine("Sum of two integer is = " + sum(10, 20));
        Console.WriteLine("Difference of two integer is = " + diff(20, 10));
    }
}