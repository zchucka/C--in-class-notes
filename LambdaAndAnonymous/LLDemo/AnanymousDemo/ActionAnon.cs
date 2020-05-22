using System;
using System.Collections.Generic;
using System.Text;

namespace AnanymousDemo
{
    class ActionAnon
    {
        Action<string> strTarget = new Action<string>(StringTarget);
        strTarget("Hello");

        static void StringTarget(string arg)
        {
            //No longer needed because I passed an anonymous method doing the same thing! stringParam => Console.WriteLine(stringParam)
            Console.WriteLine(arg);
        }

        Action<string> strTarget1 = new Action<string>(delegate (string stringParam) { Console.WriteLine(stringParam); }); //anonymous method the long way.
        strTarget1("Hello");

        Action<string> strTarget2 = (stringParam) => Console.WriteLine(stringParam); //anonymous method using lambda expression. Without delegate keyword.
        strTarget2("Hello");

        //pass action object to a method.
        MethodThatTakesActionAsParam(strTarget);
        static void MethodThatTakesActionAsParam(Action<string> action)
        {
            action("action this");
        }

    }
}
