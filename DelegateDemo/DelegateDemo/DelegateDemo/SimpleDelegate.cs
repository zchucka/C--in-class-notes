using System;
using System.Collections.Generic;
using System.Text;
/*
 * Follow the below steps to create a Delegate

Define  : Define a Delegate
Create  : Create a Delegate object to assign
Refer or Point : Point to reference of a Method
Invoke : Finally Call or Invoke the delegate
 */
namespace DelegateDemo
{
    //Define a Delegate
    delegate void SumDelegate(int x, int y); // this is a delegate to a method that should have two 

    class SimpleDelegate
    {
        public static void ExecuteMain()
        { 
            //Declare Delegate Object
            SumDelegate objDelegate = null;

            //Point to method reference in our example "Sum"
            objDelegate=Sum;

            //Final Step Invoke Delegate
            objDelegate.Invoke(10, 20);
            Console.Read();
        }
        static void Sum(int x, int y)
        {
            Console.WriteLine((x + y).ToString());
        }
    }

}
