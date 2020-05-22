using System;
using System.Collections.Generic;
using System.Text;

namespace AnanymousDemo
{
    class ActionParam
    {
        // Action - c# - Using void return types with new Func<T, TResult>
        public static void ApplyAction(string str, Action<string> innerAction, Action<string, Action<string>> wrapperAction)
        {
            wrapperAction(str, innerAction);
        }
        public static void Main()
        {
            int alpha = 451;
            Action<string> innerAction = (str) =>
            {
                str += " omega";
                Console.WriteLine("innerAction: {0}", str);
                Console.WriteLine("innerAction: Scope testing {0}", alpha);
            };
            Action<string, Action<string>> wrapperAction = (str, subAction) =>
            {
                Console.WriteLine("Before: {0}", str);
                subAction(str); // no return value
                Console.WriteLine("After : {0}", str);
            };
            ApplyAction("alpha", innerAction, wrapperAction);
        }
    }
}