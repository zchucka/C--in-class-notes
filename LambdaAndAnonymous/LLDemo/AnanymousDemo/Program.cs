using System;
using System.Collections.Generic;

namespace AnanymousDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Anonymous method
            var f1 = new { Name = "Mango", Kilos = 3 };
            Console.WriteLine("{0} is {1}", f1.Name, f1.Kilos);

            //Action delegate is similar to Func delegate except that it does not return any value.
            //It is used when the return type is void Action<int,int>
            //Action<string> strTarget = new Action<string>(StringTarget); //no anonymous method.
            //Action<string> strTarget = new Action<string>(delegate(string stringParam){Console.WriteLine(stringParam);}); //anonymous method the long way.
            Action<string> strTarget = (stringParam) => Console.WriteLine(stringParam); //anonymous method using lambda expression. Without delegate keyword.
            MethodThatTakesActionAsParam(strTarget);
            //Action Delegate with anonymous method

        }
        static void StringTarget(string arg)
        {
            //No longer needed because I passed an anonymous method doing the same thing! stringParam => Console.WriteLine(stringParam)
            Console.WriteLine(arg);

        }
        static void MethodThatTakesActionAsParam(Action<string> action)
        {
            action("action this");
        }
    }

	




}
